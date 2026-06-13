using System;
using System.Collections.Generic;
using System.Text;

namespace WaterWiseV2.Model
{
    public class M_PenggunaanAir
    {
        public int Id_penggunaan { get; set; }
        public int Id_user { get; set; }
        public string Kode_ambil { get; set; }
        public DateTime Tanggal_penggunaan { get; set; } = DateTime.Now;
        public decimal Jumlah_air { get; set; }

        // Navigation property
        public M_User User { get; set; }

        public M_PenggunaanAir() { }
    }
}
