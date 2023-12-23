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
    public partial class KayıtOl : Form
    {
        public KayıtOl()
        {
            InitializeComponent();
        }

    

        private void btnkayıtol_Click(object sender, EventArgs e)
        {
            OkulEntities db = new OkulEntities();
            if (txtsifre1==txtsifre2)
            {
                Kullanici kullanici = new Kullanici
                {
                    Adı = txtadı.Text,
                    Mail = txtmail.Text,
                    Sifre = txtsifre1.Text,
                    Yetki = "u"
                };
                db.Kullanici.Add(kullanici);
                db.SaveChanges();
            }
        }
    }
}
