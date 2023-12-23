
namespace Okul
{
    partial class KitapListesi
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnkitapal = new System.Windows.Forms.Button();
            this.txtkitapId = new System.Windows.Forms.TextBox();
            this.btnfiltre = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(682, 450);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnkitapal
            // 
            this.btnkitapal.Location = new System.Drawing.Point(702, 54);
            this.btnkitapal.Name = "btnkitapal";
            this.btnkitapal.Size = new System.Drawing.Size(75, 23);
            this.btnkitapal.TabIndex = 1;
            this.btnkitapal.Text = "Kitabı Al";
            this.btnkitapal.UseVisualStyleBackColor = true;
            this.btnkitapal.Click += new System.EventHandler(this.btnkitapal_Click);
            // 
            // txtkitapId
            // 
            this.txtkitapId.Location = new System.Drawing.Point(688, 28);
            this.txtkitapId.Name = "txtkitapId";
            this.txtkitapId.Size = new System.Drawing.Size(100, 20);
            this.txtkitapId.TabIndex = 2;
            // 
            // btnfiltre
            // 
            this.btnfiltre.Location = new System.Drawing.Point(702, 93);
            this.btnfiltre.Name = "btnfiltre";
            this.btnfiltre.Size = new System.Drawing.Size(75, 23);
            this.btnfiltre.TabIndex = 3;
            this.btnfiltre.Text = "Filtrele";
            this.btnfiltre.UseVisualStyleBackColor = true;
            this.btnfiltre.Click += new System.EventHandler(this.btnfiltre_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(702, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kitap Id Giriniz";
            // 
            // KitapListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnfiltre);
            this.Controls.Add(this.txtkitapId);
            this.Controls.Add(this.btnkitapal);
            this.Controls.Add(this.dataGridView1);
            this.Name = "KitapListesi";
            this.Text = "KitapListesi";
            this.Load += new System.EventHandler(this.KitapListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnkitapal;
        private System.Windows.Forms.TextBox txtkitapId;
        private System.Windows.Forms.Button btnfiltre;
        private System.Windows.Forms.Label label1;
    }
}