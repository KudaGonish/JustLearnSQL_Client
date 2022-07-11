using Just_Learning_SQL.getFoldersAndLecturesFromServer;
using Just_Learning_SQL.Models;
using Just_Learning_SQL.Properties;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Threading;
using System.Windows.Forms;



//#5EBAE9
//#0494DD
namespace Just_Learning_SQL
{

    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        bool isFirstRun;
        private async void Splash_Load(object sender, EventArgs e)
        {
            isFirstRun = Settings.Default.isFrstRun;
            //пингуем серв и при тру запускаем мейн форму
            if (pingMainComputer())
            {
                //проверяем на первый запуск приложени
                if (isFirstRun)
                {
                    CreateCourseDir createCourseDir = new CreateCourseDir();
                    await createCourseDir.CreateCoursesDir();

                    Settings.Default.isFrstRun = false; 
                    Settings.Default.Save();
                }
                Thread openDesktop = new Thread(delegate ()
                {
                    Application.Run(new Desktop());
                });
                Close();
                openDesktop.SetApartmentState(ApartmentState.STA);
                openDesktop.Start();
            }
            else
            {
                MessageBox.Show("В данный момент сервер не доступен");
            }

            
        }

        private bool pingMainComputer()
        {
            Ping pingMainPC = null;
            PingReply pingReply = null;

            try
            {
                pingMainPC = new Ping();
                pingReply = pingMainPC.Send("learneasyapi100-001-site1.ftempurl.com");
            }
            catch
            {
                return false;
            }
            finally
            {
                if (pingMainPC != null) pingMainPC.Dispose();
            }
            return pingReply.Status == IPStatus.Success;
        }
    }
}





