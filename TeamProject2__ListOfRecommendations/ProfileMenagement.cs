using NLog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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

        private void support_service_lbl_Click(object sender, EventArgs e)
        {
            string subject = "Запрос на поддержку";
            string email = "list_of_recomendations@mail.ru";
            string mailtoCommand = string.Format("mailto:{0}?subject={1}", email, subject);
            

            Process.Start(mailtoCommand);
        }

        private void support_service_lbl_MouseEnter(object sender, EventArgs e)
        {
            command1.Visible = true;
        }

        private void support_service_lbl_MouseLeave(object sender, EventArgs e)
        {
            command1.Visible = false;
        }
    }
}
