using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeamProject1_ToDoList.Classes;
using System.Net;
using System.Net.Mail;

namespace TeamProject2__ListOfRecommendations
{
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
            timer = new Timer();
            timer.Interval = 500; 
            timer.Tick += new EventHandler(timer_Tick);
            info_lbl.Visible = false;
            go_btn.Visible = false;
            registration_btn.Visible = false;
            password_tb.Visible = false;
            login_tb.Visible = false;
            hide_btn.Visible = false;
            show_btn.Visible = false;
            this.Controls.Add(info_lbl);
            timer.Start();
        }

        private void Authorization_Load(object sender, EventArgs e)
        {
            picture_logo.SizeMode = PictureBoxSizeMode.StretchImage;
            
            var screenWidth = Screen.PrimaryScreen.Bounds.Width;
            var screenHeight = Screen.PrimaryScreen.Bounds.Height;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point((screenWidth - this.Width) / 2, (screenHeight - this.Height) / 2);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void go_btn_Click(object sender, EventArgs e)
        {
            String loginUser = login_tb.Text;
            String passUser = password_tb.Text;

            DataBase db = new DataBase();
            
            MySqlCommand command = new MySqlCommand("SELECT * FROM users WHERE  login = @uL AND password = @uP", db.GetConnection()); // создаем объект и передаем команду для вытягивания из бд логина и пароля из бд
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            adapter.SelectCommand = command; 


            DataTable table = new DataTable();

            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                ProfileMenagement profileMenagement = new ProfileMenagement(loginUser);
                MainForm mainForm = new MainForm(loginUser);
                mainForm.ShowDialog();
            }

            else
            {
                MessageBox.Show("Пользователь с такими данными не найден!");
                forgotpassword_btn.Visible = true;
            }

        }
        private void timer_Tick(object sender, EventArgs e)
        {
            info_lbl.Visible = true;
            go_btn.Visible = true;
            registration_btn.Visible = true;
            password_tb.Visible = true;
            login_tb.Visible = true;
            timer.Stop();
        }

        private void login_tb_Click(object sender, EventArgs e)
        {
            login_tb.Text = "";
        }

        private void password_tb_Click(object sender, EventArgs e)
        {
            password_tb.Text = "";
        }

        private void registration_btn_MouseEnter(object sender, EventArgs e)
        {
            registration_btn.ForeColor = Color.FromArgb(197, 210, 219);
        }

        private void registration_btn_MouseLeave(object sender, EventArgs e)
        {
            registration_btn.ForeColor = Color.FromArgb(133, 162, 167);
        }

        private void forgotpassword_btn_MouseEnter(object sender, EventArgs e)
        {
            forgotpassword_btn.ForeColor = Color.FromArgb(197, 210, 219);
        }

        private void forgotpassword_btn_MouseLeave(object sender, EventArgs e)
        {
            forgotpassword_btn.ForeColor = Color.FromArgb(133, 162, 167);
        }

        private void login_tb_MouseEnter(object sender, EventArgs e)
        {
            login_tb.BackColor = Color.White;
        }

        private void login_tb_MouseLeave(object sender, EventArgs e)
        {
            login_tb.BackColor = Color.FromArgb(241, 243, 242);
        }

        private void password_tb_MouseEnter(object sender, EventArgs e)
        {
            password_tb.BackColor = Color.White;
        }

        private void password_tb_MouseLeave(object sender, EventArgs e)
        {
            password_tb.BackColor = Color.FromArgb(241, 243, 242);
        }

        private void registration_btn_Click(object sender, EventArgs e)
        {
            Registration registration = new Registration(login_tb.Text);
            registration.Show();
        }
        private void forgotpassword_btn_Click(object sender, EventArgs e)
        {
            PasswordRecovery passwordRecovery = new PasswordRecovery(login_tb.Text);
            passwordRecovery.Show();
        }

        private void show_btn_Click(object sender, EventArgs e)
        {
            password_tb.PasswordChar = '*';
            hide_btn.Visible = true;
            show_btn.Visible = false;
            

        }

        private void hide_btn_Click(object sender, EventArgs e)
        {
            password_tb.PasswordChar = '\0';
            hide_btn.Visible = false;
            show_btn.Visible = true;
        }

        private void password_tb_TextChanged(object sender, EventArgs e)
        {
            password_tb.PasswordChar = '*';
            hide_btn.Visible = true;
        }
    }
}
