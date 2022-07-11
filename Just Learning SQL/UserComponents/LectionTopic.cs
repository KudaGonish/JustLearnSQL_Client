using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using Just_Learning_SQL.getFoldersAndLecturesFromServer;
using Just_Learning_SQL.Models;
using Microsoft.Win32;

namespace Just_Learning_SQL.UserComponents
{
    public partial class LectionTopic : UserControl
    {

        //lectureNameNotCut
        KeyWordsForInteractiveTopic keyWords = new KeyWordsForInteractiveTopic();

        List<LectionModelForAnswer> lectionsIdAndNameList = new List<LectionModelForAnswer>();

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
            if (fioTextBox.Text.Length > 6)
            {
                if (openFileDialog1.FileName != "")
                {

                    if (Path.GetExtension(openFileDialog1.FileName) == ".png")
                    {
                        //Отправка ответа в виде картинки
                        await QueryForServer.CreateAnswerAsync(new Answer()
                        {
                            LectureId = lectionsIdAndNameList.First(i => i.FileName == LectureInfo.fileName).LectureId,
                            LFP = fioTextBox.Text,
                            PCNumber = Environment.UserName,
                            AnswerType = "Image",
                            AnswerImage = File.ReadAllBytes(openFileDialog1.FileName)
                        });
                        MessageBox.Show("Ответ успешно отправлен!");


                    }
                    else
                    {
                        //Отправка ответа в виде файла
                        await QueryForServer.CreateAnswerAsync(new Answer()
                        {
                            LectureId = lectionsIdAndNameList.First(i => i.FileName == LectureInfo.fileName).LectureId,
                            LFP = fioTextBox.Text,
                            PCNumber = Environment.UserName,
                            AnswerType = "File",
                            AnswerFileName = Path.GetFileNameWithoutExtension(openFileDialog1.FileName),
                            AnswerFile = await QueryForServer.FileToByteArray(openFileDialog1.FileName)

                        });
                        MessageBox.Show("Ответ успешно отправлен!");
                    }

                }
                else
                {
                    //"Отправка ответа в виде стринг
                    if (queryBox.Text.Length > 10)
                    {
                        await QueryForServer.CreateAnswerAsync(new Answer()
                        {
                            LectureId = lectionsIdAndNameList.First(i => i.FileName == LectureInfo.fileName).LectureId,
                            LFP = fioTextBox.Text,
                            PCNumber = Environment.UserName,
                            AnswerType = "Text",
                            AnswerText = queryBox.Text

                        });
                        MessageBox.Show("Ответ успешно отправлен!");
                    }
                    else
                    {
                        MessageBox.Show("Введено слишком мало символов в текстовом поле ответа");
                    }

                }
                openFileDialog1.FileName = "";
                nameFileLabel.Text = "Выбран файл:";
                fioTextBox.Text = "";
            }
            else
            {
                MessageBox.Show("Вы не указали фамилию");
            }
           
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

            string path = @"appSettings\settings.txt";

            var list = File.ReadAllLines(path).ToList();
            foreach (var item in list)
            {
                lectionsIdAndNameList.Add(new LectionModelForAnswer
                {
                    LectureId = Convert.ToInt32(item.Split(' ')[1]),
                    FileName = item.Split(' ')[0]
                });
            }

            RegistryKey adobe = Registry.LocalMachine.OpenSubKey("Software").OpenSubKey("Adobe");

            if (adobe != null)
            {
                RegistryKey acrobatReader = adobe.OpenSubKey("Acrobat Reader");

                if (acrobatReader == null)
                {
                    MessageBox.Show("На вашем компьютере не установлен Adobe Acrobat Reader" + Environment.NewLine + "Для продолжения работы, установите Acrobate Reader");
                }
            }

            string[] fromat = LectureInfo.srcLecture.Split('.');


            try
            {
                axAcroPDF1.setShowToolbar(false);
                axAcroPDF1.ContextMenuStrip = null;
                axAcroPDF1.src = LectureInfo.srcLecture;
            }
            catch
            {
                MessageBox.Show("Вы пытались открыть не верный формат файла" + Environment.NewLine + "Сообщите преподователю");
            }

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

        private void LectionTopic_Load(object sender, EventArgs e)
        {


        }
    }
}
