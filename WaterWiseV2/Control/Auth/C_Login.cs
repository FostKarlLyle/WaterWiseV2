using System;
using System.Collections.Generic;
using System.Text;
using WaterWiseV2.Model;
using WaterWiseV2.Repositories;

namespace WaterWiseV2.Control.Auth
{
    internal class C_Login
    {
        private AkunRepository _akunRepo;
        private UserRepository _userRepo;

        public C_Login()
        {
            _akunRepo = new AkunRepository();
            _userRepo = new UserRepository();
        }

        public object Login(string username, string password)
        {
            // Cari akun berdasarkan username
            M_Akun akun = _akunRepo.GetByUsername(username);

            if (akun == null)
            {
                MessageBox.Show("Username tidak ditemukan!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            if (akun.Password != password)
            {
                MessageBox.Show("Password salah!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            if (akun.Status_akun != "aktif")
            {
                MessageBox.Show("Akun Anda nonaktif. Hubungi admin!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            if (akun.Role == "admin")
            {
                MessageBox.Show($"Selamat datang Admin {akun.Nama}!", "Login Berhasil",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return akun;
            }
            else
            {
                M_User user = _userRepo.GetByAkunId(akun.Id_akun);
                MessageBox.Show($"Selamat datang {user.Nama}!", "Login Berhasil",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return user;
            }
        }
    }
}
