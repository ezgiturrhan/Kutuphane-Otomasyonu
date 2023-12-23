using Okul.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Okul
{
    public partial class KitapListesi : Form
    {
        public KitapListesi()
        {
            InitializeComponent();
        }

        private void KitapListesi_Load(object sender, EventArgs e)
        {
            OkulEntities db = new OkulEntities();
            var kitaplar = db.Kitap.Where(x=> x.StokMiktari<1).ToList();
            dataGridView1.DataSource = kitaplar;
        }

        private void btnfiltre_Click(object sender, EventArgs e)
        {
            OkulEntities db = new OkulEntities();
            var kitaplar = db.Kitap.Where(x => x.Adı.Contains(txtkitapId.Text) || x.Yazar.Contains(txtkitapId.Text) || x.KategoriAdı.Contains(txtkitapId.Text)).ToList();
            dataGridView1.DataSource = kitaplar;
        }

        private void btnkitapal_Click(object sender, EventArgs e)
        {
            OkulEntities db = new OkulEntities();
            if (txtkitapId.Text != null)
            {
                int Id = Convert.ToInt32(txtkitapId.Text);
                var kitap = db.Kitap.Where(x => x.Id == Id).FirstOrDefault();
                int KullaniciId = Properties.Settings.Default.kullaniciId;
                int alinankitapsayisi= db.AlinanKitaplarr.Where(x => x.KullaniciId == KullaniciId).ToList().Count();
                if (kitap.StokMiktari>0 && alinankitapsayisi<2)
                {
                    kitap.StokMiktari -= 1;
                    AlinanKitaplarr alinanKitaplar = new AlinanKitaplarr
                    {
                        KitapId = Id,
                        KullaniciId = KullaniciId,
                    };
                    db.AlinanKitaplarr.Add(alinanKitaplar);
                    db.SaveChanges();
                }
            }
        }
    }
}
