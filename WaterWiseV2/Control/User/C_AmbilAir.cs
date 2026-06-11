using System;
using System.Collections.Generic;
using System.Text;
using WaterWiseV2.Model;
using WaterWiseV2.Repositories;

namespace WaterWiseV2.Control.User
{
    internal class C_AmbilAir
    {
        private M_User _currentUser;
        private PenggunaanAirRepository _penggunaanRepo;
        private string _kodeTerakhir;

        public C_AmbilAir(M_User user)
        {
            _currentUser = user;
            _penggunaanRepo = new PenggunaanAirRepository();
            _kodeTerakhir = "";
        }

        public int GetSisaLimit()
        {
            decimal pemakaian = _penggunaanRepo.GetTotalPemakaianHariIni(_currentUser.Id_user);
            return _currentUser.Limit_air - (int)pemakaian;
        }

        public string GetKodeTerakhir()
        {
            return _kodeTerakhir;
        }

        public bool AmbilAir(int jumlahAir)
        {
            int sisaLimit = GetSisaLimit();

            if (sisaLimit < jumlahAir)
            {
                MessageBox.Show($"Sisa limit Anda hanya {sisaLimit} liter. Tidak bisa mengambil {jumlahAir} liter!",
                    "Limit Habis", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (jumlahAir <= 0)
            {
                MessageBox.Show("Jumlah air harus lebih dari 0 liter!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            string kodeAmbil = GenerateUniqueKode();

            var penggunaan = new M_PenggunaanAir
            {
                Id_user = _currentUser.Id_user,
                Jumlah_air = jumlahAir,
                Kode_ambil = kodeAmbil,
                Tanggal_penggunaan = DateTime.Now
            };

            bool result = _penggunaanRepo.Insert(penggunaan);

            if (result)
            {
                _kodeTerakhir = kodeAmbil;
                MessageBox.Show($"Berhasil mengambil {jumlahAir} liter air!",
                    "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }

            MessageBox.Show("Gagal menyimpan data pengambilan air!", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        private string GenerateUniqueKode()
        {
            string kode;
            bool isUnique = false;

            do
            {
                kode = $"WTR-{DateTime.Now:yyyyMMddHHmmss}-{new Random().Next(1000, 9999)}";
                isUnique = _penggunaanRepo.IsKodeUnique(kode);

                if (!isUnique)
                {
                    System.Threading.Thread.Sleep(1);
                }
            }
            while (!isUnique);

            return kode;
        }
    }
}
