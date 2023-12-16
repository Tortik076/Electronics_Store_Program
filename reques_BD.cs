    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Data.SqlClient;
    using System.Data;
    using System.Windows.Forms;


    namespace Electronics_Store_Program
    {

        static class reques_BD
        {
            public static string Staffers
            {
                get { return "Staffers"; }
            }
            public static string Suppliers
            {
                get { return "Suppliers"; }
            }
            public static string select_all_from_Staffers
            {
                get { return $"select * from {reques_BD.Staffers}"; }
            }
            public static string select_all_from_Suppliers
            {
                get { return $"select * from {reques_BD.Suppliers}"; }
            }
            public static string searchQuert_on_Fio_and_Login_from_Staffers(string SearchText)
            {
                return $"select * from {reques_BD.Staffers} where concat(Staffer_FIO,Staffer_Login) like '%" + SearchText + "%'";
            }
            public static string insert_into_Staffers(string fio, string access, string login, string password)
            {
                return $"insert into Staffers(Staffer_FIO,Staffer_Access,Staffer_Login,Staffer_Password) values ('{fio}','{access}','{login}','{password}')";
            }
            public static string searchQuert_on_Fio_and_Login_from_Suppliers(string SearchText)
            {
                return $"select * from {reques_BD.Suppliers} where concat(Supplier_Name,Supplier_Address,Supplier_PhoneNumber) like '%" + SearchText + "%'";
            }
            public static string delete_from_Staffers_where_Staffer_Id(string Staffer_Id)
            {
                return $"delete from Staffers where Staffer_Id = '{Staffer_Id}'";
            }
            public static string update_Staffers(DataGridView Dgw, int index)
            {
                return $"update Staffers set Staffer_FIO='{Dgw.Rows[index].Cells[1].Value}'," +
                $"Staffer_Access='{Dgw.Rows[index].Cells[2].Value}'" +
                $",Staffer_Login='{Dgw.Rows[index].Cells[3].Value}'" +
                $",Staffer_Password='{Dgw.Rows[index].Cells[4].Value}'" +
                $" where Staffer_Id = '{Dgw.Rows[index].Cells[0].Value}'";
            }
            public static string delete_from_Suppliers_where_Supplier_Id(string Supplier_Id)
            {
                return $"delete from Suppliers where Supplier_Id = '{Supplier_Id}'";
            }
            public static string update_Suppliers(DataGridView Dgw, int index)
            {
                return $"update Suppliers set Supplier_Name='{Dgw.Rows[index].Cells[1].Value}'," +
                $"Supplier_Address='{Dgw.Rows[index].Cells[2].Value}'" +
                $",Supplier_PhoneNumber='{Dgw.Rows[index].Cells[3].Value}'" +
                $",Supplier_Email='{Dgw.Rows[index].Cells[4].Value}'" +
                $" where Supplier_Id = {Dgw.Rows[index].Cells[0].Value}";
            }
            public static string insert_into_Suppliers(string Supplier_Name, string Supplier_Address, string Supplier_PhoneNumber, string Supplier_Email)
            {
                return $"insert into Suppliers(Supplier_Name, Supplier_Address,Supplier_PhoneNumber,Supplier_Email)" +
                    $" values('{Supplier_Name}','{Supplier_Address}','{Supplier_PhoneNumber}','{Supplier_Email}')";
            }
            //Товары 
            public static string select_all_from_Products
            {
                get
                {
                    return $"SELECT Products.Product_Id, Products.Product_Name, Products.Product_Price_ForSale, Products.Product_Amount, Categories.Product_Category, Suppliers.Supplier_Name " +
                    $"From Products " +
                    $"Left join Categories " +
                    $"on Categories.Category_Id = Products.Id_Product_Category " +
                    $"Left join Suppliers " +
                    $"on Suppliers.Supplier_Id = Products.Id_Supplier ";
                }
            }
            public static string update_products(DataGridView Dgw, int index)
            {
                return $"update Products set Product_Name = '{Dgw.Rows[index].Cells[1].Value}' " +
                        $",Product_Price_ForSale = {Convert.ToInt32(Dgw.Rows[index].Cells[2].Value)} " +
                        $",Product_Amount = {Dgw.Rows[index].Cells[3].Value} " +
                        $" where Product_Id  = {Dgw.Rows[index].Cells[0].Value}";
            }
            public static string searchQuert_on_Name_Products(string SearchText)
            {
                return $"select * from Products where Product_Name like '%" + SearchText + "%'";
            }
            public static string select_Category_Id_AND_Product_Category_Form_Categories()
            {
                return $"select Category_Id, Product_Category from Categories";
            }
            public static string select_Supplier_Id_AND_Supplier_Name_From_Suppliers()
            {
                return $"select Supplier_Id, Supplier_Name from Suppliers";
            }
            public static string insert_into_Products(string Product_Name, double Product_Price_ForSale, int Id_Product_Category, int Id_Supplier)
            {
                string strValue = Product_Price_ForSale.ToString("F");
                strValue = strValue.Replace(",", ".");

                return $"insert into Products (Product_Name, Product_Price_ForSale, [Product_Amount], [Id_Product_Category] ,Id_Supplier) " +
                    $" values('{Product_Name}', {strValue}, 0 , {Id_Product_Category}, {Id_Supplier})";
            }
            public static string delete_from_Products_where_Product_Id(string Product_Id)
            {
                return $"delete from Products where Product_Id = '{Product_Id}'";
            }
            public static string select_Product_Id_AND_Product_Name_From_Products()
            {
                return "select Product_Id, Product_Name from Products";
            }
            public static string update_Product_Amount_where_Product_Id(int Product_Amount, int Product_Id)
            {
                return $"update Products set Product_Amount = Product_Amount + {Product_Amount} where Product_Id = {Product_Id}";
            }
            public static string insert_into_Orders(int Staffer_Id)
            {
                DateTime now = DateTime.Now;
                string sqlFormattedDate = now.ToString("yyyy-MM-dd HH:mm:ss");
                return "insert into Orders(Order_Date,Staffer_Id)" +
                    $"values('{sqlFormattedDate}', {Staffer_Id})";
            }
            public static string insert_into_Order_Details(int Order_Id, int Product_Id, int Count_Product)
            {
                return "insert into Order_Details(Order_Id,Product_Id,Count_Product)" +
                        $"values({Order_Id}, {Product_Id}, {Count_Product})";
            }
            public static string SELECT_SCOPE_IDENTITY()
            {
                return "SELECT top 1 Order_Id FROM Orders ORDER BY Order_Id DESC;";

            }
            public static string select_all_where_Order_Id(int Order_Id)
            {
                return $"select Order_Details.Order_Id, Products.Product_Name,  Order_Details.Count_Product " +
                        "from Order_Details " +
                        "left join Products " +
                        "on Order_Details.Product_Id = Products.Product_Id " +
                        $"where Order_Id = {Order_Id}";
            }
            public static string select_all_from_Orders()
            {
                return "select Orders.Order_Id, Orders.Order_Date, Staffers.Staffer_FIO " +
                    "from Orders " +
                    "left join Staffers " +
                    "on Orders.Staffer_Id = Staffers.Staffer_Id";
            }
            public static string delete_from_Orders_where_Order_Id(int Order_Id)
            {
                return $"delete from Orders where Order_Id = {Order_Id}";
            }
            public static string select_Category_Id_AND_Product_Category_From_Categories()
            {
                return "select Category_Id,Product_Category from Categories";
            }
            public static string update_Products_set_Product_Amount_where_Product_Id(int Product_Id, int count)
            {
                return $"update Products set Product_Amount = Product_Amount - {count} where Product_Id= {Product_Id};";
            }
            //детали заказа
            //categories
            public static string select_all_form_categories()
            {
                return "select * from Categories";
            }

            public static string insert_into_Categories(string Product_Category, string Category_Description)
            {
                return "insert into Categories (Product_Category,Category_Description)" +
                        $"values('{Product_Category}', '{Category_Description}')";
            }
            public static string delete_from_Categories_where_Category_Id(int Category_Id)
            {
                return $"delete from Categories where Category_Id = {Category_Id}";
            }

            //История входа 
            public static string select_all_from_history()
            {
                return "select * from history_login";
            }
            public static string insert_into_history(string Status_try, string Login_inp, string Access_inp)
            {
                string datetimeNow = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss");
                return "insert into history_login (Time_try, Status_try, Login_inp, Access_inp)" +
                        $" values('{datetimeNow}', '{Status_try}', '{Login_inp}','{Access_inp}' )";
            }
        }
    }
