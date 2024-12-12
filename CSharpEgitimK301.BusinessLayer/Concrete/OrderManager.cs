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
    public class OrderManager : IOrderService
    {
        private readonly IOrderDal _orderDal;

        public OrderManager(IOrderDal orderDal)
        {
            _orderDal = orderDal;
        }

        public void TDelete(Order entity)
        {
            _orderDal.Delete(entity);
        }

        public List<Order> TGetAll()
        {
            return _orderDal.GetAll();
        }

        public Order TGetTById(int id)
        {
           return _orderDal.GetTById(id);
        }

        public void TInsert(Order entity)
        {
            _orderDal.Insert(entity);
        }

        public void TUpdate(Order entity)
        {
            _orderDal.Update(entity);
        }
    }
}
/* burada IOrderdal'ı kullanma sebebi biz business katmanı metotlarını 
 * başında T olanları presentationda çağıracağız  ama 
 * bussiness katmaının içinde dataaccess katmanının metotlarını çağıracağız 
 * yani Tdelete çağırıldığı zaman aslında yapacağı işlem   _orderDal.Delete(entity);'den gelen değeri silmek 
 */