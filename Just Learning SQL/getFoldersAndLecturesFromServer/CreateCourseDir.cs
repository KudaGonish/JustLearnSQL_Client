using Just_Learning_SQL.Models;
using Just_Learning_SQL.Properties;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Just_Learning_SQL.getFoldersAndLecturesFromServer
{
    class CreateCourseDir
    {
        public async Task CreateCoursesDir()
        {
            QueryForServer queryForServer = new QueryForServer();
            await queryForServer.RunAsync();
            // обрабатываем результаты запроса на сервер, создаем папки,подпапки и лекции
            DirectoryInfo dirInfo;
            Directory.Delete(Settings.Default.pathForCoursesFromServer, true);
            

            foreach (var course in CoursesListInfo.courses)
            {
                course.CourseName.Replace("/", ",").Replace("|", ",").Replace(":", ",").Replace("*", ",").Replace("?", ",").Replace("<", ",").Replace(">", ","); // понять как запихнуть сюда блядский \

                dirInfo = new DirectoryInfo(Settings.Default.pathForCoursesFromServer + course.CourseName);

                //очистка лекций и курсов перед заполнением
                var modules = CoursesListInfo.modules.Where(c => c.Course == course.CourseName).ToList();

                foreach (var module in modules)
                {
                    dirInfo.CreateSubdirectory(module.ModuleName);

                    var lessons = CoursesListInfo.lessons.Where(m => m.Module == module.ModuleName).ToList();


                    foreach (var lesson in lessons)
                    {
                        await QueryForServer.GetFileAsync($"{Settings.Default.pathForCoursesFromServer}/{ course.CourseName}/{ module.ModuleName}/{lesson.FileName}", lesson.File);
                       // await File.WriteAllBytes($"{Settings.Default.pathForCoursesFromServer}/{ course.CourseName}/{ module.ModuleName}/{lesson.FileName}", lesson.File);
                    }
                }
            }
        }
    }
}
