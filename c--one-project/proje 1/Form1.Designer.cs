
namespace proje_1
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
            this.yazdirbtn = new System.Windows.Forms.Button();
            this.txtkelime = new System.Windows.Forms.TextBox();
            this.lblsonuc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // yazdirbtn
            // 
            this.yazdirbtn.Location = new System.Drawing.Point(304, 170);
            this.yazdirbtn.Name = "yazdirbtn";
            this.yazdirbtn.Size = new System.Drawing.Size(75, 23);
            this.yazdirbtn.TabIndex = 0;
            this.yazdirbtn.Text = "Yazdır ";
            this.yazdirbtn.UseVisualStyleBackColor = true;
            this.yazdirbtn.Click += new System.EventHandler(this.yazdirbtn_Click);
            // 
            // txtkelime
            // 
            this.txtkelime.Location = new System.Drawing.Point(475, 170);
            this.txtkelime.Name = "txtkelime";
            this.txtkelime.Size = new System.Drawing.Size(100, 22);
            this.txtkelime.TabIndex = 1;
            // 
            // lblsonuc
            // 
            this.lblsonuc.AutoSize = true;
            this.lblsonuc.Location = new System.Drawing.Point(651, 170);
            this.lblsonuc.Name = "lblsonuc";
            this.lblsonuc.Size = new System.Drawing.Size(0, 17);
            this.lblsonuc.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1338, 687);
            this.Controls.Add(this.lblsonuc);
            this.Controls.Add(this.txtkelime);
            this.Controls.Add(this.yazdirbtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button yazdirbtn;
        private System.Windows.Forms.TextBox txtkelime;
        private System.Windows.Forms.Label lblsonuc;
    }
}

