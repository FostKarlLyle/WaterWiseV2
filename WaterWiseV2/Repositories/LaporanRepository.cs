using Npgsql;
using System;
using System.Collections.Generic;
using System.Text;
using WaterWiseV2.DatabaseHealper;
using WaterWiseV2.Model;

namespace WaterWiseV2.Repositories
{
    internal class LaporanRepository
    {
        
        public int Insert(M_Laporan laporan)
        {
            string query = @"
                INSERT INTO laporan (id_akun, tanggal_laporan, status_laporan) 
                VALUES (@id_akun, @tanggal_laporan, @status_laporan)
                RETURNING id_laporan";

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id_akun", laporan.Id_akun);
                    cmd.Parameters.AddWithValue("@tanggal_laporan", laporan.Tanggal_laporan);
                    cmd.Parameters.AddWithValue("@status_laporan", laporan.Status_laporan);
                    return (int)cmd.ExecuteScalar();
                }
            }
        }

        // INSERT detail laporan
        public bool InsertDetail(M_DetailLaporan detail)
        {
            string query = @"
                INSERT INTO detail_laporan (id_laporan, isi_laporan) 
                VALUES (@id_laporan, @isi_laporan)";

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id_laporan", detail.Id_laporan);
                    cmd.Parameters.AddWithValue("@isi_laporan", detail.Isi_laporan);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}
