using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;
using Just_Learning_SQL.getFoldersAndLecturesFromServer;
using Just_Learning_SQL.Models;


namespace Just_Learning_SQL.UserComponents
{
    public partial class LectionTopic : UserControl
    {
        KeyWordsForInteractiveTopic keyWords = new KeyWordsForInteractiveTopic();

        string pkName = Dns.GetHostName() + "/" + Environment.UserName;

        public LectionTopic()
        {
            InitializeComponent();

            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "Текстовый файл(*.pdf,*.txt,*.docx)|*.pdf;*.txt,;*.docx|Изображение|*.png";
        }

        private void openFileButton_Click(object sender, EventArgs e)
        {
            if (queryBox.Text != "")
            {
                if (queryBox.Text.Length > 10)//что-бы не кидали пустые ответы, если что убрать
                {
                    if (fioTextBox.Text != "")
                    {
                        nameFileLabel.Text = "Выбран файл: Ответ из текстового поля";
                    }
                    else MessageBox.Show("Вы не указали ФИО");

                }
                else MessageBox.Show("В поле слишком мало символов"); //изменить если что текст 
            }
            else
            {
                startOpenFileDialog();
            }
        }

        private async void sendFileButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.FileName != "")
            {
                if (Path.GetExtension(openFileDialog1.FileName) == ".png")
                {
                    //Отправка ответа в виде картинки
                    await QueryForServer.CreateAnswerAsync(new Answer()
                    {
                        LessonId = 1, //доделать
                        SNM = fioTextBox.Text,
                        PKNumber = pkName,
                        AnswerType = "Image",
                        Image =  File.ReadAllBytes(openFileDialog1.FileName)

                    }); 
                }
                else
                {
                    //Отправка ответа в виде файла
                    await QueryForServer.CreateAnswerAsync(new Answer()
                    {
                        LessonId = 1,
                        SNM = fioTextBox.Text,
                        PKNumber = pkName,
                        AnswerType = "File",
                        FileName = Path.GetFileNameWithoutExtension(openFileDialog1.FileName),
                        File = await QueryForServer.FileToByteArray(openFileDialog1.FileName)

                    }); 
                }
            }
            else
            {
                //"Отправка ответа в виде стринг
                await QueryForServer.CreateAnswerAsync(new Answer()
                {
                    LessonId = 1, // доделать хуйню с парсингом номера лекции
                    SNM = fioTextBox.Text,
                    PKNumber = pkName,
                    AnswerType = "Text",
                    Text = queryBox.Text

                });
            }
            openFileDialog1.FileName = "";
            nameFileLabel.Text = "Выбран файл:";
            fioTextBox.Text = "";
        }
        private void startOpenFileDialog()
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            if (Path.GetExtension(openFileDialog1.FileName) == ".png")
            {
                Image img = Image.FromFile(openFileDialog1.FileName);
                if (img.Width < 500 && img.Height < 500)
                {
                    openFileDialog1.FileName = "";
                    MessageBox.Show("Картинка должна быть минимум 500x500 пикселей");
                }

            }
            nameFileLabel.Text = "Выбран файл:  " + Path.GetFileNameWithoutExtension(openFileDialog1.FileName) + Path.GetExtension(openFileDialog1.FileName);





        }

        protected override void OnLoad(EventArgs e)
        {
            // MessageBox.Show(srcLecture);
            //axAcroPDF1.src = srcLecture;
            // axAcroPDF1.setShowToolbar(false);
            webBrowser1.Url = new Uri(LectureInfo.srcLecture);
            base.OnLoad(e);
        }

        private void queryBox_TextChanged(object sender, EventArgs e)
        {
            coloringKeyText(keyWords.keyWords, Color.Coral);
        }

        private void coloringKeyText(string[] text, Color color)
        {
            int position_save = queryBox.SelectionStart;

            foreach (string key in text)
            {
                int i = 0;
                while (i <= queryBox.Text.Length - key.Length)
                {
                    i = queryBox.Text.ToLower().IndexOf(key, i);
                    if (i < 0) break;

                    queryBox.SelectionStart = i;
                    queryBox.SelectionLength = key.Length;
                    queryBox.SelectionColor = color;

                    i += key.Length;

                    queryBox.SelectionStart = position_save;
                    queryBox.SelectionColor = Color.Black;
                }
            }

        }


        #region перекрас бордера ричбокса
        bool hover = false;
        bool focus = false;
        private void layoutForRichBox_Paint(object sender, PaintEventArgs e)
        {
            if (focus && !hover)
            {

                Pen p = new Pen(Color.FromArgb(4, 148, 221));
                Graphics g = e.Graphics;

                int variance = 1;
                g.DrawRectangle(p, new Rectangle(queryBox.Location.X - variance, queryBox.Location.Y - variance, queryBox.Width + variance, queryBox.Height + variance));


            }
            if (hover)
            {
                Pen p = new Pen(Color.FromArgb(94, 186, 233));
                Graphics g = e.Graphics;

                int variance = 1;
                g.DrawRectangle(p, new Rectangle(queryBox.Location.X - variance, queryBox.Location.Y - variance, queryBox.Width + variance, queryBox.Height + variance));
            }
            else if (!hover && !focus)
            {
                Pen p = new Pen(Color.FromArgb(213, 218, 223));
                Graphics g = e.Graphics;

                int variance = 1;
                g.DrawRectangle(p, new Rectangle(queryBox.Location.X - variance, queryBox.Location.Y - variance, queryBox.Width + variance, queryBox.Height + variance));
            }

        }

        private void queryBox_Enter(object sender, EventArgs e)
        {
            hover = false;
            focus = true;
            this.Refresh();
        }

        private void queryBox_Leave(object sender, EventArgs e)
        {
            focus = false;
            this.Refresh();
        }

        private void queryBox_MouseEnter(object sender, EventArgs e)
        {
            hover = true;
            this.Refresh();

        }

        private void queryBox_MouseLeave(object sender, EventArgs e)
        {
            hover = false;
            this.Refresh();
        }

        #endregion


    }
}
