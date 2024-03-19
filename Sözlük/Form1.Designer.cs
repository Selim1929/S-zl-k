namespace Sözlük
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
            this.comboBoxCeviri1 = new System.Windows.Forms.ComboBox();
            this.comboBoxCeviri2 = new System.Windows.Forms.ComboBox();
            this.textBoxCeviri1 = new System.Windows.Forms.TextBox();
            this.textBoxCeviri2 = new System.Windows.Forms.TextBox();
            this.BtnEkle = new System.Windows.Forms.Button();
            this.btnYerDegistir2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxCeviri1
            // 
            this.comboBoxCeviri1.FormattingEnabled = true;
            this.comboBoxCeviri1.Items.AddRange(new object[] {
            "İngilizce",
            "Türkçe"});
            this.comboBoxCeviri1.Location = new System.Drawing.Point(64, 54);
            this.comboBoxCeviri1.Name = "comboBoxCeviri1";
            this.comboBoxCeviri1.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCeviri1.TabIndex = 0;
            this.comboBoxCeviri1.Text = "İngilizce";
            // 
            // comboBoxCeviri2
            // 
            this.comboBoxCeviri2.FormattingEnabled = true;
            this.comboBoxCeviri2.Items.AddRange(new object[] {
            "Türkçe",
            "İngilizce"});
            this.comboBoxCeviri2.Location = new System.Drawing.Point(342, 54);
            this.comboBoxCeviri2.Name = "comboBoxCeviri2";
            this.comboBoxCeviri2.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCeviri2.TabIndex = 1;
            this.comboBoxCeviri2.Text = "Türkçe";
            // 
            // textBoxCeviri1
            // 
            this.textBoxCeviri1.Location = new System.Drawing.Point(64, 104);
            this.textBoxCeviri1.Multiline = true;
            this.textBoxCeviri1.Name = "textBoxCeviri1";
            this.textBoxCeviri1.Size = new System.Drawing.Size(121, 170);
            this.textBoxCeviri1.TabIndex = 2;
            this.textBoxCeviri1.TextChanged += new System.EventHandler(this.textBoxCeviri1_TextChanged);
            // 
            // textBoxCeviri2
            // 
            this.textBoxCeviri2.Location = new System.Drawing.Point(342, 104);
            this.textBoxCeviri2.Multiline = true;
            this.textBoxCeviri2.Name = "textBoxCeviri2";
            this.textBoxCeviri2.Size = new System.Drawing.Size(121, 170);
            this.textBoxCeviri2.TabIndex = 3;
            // 
            // BtnEkle
            // 
            this.BtnEkle.Location = new System.Drawing.Point(226, 192);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(75, 46);
            this.BtnEkle.TabIndex = 4;
            this.BtnEkle.Text = "Ekle";
            this.BtnEkle.UseVisualStyleBackColor = true;
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // btnYerDegistir2
            // 
            this.btnYerDegistir2.Location = new System.Drawing.Point(226, 119);
            this.btnYerDegistir2.Name = "btnYerDegistir2";
            this.btnYerDegistir2.Size = new System.Drawing.Size(75, 49);
            this.btnYerDegistir2.TabIndex = 5;
            this.btnYerDegistir2.Text = "-----";
            this.btnYerDegistir2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnYerDegistir2);
            this.Controls.Add(this.BtnEkle);
            this.Controls.Add(this.textBoxCeviri2);
            this.Controls.Add(this.textBoxCeviri1);
            this.Controls.Add(this.comboBoxCeviri2);
            this.Controls.Add(this.comboBoxCeviri1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCeviri1;
        private System.Windows.Forms.ComboBox comboBoxCeviri2;
        private System.Windows.Forms.TextBox textBoxCeviri1;
        private System.Windows.Forms.TextBox textBoxCeviri2;
        private System.Windows.Forms.Button BtnEkle;
        private System.Windows.Forms.Button btnYerDegistir2;
    }
}

