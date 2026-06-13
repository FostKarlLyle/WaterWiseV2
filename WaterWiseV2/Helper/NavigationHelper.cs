using System;
using System.Collections.Generic;
using System.Text;
using WaterWiseV2.Control.Auth;
using WaterWiseV2.Model;
using WaterWiseV2.View.Auth;
using WaterWiseV2.View.User;

namespace WaterWiseV2.Helper
{
    internal class NavigationHelper
    {
        // NAVIGASI USER (dengan parameter Form currentForm)
        public static void GoToDashboardUser(M_User user, Form currentForm)
        {
            DashboardUser form = new DashboardUser(user);
            form.Show();
            currentForm.Close();
        }

        public static void GoToAmbilAirUser(M_User user, Form currentForm)
        {
            AmbilAirUser form = new AmbilAirUser(user);
            form.Show();
            currentForm.Close();
        }

        public static void GoToProfileUser(M_User user, Form currentForm)
        {
            ProfileUser form = new ProfileUser(user);
            form.Show();
            currentForm.Close();
        }

        public static void GoToLaporKeluhanUser(M_User user, Form currentForm)
        {
            LaporKeluhanUser form = new LaporKeluhanUser(user);
            form.Show();
            currentForm.Close();
        }

        public static void GoToHistoryUser(M_User user, Form currentForm)
        {
            HistoryUser form = new HistoryUser(user);
            form.Show();
            currentForm.Close();
        }

        // NAVIGASI UMUM
        public static void GoToLogin(Form currentForm)
        {
            Login form = new Login();
            form.Show();
            currentForm.Close();
        }

        public static void GoToRegister(Form currentForm)
        {
            Register form = new Register();
            form.Show();
            currentForm.Close();
        }

        public static void Logout(Form currentForm)
        {
            DialogResult result = MessageBox.Show("Apakah Anda yakin ingin logout?", "Konfirmasi",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                GoToLogin(currentForm);
            }
        }
    }
}
