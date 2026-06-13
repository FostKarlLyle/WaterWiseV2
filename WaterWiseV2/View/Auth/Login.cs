using WaterWiseV2.Helper;
using WaterWiseV2.Control.Auth;
using WaterWiseV2.Model;
using WaterWiseV2.View.User;

namespace WaterWiseV2
{
    public partial class Login : Form
    {
        private C_Login _loginController;

        public Login()
        {
            InitializeComponent();
            _loginController = new C_Login();
        }

        private void textboxUsername_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = textboxUsername.Text.Trim();
            string password = textboxPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username dan password harus diisi!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            object result = _loginController.Login(username, password);

            if (result != null)
            {
                if (result is M_Admin admin)
                {
                    //DashboardAdmin dashboardAdmin = new DashboardAdmin(admin);
                    //dashboardAdmin.Show();
                    //this.Hide();
                    MessageBox.Show("Admin berhasil login, tapi form admin belum dibuat.", "Info",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (result is M_User user)
                {
                    DashboardUser dashboardUser = new DashboardUser(user);
                    dashboardUser.Show();
                    this.Hide();
                }
            }
        }

        private void linkRegistrasi_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NavigationHelper.GoToRegister(this);
        }
    }
}
