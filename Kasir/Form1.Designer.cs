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
            nudMinuman = new NumericUpDown();
            nudMakanan = new NumericUpDown();
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
            txtKasir = new TextBox();
            label6 = new Label();
            btnClear = new Button();
            groupBox1 = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            gbMakMin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudMinuman).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMakanan).BeginInit();
            gbSub.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // gbMakMin
            // 
            gbMakMin.BackColor = Color.FromArgb(192, 210, 240);
            gbMakMin.Controls.Add(nudMinuman);
            gbMakMin.Controls.Add(nudMakanan);
            gbMakMin.Controls.Add(cmbMinuman);
            gbMakMin.Controls.Add(cmbMakanan);
            gbMakMin.Controls.Add(lblPilihMin);
            gbMakMin.Controls.Add(lblPilihMak);
            gbMakMin.Font = new Font("Arial Rounded MT Bold", 13.8F);
            gbMakMin.ForeColor = Color.FromArgb(50, 76, 120);
            gbMakMin.Location = new Point(33, 46);
            gbMakMin.Name = "gbMakMin";
            gbMakMin.Size = new Size(564, 183);
            gbMakMin.TabIndex = 0;
            gbMakMin.TabStop = false;
            gbMakMin.Text = "Daftar Makanan dan Minuman";
            // 
            // nudMinuman
            // 
            nudMinuman.BackColor = Color.FromArgb(247, 242, 233);
            nudMinuman.ForeColor = Color.FromArgb(67, 96, 143);
            nudMinuman.Location = new Point(443, 105);
            nudMinuman.Name = "nudMinuman";
            nudMinuman.Size = new Size(101, 34);
            nudMinuman.TabIndex = 5;
            nudMinuman.ValueChanged += nudMinuman_ValueChanged;
            // 
            // nudMakanan
            // 
            nudMakanan.BackColor = Color.FromArgb(247, 242, 233);
            nudMakanan.ForeColor = Color.FromArgb(67, 96, 143);
            nudMakanan.Location = new Point(443, 54);
            nudMakanan.Name = "nudMakanan";
            nudMakanan.Size = new Size(101, 34);
            nudMakanan.TabIndex = 4;
            nudMakanan.ValueChanged += nudMakanan_ValueChanged;
            // 
            // cmbMinuman
            // 
            cmbMinuman.BackColor = Color.FromArgb(247, 242, 233);
            cmbMinuman.ForeColor = Color.FromArgb(67, 96, 143);
            cmbMinuman.FormattingEnabled = true;
            cmbMinuman.Items.AddRange(new object[] { "Matcha", "Air", "Thai Tea" });
            cmbMinuman.Location = new Point(144, 105);
            cmbMinuman.Name = "cmbMinuman";
            cmbMinuman.Size = new Size(280, 35);
            cmbMinuman.TabIndex = 3;
            cmbMinuman.SelectedIndexChanged += cmbMinuman_SelectedIndexChanged;
            // 
            // cmbMakanan
            // 
            cmbMakanan.BackColor = Color.FromArgb(247, 242, 233);
            cmbMakanan.ForeColor = Color.FromArgb(67, 96, 143);
            cmbMakanan.FormattingEnabled = true;
            cmbMakanan.Items.AddRange(new object[] { "Katsu", "Ramen", "Sushi" });
            cmbMakanan.Location = new Point(144, 53);
            cmbMakanan.Name = "cmbMakanan";
            cmbMakanan.Size = new Size(280, 35);
            cmbMakanan.TabIndex = 2;
            cmbMakanan.SelectedIndexChanged += cmbMakanan_SelectedIndexChanged;
            // 
            // lblPilihMin
            // 
            lblPilihMin.AutoSize = true;
            lblPilihMin.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            lblPilihMin.ForeColor = Color.FromArgb(50, 76, 120);
            lblPilihMin.Location = new Point(4, 115);
            lblPilihMin.Name = "lblPilihMin";
            lblPilihMin.Size = new Size(117, 19);
            lblPilihMin.TabIndex = 1;
            lblPilihMin.Text = "Pilih Minuman";
            // 
            // lblPilihMak
            // 
            lblPilihMak.AutoSize = true;
            lblPilihMak.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            lblPilihMak.ForeColor = Color.FromArgb(50, 76, 120);
            lblPilihMak.Location = new Point(4, 63);
            lblPilihMak.Name = "lblPilihMak";
            lblPilihMak.Size = new Size(116, 19);
            lblPilihMak.TabIndex = 0;
            lblPilihMak.Text = "Pilih Makanan";
            // 
            // gbSub
            // 
            gbSub.BackColor = Color.FromArgb(192, 210, 240);
            gbSub.Controls.Add(txtMinuman);
            gbSub.Controls.Add(txtMakanan);
            gbSub.Font = new Font("Arial Rounded MT Bold", 13.8F);
            gbSub.ForeColor = Color.FromArgb(50, 76, 120);
            gbSub.Location = new Point(33, 270);
            gbSub.Name = "gbSub";
            gbSub.Size = new Size(429, 183);
            gbSub.TabIndex = 1;
            gbSub.TabStop = false;
            gbSub.Text = "Sub Total";
            // 
            // txtMinuman
            // 
            txtMinuman.BackColor = Color.FromArgb(247, 242, 233);
            txtMinuman.Font = new Font("Arial Rounded MT Bold", 10.2F);
            txtMinuman.Location = new Point(34, 110);
            txtMinuman.Multiline = true;
            txtMinuman.Name = "txtMinuman";
            txtMinuman.Size = new Size(358, 36);
            txtMinuman.TabIndex = 1;
            // 
            // txtMakanan
            // 
            txtMakanan.BackColor = Color.FromArgb(247, 242, 233);
            txtMakanan.Font = new Font("Arial Rounded MT Bold", 10.2F);
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
            label3.ForeColor = Color.FromArgb(50, 76, 120);
            label3.Location = new Point(11, 23);
            label3.Name = "label3";
            label3.Size = new Size(76, 24);
            label3.TabIndex = 2;
            label3.Text = "TOTAL";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(50, 76, 120);
            label4.Location = new Point(11, 77);
            label4.Name = "label4";
            label4.Size = new Size(73, 24);
            label4.TabIndex = 3;
            label4.Text = "BAYAR";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(50, 76, 120);
            label5.Location = new Point(11, 134);
            label5.Name = "label5";
            label5.Size = new Size(98, 24);
            label5.TabIndex = 4;
            label5.Text = "KEMBALI";
            label5.Click += label5_Click;
            // 
            // txtBayar
            // 
            txtBayar.BackColor = Color.FromArgb(247, 242, 233);
            txtBayar.Font = new Font("Arial Rounded MT Bold", 10.2F);
            txtBayar.ForeColor = Color.FromArgb(67, 96, 143);
            txtBayar.Location = new Point(115, 70);
            txtBayar.Multiline = true;
            txtBayar.Name = "txtBayar";
            txtBayar.Size = new Size(277, 36);
            txtBayar.TabIndex = 3;
            txtBayar.TextChanged += txtBayar_TextChanged;
            // 
            // txtTotal
            // 
            txtTotal.BackColor = Color.FromArgb(247, 242, 233);
            txtTotal.Font = new Font("Arial Rounded MT Bold", 10.2F);
            txtTotal.ForeColor = Color.FromArgb(67, 96, 143);
            txtTotal.Location = new Point(115, 18);
            txtTotal.Multiline = true;
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(277, 36);
            txtTotal.TabIndex = 2;
            // 
            // txtKembali
            // 
            txtKembali.BackColor = Color.FromArgb(247, 242, 233);
            txtKembali.Font = new Font("Arial Rounded MT Bold", 10.2F);
            txtKembali.ForeColor = Color.FromArgb(67, 96, 143);
            txtKembali.Location = new Point(115, 126);
            txtKembali.Multiline = true;
            txtKembali.Name = "txtKembali";
            txtKembali.Size = new Size(277, 36);
            txtKembali.TabIndex = 5;
            // 
            // btnProses
            // 
            btnProses.BackColor = Color.FromArgb(67, 96, 143);
            btnProses.Font = new Font("Arial Rounded MT Bold", 9F);
            btnProses.ForeColor = Color.FromArgb(252, 243, 222);
            btnProses.Location = new Point(800, 484);
            btnProses.Name = "btnProses";
            btnProses.Size = new Size(117, 44);
            btnProses.TabIndex = 6;
            btnProses.Text = "Proses";
            btnProses.UseVisualStyleBackColor = false;
            btnProses.Click += btnProses_Click;
            // 
            // btnTutup
            // 
            btnTutup.BackColor = Color.FromArgb(67, 96, 143);
            btnTutup.Font = new Font("Arial Rounded MT Bold", 9F);
            btnTutup.ForeColor = Color.FromArgb(252, 243, 222);
            btnTutup.Location = new Point(227, 490);
            btnTutup.Name = "btnTutup";
            btnTutup.Size = new Size(117, 32);
            btnTutup.TabIndex = 7;
            btnTutup.Text = "Tutup";
            btnTutup.UseVisualStyleBackColor = false;
            btnTutup.Click += btnTutup_Click;
            // 
            // btnSebelumnya
            // 
            btnSebelumnya.BackColor = Color.FromArgb(67, 96, 143);
            btnSebelumnya.Font = new Font("Arial Rounded MT Bold", 9F);
            btnSebelumnya.ForeColor = Color.FromArgb(252, 243, 222);
            btnSebelumnya.Location = new Point(81, 490);
            btnSebelumnya.Name = "btnSebelumnya";
            btnSebelumnya.Size = new Size(117, 32);
            btnSebelumnya.TabIndex = 8;
            btnSebelumnya.Text = "Sebelumnya";
            btnSebelumnya.UseVisualStyleBackColor = false;
            btnSebelumnya.Click += btnSebelumnya_Click;
            // 
            // txtKasir
            // 
            txtKasir.BackColor = Color.FromArgb(247, 242, 233);
            txtKasir.Font = new Font("Arial Rounded MT Bold", 10.2F);
            txtKasir.ForeColor = Color.FromArgb(67, 96, 143);
            txtKasir.Location = new Point(621, 193);
            txtKasir.Multiline = true;
            txtKasir.Name = "txtKasir";
            txtKasir.Size = new Size(259, 36);
            txtKasir.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(50, 76, 120);
            label6.Location = new Point(621, 159);
            label6.Name = "label6";
            label6.Size = new Size(76, 24);
            label6.TabIndex = 10;
            label6.Text = "KASIR:";
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(67, 96, 143);
            btnClear.Font = new Font("Arial Rounded MT Bold", 9F);
            btnClear.ForeColor = Color.FromArgb(252, 243, 222);
            btnClear.Location = new Point(366, 490);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(117, 32);
            btnClear.TabIndex = 11;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(192, 210, 240);
            groupBox1.Controls.Add(txtBayar);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtTotal);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtKembali);
            groupBox1.Location = new Point(488, 270);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(429, 183);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MV Boli", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(247, 242, 233);
            label1.Location = new Point(662, 70);
            label1.Name = "label1";
            label1.Size = new Size(201, 58);
            label1.TabIndex = 12;
            label1.Text = "NekoFee";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(247, 242, 233);
            label2.Location = new Point(629, 123);
            label2.Name = "label2";
            label2.Size = new Size(268, 18);
            label2.TabIndex = 13;
            label2.Text = "Tempat hangat untuk cerita dan rasa.";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(143, 165, 201);
            ClientSize = new Size(960, 572);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(btnClear);
            Controls.Add(label6);
            Controls.Add(txtKasir);
            Controls.Add(btnSebelumnya);
            Controls.Add(btnTutup);
            Controls.Add(btnProses);
            Controls.Add(gbSub);
            Controls.Add(gbMakMin);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            gbMakMin.ResumeLayout(false);
            gbMakMin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudMinuman).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMakanan).EndInit();
            gbSub.ResumeLayout(false);
            gbSub.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
    }
}
