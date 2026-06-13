using Npgsql;
using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;
using System.Text;

namespace WaterWiseV2.DatabaseHealper
{
    internal class DatabaseHelper
    {
        
        private static string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=Mahfullah;Database=WaterWise";

        public static NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(connectionString);
        }

        public static bool TestConnection()
        {
            try
            {
                using (var conn = GetConnection())
                {
                    conn.Open();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
