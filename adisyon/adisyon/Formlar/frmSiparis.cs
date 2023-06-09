using adisyon.Modeller;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace adisyon.Formlar
{
    public partial class frmSiparis : Form
    {
        int masaId;
        Modeller.Masalar masa;
        Modeller.RestoranEntities db=new Modeller.RestoranEntities();
        int aktifSiparisId = -1;
        public frmSiparis(int gonderenMasaId) 
        {
            InitializeComponent();

            masaId = gonderenMasaId;
            masa = db.Masalar.FirstOrDefault(x => x.Id == masaId);
            label1.Text =masa.Adi;
        }

        private void frmSiparis_Load(object sender, EventArgs e)
        {
            Siparisler aktifSiparisler = db.Siparisler.Where(x => x.MasaId == masaId && x.AcikMi == true).FirstOrDefault();
            if(aktifSiparisler != null)
            {
                aktifSiparisId = aktifSiparisler.Id;
            }
            SiparisleriGetir();

            List<UrunGruplari> urunGrupları=db.UrunGruplari.ToList();

            foreach (var ug in urunGrupları)
            {
                Button b = new Button();
                b.Name="btnUrunGrubu"+ ug.Id.ToString();
                b.Text = ug.Adi;
                b.Tag = ug.Id;
                b.Size = new Size(120, 60);
                b.Parent = flpUrunGruplari;
                b.Click += UrunGrubuClick;


            }
        }

        private void UrunGrubuClick(object sender, EventArgs e)
        {
            Button btn=sender as Button;
            int urunGrubuId= (int)btn.Tag;
            List<Urunler> urunler =db.Urunler.Where(x => x.GrupId == urunGrubuId).ToList();
            flpUrunler.Controls.Clear();
            foreach (var u in urunler)
            {
                Button b = new Button();
                b.Name = "btnUrun" + u.Id.ToString();
                b.Text = u.Adi;
                b.Tag = u.Id;
                b.Size = new Size(120, 70);
                b.Parent = flpUrunler;
                b.Click += UrunButtonClick;
                
            }
        }
        private void UrunButtonClick(object sender, EventArgs e)
        {
            //bu ürün siparişe eklencek
            //bu masanın açık siparişi var mı
            //açık sipariş varsa ürün o siparişe eklenecek
            //açık sipariş yoksa sipariş açılacak ve ürün o siparişe eklenecek

            Siparisler aktifSiparis = db.Siparisler.Where(x=> x.MasaId==masaId && x.AcikMi==true).FirstOrDefault();

            if (aktifSiparis == null)
            {
                aktifSiparis=new Siparisler();
                aktifSiparis.MasaId=masaId;
                aktifSiparis.AcikMi=true;
                aktifSiparis.AcilmaZamani=DateTime.Now;
                db.Entry(aktifSiparis).State = System.Data.Entity.EntityState.Added;
                db.SaveChanges();

                masa.AcikMi = true;
                db.Entry(masa).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
            aktifSiparisId=aktifSiparis.Id;
            label5.Text=((DateTime)aktifSiparis.AcilmaZamani).ToLongDateString();

            Button urunBtn=sender as Button;
            int urunId=(int)urunBtn.Tag;
            Urunler urun =db.Urunler.Where(x=> x.Id== urunId).FirstOrDefault();

            SiparisDetay siparisDetay=db.SiparisDetay.Where(x=> x.SiparisId== aktifSiparisId && x.UrunId==urunId).FirstOrDefault();
            if (siparisDetay == null)
            {

                SiparisDetay sd = new SiparisDetay
                {
                    Fiyati = urun.Fiyat,
                    Miktar = 1,
                    SiparisId = aktifSiparisId,
                    UrunId = urun.Id,
                    Tutar = urun.Fiyat * 1
                };
                db.Entry(sd).State = System.Data.Entity.EntityState.Added;
                db.SaveChanges();
            }
            else
            {
                siparisDetay.Miktar++;
                siparisDetay.Tutar = siparisDetay.Miktar * siparisDetay.Fiyati;
                db.Entry(siparisDetay).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }

            SiparisleriGetir();
        }
        private void SiparisleriGetir()
        {
            //List<SiparisDetay> siparisler = db.SiparisDetay.Where(x=> x.SiparisId==aktifSiparisId).ToList();

            var siparisDetaylari = (
                from sd in db.SiparisDetay
                join u in db.Urunler on sd.UrunId equals u.Id
                where sd.SiparisId==aktifSiparisId
                select new
                {
                    Urun=u.Adi,
                    Miktar=sd.Miktar,
                    Fiyat=sd.Fiyati,
                    Tutar=sd.Tutar
                }
                ).ToList();

            dataGridView1.DataSource = siparisDetaylari;
            label3.Text= siparisDetaylari.Select(x => (decimal)x.Tutar).Sum().ToString();
        }
    }
}
