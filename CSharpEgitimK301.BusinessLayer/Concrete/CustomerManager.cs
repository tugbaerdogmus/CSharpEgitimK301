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
    public class CustomerManager : ICustomerService
    {
        private readonly ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }
        public void TDelete(Customer entity)
        {
            _customerDal.Delete(entity);
        }
        public List<Customer> TGetAll()
        {
            return _customerDal.GetAll();
        }
        public Customer TGetTById(int id)
        {
            return _customerDal.GetTById(id);
        }
        public void TInsert(Customer entity)
        {
            if(entity.CustomerName != "" && entity.CustomerName.Length >= 3 && entity.CustomerCity != null &&
                entity.CustomerSurname != "" && entity.CustomerSurname.Length <= 30)
            {
                // bu işlemler validadasyon işlemleri
                //ekleme işlemi yap
                //şartlar böyle yazılmaz burada bir kütüphaneye ihtiyacımız var clean code için
                _customerDal.Insert(entity);
            }
            else
            {
                // hata mesajı ver bunlar için validasyon kütüphaneleri tercih edilebiliyor
            }
        }
        public void TUpdate(Customer entity)
        {
            _customerDal.Update(entity);
        }
    }
}
//dataaccess katmanının aynısını yazıyoruz ama fark şu validasyon şartları var (ör insert içi) diğer metotlar içine de yazılabilir bu validasyon 