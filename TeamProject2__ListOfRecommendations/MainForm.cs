using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Xml.Linq;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using static System.Net.WebRequestMethods;

namespace TeamProject2__ListOfRecommendations
{

    public partial class MainForm : Form
    {
        public MainForm(string login)
        {
            InitializeComponent();
            Login = login;
        }
        public string Login;
       

        private void MainForm_Load(object sender, EventArgs e)
        {
            
            CheckAdminRights(Login, add_film_btn);

            var screenWidth = Screen.PrimaryScreen.Bounds.Width;
            var screenHeight = Screen.PrimaryScreen.Bounds.Height;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point((screenWidth - this.Width) / 2, (screenHeight - this.Height) / 2);

            int buttonOffset = 30; // Размер отступа (30 мм)
            int formWidth = just_panel.Location.X + just_panel.Width + buttonOffset; // Вычисляем желаемую ширину формы
            int formHeight = just_panel.Location.Y + just_panel.Height + buttonOffset; // Вычисляем желаемую высоту формы
            this.ClientSize = new Size(formWidth, formHeight); // Устанавливаем размер формы
        }

        private void profile_pb_MouseEnter(object sender, EventArgs e)
        {
            frame_profile.Visible = true;

        }

        private void profile_pb_MouseLeave(object sender, EventArgs e)
        {
            frame_profile.Visible = false;
        }


        private void collapse_pb_MouseEnter(object sender, EventArgs e)
        {
            frame_collapse.Visible = true;
        }


        private void collapse_pb_MouseLeave(object sender, EventArgs e)
        {
            frame_collapse.Visible = false;
        }


        private void expand_pb_MouseEnter(object sender, EventArgs e)
        {
            frane_expand.Visible = true;
        }


        private void expand_pb_MouseLeave(object sender, EventArgs e)
        {
            frane_expand.Visible = false;
        }


        private void profile_pb_Click(object sender, EventArgs e)
        {
            ProfileMenagement profileMenagement = new ProfileMenagement(Login);
            profileMenagement.Show();
        }


        private void change_btn_MouseEnter(object sender, EventArgs e)
        {
            change_btn.ForeColor = Color.FromArgb(133, 162, 167);
        }


        private void change_btn_MouseLeave(object sender, EventArgs e)
        {
            change_btn.ForeColor = Color.FromArgb(64, 64, 64);
        }


        private void add_compilation_MouseEnter(object sender, EventArgs e)
        {
            add_compilation.BackColor = Color.FromArgb(133, 162, 167);
            add_compilation.ForeColor = Color.Black;
        }

        private void add_compilation_MouseLeave(object sender, EventArgs e)
        {
            add_compilation.BackColor = Color.FromArgb(64, 64, 64);
            add_compilation.ForeColor = Color.DarkGray;
        }

        private void change_compilation_MouseEnter(object sender, EventArgs e)
        {
            change_compilation.BackColor = Color.FromArgb(133, 162, 167);
            change_compilation.ForeColor = Color.Black;
        }
    

        private void change_compilation_MouseLeave(object sender, EventArgs e)
        {
            change_compilation.BackColor = Color.FromArgb(64, 64, 64);
            change_compilation.ForeColor = Color.DarkGray;
        }

        private void api_btn_MouseEnter(object sender, EventArgs e)
        {
            frame_api.Visible = true;
        }

        private void api_btn_MouseLeave(object sender, EventArgs e)
        {
            frame_api.Visible = false;
        }

        private void api_btn_Click(object sender, EventArgs e)
        {
            APISearch aPISearch = new APISearch();
            aPISearch.Show();
        }

        private void change_btn_Click(object sender, EventArgs e)
        {
            СhangeСharacteristics сhangeСharacteristics = new СhangeСharacteristics();
            сhangeСharacteristics.Show();
        }

        private void add_in_compilation_btn_Click(object sender, EventArgs e)
        {
            СhooseCollection chooseASelection = new СhooseCollection();
            chooseASelection.Show();
        }

        private void add_film_btn_Click(object sender, EventArgs e)
        {
            AddFilm addFilm = new AddFilm();
            addFilm.Show();
        }


        private void add_compilation_Click(object sender, EventArgs e)
        {
            CreateCollection createCollection = new CreateCollection();
            createCollection.Show();
        }


        private void change_compilation_Click(object sender, EventArgs e)
        {
            ChangeCollections changeCollections = new ChangeCollections();
            changeCollections.Show();
        }

        private void list_collections_SelectedIndexChanged(object sender, EventArgs e)
        {
            InfoAboutCollection infoAboutCollection = new InfoAboutCollection();
            infoAboutCollection.Show();
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            
        }


            private int isAdmin(string login)
            {
                string connectionString = "server=localhost;port=3306;username=root;password=root;database=teamproject_listofrecommendations";
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();
                string query = $"SELECT admin_rights FROM users WHERE Login='{login}'";
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();
                reader.Read();
                int adminRights = reader.GetInt32("admin_rights");
                reader.Close();
                connection.Close();
                return adminRights;
            }

        private void CheckAdminRights(string login, System.Windows.Forms.Button button) // в качестве аргументов передаем логин пользователя и кнопку, видимость которой надо изменить.
        {
            if (isAdmin(login)==1) 
            {
                button.Visible = true;
                MessageBox.Show("Добро пожаловать в профиль администаратора!\nУ вас есть возможность добавлять фильмы в приложение. Пожалуйста, придержвайтесь правил в создании фильмов.\nРазмещайте только существуюшие фильмы с актуальной информацией о них\nУдачи!");

            }
            else
            {
                button.Visible = false; 
            }
        }



    }
}









