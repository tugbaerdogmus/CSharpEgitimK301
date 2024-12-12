﻿using CSharpEgitimK301.BusinessLayer.Abstract;
using CSharpEgitimK301.BusinessLayer.Concrete;
using CSharpEgitimK301.DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimK301.PresentationLayer
{
    public partial class FrmProduct : Form
    {
        private readonly IProductService _productService;

        public FrmProduct()
        {
            InitializeComponent();
            _productService = new ProductManager(new EfProductDal());
        }
        private void btnList_Click(object sender, EventArgs e)
        {
            var values = _productService.TGetAll();
            dataGridView1.DataSource = values;
        }

        private void btnList2_Click(object sender, EventArgs e)
        {
            var values = _productService.TGetProductsWithCategory();
            dataGridView1.DataSource = values;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            //_productService.TDelete
        }
    }
}
