namespace WaterWiseV2.View.User
{
    partial class DashboardUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardUser));
            labelPenggunaanHariIni = new Label();
            labelSisaLimit = new Label();
            labelStatus = new Label();
            btnLogOut = new Button();
            buttonUtama = new Button();
            btnProfile = new Button();
            btnAmbilAir = new Button();
            btnHistory = new Button();
            btnLapor = new Button();
            SuspendLayout();
            // 
            // labelPenggunaanHariIni
            // 
            labelPenggunaanHariIni.AutoSize = true;
            labelPenggunaanHariIni.BackColor = Color.White;
            labelPenggunaanHariIni.Font = new Font("Rockwell", 15F);
            labelPenggunaanHariIni.Location = new Point(306, 213);
            labelPenggunaanHariIni.Name = "labelPenggunaanHariIni";
            labelPenggunaanHariIni.Size = new Size(63, 22);
            labelPenggunaanHariIni.TabIndex = 0;
            labelPenggunaanHariIni.Text = "Value";
            // 
            // labelSisaLimit
            // 
            labelSisaLimit.AutoSize = true;
            labelSisaLimit.BackColor = Color.White;
            labelSisaLimit.Font = new Font("Rockwell", 15F);
            labelSisaLimit.Location = new Point(535, 213);
            labelSisaLimit.Name = "labelSisaLimit";
            labelSisaLimit.Size = new Size(63, 22);
            labelSisaLimit.TabIndex = 1;
            labelSisaLimit.Text = "Value";
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.BackColor = Color.White;
            labelStatus.Font = new Font("Rockwell", 15F);
            labelStatus.Location = new Point(768, 213);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(63, 22);
            labelStatus.TabIndex = 2;
            labelStatus.Text = "Value";
            // 
            // btnLogOut
            // 
            btnLogOut.BackgroundImage = (Image)resources.GetObject("btnLogOut.BackgroundImage");
            btnLogOut.FlatAppearance.BorderSize = 0;
            btnLogOut.FlatStyle = FlatStyle.Flat;
            btnLogOut.Location = new Point(41, 505);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(162, 44);
            btnLogOut.TabIndex = 3;
            btnLogOut.UseVisualStyleBackColor = true;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // buttonUtama
            // 
            buttonUtama.BackgroundImage = (Image)resources.GetObject("buttonUtama.BackgroundImage");
            buttonUtama.FlatAppearance.BorderSize = 0;
            buttonUtama.FlatStyle = FlatStyle.Flat;
            buttonUtama.Location = new Point(12, 89);
            buttonUtama.Name = "buttonUtama";
            buttonUtama.Size = new Size(158, 41);
            buttonUtama.TabIndex = 4;
            buttonUtama.UseVisualStyleBackColor = true;
            buttonUtama.Click += buttonUtama_Click;
            // 
            // btnProfile
            // 
            btnProfile.BackgroundImage = (Image)resources.GetObject("btnProfile.BackgroundImage");
            btnProfile.FlatAppearance.BorderSize = 0;
            btnProfile.FlatStyle = FlatStyle.Flat;
            btnProfile.Location = new Point(12, 136);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(158, 41);
            btnProfile.TabIndex = 5;
            btnProfile.UseVisualStyleBackColor = true;
            btnProfile.Click += btnProfile_Click;
            // 
            // btnAmbilAir
            // 
            btnAmbilAir.BackgroundImage = (Image)resources.GetObject("btnAmbilAir.BackgroundImage");
            btnAmbilAir.FlatAppearance.BorderSize = 0;
            btnAmbilAir.FlatStyle = FlatStyle.Flat;
            btnAmbilAir.Location = new Point(12, 183);
            btnAmbilAir.Name = "btnAmbilAir";
            btnAmbilAir.Size = new Size(158, 41);
            btnAmbilAir.TabIndex = 6;
            btnAmbilAir.UseVisualStyleBackColor = true;
            btnAmbilAir.Click += btnAmbilAir_Click;
            // 
            // btnHistory
            // 
            btnHistory.BackgroundImage = (Image)resources.GetObject("btnHistory.BackgroundImage");
            btnHistory.FlatAppearance.BorderSize = 0;
            btnHistory.FlatStyle = FlatStyle.Flat;
            btnHistory.Location = new Point(12, 230);
            btnHistory.Name = "btnHistory";
            btnHistory.Size = new Size(158, 41);
            btnHistory.TabIndex = 7;
            btnHistory.UseVisualStyleBackColor = true;
            btnHistory.Click += btnHistory_Click;
            // 
            // btnLapor
            // 
            btnLapor.BackgroundImage = (Image)resources.GetObject("btnLapor.BackgroundImage");
            btnLapor.FlatAppearance.BorderSize = 0;
            btnLapor.FlatStyle = FlatStyle.Flat;
            btnLapor.Location = new Point(12, 277);
            btnLapor.Name = "btnLapor";
            btnLapor.Size = new Size(158, 41);
            btnLapor.TabIndex = 8;
            btnLapor.UseVisualStyleBackColor = true;
            btnLapor.Click += btnLapor_Click;
            // 
            // DashboardUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(984, 561);
            Controls.Add(btnLapor);
            Controls.Add(btnHistory);
            Controls.Add(btnAmbilAir);
            Controls.Add(btnProfile);
            Controls.Add(buttonUtama);
            Controls.Add(btnLogOut);
            Controls.Add(labelStatus);
            Controls.Add(labelSisaLimit);
            Controls.Add(labelPenggunaanHariIni);
            Name = "DashboardUser";
            Text = "DashboardUser";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelPenggunaanHariIni;
        private Label labelSisaLimit;
        private Label labelStatus;
        private Button btnLogOut;
        private Button buttonUtama;
        private Button btnProfile;
        private Button btnAmbilAir;
        private Button btnHistory;
        private Button btnLapor;
    }
}