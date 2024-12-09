using CSharpEgitimK301.DataAccessLayer.Abstract;
using CSharpEgitimK301.DataAccessLayer.Repositories;
using CSharpEgitimK301.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimK301.DataAccessLayer.EntityFramework
{
    public class EfAdminDal:GenericRepository<Admin>,IAdminDal
    {
    }
}
/* biz GenericRepository'de ekleme silme güncelleme listeleme ve id'ye göre getirme işlemlerinin 
 * tamamını T'ye göre yaptık şimdi bu T'ler entity olarak değişecek ve entitylerin yerini alıp 
 * her bir entitymiz bütün crud işlmeleri ile haberleşicek 
 */
/* entityye özgü olmayan metotlar ekle, sil güncelle listele id'ye göre getir 
 entitye özgü örnek içinde a harfi geçmeyen kullanıcıları listele 
Burada IAdminDal'dan miras almamızın sebebi entitye özgü metotlar yazabilmemiz için
 */