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
    internal class EfProductDal: GenericRepository<Product>, IProductDal
    {
    }
}
