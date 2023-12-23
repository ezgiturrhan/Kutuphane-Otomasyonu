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
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }
        public void formgetir(Form frm)
        {
            panel2.Controls.Clear();
            frm.MdiParent = this;
            frm.FormBorderStyle = FormBorderStyle.None;
            panel2.Controls.Add(frm);
            frm.Show();
        }
        public void kullaniciadikaydet(string ad)
        {
            lblgirisyapan.Text = ad;
            lblgirisyapan.Visible = true;
        }
        private void btngirisyap_Click(object sender, EventArgs e)
        {
            Girisyap girisyap = new Girisyap();
            formgetir(girisyap);
        }

        private void btnkayıtol_Click(object sender, EventArgs e)
        {
            KayıtOl kayitol = new KayıtOl();
            formgetir(kayitol);
        }

        public void btnkitaplistesi_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.kullaniciId!=0)
            {
                KitapListesi kitapListesi = new KitapListesi();
                formgetir(kitapListesi);
            }
        }

        private void Anasayfa_Load(object sender, EventArgs e)
        {
            lblgirisyapan.Visible = false;
        }

        private void btnkitapekle_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.kullaniciId != 0)
            {
                KitapEkle kitapListesi = new KitapEkle();
                formgetir(kitapListesi);
            }
        }

        private void btnalinankitaplar_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.kullaniciId != 0)
            {
                AlinanKitaplar alinankitaplistesi = new AlinanKitaplar();
                formgetir(alinankitaplistesi);
            }
        }
    }
}
