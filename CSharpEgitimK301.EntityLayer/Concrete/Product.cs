using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimK301.EntityLayer.Concrete
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int ProductStock { get; set; }
        public decimal ProductPrice { get; set; }
        public string ProductDescription { get; set; }
        public int CategoryID { get; set; }
        //burada üründen kaegoriye gitmek adına ve
        //ilişkinin bireçok kısmının bir kısmını yapabilmek için
        public virtual Category Category { get; set; } 
        //ilişkinin tanımlanabilmesi için
        public List<Order> Orders { get; set; }
        //ilişkiyi oluşturmak iin
    }
}
