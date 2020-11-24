namespace Just_Learning_SQL.UserComponents
{
    partial class BaseForCards
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
            this.itemPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.themePanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.SuspendLayout();
            // 
            // itemPanel
            // 
            this.itemPanel.AutoScroll = true;
            this.itemPanel.BackColor = System.Drawing.Color.White;
            this.itemPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.itemPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.itemPanel.Location = new System.Drawing.Point(250, 6);
            this.itemPanel.Margin = new System.Windows.Forms.Padding(0);
            this.itemPanel.Name = "itemPanel";
            this.itemPanel.Padding = new System.Windows.Forms.Padding(15, 35, 0, 35);
            this.itemPanel.Size = new System.Drawing.Size(750, 644);
            this.itemPanel.TabIndex = 0;
            // 
            // themePanel
            // 
            this.themePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.themePanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(236)))));
            this.themePanel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(186)))), ((int)(((byte)(251)))));
            this.themePanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.themePanel.Location = new System.Drawing.Point(0, 0);
            this.themePanel.Margin = new System.Windows.Forms.Padding(0);
            this.themePanel.Name = "themePanel";
            this.themePanel.ShadowDecoration.Parent = this.themePanel;
            this.themePanel.Size = new System.Drawing.Size(250, 650);
            this.themePanel.TabIndex = 1;
            // 
            // BaseForCards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.itemPanel);
            this.Controls.Add(this.themePanel);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "BaseForCards";
            this.Size = new System.Drawing.Size(1000, 650);
            this.Load += new System.EventHandler(this.BaseForCards_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.FlowLayoutPanel itemPanel;
        public Guna.UI2.WinForms.Guna2GradientPanel themePanel;
    }
}
