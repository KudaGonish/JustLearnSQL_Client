using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Just_Learning_SQL.Models;

namespace Just_Learning_SQL.UserComponents
{
    public partial class TopicCard : UserControl
    {
        public TopicCard()
        {
            InitializeComponent();
        }
        public Image backImage { get; set; }
        public string lectureName { get; set; }
        public string notCutFileName { get; set; }
        public string lectureFullName { get; set; }

        public bool isDemoExam { get; set; }
        
        public string lectionId { get; set; }

        private void TopicCard_Load(object sender, EventArgs e)
        {
            lectureNameLabel.Parent = this;
            lectureNameLabel.Text = lectureName;
            
        }

        private void TopicCard_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(backImage, 0, 0, 170, 220);
        }

        private void button_Click(object sender, EventArgs e)
        {
            var desktop = this.Parent.Parent;

            desktop.Controls.Clear();
            if(isDemoExam)
            {
                desktop.Controls.Add(new InteractiveTopic
                {
                    srcLecture = lectureFullName
                });
            }
            else
            {
                LectureInfo.srcLecture = lectureFullName;
                LectureInfo.fileName = notCutFileName;
                desktop.Controls.Add(new LectionTopic());
            }
            
            
        }
    }
}
