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
    public partial class Admin_AND_User_Amount_Product : Form
    {
        List<string> AllitemsList = new List<string>();
        List<string> filtereditemsList = new List<string>();
        public Admin_AND_User_Amount_Product()
        {
            InitializeComponent();
            For_dGV.ComboBox_add_items_From_Query(comboBox_product_selection, reques_BD.select_Product_Id_AND_Product_Name_From_Products());
            comboBox_product_selection.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox_product_selection.AutoCompleteSource = AutoCompleteSource.ListItems;
            CreateCloums_Products_Selected();
        }

        private void CreateCloums_Products_Selected()
        {
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.HeaderText = "Дейсвие";
            buttonColumn.Text = "Удалить";
            buttonColumn.UseColumnTextForButtonValue = true;


            dataGridView_selected_product_to_add.Columns.Add("Product_Id", "Id");
            dataGridView_selected_product_to_add.Columns.Add("Product_Name", "Наименование товара");
            dataGridView_selected_product_to_add.Columns.Add("Count_Product", "Кол-во");
            dataGridView_selected_product_to_add.Columns.Add("Purchase_Price", "Цена закупки");
            dataGridView_selected_product_to_add.Columns.Add(buttonColumn);


            dataGridView_selected_product_to_add.Columns[0].Width = (int)(0.07 * dataGridView_selected_product_to_add.Width);
            dataGridView_selected_product_to_add.Columns[1].Width = (int)(0.40 * dataGridView_selected_product_to_add.Width);
            dataGridView_selected_product_to_add.Columns[2].Width = (int)(0.18 * dataGridView_selected_product_to_add.Width);
            dataGridView_selected_product_to_add.Columns[3].Width = (int)(0.20 * dataGridView_selected_product_to_add.Width);
            dataGridView_selected_product_to_add.Columns[4].Width = (int)(0.15 * dataGridView_selected_product_to_add.Width);
        }
        //добваить
        private void button_product_selection_to_dataGridView_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(comboBox_product_selection.Text) && !string.IsNullOrEmpty(textBox_product_purchase_price.Text))
            {
                string input = comboBox_product_selection.SelectedItem.ToString();
                string Product_Id = input.Substring(input.IndexOf("(id:") + 4, input.IndexOf(")") - input.IndexOf("(id:") - 4);
                string Product_Name = input.Substring(0, input.IndexOf("(id:"));

                string[] product = new string[4];
                product[0] = Product_Id;
                product[1] = Product_Name;
                product[2] = numericUpDown_product_selection.Value.ToString();
                product[3] = textBox_product_purchase_price.Text.ToString();

                dataGridView_selected_product_to_add.Rows.Add(product);

                numericUpDown_product_selection.Value = 1;
                comboBox_product_selection.SelectedIndex = -1;
                textBox_product_purchase_price.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Выберите товар и укажите закупочную цену!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        //провести
        private void button_product_selection_ADD_Click_1(object sender, EventArgs e)
        {
            if(dataGridView_selected_product_to_add.RowCount > 0)
            {
                foreach (DataGridViewRow row in dataGridView_selected_product_to_add.Rows)
                {
                    int Product_Id = Convert.ToInt32(row.Cells[0].Value);
                    int Product_Amount = Convert.ToInt32(row.Cells[2].Value);
                    double Product_Purchase_Price = Convert.ToDouble(row.Cells[3].Value);

                    string datetimeNow = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss");
                    string addQuert_Reception = $"insert into Reception(Reception_DATE,Product_Id,Product_Amount,Product_Price_Reception) " +
                        $" values ('{datetimeNow}',{Product_Id},{Product_Amount},{Product_Purchase_Price} )";

                    string addQuert = reques_BD.update_Product_Amount_where_Product_Id(Product_Amount, Product_Id);
                    For_dGV.useQuery(addQuert);
                }
                MessageBox.Show("Товар добавлен!", "Ок!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView_selected_product_to_add.Rows.Clear();
            }
            else
            {
                MessageBox.Show("Выберите товар", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //удаление
        private void dataGridView_selected_product_to_add_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Проверяем, была ли нажата кнопка
            if (e.ColumnIndex == dataGridView_selected_product_to_add.Columns[4].Index && e.RowIndex >= 0)
            {
                dataGridView_selected_product_to_add.Rows.Remove(dataGridView_selected_product_to_add.Rows[e.RowIndex]);
            }
        }


        //проврека ввода 
        private void textBox_product_purchase_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.') && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // Разрешение только одной десятичной точки
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
