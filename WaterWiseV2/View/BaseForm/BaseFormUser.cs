using System;
using System.Collections.Generic;
using System.Text;
using WaterWiseV2.Control;
using WaterWiseV2.Model;
using WaterWiseV2.View.User;

namespace WaterWiseV2.View.BaseForm
{
    internal class BaseFormUser 
    {
        protected M_User _currentUser;

        public BaseFormUser(M_User user)
        {
            _currentUser = user;
        }

        // method navigasi
        protected void NavigateToDashboard()
        {
            DashboardUser form = new DashboardUser(_currentUser);
            form.Show();
            if (Application.OpenForms["DashboardUser"] != null)
            {
                // Close form sebelumnya (yang memanggil)
                Form currentForm = Form.ActiveForm;
                if (currentForm != null)
                    currentForm.Close();
            }
        }

        protected void NavigateToAmbilAir()
        {
            AmbilAirUser form = new AmbilAirUser(_currentUser);
            form.Show();
            Form.ActiveForm?.Close();
        }

        protected void NavigateToProfil()
        {
            ProfileUser form = new ProfileUser(_currentUser);
            form.Show();
            Form.ActiveForm?.Close();
        }

        protected void NavigateToLaporKeluhan()
        {
            LaporKeluhanUser form = new LaporKeluhanUser(_currentUser);
            form.Show();
            Form.ActiveForm?.Close();
        }

        protected void NavigateToHistory(M_User user)
        {
            HistoryUser form = new HistoryUser(_currentUser);
            form.Show();
            Form.ActiveForm?.Close();
        }

        protected void Logout()
        {
            DialogResult result = MessageBox.Show("Apakah Anda yakin ingin logout?", "Konfirmasi",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Login loginForm = new Login();
                loginForm.Show();
                Form.ActiveForm?.Close();
            }
        }
    }
}
