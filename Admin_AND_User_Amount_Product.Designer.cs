namespace Electronics_Store_Program
{
    partial class Admin_AND_User_Amount_Product
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
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView_selected_product_to_add = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.button_product_selection_ADD = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_product_purchase_price = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown_product_selection = new System.Windows.Forms.NumericUpDown();
            this.comboBox_product_selection = new System.Windows.Forms.ComboBox();
            this.button_product_selection_to_dataGridView = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_selected_product_to_add)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_product_selection)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Найдите нужный товар:";
            // 
            // dataGridView_selected_product_to_add
            // 
            this.dataGridView_selected_product_to_add.AllowUserToAddRows = false;
            this.dataGridView_selected_product_to_add.AllowUserToDeleteRows = false;
            this.dataGridView_selected_product_to_add.AllowUserToResizeColumns = false;
            this.dataGridView_selected_product_to_add.AllowUserToResizeRows = false;
            this.dataGridView_selected_product_to_add.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView_selected_product_to_add.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_selected_product_to_add.Location = new System.Drawing.Point(33, 351);
            this.dataGridView_selected_product_to_add.Name = "dataGridView_selected_product_to_add";
            this.dataGridView_selected_product_to_add.ReadOnly = true;
            this.dataGridView_selected_product_to_add.RowHeadersVisible = false;
            this.dataGridView_selected_product_to_add.RowHeadersWidth = 51;
            this.dataGridView_selected_product_to_add.RowTemplate.Height = 24;
            this.dataGridView_selected_product_to_add.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView_selected_product_to_add.Size = new System.Drawing.Size(737, 229);
            this.dataGridView_selected_product_to_add.TabIndex = 3;
            this.dataGridView_selected_product_to_add.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_selected_product_to_add_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 323);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Список поставки:";
            // 
            // button_product_selection_ADD
            // 
            this.button_product_selection_ADD.BackColor = System.Drawing.Color.BurlyWood;
            this.button_product_selection_ADD.Location = new System.Drawing.Point(623, 613);
            this.button_product_selection_ADD.Name = "button_product_selection_ADD";
            this.button_product_selection_ADD.Size = new System.Drawing.Size(196, 42);
            this.button_product_selection_ADD.TabIndex = 5;
            this.button_product_selection_ADD.Text = "Провести";
            this.button_product_selection_ADD.UseVisualStyleBackColor = false;
            this.button_product_selection_ADD.Click += new System.EventHandler(this.button_product_selection_ADD_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox_product_purchase_price);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.numericUpDown_product_selection);
            this.groupBox1.Controls.Add(this.comboBox_product_selection);
            this.groupBox1.Controls.Add(this.button_product_selection_to_dataGridView);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(33, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(771, 275);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Оформлени поставки";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(367, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "р.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(234, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Закупочная стоимость:";
            // 
            // textBox_product_purchase_price
            // 
            this.textBox_product_purchase_price.Location = new System.Drawing.Point(261, 155);
            this.textBox_product_purchase_price.Name = "textBox_product_purchase_price";
            this.textBox_product_purchase_price.Size = new System.Drawing.Size(100, 30);
            this.textBox_product_purchase_price.TabIndex = 9;
            this.textBox_product_purchase_price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_product_purchase_price_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Введите кол-во:";
            // 
            // numericUpDown_product_selection
            // 
            this.numericUpDown_product_selection.Location = new System.Drawing.Point(261, 108);
            this.numericUpDown_product_selection.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown_product_selection.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_product_selection.Name = "numericUpDown_product_selection";
            this.numericUpDown_product_selection.Size = new System.Drawing.Size(82, 30);
            this.numericUpDown_product_selection.TabIndex = 5;
            this.numericUpDown_product_selection.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // comboBox_product_selection
            // 
            this.comboBox_product_selection.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_product_selection.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_product_selection.FormattingEnabled = true;
            this.comboBox_product_selection.Location = new System.Drawing.Point(261, 49);
            this.comboBox_product_selection.Name = "comboBox_product_selection";
            this.comboBox_product_selection.Size = new System.Drawing.Size(443, 33);
            this.comboBox_product_selection.TabIndex = 4;
            // 
            // button_product_selection_to_dataGridView
            // 
            this.button_product_selection_to_dataGridView.BackColor = System.Drawing.Color.BurlyWood;
            this.button_product_selection_to_dataGridView.Location = new System.Drawing.Point(569, 150);
            this.button_product_selection_to_dataGridView.Name = "button_product_selection_to_dataGridView";
            this.button_product_selection_to_dataGridView.Size = new System.Drawing.Size(135, 41);
            this.button_product_selection_to_dataGridView.TabIndex = 3;
            this.button_product_selection_to_dataGridView.Text = "Добавить";
            this.button_product_selection_to_dataGridView.UseVisualStyleBackColor = false;
            this.button_product_selection_to_dataGridView.Click += new System.EventHandler(this.button_product_selection_to_dataGridView_Click);
            // 
            // Admin_AND_User_Amount_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(858, 684);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_product_selection_ADD);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView_selected_product_to_add);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Admin_AND_User_Amount_Product";
            this.Text = "Admin_AND_User_Amount_Product";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_selected_product_to_add)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_product_selection)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView_selected_product_to_add;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_product_selection_ADD;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown_product_selection;
        private System.Windows.Forms.ComboBox comboBox_product_selection;
        private System.Windows.Forms.Button button_product_selection_to_dataGridView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_product_purchase_price;
        private System.Windows.Forms.Label label6;
    }
}