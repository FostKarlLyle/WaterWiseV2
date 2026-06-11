using System;
using System.Collections.Generic;
using System.Text;
using WaterWiseV2.Control.Auth;
using WaterWiseV2.Model;
using WaterWiseV2.View.User;

namespace WaterWiseV2.Helper
{
    internal class NavigationHelper
    {
        // ==================== NAVIGASI USER ====================
        public static void GoToDashboardUser(M_User user)
        {
            DashboardUser form = new DashboardUser(user);
            form.Show();
            CloseCurrentForm();
        }

        public static void GoToAmbilAirUser(M_User user)
        {
            AmbilAirUser form = new AmbilAirUser(user);
            form.Show();
            CloseCurrentForm();
        }

        public static void GoToProfileUser(M_User user)
        {
            ProfileUser form = new ProfileUser(user);
            form.Show();
            CloseCurrentForm();
        }

        public static void GoToLaporKeluhanUser(M_User user)
        {
            LaporKeluhanUser form = new LaporKeluhanUser(user);
            form.Show();
            CloseCurrentForm();
        }

        public static void GoToHistoryUser(M_User user)
        {
            V_HistoryUser form = new V_HistoryUser(user);
            form.Show();
            CloseCurrentForm();
        }

        // ==================== NAVIGASI ADMIN ====================
        public static void GoToDashboardAdmin(M_Admin admin)
        {
            V_DashboardAdmin form = new V_DashboardAdmin(admin);
            form.Show();
            CloseCurrentForm();
        }

        public static void GoToKelolaUserAdmin(M_Admin admin)
        {
            V_KelolaUserAdmin form = new V_KelolaUserAdmin(admin);
            form.Show();
            CloseCurrentForm();
        }

        public static void GoToUbahLimitAdmin(M_Admin admin)
        {
            V_UbahLimitAdmin form = new V_UbahLimitAdmin(admin);
            form.Show();
            CloseCurrentForm();
        }

        public static void GoToLihatKeluhanAdmin(M_Admin admin)
        {
            V_LihatKeluhanAdmin form = new V_LihatKeluhanAdmin(admin);
            form.Show();
            CloseCurrentForm();
        }

        public static void GoToHistoryAdmin(M_Admin admin)
        {
            V_HistoryAdmin form = new V_HistoryAdmin(admin);
            form.Show();
            CloseCurrentForm();
        }

        public static void GoToProfileAdmin(M_Admin admin)
        {
            V_ProfileAdmin form = new V_ProfileAdmin(admin);
            form.Show();
            CloseCurrentForm();
        }

        // ==================== NAVIGASI UMUM ====================
        public static void GoToLogin()
        {
            V_Login form = new V_Login();
            form.Show();
            CloseCurrentForm();
        }

        public static void GoToRegister()
        {
            V_Register form = new V_Register();
            form.Show();
            CloseCurrentForm();
        }

        public static void Logout()
        {
            DialogResult result = MessageBox.Show("Apakah Anda yakin ingin logout?", "Konfirmasi",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                GoToLogin();
            }
        }

        private static void CloseCurrentForm()
        {
            Form currentForm = Form.ActiveForm;
            if (currentForm != null)
            {
                currentForm.Close();
            }
        }
    }
}
