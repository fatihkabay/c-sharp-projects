﻿
namespace listeleme
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
            this.txtmeyveler = new System.Windows.Forms.TextBox();
            this.yazdirbtn = new System.Windows.Forms.Button();
            this.lst1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtmeyveler
            // 
            this.txtmeyveler.Location = new System.Drawing.Point(516, 114);
            this.txtmeyveler.Name = "txtmeyveler";
            this.txtmeyveler.Size = new System.Drawing.Size(100, 22);
            this.txtmeyveler.TabIndex = 0;
            // 
            // yazdirbtn
            // 
            this.yazdirbtn.Location = new System.Drawing.Point(529, 191);
            this.yazdirbtn.Name = "yazdirbtn";
            this.yazdirbtn.Size = new System.Drawing.Size(75, 23);
            this.yazdirbtn.TabIndex = 1;
            this.yazdirbtn.Text = "Yazdır";
            this.yazdirbtn.UseVisualStyleBackColor = true;
            this.yazdirbtn.Click += new System.EventHandler(this.yazdirbtn_Click);
            // 
            // lst1
            // 
            this.lst1.FormattingEnabled = true;
            this.lst1.ItemHeight = 16;
            this.lst1.Location = new System.Drawing.Point(697, 100);
            this.lst1.Name = "lst1";
            this.lst1.Size = new System.Drawing.Size(153, 148);
            this.lst1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 506);
            this.Controls.Add(this.lst1);
            this.Controls.Add(this.yazdirbtn);
            this.Controls.Add(this.txtmeyveler);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtmeyveler;
        private System.Windows.Forms.Button yazdirbtn;
        private System.Windows.Forms.ListBox lst1;
    }
}

