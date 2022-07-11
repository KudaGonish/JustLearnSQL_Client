using Just_Learning_SQL.Models;
using Just_Learning_SQL.Properties;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Just_Learning_SQL.getFoldersAndLecturesFromServer
{
    public class MyClient
    {
        private static HttpClient Client;

        private static HttpClient Initialization()
        {
            Client = new HttpClient();

            Client.BaseAddress = new Uri("http://learneasyapi100-001-site1.ftempurl.com/");
            Client.DefaultRequestHeaders.Accept.Clear();
            Client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            return Client;
        }

        public static HttpClient GetClient()
        {
            return Initialization();
        }
    }

    class QueryForServer
    {
        private static HttpClient Client;

        public static async Task RunAsync()
        {

            Client = MyClient.GetClient();

            if (await GetStatusAsync("api/GetCourses") == "OK" &&
                await GetStatusAsync("api/GetModules") == "OK" &&
                await GetStatusAsync("api/GetLectures") == "OK")
            {
                try
                {
                    CoursesListInfo.courses = await GetListCoursesAsync("api/GetCourses");
                    CoursesListInfo.modules = await GetListModulesAsync("api/GetModules");
                    CoursesListInfo.lessons = await GetListLessonsAsync("api/GetLectures");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка получения курсов " + ex.Message.ToString());
                }
                Client.Dispose();
            }
            else
            {
                MessageBox.Show("Ошибка. Сервер не доступен");
                Client.Dispose();
            }
        }
        private static async Task<string> GetStatusAsync(string apiMethod)
        {
            HttpResponseMessage response = await Client.GetAsync(string.Concat(Client.BaseAddress + apiMethod));

            if (response.IsSuccessStatusCode)
                return response.StatusCode.ToString();

            return "Bad Request!";
        }

        private static async Task<List<Course>> GetListCoursesAsync(string apiMethod)
        {
            List<Course> courses = null;

            HttpResponseMessage response = await Client.GetAsync(string.Concat(Client.BaseAddress + apiMethod));

            if (response.IsSuccessStatusCode)
            {
                courses = await response.Content.ReadAsAsync<List<Course>>();
            }

            return courses;
        }

        private static async Task<List<Module>> GetListModulesAsync(string apiMethod)
        {
            List<Module> modules = null;

            HttpResponseMessage response = await Client.GetAsync(string.Concat(Client.BaseAddress + apiMethod));

            if (response.IsSuccessStatusCode)
            {
                modules = await response.Content.ReadAsAsync<List<Module>>();
            }

            return modules;
        }

        private static async Task<List<Lecture>> GetListLessonsAsync(string apiMethod)
        {
            List<Lecture> lessons = null;

            HttpResponseMessage response = await Client.GetAsync(string.Concat(Client.BaseAddress + apiMethod));

            if (response.IsSuccessStatusCode)
            {
                lessons = await response.Content.ReadAsAsync<List<Lecture>>();
            }

            return lessons;
        }

        public static async Task<string> GetFileAsync(string path, byte[] file)
        {
            try
            {
                File.WriteAllBytes(path, file);
                if (file != null) return "успешно";
                return "не успешно";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

                throw new Exception(ex.ToString());
            }

        }

        public static async Task<byte[]> FileToByteArray(string fileName)
        {
            byte[] buff = null;

            FileStream fs = new FileStream(fileName,
                                           FileMode.Open,
                                           FileAccess.Read);

            var br = new BinaryReader(fs);

            long numBytes = new FileInfo(fileName).Length;

            buff = br.ReadBytes((int)numBytes);

            return buff;
        }

        public static async Task<string> CreateAnswerAsync(Answer answer)
        {

            Client = MyClient.GetClient();
            HttpResponseMessage response =
                await Client.PostAsJsonAsync(string.Concat(Client.BaseAddress + "api/PostNewAnswer"), answer);
            
            return response.StatusCode.ToString();
        }
    }
}
