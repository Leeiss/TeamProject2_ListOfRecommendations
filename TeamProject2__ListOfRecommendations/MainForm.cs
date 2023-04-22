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
using System.Diagnostics;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Org.BouncyCastle.Asn1.X509;
using System.Numerics;
using System.IO;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
        private string Link;
        private string connectionString = "server=localhost;port=3306;username=root;password=root;database=teamproject_listofrecommendations";
        List<Movie> movies = new List<Movie>();
        List<Movie> movielist = new List<Movie>();  

        private void ShowInfo()
        {
            if (movielist.Count != 0)
            {
                film_title_lbl.Text = movielist[0].Title.ToUpper();
                picture_poster.Image = System.Drawing.Image.FromFile(movielist[0].PicturePath);
                Link = movielist[0].Link;
            }
            else
            {
                MessageBox.Show("К сожалению, в нашем приложении еще нет фильмов, подходящих под ваши предпочтения\nВы можете изменить свои предпочтения в разделе <<Мой профиль>>, а также ставить оценки фильмам и выбирать характеристики фильмов");
            }
        }

       private void MainForm_Load(object sender, EventArgs e)
        {

            CheckAdminRights(Login, add_film_btn);
            movies = GetMoviesByPreferences(Login);
            foreach (Movie movie in movies)
            {
                movielist.Add(movie);
            }
            ShowInfo();

            

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
            connectionString = "server=localhost;port=3306;username=root;password=root;database=teamproject_listofrecommendations";
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
            if (isAdmin(login) == 1)
            {
                button.Visible = true;
                MessageBox.Show("Добро пожаловать в профиль администратора!\nУ вас есть возможность добавлять фильмы в приложение. Пожалуйста, придержвайтесь правил в создании фильмов.\nРазмещайте только существуюшие фильмы с актуальной информацией о них\nУдачи!");

            }
            else
            {
                button.Visible = false;
            }
        }

        private void substrate_picture1_MouseEnter(object sender, EventArgs e)
        {
            substrate_picture.Visible = true;
        }

        private void substrate_picture1_MouseLeave(object sender, EventArgs e)
        {
            substrate_picture.Visible = false;
        }

        private void picture_poster_Click(object sender, EventArgs e)
        {
            Process.Start(Link);
        }

        private void substrate_picture1_Click(object sender, EventArgs e)
        {
            Process.Start(Link);
        }

        private void picture_poster_MouseEnter(object sender, EventArgs e)
        {
            substrate_picture.Visible = true;
        }


        /// <summary>
        ///  Объединяем столбцы с жанрами, актерами и странами в одну строку, используя функцию GROUP_CONCAT 
        /// C помощью операторов LEFT JOIN и OR в блоке WHERE выбираем только те фильмы, которые содержат 
        /// жанр или актера, указанного в таблицах users_favoriteactors или users_favoritegenres для конкретного 
        /// пользователя.
        /// Сортируем по рейтингу, добавляем фильмы в List
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public List<Movie> GetMoviesByPreferences(string username)
        {
            List<Movie> movies = new List<Movie>();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = @"SELECT m.MovieID, m.Title, m.Date, m.Rating, m.PicturePath, m.Link, 
                        GROUP_CONCAT(DISTINCT fg.Genre) as Genres, 
                        GROUP_CONCAT(DISTINCT fa.Actor) as Actors, 
                        GROUP_CONCAT(DISTINCT fc.Country) as Countries 
                        FROM movies m 
                        LEFT JOIN film_genres fg ON m.MovieID = fg.FilmId 
                        LEFT JOIN film_actors fa ON m.MovieID = fa.FilmId 
                        LEFT JOIN film_countries fc ON m.MovieID = fc.FilmId 
                        LEFT JOIN users_favoriteactors ufa ON fa.Actor = ufa.Actor 
                        LEFT JOIN users_favoritegenres ufg ON fg.Genre = ufg.Genre 
                        WHERE ufa.Username = @Username OR ufg.Username = @Username 
                        GROUP BY m.MovieID 
                        ORDER BY m.Rating DESC";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Username", username);

                conn.Open();

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Movie newMovie = new Movie()
                        {
                            MovieID = reader.GetInt32("MovieID"),
                            Title = reader.GetString("Title"),
                            Date = reader.GetString("Date"),
                            Rating = reader.GetString("Rating"),
                            PicturePath = reader.GetString("PicturePath"),
                            Link = reader.GetString("Link"),
                            Genres = reader.GetString("Genres"),
                            Actors = reader.GetString("Actors"),
                            Countries = reader.GetString("Countries")
                        };

                        movies.Add(newMovie);
                    }
                }
            }

            return movies;
        }

        private void film_title_lbl_MouseEnter(object sender, EventArgs e)
        {
            film_title_lbl.ForeColor = Color.FromArgb(133, 162, 167);
            
        }

        private void film_title_lbl_MouseLeave(object sender, EventArgs e)
        {
            film_title_lbl.ForeColor = Color.Black;
        }

        private void collections_btn_MouseEnter(object sender, EventArgs e)
        {
            substrate_collection.Visible = true;
        }

        private void collections_btn_MouseLeave(object sender, EventArgs e)
        {
            substrate_collection.Visible = false;
        }

        private void film_title_lbl_Click(object sender, EventArgs e)
        {
            
            
            if (movies.Count == 0)
            {
                MessageBox.Show("К сожалению, в нашем приложении пока нет фильмов, подходящих под ваши предпочтения\nВы можете изменить свои предпотения в разделе <<Мой профиль>> или же ставя оценки фильмам и изменяя характеристики");
            }
            else
            {
                InfoAboutFilm infoAboutFilm = new InfoAboutFilm(movielist[0].Title, movielist[0].PicturePath, movielist[0].Genres, movielist[0].Actors, movielist[0].Countries, movielist[0].Date);
                infoAboutFilm.Show();
            }
        }

        private void pass_btn_Click(object sender, EventArgs e)
        {
            movielist.RemoveAt(0);
            if (movielist.Count == 0)
            {
                foreach (Movie movie in movies)
                {
                    movielist.Add(movie);
                }
            }
            ShowInfo();
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            
        }
    }
}









