namespace WaterWiseV2.View.User
{
    partial class LaporKeluhanUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LaporKeluhanUser));
            textboxDeskripsi = new TextBox();
            btnKirimKeluhan = new Button();
            btnLapor = new Button();
            btnHistory = new Button();
            btnAmbilAir = new Button();
            btnProfile = new Button();
            buttonUtama = new Button();
            btnLogOut = new Button();
            SuspendLayout();
            // 
            // textboxDeskripsi
            // 
            textboxDeskripsi.BorderStyle = BorderStyle.None;
            textboxDeskripsi.Location = new Point(320, 147);
            textboxDeskripsi.Multiline = true;
            textboxDeskripsi.Name = "textboxDeskripsi";
            textboxDeskripsi.Size = new Size(616, 200);
            textboxDeskripsi.TabIndex = 0;
            // 
            // btnKirimKeluhan
            // 
            btnKirimKeluhan.BackgroundImage = (Image)resources.GetObject("btnKirimKeluhan.BackgroundImage");
            btnKirimKeluhan.FlatAppearance.BorderSize = 0;
            btnKirimKeluhan.FlatStyle = FlatStyle.Flat;
            btnKirimKeluhan.Location = new Point(320, 439);
            btnKirimKeluhan.Name = "btnKirimKeluhan";
            btnKirimKeluhan.Size = new Size(616, 46);
            btnKirimKeluhan.TabIndex = 1;
            btnKirimKeluhan.UseVisualStyleBackColor = true;
            btnKirimKeluhan.Click += btnKirimKeluhan_Click;
            // 
            // btnLapor
            // 
            btnLapor.BackgroundImage = (Image)resources.GetObject("btnLapor.BackgroundImage");
            btnLapor.FlatAppearance.BorderSize = 0;
            btnLapor.FlatStyle = FlatStyle.Flat;
            btnLapor.Location = new Point(12, 279);
            btnLapor.Name = "btnLapor";
            btnLapor.Size = new Size(158, 41);
            btnLapor.TabIndex = 14;
            btnLapor.UseVisualStyleBackColor = true;
            // 
            // btnHistory
            // 
            btnHistory.BackgroundImage = (Image)resources.GetObject("btnHistory.BackgroundImage");
            btnHistory.FlatAppearance.BorderSize = 0;
            btnHistory.FlatStyle = FlatStyle.Flat;
            btnHistory.Location = new Point(12, 232);
            btnHistory.Name = "btnHistory";
            btnHistory.Size = new Size(158, 41);
            btnHistory.TabIndex = 13;
            btnHistory.UseVisualStyleBackColor = true;
            btnHistory.Click += btnHistory_Click;
            // 
            // btnAmbilAir
            // 
            btnAmbilAir.BackgroundImage = (Image)resources.GetObject("btnAmbilAir.BackgroundImage");
            btnAmbilAir.FlatAppearance.BorderSize = 0;
            btnAmbilAir.FlatStyle = FlatStyle.Flat;
            btnAmbilAir.Location = new Point(12, 185);
            btnAmbilAir.Name = "btnAmbilAir";
            btnAmbilAir.Size = new Size(158, 41);
            btnAmbilAir.TabIndex = 12;
            btnAmbilAir.UseVisualStyleBackColor = true;
            btnAmbilAir.Click += btnAmbilAir_Click;
            // 
            // btnProfile
            // 
            btnProfile.BackgroundImage = (Image)resources.GetObject("btnProfile.BackgroundImage");
            btnProfile.FlatAppearance.BorderSize = 0;
            btnProfile.FlatStyle = FlatStyle.Flat;
            btnProfile.Location = new Point(12, 138);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(158, 41);
            btnProfile.TabIndex = 11;
            btnProfile.UseVisualStyleBackColor = true;
            btnProfile.Click += btnProfile_Click;
            // 
            // buttonUtama
            // 
            buttonUtama.BackgroundImage = (Image)resources.GetObject("buttonUtama.BackgroundImage");
            buttonUtama.FlatAppearance.BorderSize = 0;
            buttonUtama.FlatStyle = FlatStyle.Flat;
            buttonUtama.Location = new Point(12, 91);
            buttonUtama.Name = "buttonUtama";
            buttonUtama.Size = new Size(158, 41);
            buttonUtama.TabIndex = 10;
            buttonUtama.UseVisualStyleBackColor = true;
            buttonUtama.Click += buttonUtama_Click;
            // 
            // btnLogOut
            // 
            btnLogOut.BackgroundImage = (Image)resources.GetObject("btnLogOut.BackgroundImage");
            btnLogOut.FlatAppearance.BorderSize = 0;
            btnLogOut.FlatStyle = FlatStyle.Flat;
            btnLogOut.Location = new Point(41, 507);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(162, 44);
            btnLogOut.TabIndex = 9;
            btnLogOut.UseVisualStyleBackColor = true;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // LaporKeluhanUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(984, 561);
            Controls.Add(btnLapor);
            Controls.Add(btnHistory);
            Controls.Add(btnAmbilAir);
            Controls.Add(btnProfile);
            Controls.Add(buttonUtama);
            Controls.Add(btnLogOut);
            Controls.Add(btnKirimKeluhan);
            Controls.Add(textboxDeskripsi);
            Name = "LaporKeluhanUser";
            Text = " ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textboxDeskripsi;
        private Button btnKirimKeluhan;
        private Button btnLapor;
        private Button btnHistory;
        private Button btnAmbilAir;
        private Button btnProfile;
        private Button buttonUtama;
        private Button btnLogOut;
    }
}