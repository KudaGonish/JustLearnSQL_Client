using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Just_Learning_SQL.creatingElements
{
    public class СreatingButton
    {
        public static Guna2Button CreateGuna2Button(string nameCourse, int count)
        {
            Guna2Button button = new Guna2Button();

            button.Location = new Point(count, 10);
            button.Name = nameCourse;
            button.Text = nameCourse;
            button.BackColor = Color.Transparent;
            button.Font = new Font("Century Gothic", 11F);
            button.ForeColor = Color.FromArgb(4, 148, 221);
            button.Height = 40;
            button.Width = 120;
            button.Animated = true;
            button.FillColor = Color.White;
            button.PressedColor = Color.Black;
            button.PressedDepth = 30;
            button.TextAlign = HorizontalAlignment.Center;
            
            return button;
        }
    }
}
