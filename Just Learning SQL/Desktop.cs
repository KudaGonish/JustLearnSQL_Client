using Just_Learning_SQL.UserComponents;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Just_Learning_SQL.creatingElements;
using Guna.UI2.WinForms;
using Just_Learning_SQL.Properties;

namespace Just_Learning_SQL
{
    public partial class Desktop : Form
    {
        public Desktop()
        {
            InitializeComponent();
        }

        DirectoryInfo directoryInfo = new DirectoryInfo(Settings.Default.pathForCoursesFromServer);
        private void Desktop_Load(object sender, EventArgs e)
        {
            //хуйня что бы кнопки на панельке крутились
            panelCources.MouseWheel += PanelCources_MouseWheel;

            int i = 0;

            foreach (var folder in directoryInfo.EnumerateFileSystemInfos())
            {
                var button = СreatingButton.CreateGuna2Button(folder.Name, i);
                i += 120;
                button.Click += ButtonCoursesFromServer_Click;
                panelCources.Controls.Add(button);
            }

            mainPanel.Controls.Add(new WelcomeScreen());

        }

        private void ButtonCoursesFromServer_Click(object sender, EventArgs e)
        {
            var button = (Guna2Button)sender;
            mainPanel.Controls.Clear();

            mainPanel.Controls.Add(new BaseForCards
            {
                directoryInfo = Settings.Default.pathForCoursesFromServer + "/" + button.Name,
                isDemoExam = false
            });
        }

        private void PanelCources_MouseWheel(object sender, MouseEventArgs e)
        {
            //доделать эту парашу что бы она не улетала как хуй пойми что
            if (e.Delta < 0)//-120  колесиком вниз, поворот вправо/ 
            {
                foreach (Control ctrl in panelCources.Controls)
                {
                    ctrl.Location = new Point(ctrl.Location.X - 120, 10);
                }
            }
            else
            {
                foreach (Control ctrl in panelCources.Controls)
                {
                    ctrl.Location = new Point(ctrl.Location.X + 120, 10);
                }
            }

        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void demoExButton_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();

            mainPanel.Controls.Add(new BaseForCards
            {
                directoryInfo = Settings.Default.path,
                isDemoExam = true
            });
        }

        private void reloadCoursesButton_Click(object sender, EventArgs e)
        {
            var message = MessageBox.Show("Вы хотите обновить список курсов?","",MessageBoxButtons.YesNo);
            if(message == DialogResult.Yes)
            {
                Settings.Default.isFrstRun = true;
                Settings.Default.Save();
                Application.Restart();
            }
            
        }
    }
}
