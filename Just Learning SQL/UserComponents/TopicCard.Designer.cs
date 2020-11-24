namespace Just_Learning_SQL.UserComponents
{
    partial class TopicCard
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
            this.button = new Guna.UI2.WinForms.Guna2Button();
            this.lectureNameLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.SuspendLayout();
            // 
            // button
            // 
            this.button.Animated = true;
            this.button.BackColor = System.Drawing.Color.Transparent;
            this.button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button.BorderColor = System.Drawing.Color.Transparent;
            this.button.CheckedState.Parent = this.button;
            this.button.CustomImages.Parent = this.button;
            this.button.FillColor = System.Drawing.Color.Transparent;
            this.button.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button.ForeColor = System.Drawing.Color.Transparent;
            this.button.HoverState.Parent = this.button;
            this.button.Location = new System.Drawing.Point(0, 0);
            this.button.Margin = new System.Windows.Forms.Padding(0);
            this.button.Name = "button";
            this.button.ShadowDecoration.Parent = this.button;
            this.button.Size = new System.Drawing.Size(170, 220);
            this.button.TabIndex = 5;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // lectureNameLabel
            // 
            this.lectureNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.lectureNameLabel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.lectureNameLabel.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lectureNameLabel.ForeColor = System.Drawing.Color.White;
            this.lectureNameLabel.IsContextMenuEnabled = false;
            this.lectureNameLabel.IsSelectionEnabled = false;
            this.lectureNameLabel.Location = new System.Drawing.Point(6, 7);
            this.lectureNameLabel.MaximumSize = new System.Drawing.Size(160, 0);
            this.lectureNameLabel.Name = "lectureNameLabel";
            this.lectureNameLabel.Size = new System.Drawing.Size(98, 23);
            this.lectureNameLabel.TabIndex = 8;
            this.lectureNameLabel.Text = "Основы SQL";
            // 
            // TopicCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Controls.Add(this.lectureNameLabel);
            this.Controls.Add(this.button);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(55, 0, 0, 55);
            this.Name = "TopicCard";
            this.Size = new System.Drawing.Size(170, 220);
            this.Load += new System.EventHandler(this.TopicCard_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.TopicCard_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public Guna.UI2.WinForms.Guna2HtmlLabel lectureNameLabel;
        public Guna.UI2.WinForms.Guna2Button button;
    }
}
