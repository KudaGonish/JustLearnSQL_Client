namespace Just_Learning_SQL.UserComponents
{
    partial class WelcomeScreen
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.welcomeLabel = new Guna.UI.WinForms.GunaLabel();
            this.welcomePictureBox = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.welcomePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.BackColor = System.Drawing.Color.Transparent;
            this.welcomeLabel.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.welcomeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(148)))), ((int)(((byte)(221)))));
            this.welcomeLabel.Location = new System.Drawing.Point(242, 125);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(516, 72);
            this.welcomeLabel.TabIndex = 10;
            this.welcomeLabel.Text = "Добро пожаловать!\r\nВыберите желаемый курс сверху.";
            this.welcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // welcomePictureBox
            // 
            this.welcomePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.welcomePictureBox.Image = global::Just_Learning_SQL.Properties.Resources.welcomeScreen;
            this.welcomePictureBox.Location = new System.Drawing.Point(300, 215);
            this.welcomePictureBox.Name = "welcomePictureBox";
            this.welcomePictureBox.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.welcomePictureBox.ShadowDecoration.Parent = this.welcomePictureBox;
            this.welcomePictureBox.Size = new System.Drawing.Size(400, 400);
            this.welcomePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.welcomePictureBox.TabIndex = 1;
            this.welcomePictureBox.TabStop = false;
            this.welcomePictureBox.Click += new System.EventHandler(this.welcomePictureBox_Click);
            // 
            // WelcomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.welcomePictureBox);
            this.Location = new System.Drawing.Point(0, 10);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "WelcomeScreen";
            this.Size = new System.Drawing.Size(1000, 640);
            this.Load += new System.EventHandler(this.WelcomeScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.welcomePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2CirclePictureBox welcomePictureBox;
        private Guna.UI.WinForms.GunaLabel welcomeLabel;
    }
}
