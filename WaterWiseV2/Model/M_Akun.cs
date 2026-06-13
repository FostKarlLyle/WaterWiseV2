using System;
using System.Collections.Generic;
using System.Text;

namespace WaterWiseV2.Model
{
    public abstract class M_Akun
    {
        public int Id_akun { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Nama { get; set; }
        public string No_telepon { get; set; }
        public string Email { get; set; }
        public string Status_akun { get; set; } = "aktif";
        public string Role { get; set; }

        public M_Akun()
        {
            Status_akun = "aktif";
        }
    }  
}