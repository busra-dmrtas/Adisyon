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
    public partial class frmUrunler : Form
    {
        Modeller.RestoranEntities db=new Modeller.RestoranEntities();
        public frmUrunler()
        {
            InitializeComponent();
        }
        public void UrunleriGetir()
        {
            dataGridView1.DataSource = db.Urunler.ToList();
        }

        private void frmUrunler_Load(object sender, EventArgs e)
        {
            UrunleriGetir();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmUrunEkle f=new frmUrunEkle(this);
            if (f.ShowDialog() == DialogResult.OK)
                UrunleriGetir();
        }
    }
}
