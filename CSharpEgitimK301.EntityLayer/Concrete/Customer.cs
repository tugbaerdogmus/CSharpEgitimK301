using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimK301.EntityLayer.Concrete
{
    public class Customer
    {
        public int CustomerId { get;set; }
        public int CustomerName { get;set; }
        public int CustomerSurname { get;set; }
        public int CustomerDistrict { get;set; }
        public int CustomerCity { get;set; }
        public List<Order> Orders { get;set; }
        public bool CustomerStatus { get;set; }
    }
}
