﻿using CSharpEgitimK301.DataAccessLayer.Abstract;
using CSharpEgitimK301.DataAccessLayer.Context;
using CSharpEgitimK301.DataAccessLayer.Repositories;
using CSharpEgitimK301.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimK301.DataAccessLayer.EntityFramework
{
    public class EfProductDal : GenericRepository<Product>, IProductDal
    {
        public List<Object> GetProductWithCategory()
        {
            var context = new KampContext();
            //aşağıdaki ifadeyle buradaki sınıftan aşağıdaki tabloya atama yapmak 
            var values = context.Products
                .Select(x => new 
                {
                    ProductID = x.ProductID,
                    ProductName = x.ProductName,
                    ProductStock = x.ProductStock,
                    ProductPrice = x.ProductPrice,
                    ProductDescription = x.ProductDescription,
                    CategoryName = x.Category.CategoryName
                }).ToList();
            return values.Cast<object>().ToList();
        }
    }
}
