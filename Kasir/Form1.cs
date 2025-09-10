namespace Kasir
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // harga satuan
            
        }

        int hargaMakanan = 0;
        int hargaMinuman = 0;

        private void btnProses_Click(object sender, EventArgs e)
        {
            // Cek apakah kasir sudah diisi
            if (string.IsNullOrWhiteSpace(txtKasir.Text))
            {
                MessageBox.Show("Nama kasir wajib diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtKasir.Focus();
                return;
            }

            // Cek apakah bayar sudah diisi
            if (string.IsNullOrWhiteSpace(txtBayar.Text))
            {
                MessageBox.Show("Jumlah bayar wajib diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBayar.Focus();
                return;
            }

            // Cek apakah cukup bayar
            int total = int.Parse(txtTotal.Text);
            int bayar = int.Parse(txtBayar.Text);

            if (bayar < total)
            {
                MessageBox.Show("Uang bayar kurang dari total!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBayar.Focus();
                return;
            }

            string kasir = txtKasir.Text;
            string makanan = cmbMakanan.SelectedItem != null ? cmbMakanan.SelectedItem.ToString() : "-";
            string minuman = cmbMinuman.SelectedItem != null ? cmbMinuman.SelectedItem.ToString() : "-";
            string kembali = txtKembali.Text;

            string struk = $"Kasir: {kasir}\n" +
                           $"Makanan: {makanan} x {nudMakanan.Value}\n" +
                           $"Minuman: {minuman} x {nudMinuman.Value}\n" +
                           $"Total: {total}\n" +
                           $"Bayar: {bayar}\n" +
                           $"Kembali: {kembali}";

            DialogResult result = MessageBox.Show(struk, "Struk Pembelian", MessageBoxButtons.OK);

            if (result == DialogResult.OK)
            {
                btnClear_Click(sender, e); // reset ke default
            }
        }




        private void btnClear_Click(object sender, EventArgs e)
        {
            cmbMakanan.SelectedIndex = -1;
            cmbMinuman.SelectedIndex = -1;
            txtMakanan.Text = "";
            txtMinuman.Text = "";
            txtTotal.Text = "";
            txtBayar.Text = "";
            txtKembali.Text = "";
            nudMakanan.Value = 0;
            nudMinuman.Value = 0;
            txtKasir.Text = "";
        }

        private void btnTutup_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void Total()
        {
            int qtyMakanan = (int)nudMakanan.Value;
            int qtyMinuman = (int)nudMinuman.Value;

            // hitung subtotal berdasarkan harga satuan x qty
            int subMakanan = hargaMakanan * qtyMakanan;
            int subMinuman = hargaMinuman * qtyMinuman;

            txtMakanan.Text = subMakanan.ToString();
            txtMinuman.Text = subMinuman.ToString();

            int total = subMakanan + subMinuman;
            txtTotal.Text = total.ToString();
        }



        private void btnSebelumnya_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.ShowDialog();   // modal → tunggu sampai ditutup
            this.Show();          // tampilkan lagi Form1 setelah login ditutup
        }


        private void cmbMakanan_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbMakanan.SelectedIndex)
            {
                case 0:
                    hargaMakanan = 25000;
                    break;
                case 1:
                    hargaMakanan = 21000;
                    break;
                case 2:
                    hargaMakanan = 20000;
                    break;
            }

            if (nudMakanan.Value == 0)
                nudMakanan.Value = 1;

            Total();
        }

        private void cmbMinuman_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbMinuman.SelectedIndex)
            {
                case 0:
                    hargaMinuman = 10000;
                    break;
                case 1:
                    hargaMinuman = 10000;
                    break;
                case 2:
                    hargaMinuman = 10000;
                    break;
            }

            if (nudMinuman.Value == 0)
                nudMinuman.Value = 1;

            Total();
        }




        private void txtBayar_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBayar.Text))
            {
                txtKembali.Text = "0";
                return;
            }

            int bayar, total;
            int.TryParse(txtBayar.Text, out bayar);
            int.TryParse(txtTotal.Text, out total);

            int kembali = bayar - total;
            txtKembali.Text = kembali.ToString();
        }

        private void nudMakanan_ValueChanged(object sender, EventArgs e)
        {
            Total();
        }

        private void nudMinuman_ValueChanged(object sender, EventArgs e)
        {
            Total();
        }


        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
