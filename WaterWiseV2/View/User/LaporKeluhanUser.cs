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
    public partial class LaporKeluhanUser : Form
    {
        private M_User _currentUser;
        private C_Laporan _laporanController;

        public LaporKeluhanUser(M_User user)
        {
            InitializeComponent();
            _currentUser = user;
            _laporanController = new C_Laporan(user);
        }

        private void btnKirimKeluhan_Click(object sender, EventArgs e)
        {
            string isiLaporan = textboxDeskripsi.Text.Trim();

            if (string.IsNullOrWhiteSpace(isiLaporan))
            {
                MessageBox.Show("Isi laporan tidak boleh kosong!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool berhasil = _laporanController.KirimLaporan(isiLaporan);

            if (berhasil)
            {
                textboxDeskripsi.Clear();
                textboxDeskripsi.Focus();
            }
        }

        private void buttonUtama_Click(object sender, EventArgs e)
        {
            NavigationHelper.GoToDashboardUser(_currentUser, this);
        }
        private void btnProfile_Click(object sender, EventArgs e)
        {
            NavigationHelper.GoToProfileUser(_currentUser, this);
        }
        private void btnAmbilAir_Click(object sender, EventArgs e)
        {
            NavigationHelper.GoToAmbilAirUser(_currentUser, this);
        }
        private void btnHistory_Click(object sender, EventArgs e)
        {
            NavigationHelper.GoToHistoryUser(_currentUser, this);
        }
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            NavigationHelper.Logout(this);
        }
    }
}
