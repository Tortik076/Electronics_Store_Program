
namespace Electronics_Store_Program
{
    partial class log_in
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(log_in));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_log_in = new System.Windows.Forms.Button();
            this.textBox_login = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox_showPass = new System.Windows.Forms.PictureBox();
            this.pictureBox_hidePass = new System.Windows.Forms.PictureBox();
            this.label_For_capcha1 = new System.Windows.Forms.Label();
            this.label_For_capcha2 = new System.Windows.Forms.Label();
            this.textBoxl_For_capcha = new System.Windows.Forms.TextBox();
            this.label_For_capcha3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_showPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_hidePass)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(35, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Логин:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(19, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Пароль:";
            // 
            // button_log_in
            // 
            this.button_log_in.BackColor = System.Drawing.Color.BurlyWood;
            this.button_log_in.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_log_in.Location = new System.Drawing.Point(24, 314);
            this.button_log_in.Name = "button_log_in";
            this.button_log_in.Size = new System.Drawing.Size(370, 36);
            this.button_log_in.TabIndex = 2;
            this.button_log_in.Text = "Вход";
            this.button_log_in.UseVisualStyleBackColor = false;
            this.button_log_in.Click += new System.EventHandler(this.button_log_in_Click);
            // 
            // textBox_login
            // 
            this.textBox_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_login.Location = new System.Drawing.Point(144, 89);
            this.textBox_login.Name = "textBox_login";
            this.textBox_login.Size = new System.Drawing.Size(186, 30);
            this.textBox_login.TabIndex = 3;
            // 
            // textBox_password
            // 
            this.textBox_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_password.Location = new System.Drawing.Point(144, 150);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.PasswordChar = '*';
            this.textBox_password.Size = new System.Drawing.Size(186, 30);
            this.textBox_password.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(34, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(304, 36);
            this.label3.TabIndex = 5;
            this.label3.Text = "Добро пожаловать!";
            // 
            // pictureBox_showPass
            // 
            this.pictureBox_showPass.Image = global::Electronics_Store_Program.Properties.Resources.icone_hide_password2;
            this.pictureBox_showPass.Location = new System.Drawing.Point(336, 151);
            this.pictureBox_showPass.Name = "pictureBox_showPass";
            this.pictureBox_showPass.Size = new System.Drawing.Size(39, 39);
            this.pictureBox_showPass.TabIndex = 7;
            this.pictureBox_showPass.TabStop = false;
            this.pictureBox_showPass.Click += new System.EventHandler(this.pictureBox_showPass_Click);
            // 
            // pictureBox_hidePass
            // 
            this.pictureBox_hidePass.Image = global::Electronics_Store_Program.Properties.Resources.icone_show_password2;
            this.pictureBox_hidePass.Location = new System.Drawing.Point(336, 151);
            this.pictureBox_hidePass.Name = "pictureBox_hidePass";
            this.pictureBox_hidePass.Size = new System.Drawing.Size(39, 39);
            this.pictureBox_hidePass.TabIndex = 6;
            this.pictureBox_hidePass.TabStop = false;
            this.pictureBox_hidePass.Visible = false;
            this.pictureBox_hidePass.Click += new System.EventHandler(this.pictureBox_hidePass_Click);
            // 
            // label_For_capcha1
            // 
            this.label_For_capcha1.AutoSize = true;
            this.label_For_capcha1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_For_capcha1.Location = new System.Drawing.Point(19, 215);
            this.label_For_capcha1.Name = "label_For_capcha1";
            this.label_For_capcha1.Size = new System.Drawing.Size(334, 25);
            this.label_For_capcha1.TabIndex = 8;
            this.label_For_capcha1.Text = "Для проложения решите пример:";
            this.label_For_capcha1.Visible = false;
            // 
            // label_For_capcha2
            // 
            this.label_For_capcha2.AutoSize = true;
            this.label_For_capcha2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_For_capcha2.Location = new System.Drawing.Point(12, 258);
            this.label_For_capcha2.Name = "label_For_capcha2";
            this.label_For_capcha2.Size = new System.Drawing.Size(73, 25);
            this.label_For_capcha2.TabIndex = 9;
            this.label_For_capcha2.Text = "2 + 2 =";
            this.label_For_capcha2.Visible = false;
            // 
            // textBoxl_For_capcha
            // 
            this.textBoxl_For_capcha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxl_For_capcha.Location = new System.Drawing.Point(116, 255);
            this.textBoxl_For_capcha.Name = "textBoxl_For_capcha";
            this.textBoxl_For_capcha.Size = new System.Drawing.Size(38, 30);
            this.textBoxl_For_capcha.TabIndex = 10;
            this.textBoxl_For_capcha.Visible = false;
            // 
            // label_For_capcha3
            // 
            this.label_For_capcha3.AutoSize = true;
            this.label_For_capcha3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_For_capcha3.Location = new System.Drawing.Point(172, 260);
            this.label_For_capcha3.Name = "label_For_capcha3";
            this.label_For_capcha3.Size = new System.Drawing.Size(238, 25);
            this.label_For_capcha3.TabIndex = 11;
            this.label_For_capcha3.Text = "Неверно решен приемр!";
            this.label_For_capcha3.Visible = false;
            // 
            // log_in
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(422, 368);
            this.Controls.Add(this.label_For_capcha3);
            this.Controls.Add(this.textBoxl_For_capcha);
            this.Controls.Add(this.label_For_capcha2);
            this.Controls.Add(this.label_For_capcha1);
            this.Controls.Add(this.pictureBox_showPass);
            this.Controls.Add(this.pictureBox_hidePass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_login);
            this.Controls.Add(this.button_log_in);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "log_in";
            this.Text = "Вход";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_showPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_hidePass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_log_in;
        private System.Windows.Forms.TextBox textBox_login;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox_hidePass;
        private System.Windows.Forms.PictureBox pictureBox_showPass;
        private System.Windows.Forms.Label label_For_capcha1;
        private System.Windows.Forms.Label label_For_capcha2;
        private System.Windows.Forms.TextBox textBoxl_For_capcha;
        private System.Windows.Forms.Label label_For_capcha3;
    }
}