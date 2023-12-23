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
    public partial class KitapEkle : Form
    {
        public KitapEkle()
        {
            InitializeComponent();
        }

        private void btnKitapEkle_Click(object sender, EventArgs e)
        {
            OkulEntities db = new OkulEntities();
            Kitap kitap = new Kitap
            {
                Adı=txtkitapadi.Text,
                KitapYılı=Convert.ToInt32(txtkitapyili.Text),
                KategoriAdı=txtkategoriadi.Text,
                StokMiktari=Convert.ToInt32(txtstokmiktari.Text),
                SayfaSayisi=Convert.ToInt32(txtsayfasayisi.Text),
                Yazar=txtyazaradi.Text
            };
            db.Kitap.Add(kitap);
          int sonuc=   db.SaveChanges();
        }
    }
}
