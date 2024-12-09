
using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        EgitimKEftravelDbEntities2 db = new EgitimKEftravelDbEntities2();
        private void button1_Click(object sender, EventArgs e)
        {
            var values = db.Guide.ToList();
            dataGridView1.DataSource = values;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Guide guide = new Guide();
            guide.GuideName = txtAd.Text;
            guide.GuideSurname = txtSoyad.Text;
            db.Guide.Add(guide);
            db.SaveChanges();
            MessageBox.Show("rehber eklendi");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var removeValue = db.Guide.Find(id);
            db.Guide.Remove(removeValue);
            db.SaveChanges();
            MessageBox.Show("silindi");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int id=int.Parse(txtId.Text);
            var updateValue=db.Guide.Find(id);
            updateValue.GuideName = txtAd.Text;
            updateValue.GuideSurname= txtSoyad.Text;
            db.SaveChanges();
            MessageBox.Show("güncellendi", "uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int id= int.Parse(txtId.Text);
            var values = db.Guide.Where(x => x.GuideId == id).ToList();
            dataGridView1.DataSource = values;
        }
    }
}
