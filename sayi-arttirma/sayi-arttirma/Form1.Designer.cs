
namespace sayi_arttirma
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
            this.arttirbtn = new System.Windows.Forms.Button();
            this.azaltbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(233, 127);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(39, 17);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Sayı:";
            // 
            // txtsayi
            // 
            this.txtsayi.Location = new System.Drawing.Point(278, 124);
            this.txtsayi.Name = "txtsayi";
            this.txtsayi.Size = new System.Drawing.Size(100, 22);
            this.txtsayi.TabIndex = 1;
            // 
            // arttirbtn
            // 
            this.arttirbtn.Location = new System.Drawing.Point(278, 193);
            this.arttirbtn.Name = "arttirbtn";
            this.arttirbtn.Size = new System.Drawing.Size(37, 23);
            this.arttirbtn.TabIndex = 2;
            this.arttirbtn.Text = "+1";
            this.arttirbtn.UseVisualStyleBackColor = true;
            this.arttirbtn.Click += new System.EventHandler(this.arttirbtn_Click);
            // 
            // azaltbtn
            // 
            this.azaltbtn.Location = new System.Drawing.Point(336, 193);
            this.azaltbtn.Name = "azaltbtn";
            this.azaltbtn.Size = new System.Drawing.Size(42, 23);
            this.azaltbtn.TabIndex = 3;
            this.azaltbtn.Text = "-1";
            this.azaltbtn.UseVisualStyleBackColor = true;
            this.azaltbtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.azaltbtn);
            this.Controls.Add(this.arttirbtn);
            this.Controls.Add(this.txtsayi);
            this.Controls.Add(this.lbl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txtsayi;
        private System.Windows.Forms.Button arttirbtn;
        private System.Windows.Forms.Button azaltbtn;
    }
}

