using System;
using System.Collections.Generic;
using System.Text;
using WaterWiseV2.Model;
using WaterWiseV2.Repositories;

namespace WaterWiseV2.Control.Auth
{
    internal class C_Registrasi
    {
        private UserRepository _userRepo;

        public C_Registrasi()
        {
            _userRepo = new UserRepository();
        }

        public bool Register(M_User user, string password)
        {
            if (string.IsNullOrEmpty(password) || password.Length < 8)
            {
                MessageBox.Show("Password minimal 8 karakter!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrEmpty(user.Username) || string.IsNullOrEmpty(user.Nama) ||
                string.IsNullOrEmpty(user.No_kk) || user.Jumlah_anggota <= 0)
            {
                MessageBox.Show("Semua data wajib diisi dengan benar!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            user.Password = password;
            user.Role = "user";
            user.Status_akun = "aktif";
            user.Limit_air = user.Jumlah_anggota * 30;

            bool result = _userRepo.Register(user);

            if (result)
            {
                MessageBox.Show("Registrasi berhasil! Silakan login.", "Sukses",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Registrasi gagal! Username mungkin sudah terpakai.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return result;
        }
    }
}
