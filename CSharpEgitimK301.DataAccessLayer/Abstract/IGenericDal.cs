using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimK301.DataAccessLayer.Abstract
{
    public interface IGenericDal<T> where T:class
    {
        //burada bize merkeziyetli bir sistem sun
        void Insert(T entity);
        void Update(T entity);
        void Delete(int id);
        List<T> GetAll(); 
        T GetTById(int id);
    }
}
/*
 burada başka metotlarda ekleyebiliriz 
burada yazacağımız metot entity'e özgü olmalı 
buraad yazacağımız her metotu o yüzden genericAl'la haberleştrmek gerekiyor

 */