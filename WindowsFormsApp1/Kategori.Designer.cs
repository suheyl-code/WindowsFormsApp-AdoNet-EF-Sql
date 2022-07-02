namespace WindowsFormsApp1
{
    partial class Kategori
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.datagridKategori = new System.Windows.Forms.DataGridView();
            this.tbxKategoriAdi = new System.Windows.Forms.TextBox();
            this.tbxTanimi = new System.Windows.Forms.TextBox();
            this.btnKategoriEkle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagridKategori)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "KategoriAdi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(199, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tanimi";
            // 
            // datagridKategori
            // 
            this.datagridKategori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridKategori.Location = new System.Drawing.Point(15, 101);
            this.datagridKategori.Name = "datagridKategori";
            this.datagridKategori.RowHeadersWidth = 51;
            this.datagridKategori.RowTemplate.Height = 24;
            this.datagridKategori.Size = new System.Drawing.Size(713, 408);
            this.datagridKategori.TabIndex = 3;
            // 
            // tbxKategoriAdi
            // 
            this.tbxKategoriAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxKategoriAdi.Location = new System.Drawing.Point(15, 64);
            this.tbxKategoriAdi.Name = "tbxKategoriAdi";
            this.tbxKategoriAdi.Size = new System.Drawing.Size(143, 27);
            this.tbxKategoriAdi.TabIndex = 4;
            // 
            // tbxTanimi
            // 
            this.tbxTanimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTanimi.Location = new System.Drawing.Point(202, 64);
            this.tbxTanimi.Name = "tbxTanimi";
            this.tbxTanimi.Size = new System.Drawing.Size(196, 27);
            this.tbxTanimi.TabIndex = 5;
            // 
            // btnKategoriEkle
            // 
            this.btnKategoriEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKategoriEkle.Location = new System.Drawing.Point(452, 29);
            this.btnKategoriEkle.Name = "btnKategoriEkle";
            this.btnKategoriEkle.Size = new System.Drawing.Size(90, 35);
            this.btnKategoriEkle.TabIndex = 6;
            this.btnKategoriEkle.Text = "Ekle";
            this.btnKategoriEkle.UseVisualStyleBackColor = true;
            this.btnKategoriEkle.Click += new System.EventHandler(this.btnKategoriEkle_Click);
            // 
            // Kategori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 521);
            this.Controls.Add(this.btnKategoriEkle);
            this.Controls.Add(this.tbxTanimi);
            this.Controls.Add(this.tbxKategoriAdi);
            this.Controls.Add(this.datagridKategori);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Kategori";
            this.Text = "Kategori";
            this.Load += new System.EventHandler(this.Kategori_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridKategori)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView datagridKategori;
        private System.Windows.Forms.TextBox tbxKategoriAdi;
        private System.Windows.Forms.TextBox tbxTanimi;
        private System.Windows.Forms.Button btnKategoriEkle;
    }
}