namespace Just_Learning_SQL
{
    partial class Desktop
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
            this.formHandleDesktop = new XanderUI.XUIFormHandle();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.demoExButton = new Guna.UI2.WinForms.Guna2Button();
            this.panelCources = new System.Windows.Forms.Panel();
            this.formHandle2 = new XanderUI.XUIFormHandle();
            this.mainPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.reloadCoursesButton = new Guna.UI2.WinForms.Guna2Button();
            this.exitButton = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // formHandleDesktop
            // 
            this.formHandleDesktop.DockAtTop = true;
            this.formHandleDesktop.HandleControl = this.guna2Panel2;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel2.BorderColor = System.Drawing.Color.Black;
            this.guna2Panel2.Controls.Add(this.reloadCoursesButton);
            this.guna2Panel2.Controls.Add(this.demoExButton);
            this.guna2Panel2.Controls.Add(this.panelCources);
            this.guna2Panel2.Controls.Add(this.exitButton);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(0);
            this.guna2Panel2.MaximumSize = new System.Drawing.Size(0, 50);
            this.guna2Panel2.MinimumSize = new System.Drawing.Size(0, 50);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(1000, 50);
            this.guna2Panel2.TabIndex = 0;
            // 
            // demoExButton
            // 
            this.demoExButton.Animated = true;
            this.demoExButton.CheckedState.Parent = this.demoExButton;
            this.demoExButton.CustomImages.Parent = this.demoExButton;
            this.demoExButton.FillColor = System.Drawing.Color.White;
            this.demoExButton.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.demoExButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(148)))), ((int)(((byte)(221)))));
            this.demoExButton.HoverState.Parent = this.demoExButton;
            this.demoExButton.Location = new System.Drawing.Point(645, 10);
            this.demoExButton.Margin = new System.Windows.Forms.Padding(0);
            this.demoExButton.Name = "demoExButton";
            this.demoExButton.ShadowDecoration.Parent = this.demoExButton;
            this.demoExButton.Size = new System.Drawing.Size(177, 40);
            this.demoExButton.TabIndex = 5;
            this.demoExButton.Text = "Демонстрационный экзамен";
            this.demoExButton.Click += new System.EventHandler(this.demoExButton_Click);
            // 
            // panelCources
            // 
            this.panelCources.Location = new System.Drawing.Point(0, 0);
            this.panelCources.Margin = new System.Windows.Forms.Padding(0);
            this.panelCources.Name = "panelCources";
            this.panelCources.Size = new System.Drawing.Size(645, 50);
            this.panelCources.TabIndex = 0;
            // 
            // formHandle2
            // 
            this.formHandle2.DockAtTop = true;
            this.formHandle2.HandleControl = this.panelCources;
            // 
            // mainPanel
            // 
            this.mainPanel.BackgroundImage = global::Just_Learning_SQL.Properties.Resources.innerShadow1;
            this.mainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 50);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.ShadowDecoration.Parent = this.mainPanel;
            this.mainPanel.Size = new System.Drawing.Size(1000, 650);
            this.mainPanel.TabIndex = 1;
            // 
            // reloadCoursesButton
            // 
            this.reloadCoursesButton.Animated = true;
            this.reloadCoursesButton.CheckedState.Parent = this.reloadCoursesButton;
            this.reloadCoursesButton.CustomImages.Parent = this.reloadCoursesButton;
            this.reloadCoursesButton.FillColor = System.Drawing.Color.White;
            this.reloadCoursesButton.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.reloadCoursesButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(148)))), ((int)(((byte)(221)))));
            this.reloadCoursesButton.HoverState.Parent = this.reloadCoursesButton;
            this.reloadCoursesButton.Image = global::Just_Learning_SQL.Properties.Resources.reloadCourse;
            this.reloadCoursesButton.ImageSize = new System.Drawing.Size(24, 24);
            this.reloadCoursesButton.Location = new System.Drawing.Point(850, 10);
            this.reloadCoursesButton.Margin = new System.Windows.Forms.Padding(0);
            this.reloadCoursesButton.Name = "reloadCoursesButton";
            this.reloadCoursesButton.ShadowDecoration.Parent = this.reloadCoursesButton;
            this.reloadCoursesButton.Size = new System.Drawing.Size(39, 40);
            this.reloadCoursesButton.TabIndex = 7;
            this.reloadCoursesButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.reloadCoursesButton.Click += new System.EventHandler(this.reloadCoursesButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Animated = true;
            this.exitButton.CheckedState.Parent = this.exitButton;
            this.exitButton.CustomImages.Parent = this.exitButton;
            this.exitButton.FillColor = System.Drawing.Color.White;
            this.exitButton.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.exitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(148)))), ((int)(((byte)(221)))));
            this.exitButton.HoverState.Parent = this.exitButton;
            this.exitButton.Image = global::Just_Learning_SQL.Properties.Resources.exit;
            this.exitButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.exitButton.Location = new System.Drawing.Point(911, 10);
            this.exitButton.Margin = new System.Windows.Forms.Padding(0);
            this.exitButton.Name = "exitButton";
            this.exitButton.ShadowDecoration.Parent = this.exitButton;
            this.exitButton.Size = new System.Drawing.Size(89, 40);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Выход";
            this.exitButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Desktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.guna2Panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Desktop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Desktop_Load);
            this.guna2Panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private XanderUI.XUIFormHandle formHandleDesktop;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Button demoExButton;
        private Guna.UI2.WinForms.Guna2Button exitButton;
        public Guna.UI2.WinForms.Guna2Panel mainPanel;
        private System.Windows.Forms.Panel panelCources;
        private Guna.UI2.WinForms.Guna2Button reloadCoursesButton;
        private XanderUI.XUIFormHandle formHandle2;
    }
}