using Just_Learning_SQL.createFoldersAndLecture;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Just_Learning_SQL.DemoExam
{
    class ReadFileData
    {
       /* public List<Folder_LectureModel> folder_LectureModel = new List<Folder_LectureModel>();

        public void getFolderAndLecture(string path)
        {
            DirectoryInfo dir = new DirectoryInfo(path);

            List<string> nameLecturesList = new List<string>();

            foreach (DirectoryInfo folder in dir.EnumerateDirectories())
            {
                DirectoryInfo dirWithFilder = new DirectoryInfo(path+folder);
                
                foreach (FileInfo file in dirWithFilder.EnumerateFiles("*.pdf"))
                {
                    nameLecturesList.Add(file.Name.Remove(file.Name.Length - 4, 4));
                }

                var folder_lecture = new Folder_LectureModel()
                {
                    nameFolder = folder.Name,
                    nameLecures = nameLecturesList
                };
                
                folder_LectureModel.Add(folder_lecture); 

            }

        }*/
       


        public static object getFolderAndLectures(DirectoryInfo directoryInfoFolders,List<Folder_LectureModel> folder_LectureModels)
        {
            if(directoryInfoFolders !=null)
            {
                foreach(var dir in directoryInfoFolders.EnumerateFileSystemInfos())
                {
                    var folderAndLectureModel = new Folder_LectureModel()
                    {
                        nameFolder = dir.Name,
                        nameLecures = new DirectoryInfo(dir.FullName).EnumerateFiles().ToList()
                    };

                    folder_LectureModels.Add(folderAndLectureModel);

                }
                return folder_LectureModels;
            }
            return new List<Folder_LectureModel>();
        }
    }

}
