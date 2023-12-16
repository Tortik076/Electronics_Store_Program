using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Electronics_Store_Program
{
    public static class dataBase
    {
        static SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-V6VCQA2;Initial Catalog=UP2023; Integrated Security = True");
        
        
        
        //static SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-V6VCQA2;Initial Catalog=Electronics_Store; Integrated Security = True");
       //static SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-7J9IUA1;Initial Catalog=Electronics_Store; Integrated Security = True");

        public static void openConnection()
        {
            if(sqlConnection.State == System.Data.ConnectionState.Closed)
            {
                try { sqlConnection.Open(); }
                catch(Exception ex) { MessageBox.Show(ex.Message); Application.Exit(); }

            }
        }

        public static void closeConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }

        public static SqlConnection getConnection()
        {
            return sqlConnection;
        }
    }
}
