using CSharpEgitimK301.BusinessLayer.Abstract;
using CSharpEgitimK301.DataAccessLayer.Abstract;
using CSharpEgitimK301.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimK301.BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDal _categoryDal; //bu bir field çünkü bir classın içierisinde direkt olarak tanımlandı metotun içinde değişken eğer sonunda get set olsa property olur
        //eğer _ kullanmazsak bu sefer this atıyor constuctor oluştururken ve metotların içinde de çağırırken thisle çağırıyoruz _ daha kolay 
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void TDelete(Category entity)
        {
            _categoryDal.Delete(entity);
            //bu delete metodu dataaccess de, entityden gelen değeri silecek 
        }
        public List<Category> TGetAll()
        {
            return _categoryDal.GetAll();
        }
        public Category TGetTById(int id)
        {
            return _categoryDal.GetTById(id);
        }
        public void TInsert(Category entity)
        {
            _categoryDal.Insert(entity);
        }
        public void TUpdate(Category entity)
        {
            _categoryDal.Update(entity);
        }
    }
}
//burada dataaccess katmanındaki metotları çağırmış olduk business katmanındaki metotların içine 