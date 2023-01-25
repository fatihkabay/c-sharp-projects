
namespace kisi_ekleme
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
            this.eklebtn = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.txtadsoyad = new System.Windows.Forms.TextBox();
            this.lstbx = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // eklebtn
            // 
            this.eklebtn.Location = new System.Drawing.Point(375, 111);
            this.eklebtn.Name = "eklebtn";
            this.eklebtn.Size = new System.Drawing.Size(75, 23);
            this.eklebtn.TabIndex = 0;
            this.eklebtn.Text = "Ekle";
            this.eklebtn.UseVisualStyleBackColor = true;
            this.eklebtn.Click += new System.EventHandler(this.eklebtn_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(283, 77);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(73, 17);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "Ad Soyad:";
            // 
            // txtadsoyad
            // 
            this.txtadsoyad.Location = new System.Drawing.Point(362, 74);
            this.txtadsoyad.Name = "txtadsoyad";
            this.txtadsoyad.Size = new System.Drawing.Size(100, 22);
            this.txtadsoyad.TabIndex = 2;
            // 
            // lstbx
            // 
            this.lstbx.FormattingEnabled = true;
            this.lstbx.ItemHeight = 16;
            this.lstbx.Location = new System.Drawing.Point(324, 175);
            this.lstbx.Name = "lstbx";
            this.lstbx.Size = new System.Drawing.Size(179, 164);
            this.lstbx.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstbx);
            this.Controls.Add(this.txtadsoyad);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.eklebtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button eklebtn;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txtadsoyad;
        private System.Windows.Forms.ListBox lstbx;
    }
}

