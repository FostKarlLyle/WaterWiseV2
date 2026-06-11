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
    public partial class ProfileUser : Form
    {
        public ProfileUser()
        {
            InitializeComponent();
        }

        private M_User _currentUser;
        private C_UserProfil _userProfilController;
        private bool _isEditMode = false;

        // Data sementara untuk edit
        private string _tempNama;
        private string _tempEmail;
        private string _tempNoTelepon;

        public ProfileUser(M_User user)
        {
            InitializeComponent();
            _currentUser = user;
            _userProfilController = new C_UserProfil(user);
            LoadProfile();
            SetEditMode(false);
        }

        // Load data ke label-label
        private void LoadProfile()
        {
            // Header
            lblNamaHeader.Text = _currentUser.Nama;
            lblEmailHeader.Text = _currentUser.Email;

            // Detail
            lblNamaValue.Text = _currentUser.Nama;
            lblEmailValue.Text = _currentUser.Email;
            lblNoKKValue.Text = _currentUser.No_kk;
            lblUsernameValue.Text = _currentUser.Username;
            lblNoTeleponValue.Text = _currentUser.No_telepon;
            lblJumlahKeluargaValue.Text = _currentUser.Jumlah_anggota.ToString() + " orang";
        }

        // Set mode edit
        private void SetEditMode(bool isEdit)
        {
            _isEditMode = isEdit;

            if (isEdit)
            {
                // Ganti label jadi textbox untuk edit
                SwitchLabelToTextBox();
                btnEdit.Visible = false;
                btnSimpan.Visible = true;
            }
            else
            {
                // Ganti textbox jadi label
                SwitchTextBoxToLabel();
                btnEdit.Visible = true;
                btnSimpan.Visible = false;
            }
        }

        // Ganti label jadi textbox (mode edit)
        private void SwitchLabelToTextBox()
        {
            // Simpan nilai lama
            _tempNama = lblNamaValue.Text;
            _tempEmail = lblEmailValue.Text;
            _tempNoTelepon = lblNoTeleponValue.Text;

            // Sembunyikan label
            lblNamaValue.Visible = false;
            lblEmailValue.Visible = false;
            lblNoTeleponValue.Visible = false;

            // Tampilkan textbox
            txtEditNama.Visible = true;
            txtEditEmail.Visible = true;
            txtEditNoTelepon.Visible = true;

            // Isi textbox dengan nilai saat ini
            txtEditNama.Text = _tempNama;
            txtEditEmail.Text = _tempEmail;
            txtEditNoTelepon.Text = _tempNoTelepon;
        }

        // Ganti textbox jadi label (mode read only)
        private void SwitchTextBoxToLabel()
        {
            // Sembunyikan textbox
            txtEditNama.Visible = false;
            txtEditEmail.Visible = false;
            txtEditNoTelepon.Visible = false;

            // Tampilkan label
            lblNamaValue.Visible = true;
            lblEmailValue.Visible = true;
            lblNoTeleponValue.Visible = true;
        }

        // Tombol EDIT
        private void btnEdit_Click(object sender, EventArgs e)
        {
            SetEditMode(true);
        }

        // Tombol SIMPAN
        private void btnSimpan_Click(object sender, EventArgs e)
        {
            // Validasi
            if (string.IsNullOrWhiteSpace(txtEditNama.Text))
            {
                MessageBox.Show("Nama tidak boleh kosong!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtEditEmail.Text) ||
                !txtEditEmail.Text.Contains("@") ||
                !txtEditEmail.Text.Contains("."))
            {
                MessageBox.Show("Email tidak valid!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtEditNoTelepon.Text))
            {
                MessageBox.Show("No telepon tidak boleh kosong!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Update ke database
            bool berhasil = _userProfilController.UpdateProfil(
                txtEditNama.Text.Trim(),
                txtEditNoTelepon.Text.Trim(),
                txtEditEmail.Text.Trim()
            );

            if (berhasil)
            {
                // Refresh data
                _currentUser = _userProfilController.GetUserData();
                LoadProfile();
                SetEditMode(false);
            }
        }

        // Tombol Kembali ke Dashboard
        private void btnKembali_Click(object sender, EventArgs e)
        {
            DashboardUser dashboardForm = new DashboardUser(_currentUser);
            dashboardForm.Show();
            this.Close();
        }

        private void buttonUtama_Click(object sender, EventArgs e)
        {

        }

        private void btnProfile_Click(object sender, EventArgs e)
        {

        }

        private void btnAmbilAir_Click(object sender, EventArgs e)
        {

        }

        private void btnHistory_Click(object sender, EventArgs e)
        {

        }

        private void btnLapor_Click(object sender, EventArgs e)
        {

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {

        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {

        }
    }
}
