
namespace classlarda_get_ve_set_kullanimi
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
            this.txtadsoyad = new System.Windows.Forms.TextBox();
            this.txttc = new System.Windows.Forms.TextBox();
            this.txtoda = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.yazdirbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtadsoyad
            // 
            this.txtadsoyad.Location = new System.Drawing.Point(347, 89);
            this.txtadsoyad.Name = "txtadsoyad";
            this.txtadsoyad.Size = new System.Drawing.Size(100, 22);
            this.txtadsoyad.TabIndex = 0;
            // 
            // txttc
            // 
            this.txttc.Location = new System.Drawing.Point(347, 135);
            this.txttc.Name = "txttc";
            this.txttc.Size = new System.Drawing.Size(100, 22);
            this.txttc.TabIndex = 1;
            // 
            // txtoda
            // 
            this.txtoda.Location = new System.Drawing.Point(347, 180);
            this.txtoda.Name = "txtoda";
            this.txtoda.Size = new System.Drawing.Size(100, 22);
            this.txtoda.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(268, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ad Soyad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(291, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "TC no:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(282, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Oda no:";
            // 
            // yazdirbtn
            // 
            this.yazdirbtn.Location = new System.Drawing.Point(361, 224);
            this.yazdirbtn.Name = "yazdirbtn";
            this.yazdirbtn.Size = new System.Drawing.Size(75, 23);
            this.yazdirbtn.TabIndex = 6;
            this.yazdirbtn.Text = "Yazdır";
            this.yazdirbtn.UseVisualStyleBackColor = true;
            this.yazdirbtn.Click += new System.EventHandler(this.yazdirbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.yazdirbtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtoda);
            this.Controls.Add(this.txttc);
            this.Controls.Add(this.txtadsoyad);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtadsoyad;
        private System.Windows.Forms.TextBox txttc;
        private System.Windows.Forms.TextBox txtoda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button yazdirbtn;
    }
}

