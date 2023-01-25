
namespace esya_kontrolü
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
            this.grpbx1 = new System.Windows.Forms.GroupBox();
            this.grpbx2 = new System.Windows.Forms.GroupBox();
            this.checkbx1 = new System.Windows.Forms.CheckBox();
            this.checkbx2 = new System.Windows.Forms.CheckBox();
            this.yazdirbtn = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.grpbx1.SuspendLayout();
            this.grpbx2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbx1
            // 
            this.grpbx1.Controls.Add(this.yazdirbtn);
            this.grpbx1.Controls.Add(this.checkbx2);
            this.grpbx1.Controls.Add(this.checkbx1);
            this.grpbx1.Location = new System.Drawing.Point(123, 118);
            this.grpbx1.Name = "grpbx1";
            this.grpbx1.Size = new System.Drawing.Size(200, 162);
            this.grpbx1.TabIndex = 0;
            this.grpbx1.TabStop = false;
            this.grpbx1.Text = "Kontrol Paneli";
            // 
            // grpbx2
            // 
            this.grpbx2.Controls.Add(this.listBox1);
            this.grpbx2.Location = new System.Drawing.Point(393, 118);
            this.grpbx2.Name = "grpbx2";
            this.grpbx2.Size = new System.Drawing.Size(200, 162);
            this.grpbx2.TabIndex = 1;
            this.grpbx2.TabStop = false;
            this.grpbx2.Text = "Sistem Raporu";
            // 
            // checkbx1
            // 
            this.checkbx1.AutoSize = true;
            this.checkbx1.Location = new System.Drawing.Point(36, 40);
            this.checkbx1.Name = "checkbx1";
            this.checkbx1.Size = new System.Drawing.Size(130, 21);
            this.checkbx1.TabIndex = 0;
            this.checkbx1.Text = "Lamba Aç/Kapa";
            this.checkbx1.UseVisualStyleBackColor = true;
            // 
            // checkbx2
            // 
            this.checkbx2.AutoSize = true;
            this.checkbx2.Location = new System.Drawing.Point(36, 81);
            this.checkbx2.Name = "checkbx2";
            this.checkbx2.Size = new System.Drawing.Size(126, 21);
            this.checkbx2.TabIndex = 1;
            this.checkbx2.Text = "Kombi Aç/Kapa";
            this.checkbx2.UseVisualStyleBackColor = true;
            // 
            // yazdirbtn
            // 
            this.yazdirbtn.Location = new System.Drawing.Point(59, 126);
            this.yazdirbtn.Name = "yazdirbtn";
            this.yazdirbtn.Size = new System.Drawing.Size(75, 23);
            this.yazdirbtn.TabIndex = 2;
            this.yazdirbtn.Text = "Yazdır";
            this.yazdirbtn.UseVisualStyleBackColor = true;
            this.yazdirbtn.Click += new System.EventHandler(this.yazdirbtn_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(6, 21);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(188, 132);
            this.listBox1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpbx2);
            this.Controls.Add(this.grpbx1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpbx1.ResumeLayout(false);
            this.grpbx1.PerformLayout();
            this.grpbx2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbx1;
        private System.Windows.Forms.Button yazdirbtn;
        private System.Windows.Forms.CheckBox checkbx2;
        private System.Windows.Forms.CheckBox checkbx1;
        private System.Windows.Forms.GroupBox grpbx2;
        private System.Windows.Forms.ListBox listBox1;
    }
}

