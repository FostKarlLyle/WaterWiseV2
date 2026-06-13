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
    public partial class AmbilAirUser : Form
    {
        private M_User _currentUser;
        private C_AmbilAir _ambilAirController;

        // Constructor
        public AmbilAirUser(M_User user)
        {
            InitializeComponent();
            _currentUser = user;
            _ambilAirController = new C_AmbilAir(user);
            LoadSisaLimit();
            ClearKode();
            SetupNumericUpDown();
        }

        // Setup NumericUpDown
        private void SetupNumericUpDown()
        {
            numericJumlahLiter.Minimum = 1;      // Minimal 1 liter
            numericJumlahLiter.Maximum = 100;   // Maksimal 100 liter
            numericJumlahLiter.Value = 1;        // Default value
            numericJumlahLiter.Increment = 1;    // Naik/turun 1 liter
        }

        // Load sisa limit dari database
        private void LoadSisaLimit()
        {
            int sisaLimit = _ambilAirController.GetSisaLimit();
            lblSisaLimit.Text = sisaLimit.ToString() + " L";

            // Set maksimum NumericUpDown sesuai sisa limit
            if (sisaLimit > 0)
            {
                numericJumlahLiter.Maximum = sisaLimit;
            }
            else
            {
                numericJumlahLiter.Maximum = 0;
                numericJumlahLiter.Enabled = false;
                btnAmbil.Enabled = false;
                MessageBox.Show("Limit air hari ini habis!", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Kosongkan label kode
        private void ClearKode()
        {
            lblKode.Text = "";
        }

        // Tampilkan kode yang digenerate
        private void TampilkanKode(string kode)
        {
            lblKode.Text = kode;
        }

        // Tombol Ambil Air
        private void btnAmbil_Click(object sender, EventArgs e)
        {
            // Ambil nilai dari NumericUpDown
            int jumlahAir = (int)numericJumlahLiter.Value;

            // Proses ambil air
            bool berhasil = _ambilAirController.AmbilAir(jumlahAir);

            if (berhasil)
            {
                // Refresh sisa limit
                LoadSisaLimit();

                // Tampilkan kode yang di-generate
                string kodeTerakhir = _ambilAirController.GetKodeTerakhir();
                TampilkanKode(kodeTerakhir);

                // Reset NumericUpDown ke 1
                numericJumlahLiter.Value = 1;
                numericJumlahLiter.Focus();
            }
        }

        public AmbilAirUser()
        {
            InitializeComponent();
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

        private void btnLapor_Click(object sender, EventArgs e)
        {
            NavigationHelper.GoToLaporKeluhanUser(_currentUser, this);
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            NavigationHelper.Logout(this);
        }
    }
}
