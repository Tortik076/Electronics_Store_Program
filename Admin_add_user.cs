using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Electronics_Store_Program
{
    public partial class Admin_add_user : Form
    {
        public Admin_add_user()
        {
            InitializeComponent();
        }

        private void button_add_User_Click(object sender, EventArgs e)
        {

            if(!string.IsNullOrEmpty(textBox_Staffer_FIO.Text) && !string.IsNullOrEmpty(textBox_Staffer_Login.Text)  && !string.IsNullOrEmpty(textBox_Staffer_Password.Text) && !string.IsNullOrEmpty(comboBox_Staffer_Access.Text))
            {
                string addQuery = reques_BD.insert_into_Staffers(textBox_Staffer_FIO.Text, comboBox_Staffer_Access.Text, textBox_Staffer_Login.Text,textBox_Staffer_Password.Text);

                For_dGV.useQuery(addQuery);
                MessageBox.Show("Запись успешно добавлена!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Заполните все поля!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
