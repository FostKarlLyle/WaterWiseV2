using System;
using System.Collections.Generic;
using System.Text;
using WaterWiseV2.Model;
using WaterWiseV2.Repositories;

namespace WaterWiseV2.Control.User
{
    internal class C_Laporan
    {
        private M_User _currentUser;
        private LaporanRepository _laporanRepo;

        public C_Laporan(M_User user)
        {
            _currentUser = user;
            _laporanRepo = new LaporanRepository();
        }

        public bool KirimLaporan(string isiLaporan)
        {
            if (string.IsNullOrWhiteSpace(isiLaporan))
            {
                MessageBox.Show("Isi laporan tidak boleh kosong!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            var laporan = new M_Laporan
            {
                Id_akun = _currentUser.Id_akun,
                Tanggal_laporan = DateTime.Now,
                Status_laporan = "diproses"
            };

            int idLaporan = _laporanRepo.Insert(laporan);

            if (idLaporan > 0)
            {
                var detail = new M_DetailLaporan
                {
                    Id_laporan = idLaporan,
                    Isi_laporan = isiLaporan
                };
                _laporanRepo.InsertDetail(detail);

                MessageBox.Show("Laporan berhasil dikirim! Admin akan segera memproses.",
                    "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }

            MessageBox.Show("Gagal mengirim laporan!", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
       
    }
}
