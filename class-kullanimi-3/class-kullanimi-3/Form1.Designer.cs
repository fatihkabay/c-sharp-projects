
namespace class_kullanimi_3
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
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.cmbbox1 = new System.Windows.Forms.ComboBox();
            this.radiobtn1 = new System.Windows.Forms.RadioButton();
            this.radiobtn2 = new System.Windows.Forms.RadioButton();
            this.txtbox1 = new System.Windows.Forms.TextBox();
            this.txtbox2 = new System.Windows.Forms.TextBox();
            this.txtbox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.yazdirbtn = new System.Windows.Forms.Button();
            this.lblsonuc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(289, 60);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(29, 17);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Ad:";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(266, 90);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(52, 17);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "Soyad:";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(282, 127);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(36, 17);
            this.lbl3.TabIndex = 2;
            this.lbl3.Text = "Yaş:";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(214, 161);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(104, 17);
            this.lbl4.TabIndex = 4;
            this.lbl4.Text = "Eğitim Durumu:";
            // 
            // cmbbox1
            // 
            this.cmbbox1.FormattingEnabled = true;
            this.cmbbox1.Items.AddRange(new object[] {
            "Anaokul",
            "İlkokul",
            "Ortaokul",
            "Lise",
            "Üniversite",
            "Lisans",
            "Yüksek Lisans",
            "Doktora"});
            this.cmbbox1.Location = new System.Drawing.Point(332, 158);
            this.cmbbox1.Name = "cmbbox1";
            this.cmbbox1.Size = new System.Drawing.Size(100, 24);
            this.cmbbox1.TabIndex = 5;
            // 
            // radiobtn1
            // 
            this.radiobtn1.AutoSize = true;
            this.radiobtn1.Location = new System.Drawing.Point(332, 201);
            this.radiobtn1.Name = "radiobtn1";
            this.radiobtn1.Size = new System.Drawing.Size(71, 21);
            this.radiobtn1.TabIndex = 6;
            this.radiobtn1.TabStop = true;
            this.radiobtn1.Text = "Yapıldı";
            this.radiobtn1.UseVisualStyleBackColor = true;
            // 
            // radiobtn2
            // 
            this.radiobtn2.AutoSize = true;
            this.radiobtn2.Location = new System.Drawing.Point(332, 228);
            this.radiobtn2.Name = "radiobtn2";
            this.radiobtn2.Size = new System.Drawing.Size(90, 21);
            this.radiobtn2.TabIndex = 7;
            this.radiobtn2.TabStop = true;
            this.radiobtn2.Text = "Yapılmadı";
            this.radiobtn2.UseVisualStyleBackColor = true;
            // 
            // txtbox1
            // 
            this.txtbox1.Location = new System.Drawing.Point(332, 60);
            this.txtbox1.Name = "txtbox1";
            this.txtbox1.Size = new System.Drawing.Size(100, 22);
            this.txtbox1.TabIndex = 8;
            // 
            // txtbox2
            // 
            this.txtbox2.Location = new System.Drawing.Point(332, 90);
            this.txtbox2.Name = "txtbox2";
            this.txtbox2.Size = new System.Drawing.Size(100, 22);
            this.txtbox2.TabIndex = 9;
            // 
            // txtbox3
            // 
            this.txtbox3.Location = new System.Drawing.Point(332, 124);
            this.txtbox3.Name = "txtbox3";
            this.txtbox3.Size = new System.Drawing.Size(100, 22);
            this.txtbox3.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(205, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Askerlik durumu:";
            // 
            // yazdirbtn
            // 
            this.yazdirbtn.Location = new System.Drawing.Point(332, 277);
            this.yazdirbtn.Name = "yazdirbtn";
            this.yazdirbtn.Size = new System.Drawing.Size(75, 23);
            this.yazdirbtn.TabIndex = 12;
            this.yazdirbtn.Text = "Yazdır";
            this.yazdirbtn.UseVisualStyleBackColor = true;
            this.yazdirbtn.Click += new System.EventHandler(this.yazdirbtn_Click);
            // 
            // lblsonuc
            // 
            this.lblsonuc.AutoSize = true;
            this.lblsonuc.Location = new System.Drawing.Point(12, 334);
            this.lblsonuc.Name = "lblsonuc";
            this.lblsonuc.Size = new System.Drawing.Size(48, 17);
            this.lblsonuc.TabIndex = 13;
            this.lblsonuc.Text = "Sonuç";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblsonuc);
            this.Controls.Add(this.yazdirbtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtbox3);
            this.Controls.Add(this.txtbox2);
            this.Controls.Add(this.txtbox1);
            this.Controls.Add(this.radiobtn2);
            this.Controls.Add(this.radiobtn1);
            this.Controls.Add(this.cmbbox1);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lbl3);
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
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.ComboBox cmbbox1;
        private System.Windows.Forms.RadioButton radiobtn1;
        private System.Windows.Forms.RadioButton radiobtn2;
        private System.Windows.Forms.TextBox txtbox1;
        private System.Windows.Forms.TextBox txtbox2;
        private System.Windows.Forms.TextBox txtbox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button yazdirbtn;
        private System.Windows.Forms.Label lblsonuc;
    }
}

