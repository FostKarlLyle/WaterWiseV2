using Npgsql;
using System;
using System.Collections.Generic;
using System.Text;
using WaterWiseV2.DatabaseHealper;
using WaterWiseV2.Model;

namespace WaterWiseV2.Repositories
{
    internal class PenggunaanAirRepository
    {
        // INSERT penggunaan air
        public bool Insert(M_PenggunaanAir penggunaan)
        {
            string query = @"
                INSERT INTO penggunaan_air (id_user, kode_ambil, tanggal_penggunaan, jumlah_air) 
                VALUES (@id_user, @kode_ambil, @tanggal_penggunaan, @jumlah_air)";

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id_user", penggunaan.Id_user);
                    cmd.Parameters.AddWithValue("@kode_ambil", penggunaan.Kode_ambil);
                    cmd.Parameters.AddWithValue("@tanggal_penggunaan", penggunaan.Tanggal_penggunaan);
                    cmd.Parameters.AddWithValue("@jumlah_air", penggunaan.Jumlah_air);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        // GET semua penggunaan air by user id
        public List<M_PenggunaanAir> GetByUserId(int id_user)
        {
            var list = new List<M_PenggunaanAir>();
            string query = "SELECT id_penggunaan, id_user, kode_ambil, tanggal_penggunaan, jumlah_air FROM penggunaan_air WHERE id_user = @id_user ORDER BY tanggal_penggunaan DESC";

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id_user", id_user);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new M_PenggunaanAir
                            {
                                Id_penggunaan = reader.GetInt32(0),
                                Id_user = reader.GetInt32(1),
                                Kode_ambil = reader.GetString(2),
                                Tanggal_penggunaan = reader.GetDateTime(3),
                                Jumlah_air = reader.GetDecimal(4)
                            });
                        }
                    }
                }
            }
            return list;
        }

        // GET total pemakaian hari ini saja
        public decimal GetTotalPemakaianHariIni(int id_user)
        {
            string query = @"
                SELECT COALESCE(SUM(jumlah_air), 0) 
                FROM penggunaan_air 
                WHERE id_user = @id_user 
                AND DATE(tanggal_penggunaan) = CURRENT_DATE";

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id_user", id_user);
                    object result = cmd.ExecuteScalar();
                    return Convert.ToDecimal(result);
                }
            }
        }

        // CEK apakah kode unik (belum pernah dipakai)
        public bool IsKodeUnique(string kodeAmbil)
        {
            string query = "SELECT COUNT(*) FROM penggunaan_air WHERE kode_ambil = @kode";

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@kode", kodeAmbil);
                    long count = (long)cmd.ExecuteScalar();
                    return count == 0;  // True jika belum ada
                }
            }
        }
    }
}
