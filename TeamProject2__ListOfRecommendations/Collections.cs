using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace TeamProject2__ListOfRecommendations
{
    public partial class Collections : Form
    {
        public Collections(string login)
        {
            InitializeComponent();
            Login = login;


        }
        private string Login;
        private bool isComedy = false;
        private void Collections_Load(object sender, EventArgs e)
        {
            info_lbl1.Visible = true;

            Timer timer = new Timer();
            timer.Interval = 1000; 
            timer.Tick += (s, args) =>
            {
                closing_panel.Visible = true;
                timer.Stop();
                timer.Dispose();
            };
            timer.Start();

            int buttonOffset = 20; 
            int formWidth = go_btn.Location.X + go_btn.Width + buttonOffset; 
            int formHeight = go_btn.Location.Y + go_btn.Height + buttonOffset; 
            this.ClientSize = new Size(formWidth, formHeight); 
        }

        private void closing_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comedy_btn_MouseEnter(object sender, EventArgs e)
        {
            substrate1.Visible = true;
        }

        private void comedy_btn_MouseLeave(object sender, EventArgs e)
        {
            substrate1.Visible = false;
        }

        private void adventure_btn_MouseEnter(object sender, EventArgs e)
        {
            substrate2.Visible = true;
        }

        private void adventure_btn_MouseLeave(object sender, EventArgs e)
        {
            substrate2.Visible = false;
        }

        private void action_btn_MouseEnter(object sender, EventArgs e)
        {
            substrate3.Visible = true;
        }

        private void action_btn_MouseLeave(object sender, EventArgs e)
        {
            substrate3.Visible = false;
        }

        private void fantasy_btn_MouseEnter(object sender, EventArgs e)
        {
            substrate4.Visible = true;
        }

        private void fantasy_btn_MouseLeave(object sender, EventArgs e)
        {
            substrate4.Visible = false;
        }

        private void detective_btn_MouseEnter(object sender, EventArgs e)
        {
            substrate5.Visible = true;
        }

        private void detective_btn_MouseLeave(object sender, EventArgs e)
        {
            substrate5.Visible = false;
        }

        private void history_btn_MouseEnter(object sender, EventArgs e)
        {
            substrate6.Visible = true;
        }

        private void history_btn_MouseLeave(object sender, EventArgs e)
        {
            substrate6.Visible = false;
        }

        private void comedy_btn_Click(object sender, EventArgs e)
        {
            isComedy = true;
            MainForm myForm = new MainForm(Login);
            myForm.ShowComedyFilms(isComedy);
            this.Close();
            go_btn.Visible = true;
        }

        private void adventure_btn_Click(object sender, EventArgs e)
        {
            go_btn.Visible = true;
        }

        private void action_btn_Click(object sender, EventArgs e)
        {
            go_btn.Visible = true;
        }

        private void fantasy_btn_Click(object sender, EventArgs e)
        {
            go_btn.Visible = true;
        }

        private void detective_btn_Click(object sender, EventArgs e)
        {
            go_btn.Visible = true;
        }

        private void history_btn_Click(object sender, EventArgs e)
        {
            go_btn.Visible = true;
        }

        private void info_lbl1_Click(object sender, EventArgs e)
        {

        }

        private void substrate6_MouseEnter(object sender, EventArgs e)
        {
            substrate6.Visible = true;
        }

        private void substrate6_MouseLeave(object sender, EventArgs e)
        {
            substrate6.Visible = false;
        }
    }
}
