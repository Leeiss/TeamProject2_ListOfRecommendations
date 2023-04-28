using NLog;
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

        
        private void change_lbl_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm(Login);
            mainForm.Close();
            this.Close();
            
        }

        private void password_lbl_MouseEnter(object sender, EventArgs e)
        {
            command2.Visible = true;
        }

        private void password_lbl_MouseLeave(object sender, EventArgs e)
        {
            command2.Visible = false;
        }

        
        private void ProfileMenagement_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
    }
}
