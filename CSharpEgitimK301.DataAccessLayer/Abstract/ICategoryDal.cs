using CSharpEgitimK301.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimK301.DataAccessLayer.Abstract
{
    public interface ICategoryDal: IGenericDal<Category>
    {
    }
}

/*
 public interface ICategoryDal: IGenericDal<Category>
bu kısım da kategory sınıfı için vrud işlemleri hazır hale gelmiş olur 
 */