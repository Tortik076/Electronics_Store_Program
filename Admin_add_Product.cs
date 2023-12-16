using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Electronics_Store_Program
{
    public partial class Admin_add_Product : Form
    {
        public Admin_add_Product()
        {
            InitializeComponent();
            For_dGV.ComboBox_add_items_From_Query(comboBox1,reques_BD.select_Category_Id_AND_Product_Category_Form_Categories());
            For_dGV.ComboBox_add_items_From_Query(comboBox2, reques_BD.select_Supplier_Id_AND_Supplier_Name_From_Suppliers());
        }

        private void button_add_User_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedItem!= null && comboBox2.SelectedItem != null && textBox_Product_name.Text != null && textBox_Product_price.Text!= null)
            {
                string input = comboBox1.SelectedItem.ToString();
                string Category_Id = input.Substring(input.IndexOf("(id:") + 4, input.IndexOf(")") - input.IndexOf("(id:") - 4);
                int id_Category = int.Parse(Category_Id);

                string input2 = comboBox2.SelectedItem.ToString();
                string Supplier_Id = input2.Substring(input2.IndexOf("(id:") + 4, input2.IndexOf(")") - input2.IndexOf("(id:") - 4);
                int id_Supplier = int.Parse(Supplier_Id);

                double product_price = double.Parse(textBox_Product_price.Text);

                string add_product_Query = reques_BD.insert_into_Products(textBox_Product_name.Text, product_price, id_Category, id_Supplier);
                For_dGV.useQuery(add_product_Query);
                MessageBox.Show("Запись успешно добавлена!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
            else
            {
                MessageBox.Show("Заполните все поля!","Ошибка!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

    }
}
