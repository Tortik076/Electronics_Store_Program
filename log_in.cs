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
    public partial class log_in : Form
    {
        public log_in()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        public static int Staffer_Id;
        public static string Staffer_FIO;
        public static string Staffer_Access;

        public int number_attempts = 0;
        int first, second;

        private void button_log_in_Click(object sender, EventArgs e)
        {
            label_For_capcha3.Visible = false;
            if (number_attempts > 1)
            {
                if (String.IsNullOrEmpty(textBoxl_For_capcha.Text) || ((first + second) != (int.Parse(textBoxl_For_capcha.Text) ))){
                    label_For_capcha3.Visible = true;
                    return;
                }
            }

            string loginUser = textBox_login.Text;
            string passwordUser = textBox_password.Text;
            string query = $"select * from Staffers where Staffer_Login = '{loginUser}' and Staffer_Password ='{passwordUser}'";

            try
            {

                SqlCommand sqlCommand = new SqlCommand(query, dataBase.getConnection());
                dataBase.openConnection();

                SqlDataReader reader = sqlCommand.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    Staffer_Id = reader.GetInt32(0);
                    Staffer_FIO = reader.GetString(1);
                    Staffer_Access = reader.GetString(2);
                    dataBase.closeConnection();
                    MessageBox.Show("Вход выполнен! \n" +"Добро пожаловать," + Staffer_FIO +" !\n" + "Ваша роль: " + Staffer_Access, "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    For_dGV.useQuery(reques_BD.insert_into_history("successfully", Staffer_FIO, Staffer_Access));
                    Admin_main admin_Main = new Admin_main();
                    this.Hide();
                    admin_Main.ShowDialog();
                    Program.log_In.Close();
                }
                else
                {
                    MessageBox.Show("Пользователь с таким паролем и лонином не найден! \n Проверьте правильность ввода и повторите попытку!");
                    number_attempts++;
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Application.Exit();
            }

            if(number_attempts > 1)
            {
                label_For_capcha1.Visible = true;
                label_For_capcha2.Visible = true;
                textBoxl_For_capcha.Visible = true;

                Random rand = new Random();
             
                first = rand.Next(1, 100);
                second = rand.Next(1, 100);

                label_For_capcha2.Text = first + " + " + second + " = ";

            }

        }

        #region Кнопки для скрытия символов пароля
        private void pictureBox_hidePass_Click(object sender, EventArgs e)
        {
            textBox_password.PasswordChar = '*';
            pictureBox_hidePass.Visible = false;
            pictureBox_showPass.Visible = true;
        }

        private void pictureBox_showPass_Click(object sender, EventArgs e)
        {
            textBox_password.PasswordChar = '\0';
            pictureBox_hidePass.Visible = true;
            pictureBox_showPass.Visible = false;
        }

        #endregion

    }
}
