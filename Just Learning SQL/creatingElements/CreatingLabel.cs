using System;
using System.Drawing;
using System.Windows.Forms;

namespace Just_Learning_SQL.creatingElements
{
    public class CreatingLabel
    {
        //private static int count = 10;
        public static Label CreateLabel(string text,int count)
        {
            Label label = new Label();
            label.Location = new Point(8, count);
            label.Name = text + "Label";
            label.Text = text;
            label.AutoSize = true;
            label.BackColor = Color.Transparent;
            label.ForeColor = Color.White;
            label.Font = new Font("Century Gothic", 12F);
            label.MaximumSize = new Size(250, 0);
            label.Cursor = Cursors.Hand;
            return label;
        }


    }
}
