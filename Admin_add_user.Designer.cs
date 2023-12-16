namespace Electronics_Store_Program
{
    partial class Admin_add_user
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
            this.textBox_Staffer_Password = new System.Windows.Forms.TextBox();
            this.textBox_Staffer_Login = new System.Windows.Forms.TextBox();
            this.textBox_Staffer_FIO = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button_add_User = new System.Windows.Forms.Button();
            this.comboBox_Staffer_Access = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBox_Staffer_Password
            // 
            this.textBox_Staffer_Password.Location = new System.Drawing.Point(148, 274);
            this.textBox_Staffer_Password.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_Staffer_Password.Name = "textBox_Staffer_Password";
            this.textBox_Staffer_Password.Size = new System.Drawing.Size(288, 30);
            this.textBox_Staffer_Password.TabIndex = 22;
            // 
            // textBox_Staffer_Login
            // 
            this.textBox_Staffer_Login.Location = new System.Drawing.Point(148, 219);
            this.textBox_Staffer_Login.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_Staffer_Login.Name = "textBox_Staffer_Login";
            this.textBox_Staffer_Login.Size = new System.Drawing.Size(288, 30);
            this.textBox_Staffer_Login.TabIndex = 21;
            // 
            // textBox_Staffer_FIO
            // 
            this.textBox_Staffer_FIO.Location = new System.Drawing.Point(148, 110);
            this.textBox_Staffer_FIO.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_Staffer_FIO.Name = "textBox_Staffer_FIO";
            this.textBox_Staffer_FIO.Size = new System.Drawing.Size(288, 30);
            this.textBox_Staffer_FIO.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 274);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 25);
            this.label5.TabIndex = 18;
            this.label5.Text = "Пароль:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 219);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 25);
            this.label4.TabIndex = 17;
            this.label4.Text = "Логин:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 168);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "Доступ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 113);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "ФИО:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(113, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(323, 25);
            this.label6.TabIndex = 24;
            this.label6.Text = "Сознадние нового пользователя!";
            // 
            // button_add_User
            // 
            this.button_add_User.BackColor = System.Drawing.Color.BurlyWood;
            this.button_add_User.Location = new System.Drawing.Point(129, 362);
            this.button_add_User.Name = "button_add_User";
            this.button_add_User.Size = new System.Drawing.Size(307, 54);
            this.button_add_User.TabIndex = 25;
            this.button_add_User.Text = "Добавить пользователя";
            this.button_add_User.UseVisualStyleBackColor = false;
            this.button_add_User.Click += new System.EventHandler(this.button_add_User_Click);
            // 
            // comboBox_Staffer_Access
            // 
            this.comboBox_Staffer_Access.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Staffer_Access.FormattingEnabled = true;
            this.comboBox_Staffer_Access.Items.AddRange(new object[] {
            "admin",
            "user"});
            this.comboBox_Staffer_Access.Location = new System.Drawing.Point(148, 165);
            this.comboBox_Staffer_Access.Name = "comboBox_Staffer_Access";
            this.comboBox_Staffer_Access.Size = new System.Drawing.Size(288, 33);
            this.comboBox_Staffer_Access.TabIndex = 27;
            // 
            // Admin_add_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(588, 455);
            this.Controls.Add(this.comboBox_Staffer_Access);
            this.Controls.Add(this.button_add_User);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_Staffer_Password);
            this.Controls.Add(this.textBox_Staffer_Login);
            this.Controls.Add(this.textBox_Staffer_FIO);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Admin_add_user";
            this.Text = "Admin_add_user";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Staffer_Password;
        private System.Windows.Forms.TextBox textBox_Staffer_Login;
        private System.Windows.Forms.TextBox textBox_Staffer_FIO;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_add_User;
        private System.Windows.Forms.ComboBox comboBox_Staffer_Access;
    }
}