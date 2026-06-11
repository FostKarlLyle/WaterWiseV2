using Npgsql;
using System;
using System.Collections.Generic;
using System.Text;
using WaterWiseV2.DatabaseHealper;
using WaterWiseV2.Model;

namespace WaterWiseV2.Repositories
{
    internal class UserRepository
    {
        // GET semua user
        public List<M_User> GetAll()
        {
            var list = new List<M_User>();
            string query = @"
                SELECT a.id_akun, a.username, a.password, a.nama, a.no_telepon, a.email, a.status_akun, a.role,
                       u.id_user, u.no_kk, u.jumlah_anggota, u.limit_air
                FROM akun a
                JOIN users u ON a.id_akun = u.id_akun
                WHERE a.role = 'user'";

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new M_User
                        {
                            Id_akun = reader.GetInt32(0),
                            Username = reader.GetString(1),
                            Password = reader.GetString(2),
                            Nama = reader.GetString(3),
                            No_telepon = reader.GetString(4),
                            Email = reader.GetString(5),
                            Status_akun = reader.GetString(6),
                            Role = reader.GetString(7),
                            Id_user = reader.GetInt32(8),
                            No_kk = reader.GetString(9),
                            Jumlah_anggota = reader.GetInt32(10),
                            Limit_air = reader.GetInt32(11)
                        });
                    }
                }
            }
            return list;
        }

        // GET user by id_akun
        public M_User GetByAkunId(int id_akun)
        {
            string query = @"
                SELECT a.id_akun, a.username, a.password, a.nama, a.no_telepon, a.email, a.status_akun, a.role,
                       u.id_user, u.no_kk, u.jumlah_anggota, u.limit_air
                FROM akun a
                JOIN users u ON a.id_akun = u.id_akun
                WHERE a.id_akun = @id_akun";

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id_akun", id_akun);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
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
                                Role = reader.GetString(7),
                                Id_user = reader.GetInt32(8),
                                No_kk = reader.GetString(9),
                                Jumlah_anggota = reader.GetInt32(10),
                                Limit_air = reader.GetInt32(11)
                            };
                        }
                    }
                }
            }
            return null;
        }

        // GET user by id_user
        public M_User GetById(int id_user)
        {
            string query = @"
                SELECT a.id_akun, a.username, a.password, a.nama, a.no_telepon, a.email, a.status_akun, a.role,
                       u.id_user, u.no_kk, u.jumlah_anggota, u.limit_air
                FROM akun a
                JOIN users u ON a.id_akun = u.id_akun
                WHERE u.id_user = @id_user";

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id_user", id_user);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
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
                                Role = reader.GetString(7),
                                Id_user = reader.GetInt32(8),
                                No_kk = reader.GetString(9),
                                Jumlah_anggota = reader.GetInt32(10),
                                Limit_air = reader.GetInt32(11)
                            };
                        }
                    }
                }
            }
            return null;
        }

        // REGISTER user baru
        public bool Register(M_User user)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (var transaction = conn.BeginTransaction())
                {
                    try
                    {
                        // Insert ke tabel akun
                        string queryAkun = @"
                            INSERT INTO akun (username, password, nama, no_telepon, email, status_akun, role) 
                            VALUES (@username, @password, @nama, @no_telepon, @email, @status_akun, @role)
                            RETURNING id_akun";

                        int id_akun;
                        using (var cmd = new NpgsqlCommand(queryAkun, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@username", user.Username);
                            cmd.Parameters.AddWithValue("@password", user.Password);
                            cmd.Parameters.AddWithValue("@nama", user.Nama);
                            cmd.Parameters.AddWithValue("@no_telepon", user.No_telepon);
                            cmd.Parameters.AddWithValue("@email", user.Email);
                            cmd.Parameters.AddWithValue("@status_akun", "aktif");
                            cmd.Parameters.AddWithValue("@role", "user");
                            id_akun = (int)cmd.ExecuteScalar();
                        }

                        // Insert ke tabel users
                        string queryUser = @"
                            INSERT INTO users (id_akun, no_kk, jumlah_anggota, limit_air) 
                            VALUES (@id_akun, @no_kk, @jumlah_anggota, @limit_air)";

                        using (var cmd = new NpgsqlCommand(queryUser, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@id_akun", id_akun);
                            cmd.Parameters.AddWithValue("@no_kk", user.No_kk);
                            cmd.Parameters.AddWithValue("@jumlah_anggota", user.Jumlah_anggota);
                            cmd.Parameters.AddWithValue("@limit_air", user.Limit_air);
                            cmd.ExecuteNonQuery();
                        }

                        transaction.Commit();
                        return true;
                    }
                    catch
                    {
                        transaction.Rollback();
                        return false;
                    }
                }
            }
        }

        // CEK apakah username sudah terpakai
        public bool IsUsernameAvailable(string username)
        {
            string query = "SELECT COUNT(*) FROM akun WHERE username = @username";

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    long count = (long)cmd.ExecuteScalar();
                    return count == 0;
                }
            }
        }

        // UPDATE user
        public bool Update(M_User user)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (var transaction = conn.BeginTransaction())
                {
                    try
                    {
                        // Update tabel akun
                        string queryAkun = @"
                            UPDATE akun 
                            SET nama = @nama, no_telepon = @no_telepon, email = @email 
                            WHERE id_akun = @id_akun";

                        using (var cmd = new NpgsqlCommand(queryAkun, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@nama", user.Nama);
                            cmd.Parameters.AddWithValue("@no_telepon", user.No_telepon);
                            cmd.Parameters.AddWithValue("@email", user.Email);
                            cmd.Parameters.AddWithValue("@id_akun", user.Id_akun);
                            cmd.ExecuteNonQuery();
                        }

                        transaction.Commit();
                        return true;
                    }
                    catch
                    {
                        transaction.Rollback();
                        return false;
                    }
                }
            }
        }

        // DELETE user
        public bool Delete(int id_user)
        {
            string query = "DELETE FROM users WHERE id_user = @id_user";

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id_user", id_user);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}
