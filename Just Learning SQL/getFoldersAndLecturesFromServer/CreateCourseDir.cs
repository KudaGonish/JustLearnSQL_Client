using Just_Learning_SQL.Models;
using Just_Learning_SQL.Properties;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Just_Learning_SQL.getFoldersAndLecturesFromServer
{
    class CreateCourseDir
    {
        public async Task CreateCoursesDir()
        {
            await QueryForServer.RunAsync();
            // обрабатываем результаты запроса на сервер, создаем папки,подпапки и лекции


            string path =  @"appSettings\";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            DirectoryInfo dirInfo;
            if (Directory.Exists(Settings.Default.pathForCoursesFromServer))
            {
                dirInfo = new DirectoryInfo(Settings.Default.pathForCoursesFromServer);

                foreach (var item in dirInfo.GetDirectories())
                {
                    item.Delete(true);
                }
                dirInfo = null;
            }
            else
            {
                Directory.CreateDirectory(Settings.Default.pathForCoursesFromServer);
            }

            StreamWriter streamWriter = new StreamWriter(path+"settings.txt", false);

            foreach (var course in CoursesListInfo.courses)
            {
                course.Title.Replace("/", ",").Replace("|", ",").Replace(":", ",").Replace("*", ",").Replace("?", ",").Replace("<", ",").Replace(">", ","); // понять как запихнуть сюда блядский \

                dirInfo = new DirectoryInfo(Settings.Default.pathForCoursesFromServer + course.Title);


                dirInfo.Create();
                //очистка лекций и курсов перед заполнением
                var modules = CoursesListInfo.modules.Where(c => c.CourseId == course.CourseId).ToList();

                foreach (var module in modules)
                {
                    dirInfo.CreateSubdirectory(module.Title);

                    var lessons = CoursesListInfo.lessons.Where(m => m.ModuleId == module.ModuleId).ToList();


                    foreach (var lesson in lessons)
                    {

                        await QueryForServer.GetFileAsync($"{Settings.Default.pathForCoursesFromServer}/{ course.Title}/{ module.Title}/{lesson.FileName}", lesson.LectureFile);

                        streamWriter.WriteLine(lesson.FileName + " " + lesson.LectureId);
                    }
                }
            }

            streamWriter.Close();
        }
    }
}
