using Npgsql;
using System;
using System.Collections.Generic;
using System.Text;
using WaterWiseV2.Model;
using WaterWiseV2.DatabaseHealper;

namespace WaterWiseV2.Repositories
{
    internal class AkunRepository
    {
        // GET akun (untuk login)
        public M_Akun GetByUsername(string username)
        {
            string query = "SELECT id_akun, username, password, nama, no_telepon, email, status_akun, role FROM akun WHERE username = @username";

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Cek role untuk menentukan return tipe M_User atau M_Admin
                            string role = reader.GetString(7);

                            if (role == "admin")
                            {
                                return new M_Admin
                                {
                                    Id_akun = reader.GetInt32(0),
                                    Username = reader.GetString(1),
                                    Password = reader.GetString(2),
                                    Nama = reader.GetString(3),
                                    No_telepon = reader.GetString(4),
                                    Email = reader.GetString(5),
                                    Status_akun = reader.GetString(6),
                                    Role = role
                                };
                            }
                            else
                            {
                                return new M_User
                                {
                                    Id_akun = reader.GetInt32(0),
                                    Username = reader.GetString(1),
                                    Password = reader.GetString(2),
                                    Nama = reader.GetString(3),
                                    No_telepon = reader.GetString(4),
                                    Email = reader.GetString(5),
                                    Status_akun = reader.GetString(6),
                                    Role = role
                                };
                            }
                        }
                    }
                }
            }
            return null;
        }

        // UPDATE status akun (aktif/nonaktif)
        public bool UpdateStatus(int id_akun, string status)
        {
            string query = "UPDATE akun SET status_akun = @status WHERE id_akun = @id";

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@status", status);
                    cmd.Parameters.AddWithValue("@id", id_akun);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}
