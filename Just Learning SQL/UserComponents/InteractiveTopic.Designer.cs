namespace Just_Learning_SQL
{
    partial class InteractiveTopic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InteractiveTopic));
            this.panel = new Guna.UI2.WinForms.Guna2Panel();
            this.axAcroPDF1 = new AxAcroPDFLib.AxAcroPDF();
            this.queryBox = new System.Windows.Forms.RichTextBox();
            this.answerTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.layoutForRichBox = new System.Windows.Forms.Panel();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).BeginInit();
            this.layoutForRichBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.axAcroPDF1);
            this.panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Margin = new System.Windows.Forms.Padding(0);
            this.panel.Name = "panel";
            this.panel.ShadowDecoration.Parent = this.panel;
            this.panel.Size = new System.Drawing.Size(588, 640);
            this.panel.TabIndex = 0;
            // 
            // axAcroPDF1
            // 
            this.axAcroPDF1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axAcroPDF1.Enabled = true;
            this.axAcroPDF1.Location = new System.Drawing.Point(0, 0);
            this.axAcroPDF1.Name = "axAcroPDF1";
            this.axAcroPDF1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDF1.OcxState")));
            this.axAcroPDF1.Size = new System.Drawing.Size(588, 640);
            this.axAcroPDF1.TabIndex = 1;
            // 
            // queryBox
            // 
            this.queryBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.queryBox.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.queryBox.ForeColor = System.Drawing.Color.Black;
            this.queryBox.Location = new System.Drawing.Point(1, 1);
            this.queryBox.Margin = new System.Windows.Forms.Padding(0);
            this.queryBox.Name = "queryBox";
            this.queryBox.Size = new System.Drawing.Size(410, 254);
            this.queryBox.TabIndex = 0;
            this.queryBox.Text = "";
            this.queryBox.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            this.queryBox.Enter += new System.EventHandler(this.queryBox_Enter);
            this.queryBox.Leave += new System.EventHandler(this.queryBox_Leave);
            this.queryBox.MouseEnter += new System.EventHandler(this.queryBox_MouseEnter);
            this.queryBox.MouseLeave += new System.EventHandler(this.queryBox_MouseLeave);
            // 
            // answerTextBox
            // 
            this.answerTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.answerTextBox.DefaultText = "";
            this.answerTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.answerTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.answerTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.answerTextBox.DisabledState.Parent = this.answerTextBox;
            this.answerTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.answerTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.answerTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(148)))), ((int)(((byte)(221)))));
            this.answerTextBox.FocusedState.Parent = this.answerTextBox;
            this.answerTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.answerTextBox.ForeColor = System.Drawing.Color.Black;
            this.answerTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(186)))), ((int)(((byte)(233)))));
            this.answerTextBox.HoverState.Parent = this.answerTextBox;
            this.answerTextBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.answerTextBox.Location = new System.Drawing.Point(588, 299);
            this.answerTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.answerTextBox.Multiline = true;
            this.answerTextBox.Name = "answerTextBox";
            this.answerTextBox.PasswordChar = '\0';
            this.answerTextBox.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.answerTextBox.PlaceholderText = "Вывод:";
            this.answerTextBox.ReadOnly = true;
            this.answerTextBox.SelectedText = "";
            this.answerTextBox.ShadowDecoration.Parent = this.answerTextBox;
            this.answerTextBox.Size = new System.Drawing.Size(412, 341);
            this.answerTextBox.TabIndex = 2;
            this.answerTextBox.TabStop = false;
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(148)))), ((int)(((byte)(221)))));
            this.guna2Button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(588, 256);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(0);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(412, 43);
            this.guna2Button1.TabIndex = 3;
            this.guna2Button1.Text = "Проверить решение";
            // 
            // layoutForRichBox
            // 
            this.layoutForRichBox.Controls.Add(this.queryBox);
            this.layoutForRichBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.layoutForRichBox.Location = new System.Drawing.Point(588, 0);
            this.layoutForRichBox.Margin = new System.Windows.Forms.Padding(0);
            this.layoutForRichBox.Name = "layoutForRichBox";
            this.layoutForRichBox.Size = new System.Drawing.Size(412, 256);
            this.layoutForRichBox.TabIndex = 4;
            this.layoutForRichBox.Paint += new System.Windows.Forms.PaintEventHandler(this.layoutForRichBox_Paint);
            // 
            // InteractiveTopic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.layoutForRichBox);
            this.Controls.Add(this.answerTextBox);
            this.Controls.Add(this.panel);
            this.Location = new System.Drawing.Point(0, 10);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "InteractiveTopic";
            this.Size = new System.Drawing.Size(1000, 640);
            this.Load += new System.EventHandler(this.InteractiveTopic_Load);
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).EndInit();
            this.layoutForRichBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panel;
        private Guna.UI2.WinForms.Guna2TextBox answerTextBox;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.RichTextBox queryBox;
        private System.Windows.Forms.Panel layoutForRichBox;
        private AxAcroPDFLib.AxAcroPDF axAcroPDF1;
    }
}
