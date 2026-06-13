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
    public partial class DashboardUser : Form
    {
        private M_User _currentUser;
        private C_DashboardUser _userDashboard;

        // Constructor dengan parameter (dipanggil dari login)
        public DashboardUser(M_User user)
        {
            InitializeComponent();
            _currentUser = user;
            _userDashboard = new C_DashboardUser(user);
            LoadDashboard();
        }

        private void LoadDashboard()
        {
            labelPenggunaanHariIni.Text = _userDashboard.GetPemakaianHariIni().ToString() + " L";
            labelSisaLimit.Text = _userDashboard.GetSisaLimitHariIni().ToString() + " L";
            labelStatus.Text = _userDashboard.GetStatusAkun();
        }

        // tombol Utama (refresh halaman)
        private void buttonUtama_Click(object sender, EventArgs e)
        {
            LoadDashboard();  // Refresh saja, tidak perlu buka form baru
        }

        // Tombol Ambil Air
        private void btnAmbilAir_Click(object sender, EventArgs e)
        {
            NavigationHelper.GoToAmbilAirUser(_currentUser, this);
        }

        // Tombol Profile
        private void btnProfile_Click(object sender, EventArgs e)
        {
            NavigationHelper.GoToProfileUser(_currentUser, this);
        }

        // Tombol History
        private void btnHistory_Click(object sender, EventArgs e)
        {
            NavigationHelper.GoToHistoryUser(_currentUser, this);
        }

        // Tombol Lapor Keluhan
        private void btnLapor_Click(object sender, EventArgs e)
        {
            NavigationHelper.GoToLaporKeluhanUser(_currentUser, this);
        }

        // Tombol LogOut
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            NavigationHelper.Logout(this);
        }
    }
}
