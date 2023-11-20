namespace WindowsFormsApp1
{
    partial class Administrator
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
            this.button_sign_up = new System.Windows.Forms.Button();
            this.button_Tov_List = new System.Windows.Forms.Button();
            this.button_His = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_sign_up
            // 
            this.button_sign_up.BackColor = System.Drawing.Color.Black;
            this.button_sign_up.Font = new System.Drawing.Font("Corbel Light", 12F, System.Drawing.FontStyle.Italic);
            this.button_sign_up.ForeColor = System.Drawing.Color.White;
            this.button_sign_up.Location = new System.Drawing.Point(382, 142);
            this.button_sign_up.Name = "button_sign_up";
            this.button_sign_up.Size = new System.Drawing.Size(240, 54);
            this.button_sign_up.TabIndex = 0;
            this.button_sign_up.Text = "Список пользователей";
            this.button_sign_up.UseVisualStyleBackColor = false;
            this.button_sign_up.Click += new System.EventHandler(this.button_sign_up_Click);
            // 
            // button_Tov_List
            // 
            this.button_Tov_List.BackColor = System.Drawing.Color.Black;
            this.button_Tov_List.Font = new System.Drawing.Font("Corbel Light", 12F, System.Drawing.FontStyle.Italic);
            this.button_Tov_List.ForeColor = System.Drawing.Color.White;
            this.button_Tov_List.Location = new System.Drawing.Point(382, 214);
            this.button_Tov_List.Name = "button_Tov_List";
            this.button_Tov_List.Size = new System.Drawing.Size(240, 51);
            this.button_Tov_List.TabIndex = 1;
            this.button_Tov_List.Text = "Посмотреть список моделей";
            this.button_Tov_List.UseVisualStyleBackColor = false;
            this.button_Tov_List.Click += new System.EventHandler(this.button_Tov_List_Click);
            // 
            // button_His
            // 
            this.button_His.BackColor = System.Drawing.Color.Black;
            this.button_His.Font = new System.Drawing.Font("Corbel Light", 12F, System.Drawing.FontStyle.Italic);
            this.button_His.ForeColor = System.Drawing.Color.White;
            this.button_His.Location = new System.Drawing.Point(382, 70);
            this.button_His.Name = "button_His";
            this.button_His.Size = new System.Drawing.Size(240, 54);
            this.button_His.TabIndex = 2;
            this.button_His.Text = "Просмотреть историю входа";
            this.button_His.UseVisualStyleBackColor = false;
            this.button_His.Click += new System.EventHandler(this.button_His_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Corbel Light", 15F, System.Drawing.FontStyle.Italic);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "lalble";
            // 
            // Administrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.гослинг_для_админа;
            this.ClientSize = new System.Drawing.Size(654, 337);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_His);
            this.Controls.Add(this.button_Tov_List);
            this.Controls.Add(this.button_sign_up);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Administrator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_Tov_List;
        private System.Windows.Forms.Button button_His;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_sign_up;
    }
}