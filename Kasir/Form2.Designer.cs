namespace Kasir
{
    partial class Form2
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            checkShowPassword = new CheckBox();
            label4 = new Label();
            label5 = new Label();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(50, 76, 120);
            label1.Location = new Point(123, 8);
            label1.Name = "label1";
            label1.Size = new Size(91, 33);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(50, 76, 120);
            label2.Location = new Point(21, 46);
            label2.Name = "label2";
            label2.Size = new Size(105, 24);
            label2.TabIndex = 1;
            label2.Text = "Username";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(50, 76, 120);
            label3.Location = new Point(21, 117);
            label3.Name = "label3";
            label3.Size = new Size(103, 24);
            label3.TabIndex = 2;
            label3.Text = "Password";
            label3.Click += label3_Click;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.FromArgb(247, 242, 233);
            txtUsername.Location = new Point(30, 77);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(284, 28);
            txtUsername.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(247, 242, 233);
            txtPassword.Location = new Point(30, 143);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(284, 27);
            txtPassword.TabIndex = 4;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(67, 96, 143);
            btnLogin.Font = new Font("Arial Rounded MT Bold", 9F);
            btnLogin.ForeColor = Color.FromArgb(252, 243, 222);
            btnLogin.Location = new Point(96, 220);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(162, 37);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // checkShowPassword
            // 
            checkShowPassword.Location = new Point(30, 176);
            checkShowPassword.Name = "checkShowPassword";
            checkShowPassword.Size = new Size(205, 24);
            checkShowPassword.TabIndex = 0;
            checkShowPassword.Text = "Show Password";
            checkShowPassword.CheckedChanged += checkShowPassword_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(247, 242, 233);
            label4.Location = new Point(316, 73);
            label4.Name = "label4";
            label4.Size = new Size(268, 18);
            label4.TabIndex = 15;
            label4.Text = "Tempat hangat untuk cerita dan rasa.";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("MV Boli", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(247, 242, 233);
            label5.Location = new Point(349, 20);
            label5.Name = "label5";
            label5.Size = new Size(201, 58);
            label5.TabIndex = 14;
            label5.Text = "NekoFee";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(192, 210, 240);
            groupBox1.Controls.Add(checkShowPassword);
            groupBox1.Controls.Add(btnLogin);
            groupBox1.Controls.Add(txtPassword);
            groupBox1.Controls.Add(txtUsername);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(273, 123);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(347, 287);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(143, 165, 201);
            ClientSize = new Size(880, 436);
            Controls.Add(groupBox1);
            Controls.Add(label4);
            Controls.Add(label5);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLogin;
        private CheckBox checkShowPassword;
        private Label label4;
        private Label label5;
        private GroupBox groupBox1;
    }
}