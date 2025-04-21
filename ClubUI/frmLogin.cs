using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClubClassLibrary.Repositories;

namespace ClubUI
{
    public partial class frmLogin : Form
    {
        UserRepository repoUser = new UserRepository();

        public bool LoggedIn = false;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            //validate textboxes ...


            var user = repoUser.CheckLogin(textBoxEmail.Text, textBoxPassword.Text);

            if (user != null)
            {
                App.CurrentUser = user;
                LoggedIn = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("خطأ في بيانات الدخول");
            }
        }
    }
}
