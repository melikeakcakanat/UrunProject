namespace MixApp
{
    partial class frmAnasayfa
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnKapat = new System.Windows.Forms.Button();
            this.btnUc = new System.Windows.Forms.Button();
            this.btnIki = new System.Windows.Forms.Button();
            this.btnBir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pnlUc = new System.Windows.Forms.Panel();
            this.pnlIki = new System.Windows.Forms.Panel();
            this.btnAlisListe = new System.Windows.Forms.Button();
            this.btnSatis = new System.Windows.Forms.Button();
            this.btnAlis = new System.Windows.Forms.Button();
            this.pnlBir = new System.Windows.Forms.Panel();
            this.btnUrunKayitListe = new System.Windows.Forms.Button();
            this.btnUrunKayit = new System.Windows.Forms.Button();
            this.btnMarka = new System.Windows.Forms.Button();
            this.btnSezon = new System.Windows.Forms.Button();
            this.btnBeden = new System.Windows.Forms.Button();
            this.btnRenk = new System.Windows.Forms.Button();
            this.btnUrunGrupGiris = new System.Windows.Forms.Button();
            this.btnCariGiris = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnlIki.SuspendLayout();
            this.pnlBir.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.btnKapat);
            this.panel1.Controls.Add(this.btnUc);
            this.panel1.Controls.Add(this.btnIki);
            this.panel1.Controls.Add(this.btnBir);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(893, 65);
            this.panel1.TabIndex = 0;
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.Location = new System.Drawing.Point(787, 21);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(75, 23);
            this.btnKapat.TabIndex = 0;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnUc
            // 
            this.btnUc.Location = new System.Drawing.Point(298, 21);
            this.btnUc.Name = "btnUc";
            this.btnUc.Size = new System.Drawing.Size(75, 23);
            this.btnUc.TabIndex = 0;
            this.btnUc.Text = "Üç";
            this.btnUc.UseVisualStyleBackColor = true;
            this.btnUc.Click += new System.EventHandler(this.btnUc_Click);
            // 
            // btnIki
            // 
            this.btnIki.Location = new System.Drawing.Point(146, 21);
            this.btnIki.Name = "btnIki";
            this.btnIki.Size = new System.Drawing.Size(107, 23);
            this.btnIki.TabIndex = 0;
            this.btnIki.Text = "Alış-Satış İşlemleri";
            this.btnIki.UseVisualStyleBackColor = true;
            this.btnIki.Click += new System.EventHandler(this.btnIki_Click);
            // 
            // btnBir
            // 
            this.btnBir.Location = new System.Drawing.Point(32, 21);
            this.btnBir.Name = "btnBir";
            this.btnBir.Size = new System.Drawing.Size(75, 23);
            this.btnBir.TabIndex = 0;
            this.btnBir.Text = "Bilgi Giriş";
            this.btnBir.UseVisualStyleBackColor = true;
            this.btnBir.Click += new System.EventHandler(this.btnBir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox1.Controls.Add(this.pnlUc);
            this.groupBox1.Controls.Add(this.pnlIki);
            this.groupBox1.Controls.Add(this.pnlBir);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(211, 385);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // pnlUc
            // 
            this.pnlUc.BackColor = System.Drawing.Color.DarkTurquoise;
            this.pnlUc.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlUc.Location = new System.Drawing.Point(421, 16);
            this.pnlUc.Name = "pnlUc";
            this.pnlUc.Size = new System.Drawing.Size(209, 366);
            this.pnlUc.TabIndex = 0;
            this.pnlUc.Visible = false;
            // 
            // pnlIki
            // 
            this.pnlIki.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.pnlIki.Controls.Add(this.btnAlisListe);
            this.pnlIki.Controls.Add(this.btnSatis);
            this.pnlIki.Controls.Add(this.btnAlis);
            this.pnlIki.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlIki.Location = new System.Drawing.Point(212, 16);
            this.pnlIki.Name = "pnlIki";
            this.pnlIki.Size = new System.Drawing.Size(209, 366);
            this.pnlIki.TabIndex = 0;
            this.pnlIki.Visible = false;
            // 
            // btnAlisListe
            // 
            this.btnAlisListe.Location = new System.Drawing.Point(29, 88);
            this.btnAlisListe.Name = "btnAlisListe";
            this.btnAlisListe.Size = new System.Drawing.Size(111, 23);
            this.btnAlisListe.TabIndex = 1;
            this.btnAlisListe.Text = "Alış Listesi";
            this.btnAlisListe.UseVisualStyleBackColor = true;
            this.btnAlisListe.Click += new System.EventHandler(this.btnAlisListe_Click);
            // 
            // btnSatis
            // 
            this.btnSatis.Location = new System.Drawing.Point(29, 58);
            this.btnSatis.Name = "btnSatis";
            this.btnSatis.Size = new System.Drawing.Size(111, 23);
            this.btnSatis.TabIndex = 1;
            this.btnSatis.Text = "Satış";
            this.btnSatis.UseVisualStyleBackColor = true;
            this.btnSatis.Click += new System.EventHandler(this.btnSatis_Click);
            // 
            // btnAlis
            // 
            this.btnAlis.Location = new System.Drawing.Point(29, 29);
            this.btnAlis.Name = "btnAlis";
            this.btnAlis.Size = new System.Drawing.Size(111, 23);
            this.btnAlis.TabIndex = 0;
            this.btnAlis.Text = "Alış";
            this.btnAlis.UseVisualStyleBackColor = true;
            this.btnAlis.Click += new System.EventHandler(this.btnAlis_Click);
            // 
            // pnlBir
            // 
            this.pnlBir.BackColor = System.Drawing.Color.LightSalmon;
            this.pnlBir.Controls.Add(this.btnUrunKayitListe);
            this.pnlBir.Controls.Add(this.btnUrunKayit);
            this.pnlBir.Controls.Add(this.btnMarka);
            this.pnlBir.Controls.Add(this.btnSezon);
            this.pnlBir.Controls.Add(this.btnBeden);
            this.pnlBir.Controls.Add(this.btnRenk);
            this.pnlBir.Controls.Add(this.btnUrunGrupGiris);
            this.pnlBir.Controls.Add(this.btnCariGiris);
            this.pnlBir.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlBir.Location = new System.Drawing.Point(3, 16);
            this.pnlBir.Name = "pnlBir";
            this.pnlBir.Size = new System.Drawing.Size(209, 366);
            this.pnlBir.TabIndex = 0;
            // 
            // btnUrunKayitListe
            // 
            this.btnUrunKayitListe.Location = new System.Drawing.Point(11, 233);
            this.btnUrunKayitListe.Name = "btnUrunKayitListe";
            this.btnUrunKayitListe.Size = new System.Drawing.Size(124, 23);
            this.btnUrunKayitListe.TabIndex = 6;
            this.btnUrunKayitListe.Text = "Ürün Kayıt Listesi";
            this.btnUrunKayitListe.UseVisualStyleBackColor = true;
            this.btnUrunKayitListe.Click += new System.EventHandler(this.btnUrunKayitListe_Click);
            // 
            // btnUrunKayit
            // 
            this.btnUrunKayit.Location = new System.Drawing.Point(11, 204);
            this.btnUrunKayit.Name = "btnUrunKayit";
            this.btnUrunKayit.Size = new System.Drawing.Size(124, 23);
            this.btnUrunKayit.TabIndex = 6;
            this.btnUrunKayit.Text = "Ürün Kayıt";
            this.btnUrunKayit.UseVisualStyleBackColor = true;
            this.btnUrunKayit.Click += new System.EventHandler(this.btnUrunKayit_Click);
            // 
            // btnMarka
            // 
            this.btnMarka.Location = new System.Drawing.Point(11, 175);
            this.btnMarka.Name = "btnMarka";
            this.btnMarka.Size = new System.Drawing.Size(124, 23);
            this.btnMarka.TabIndex = 5;
            this.btnMarka.Text = "Marka Giriş";
            this.btnMarka.UseVisualStyleBackColor = true;
            this.btnMarka.Click += new System.EventHandler(this.btnMarka_Click);
            // 
            // btnSezon
            // 
            this.btnSezon.Location = new System.Drawing.Point(11, 146);
            this.btnSezon.Name = "btnSezon";
            this.btnSezon.Size = new System.Drawing.Size(124, 23);
            this.btnSezon.TabIndex = 4;
            this.btnSezon.Text = "Sezon Girişi";
            this.btnSezon.UseVisualStyleBackColor = true;
            this.btnSezon.Click += new System.EventHandler(this.btnSezon_Click);
            // 
            // btnBeden
            // 
            this.btnBeden.Location = new System.Drawing.Point(11, 117);
            this.btnBeden.Name = "btnBeden";
            this.btnBeden.Size = new System.Drawing.Size(124, 23);
            this.btnBeden.TabIndex = 3;
            this.btnBeden.Text = "Beden Girişi";
            this.btnBeden.UseVisualStyleBackColor = true;
            this.btnBeden.Click += new System.EventHandler(this.btnBeden_Click);
            // 
            // btnRenk
            // 
            this.btnRenk.Location = new System.Drawing.Point(11, 88);
            this.btnRenk.Name = "btnRenk";
            this.btnRenk.Size = new System.Drawing.Size(124, 23);
            this.btnRenk.TabIndex = 2;
            this.btnRenk.Text = "Renk Girişi";
            this.btnRenk.UseVisualStyleBackColor = true;
            this.btnRenk.Click += new System.EventHandler(this.btnRenk_Click);
            // 
            // btnUrunGrupGiris
            // 
            this.btnUrunGrupGiris.Location = new System.Drawing.Point(10, 59);
            this.btnUrunGrupGiris.Name = "btnUrunGrupGiris";
            this.btnUrunGrupGiris.Size = new System.Drawing.Size(125, 23);
            this.btnUrunGrupGiris.TabIndex = 1;
            this.btnUrunGrupGiris.Text = "Ürün Grup Giriş";
            this.btnUrunGrupGiris.UseVisualStyleBackColor = true;
            this.btnUrunGrupGiris.Click += new System.EventHandler(this.btnUrunGrupGiris_Click);
            // 
            // btnCariGiris
            // 
            this.btnCariGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCariGiris.Location = new System.Drawing.Point(11, 32);
            this.btnCariGiris.Name = "btnCariGiris";
            this.btnCariGiris.Size = new System.Drawing.Size(124, 21);
            this.btnCariGiris.TabIndex = 0;
            this.btnCariGiris.Text = "Cari Giriş";
            this.btnCariGiris.UseVisualStyleBackColor = true;
            this.btnCariGiris.Click += new System.EventHandler(this.btnCariGiris_Click);
            // 
            // frmAnasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Name = "frmAnasayfa";
            this.Text = "frmAnasayfa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmAnasayfa_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.pnlIki.ResumeLayout(false);
            this.pnlBir.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Button btnUc;
        private System.Windows.Forms.Button btnIki;
        private System.Windows.Forms.Button btnBir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel pnlUc;
        private System.Windows.Forms.Panel pnlIki;
        private System.Windows.Forms.Panel pnlBir;
        private System.Windows.Forms.Button btnCariGiris;
        private System.Windows.Forms.Button btnUrunGrupGiris;
        private System.Windows.Forms.Button btnRenk;
        private System.Windows.Forms.Button btnBeden;
        private System.Windows.Forms.Button btnSezon;
        private System.Windows.Forms.Button btnMarka;
        private System.Windows.Forms.Button btnUrunKayit;
        private System.Windows.Forms.Button btnSatis;
        private System.Windows.Forms.Button btnAlis;
        private System.Windows.Forms.Button btnAlisListe;
        private System.Windows.Forms.Button btnUrunKayitListe;
    }
}