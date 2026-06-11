using System;
using System.Collections.Generic;
using System.Text;
using WaterWiseV2.Model;
using WaterWiseV2.Repositories;

namespace WaterWiseV2.Control.User
{
    internal class C_DashboardUser
    {
        private M_User _currentUser;
        private PenggunaanAirRepository _penggunaanRepo;

        public C_DashboardUser(M_User user)
        {
            _currentUser = user;
            _penggunaanRepo = new PenggunaanAirRepository();
        }

        public decimal GetPemakaianHariIni()
        {
            return _penggunaanRepo.GetTotalPemakaianHariIni(_currentUser.Id_user);
        }

        public int GetSisaLimitHariIni()
        {
            decimal pemakaian = _penggunaanRepo.GetTotalPemakaianHariIni(_currentUser.Id_user);
            return _currentUser.Limit_air - (int)pemakaian;
        }

        public string GetStatusAkun()
        {
            return _currentUser.Status_akun;
        }
    }
}
