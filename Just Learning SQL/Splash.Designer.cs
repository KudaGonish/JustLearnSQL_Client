namespace Just_Learning_SQL
{
    partial class Splash
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.guna2WinProgressIndicator1 = new Guna.UI2.WinForms.Guna2WinProgressIndicator();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.SuspendLayout();
            // 
            // guna2WinProgressIndicator1
            // 
            this.guna2WinProgressIndicator1.AnimationSpeed = 70;
            this.guna2WinProgressIndicator1.AutoStart = true;
            this.guna2WinProgressIndicator1.CircleSize = 1F;
            this.guna2WinProgressIndicator1.Location = new System.Drawing.Point(100, 100);
            this.guna2WinProgressIndicator1.Name = "guna2WinProgressIndicator1";
            this.guna2WinProgressIndicator1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(148)))), ((int)(((byte)(221)))));
            this.guna2WinProgressIndicator1.Size = new System.Drawing.Size(200, 200);
            this.guna2WinProgressIndicator1.TabIndex = 8;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(148)))), ((int)(((byte)(221)))));
            this.gunaLabel1.Location = new System.Drawing.Point(86, 356);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(229, 22);
            this.gunaLabel1.TabIndex = 9;
            this.gunaLabel1.Text = "Проверка соединения.";
            // 
            // Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.guna2WinProgressIndicator1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Splash";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Splash_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2WinProgressIndicator guna2WinProgressIndicator1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
    }
}