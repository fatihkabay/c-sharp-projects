
namespace sayi_yazdirma
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
            this.label1 = new System.Windows.Forms.Label();
            this.doldurbtn = new System.Windows.Forms.Button();
            this.cmbbox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(280, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sayılar:";
            // 
            // doldurbtn
            // 
            this.doldurbtn.Location = new System.Drawing.Point(362, 158);
            this.doldurbtn.Name = "doldurbtn";
            this.doldurbtn.Size = new System.Drawing.Size(75, 23);
            this.doldurbtn.TabIndex = 1;
            this.doldurbtn.Text = "Doldur";
            this.doldurbtn.UseVisualStyleBackColor = true;
            this.doldurbtn.Click += new System.EventHandler(this.doldurbtn_Click);
            // 
            // cmbbox1
            // 
            this.cmbbox1.FormattingEnabled = true;
            this.cmbbox1.Location = new System.Drawing.Point(341, 100);
            this.cmbbox1.Name = "cmbbox1";
            this.cmbbox1.Size = new System.Drawing.Size(121, 24);
            this.cmbbox1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbbox1);
            this.Controls.Add(this.doldurbtn);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button doldurbtn;
        private System.Windows.Forms.ComboBox cmbbox1;
    }
}

