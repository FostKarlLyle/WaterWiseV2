using System;
using System.Collections.Generic;
using System.Text;
using WaterWiseV2.Model;
using WaterWiseV2.Repositories;

namespace WaterWiseV2.Control.User
{
    internal class C_History
    {
        private M_User _currentUser;
        private PenggunaanAirRepository _penggunaanRepo;

        public C_History(M_User user)
        {
            _currentUser = user;
            _penggunaanRepo = new PenggunaanAirRepository();
        }

        public List<M_PenggunaanAir> GetRiwayat()
        {
            return _penggunaanRepo.GetByUserId(_currentUser.Id_user);
        }
    }
}
