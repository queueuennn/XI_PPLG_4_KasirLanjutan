using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kasir
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            btnLogin.Click += btnLogin_Click; // pastikan nama btnLogin benar
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUsername.Text.Trim();
            string pass = txtPassword.Text.Trim();

            // contoh login sederhana
            if (user == "admin" && pass == "123")
            {
                // cara yang bersih: tampilkan Form1 sebagai modal lalu tutup Form2
                this.Hide();
                using (Form1 form1 = new Form1())
                {
                    form1.ShowDialog();
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Username atau Password salah!", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void checkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkShowPassword.Checked)
            {
                txtPassword.UseSystemPasswordChar = false; // tampilkan password
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true; // sembunyikan password
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
