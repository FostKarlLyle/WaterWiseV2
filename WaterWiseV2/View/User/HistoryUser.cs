using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WaterWiseV2.Control.User;
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
            var riwayat = _historyController.GetRiwayat();
            dgvHistory.DataSource = riwayat;

            // Atur header kolom
            if (dgvHistory.Columns.Count > 0)
            {
                dgvHistory.Columns["Id_penggunaan"].HeaderText = "ID";
                dgvHistory.Columns["Id_user"].Visible = false;
                dgvHistory.Columns["Tanggal_penggunaan"].HeaderText = "Tanggal";
                dgvHistory.Columns["Jumlah_air"].HeaderText = "Jumlah (L)";
                dgvHistory.Columns["Kode_ambil"].HeaderText = "Kode Ambil";
                dgvHistory.Columns["User"].Visible = false;

                // Atur lebar
                dgvHistory.Columns["Tanggal_penggunaan"].Width = 150;
                dgvHistory.Columns["Jumlah_air"].Width = 100;
                dgvHistory.Columns["Kode_ambil"].Width = 200;
            }

            dgvHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
    }
}
