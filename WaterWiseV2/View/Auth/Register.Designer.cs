namespace WaterWiseV2.View.Auth
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            btnDaftar = new Button();
            linkLogin = new LinkLabel();
            textboxNama = new TextBox();
            textboxUsername = new TextBox();
            textboxEmail = new TextBox();
            textboxPassword = new TextBox();
            textboxNoTelpon = new TextBox();
            textboxNoKK = new TextBox();
            textboxJumlahAnggota = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(textboxJumlahAnggota);
            panel1.Controls.Add(textboxNoKK);
            panel1.Controls.Add(textboxNoTelpon);
            panel1.Controls.Add(textboxPassword);
            panel1.Controls.Add(textboxEmail);
            panel1.Controls.Add(textboxUsername);
            panel1.Controls.Add(textboxNama);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(575, 171);
            panel1.Name = "panel1";
            panel1.Size = new Size(323, 247);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(320, 600);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // btnDaftar
            // 
            btnDaftar.BackgroundImage = (Image)resources.GetObject("btnDaftar.BackgroundImage");
            btnDaftar.BackgroundImageLayout = ImageLayout.Stretch;
            btnDaftar.FlatAppearance.BorderSize = 0;
            btnDaftar.FlatStyle = FlatStyle.Flat;
            btnDaftar.Location = new Point(589, 450);
            btnDaftar.Name = "btnDaftar";
            btnDaftar.Size = new Size(294, 35);
            btnDaftar.TabIndex = 1;
            btnDaftar.UseVisualStyleBackColor = true;
            btnDaftar.Click += btnDaftar_Click;
            // 
            // linkLogin
            // 
            linkLogin.AutoSize = true;
            linkLogin.BackColor = Color.White;
            linkLogin.Font = new Font("Segoe UI", 11F);
            linkLogin.Location = new Point(785, 518);
            linkLogin.Name = "linkLogin";
            linkLogin.Size = new Size(46, 20);
            linkLogin.TabIndex = 2;
            linkLogin.TabStop = true;
            linkLogin.Text = "Login";
            linkLogin.LinkClicked += linkLogin_LinkClicked;
            // 
            // textboxNama
            // 
            textboxNama.BorderStyle = BorderStyle.None;
            textboxNama.Location = new Point(3, 55);
            textboxNama.Multiline = true;
            textboxNama.Name = "textboxNama";
            textboxNama.Size = new Size(305, 28);
            textboxNama.TabIndex = 2;
            // 
            // textboxUsername
            // 
            textboxUsername.BorderStyle = BorderStyle.None;
            textboxUsername.Location = new Point(3, 138);
            textboxUsername.Multiline = true;
            textboxUsername.Name = "textboxUsername";
            textboxUsername.Size = new Size(305, 28);
            textboxUsername.TabIndex = 3;
            // 
            // textboxEmail
            // 
            textboxEmail.BorderStyle = BorderStyle.None;
            textboxEmail.Location = new Point(3, 219);
            textboxEmail.Multiline = true;
            textboxEmail.Name = "textboxEmail";
            textboxEmail.Size = new Size(305, 28);
            textboxEmail.TabIndex = 4;
            // 
            // textboxPassword
            // 
            textboxPassword.BorderStyle = BorderStyle.None;
            textboxPassword.Location = new Point(3, 301);
            textboxPassword.Multiline = true;
            textboxPassword.Name = "textboxPassword";
            textboxPassword.Size = new Size(305, 28);
            textboxPassword.TabIndex = 5;
            // 
            // textboxNoTelpon
            // 
            textboxNoTelpon.BorderStyle = BorderStyle.None;
            textboxNoTelpon.Location = new Point(3, 383);
            textboxNoTelpon.Multiline = true;
            textboxNoTelpon.Name = "textboxNoTelpon";
            textboxNoTelpon.Size = new Size(305, 28);
            textboxNoTelpon.TabIndex = 6;
            // 
            // textboxNoKK
            // 
            textboxNoKK.BorderStyle = BorderStyle.None;
            textboxNoKK.Location = new Point(3, 465);
            textboxNoKK.Multiline = true;
            textboxNoKK.Name = "textboxNoKK";
            textboxNoKK.Size = new Size(305, 28);
            textboxNoKK.TabIndex = 7;
            // 
            // textboxJumlahAnggota
            // 
            textboxJumlahAnggota.BorderStyle = BorderStyle.None;
            textboxJumlahAnggota.Location = new Point(3, 547);
            textboxJumlahAnggota.Multiline = true;
            textboxJumlahAnggota.Name = "textboxJumlahAnggota";
            textboxJumlahAnggota.Size = new Size(305, 28);
            textboxJumlahAnggota.TabIndex = 8;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(984, 561);
            Controls.Add(linkLogin);
            Controls.Add(btnDaftar);
            Controls.Add(panel1);
            Name = "Register";
            Text = "Register";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Button btnDaftar;
        private LinkLabel linkLogin;
        private TextBox textboxNama;
        private TextBox textboxJumlahAnggota;
        private TextBox textboxNoKK;
        private TextBox textboxNoTelpon;
        private TextBox textboxPassword;
        private TextBox textboxEmail;
        private TextBox textboxUsername;
    }
}