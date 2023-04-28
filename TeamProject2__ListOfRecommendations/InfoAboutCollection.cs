using MySql.Data.MySqlClient;
using NLog;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TeamProject2__ListOfRecommendations
{
    public partial class InfoAboutCollection : Form
    {
        public InfoAboutCollection(string login, int collectionId)
        {
            InitializeComponent();
            Login = login;
            CollectionId = collectionId;
        }
        private List<int> ints = new List<int>();
        private string Login;
        private int CollectionId;
        private static Logger logger = LogManager.GetCurrentClassLogger();
        private string connectionString = "server=localhost;port=3306;username=root;password=root;database=teamproject_listofrecommendations";

        private void InfoAboutCollection_Load(object sender, EventArgs e)
        {
            FillList();

            var screenWidth = Screen.PrimaryScreen.Bounds.Width;
            var screenHeight = Screen.PrimaryScreen.Bounds.Height;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point((screenWidth - this.Width) / 2, (screenHeight - this.Height) / 2);

            int buttonOffset = 30; 
            int formWidth = just_panel.Location.X + just_panel.Width + buttonOffset; // Вычисляем желаемую ширину формы
            int formHeight = just_panel.Location.Y + just_panel.Height + buttonOffset; // Вычисляем желаемую высоту формы
            this.ClientSize = new Size(formWidth, formHeight);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void FillList()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = @"SELECT m.MovieID, m.Title FROM movies_collections mc
                       JOIN movies m ON mc.MovieID = m.MovieID
                       JOIN users_collections uc ON mc.CollectionID = uc.ID
                       JOIN users u ON uc.User_name = u.Login
                       WHERE uc.ID = @collectionId AND u.Login = @login";

                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@collectionId", CollectionId);
                command.Parameters.AddWithValue("@login", Login);
                MySqlDataReader reader = command.ExecuteReader();

                films_list.Items.Clear();

                while (reader.Read())
                {
                    int movieId = reader.GetInt32(0);
                    string title = reader.GetString(1);
                    films_list.Items.Add(title);
                    ints.Add(movieId);
                }
                connection.Close();
            }
        }

        private void films_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                go_btn.Visible = true;
            }
            catch
            {
                MessageBox.Show("Выберите фильм");
            }
            
        }
        public Movie GetMovieById(int movieId)
        {
            Movie movie = null;
            string query = "SELECT movies.MovieID, movies.Title, movies.Date, movies.PicturePath, movies.Link, GROUP_CONCAT(DISTINCT film_genres.Genre SEPARATOR ', ') AS Genres, GROUP_CONCAT(DISTINCT film_actors.Actor SEPARATOR ', ') AS Actors, GROUP_CONCAT(DISTINCT film_countries.Country SEPARATOR ', ') AS Countries " +
                           "FROM movies " +
                           "INNER JOIN film_genres ON movies.MovieID = film_genres.FilmId " +
                           "INNER JOIN film_actors ON movies.MovieID = film_actors.FilmId " +
                           "INNER JOIN film_countries ON movies.MovieID = film_countries.FilmId " +
                           "WHERE movies.MovieID = @MovieID " +
                           "GROUP BY movies.MovieID";
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MovieID", movieId);
                    connection.Open();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            movie = new Movie();
                            movie.MovieID = reader.GetInt32("MovieID");
                            movie.Title = reader.GetString("Title");
                            movie.Date = reader.GetString("Date");
                            movie.PicturePath = reader.GetString("PicturePath");
                            movie.Link = reader.GetString("Link");
                            movie.Genres = reader.GetString("Genres");
                            movie.Actors = reader.GetString("Actors");
                            movie.Countries = reader.GetString("Countries");
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            return movie;
        }
        private void go_btn_Click(object sender, EventArgs e)
        {
            int index = films_list.SelectedIndex;
            if (index == -1) 
            {
                MessageBox.Show("Выберите фильм");
            }
            else
            {
                int movieId = ints[index];
                Movie movie = GetMovieById(movieId);
                MainForm form1 = Application.OpenForms.OfType<MainForm>().FirstOrDefault();
                if (form1 != null)
                {

                    string year = movie.Date;
                    form1.close_showing_collection_film_btn.Visible = true;
                    year = year.Remove(0, 6);
                    form1.collections_panel.Visible = false;
                    form1.panel_show_collectionfilm.Visible = true;
                    form1.LinkForCollection = movie.Link;
                    form1.title_film_fromcollection.Text = $"{movie.Title.ToUpper()} ({year})";
                    form1.genres_collectionfilm.Text = movie.Genres;
                    form1.date_collectionfilm.Text = movie.Date;
                    form1.actors_collectionfilm.Text = movie.Actors;
                    form1.countries_collectionfilm.Text = movie.Countries;
                    try
                    {

                        form1.picture_poster_forcollection.Image = System.Drawing.Image.FromFile(movie.PicturePath);

                    }
                    catch
                    {
                        MessageBox.Show("Некорректный адрес изображения");
                    }


                }
                this.Close();
                form1.Activate();
            }
            
        }
    }
}
