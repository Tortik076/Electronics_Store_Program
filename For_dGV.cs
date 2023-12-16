using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace Electronics_Store_Program
{
    public enum RowState
    {
        Existed,
        New,
        ModifiedNew,
        Deleted
    }
    public static class For_dGV
    {
        public static void RefreshDataGridView(DataGridView dgw, string query)
        {
            try
            {
                dgw.Rows.Clear();
                SqlCommand sqlCommand = new SqlCommand(query, dataBase.getConnection());
                dataBase.openConnection();
                SqlDataReader reader = sqlCommand.ExecuteReader();
                // Добавляем строки в DataGridView
                while (reader.Read())
                {
                    object[] values = new object[reader.FieldCount + 1];
                    reader.GetValues(values);
                    values[reader.FieldCount] = RowState.Existed;//Добавляем статус для строки
                    dgw.Rows.Add(values);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Application.Exit();
            }

        }
        public static void RefreshDataGridView_WithOutEnums(DataGridView dgw, string query)
        {
            try
            {
                dgw.Rows.Clear();
                SqlCommand sqlCommand = new SqlCommand(query, dataBase.getConnection());
                dataBase.openConnection();
                SqlDataReader reader = sqlCommand.ExecuteReader();
                // Добавляем строки в DataGridView
                while (reader.Read())
                {
                    object[] values = new object[reader.FieldCount ];
                    reader.GetValues(values);
                    dgw.Rows.Add(values);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Application.Exit();
            }

        }
        public static void useQuery(string Query)
        {
            try
            {
                dataBase.openConnection();
                SqlCommand sqlCommand = new SqlCommand(Query, dataBase.getConnection());
                sqlCommand.ExecuteNonQuery();
                dataBase.closeConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void ComboBox_add_items_From_Query(ComboBox comboBox, string Query)
        {
            try
            {
                comboBox.Items.Clear();
                dataBase.openConnection();
                SqlCommand sqlCommand = new SqlCommand(Query, dataBase.getConnection());
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    string item =  reader[1] + " (id:" + reader[0] + ")" ;
                    comboBox.Items.Add(item);
                }
                reader.Close();
                dataBase.closeConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Application.Exit();
            }
        }
        public static string get_from_query(string Query)
        {

                dataBase.openConnection();
                SqlCommand sqlCommand = new SqlCommand(Query, dataBase.getConnection());
                sqlCommand.ExecuteNonQuery();

                SqlDataReader reader = sqlCommand.ExecuteReader();
                string response ="";
                while (reader.Read())
                {
                 response = Convert.ToString(reader.GetInt32(0));
                }
                reader.Close();

                dataBase.closeConnection();
                return response;
        }
    }

}
