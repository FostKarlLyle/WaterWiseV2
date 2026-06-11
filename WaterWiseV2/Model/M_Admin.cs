using System;
using System.Collections.Generic;
using System.Text;

namespace WaterWiseV2.Model
{
    internal class M_Admin : M_Akun
    {
        public int Id_admin { get; set; }
        public string Status_kerja { get; set; } = "aktif";

        public M_Admin()
        {
            Role = "admin";
        }
    }
}
