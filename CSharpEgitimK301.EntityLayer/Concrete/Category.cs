using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimK301.EntityLayer.Concrete
{
    public class Category
    {
        public int CategoryID { get; set; }
        /*Önemli: bunun Codefirst tarafında birincil anahtar olduğunu 
         * otamatik artan olduğunu bildirmek amacıyla 
         * sınıfın isminin birebir aynı yazılmalı ve 
         * sonuna Id yazılmalı 
         */
        public string CategoryName { get; set; }
        public bool CategoryStatus { get; set; }
        public List<Product> Products { get; set; }
        //ürünle bağlantıyı haberdar etmek için 
        // buranın çoğul olmasının sebebi birden fazla olabilir yani birden fazla ürün gibi
        //bu bire çok ilişki 
    }
}

/*
 Field - Variable - Property
 
bir değişken diğer sınıfın içinde tanımlanırsa: Field
sınıfın içinde tanımlanan bu değişken sonuna get set alırsa: property 
bir metot içinde tanımlanıyorsa: değişken
 
 */
