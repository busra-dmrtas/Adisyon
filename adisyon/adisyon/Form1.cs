using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace adisyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void masaTanımlamalarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formlar.frmMasalar r=new Formlar.frmMasalar();
            r.ShowDialog();
        }

        private void ürünGrubuTanımlamalarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formlar.frmUrunGruplari f=new Formlar.frmUrunGruplari();
            f.ShowDialog();
        }

        private void ürünTanımlamalarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formlar.frmUrunler f= new Formlar.frmUrunler();
            f.ShowDialog();
        }

        private void masalarListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formlar.frmMasalarListesi f=new Formlar.frmMasalarListesi();
            f.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
