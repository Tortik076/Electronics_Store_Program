namespace Electronics_Store_Program
{
    partial class Admin_add_Category
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
            this.textBox_Product_price = new System.Windows.Forms.TextBox();
            this.button_add_User = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_Product_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_Product_price
            // 
            this.textBox_Product_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Product_price.Location = new System.Drawing.Point(29, 198);
            this.textBox_Product_price.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.textBox_Product_price.Multiline = true;
            this.textBox_Product_price.Name = "textBox_Product_price";
            this.textBox_Product_price.Size = new System.Drawing.Size(471, 166);
            this.textBox_Product_price.TabIndex = 57;
            // 
            // button_add_User
            // 
            this.button_add_User.BackColor = System.Drawing.Color.BurlyWood;
            this.button_add_User.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_add_User.Location = new System.Drawing.Point(70, 389);
            this.button_add_User.Margin = new System.Windows.Forms.Padding(4);
            this.button_add_User.Name = "button_add_User";
            this.button_add_User.Size = new System.Drawing.Size(384, 68);
            this.button_add_User.TabIndex = 56;
            this.button_add_User.Text = "Добавить категорию";
            this.button_add_User.UseVisualStyleBackColor = false;
            this.button_add_User.Click += new System.EventHandler(this.button_add_User_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(162, 33);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(233, 25);
            this.label6.TabIndex = 55;
            this.label6.Text = "Добваление категории!";
            // 
            // textBox_Product_name
            // 
            this.textBox_Product_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Product_name.Location = new System.Drawing.Point(254, 119);
            this.textBox_Product_name.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.textBox_Product_name.Name = "textBox_Product_name";
            this.textBox_Product_name.Size = new System.Drawing.Size(216, 30);
            this.textBox_Product_name.TabIndex = 54;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(24, 167);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 25);
            this.label3.TabIndex = 51;
            this.label3.Text = "Описание категории:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(27, 119);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 25);
            this.label2.TabIndex = 50;
            this.label2.Text = "Название категории:";
            // 
            // Admin_add_Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(527, 500);
            this.Controls.Add(this.textBox_Product_price);
            this.Controls.Add(this.button_add_User);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_Product_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Admin_add_Category";
            this.Text = "Admin_add_Category";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Product_price;
        private System.Windows.Forms.Button button_add_User;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_Product_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}