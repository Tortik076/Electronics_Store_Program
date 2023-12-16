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

    public partial class Admin_main : Form
    {
        public Admin_main()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        //открытие формы
        private void Admin_main_Load(object sender, EventArgs e)
        {
            if(log_in.Staffer_Access == "admin")
            {

            }
            else if (log_in.Staffer_Access == "user")
            {
                tabControl1.TabPages[5].Parent = null;
                tabControl1.TabPages[4].Parent = null;
                tabControl1.TabPages[3].Parent = null;
                button_delete_Product.Enabled = false;
                button_products_edit.Enabled = false;
            }
            else
            {
                MessageBox.Show("Разрешения для данной группы пользователей не настроены! \n Обратитесь к администратору!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
        //при открытии
        private void tabControl1_Enter(object sender, EventArgs e)
        {
            tabControl1_SelectedIndexChanged(sender, e);
        }
        //Выбор открытой вкладки и заполнения данными из таблицы
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 5)//категории / История входа в приложение
            {
                CreateColums_Categories();
                For_dGV.RefreshDataGridView(dataGridView_Categories, reques_BD.select_all_from_history());
            }
            if (tabControl1.SelectedIndex == 4)//Пользователи
            {
                CreateColums_Staffers();
                For_dGV.RefreshDataGridView(dataGridView_Staffers, reques_BD.select_all_from_Staffers);
            }
            if (tabControl1.SelectedIndex == 3)//Поставщики
            {
                CreateColums_Suppliers();
                For_dGV.RefreshDataGridView(dataGridView_Suppliers, reques_BD.select_all_from_Suppliers);
            }
            if(tabControl1.SelectedIndex == 2)//заказы
            {
                CreateColums_Orders();
                CreateColums_Order_Details();
                For_dGV.RefreshDataGridView_WithOutEnums(dataGridView_orders, reques_BD.select_all_from_Orders());
            }
            if(tabControl1.SelectedIndex == 1)//Товары
            {
                CreateColums_All_Products();
                For_dGV.RefreshDataGridView(dataGridView_All_Products, reques_BD.select_all_from_Products);
            }
            if (tabControl1.SelectedIndex == 0)//Оформление заказа
            {
                CreateColums_Make_Order();
                CreateCloums_Products_Selected();
                For_dGV.RefreshDataGridView_WithOutEnums(dataGridView_Products_in_Make_Order, reques_BD.select_all_from_Products);
            }
        }
        //------------------------------------Staffers------------------------------------------------
        //Отображение таблицы "Пользователи"
        private void CreateColums_Staffers()
        {
            dataGridView_Staffers.Columns.Add("Staffer_Id", "Id");
            dataGridView_Staffers.Columns.Add("Staffer_FIO", "ФИО");
            dataGridView_Staffers.Columns.Add("Staffer_Access", "Доступ");
            dataGridView_Staffers.Columns.Add("Staffer_Login", "Логин");
            dataGridView_Staffers.Columns.Add("Staffer_Password", "Пароль");
            dataGridView_Staffers.Columns.Add("IsNew", string.Empty);

            dataGridView_Staffers.Columns[0].Width = (int)(0.05 * dataGridView_Staffers.Width);
            dataGridView_Staffers.Columns[1].Width = (int)(0.37 * dataGridView_Staffers.Width);
            dataGridView_Staffers.Columns[2].Width = (int)(0.12 * dataGridView_Staffers.Width);
            dataGridView_Staffers.Columns[3].Width = (int)(0.23 * dataGridView_Staffers.Width);
            dataGridView_Staffers.Columns[4].Width = (int)(0.23 * dataGridView_Staffers.Width);
            //dataGridView_Staffers.Columns[5].Width = (int)(0.12 * dataGridView_Staffers.Width);
        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            For_dGV.RefreshDataGridView(dataGridView_Staffers, reques_BD.select_all_from_Staffers);
        }
        private void button_add_Click(object sender, EventArgs e)
        {
            Admin_add_user admin_Add_User = new Admin_add_user();
            admin_Add_User.ShowDialog();
        }

        private void textBox_search_TextChanged(object sender, EventArgs e)
        {
            string searchQuert = reques_BD.searchQuert_on_Fio_and_Login_from_Staffers(textBox_search.Text.ToString());
            For_dGV.RefreshDataGridView(dataGridView_Staffers, searchQuert);
        }
        private void button_Delete_Click(object sender, EventArgs e)
        {
            int index = dataGridView_Staffers.CurrentCell.RowIndex;
            dataGridView_Staffers.Rows[index].Visible = false;

            string deleteQuert = reques_BD.delete_from_Staffers_where_Staffer_Id(dataGridView_Staffers.Rows[index].Cells[0].Value.ToString());
            For_dGV.useQuery(deleteQuert);
        }
        private void button_change_Click(object sender, EventArgs e)
        {
            dataGridView_Staffers.ReadOnly = false;
            button_change.Visible = false;
            button_save.Visible = true;
        }
        private void dataGridView_Staffers_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            dataGridView_Staffers.Rows[dataGridView_Staffers.CurrentCell.RowIndex].Cells[5].Value = RowState.ModifiedNew;
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            button_save.Visible = false;
            button_change.Visible = true;
            dataGridView_Staffers.ReadOnly = true;
            for (int index = 0; index < dataGridView_Staffers.Rows.Count; index++)
            {
                if ((RowState)dataGridView_Staffers.Rows[index].Cells[5].Value == RowState.ModifiedNew)
                {
                    string changeQuery = reques_BD.update_Staffers(dataGridView_Staffers, index);
                    For_dGV.useQuery(changeQuery);
                }
            }
        }
        //------------------------------------END Staffers------------------------------------------------

        //------------------------------------Suppliers---------------------------------------------------

        //Отображение таблицы "Поставщики"
        private void CreateColums_Suppliers()
        {
            dataGridView_Suppliers.Columns.Add("Supplier_Id", "Id");
            dataGridView_Suppliers.Columns.Add("Supplier_Name", "Наименование компании");
            dataGridView_Suppliers.Columns.Add("Supplier_Address", "Юр. адрес");
            dataGridView_Suppliers.Columns.Add("Supplier_PhoneNumber", "Телефон");
            dataGridView_Suppliers.Columns.Add("Supplier_Email", "Почта");
            dataGridView_Suppliers.Columns.Add("IsNew", string.Empty);

            dataGridView_Suppliers.Columns[0].Width = (int)(0.05 * dataGridView_Suppliers.Width);
            dataGridView_Suppliers.Columns[1].Width = (int)(0.32 * dataGridView_Suppliers.Width);
            dataGridView_Suppliers.Columns[2].Width = (int)(0.17 * dataGridView_Suppliers.Width);
            dataGridView_Suppliers.Columns[3].Width = (int)(0.23 * dataGridView_Suppliers.Width);
            dataGridView_Suppliers.Columns[4].Width = (int)(0.23 * dataGridView_Suppliers.Width);
            dataGridView_Suppliers.Columns[5].Width = (int)(0.12 * dataGridView_Suppliers.Width);
        }

        ////добавление в таблицу занчений из record
        //private void ReadSingleRow(DataGridView dgw, IDataReader record)
        //{
        //   dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3), record.GetString(4), RowState.Existed);

        //}
        ////обнавление таблицы 
        //private void RefreshDataGridView(DataGridView dgw)
        //{
        //    dgw.Rows.Clear();

        //    string query = $"select * from Staffers";

        //    SqlCommand sqlCommand = new SqlCommand(query, dataBase.getConnection());

        //    dataBase.openConnection();

        //    SqlDataReader reader = sqlCommand.ExecuteReader();

        //    // Добавляем строки в DataGridView
        //    while (reader.Read())
        //    {
        //        object[] values = new object[reader.FieldCount];
        //        reader.GetValues(values);
        //        dataGridView_Staffers.Rows.Add(values);
        //    }
        //    //DataTable dt = new DataTable();
        //    //dt.Load(reader);
        //    //dataGridView_Staffers.DataSource = dt;
        //    //while (reader.Read())
        //    //{
        //    //    ReadSingleRow(dgw, reader);
        //    //}
        //    reader.Close();
        //}


        private void button_refresh_Suppliers_Click(object sender, EventArgs e)
        {
            For_dGV.RefreshDataGridView(dataGridView_Suppliers, reques_BD.select_all_from_Suppliers);
        }

        private void button_add_Supplier_Click(object sender, EventArgs e)
        {
            Admin_add_Supplier admin_Add_Supplier = new Admin_add_Supplier();
            admin_Add_Supplier.ShowDialog();

        }

        //private void Search(DataGridView Dgw)
        //{
        //    Dgw.Rows.Clear();
        //    string searchQuert = $"select * from Staffers where concat(Staffer_FIO,Staffer_Login) like '%" + textBox_search.Text + "%'";

        //    dataBase.openConnection();
        //    SqlCommand sqlCommand = new SqlCommand(searchQuert, dataBase.getConnection());

        //    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

        //    while (sqlDataReader.Read())
        //    {
        //       // ReadSingleRow(Dgw, sqlDataReader);
        //    }
        //    sqlDataReader.Close();
        //}


        private void textBox_search_Suppliers_TextChanged(object sender, EventArgs e)
        {
            string searchQuert = reques_BD.searchQuert_on_Fio_and_Login_from_Suppliers(textBox_search_Suppliers.Text);
            For_dGV.RefreshDataGridView(dataGridView_Suppliers, searchQuert);
        }

        //private void deleteRows(DataGridView dgv)
        //{
        //    int index = dataGridView_Staffers.CurrentCell.RowIndex;

        //    dataGridView_Staffers.Rows[index].Visible = false;

        //    if ((dataGridView_Staffers.Rows[index].Cells[0].Value.ToString()) != null)
        //    {
        //        dataGridView_Staffers.Rows[index].Cells[5].Value = RowState.Deleted;
        //    }
        //}

        //private void Update(DataGridView Dgw)
        //{
        //    dataBase.openConnection();

        //    for (int index = 0; index < Dgw.Rows.Count; index++)
        //    {
        //        RowState rowState = (RowState)Dgw.Rows[index].Cells[Dgw.ColumnCount-1].Value;
        //        if (rowState == RowState.Deleted)
        //        {
        //            var id = Dgw.Rows[index].Cells[0].Value;
        //            string delateQuery = $"delete from Staffers where Staffer_Id = '{id}'";
        //            SqlCommand sqlCommand = new SqlCommand(delateQuery, dataBase.getConnection());
        //            sqlCommand.ExecuteNonQuery();
        //        }
        //        if (rowState == RowState.ModifiedNew)
        //        {
        //            string changeQuery = $"update Staffers set Staffer_FIO='{Dgw.Rows[index].Cells[1].Value}'," +
        //                $"Staffer_Access='{Dgw.Rows[index].Cells[2].Value}'" +
        //                $",Staffer_Login='{Dgw.Rows[index].Cells[3].Value}'" +
        //                $",Staffer_Password='{Dgw.Rows[index].Cells[4].Value}'" +
        //                $" where Staffer_Id = '{Dgw.Rows[index].Cells[0].Value}'";

        //            SqlCommand sqlCommand = new SqlCommand(changeQuery, dataBase.getConnection());

        //            sqlCommand.ExecuteNonQuery();
        //        }
        //    }
        //    dataBase.closeConnection();
        //}

        

        private void button_delete_Suppliers_Click(object sender, EventArgs e)
        {
            if (dataGridView_Suppliers.CurrentCell.RowIndex != -1)
            {
                int index = dataGridView_Suppliers.CurrentCell.RowIndex;
                dataGridView_Suppliers.Rows[index].Visible = false;
                string deleteQuert = reques_BD.delete_from_Suppliers_where_Supplier_Id(dataGridView_Suppliers.Rows[index].Cells[0].Value.ToString());
                For_dGV.useQuery(deleteQuert);
            }
             else MessageBox.Show("Выделеите строку котору хотите удалить и нажмите кнопку заново!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }


        private void button_change_Suppliers_Click(object sender, EventArgs e)
        {
            dataGridView_Suppliers.ReadOnly = false;
            button_change_Suppliers.Visible = false;
            button_save_Suppliers.Visible = true;

        }
        private void dataGridView_Suppliers_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            dataGridView_Suppliers.Rows[dataGridView_Suppliers.CurrentCell.RowIndex].Cells[5].Value = RowState.ModifiedNew;
        }

        private void button_save_Suppliers_Click(object sender, EventArgs e)
        {
            button_save_Suppliers.Visible = false;
            button_change_Suppliers.Visible = true;
            dataGridView_Suppliers.ReadOnly = true;
            for (int index = 0; index < dataGridView_Suppliers.Rows.Count; index++)
            {
                if ((RowState)dataGridView_Suppliers.Rows[index].Cells[5].Value == RowState.ModifiedNew)
                {
                    string changeQuery = reques_BD.update_Suppliers(dataGridView_Suppliers, index);
                    For_dGV.useQuery(changeQuery);
                }
            }
        }
        //------------------------------------ END Suppliers------------------------------------------------

        //----------------------------------Make order---------------------------------------------------
        //добавлеие кнопки в datagridview 
            
        //Отображение таблицы "товары в наличии"
        private void CreateColums_Make_Order()
        {            
            if(dataGridView_Products_in_Make_Order.Columns.Count ==0)
            {
                DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
                buttonColumn.HeaderText = "Действие";
                buttonColumn.Text = "Добавить";
                buttonColumn.UseColumnTextForButtonValue = true;

                dataGridView_Products_in_Make_Order.Columns.Add("Product_Id", "Id");
                dataGridView_Products_in_Make_Order.Columns.Add("Product_Name", "Наименование товара");
                dataGridView_Products_in_Make_Order.Columns.Add("Product_Price_ForSale", "Цена руб.");
                dataGridView_Products_in_Make_Order.Columns.Add("Product_Amount", "Кол-во в наличии");
                dataGridView_Products_in_Make_Order.Columns.Add("Id_Product_Category", "Категория");
                dataGridView_Products_in_Make_Order.Columns.Add("Id_Supplier", "Поставщик");
                dataGridView_Products_in_Make_Order.Columns.Add(buttonColumn);

                dataGridView_Products_in_Make_Order.Columns[0].Width = (int)(0.04 * dataGridView_Products_in_Make_Order.Width);
                dataGridView_Products_in_Make_Order.Columns[1].Width = (int)(0.30 * dataGridView_Products_in_Make_Order.Width);
                dataGridView_Products_in_Make_Order.Columns[2].Width = (int)(0.1 * dataGridView_Products_in_Make_Order.Width);
                dataGridView_Products_in_Make_Order.Columns[3].Width = (int)(0.10 * dataGridView_Products_in_Make_Order.Width);
                dataGridView_Products_in_Make_Order.Columns[4].Width = (int)(0.18 * dataGridView_Products_in_Make_Order.Width);
                dataGridView_Products_in_Make_Order.Columns[5].Width = (int)(0.15 * dataGridView_Products_in_Make_Order.Width);
                dataGridView_Products_in_Make_Order.Columns[6].Width = (int)(0.13 * dataGridView_Products_in_Make_Order.Width);
            }
        }
        private void CreateCloums_Products_Selected()
        {
            if(dataGridView_Products_Selected.Columns.Count == 0)
            {
                DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
                buttonColumn.HeaderText = "Действие";
                buttonColumn.Text = "Удалить";
                buttonColumn.UseColumnTextForButtonValue = true;

                dataGridView_Products_Selected.Columns.Add("Product_Id", "Id");
                dataGridView_Products_Selected.Columns.Add("Product_Name", "Наименование товара");
                dataGridView_Products_Selected.Columns.Add("Product_Price_ForSale", "Цена");
                dataGridView_Products_Selected.Columns.Add("Count_Product", "Кол-во");
                dataGridView_Products_Selected.Columns.Add(buttonColumn);

                dataGridView_Products_Selected.Columns[0].Width = (int)(0.07 * dataGridView_Products_Selected.Width);
                dataGridView_Products_Selected.Columns[1].Width = (int)(0.45 * dataGridView_Products_Selected.Width);
                dataGridView_Products_Selected.Columns[2].Width = (int)(0.18 * dataGridView_Products_Selected.Width);
                dataGridView_Products_Selected.Columns[3].Width = (int)(0.15 * dataGridView_Products_Selected.Width);
                dataGridView_Products_Selected.Columns[4].Width = (int)(0.15 * dataGridView_Products_Selected.Width);
            }

        }

        private void dataGridView_Products_in_Make_Order_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView_Products_in_Make_Order.Columns[6].Index && e.RowIndex >= 0)
            {
                int index = e.RowIndex;
                List<string> List_Selected_Orders = new List<string>();
                List_Selected_Orders.Add(dataGridView_Products_in_Make_Order.Rows[index].Cells[0].Value.ToString());
                List_Selected_Orders.Add(dataGridView_Products_in_Make_Order.Rows[index].Cells[1].Value.ToString());
                List_Selected_Orders.Add(dataGridView_Products_in_Make_Order.Rows[index].Cells[2].Value.ToString());
                List_Selected_Orders.Add(dataGridView_Products_in_Make_Order.Rows[index].Cells[3].Value.ToString());


                if (dataGridView_Products_Selected.Rows.Count > 0)
                {
                    for (int i = 0; i < (int)dataGridView_Products_Selected.Rows.Count; i++)
                    {
                        if (dataGridView_Products_Selected.Rows[i].Cells[0].Value.ToString() == List_Selected_Orders[0])
                        {
                            dataGridView_Products_Selected.Rows[i].Cells[3].Value = 1 + Convert.ToInt32(dataGridView_Products_Selected.Rows[i].Cells[3].Value);
                            return;
                        }
                    }
                }
                 dataGridView_Products_Selected.Rows.Add(List_Selected_Orders[0], List_Selected_Orders[1], List_Selected_Orders[2], 1);


                dataGridView_Products_Selected.ReadOnly = false;
                foreach (DataGridViewRow row in dataGridView_Products_Selected.Rows)
                {
                    row.Cells[0].ReadOnly = true;
                    row.Cells[1].ReadOnly = true;
                    row.Cells[2].ReadOnly = true;
                }

            }
        }
        private void dataGridView_Products_Selected_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            coun_sum();
        }
        private void dataGridView_Products_Selected_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            coun_sum();
        }
        private void coun_sum()
        {
            double sum = 0;
            if (dataGridView_Products_Selected.Rows.Count > 0)
            {
                for (int i = 0; i < (int)dataGridView_Products_Selected.Rows.Count; i++)
                {
                    sum = sum + (Convert.ToDouble(dataGridView_Products_Selected.Rows[i].Cells[3].Value) * Convert.ToDouble(dataGridView_Products_Selected.Rows[i].Cells[2].Value));
                }
            }

            label_sum.Text = sum.ToString() + " р.";
        }

        private void textBox_seatch_TextChanged(object sender, EventArgs e)
        {
            string sestchQuert = reques_BD.searchQuert_on_Name_Products(textBox_seatch.Text);
            For_dGV.RefreshDataGridView(dataGridView_Products_in_Make_Order, sestchQuert);
        }

        private void button_make_order_Click(object sender, EventArgs e)
        {
            if(dataGridView_Products_Selected.Rows.Count != 0)
            {
                For_dGV.useQuery(reques_BD.insert_into_Orders(log_in.Staffer_Id)) ;
                string order_id = For_dGV.get_from_query(reques_BD.SELECT_SCOPE_IDENTITY());
                foreach (DataGridViewRow Row in dataGridView_Products_Selected.Rows)
                {
                    for (int i = 0 ; i < dataGridView_Products_in_Make_Order.Rows.Count; i++)
                    {
                        if (Row.Cells[0].Value.ToString() == dataGridView_Products_in_Make_Order.Rows[i].Cells[0].Value.ToString())
                        {
                            if( Convert.ToInt32(Row.Cells[3].Value) > Convert.ToInt32(dataGridView_Products_in_Make_Order.Rows[i].Cells[3].Value.ToString()))
                            {
                                MessageBox.Show($" Вы выбрали товар: {Row.Cells[1].Value} ({Row.Cells[3].Value} шт.) \n В наличии есть: {dataGridView_Products_in_Make_Order.Rows[i].Cells[3].Value.ToString()} ", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                    }
                }



                foreach (DataGridViewRow Row in dataGridView_Products_Selected.Rows)
                {
                    For_dGV.useQuery(reques_BD.insert_into_Order_Details(Convert.ToInt32(order_id), Convert.ToInt32(Row.Cells[0].Value), Convert.ToInt32(Row.Cells[3].Value)));
                    For_dGV.useQuery(reques_BD.update_Products_set_Product_Amount_where_Product_Id(Convert.ToInt32(Row.Cells[0].Value), Convert.ToInt32(Row.Cells[3].Value)));
                }
                MessageBox.Show("Заказ успешно записан!", "Запись", MessageBoxButtons.OK, MessageBoxIcon.Information);
                label_sum.Text = "";
                dataGridView_Products_Selected.Rows.Clear();
                For_dGV.RefreshDataGridView_WithOutEnums(dataGridView_Products_in_Make_Order, reques_BD.select_all_from_Products);
            }
            else
            {
                MessageBox.Show("Добавьте товар в зказ", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void dataGridView_Products_Selected_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Проверяем, была ли нажата кнопка
            if (e.ColumnIndex == dataGridView_Products_Selected.Columns[4].Index && e.RowIndex >= 0)
            {
                dataGridView_Products_Selected.Rows.Remove(dataGridView_Products_Selected.Rows[e.RowIndex]);
            }
        }

        //----------------------------------END Make order-----------------------------------------------

        //----------------------------------Products----------------------------------------------------
        private void CreateColums_All_Products()
        {
            if(dataGridView_All_Products.Columns.Count == 0)
            {
                dataGridView_All_Products.Columns.Add("Product_Id", "Id");
                dataGridView_All_Products.Columns.Add("Product_Name", "Наименование товара");
                dataGridView_All_Products.Columns.Add("Product_Price_ForSale", "Цена руб.");
                dataGridView_All_Products.Columns.Add("Product_Amount", "Кол-во в наличии");
                dataGridView_All_Products.Columns.Add("Id_Product_Category", "Категория");
                dataGridView_All_Products.Columns.Add("Id_Supplier", "Поставщик");
                dataGridView_All_Products.Columns.Add("IsNew", string.Empty);

                dataGridView_All_Products.Columns[0].Width = (int)(0.04 * dataGridView_All_Products.Width);
                dataGridView_All_Products.Columns[1].Width = (int)(0.40 * dataGridView_All_Products.Width);
                dataGridView_All_Products.Columns[2].Width = (int)(0.1 * dataGridView_All_Products.Width);
                dataGridView_All_Products.Columns[3].Width = (int)(0.10 * dataGridView_All_Products.Width);
                dataGridView_All_Products.Columns[4].Width = (int)(0.18 * dataGridView_All_Products.Width);
                dataGridView_All_Products.Columns[5].Width = (int)(0.18 * dataGridView_All_Products.Width);
                //dataGridView_All_Products.Columns[6].Width = (int)(0.1 * dataGridView_All_Products.Width);
            }
            For_dGV.ComboBox_add_items_From_Query(combobox_suppliers,reques_BD.select_Supplier_Id_AND_Supplier_Name_From_Suppliers());
            For_dGV.ComboBox_add_items_From_Query(comboBox_category, reques_BD.select_Category_Id_AND_Product_Category_From_Categories());
        }

        private void button_refresh_All_Products_Click(object sender, EventArgs e)
        {
            For_dGV.RefreshDataGridView(dataGridView_All_Products, reques_BD.select_all_from_Products);
            combobox_suppliers.SelectedIndex = -1;
            comboBox_category.SelectedIndex = -1;
        }

        private void textBox_all_Products_TextChanged(object sender, EventArgs e)
        {
            string sestchQuert = reques_BD.searchQuert_on_Name_Products(textBox_all_Products.Text);
            For_dGV.RefreshDataGridView(dataGridView_All_Products, sestchQuert);
        }

        private void button_add_new_Product_Click(object sender, EventArgs e)
        {
            Admin_add_Product admin_Add_Product = new Admin_add_Product();
            admin_Add_Product.ShowDialog();
        }

        private void button_delete_Product_Click(object sender, EventArgs e)
        {
            if (dataGridView_All_Products.CurrentCell.RowIndex != -1)
            {
                int index = dataGridView_All_Products.CurrentCell.RowIndex;

                DialogResult result = MessageBox.Show($"Вы уверены, что хотите удалить этот товар? \n {dataGridView_All_Products.Rows[index].Cells[1].Value}", "Внимание !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    dataGridView_All_Products.Rows[index].Visible = false;
                    string deleteQuert = reques_BD.delete_from_Products_where_Product_Id(dataGridView_All_Products.Rows[index].Cells[0].Value.ToString());
                    For_dGV.useQuery(deleteQuert);
                }
            }
            else MessageBox.Show("Выделеите строку котору хотите удалить и нажмите кнопку заново!","Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        private void button_add_Amount_Product_Click(object sender, EventArgs e)
        {
            Admin_AND_User_Amount_Product admin_AND_User_Amount_Product = new Admin_AND_User_Amount_Product();
            admin_AND_User_Amount_Product.ShowDialog();
        }
        private void combobox_suppliers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(combobox_suppliers.SelectedIndex != -1)
            {
                string input = combobox_suppliers.SelectedItem.ToString();
                string selectedValue = input.Substring(0, input.IndexOf(" (id:"));
                foreach (DataGridViewRow row in dataGridView_All_Products.Rows)
                {
                    if (comboBox_category.SelectedIndex != -1)
                    {
                        if (!row.IsNewRow & row.Visible == true)
                        {
                            if (row.Cells[5].Value.ToString().Contains(selectedValue))
                            {
                                row.Visible = true;
                            }
                            else
                            {
                                row.Visible = false;
                            }
                        }
                    }
                    else
                    {
                        if (!row.IsNewRow)
                        {
                            if (row.Cells[5].Value.ToString().Contains(selectedValue))
                            {
                                row.Visible = true;
                            }
                            else
                            {
                                row.Visible = false;
                            }
                        }
                    }
                }
            }
            
        }

        private void comboBox_category_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_category.SelectedIndex != -1)
            {
                string input = comboBox_category.SelectedItem.ToString();
                string selectedValue = input.Substring(0, input.IndexOf(" (id:"));
                foreach (DataGridViewRow row in dataGridView_All_Products.Rows)
                {
                    if(combobox_suppliers.SelectedIndex != -1)
                    {
                        if (!row.IsNewRow & row.Visible == true)
                        {
                            if (row.Cells[4].Value.ToString().Contains(selectedValue))
                            {
                                row.Visible = true;
                            }
                            else
                            {
                                row.Visible = false;
                            }
                        }
                    }
                    else
                    {
                        if (!row.IsNewRow)
                        {
                            if (row.Cells[4].Value.ToString().Contains(selectedValue))
                            {
                                row.Visible = true;
                            }
                            else
                            {
                                row.Visible = false;
                            }
                        }
                    }
                    
                }
            }               
        }
        private void button_products_edit_Click(object sender, EventArgs e)
        {
            button_products_edit.Visible = false;
            button_ptoducts_save_edit.Visible = true;
            dataGridView_All_Products.ReadOnly = false;
            foreach(DataGridViewRow row in dataGridView_All_Products.Rows)
            {
                row.Cells[0].ReadOnly = true;
                row.Cells[4].ReadOnly = true;
                row.Cells[5].ReadOnly = true;
                row.Cells[6].ReadOnly = true;
            }
        }
        private void dataGridView_All_Products_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            dataGridView_All_Products.Rows[dataGridView_All_Products.CurrentCell.RowIndex].Cells[6].Value = RowState.ModifiedNew;
        }

        private void button_ptoducts_save_edit_Click(object sender, EventArgs e)
        {
            button_products_edit.Visible = true;
            button_ptoducts_save_edit.Visible = false;
            dataGridView_All_Products.ReadOnly = true;

            for (int index = 0; index < dataGridView_All_Products.Rows.Count; index++)
            {
                if ((RowState)dataGridView_All_Products.Rows[index].Cells[6].Value == RowState.ModifiedNew)
                {
                    string changeQuery = reques_BD.update_products(dataGridView_All_Products, index);
                    For_dGV.useQuery(changeQuery);
                }
            }
        }


            //----------------------------------END Products------------------------------------------------
            //----------------------------------Orders------------------------------------------------
         private void CreateColums_Orders()
         {
            if ((int)dataGridView_orders.Columns.Count == 0)
            {
                DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
                buttonColumn.HeaderText = "Действие";
                buttonColumn.Text = "Подробнее";
                buttonColumn.UseColumnTextForButtonValue = true;

                DataGridViewButtonColumn buttonColumn_dell = new DataGridViewButtonColumn();
                buttonColumn_dell.HeaderText = "Действие";
                buttonColumn_dell.Text = "Удалить";
                buttonColumn_dell.UseColumnTextForButtonValue = true;

                dataGridView_orders.Columns.Add("Order_Id", "Id");
                dataGridView_orders.Columns.Add("Order_Date ", "Дата");
                dataGridView_orders.Columns.Add("Staffer_Id ", "Продавец");
                dataGridView_orders.Columns.Add(buttonColumn);
                dataGridView_orders.Columns.Add(buttonColumn_dell);

                dataGridView_orders.Columns[0].Width = (int)(0.05 * dataGridView_orders.Width);
                dataGridView_orders.Columns[1].Width = (int)(0.25 * dataGridView_orders.Width);
                dataGridView_orders.Columns[2].Width = (int)(0.35 * dataGridView_orders.Width);
                dataGridView_orders.Columns[3].Width = (int)(0.20 * dataGridView_orders.Width);
                dataGridView_orders.Columns[4].Width = (int)(0.15 * dataGridView_orders.Width);

            }
         }
        private void CreateColums_Order_Details()
        {
            if(dataGridView_Order_Details.Columns.Count == 0)
            {
                dataGridView_Order_Details.Columns.Add("Order_Id", "Order_Id");
                dataGridView_Order_Details.Columns.Add("Product_Name", "Product_Name");
                dataGridView_Order_Details.Columns.Add("Count_Product", "Кол-во");
                dataGridView_Order_Details.Columns[0].Width = (int)(0.15 * dataGridView_Order_Details.Width);
                dataGridView_Order_Details.Columns[1].Width = (int)(0.65 * dataGridView_Order_Details.Width);
                dataGridView_Order_Details.Columns[2].Width = (int)(0.20 * dataGridView_Order_Details.Width);
            }
        }

        private void dataGridView_orders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView_orders.Columns[3].Index && e.RowIndex >= 0)
            {
                int index = e.RowIndex;
                int index_order = (int)dataGridView_orders.Rows[index].Cells[0].Value;
                For_dGV.RefreshDataGridView_WithOutEnums(dataGridView_Order_Details, reques_BD.select_all_where_Order_Id(index_order));
            }
            if (e.ColumnIndex == dataGridView_orders.Columns[4].Index && e.RowIndex >= 0)
            {

                if (log_in.Staffer_Access == "user")
                {
                    MessageBox.Show($"Удалять заказы может только администратор!", "Внимание !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                int index = e.RowIndex;
                int index_order = (int)dataGridView_orders.Rows[index].Cells[0].Value;
                DialogResult result = MessageBox.Show($"Вы уверены, что хотите удалить  заказ? \n Id: {dataGridView_orders.Rows[index].Cells[0].Value}", "Внимание !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    For_dGV.useQuery(reques_BD.delete_from_Orders_where_Order_Id(index_order));
                    For_dGV.RefreshDataGridView_WithOutEnums(dataGridView_orders, reques_BD.select_all_from_Orders());
                }
            }
        }

        //----------------------------------END Orders------------------------------------------------
        //----------------------------------Categories------------------------------------------------

        private void CreateColums_Categories()
        {
            if ((int)dataGridView_Categories.Columns.Count == 0)
            {

                dataGridView_Categories.Columns.Add("ID ", "Id");
                dataGridView_Categories.Columns.Add("Time_try ", "Время входа");
                dataGridView_Categories.Columns.Add("Status_try", "Статус входа");
                dataGridView_Categories.Columns.Add("Login_inp", "ФИО");
                dataGridView_Categories.Columns.Add("Access_inp", "Доступ");

                dataGridView_Categories.Columns[0].Width = (int)(0.10 * dataGridView_Categories.Width);
                dataGridView_Categories.Columns[1].Width = (int)(0.30 * dataGridView_Categories.Width);
                dataGridView_Categories.Columns[2].Width = (int)(0.20 * dataGridView_Categories.Width);
                dataGridView_Categories.Columns[3].Width = (int)(0.20 * dataGridView_Categories.Width);
                dataGridView_Categories.Columns[4].Width = (int)(0.20 * dataGridView_Categories.Width);
            }

        }


        private void button7_Click(object sender, EventArgs e)
        {
            For_dGV.RefreshDataGridView(dataGridView_Categories, reques_BD.select_all_from_history());
        }



        //----------------------------------END Categories------------------------------------------------

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }


}



