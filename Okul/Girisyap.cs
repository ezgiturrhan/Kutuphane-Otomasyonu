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
    public partial class Girisyap : Form
    {
        public Girisyap()
        {
            
            InitializeComponent();
        }
     
        private void btngirisyap_Click(object sender, EventArgs e)
        {
            OkulEntities db = new OkulEntities();
            var kullanici= db.Kullanici.Where(x => x.Mail == txtuyeadi.Text && x.Sifre == txtsifre.Text).FirstOrDefault();
            if (kullanici!=null)
            {
                Properties.Settings.Default.kullaniciId = kullanici.Id;
                lblhata.Visible = true;
                lblhata.Text = "Giriş Başarılı";
                lblhata.ForeColor =Color.Blue;
            }
            else
            {
                lblhata.ForeColor = Color.Red;
                lblhata.Visible = true;
                lblhata.Text = "Üye Adı veya Şifre Hatalı";
            }
        }

        private void Girisyap_Load(object sender, EventArgs e)
        {
            lblhata.Visible = false;
        }
    }
}
