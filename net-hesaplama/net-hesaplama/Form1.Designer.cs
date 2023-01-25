
namespace net_hesaplama
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
            this.hesaplabtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.txtturkcedogru = new System.Windows.Forms.TextBox();
            this.txtturkcenet = new System.Windows.Forms.TextBox();
            this.txtturkceyanlis = new System.Windows.Forms.TextBox();
            this.txtmatematiknet = new System.Windows.Forms.TextBox();
            this.txtmatematikyanlis = new System.Windows.Forms.TextBox();
            this.txtmatematikdogru = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkOrange;
            this.groupBox1.Controls.Add(this.txtmatematikdogru);
            this.groupBox1.Controls.Add(this.txtmatematikyanlis);
            this.groupBox1.Controls.Add(this.txtmatematiknet);
            this.groupBox1.Controls.Add(this.txtturkceyanlis);
            this.groupBox1.Controls.Add(this.txtturkcenet);
            this.groupBox1.Controls.Add(this.txtturkcedogru);
            this.groupBox1.Controls.Add(this.lbl5);
            this.groupBox1.Controls.Add(this.hesaplabtn);
            this.groupBox1.Controls.Add(this.lbl4);
            this.groupBox1.Controls.Add(this.lbl3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(170, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(519, 279);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sınav 1. Oturum";
            // 
            // hesaplabtn
            // 
            this.hesaplabtn.Location = new System.Drawing.Point(204, 227);
            this.hesaplabtn.Name = "hesaplabtn";
            this.hesaplabtn.Size = new System.Drawing.Size(122, 31);
            this.hesaplabtn.TabIndex = 0;
            this.hesaplabtn.Text = "Net Hesapla";
            this.hesaplabtn.UseVisualStyleBackColor = true;
            this.hesaplabtn.Click += new System.EventHandler(this.hesaplabtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Türkçe (40 Soru)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Matematik ( 40 Soru )";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(211, 22);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(47, 17);
            this.lbl3.TabIndex = 3;
            this.lbl3.Text = "Doğru";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(317, 22);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(46, 17);
            this.lbl4.TabIndex = 4;
            this.lbl4.Text = "Yanlış";
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Location = new System.Drawing.Point(423, 22);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(30, 17);
            this.lbl5.TabIndex = 5;
            this.lbl5.Text = "Net";
            // 
            // txtturkcedogru
            // 
            this.txtturkcedogru.Location = new System.Drawing.Point(204, 72);
            this.txtturkcedogru.Name = "txtturkcedogru";
            this.txtturkcedogru.Size = new System.Drawing.Size(54, 22);
            this.txtturkcedogru.TabIndex = 6;
            // 
            // txtturkcenet
            // 
            this.txtturkcenet.Location = new System.Drawing.Point(413, 72);
            this.txtturkcenet.Name = "txtturkcenet";
            this.txtturkcenet.Size = new System.Drawing.Size(56, 22);
            this.txtturkcenet.TabIndex = 7;
            // 
            // txtturkceyanlis
            // 
            this.txtturkceyanlis.Location = new System.Drawing.Point(308, 72);
            this.txtturkceyanlis.Name = "txtturkceyanlis";
            this.txtturkceyanlis.Size = new System.Drawing.Size(55, 22);
            this.txtturkceyanlis.TabIndex = 8;
            // 
            // txtmatematiknet
            // 
            this.txtmatematiknet.Location = new System.Drawing.Point(415, 166);
            this.txtmatematiknet.Name = "txtmatematiknet";
            this.txtmatematiknet.Size = new System.Drawing.Size(54, 22);
            this.txtmatematiknet.TabIndex = 9;
            // 
            // txtmatematikyanlis
            // 
            this.txtmatematikyanlis.Location = new System.Drawing.Point(308, 166);
            this.txtmatematikyanlis.Name = "txtmatematikyanlis";
            this.txtmatematikyanlis.Size = new System.Drawing.Size(54, 22);
            this.txtmatematikyanlis.TabIndex = 10;
            // 
            // txtmatematikdogru
            // 
            this.txtmatematikdogru.Location = new System.Drawing.Point(204, 166);
            this.txtmatematikdogru.Name = "txtmatematikdogru";
            this.txtmatematikdogru.Size = new System.Drawing.Size(54, 22);
            this.txtmatematikdogru.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtmatematikdogru;
        private System.Windows.Forms.TextBox txtmatematikyanlis;
        private System.Windows.Forms.TextBox txtmatematiknet;
        private System.Windows.Forms.TextBox txtturkceyanlis;
        private System.Windows.Forms.TextBox txtturkcenet;
        private System.Windows.Forms.TextBox txtturkcedogru;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Button hesaplabtn;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

