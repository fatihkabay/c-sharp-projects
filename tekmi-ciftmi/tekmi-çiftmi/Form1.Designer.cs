
namespace tekmi_çiftmi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl1 = new System.Windows.Forms.Label();
            this.txtsayi = new System.Windows.Forms.TextBox();
            this.btnhesapla = new System.Windows.Forms.Button();
            this.lblsonuc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(158, 110);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(39, 17);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Sayı:";
            // 
            // txtsayi
            // 
            this.txtsayi.Location = new System.Drawing.Point(203, 107);
            this.txtsayi.Name = "txtsayi";
            this.txtsayi.Size = new System.Drawing.Size(100, 22);
            this.txtsayi.TabIndex = 1;
            // 
            // btnhesapla
            // 
            this.btnhesapla.Location = new System.Drawing.Point(203, 156);
            this.btnhesapla.Name = "btnhesapla";
            this.btnhesapla.Size = new System.Drawing.Size(100, 44);
            this.btnhesapla.TabIndex = 2;
            this.btnhesapla.Text = "Tekmi? Çiftmi?";
            this.btnhesapla.UseVisualStyleBackColor = true;
            this.btnhesapla.Click += new System.EventHandler(this.btnhesapla_Click);
            // 
            // lblsonuc
            // 
            this.lblsonuc.AutoSize = true;
            this.lblsonuc.Location = new System.Drawing.Point(226, 232);
            this.lblsonuc.Name = "lblsonuc";
            this.lblsonuc.Size = new System.Drawing.Size(48, 17);
            this.lblsonuc.TabIndex = 3;
            this.lblsonuc.Text = "Sonuç";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblsonuc);
            this.Controls.Add(this.btnhesapla);
            this.Controls.Add(this.txtsayi);
            this.Controls.Add(this.lbl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txtsayi;
        private System.Windows.Forms.Button btnhesapla;
        private System.Windows.Forms.Label lblsonuc;
    }
}

