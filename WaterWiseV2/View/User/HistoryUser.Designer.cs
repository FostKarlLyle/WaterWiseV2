namespace WaterWiseV2.View.User
{
    partial class HistoryUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistoryUser));
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            btnLapor = new Button();
            btnHistory = new Button();
            btnAmbilAir = new Button();
            btnProfile = new Button();
            buttonUtama = new Button();
            btnLogOut = new Button();
            dgvHistory = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvHistory).BeginInit();
            SuspendLayout();
            // 
            // btnLapor
            // 
            btnLapor.BackgroundImage = (Image)resources.GetObject("btnLapor.BackgroundImage");
            btnLapor.FlatAppearance.BorderSize = 0;
            btnLapor.FlatStyle = FlatStyle.Flat;
            btnLapor.Location = new Point(12, 277);
            btnLapor.Name = "btnLapor";
            btnLapor.Size = new Size(158, 41);
            btnLapor.TabIndex = 14;
            btnLapor.UseVisualStyleBackColor = true;
            btnLapor.Click += btnLapor_Click;
            // 
            // btnHistory
            // 
            btnHistory.BackgroundImage = (Image)resources.GetObject("btnHistory.BackgroundImage");
            btnHistory.FlatAppearance.BorderSize = 0;
            btnHistory.FlatStyle = FlatStyle.Flat;
            btnHistory.Location = new Point(12, 230);
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
            btnAmbilAir.Location = new Point(12, 183);
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
            btnProfile.Location = new Point(12, 136);
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
            buttonUtama.Location = new Point(12, 89);
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
            btnLogOut.Location = new Point(41, 505);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(162, 44);
            btnLogOut.TabIndex = 9;
            btnLogOut.UseVisualStyleBackColor = true;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // dgvHistory
            // 
            dgvHistory.AllowUserToAddRows = false;
            dgvHistory.AllowUserToDeleteRows = false;
            dgvHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHistory.BackgroundColor = Color.White;
            dgvHistory.BorderStyle = BorderStyle.None;
            dgvHistory.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Blue;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvHistory.ColumnHeadersHeight = 40;
            dgvHistory.EnableHeadersVisualStyles = false;
            dgvHistory.GridColor = Color.LightGray;
            dgvHistory.Location = new Point(309, 89);
            dgvHistory.Name = "dgvHistory";
            dgvHistory.ReadOnly = true;
            dgvHistory.RowHeadersVisible = false;
            dgvHistory.RowTemplate.Height = 40;
            dgvHistory.Size = new Size(620, 402);
            dgvHistory.TabIndex = 15;
            // 
            // HistoryUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(984, 561);
            Controls.Add(dgvHistory);
            Controls.Add(btnLapor);
            Controls.Add(btnHistory);
            Controls.Add(btnAmbilAir);
            Controls.Add(btnProfile);
            Controls.Add(buttonUtama);
            Controls.Add(btnLogOut);
            Name = "HistoryUser";
            Text = "AmbilAir";
            ((System.ComponentModel.ISupportInitialize)dgvHistory).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnLapor;
        private Button btnHistory;
        private Button btnAmbilAir;
        private Button btnProfile;
        private Button buttonUtama;
        private Button btnLogOut;
        private DataGridView dgvHistory;
    }
}