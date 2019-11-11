namespace MixApp.Bilgi
{
    partial class frmUrunKayit
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnAra = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCollapse = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Liste = new System.Windows.Forms.DataGridView();
            this.UrunKodu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UrunGrup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Renk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Beden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sezon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Barkod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCollapse2 = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.txtGTarih = new System.Windows.Forms.DateTimePicker();
            this.txtBeden = new System.Windows.Forms.ComboBox();
            this.txtSezon = new System.Windows.Forms.ComboBox();
            this.txtRenk = new System.Windows.Forms.ComboBox();
            this.txtMarka = new System.Windows.Forms.ComboBox();
            this.txtUrunGrup = new System.Windows.Forms.ComboBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.txtCari = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txtUrunGrupNo = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtAra
            // 
            this.txtAra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAra.Location = new System.Drawing.Point(174, 8);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(331, 20);
            this.txtAra.TabIndex = 3;
            // 
            // btnPrint
            // 
            this.btnPrint.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnPrint.Location = new System.Drawing.Point(620, 0);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 35);
            this.btnPrint.TabIndex = 2;
            this.btnPrint.Text = "Yazdır";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnAra
            // 
            this.btnAra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAra.Location = new System.Drawing.Point(511, 6);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(75, 23);
            this.btnAra.TabIndex = 1;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            // 
            // btnTemizle
            // 
            this.btnTemizle.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnTemizle.Location = new System.Drawing.Point(0, 0);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(75, 35);
            this.btnTemizle.TabIndex = 0;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.txtAra);
            this.panel1.Controls.Add(this.btnPrint);
            this.panel1.Controls.Add(this.btnAra);
            this.panel1.Controls.Add(this.btnTemizle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(695, 35);
            this.panel1.TabIndex = 0;
            // 
            // btnCollapse
            // 
            this.btnCollapse.BackColor = System.Drawing.Color.Red;
            this.btnCollapse.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCollapse.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCollapse.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCollapse.Location = new System.Drawing.Point(699, 0);
            this.btnCollapse.Name = "btnCollapse";
            this.btnCollapse.Size = new System.Drawing.Size(38, 487);
            this.btnCollapse.TabIndex = 0;
            this.btnCollapse.Text = "Gizle";
            this.btnCollapse.UseVisualStyleBackColor = false;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKaydet.Location = new System.Drawing.Point(0, 0);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(179, 55);
            this.btnKaydet.TabIndex = 0;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(46, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Göderici Firma :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Liste
            // 
            this.Liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Liste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UrunKodu,
            this.UrunGrup,
            this.Marka,
            this.Renk,
            this.Beden,
            this.Sezon,
            this.Barkod});
            this.Liste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Liste.Location = new System.Drawing.Point(0, 35);
            this.Liste.MultiSelect = false;
            this.Liste.Name = "Liste";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Liste.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Liste.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.Liste.Size = new System.Drawing.Size(695, 255);
            this.Liste.TabIndex = 1;
            this.Liste.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.Liste_CellEndEdit);
            this.Liste.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.Liste_EditingControlShowing);
            // 
            // UrunKodu
            // 
            this.UrunKodu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UrunKodu.HeaderText = "Ürün Kodu";
            this.UrunKodu.Name = "UrunKodu";
            // 
            // UrunGrup
            // 
            this.UrunGrup.HeaderText = "Ürün Grup";
            this.UrunGrup.Name = "UrunGrup";
            this.UrunGrup.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.UrunGrup.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Marka
            // 
            this.Marka.HeaderText = "Marka";
            this.Marka.Name = "Marka";
            this.Marka.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Marka.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Renk
            // 
            this.Renk.HeaderText = "Renk";
            this.Renk.Name = "Renk";
            this.Renk.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Renk.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Beden
            // 
            this.Beden.HeaderText = "Beden";
            this.Beden.Name = "Beden";
            this.Beden.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Beden.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Sezon
            // 
            this.Sezon.HeaderText = "Sezon";
            this.Sezon.Name = "Sezon";
            this.Sezon.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Sezon.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Barkod
            // 
            this.Barkod.HeaderText = "Barkod";
            this.Barkod.Name = "Barkod";
            this.Barkod.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Barkod.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // btnCollapse2
            // 
            this.btnCollapse2.BackColor = System.Drawing.Color.DarkGray;
            this.btnCollapse2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCollapse2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCollapse2.Location = new System.Drawing.Point(0, 158);
            this.btnCollapse2.Name = "btnCollapse2";
            this.btnCollapse2.Size = new System.Drawing.Size(695, 27);
            this.btnCollapse2.TabIndex = 0;
            this.btnCollapse2.Text = "Gizle";
            this.btnCollapse2.UseVisualStyleBackColor = false;
            // 
            // btnKapat
            // 
            this.btnKapat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnKapat.Location = new System.Drawing.Point(0, 432);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(179, 51);
            this.btnKapat.TabIndex = 0;
            this.btnKapat.Text = "Formu Kapat";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.txtGTarih);
            this.splitContainer2.Panel1.Controls.Add(this.txtBeden);
            this.splitContainer2.Panel1.Controls.Add(this.txtSezon);
            this.splitContainer2.Panel1.Controls.Add(this.txtRenk);
            this.splitContainer2.Panel1.Controls.Add(this.txtMarka);
            this.splitContainer2.Panel1.Controls.Add(this.txtUrunGrup);
            this.splitContainer2.Panel1.Controls.Add(this.txtAciklama);
            this.splitContainer2.Panel1.Controls.Add(this.txtCari);
            this.splitContainer2.Panel1.Controls.Add(this.label2);
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            this.splitContainer2.Panel1.Controls.Add(this.btnCollapse2);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.Liste);
            this.splitContainer2.Panel2.Controls.Add(this.panel1);
            this.splitContainer2.Size = new System.Drawing.Size(699, 487);
            this.splitContainer2.SplitterDistance = 189;
            this.splitContainer2.TabIndex = 1;
            // 
            // txtGTarih
            // 
            this.txtGTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtGTarih.Location = new System.Drawing.Point(443, 25);
            this.txtGTarih.Name = "txtGTarih";
            this.txtGTarih.Size = new System.Drawing.Size(121, 20);
            this.txtGTarih.TabIndex = 9;
            // 
            // txtBeden
            // 
            this.txtBeden.FormattingEnabled = true;
            this.txtBeden.Location = new System.Drawing.Point(443, 52);
            this.txtBeden.Name = "txtBeden";
            this.txtBeden.Size = new System.Drawing.Size(121, 21);
            this.txtBeden.TabIndex = 8;
            // 
            // txtSezon
            // 
            this.txtSezon.FormattingEnabled = true;
            this.txtSezon.Location = new System.Drawing.Point(443, 89);
            this.txtSezon.Name = "txtSezon";
            this.txtSezon.Size = new System.Drawing.Size(121, 21);
            this.txtSezon.TabIndex = 7;
            // 
            // txtRenk
            // 
            this.txtRenk.FormattingEnabled = true;
            this.txtRenk.Location = new System.Drawing.Point(302, 90);
            this.txtRenk.Name = "txtRenk";
            this.txtRenk.Size = new System.Drawing.Size(121, 21);
            this.txtRenk.TabIndex = 6;
            // 
            // txtMarka
            // 
            this.txtMarka.FormattingEnabled = true;
            this.txtMarka.Location = new System.Drawing.Point(168, 90);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(121, 21);
            this.txtMarka.TabIndex = 5;
            // 
            // txtUrunGrup
            // 
            this.txtUrunGrup.FormattingEnabled = true;
            this.txtUrunGrup.Location = new System.Drawing.Point(34, 90);
            this.txtUrunGrup.Name = "txtUrunGrup";
            this.txtUrunGrup.Size = new System.Drawing.Size(121, 21);
            this.txtUrunGrup.TabIndex = 4;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(168, 52);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(255, 20);
            this.txtAciklama.TabIndex = 3;
            // 
            // txtCari
            // 
            this.txtCari.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtCari.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtCari.FormattingEnabled = true;
            this.txtCari.Location = new System.Drawing.Point(168, 25);
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new System.Drawing.Size(255, 21);
            this.txtCari.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(46, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Açıklama :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel1.Controls.Add(this.btnCollapse);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Tomato;
            this.splitContainer1.Panel2.Controls.Add(this.txtUrunGrupNo);
            this.splitContainer1.Panel2.Controls.Add(this.btnKapat);
            this.splitContainer1.Panel2.Controls.Add(this.btnKaydet);
            this.splitContainer1.Size = new System.Drawing.Size(924, 487);
            this.splitContainer1.SplitterDistance = 737;
            this.splitContainer1.TabIndex = 1;
            // 
            // txtUrunGrupNo
            // 
            this.txtUrunGrupNo.Location = new System.Drawing.Point(4, 61);
            this.txtUrunGrupNo.Name = "txtUrunGrupNo";
            this.txtUrunGrupNo.ReadOnly = true;
            this.txtUrunGrupNo.Size = new System.Drawing.Size(172, 20);
            this.txtUrunGrupNo.TabIndex = 1;
            this.txtUrunGrupNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmUrunKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 487);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmUrunKayit";
            this.Text = "frmUrunKayit";
            this.Load += new System.EventHandler(this.frmUrunKayit_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCollapse;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Liste;
        private System.Windows.Forms.Button btnCollapse2;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.ComboBox txtCari;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox txtUrunGrup;
        private System.Windows.Forms.ComboBox txtMarka;
        private System.Windows.Forms.ComboBox txtBeden;
        private System.Windows.Forms.ComboBox txtSezon;
        private System.Windows.Forms.ComboBox txtRenk;
        private System.Windows.Forms.DataGridViewTextBoxColumn UrunKodu;
        private System.Windows.Forms.DataGridViewTextBoxColumn UrunGrup;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marka;
        private System.Windows.Forms.DataGridViewTextBoxColumn Renk;
        private System.Windows.Forms.DataGridViewTextBoxColumn Beden;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sezon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Barkod;
        private System.Windows.Forms.TextBox txtUrunGrupNo;
        private System.Windows.Forms.DateTimePicker txtGTarih;
    }
}