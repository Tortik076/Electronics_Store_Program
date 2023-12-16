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
    public partial class Admin_add_Supplier : Form
    {
        public Admin_add_Supplier()
        {
            InitializeComponent();
        }

        private void button_add_User_Click(object sender, EventArgs e)
        {
            string add_supplier_Query = reques_BD.insert_into_Suppliers(textBox_supplier_name.Text,textBox_supplier_adress.Text,textBox_supplier_phoneNumber.Text,textBox_Supplier_email.Text);
            For_dGV.useQuery(add_supplier_Query);
            MessageBox.Show("Запись успешно добавлена!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
        }
    }
}
