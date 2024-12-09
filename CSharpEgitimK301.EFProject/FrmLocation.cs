﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimK301.EFProject
{
    public partial class FrmLocation : Form
    {
        public FrmLocation()
        {
            InitializeComponent();
        }
        EgitimKEftravelDbEntities2 db =new EgitimKEftravelDbEntities2();
        private void button1_Click(object sender, EventArgs e)
        {
            var values = db.Location.ToList();
            dataGridView1.DataSource = values;
        }

        private void FrmLocation_Load(object sender, EventArgs e)
        {
            var values = db.Guide.Select(x => new
            {
                FullName = x.GuideName + " " + x.GuideSurname,
                x.GuideId
            }).ToList();
            cmbGuide.DisplayMember = "FullName";
            cmbGuide.ValueMember = "GuideId";
            cmbGuide.DataSource = values;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Location location=new Location();
            location.Capacity = byte.Parse(nudCapacity.Value.ToString());
            location.City = txtCity.Text;
            location.Country = txtCountry.Text;
            location.Price = decimal.Parse(txtPrice.Text);
            location.DayNight = txtDayNight.Text;
            location.GuideId = int.Parse(cmbGuide.SelectedValue.ToString());
            db.Location.Add(location);
            db.SaveChanges();
            MessageBox.Show("ekleme başarılı");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var deletedValue = db.Location.Find(id);
            db.Location.Remove(deletedValue);
            db.SaveChanges();
            MessageBox.Show("silme başarılı");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int id=int.Parse(txtId.Text);
            var updateValue = db.Location.Find(id);
            updateValue.DayNight=txtDayNight.Text;
            updateValue.Price = decimal.Parse(txtPrice.Text);
            updateValue.Capacity=byte.Parse(nudCapacity.Value.ToString());
            updateValue.City = txtCity.Text;
            updateValue.Country=txtCountry.Text;
            updateValue.GuideId=int.Parse(cmbGuide.SelectedValue.ToString());
            db.SaveChanges();
            MessageBox.Show("güncelleme başarılı");
        }
    }
}
