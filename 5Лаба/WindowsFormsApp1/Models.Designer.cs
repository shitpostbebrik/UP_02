namespace WindowsFormsApp1
{
    partial class Models
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
            this.button_New = new System.Windows.Forms.Button();
            this.button_Del = new System.Windows.Forms.Button();
            this.button_Change = new System.Windows.Forms.Button();
            this.button_Save = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox2_Gearbox = new System.Windows.Forms.TextBox();
            this.textBox2_Doors = new System.Windows.Forms.TextBox();
            this.textBox2_Engine = new System.Windows.Forms.TextBox();
            this.textBox2_Upholstery = new System.Windows.Forms.TextBox();
            this.textBox2_Color = new System.Windows.Forms.TextBox();
            this.textBox2_Name = new System.Windows.Forms.TextBox();
            this.textBox2_Code = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBox_Search = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // button_New
            // 
            this.button_New.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_New.Font = new System.Drawing.Font("Corbel Light", 12F, System.Drawing.FontStyle.Italic);
            this.button_New.ForeColor = System.Drawing.Color.White;
            this.button_New.Location = new System.Drawing.Point(561, 427);
            this.button_New.Name = "button_New";
            this.button_New.Size = new System.Drawing.Size(312, 38);
            this.button_New.TabIndex = 9;
            this.button_New.Text = "Новая запись";
            this.button_New.UseVisualStyleBackColor = false;
            this.button_New.Click += new System.EventHandler(this.button_New_Click);
            // 
            // button_Del
            // 
            this.button_Del.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_Del.Font = new System.Drawing.Font("Corbel Light", 12F, System.Drawing.FontStyle.Italic);
            this.button_Del.ForeColor = System.Drawing.Color.White;
            this.button_Del.Location = new System.Drawing.Point(561, 471);
            this.button_Del.Name = "button_Del";
            this.button_Del.Size = new System.Drawing.Size(312, 38);
            this.button_Del.TabIndex = 10;
            this.button_Del.Text = "Удалить запись";
            this.button_Del.UseVisualStyleBackColor = false;
            this.button_Del.Click += new System.EventHandler(this.button_Del_Click);
            // 
            // button_Change
            // 
            this.button_Change.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_Change.Font = new System.Drawing.Font("Corbel Light", 12F, System.Drawing.FontStyle.Italic);
            this.button_Change.ForeColor = System.Drawing.Color.White;
            this.button_Change.Location = new System.Drawing.Point(561, 515);
            this.button_Change.Name = "button_Change";
            this.button_Change.Size = new System.Drawing.Size(312, 38);
            this.button_Change.TabIndex = 11;
            this.button_Change.Text = "Изменить запись";
            this.button_Change.UseVisualStyleBackColor = false;
            this.button_Change.Click += new System.EventHandler(this.button_Change_Click);
            // 
            // button_Save
            // 
            this.button_Save.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_Save.Font = new System.Drawing.Font("Corbel Light", 12F, System.Drawing.FontStyle.Italic);
            this.button_Save.ForeColor = System.Drawing.Color.White;
            this.button_Save.Location = new System.Drawing.Point(561, 559);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(312, 38);
            this.button_Save.TabIndex = 12;
            this.button_Save.Text = "Сохранить запись";
            this.button_Save.UseVisualStyleBackColor = false;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Corbel Light", 12F, System.Drawing.FontStyle.Italic);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(475, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 19);
            this.label8.TabIndex = 37;
            this.label8.Text = "Модели компании";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Corbel Light", 12F, System.Drawing.FontStyle.Italic);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(176, 547);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 19);
            this.label5.TabIndex = 36;
            this.label5.Text = "Количество дверей";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Corbel Light", 12F, System.Drawing.FontStyle.Italic);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(187, 581);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 19);
            this.label6.TabIndex = 35;
            this.label6.Text = "Коробка передач";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Corbel Light", 12F, System.Drawing.FontStyle.Italic);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(155, 514);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 19);
            this.label7.TabIndex = 34;
            this.label7.Text = "Мощность двигателя";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Corbel Light", 12F, System.Drawing.FontStyle.Italic);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(262, 445);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 19);
            this.label9.TabIndex = 33;
            this.label9.Text = "Цвет";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Corbel Light", 12F, System.Drawing.FontStyle.Italic);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(251, 479);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 19);
            this.label10.TabIndex = 32;
            this.label10.Text = "Обивка";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Corbel Light", 12F, System.Drawing.FontStyle.Italic);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(155, 412);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(158, 19);
            this.label11.TabIndex = 31;
            this.label11.Text = "Наименование модели";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Corbel Light", 12F, System.Drawing.FontStyle.Italic);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(218, 379);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 19);
            this.label12.TabIndex = 30;
            this.label12.Text = "Код модели";
            // 
            // textBox2_Gearbox
            // 
            this.textBox2_Gearbox.Location = new System.Drawing.Point(321, 581);
            this.textBox2_Gearbox.Name = "textBox2_Gearbox";
            this.textBox2_Gearbox.Size = new System.Drawing.Size(88, 20);
            this.textBox2_Gearbox.TabIndex = 29;
            // 
            // textBox2_Doors
            // 
            this.textBox2_Doors.Location = new System.Drawing.Point(321, 547);
            this.textBox2_Doors.Name = "textBox2_Doors";
            this.textBox2_Doors.Size = new System.Drawing.Size(69, 20);
            this.textBox2_Doors.TabIndex = 28;
            // 
            // textBox2_Engine
            // 
            this.textBox2_Engine.Location = new System.Drawing.Point(321, 514);
            this.textBox2_Engine.Name = "textBox2_Engine";
            this.textBox2_Engine.Size = new System.Drawing.Size(69, 20);
            this.textBox2_Engine.TabIndex = 27;
            // 
            // textBox2_Upholstery
            // 
            this.textBox2_Upholstery.Location = new System.Drawing.Point(320, 479);
            this.textBox2_Upholstery.Name = "textBox2_Upholstery";
            this.textBox2_Upholstery.Size = new System.Drawing.Size(98, 20);
            this.textBox2_Upholstery.TabIndex = 26;
            // 
            // textBox2_Color
            // 
            this.textBox2_Color.Location = new System.Drawing.Point(320, 445);
            this.textBox2_Color.Name = "textBox2_Color";
            this.textBox2_Color.Size = new System.Drawing.Size(98, 20);
            this.textBox2_Color.TabIndex = 25;
            // 
            // textBox2_Name
            // 
            this.textBox2_Name.Location = new System.Drawing.Point(321, 412);
            this.textBox2_Name.Name = "textBox2_Name";
            this.textBox2_Name.Size = new System.Drawing.Size(163, 20);
            this.textBox2_Name.TabIndex = 24;
            // 
            // textBox2_Code
            // 
            this.textBox2_Code.Location = new System.Drawing.Point(321, 382);
            this.textBox2_Code.Name = "textBox2_Code";
            this.textBox2_Code.Size = new System.Drawing.Size(69, 20);
            this.textBox2_Code.TabIndex = 23;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.ErrorImage = null;
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.лупа_белая2;
            this.pictureBox2.Location = new System.Drawing.Point(577, 364);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(27, 34);
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // textBox_Search
            // 
            this.textBox_Search.Location = new System.Drawing.Point(610, 366);
            this.textBox_Search.Name = "textBox_Search";
            this.textBox_Search.Size = new System.Drawing.Size(194, 20);
            this.textBox_Search.TabIndex = 21;
            this.textBox_Search.TextChanged += new System.EventHandler(this.textBox_Search_TextChanged);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(126, 55);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(747, 276);
            this.dataGridView2.TabIndex = 20;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Corbel Light", 12F, System.Drawing.FontStyle.Italic);
            this.button2.Location = new System.Drawing.Point(879, 55);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 276);
            this.button2.TabIndex = 49;
            this.button2.Text = "Обновить";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Models
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.гослинг_2;
            this.ClientSize = new System.Drawing.Size(1101, 661);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBox2_Gearbox);
            this.Controls.Add(this.textBox2_Doors);
            this.Controls.Add(this.textBox2_Engine);
            this.Controls.Add(this.textBox2_Upholstery);
            this.Controls.Add(this.textBox2_Color);
            this.Controls.Add(this.textBox2_Name);
            this.Controls.Add(this.textBox2_Code);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.textBox_Search);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.button_Change);
            this.Controls.Add(this.button_Del);
            this.Controls.Add(this.button_New);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Models";
            this.Text = "Модели - Админ";
            this.Load += new System.EventHandler(this.Tovars_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_New;
        private System.Windows.Forms.Button button_Del;
        private System.Windows.Forms.Button button_Change;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox2_Gearbox;
        private System.Windows.Forms.TextBox textBox2_Doors;
        private System.Windows.Forms.TextBox textBox2_Engine;
        private System.Windows.Forms.TextBox textBox2_Upholstery;
        private System.Windows.Forms.TextBox textBox2_Color;
        private System.Windows.Forms.TextBox textBox2_Name;
        private System.Windows.Forms.TextBox textBox2_Code;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBox_Search;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button2;
    }
}