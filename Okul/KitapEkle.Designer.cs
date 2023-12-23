
namespace Okul
{
    partial class KitapEkle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtkategoriadi = new System.Windows.Forms.TextBox();
            this.txtkitapadi = new System.Windows.Forms.TextBox();
            this.txtyazaradi = new System.Windows.Forms.TextBox();
            this.txtsayfasayisi = new System.Windows.Forms.TextBox();
            this.btnKitapEkle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtkitapyili = new System.Windows.Forms.TextBox();
            this.txtstokmiktari = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtkategoriadi
            // 
            this.txtkategoriadi.Location = new System.Drawing.Point(314, 46);
            this.txtkategoriadi.Name = "txtkategoriadi";
            this.txtkategoriadi.Size = new System.Drawing.Size(137, 20);
            this.txtkategoriadi.TabIndex = 0;
            // 
            // txtkitapadi
            // 
            this.txtkitapadi.Location = new System.Drawing.Point(314, 89);
            this.txtkitapadi.Name = "txtkitapadi";
            this.txtkitapadi.Size = new System.Drawing.Size(137, 20);
            this.txtkitapadi.TabIndex = 1;
            // 
            // txtyazaradi
            // 
            this.txtyazaradi.Location = new System.Drawing.Point(314, 132);
            this.txtyazaradi.Name = "txtyazaradi";
            this.txtyazaradi.Size = new System.Drawing.Size(137, 20);
            this.txtyazaradi.TabIndex = 2;
            // 
            // txtsayfasayisi
            // 
            this.txtsayfasayisi.Location = new System.Drawing.Point(314, 175);
            this.txtsayfasayisi.Name = "txtsayfasayisi";
            this.txtsayfasayisi.Size = new System.Drawing.Size(137, 20);
            this.txtsayfasayisi.TabIndex = 3;
            // 
            // btnKitapEkle
            // 
            this.btnKitapEkle.Location = new System.Drawing.Point(314, 321);
            this.btnKitapEkle.Name = "btnKitapEkle";
            this.btnKitapEkle.Size = new System.Drawing.Size(106, 23);
            this.btnKitapEkle.TabIndex = 4;
            this.btnKitapEkle.Text = "Kitap Ekle";
            this.btnKitapEkle.UseVisualStyleBackColor = true;
            this.btnKitapEkle.Click += new System.EventHandler(this.btnKitapEkle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(233, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Kitap Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(233, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Sayfa Sayısı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(233, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Yazar :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(233, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Kategori Adı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(233, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Kitap Yılı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(233, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Stok Miktarı";
            // 
            // txtkitapyili
            // 
            this.txtkitapyili.Location = new System.Drawing.Point(314, 218);
            this.txtkitapyili.Name = "txtkitapyili";
            this.txtkitapyili.Size = new System.Drawing.Size(137, 20);
            this.txtkitapyili.TabIndex = 11;
            // 
            // txtstokmiktari
            // 
            this.txtstokmiktari.Location = new System.Drawing.Point(313, 261);
            this.txtstokmiktari.Name = "txtstokmiktari";
            this.txtstokmiktari.Size = new System.Drawing.Size(137, 20);
            this.txtstokmiktari.TabIndex = 12;
            // 
            // KitapEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtstokmiktari);
            this.Controls.Add(this.txtkitapyili);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKitapEkle);
            this.Controls.Add(this.txtsayfasayisi);
            this.Controls.Add(this.txtyazaradi);
            this.Controls.Add(this.txtkitapadi);
            this.Controls.Add(this.txtkategoriadi);
            this.Name = "KitapEkle";
            this.Text = "KitapEkle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtkategoriadi;
        private System.Windows.Forms.TextBox txtkitapadi;
        private System.Windows.Forms.TextBox txtyazaradi;
        private System.Windows.Forms.TextBox txtsayfasayisi;
        private System.Windows.Forms.Button btnKitapEkle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtkitapyili;
        private System.Windows.Forms.TextBox txtstokmiktari;
    }
}