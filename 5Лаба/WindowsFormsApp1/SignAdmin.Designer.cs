namespace WindowsFormsApp1
{
    partial class SignAdmin
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
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_login = new System.Windows.Forms.TextBox();
            this.comboBox_Role = new System.Windows.Forms.ComboBox();
            this.textBox_pwd = new System.Windows.Forms.TextBox();
            this.textBox_FIO = new System.Windows.Forms.TextBox();
            this.textBox_phone = new System.Windows.Forms.TextBox();
            this.button_Enter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Corbel Light", 12F, System.Drawing.FontStyle.Italic);
            this.label5.Location = new System.Drawing.Point(116, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "Роль";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Corbel Light", 12F, System.Drawing.FontStyle.Italic);
            this.label1.Location = new System.Drawing.Point(110, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Corbel Light", 12F, System.Drawing.FontStyle.Italic);
            this.label2.Location = new System.Drawing.Point(103, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 19);
            this.label2.TabIndex = 13;
            this.label2.Text = "Пароль";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Corbel Light", 12F, System.Drawing.FontStyle.Italic);
            this.label3.Location = new System.Drawing.Point(33, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 19);
            this.label3.TabIndex = 14;
            this.label3.Text = "ФИО(Полностью)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Corbel Light", 12F, System.Drawing.FontStyle.Italic);
            this.label4.Location = new System.Drawing.Point(22, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 19);
            this.label4.TabIndex = 15;
            this.label4.Text = "Номер телефона +7";
            // 
            // textBox_login
            // 
            this.textBox_login.Location = new System.Drawing.Point(167, 112);
            this.textBox_login.Name = "textBox_login";
            this.textBox_login.Size = new System.Drawing.Size(129, 20);
            this.textBox_login.TabIndex = 16;
            // 
            // comboBox_Role
            // 
            this.comboBox_Role.FormattingEnabled = true;
            this.comboBox_Role.Items.AddRange(new object[] {
            "Администратор",
            "Поставщик",
            "Клиент"});
            this.comboBox_Role.Location = new System.Drawing.Point(167, 85);
            this.comboBox_Role.Name = "comboBox_Role";
            this.comboBox_Role.Size = new System.Drawing.Size(129, 21);
            this.comboBox_Role.TabIndex = 17;
            // 
            // textBox_pwd
            // 
            this.textBox_pwd.Location = new System.Drawing.Point(167, 138);
            this.textBox_pwd.Name = "textBox_pwd";
            this.textBox_pwd.Size = new System.Drawing.Size(129, 20);
            this.textBox_pwd.TabIndex = 18;
            // 
            // textBox_FIO
            // 
            this.textBox_FIO.Location = new System.Drawing.Point(167, 164);
            this.textBox_FIO.Name = "textBox_FIO";
            this.textBox_FIO.Size = new System.Drawing.Size(129, 20);
            this.textBox_FIO.TabIndex = 19;
            // 
            // textBox_phone
            // 
            this.textBox_phone.Location = new System.Drawing.Point(167, 190);
            this.textBox_phone.Name = "textBox_phone";
            this.textBox_phone.Size = new System.Drawing.Size(129, 20);
            this.textBox_phone.TabIndex = 20;
            // 
            // button_Enter
            // 
            this.button_Enter.BackColor = System.Drawing.Color.FloralWhite;
            this.button_Enter.Font = new System.Drawing.Font("Corbel Light", 12F, System.Drawing.FontStyle.Italic);
            this.button_Enter.Location = new System.Drawing.Point(120, 236);
            this.button_Enter.Name = "button_Enter";
            this.button_Enter.Size = new System.Drawing.Size(223, 52);
            this.button_Enter.TabIndex = 21;
            this.button_Enter.Text = "Добавить пользователя";
            this.button_Enter.UseVisualStyleBackColor = false;
            this.button_Enter.Click += new System.EventHandler(this.button_Enter_Click);
            // 
            // SignAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.гослинг_4;
            this.ClientSize = new System.Drawing.Size(627, 369);
            this.Controls.Add(this.button_Enter);
            this.Controls.Add(this.textBox_phone);
            this.Controls.Add(this.textBox_FIO);
            this.Controls.Add(this.textBox_pwd);
            this.Controls.Add(this.comboBox_Role);
            this.Controls.Add(this.textBox_login);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "SignAdmin";
            this.Text = "Регистрация нового пользователя";
            this.Load += new System.EventHandler(this.SignAdmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_login;
        private System.Windows.Forms.ComboBox comboBox_Role;
        private System.Windows.Forms.TextBox textBox_pwd;
        private System.Windows.Forms.TextBox textBox_FIO;
        private System.Windows.Forms.TextBox textBox_phone;
        private System.Windows.Forms.Button button_Enter;
    }
}