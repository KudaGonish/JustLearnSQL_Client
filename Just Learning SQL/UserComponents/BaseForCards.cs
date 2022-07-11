using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using Just_Learning_SQL.DemoExam;
using Just_Learning_SQL.Properties;
using Just_Learning_SQL.createFoldersAndLecture;
using Just_Learning_SQL.creatingElements;

namespace Just_Learning_SQL.UserComponents
{
    public partial class BaseForCards : UserControl
    {
        public BaseForCards()
        {
            InitializeComponent();
        }

        public string directoryInfo { get; set; }
        public bool isDemoExam { get; set; }

        List<Folder_LectureModel> folder_LectureModels;

        private void BaseForCards_Load(object sender, EventArgs e)
        {
            folder_LectureModels = (List<Folder_LectureModel>)ReadFileData.getFolderAndLectures(new DirectoryInfo(directoryInfo),
                                                               new List<Folder_LectureModel>());
            int i = 10;
            foreach (var folder in folder_LectureModels)
            {
                var label = CreatingLabel.CreateLabel(folder.nameFolder, i);
                i += 35;
                label.Click += Label_Click;

                themePanel.Controls.Add(label);
            }

        }


        private void Label_Click(object sender, EventArgs e)
        {
            itemPanel.Controls.Clear();


            var label = (Label)sender;
            var folder = folder_LectureModels.FirstOrDefault(n => n.nameFolder == label.Text);
            
            foreach (var file in folder.nameLecures)
            {
                itemPanel.Controls.Add(new TopicCard
                {
                    backImage = Resources.c_,
                    lectureName = file.Name.Remove(file.Name.Length - 4, 4),
                    notCutFileName = file.Name,
                    lectureFullName = file.FullName,
                    isDemoExam = isDemoExam
                });
            }
        }


    }
}

