using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace adisyon.Formlar
{
    public partial class frmUrunEkle : Form
    {
        Modeller.RestoranEntities db=new Modeller.RestoranEntities();
        frmUrunler globalUrunlerFormu;
        public frmUrunEkle(frmUrunler frmUrunlerFormu)
        {
            InitializeComponent();
            globalUrunlerFormu = frmUrunlerFormu;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void frmUrunEkle_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = db.UrunGruplari.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Modeller.Urunler urun = new Modeller.Urunler
            {
                Adi = textBox1.Text,
                GrupId = (int)comboBox1.SelectedValue,
                Fiyat = numericUpDown1.Value
            };
            db.Entry(urun).State = System.Data.Entity.EntityState.Added;
            db.SaveChanges();
            this.DialogResult=DialogResult.OK; 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Modeller.Urunler urun = new Modeller.Urunler
            {
                Adi = textBox1.Text,
                GrupId = (int)comboBox1.SelectedValue,
                Fiyat = numericUpDown1.Value
            };
            db.Entry(urun).State = System.Data.Entity.EntityState.Added;
            db.SaveChanges();
            MessageBox.Show("Ürün eklendi");

            globalUrunlerFormu.UrunleriGetir();

            numericUpDown1.Value = 0;
            textBox1.Text = "";
        }
    }
}
