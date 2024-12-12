using CSharpEgitimK301.BusinessLayer.Abstract;
using CSharpEgitimK301.BusinessLayer.Concrete;
using CSharpEgitimK301.DataAccessLayer.EntityFramework;
using CSharpEgitimK301.EntityLayer.Concrete;
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
    public partial class FrmCategory : Form
    {
        private readonly ICategoryService _categoryService; // field örnekleme

        public FrmCategory()
        {
            _categoryService = new CategoryManager(new EfCategoryDal());
            InitializeComponent();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            //burada sınıf üzerinde çalışacağız ??
            var categoryValues = _categoryService.TGetAll();
            dataGridView1.DataSource = categoryValues;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Category category=new Category();
            category.CategoryName=txtCatName.Text;
            category.CategoryStatus = true;
            _categoryService.TInsert(category);//business de ki metot TInsert
            MessageBox.Show("ekleme başarılı");
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
           int id=int.Parse(txtId.Text);
            var deletedValues=_categoryService.TGetTById(id);
            _categoryService.TDelete(deletedValues);
            MessageBox.Show("silme başarılı");
        }

        private void btnGetById_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var values = _categoryService.TGetTById(id);
            dataGridView1.DataSource = values;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int updatedID=int.Parse(txtId.Text);
            var updatedValues = _categoryService.TGetTById(updatedID);
            updatedValues.CategoryName = txtCatName.Text;
            updatedValues.CategoryStatus = true;
            _categoryService.TUpdate(updatedValues);
        }
    }
}
