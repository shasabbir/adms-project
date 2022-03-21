using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADMS_Project
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            var reader = DbAccess.GetData($"SELECT * FROM admin WHERE Username='{loginUsernameTextBox.Text}' and password='{loginPasswordTextBox.Text}'");
            if (reader.HasRows == true)
            {
                MessageBox.Show("Login Successful !!! ");
                Dashboard dash = new Dashboard();
                dash.ShowDialog();

            }
            else
            {
                MessageBox.Show("Sorry, login failed !!!");
            }
        }
    }
}
