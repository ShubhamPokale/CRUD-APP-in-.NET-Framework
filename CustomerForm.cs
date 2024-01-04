using Customer_CRUD.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Customer_CRUD.Model;
namespace Customer_CRUD
{
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
        }

        CustomerDal customerDal = new CustomerDal();
        int index = 0;
        List<Customer> customerList;


        private void button7_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer()
            {
                CustomerId = int.Parse(CustomerIDTextBox.Text),
                CustomerName = CustomerNameTextBox.Text,
                CustomerCity = CityTextBox.Text,
            };
            int result = customerDal.InsertCustomer(customer);

            if (result > 0)
            {
            
                customerList = customerDal.GetAllCustomers();
          
            }
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {

            customerList = customerDal.GetAllCustomers();
            Navigate(index);

        }

        private void Navigate(int currentIndex)
        {

            if (customerList.Count > 0)
            { 
            //id 
            // name
            // city
                CustomerIDTextBox.Text = customerList[currentIndex].CustomerId.ToString();  
                CustomerNameTextBox.Text = customerList[currentIndex].CustomerName.ToString();  
                CityTextBox.Text = customerList[currentIndex].CustomerCity.ToString();  

       
            }

        
        }

        private void CustomerIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CustomerNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CityTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void JumpToFirstButtonClick_Click(object sender, EventArgs e)
        {
            index = 0;
            Navigate(index); 
        }

        private void JumpToLastButtonClick_Click(object sender, EventArgs e)
        {
            index = customerList.Count - 1;
            Navigate(index);
        }

        private void PreviousButtonClick_Click(object sender, EventArgs e)
        {
            if (index > 0)
            {
                index--;
                Navigate(index);
            
            }
        }

        private void NextButtonClick_Click(object sender, EventArgs e)
        {
            if (index < customerList.Count - 1)
            {
                index++;
                Navigate(index);    
            }
        }

        private void NewButtonClick_Click(object sender, EventArgs e)
        {
            CustomerIDTextBox.Text = string.Empty;
            CustomerNameTextBox.Text = string.Empty;    
            CityTextBox.Text = string.Empty;
            CustomerIDTextBox.Focus();
        }

        private void UpdateButtonClick_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer()
            {
                CustomerId = int.Parse(CustomerIDTextBox.Text),
                CustomerName = CustomerNameTextBox.Text,
                CustomerCity = CityTextBox.Text
            };

            int result = customerDal.UpdateCustomer(customer);
            if (result > 0)
            {

                customerList = customerDal.GetAllCustomers();
            
            }
        }

        private void DeleteButtonClick_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer()
            {

                CustomerId = int.Parse(CustomerIDTextBox.Text),
                CustomerName = CustomerNameTextBox.Text,
                CustomerCity = CityTextBox.Text


            };

            int result = customerDal.DeleteCustomer(customer);
            if (result > 0)
            {

                customerList = customerDal.GetAllCustomers();

            }


        }
    }
}
