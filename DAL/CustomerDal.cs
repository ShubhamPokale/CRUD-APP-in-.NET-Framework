using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Data;
using System.IO;
using Customer_CRUD.Model;

namespace Customer_CRUD.DAL
    
{
    public class CustomerDal
    {

        public List<Customer> GetAllCustomers()
        {
            using (MySqlConnection CN = new MySqlConnection(ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString))
            {
                using (MySqlCommand CMD = new MySqlCommand())
                {

                    CN.Open();
                    CMD.Connection = CN;
                    CMD.CommandType = CommandType.StoredProcedure;
                    CMD.CommandText = "GetAllCustomer";
                    MySqlDataReader DR = CMD.ExecuteReader();
                    List<Customer> customers = new List<Customer>();

                    while (DR.Read()) {

                        customers.Add(
                            new Customer()
                            {

                                CustomerId = Convert.ToInt32(DR["CustomerId"]),
                                CustomerName = Convert.ToString(DR["CustomerName"]),
                                CustomerCity = Convert.ToString(DR["CustomerCity"])

                            });
                    
                    }

                    DR.Close();
                    CN.Close();
                    return customers;


                }
                    
            }

        
        }

        public int InsertCustomer(Customer customer) {


            using (MySqlConnection CN = new MySqlConnection(ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString))
            {

                using (MySqlCommand CMD = new MySqlCommand())
                { 
                
                       CN.Open(); 
                       CMD.Connection = CN;
                    CMD.CommandType = CommandType.StoredProcedure;
                    CMD.CommandText = "InsertCustomer";
       
                    CMD.Parameters.AddWithValue("P_CustomerId", customer.CustomerId);
                    CMD.Parameters.AddWithValue("P_CustomerName", customer.CustomerName);
                    CMD.Parameters.AddWithValue("P_City", customer.CustomerCity);
                    int result = CMD.ExecuteNonQuery();

                    return result;
                }
            
            }

        
        }

        public int UpdateCustomer(Customer customer)
        {
            using (MySqlConnection CN = new MySqlConnection(ConfigurationManager.ConnectionStrings["InfowayPoDbConStr"].ConnectionString))
            {
                using (MySqlCommand CMD = new MySqlCommand())
                {
                    CN.Open();
                    CMD.Connection = CN;
                    CMD.CommandType = CommandType.StoredProcedure;
                    CMD.CommandText = "UpdateCustomer";
                    CMD.Parameters.AddWithValue("p_CustomerId", customer.CustomerId);
                    CMD.Parameters.AddWithValue("p_ContactName", customer.CustomerName);
                    CMD.Parameters.AddWithValue("p_City", customer.CustomerCity);
                    int result = CMD.ExecuteNonQuery();
                    return result; 
                }
            }
        }

        public int DeleteCustomer(Customer customer)
        {
            using (MySqlConnection CN = new MySqlConnection(ConfigurationManager.ConnectionStrings["InfowayPoDbConStr"].ConnectionString))
            {
                using (MySqlCommand CMD = new MySqlCommand())
                {
                    CN.Open();
                    CMD.Connection = CN;
                    CMD.CommandType = CommandType.StoredProcedure;
                    CMD.CommandText = "DeleteCustomer";
                    CMD.Parameters.AddWithValue("p_CustomerId", customer.CustomerId);
                    int result = CMD.ExecuteNonQuery();
                    return result;
                }
            }
        }






    }
}
