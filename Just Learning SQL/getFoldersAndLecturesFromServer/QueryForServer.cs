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

            Client.BaseAddress = new Uri("http://learneasyapi-001-site1.ftempurl.com/");
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

            if (GetAllInfoStatusAsync("api/GetCourses").Result == System.Net.HttpStatusCode.OK &&
                GetAllInfoStatusAsync("api/GetModules").Result == System.Net.HttpStatusCode.OK &&
                GetAllInfoStatusAsync("api/GetLessons").Result == System.Net.HttpStatusCode.OK)
            {
                try
                {
                    await GetListCoursesAsync("api/GetCourses");
                    await GetListModulesAsync("api/GetModules");
                    await GetListLessonsAsync("api/GetLessons");
                }
                catch(Exception ex)
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

        private static async Task<System.Net.HttpStatusCode> GetAllInfoStatusAsync(string apiMethod)
        {
            HttpResponseMessage response = await Client.GetAsync(string.Concat(Client.BaseAddress + apiMethod));

            if (response.IsSuccessStatusCode)
                return response.StatusCode;

            return System.Net.HttpStatusCode.BadRequest;
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

        private static async Task<List<Lesson>> GetListLessonsAsync(string apiMethod)
        {
            List<Lesson> lessons = null;

            HttpResponseMessage response = await Client.GetAsync(string.Concat(Client.BaseAddress + apiMethod));

            if (response.IsSuccessStatusCode)
            {
                lessons = await response.Content.ReadAsAsync<List<Lesson>>();
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

        //    public async Task RunAsync()
        //    {
        //        //try
        //        //{
        //        //    CoursesListInfo.courses = await GetCoursesAsync("http://learneasyapi-001-site1.ftempurl.com/api/GetCourses");  ///ЗАПРЕТИТЬ ЕБУЧИЕ ДВОЕТОЧИЯ И ПОДОБНУЮ ПОЕБЕНЬ
        //        //    CoursesListInfo.modules = await GetModulesAsync("http://learneasyapi-001-site1.ftempurl.com/api/GetModules");
        //        //    CoursesListInfo.lessons = await GetLessonsAsync("http://learneasyapi-001-site1.ftempurl.com/api/GetLessons");
        //        //}
        //        //catch (Exception e)
        //        //{
        //        //    MessageBox.Show(e.Message);
        //        //}

        //        Client = MyClient.GetClient();

        //        try
        //        {
        //            CoursesListInfo.courses = await GetCoursesAsync("http://learneasyapi-001-site1.ftempurl.com/api/GetCourses");
        //            CoursesListInfo.modules = await GetModulesAsync("http://learneasyapi-001-site1.ftempurl.com/api/GetModules");
        //            CoursesListInfo.lessons = await GetLessonsAsync("http://learneasyapi-001-site1.ftempurl.com/api/GetLessons");
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show("Error! " + ex.Message.ToString());
        //        }
        //        finally
        //        {
        //            Client.Dispose();
        //        }



        //    }

        //    private static async Task<List<Course>> GetCoursesAsync(string path)
        //    {
        //        List<Course> courses = null;

        //        HttpResponseMessage response = await Client.GetAsync(path);

        //        if (response.IsSuccessStatusCode)
        //        {
        //            courses = await response.Content.ReadAsAsync<List<Course>>();
        //        }
        //        response.Dispose();
        //        return courses;
        //    }

        //    private static async Task<List<Module>> GetModulesAsync(string path)
        //    {
        //        List<Module> modules = null;

        //        HttpResponseMessage response = await Client.GetAsync(path);

        //        if (response.IsSuccessStatusCode)
        //        {
        //            modules = await response.Content.ReadAsAsync<List<Module>>();
        //        }
        //        response.Dispose();
        //        return modules;
        //    }

        //    private static async Task<List<Lesson>> GetLessonsAsync(string path)
        //    {
        //        List<Lesson> lessons = null;

        //        HttpResponseMessage response = await Client.GetAsync(path);

        //        if (response.IsSuccessStatusCode)
        //        {
        //            lessons = await response.Content.ReadAsAsync<List<Lesson>>();
        //        }
        //        response.Dispose();
        //        return lessons;
        //    }

        //    /*public static async Task<string> GetFileAsync(string path, string fileName)
        //    {
        //        try
        //        {
        //            byte[] file = null;

        //            HttpResponseMessage response = await Client.GetAsync(String.Format("http://learneasyapi-001-site1.ftempurl.com/api/FileLesson?fileName={0}", fileName));

        //            if (response.IsSuccessStatusCode)
        //            {
        //                file = await response.Content.ReadAsByteArrayAsync();
        //            }

        //            File.WriteAllBytes(path, file);

        //            if (file != null) return "успешно";
        //            response.Dispose();
        //            return "не успешно";
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show(ex.ToString());

        //            throw new Exception(ex.ToString());

        //        }
        //    }*/

        //    public static async Task<string> GetFileAsync(string path, byte[] file)
        //    {
        //        try
        //        {
        //            File.WriteAllBytes(path, file);
        //            if (file != null) return "успешно";
        //            return "не успешно";
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show(ex.ToString());

        //            throw new Exception(ex.ToString());
        //        }

        //    }


        //    public static async Task<string> CreateAnswerAsync(Answer answer)
        //    {
        //        HttpResponseMessage response =
        //            await Client.PostAsJsonAsync(string.Concat(Client.BaseAddress + "http://learneasyapi-001-site1.ftempurl.com/api/PostNewAnswer"), answer);

        //        return response.StatusCode.ToString();
        //    }

        //    public static byte[] FileToByteArray(string fileName)
        //    {
        //        byte[] buff = null;
        //        FileStream fs = new FileStream(fileName,
        //                                       FileMode.Open,
        //                                       FileAccess.Read);
        //        BinaryReader br = new BinaryReader(fs);
        //        long numBytes = new FileInfo(fileName).Length;
        //        buff = br.ReadBytes((int)numBytes);
        //        return buff;
        //    }

    }
}
