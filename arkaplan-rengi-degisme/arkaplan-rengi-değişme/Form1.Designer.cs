
namespace arkaplan_rengi_değişme
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnkirmizi = new System.Windows.Forms.Button();
            this.btnyesil = new System.Windows.Forms.Button();
            this.btnmavi = new System.Windows.Forms.Button();
            this.btngri = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btngri);
            this.groupBox1.Controls.Add(this.btnmavi);
            this.groupBox1.Controls.Add(this.btnyesil);
            this.groupBox1.Controls.Add(this.btnkirmizi);
            this.groupBox1.Location = new System.Drawing.Point(452, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 272);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btnkirmizi
            // 
            this.btnkirmizi.BackColor = System.Drawing.Color.Red;
            this.btnkirmizi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnkirmizi.Location = new System.Drawing.Point(45, 78);
            this.btnkirmizi.Name = "btnkirmizi";
            this.btnkirmizi.Size = new System.Drawing.Size(85, 31);
            this.btnkirmizi.TabIndex = 0;
            this.btnkirmizi.Text = "Kırmızı";
            this.btnkirmizi.UseVisualStyleBackColor = false;
            this.btnkirmizi.Click += new System.EventHandler(this.btnkirmizi_Click);
            // 
            // btnyesil
            // 
            this.btnyesil.BackColor = System.Drawing.Color.YellowGreen;
            this.btnyesil.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnyesil.Location = new System.Drawing.Point(208, 78);
            this.btnyesil.Name = "btnyesil";
            this.btnyesil.Size = new System.Drawing.Size(86, 31);
            this.btnyesil.TabIndex = 1;
            this.btnyesil.Text = "Yeşil";
            this.btnyesil.UseVisualStyleBackColor = false;
            this.btnyesil.Click += new System.EventHandler(this.btnyesil_Click);
            // 
            // btnmavi
            // 
            this.btnmavi.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnmavi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnmavi.Location = new System.Drawing.Point(45, 177);
            this.btnmavi.Name = "btnmavi";
            this.btnmavi.Size = new System.Drawing.Size(85, 31);
            this.btnmavi.TabIndex = 2;
            this.btnmavi.Text = "Mavi";
            this.btnmavi.UseVisualStyleBackColor = false;
            this.btnmavi.Click += new System.EventHandler(this.button3_Click);
            // 
            // btngri
            // 
            this.btngri.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btngri.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btngri.Location = new System.Drawing.Point(208, 177);
            this.btngri.Name = "btngri";
            this.btngri.Size = new System.Drawing.Size(86, 31);
            this.btngri.TabIndex = 3;
            this.btngri.Text = "Gri";
            this.btngri.UseVisualStyleBackColor = false;
            this.btngri.Click += new System.EventHandler(this.btngri_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btngri;
        private System.Windows.Forms.Button btnmavi;
        private System.Windows.Forms.Button btnyesil;
        private System.Windows.Forms.Button btnkirmizi;
    }
}

