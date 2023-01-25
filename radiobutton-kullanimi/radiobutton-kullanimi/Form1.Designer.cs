
namespace radiobutton_kullanimi
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
            this.lbl2 = new System.Windows.Forms.Label();
            this.txtmiktar = new System.Windows.Forms.TextBox();
            this.yapbtn = new System.Windows.Forms.Button();
            this.radiobtn1 = new System.Windows.Forms.RadioButton();
            this.radiobtn2 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(245, 99);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(39, 17);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Sayı:";
            // 
            // txtsayi
            // 
            this.txtsayi.Location = new System.Drawing.Point(290, 96);
            this.txtsayi.Name = "txtsayi";
            this.txtsayi.Size = new System.Drawing.Size(100, 22);
            this.txtsayi.TabIndex = 1;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(234, 149);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(50, 17);
            this.lbl2.TabIndex = 2;
            this.lbl2.Text = "Miktar:";
            // 
            // txtmiktar
            // 
            this.txtmiktar.Location = new System.Drawing.Point(290, 146);
            this.txtmiktar.Name = "txtmiktar";
            this.txtmiktar.Size = new System.Drawing.Size(100, 22);
            this.txtmiktar.TabIndex = 3;
            // 
            // yapbtn
            // 
            this.yapbtn.Location = new System.Drawing.Point(264, 248);
            this.yapbtn.Name = "yapbtn";
            this.yapbtn.Size = new System.Drawing.Size(75, 23);
            this.yapbtn.TabIndex = 4;
            this.yapbtn.Text = "Yap";
            this.yapbtn.UseVisualStyleBackColor = true;
            this.yapbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // radiobtn1
            // 
            this.radiobtn1.AutoSize = true;
            this.radiobtn1.Location = new System.Drawing.Point(225, 195);
            this.radiobtn1.Name = "radiobtn1";
            this.radiobtn1.Size = new System.Drawing.Size(59, 21);
            this.radiobtn1.TabIndex = 5;
            this.radiobtn1.TabStop = true;
            this.radiobtn1.Text = "Arttır";
            this.radiobtn1.UseVisualStyleBackColor = true;
            // 
            // radiobtn2
            // 
            this.radiobtn2.AutoSize = true;
            this.radiobtn2.Location = new System.Drawing.Point(320, 195);
            this.radiobtn2.Name = "radiobtn2";
            this.radiobtn2.Size = new System.Drawing.Size(60, 21);
            this.radiobtn2.TabIndex = 6;
            this.radiobtn2.TabStop = true;
            this.radiobtn2.Text = "Azalt";
            this.radiobtn2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.radiobtn2);
            this.Controls.Add(this.radiobtn1);
            this.Controls.Add(this.yapbtn);
            this.Controls.Add(this.txtmiktar);
            this.Controls.Add(this.lbl2);
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
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.TextBox txtmiktar;
        private System.Windows.Forms.Button yapbtn;
        private System.Windows.Forms.RadioButton radiobtn1;
        private System.Windows.Forms.RadioButton radiobtn2;
    }
}

