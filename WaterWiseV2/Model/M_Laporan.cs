using System;
using System.Collections.Generic;
using System.Text;

namespace WaterWiseV2.Model
{
    public class M_Laporan
    {
        public int Id_laporan { get; set; }
        public int Id_akun { get; set; }
        public DateTime Tanggal_laporan { get; set; } = DateTime.Now;
        public string Status_laporan { get; set; } = "diproses";

        public List<M_DetailLaporan> DetailLaporans { get; set; }
        public M_Akun Akun { get; set; }

        public M_Laporan()
        {
            DetailLaporans = new List<M_DetailLaporan>();
        }


    }
}
