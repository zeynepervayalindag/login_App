namespace WindowsFormsApp1
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
            this.kullaniciadiLabel = new System.Windows.Forms.Label();
            this.sifreLabel = new System.Windows.Forms.Label();
            this.girisLabel = new System.Windows.Forms.Button();
            this.sifreTextBox = new System.Windows.Forms.TextBox();
            this.kullaniciadiTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bilgi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // kullaniciadiLabel
            // 
            this.kullaniciadiLabel.AutoSize = true;
            this.kullaniciadiLabel.Location = new System.Drawing.Point(42, 38);
            this.kullaniciadiLabel.Name = "kullaniciadiLabel";
            this.kullaniciadiLabel.Size = new System.Drawing.Size(119, 20);
            this.kullaniciadiLabel.TabIndex = 0;
            this.kullaniciadiLabel.Text = "Kullanıcı adınız :";
            this.kullaniciadiLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // sifreLabel
            // 
            this.sifreLabel.AutoSize = true;
            this.sifreLabel.Location = new System.Drawing.Point(42, 78);
            this.sifreLabel.Name = "sifreLabel";
            this.sifreLabel.Size = new System.Drawing.Size(70, 20);
            this.sifreLabel.TabIndex = 2;
            this.sifreLabel.Text = "Şifreniz :";
            this.sifreLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // girisLabel
            // 
            this.girisLabel.Location = new System.Drawing.Point(492, 130);
            this.girisLabel.Name = "girisLabel";
            this.girisLabel.Size = new System.Drawing.Size(296, 47);
            this.girisLabel.TabIndex = 4;
            this.girisLabel.Text = "Giriş ";
            this.girisLabel.UseVisualStyleBackColor = true;
            this.girisLabel.Click += new System.EventHandler(this.girisLabel_Click);
            // 
            // sifreTextBox
            // 
            this.sifreTextBox.Location = new System.Drawing.Point(187, 78);
            this.sifreTextBox.Name = "sifreTextBox";
            this.sifreTextBox.Size = new System.Drawing.Size(311, 26);
            this.sifreTextBox.TabIndex = 5;
            // 
            // kullaniciadiTextBox
            // 
            this.kullaniciadiTextBox.Location = new System.Drawing.Point(187, 32);
            this.kullaniciadiTextBox.Name = "kullaniciadiTextBox";
            this.kullaniciadiTextBox.Size = new System.Drawing.Size(311, 26);
            this.kullaniciadiTextBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 8;
            // 
            // bilgi
            // 
            this.bilgi.AutoSize = true;
            this.bilgi.Location = new System.Drawing.Point(46, 176);
            this.bilgi.Name = "bilgi";
            this.bilgi.Size = new System.Drawing.Size(0, 20);
            this.bilgi.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 201);
            this.Controls.Add(this.bilgi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kullaniciadiTextBox);
            this.Controls.Add(this.sifreTextBox);
            this.Controls.Add(this.girisLabel);
            this.Controls.Add(this.sifreLabel);
            this.Controls.Add(this.kullaniciadiLabel);
            this.Name = "Form1";
            this.Text = "Giriş Yap";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label kullaniciadiLabel;
        private System.Windows.Forms.Label sifreLabel;
        private System.Windows.Forms.Button girisLabel;
        private System.Windows.Forms.TextBox sifreTextBox;
        private System.Windows.Forms.TextBox kullaniciadiTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label bilgi;
    }
}

