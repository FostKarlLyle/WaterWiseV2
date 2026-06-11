namespace WaterWiseV2
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            textboxUsername = new TextBox();
            textboxPassword = new TextBox();
            linkRegistrasi = new LinkLabel();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // textboxUsername
            // 
            textboxUsername.BackColor = Color.White;
            textboxUsername.BorderStyle = BorderStyle.None;
            textboxUsername.Location = new Point(547, 249);
            textboxUsername.Multiline = true;
            textboxUsername.Name = "textboxUsername";
            textboxUsername.Size = new Size(373, 23);
            textboxUsername.TabIndex = 0;
            textboxUsername.TextChanged += textboxUsername_TextChanged;
            // 
            // textboxPassword
            // 
            textboxPassword.BackColor = Color.White;
            textboxPassword.BorderStyle = BorderStyle.None;
            textboxPassword.Location = new Point(547, 340);
            textboxPassword.Multiline = true;
            textboxPassword.Name = "textboxPassword";
            textboxPassword.Size = new Size(373, 23);
            textboxPassword.TabIndex = 1;
            textboxPassword.UseSystemPasswordChar = true;
            // 
            // linkRegistrasi
            // 
            linkRegistrasi.AutoSize = true;
            linkRegistrasi.BackColor = Color.White;
            linkRegistrasi.Font = new Font("Segoe UI", 11F);
            linkRegistrasi.Location = new Point(785, 484);
            linkRegistrasi.Name = "linkRegistrasi";
            linkRegistrasi.Size = new Size(73, 20);
            linkRegistrasi.TabIndex = 2;
            linkRegistrasi.TabStop = true;
            linkRegistrasi.Text = "Registrasi";
            linkRegistrasi.LinkClicked += linkRegistrasi_LinkClicked;
            // 
            // btnLogin
            // 
            btnLogin.BackgroundImage = (Image)resources.GetObject("btnLogin.BackgroundImage");
            btnLogin.BackgroundImageLayout = ImageLayout.Stretch;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Location = new Point(603, 412);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(277, 40);
            btnLogin.TabIndex = 3;
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(984, 561);
            Controls.Add(btnLogin);
            Controls.Add(linkRegistrasi);
            Controls.Add(textboxPassword);
            Controls.Add(textboxUsername);
            Name = "Login";
            Text = " ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textboxUsername;
        private TextBox textboxPassword;
        private LinkLabel linkRegistrasi;
        private Button btnLogin;
    }
}
