using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Customer_CRUD.Model
{

    // database field 

    public class Customer
    {

       public int CustomerId { get; set; }
       
        public string CustomerName { get; set; }

        public string CustomerCity { get; set; }

    }
}
