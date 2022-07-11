using System;
using System.Drawing;
using System.Windows.Forms;
using Just_Learning_SQL.UserComponents;

namespace Just_Learning_SQL
{
    public partial class InteractiveTopic : UserControl
    {
        KeyWordsForInteractiveTopic keyWords = new KeyWordsForInteractiveTopic();

        public string srcLecture { get; set; }

        public InteractiveTopic()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
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
            else if(!hover && !focus)
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

        private void InteractiveTopic_Load(object sender, EventArgs e)
        {
            axAcroPDF1.src = srcLecture;
            axAcroPDF1.setShowToolbar(false);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string text = "select ID,NAME,COST from Таблица1 where ID = 2";

            if(text == queryBox.Text)
            {
                answerTextBox.Text = String.Format("2" + Environment.NewLine +
                                                   "Xiaomi redmi note 7" + Environment.NewLine +
                                                   "25 000");
            }
            else
            {
                answerTextBox.Text = "Запрос написан не корректно";
            }
        }
    }
}
