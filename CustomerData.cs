using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;//connect sql server
using System.Data;//DataTable,DataSet
//DataTable: Row and Column
//DataSet: Multiple table
namespace CustomerDbConsole
{
    //ADO.NET - Connected mode(connection open and close) and disconnected mode
    public class CustomerData
    {
        public static string sqlConnectionStr = @"Data Source=IN-L-7402600\SQLEXPRESS;Initial Catalog=BankDb;Integrated Security=True";
        public string InsertCustomer(int id, string name, string email, string address, int mobile)
        {
            #region connected mode
            //insert customer data into sqlserver
            //SqlConnection sqlConnection = new SqlConnection(sqlConnectionStr);//connection establishment
            //SqlCommand cmd = new SqlCommand("insert into Customer values(" + id + ",'" + name + "','" + email + "'," + mobile + ",'" + address + "')", sqlConnection);
            //sqlConnection.Open();//connection state is open
            //int result = cmd.ExecuteNonQuery();//execute my sql commands 1
            //sqlConnection.Close(); //connection state is close
            //if (result == 0)
            //    return "Not inserted";
            //return "Inserted";
            #endregion

            #region disconnected mode
            //insert customer data into sqlserver
            SqlConnection sqlConnection = new SqlConnection(sqlConnectionStr);//connection establishment
            SqlDataAdapter adp = new SqlDataAdapter("insert into Customer values(" + id + ",'" + name + "','" + email + "'," + mobile + ",'" + address + "')", sqlConnection);
            DataTable dt = new DataTable();
            adp.Fill(dt); //execute my sql commands 1
            return "Inserted";
            #endregion
        }
        public string UpdateCustomer(int id, string name, string email, string address, int mobile)
        {
            #region connected mode
            //insert customer data into sqlserver
            //SqlConnection sqlConnection = new SqlConnection(sqlConnectionStr);//connection establishment
            //SqlCommand cmd = new SqlCommand("update Customer set CustName='" + name + "' , Email='" + email + "' , Mobile=" + mobile + " , CustAddress='" + address + "' where custid=" + id + "", sqlConnection);
            //sqlConnection.Open();//connection state is open
            //int result = cmd.ExecuteNonQuery();//execute my sql commands 1
            //sqlConnection.Close(); //connection state is close
            //if (result == 0)
            //    return "Not Updated";
            //return "Updated";
            #endregion

            #region disconnected mode
            SqlConnection sqlConnection = new SqlConnection(sqlConnectionStr);//connection establishment
            SqlDataAdapter adp = new SqlDataAdapter("update Customer set CustName='" + name + "' , Email='" + email + "' , Mobile=" + mobile + " , CustAddress='" + address + "' where custid=" + id + "", sqlConnection);
            DataTable dt = new DataTable();
            adp.Fill(dt);//execute my sql commands 1
            return "Updated";
            #endregion
        }
        public string DeleteCustomer(int custId)
        {
            SqlConnection sqlConnection = new SqlConnection(sqlConnectionStr);//connection establishment
            SqlCommand cmd = new SqlCommand("delete from Customer where custid=" + custId, sqlConnection);
            sqlConnection.Open();//connection state is open
            int result = cmd.ExecuteNonQuery();//execute my sql commands 1
            sqlConnection.Close(); //connection state is close
            if (result == 0)
                return "Not Deleted";
            return "Deleted";
        }
        public DataTable SelectCustomers()
        {
            #region connected mode
            //SqlConnection sqlConnection = new SqlConnection(sqlConnectionStr);//connection establishment
            //string db = sqlConnection.Database;
            //SqlCommand cmd = new SqlCommand("select * from Customer", sqlConnection);
            //sqlConnection.Open();//connection state is open
            //SqlDataReader dataReader = cmd.ExecuteReader();//execute select statment
            //DataTable dataTable = new DataTable();
            //dataTable.Load(dataReader);
            ////DataTable, DataSet
            //sqlConnection.Close(); //connection state is close
            //return dataTable;
            #endregion

            #region disconnected mode
            SqlConnection sqlConnection = new SqlConnection(sqlConnectionStr);//connection establishment
            SqlDataAdapter adp = new SqlDataAdapter("select * from Customer", sqlConnection);
            DataTable dataTable = new DataTable();
            adp.Fill(dataTable);
            return dataTable;
            #endregion
        }
        public DataTable SelectCustomerById(int custId)
        {
            SqlConnection sqlConnection = new SqlConnection(sqlConnectionStr);//connection establishment
            string db = sqlConnection.Database;
            SqlCommand cmd = new SqlCommand("select * from Customer where custid=" + custId, sqlConnection);
            sqlConnection.Open();//connection state is open
            SqlDataReader dataReader = cmd.ExecuteReader();//execute select statment
            DataTable dataTable = new DataTable();
            dataTable.Load(dataReader);
            //DataTable, DataSet
            sqlConnection.Close(); //connection state is close
            return dataTable;
        }
    }
}
