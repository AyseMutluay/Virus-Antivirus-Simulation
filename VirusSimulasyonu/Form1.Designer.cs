namespace VirusSimulasyonu
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
            this.btnVirus = new System.Windows.Forms.Button();
            this.btnAntivirus = new System.Windows.Forms.Button();
            this.lstLog = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnVirus
            // 
            this.btnVirus.Location = new System.Drawing.Point(56, 113);
            this.btnVirus.Name = "btnVirus";
            this.btnVirus.Size = new System.Drawing.Size(231, 57);
            this.btnVirus.TabIndex = 0;
            this.btnVirus.Text = "VİRÜS";
            this.btnVirus.UseVisualStyleBackColor = true;
            this.btnVirus.Click += new System.EventHandler(this.btnVirus_Click);
            // 
            // btnAntivirus
            // 
            this.btnAntivirus.Location = new System.Drawing.Point(56, 219);
            this.btnAntivirus.Name = "btnAntivirus";
            this.btnAntivirus.Size = new System.Drawing.Size(231, 63);
            this.btnAntivirus.TabIndex = 1;
            this.btnAntivirus.Text = "ANTİVİRÜS";
            this.btnAntivirus.UseVisualStyleBackColor = true;
            this.btnAntivirus.Click += new System.EventHandler(this.btnAntivirus_Click);
            // 
            // lstLog
            // 
            this.lstLog.FormattingEnabled = true;
            this.lstLog.ItemHeight = 16;
            this.lstLog.Location = new System.Drawing.Point(432, 58);
            this.lstLog.Name = "lstLog";
            this.lstLog.Size = new System.Drawing.Size(308, 276);
            this.lstLog.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstLog);
            this.Controls.Add(this.btnAntivirus);
            this.Controls.Add(this.btnVirus);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVirus;
        private System.Windows.Forms.Button btnAntivirus;
        private System.Windows.Forms.ListBox lstLog;
    }
}

