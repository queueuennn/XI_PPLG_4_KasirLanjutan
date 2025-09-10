namespace Kasir
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gbMakMin = new GroupBox();
            cmbMinuman = new ComboBox();
            cmbMakanan = new ComboBox();
            lblPilihMin = new Label();
            lblPilihMak = new Label();
            gbSub = new GroupBox();
            txtMinuman = new TextBox();
            txtMakanan = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtBayar = new TextBox();
            txtTotal = new TextBox();
            txtKembali = new TextBox();
            btnProses = new Button();
            btnTutup = new Button();
            btnSebelumnya = new Button();
            nudMakanan = new NumericUpDown();
            nudMinuman = new NumericUpDown();
            txtKasir = new TextBox();
            label6 = new Label();
            btnClear = new Button();
            gbMakMin.SuspendLayout();
            gbSub.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudMakanan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMinuman).BeginInit();
            SuspendLayout();
            // 
            // gbMakMin
            // 
            gbMakMin.Controls.Add(nudMinuman);
            gbMakMin.Controls.Add(nudMakanan);
            gbMakMin.Controls.Add(cmbMinuman);
            gbMakMin.Controls.Add(cmbMakanan);
            gbMakMin.Controls.Add(lblPilihMin);
            gbMakMin.Controls.Add(lblPilihMak);
            gbMakMin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbMakMin.Location = new Point(58, 28);
            gbMakMin.Name = "gbMakMin";
            gbMakMin.Size = new Size(751, 177);
            gbMakMin.TabIndex = 0;
            gbMakMin.TabStop = false;
            gbMakMin.Text = "Daftar Makanan dan Minuman";
            // 
            // cmbMinuman
            // 
            cmbMinuman.FormattingEnabled = true;
            cmbMinuman.Items.AddRange(new object[] { "Matcha", "Air", "Thai Tea" });
            cmbMinuman.Location = new Point(164, 112);
            cmbMinuman.Name = "cmbMinuman";
            cmbMinuman.Size = new Size(360, 36);
            cmbMinuman.TabIndex = 3;
            cmbMinuman.SelectedIndexChanged += cmbMinuman_SelectedIndexChanged;
            // 
            // cmbMakanan
            // 
            cmbMakanan.FormattingEnabled = true;
            cmbMakanan.Items.AddRange(new object[] { "Katsu", "Ramen", "Sushi" });
            cmbMakanan.Location = new Point(164, 60);
            cmbMakanan.Name = "cmbMakanan";
            cmbMakanan.Size = new Size(360, 36);
            cmbMakanan.TabIndex = 2;
            cmbMakanan.SelectedIndexChanged += cmbMakanan_SelectedIndexChanged;
            // 
            // lblPilihMin
            // 
            lblPilihMin.AutoSize = true;
            lblPilihMin.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            lblPilihMin.ForeColor = Color.MidnightBlue;
            lblPilihMin.Location = new Point(24, 122);
            lblPilihMin.Name = "lblPilihMin";
            lblPilihMin.Size = new Size(117, 19);
            lblPilihMin.TabIndex = 1;
            lblPilihMin.Text = "Pilih Minuman";
            // 
            // lblPilihMak
            // 
            lblPilihMak.AutoSize = true;
            lblPilihMak.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            lblPilihMak.ForeColor = Color.MidnightBlue;
            lblPilihMak.Location = new Point(24, 70);
            lblPilihMak.Name = "lblPilihMak";
            lblPilihMak.Size = new Size(116, 19);
            lblPilihMak.TabIndex = 0;
            lblPilihMak.Text = "Pilih Makanan";
            // 
            // gbSub
            // 
            gbSub.Controls.Add(txtMinuman);
            gbSub.Controls.Add(txtMakanan);
            gbSub.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbSub.Location = new Point(847, 30);
            gbSub.Name = "gbSub";
            gbSub.Size = new Size(429, 175);
            gbSub.TabIndex = 1;
            gbSub.TabStop = false;
            gbSub.Text = "Sub Total";
            // 
            // txtMinuman
            // 
            txtMinuman.Location = new Point(34, 110);
            txtMinuman.Multiline = true;
            txtMinuman.Name = "txtMinuman";
            txtMinuman.Size = new Size(358, 36);
            txtMinuman.TabIndex = 1;
            // 
            // txtMakanan
            // 
            txtMakanan.Location = new Point(34, 58);
            txtMakanan.Multiline = true;
            txtMakanan.Name = "txtMakanan";
            txtMakanan.Size = new Size(358, 36);
            txtMakanan.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold);
            label3.ForeColor = Color.MidnightBlue;
            label3.Location = new Point(678, 231);
            label3.Name = "label3";
            label3.Size = new Size(76, 24);
            label3.TabIndex = 2;
            label3.Text = "TOTAL";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold);
            label4.ForeColor = Color.MidnightBlue;
            label4.Location = new Point(678, 285);
            label4.Name = "label4";
            label4.Size = new Size(73, 24);
            label4.TabIndex = 3;
            label4.Text = "BAYAR";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Bold);
            label5.ForeColor = Color.MidnightBlue;
            label5.Location = new Point(678, 342);
            label5.Name = "label5";
            label5.Size = new Size(98, 24);
            label5.TabIndex = 4;
            label5.Text = "KEMBALI";
            label5.Click += label5_Click;
            // 
            // txtBayar
            // 
            txtBayar.Location = new Point(820, 286);
            txtBayar.Multiline = true;
            txtBayar.Name = "txtBayar";
            txtBayar.Size = new Size(419, 36);
            txtBayar.TabIndex = 3;
            txtBayar.TextChanged += txtBayar_TextChanged;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(820, 234);
            txtTotal.Multiline = true;
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(419, 36);
            txtTotal.TabIndex = 2;
            // 
            // txtKembali
            // 
            txtKembali.Location = new Point(820, 342);
            txtKembali.Multiline = true;
            txtKembali.Name = "txtKembali";
            txtKembali.Size = new Size(419, 36);
            txtKembali.TabIndex = 5;
            // 
            // btnProses
            // 
            btnProses.Location = new Point(972, 422);
            btnProses.Name = "btnProses";
            btnProses.Size = new Size(117, 32);
            btnProses.TabIndex = 6;
            btnProses.Text = "Proses";
            btnProses.UseVisualStyleBackColor = true;
            btnProses.Click += btnProses_Click;
            // 
            // btnTutup
            // 
            btnTutup.Location = new Point(1122, 422);
            btnTutup.Name = "btnTutup";
            btnTutup.Size = new Size(117, 32);
            btnTutup.TabIndex = 7;
            btnTutup.Text = "Tutup";
            btnTutup.UseVisualStyleBackColor = true;
            btnTutup.Click += btnTutup_Click;
            // 
            // btnSebelumnya
            // 
            btnSebelumnya.Location = new Point(58, 422);
            btnSebelumnya.Name = "btnSebelumnya";
            btnSebelumnya.Size = new Size(117, 32);
            btnSebelumnya.TabIndex = 8;
            btnSebelumnya.Text = "Sebelumnya";
            btnSebelumnya.UseVisualStyleBackColor = true;
            btnSebelumnya.Click += btnSebelumnya_Click;
            // 
            // nudMakanan
            // 
            nudMakanan.Location = new Point(563, 61);
            nudMakanan.Name = "nudMakanan";
            nudMakanan.Size = new Size(101, 34);
            nudMakanan.TabIndex = 4;
            nudMakanan.ValueChanged += nudMakanan_ValueChanged;
            // 
            // nudMinuman
            // 
            nudMinuman.Location = new Point(563, 112);
            nudMinuman.Name = "nudMinuman";
            nudMinuman.Size = new Size(101, 34);
            nudMinuman.TabIndex = 5;
            nudMinuman.ValueChanged += nudMinuman_ValueChanged;
            // 
            // txtKasir
            // 
            txtKasir.Location = new Point(221, 234);
            txtKasir.Multiline = true;
            txtKasir.Name = "txtKasir";
            txtKasir.Size = new Size(358, 36);
            txtKasir.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Bold);
            label6.ForeColor = Color.MidnightBlue;
            label6.Location = new Point(98, 239);
            label6.Name = "label6";
            label6.Size = new Size(76, 24);
            label6.TabIndex = 10;
            label6.Text = "KASIR:";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(820, 422);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(117, 32);
            btnClear.TabIndex = 11;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(1338, 534);
            Controls.Add(btnClear);
            Controls.Add(label6);
            Controls.Add(txtKasir);
            Controls.Add(btnSebelumnya);
            Controls.Add(btnTutup);
            Controls.Add(btnProses);
            Controls.Add(txtKembali);
            Controls.Add(txtBayar);
            Controls.Add(label5);
            Controls.Add(txtTotal);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(gbSub);
            Controls.Add(gbMakMin);
            Name = "Form1";
            Text = "Form1";
            gbMakMin.ResumeLayout(false);
            gbMakMin.PerformLayout();
            gbSub.ResumeLayout(false);
            gbSub.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudMakanan).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMinuman).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbMakMin;
        private Label lblPilihMak;
        private ComboBox cmbMinuman;
        private ComboBox cmbMakanan;
        private Label lblPilihMin;
        private GroupBox gbSub;
        private TextBox txtMakanan;
        private TextBox txtMinuman;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtBayar;
        private TextBox txtTotal;
        private TextBox txtKembali;
        private Button btnProses;
        private Button btnTutup;
        private Button btnSebelumnya;
        private NumericUpDown nudMinuman;
        private NumericUpDown nudMakanan;
        private TextBox txtKasir;
        private Label label6;
        private Button btnClear;
    }
}
