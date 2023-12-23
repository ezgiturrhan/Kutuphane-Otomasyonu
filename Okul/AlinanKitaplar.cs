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
    public partial class AlinanKitaplar : Form
    {
        public AlinanKitaplar()
        {
            InitializeComponent();
        }

        private void AlinanKitaplar_Load(object sender, EventArgs e)
        {
            OkulEntities db = new OkulEntities();
            int KullaniciId = Properties.Settings.Default.kullaniciId;
            var kitaplar = db.AlinanKitaplarr.Where(x => x.KullaniciId == KullaniciId).Select(b => new
            {
                
                b.Kitap.Adı,
                b.Kitap.KitapYılı,
                b.Kitap.SayfaSayisi,
                b.Kitap.Yazar,
                b.Kitap.KategoriAdı
            }).ToList();
            dataGridView1.DataSource = kitaplar;
        }
    }
}
