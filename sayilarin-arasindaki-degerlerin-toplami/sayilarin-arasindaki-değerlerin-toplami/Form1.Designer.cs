
namespace sayilarin_arasindaki_değerlerin_toplami
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
            this.lbl2 = new System.Windows.Forms.Label();
            this.txtsayi1 = new System.Windows.Forms.TextBox();
            this.txtsayi2 = new System.Windows.Forms.TextBox();
            this.lblsonuc = new System.Windows.Forms.Label();
            this.hesaplabtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(248, 138);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(51, 17);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Sayı 1:";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(440, 135);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(51, 17);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "Sayı 2:";
            // 
            // txtsayi1
            // 
            this.txtsayi1.Location = new System.Drawing.Point(305, 135);
            this.txtsayi1.Name = "txtsayi1";
            this.txtsayi1.Size = new System.Drawing.Size(100, 22);
            this.txtsayi1.TabIndex = 2;
            // 
            // txtsayi2
            // 
            this.txtsayi2.Location = new System.Drawing.Point(497, 131);
            this.txtsayi2.Name = "txtsayi2";
            this.txtsayi2.Size = new System.Drawing.Size(100, 22);
            this.txtsayi2.TabIndex = 3;
            // 
            // lblsonuc
            // 
            this.lblsonuc.AutoSize = true;
            this.lblsonuc.Location = new System.Drawing.Point(385, 256);
            this.lblsonuc.Name = "lblsonuc";
            this.lblsonuc.Size = new System.Drawing.Size(48, 17);
            this.lblsonuc.TabIndex = 4;
            this.lblsonuc.Text = "Sonuç";
            // 
            // hesaplabtn
            // 
            this.hesaplabtn.Location = new System.Drawing.Point(388, 190);
            this.hesaplabtn.Name = "hesaplabtn";
            this.hesaplabtn.Size = new System.Drawing.Size(75, 23);
            this.hesaplabtn.TabIndex = 5;
            this.hesaplabtn.Text = "Hesapla";
            this.hesaplabtn.UseVisualStyleBackColor = true;
            this.hesaplabtn.Click += new System.EventHandler(this.hesaplabtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.hesaplabtn);
            this.Controls.Add(this.lblsonuc);
            this.Controls.Add(this.txtsayi2);
            this.Controls.Add(this.txtsayi1);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.TextBox txtsayi1;
        private System.Windows.Forms.TextBox txtsayi2;
        private System.Windows.Forms.Label lblsonuc;
        private System.Windows.Forms.Button hesaplabtn;
    }
}

