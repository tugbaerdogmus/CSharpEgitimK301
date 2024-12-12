using CSharpEgitimK301.DataAccessLayer.Abstract;
using CSharpEgitimK301.DataAccessLayer.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimK301.DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        KampContext context=new KampContext(); //nesne örneğimiz 
        private readonly DbSet<T> _object; //bu field 

        public GenericRepository()
        {
            _object=context.Set<T>();
        }
        public void Delete(T entity)
        {
            var deletedEntity=context.Entry(entity);
            deletedEntity.State = EntityState.Deleted;
            context.SaveChanges();
            /* bu bizim için bir enum olarak geliyor, silme işlemi entityden gelen değere göre yapılır 
              EntityState ekleme silme güncelleme gibi bazı değişikliklere izin veren bir kod bloğu 
             */
        }

        public List<T> GetAll()
        {
            return _object.ToList();
        }

        public T GetTById(int id)
        {
            return _object.Find(id);
        }

        public void Insert(T entity)
        {
            var addedEntity=context.Entry(entity);
            addedEntity.State = EntityState.Added;
            context.SaveChanges();
        }

        public void Update(T entity)
        {
            var updatedEntity=context.Entry(entity);
            updatedEntity.State = EntityState.Modified; // modified = update .net framework de 
            context.SaveChanges();
        }
    }
}
