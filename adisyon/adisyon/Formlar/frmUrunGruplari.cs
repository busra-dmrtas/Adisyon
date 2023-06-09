using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using adisyon.Modeller;

namespace adisyon.Formlar
{
    public partial class frmUrunGruplari : Form
    {
        RestoranEntities db = new RestoranEntities();
        public frmUrunGruplari()
        {
            InitializeComponent();
        }
        private void UrunGruplariGetir()
        {
            dataGridView1.DataSource = db.UrunGruplari.ToList();
            dataGridView1.Columns["Id"].ReadOnly = true;
        }

        private void frmUrunGruplari_Load(object sender, EventArgs e)
        {
            UrunGruplariGetir();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kaydet();
        }
        
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Kaydet();
            }
            
        }
        private void Kaydet()
        {
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Ürün grubu adını boş bırakmayınız!");
                return;
            }
            
            UrunGruplari ug = new UrunGruplari();
            ug.Adi = textBox1.Text;
            db.Entry(ug).State = System.Data.Entity.EntityState.Added;
            db.SaveChanges();
            textBox1.Clear();
            textBox1.Focus();
            UrunGruplariGetir();
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult cevap;
            cevap = MessageBox.Show("Silmek istediğinize emin misiniz?","Sil?",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);

            if (cevap!=DialogResult.Yes)
            {
                return;
            }
            DataGridViewRow seciliSatir = dataGridView1.CurrentRow;
            int seciliId=(int)seciliSatir.Cells["Id"].Value;

            UrunGruplari ug=db.UrunGruplari.Where(x=>x.Id==seciliId).FirstOrDefault();

            db.Entry(ug).State = System.Data.Entity.EntityState.Deleted;
            db.SaveChanges();
            UrunGruplariGetir();
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow degisenSatir = dataGridView1.Rows[e.RowIndex];
            int id=(int)degisenSatir.Cells["Id"].Value;
            string adi=degisenSatir.Cells["Adi"].Value.ToString();

            //var ug = db.UrunGruplari.Where(x=>x.Id==id).FirstOrDefault();
            var ug = db.UrunGruplari.FirstOrDefault(x => x.Id == id);

            ug.Adi = adi;
            db.Entry(ug).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();

        }
    }
}
