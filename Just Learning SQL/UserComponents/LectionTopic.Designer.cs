namespace Just_Learning_SQL.UserComponents
{
    partial class LectionTopic
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
            this.sendFileButton = new Guna.UI2.WinForms.Guna2Button();
            this.fioTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.nameFileLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.layoutForRichBox = new System.Windows.Forms.Panel();
            this.queryBox = new System.Windows.Forms.RichTextBox();
            this.openFileButton = new Guna.UI2.WinForms.Guna2Button();
            this.layoutForRichBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // sendFileButton
            // 
            this.sendFileButton.Animated = true;
            this.sendFileButton.CheckedState.Parent = this.sendFileButton;
            this.sendFileButton.CustomImages.Parent = this.sendFileButton;
            this.sendFileButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(148)))), ((int)(((byte)(221)))));
            this.sendFileButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sendFileButton.ForeColor = System.Drawing.Color.White;
            this.sendFileButton.HoverState.Parent = this.sendFileButton;
            this.sendFileButton.Location = new System.Drawing.Point(807, 594);
            this.sendFileButton.Margin = new System.Windows.Forms.Padding(0);
            this.sendFileButton.Name = "sendFileButton";
            this.sendFileButton.ShadowDecoration.Parent = this.sendFileButton;
            this.sendFileButton.Size = new System.Drawing.Size(193, 46);
            this.sendFileButton.TabIndex = 4;
            this.sendFileButton.Text = "Отправить файл";
            this.sendFileButton.Click += new System.EventHandler(this.sendFileButton_Click);
            // 
            // fioTextBox
            // 
            this.fioTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fioTextBox.DefaultText = "";
            this.fioTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.fioTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.fioTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.fioTextBox.DisabledState.Parent = this.fioTextBox;
            this.fioTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.fioTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(148)))), ((int)(((byte)(221)))));
            this.fioTextBox.FocusedState.Parent = this.fioTextBox;
            this.fioTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fioTextBox.ForeColor = System.Drawing.Color.Black;
            this.fioTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(186)))), ((int)(((byte)(233)))));
            this.fioTextBox.HoverState.Parent = this.fioTextBox;
            this.fioTextBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.fioTextBox.Location = new System.Drawing.Point(588, 439);
            this.fioTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.fioTextBox.Multiline = true;
            this.fioTextBox.Name = "fioTextBox";
            this.fioTextBox.PasswordChar = '\0';
            this.fioTextBox.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.fioTextBox.PlaceholderText = "Фамилия и имя первого студента";
            this.fioTextBox.SelectedText = "";
            this.fioTextBox.ShadowDecoration.Parent = this.fioTextBox;
            this.fioTextBox.Size = new System.Drawing.Size(412, 59);
            this.fioTextBox.TabIndex = 6;
            this.fioTextBox.TabStop = false;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(148)))), ((int)(((byte)(221)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(588, 408);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(276, 22);
            this.guna2HtmlLabel1.TabIndex = 8;
            this.guna2HtmlLabel1.Text = "Обязательные для заполнение поле:";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.gunaLabel1.ForeColor = System.Drawing.Color.Red;
            this.gunaLabel1.Location = new System.Drawing.Point(591, 498);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(314, 51);
            this.gunaLabel1.TabIndex = 10;
            this.gunaLabel1.Text = "*Если вас несколько за пк, введите ФИ по образцу:\r\nИванов Иван;Степанов Сергей\r\n\r" +
    "\n";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.Margin = new System.Windows.Forms.Padding(0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(588, 640);
            this.webBrowser1.TabIndex = 11;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // nameFileLabel
            // 
            this.nameFileLabel.BackColor = System.Drawing.Color.Transparent;
            this.nameFileLabel.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.nameFileLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(148)))), ((int)(((byte)(221)))));
            this.nameFileLabel.Location = new System.Drawing.Point(591, 569);
            this.nameFileLabel.Name = "nameFileLabel";
            this.nameFileLabel.Size = new System.Drawing.Size(112, 22);
            this.nameFileLabel.TabIndex = 12;
            this.nameFileLabel.Text = "Выбран файл: ";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(148)))), ((int)(((byte)(221)))));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(588, 43);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(78, 22);
            this.guna2HtmlLabel2.TabIndex = 14;
            this.guna2HtmlLabel2.Text = "Решение:";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.gunaLabel2.ForeColor = System.Drawing.Color.Red;
            this.gunaLabel2.Location = new System.Drawing.Point(591, 322);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(306, 17);
            this.gunaLabel2.TabIndex = 15;
            this.gunaLabel2.Text = "*Вы можете отправить ответ не прикрепляя файл";
            // 
            // layoutForRichBox
            // 
            this.layoutForRichBox.BackColor = System.Drawing.Color.White;
            this.layoutForRichBox.Controls.Add(this.queryBox);
            this.layoutForRichBox.Location = new System.Drawing.Point(588, 68);
            this.layoutForRichBox.Margin = new System.Windows.Forms.Padding(0);
            this.layoutForRichBox.Name = "layoutForRichBox";
            this.layoutForRichBox.Size = new System.Drawing.Size(412, 256);
            this.layoutForRichBox.TabIndex = 16;
            this.layoutForRichBox.Paint += new System.Windows.Forms.PaintEventHandler(this.layoutForRichBox_Paint);
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
            this.queryBox.TextChanged += new System.EventHandler(this.queryBox_TextChanged);
            this.queryBox.Enter += new System.EventHandler(this.queryBox_Enter);
            this.queryBox.Leave += new System.EventHandler(this.queryBox_Leave);
            this.queryBox.MouseEnter += new System.EventHandler(this.queryBox_MouseEnter);
            this.queryBox.MouseLeave += new System.EventHandler(this.queryBox_MouseLeave);
            // 
            // openFileButton
            // 
            this.openFileButton.Animated = true;
            this.openFileButton.CheckedState.Parent = this.openFileButton;
            this.openFileButton.CustomImages.Parent = this.openFileButton;
            this.openFileButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(148)))), ((int)(((byte)(221)))));
            this.openFileButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.openFileButton.ForeColor = System.Drawing.Color.White;
            this.openFileButton.HoverState.Parent = this.openFileButton;
            this.openFileButton.Location = new System.Drawing.Point(588, 594);
            this.openFileButton.Margin = new System.Windows.Forms.Padding(0);
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.ShadowDecoration.Parent = this.openFileButton;
            this.openFileButton.Size = new System.Drawing.Size(193, 46);
            this.openFileButton.TabIndex = 17;
            this.openFileButton.Text = "Выбрать файл";
            this.openFileButton.Click += new System.EventHandler(this.openFileButton_Click);
            // 
            // LectionTopic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.openFileButton);
            this.Controls.Add(this.layoutForRichBox);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.nameFileLabel);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.fioTextBox);
            this.Controls.Add(this.sendFileButton);
            this.ForeColor = System.Drawing.Color.Black;
            this.Location = new System.Drawing.Point(0, 10);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "LectionTopic";
            this.Size = new System.Drawing.Size(1000, 640);
            this.layoutForRichBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button sendFileButton;
        private Guna.UI2.WinForms.Guna2TextBox fioTextBox;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Guna.UI2.WinForms.Guna2HtmlLabel nameFileLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private System.Windows.Forms.Panel layoutForRichBox;
        private System.Windows.Forms.RichTextBox queryBox;
        private Guna.UI2.WinForms.Guna2Button openFileButton;
    }
}
