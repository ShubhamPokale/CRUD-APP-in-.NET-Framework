using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Customer_CRUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            using (MySqlConnection CN = new MySqlConnection(ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString))
            {

                using (MySqlCommand CMD = new MySqlCommand())
                { 
                    CN.Open();
                    CMD.Connection = CN;
                    CMD.CommandType = CommandType.StoredProcedure;
                    CMD.CommandText = "GetAllCustomers";
                    MySqlDataReader DR = CMD.ExecuteReader();


                    DataTable Customer = new DataTable("Customer");
                        Customer.Load(DR);
                    dgvCustomer.DataSource = Customer;
                    CN.Close();
                
                }
            
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }
    }
}
