
namespace kazanan_belirleme
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
            this.hesaplabtn = new System.Windows.Forms.Button();
            this.txtsayi1 = new System.Windows.Forms.TextBox();
            this.txtsayi2 = new System.Windows.Forms.TextBox();
            this.lblsonuc = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hesaplabtn
            // 
            this.hesaplabtn.Location = new System.Drawing.Point(381, 230);
            this.hesaplabtn.Name = "hesaplabtn";
            this.hesaplabtn.Size = new System.Drawing.Size(75, 23);
            this.hesaplabtn.TabIndex = 0;
            this.hesaplabtn.Text = "Hesapla";
            this.hesaplabtn.UseVisualStyleBackColor = true;
            this.hesaplabtn.Click += new System.EventHandler(this.hesaplabtn_Click);
            // 
            // txtsayi1
            // 
            this.txtsayi1.Location = new System.Drawing.Point(370, 108);
            this.txtsayi1.Name = "txtsayi1";
            this.txtsayi1.Size = new System.Drawing.Size(100, 22);
            this.txtsayi1.TabIndex = 1;
            // 
            // txtsayi2
            // 
            this.txtsayi2.Location = new System.Drawing.Point(370, 153);
            this.txtsayi2.Name = "txtsayi2";
            this.txtsayi2.Size = new System.Drawing.Size(100, 22);
            this.txtsayi2.TabIndex = 2;
            // 
            // lblsonuc
            // 
            this.lblsonuc.AutoSize = true;
            this.lblsonuc.Location = new System.Drawing.Point(394, 281);
            this.lblsonuc.Name = "lblsonuc";
            this.lblsonuc.Size = new System.Drawing.Size(48, 17);
            this.lblsonuc.TabIndex = 3;
            this.lblsonuc.Text = "Sonuç";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(246, 111);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(118, 17);
            this.lbl1.TabIndex = 4;
            this.lbl1.Text = "1. Takımın Sayısı:";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(246, 156);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(118, 17);
            this.lbl2.TabIndex = 5;
            this.lbl2.Text = "2. Takımın Sayısı:";
            this.lbl2.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.lblsonuc);
            this.Controls.Add(this.txtsayi2);
            this.Controls.Add(this.txtsayi1);
            this.Controls.Add(this.hesaplabtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button hesaplabtn;
        private System.Windows.Forms.TextBox txtsayi1;
        private System.Windows.Forms.TextBox txtsayi2;
        private System.Windows.Forms.Label lblsonuc;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
    }
}

