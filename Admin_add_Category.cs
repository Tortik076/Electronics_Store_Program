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
    public partial class Admin_add_Category : Form
    {
        public Admin_add_Category()
        {
            InitializeComponent();
        }

        private void button_add_User_Click(object sender, EventArgs e)
        {
            For_dGV.useQuery(reques_BD.insert_into_Categories(textBox_Product_name.Text, textBox_Product_price.Text));
            MessageBox.Show("Запись успешно добавлена!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
        }
    }
}
