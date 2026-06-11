using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WaterWiseV2.Model;

namespace WaterWiseV2.View.User
{
    public partial class DashboardUser : Form
    {
        private M_User _currentUser;
        private C_UserDashboard _userDashboard;

        // Constructor dengan parameter (dipanggil dari login)
        public DashboardUser(M_User user)
        {
            InitializeComponent();
            _currentUser = user;
            _userDashboard = new C_UserDashboard(user);
            LoadDashboard();
        }

        // Constructor kosong (opsional, kalau dibutuhkan)
        public DashboardUser()
        {
            InitializeComponent();
        }

        // Method LoadDashboard (CUKUP SATU)
        private void LoadDashboard()
        {
            // Pastikan nama label sesuai dengan di Designer kamu
            labelPenggunaanHariIni.Text = _userDashboard.GetPemakaianHariIni().ToString() + " L";
            labelSisaLimit.Text = _userDashboard.GetSisaLimitHariIni().ToString() + " L";
            labelStatus.Text = _userDashboard.GetStatusAkun();
        }

        // Tombol Utama (refresh halaman)
        private void buttonUtama_Click(object sender, EventArgs e)
        {
            LoadDashboard();  // Refresh saja, tidak perlu buka form baru
        }

        // Tombol Ambil Air
        private void btnAmbilAir_Click(object sender, EventArgs e)
        {
            AmbilAirUser ambilAirForm = new AmbilAirUser(_currentUser);
            ambilAirForm.ShowDialog();
            LoadDashboard();  // Refresh setelah ambil air
        }

        // Tombol Profile
        private void btnProfile_Click(object sender, EventArgs e)
        {
            ProfileUser profileForm = new ProfileUser(_currentUser);
            profileForm.ShowDialog();
            LoadDashboard();  // Refresh setelah update profil
        }

        // Tombol History
        private void btnHistory_Click(object sender, EventArgs e)
        {
            HistoryUser historyForm = new HistoryUser(_currentUser);
            historyForm.ShowDialog();
        }

        // Tombol Lapor Keluhan
        private void btnLapor_Click(object sender, EventArgs e)
        {
            LaporKeluhanUser laporForm = new LaporKeluhanUser(_currentUser);
            laporForm.ShowDialog();
        }

        // Tombol LogOut
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah Anda yakin ingin logout?", "Konfirmasi",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Login loginForm = new Login();
                loginForm.Show();
                this.Close();
            }
        }
    }
}
