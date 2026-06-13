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
    public partial class ProfileUser : Form
    {
        private M_User _currentUser;
        private C_EditProfile _userProfilController;
        private bool _isEditMode = false;

        public ProfileUser(M_User user)
        {
            InitializeComponent();
            _currentUser = user;
            _userProfilController = new C_EditProfile(user);
            LoadProfile();
            SetPermanentReadOnlyFields();
            SetEditMode(false);
        }

        // Load data user ke TextBox
        private void LoadProfile()
        {
            textboxNama.Text = _currentUser.Nama;
            textboxEmail.Text = _currentUser.Email;
            textboxNoKK.Text = _currentUser.No_kk;
            textboxUsername.Text = _currentUser.Username;
            textboxNoTelp.Text = _currentUser.No_telepon;
            textboxJumlahKeluarga.Text = _currentUser.Jumlah_anggota.ToString() + " orang";
        }

        // Field yang SELALU ReadOnly (permanen, tidak bisa diedit)
        private void SetPermanentReadOnlyFields()
        {
            textboxNoKK.ReadOnly = true;
            textboxUsername.ReadOnly = true;
            textboxJumlahKeluarga.ReadOnly = true;

            // Styling untuk ReadOnly permanen
            textboxNoKK.BackColor = System.Drawing.SystemColors.ControlLight;
            textboxUsername.BackColor = System.Drawing.SystemColors.ControlLight;
            textboxJumlahKeluarga.BackColor = System.Drawing.SystemColors.ControlLight;
        }

        // Set mode edit (true = bisa edit, false = read only)
        private void SetEditMode(bool isEdit)
        {
            _isEditMode = isEdit;

            // Field yang BISA diedit saat mode edit
            textboxNama.ReadOnly = !isEdit;
            textboxEmail.ReadOnly = !isEdit;
            textboxNoTelp.ReadOnly = !isEdit;

            // Ubah warna background saat edit mode
            if (isEdit)
            {
                textboxNama.BackColor = System.Drawing.Color.White;
                textboxEmail.BackColor = System.Drawing.Color.White;
                textboxNoTelp.BackColor = System.Drawing.Color.White;
            }
            else
            {
                textboxNama.BackColor = System.Drawing.SystemColors.ControlLight;
                textboxEmail.BackColor = System.Drawing.SystemColors.ControlLight;
                textboxNoTelp.BackColor = System.Drawing.SystemColors.ControlLight;
            }

            // Atur visibilitas tombol
            buttonEdit.Visible = !isEdit;   // Edit muncul saat read only
            btnSimpan.Visible = isEdit;  // Simpan muncul saat edit mode
        }

        // Tombol EDIT
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            SetEditMode(true);
            textboxNama.Focus();
        }

        // Tombol SIMPAN
        private void btnSimpan_Click(object sender, EventArgs e)
        {
            // Validasi input
            if (string.IsNullOrWhiteSpace(textboxNama.Text))
            {
                MessageBox.Show("Nama tidak boleh kosong!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(textboxNoTelp.Text))
            {
                MessageBox.Show("No telepon tidak boleh kosong!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(textboxEmail.Text))
            {
                MessageBox.Show("Email tidak boleh kosong!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!textboxEmail.Text.Contains("@") || !textboxEmail.Text.Contains("."))
            {
                MessageBox.Show("Email tidak valid!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Update profil ke database
            bool berhasil = _userProfilController.UpdateProfil(
                textboxNama.Text.Trim(),
                textboxNoTelp.Text.Trim(),
                textboxEmail.Text.Trim()
            );

            if (berhasil)
            {
                // Refresh data current user
                _currentUser = _userProfilController.GetUserData();
                LoadProfile();
                SetEditMode(false);
            }
        }

        // Tombol Dashboard User
        private void buttonUtama_Click(object sender, EventArgs e)
        {
            NavigationHelper.GoToDashboardUser(_currentUser, this);
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {

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

        // Tombol Lapor Keluhan
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
