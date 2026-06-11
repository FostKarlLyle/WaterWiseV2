using System;
using System.Collections.Generic;
using System.Text;

namespace WaterWiseV2.Model
{
    internal class M_DetailLaporan
    {
        public int Id_detail_laporan { get; set; }
        public int Id_laporan { get; set; }
        public string Isi_laporan { get; set; }

        public M_Laporan Laporan { get; set; }

        public M_DetailLaporan() { }
    }
}
