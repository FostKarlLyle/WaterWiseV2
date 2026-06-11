using System;
using System.Collections.Generic;
using System.Text;
using WaterWiseV2.Model;
using WaterWiseV2.Repositories;

namespace WaterWiseV2.Control.User
{
    internal class C_EditProfile
    {
        private M_User _currentUser;
        private UserRepository _userRepo;

        public C_EditProfile(M_User user)
        {
            _currentUser = user;
            _userRepo = new UserRepository();
        }

        public M_User GetUserData()
        {
            return _currentUser;
        }

        public bool UpdateProfil(string nama, string noTelepon, string email)
        {
            _currentUser.Nama = nama;
            _currentUser.No_telepon = noTelepon;
            _currentUser.Email = email;

            bool result = _userRepo.Update(_currentUser);

            if (result)
            {
                MessageBox.Show("Profil berhasil diupdate!", "Sukses",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Gagal mengupdate profil!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return result;
        }
    }
}
