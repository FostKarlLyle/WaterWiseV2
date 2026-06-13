using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace WaterWiseV2.Model
{
    public class M_User : M_Akun
    {
        public int Id_user { get; set; }
        public string No_kk { get; set; }
        public int Jumlah_anggota { get; set; }
        public int Limit_air { get; set; }

        // Navigation property (opsional, untuk relasi)
        public List<M_PenggunaanAir> RiwayatPenggunaan { get; set; }

        public M_User()
        {
            Role = "user";
            RiwayatPenggunaan = new List<M_PenggunaanAir>();
            Limit_air = 0;
        }
    }
}
