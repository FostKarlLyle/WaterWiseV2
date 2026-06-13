using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WaterWiseV2.Control.User;
using WaterWiseV2.Helper;
using WaterWiseV2.Model;

namespace WaterWiseV2.View.User
{
    public partial class HistoryUser : Form
    {
        private M_User _currentUser;
        private C_History _historyController;

        public HistoryUser(M_User user)
        {
            InitializeComponent();
            _currentUser = user;
            _historyController = new C_History(user);
            LoadHistory();
        }

        private void LoadHistory()
        {
            try
            {
                // Ambil data dari controller
                var riwayat = _historyController.GetRiwayat();

                // Kasih data ke DataGridView
                dgvHistory.DataSource = riwayat;

                // Biarkan DataGridView mengatur sendiri lebarnya
                dgvHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                // (OPSIONAL) Kalau mau ganti header text, lakukan dengan aman
                if (dgvHistory.Columns.Contains("Tanggal_penggunaan"))
                    dgvHistory.Columns["Tanggal_penggunaan"].HeaderText = "Tanggal";

                if (dgvHistory.Columns.Contains("Jumlah_air"))
                    dgvHistory.Columns["Jumlah_air"].HeaderText = "Jumlah (L)";

                if (dgvHistory.Columns.Contains("Kode_ambil"))
                    dgvHistory.Columns["Kode_ambil"].HeaderText = "Kode Ambil";

                // Sembunyikan kolom yang tidak perlu dilihat user
                if (dgvHistory.Columns.Contains("Id_penggunaan"))
                    dgvHistory.Columns["Id_penggunaan"].Visible = false;

                if (dgvHistory.Columns.Contains("Id_user"))
                    dgvHistory.Columns["Id_user"].Visible = false;

                if (dgvHistory.Columns.Contains("User"))
                    dgvHistory.Columns["User"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal memuat riwayat: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Tombol Dashboard User
        private void buttonUtama_Click(object sender, EventArgs e)
        {
            NavigationHelper.GoToDashboardUser(_currentUser, this);
        }

        // Tombol Profile
        private void btnProfile_Click(object sender, EventArgs e)
        {
            NavigationHelper.GoToProfileUser(_currentUser, this);
        }

        // Tombol Ambil Air
        private void btnAmbilAir_Click(object sender, EventArgs e)
        {
            NavigationHelper.GoToAmbilAirUser(_currentUser, this);
        }

        // Tombol History
        private void btnHistory_Click(object sender, EventArgs e)
        {
            NavigationHelper.GoToHistoryUser(_currentUser, this);
        }

        //Tombol Laporan Keluhan
        private void btnLapor_Click(object sender, EventArgs e)
        {
            NavigationHelper.GoToLaporKeluhanUser(_currentUser, this);
        }

        // Tombol Log Out
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            NavigationHelper.Logout(this);
        }
    }
}
