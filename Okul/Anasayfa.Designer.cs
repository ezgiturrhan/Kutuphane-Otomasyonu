
namespace Okul
{
    partial class Anasayfa
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblgirisyapan = new System.Windows.Forms.Label();
            this.btnkitaplistesi = new System.Windows.Forms.Button();
            this.btnkitapekle = new System.Windows.Forms.Button();
            this.btnkayıtol = new System.Windows.Forms.Button();
            this.btngirisyap = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnalinankitaplar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnalinankitaplar);
            this.panel1.Controls.Add(this.lblgirisyapan);
            this.panel1.Controls.Add(this.btnkitaplistesi);
            this.panel1.Controls.Add(this.btnkitapekle);
            this.panel1.Controls.Add(this.btnkayıtol);
            this.panel1.Controls.Add(this.btngirisyap);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 55);
            this.panel1.TabIndex = 0;
            // 
            // lblgirisyapan
            // 
            this.lblgirisyapan.AutoSize = true;
            this.lblgirisyapan.Location = new System.Drawing.Point(713, 13);
            this.lblgirisyapan.Name = "lblgirisyapan";
            this.lblgirisyapan.Size = new System.Drawing.Size(35, 13);
            this.lblgirisyapan.TabIndex = 4;
            this.lblgirisyapan.Text = "label1";
            // 
            // btnkitaplistesi
            // 
            this.btnkitaplistesi.Location = new System.Drawing.Point(294, 13);
            this.btnkitaplistesi.Name = "btnkitaplistesi";
            this.btnkitaplistesi.Size = new System.Drawing.Size(107, 29);
            this.btnkitaplistesi.TabIndex = 3;
            this.btnkitaplistesi.Text = "Kitap Listesi";
            this.btnkitaplistesi.UseVisualStyleBackColor = true;
            this.btnkitaplistesi.Click += new System.EventHandler(this.btnkitaplistesi_Click);
            // 
            // btnkitapekle
            // 
            this.btnkitapekle.Location = new System.Drawing.Point(156, 13);
            this.btnkitapekle.Name = "btnkitapekle";
            this.btnkitapekle.Size = new System.Drawing.Size(107, 29);
            this.btnkitapekle.TabIndex = 2;
            this.btnkitapekle.Text = "Kitap Ekle";
            this.btnkitapekle.UseVisualStyleBackColor = true;
            this.btnkitapekle.Click += new System.EventHandler(this.btnkitapekle_Click);
            // 
            // btnkayıtol
            // 
            this.btnkayıtol.Location = new System.Drawing.Point(590, 13);
            this.btnkayıtol.Name = "btnkayıtol";
            this.btnkayıtol.Size = new System.Drawing.Size(107, 29);
            this.btnkayıtol.TabIndex = 1;
            this.btnkayıtol.Text = "Kayıt Ol";
            this.btnkayıtol.UseVisualStyleBackColor = true;
            this.btnkayıtol.Click += new System.EventHandler(this.btnkayıtol_Click);
            // 
            // btngirisyap
            // 
            this.btngirisyap.Location = new System.Drawing.Point(26, 13);
            this.btngirisyap.Name = "btngirisyap";
            this.btngirisyap.Size = new System.Drawing.Size(107, 29);
            this.btngirisyap.TabIndex = 0;
            this.btngirisyap.Text = "Giris Yap";
            this.btngirisyap.UseVisualStyleBackColor = true;
            this.btngirisyap.Click += new System.EventHandler(this.btngirisyap_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 395);
            this.panel2.TabIndex = 1;
            // 
            // btnalinankitaplar
            // 
            this.btnalinankitaplar.Location = new System.Drawing.Point(427, 12);
            this.btnalinankitaplar.Name = "btnalinankitaplar";
            this.btnalinankitaplar.Size = new System.Drawing.Size(107, 29);
            this.btnalinankitaplar.TabIndex = 5;
            this.btnalinankitaplar.Text = "Alınan Kitaplar";
            this.btnalinankitaplar.UseVisualStyleBackColor = true;
            this.btnalinankitaplar.Click += new System.EventHandler(this.btnalinankitaplar_Click);
            // 
            // Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Name = "Anasayfa";
            this.Text = "Anasayfa";
            this.Load += new System.EventHandler(this.Anasayfa_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnkayıtol;
        private System.Windows.Forms.Button btngirisyap;
        private System.Windows.Forms.Button btnkitapekle;
        private System.Windows.Forms.Label lblgirisyapan;
        public System.Windows.Forms.Button btnkitaplistesi;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Button btnalinankitaplar;
    }
}