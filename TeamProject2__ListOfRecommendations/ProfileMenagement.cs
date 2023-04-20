using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamProject2__ListOfRecommendations
{
    public partial class ProfileMenagement : Form
    {
        public ProfileMenagement(string username)
        {
            InitializeComponent();
            login_lbl.Text = username;
            Login = username;
        }
        public string Login;
        private void password_lbl_Click(object sender, EventArgs e)
        {
            PasswordRecovery passwordRecovery = new PasswordRecovery(Login);
            passwordRecovery.Show();
        }

        private void command1_Click(object sender, EventArgs e)
        {
            Preferences preferences = new Preferences(login_lbl.Text);
            preferences.Show();
        }

        private void command2_Click(object sender, EventArgs e)
        {
            PasswordRecovery passwordRecovery = new PasswordRecovery(Login);
            passwordRecovery.Show();
        }

        private void command3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void change_lbl_Click(object sender, EventArgs e)
        {
            Preferences preferences = new Preferences(login_lbl.Text);
            preferences.Tag = "изменить";
            preferences.Show();
        }

        private void cancel_lbl_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void change_lbl_MouseEnter(object sender, EventArgs e)
        {
            command1.Visible = true;
        }

        private void change_lbl_MouseLeave(object sender, EventArgs e)
        {
            command1.Visible = false;
        }

        private void password_lbl_MouseEnter(object sender, EventArgs e)
        {
            command2.Visible = true;
        }

        private void password_lbl_MouseLeave(object sender, EventArgs e)
        {
            command2.Visible = false;
        }

        private void cancel_lbl_MouseEnter(object sender, EventArgs e)
        {
            command3.Visible = true;
        }

        private void cancel_lbl_MouseLeave(object sender, EventArgs e)
        {
            command3.Visible = false;
        }

        private void ProfileMenagement_Load(object sender, EventArgs e)
        {
            var screenWidth = Screen.PrimaryScreen.Bounds.Width;
            var screenHeight = Screen.PrimaryScreen.Bounds.Height;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point((screenWidth - this.Width) / 2, (screenHeight - this.Height) / 2);
        }
    }
}
