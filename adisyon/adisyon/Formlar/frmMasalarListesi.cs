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
    public partial class frmMasalarListesi : Form
    {
        public frmMasalarListesi()
        {
            InitializeComponent();
        }

        private void frmMasalarListesi_Load(object sender, EventArgs e)
        {
            var db = new adisyon.Modeller.RestoranEntities();
            List<Modeller.Masalar> kayitliMasalar = db.Masalar.ToList();

            foreach (var masa in kayitliMasalar)
            {
                Button b = new Button();
                b.Name = "button" + masa.Id.ToString();
                b.Size = new System.Drawing.Size(150, 150);
                b.Text = masa.Adi;
                b.Parent = flowLayoutPanel1;
                b.Tag = masa.Id;

                if ((bool)masa.AcikMi)
                {
                    b.BackColor = Color.DarkGreen;
                }
                else
                {
                    b.BackColor = Color.DarkRed;
                    
                }
                b.Click += ButtonTiklama;
            }
        }

        private void ButtonTiklama(object sender, EventArgs e)
        {
            Button b = sender as Button;
            frmSiparis f = new frmSiparis((int)b.Tag);
            f.ShowDialog();
        }
    }
}
