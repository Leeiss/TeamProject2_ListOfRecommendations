using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace TeamProject2__ListOfRecommendations
{
    public partial class СhangeСharacteristics : Form
    {
        
        public List<Movie> movies = new List<Movie>();
        private string Date = null;
        public string[] characteristics = new string[4];
        XDocument doc = XDocument.Load("@./../../../ForLists.xml");
        private string connectionString = "server=localhost;port=3306;username=root;password=root;database=teamproject_listofrecommendations";
        public СhangeСharacteristics(string Login, List<Movie> movie)
        {
            InitializeComponent();
            login = Login;
            this.movies = movies;
        }
        private string login;
        private bool SelectDate1 = false;
        private bool SelectGenre = false;
        private bool SelectActor = false;
        private bool SelectCountry = false;
        private List<string> Genres = new List<string>();
        private List<string> Actors = new List<string>();
        private List<string> Countries = new List<string>();

        private void СhangeСharacteristics_Load(object sender, EventArgs e)
        {
            IEnumerable<string> actors = doc.Element("for_lists").Element("actors").Elements("actor").Select(x => x.Value);

            foreach (string actor in actors)
            {
                actors_list.Items.Add(actor);
            }

            var screenWidth = Screen.PrimaryScreen.Bounds.Width;
            var screenHeight = Screen.PrimaryScreen.Bounds.Height;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point((screenWidth - this.Width) / 2, (screenHeight - this.Height) / 2);

            int buttonOffset = 10; 
            int formWidth = save_btn.Location.X + save_btn.Width + buttonOffset; // Вычисляем желаемую ширину формы
            int formHeight = save_btn.Location.Y + save_btn.Height + buttonOffset; // Вычисляем желаемую высоту формы
            this.ClientSize = new Size(formWidth, formHeight); // Устанавливаем размер формы

        }

        private void ShowBtn()
        {
            if (SelectGenre ||  SelectActor || SelectDate1 || SelectCountry) 
            { 
                save_btn.Visible = true;
            }
        }
        private void genres_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            add_genre_btn.Visible = true;
        }

        private void countries_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            add_country_btn.Visible = true;
        }

        private void actors_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            add_actor_btn.Visible = true;
        }

        private void add_genre_btn_Click(object sender, EventArgs e)
        {
            Genres.Add(genres_list.SelectedItem.ToString());
            SelectGenre = true;
            ShowBtn();

        }

        private void add_country_btn_Click(object sender, EventArgs e)
        {
            Countries.Add(countries_list.SelectedItem.ToString());
            SelectCountry = true;
            ShowBtn();
        }

        private void date1_ValueChanged(object sender, EventArgs e)
        {
            SelectDate1= true;
            Date = date1.Value.ToString("dd.MM.yyyy");
            ShowBtn();
        }

       private void add_actor_btn_Click(object sender, EventArgs e)
        {
            Actors.Add(actors_list.SelectedItem.ToString());
            SelectActor = true;
            ShowBtn();
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                MySqlCommand command = new MySqlCommand();
                command.Connection = connection;

                string query = "SELECT Movies.MovieID, Movies.Title, IFNULL(Movies.Date, '') AS Date, IFNULL(Movies.Rating, '') AS Rating, IFNULL(Movies.PicturePath, '') AS PicturePath, IFNULL(Movies.Link, '') AS Link, GROUP_CONCAT(DISTINCT Film_Genres.Genre SEPARATOR ', ') AS Genres, GROUP_CONCAT(DISTINCT Film_Actors.Actor SEPARATOR ', ') AS Actors, GROUP_CONCAT(DISTINCT Film_Countries.Country SEPARATOR ', ') AS Countries FROM Movies " +
                           "LEFT JOIN Film_Genres ON Movies.MovieID = Film_Genres.FilmID " +
                           "LEFT JOIN Film_Actors ON Movies.MovieID = Film_Actors.FilmID " +
                           "LEFT JOIN Film_Countries ON Movies.MovieID = Film_Countries.FilmID " +
                           "WHERE ((";

                if (Genres.Count > 0)
                {
                    for (int i = 0; i < Genres.Count; i++)
                    {
                        if (i == 0)
                        {
                            query += "Film_Genres.Genre LIKE '%" + Genres[i].Trim() + "%'";
                        }
                        else
                        {
                            query += " OR Film_Genres.Genre LIKE '%" + Genres[i].Trim() + "%'";
                        }
                    }
                }
                else
                {
                    query += "1";
                }
                query += ") AND (";
                if (Countries.Count > 0)
                {
                    for (int i = 0; i < Countries.Count; i++)
                    {
                        if (i == 0)
                        {
                            query += "Film_Countries.Country LIKE '%" + Countries[i].Trim() + "%'";
                        }
                        else
                        {
                            query += " OR Film_Countries.Country LIKE '%" + Countries[i].Trim() + "%'";
                        }
                    }
                }
                else
                {
                    query += "1";
                }
                query += ") AND (";
                if (Actors.Count > 0)
                {
                    for (int i = 0; i < Actors.Count; i++)
                    {
                        if (i == 0)
                        {
                            query += "Film_Actors.Actor LIKE '%" + Actors[i].Trim() + "%'";
                        }
                        else
                        {
                            query += " OR Film_Actors.Actor LIKE '%" + Actors[i].Trim() + "%'";
                        }
                    }
                }
                else
                {
                    query += "1";
                }
                query += ")";
                if (!string.IsNullOrEmpty(Date))
                {
                    query += " AND (Movies.Date = '" + Date + "')";
                }
                query += ") GROUP BY Movies.MovieID";

                command.CommandText = query;

                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Movie m = new Movie();

                    m.MovieID = reader.GetInt32("MovieID");
                    m.Title = reader.GetString("Title");
                    m.Date = reader.GetString("Date");
                    m.Rating = reader.GetString("Rating");
                    m.PicturePath = reader.GetString("PicturePath");
                    m.Link = reader.GetString("Link");
                    m.Genres = reader.GetString("Genres");
                    m.Actors = reader.GetString("Actors");
                    m.Countries = reader.GetString("Countries");

                    movies.Add(m);
                }

                reader.Close();

                connection.Close();
            }
            
        }

        private void search_genre_btn_Click(object sender, EventArgs e)
        {
            search_genre_btn.Text = "";
        }

        private void search_country_tb_Click(object sender, EventArgs e)
        {
            search_country_tb.Text = string.Empty;
        }

        private void search_actor_tb_Click(object sender, EventArgs e)
        {
            search_actor_tb.Text= string.Empty;
        }

        private void SearchInList(ListBox list, string searchText)
        {
            int index = list.FindString(searchText);

            if (index != ListBox.NoMatches)
            {
                list.SelectedIndex = index;
            }
        }
        private void search_genre_btn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SearchInList(genres_list, search_genre_btn.Text);
            }
        }

        private void search_country_tb_KeyDown(object sender, KeyEventArgs e)
        {
            SearchInList(countries_list, search_country_tb.Text);
        }

        private void search_actor_tb_KeyDown(object sender, KeyEventArgs e)
        {
            SearchInList(actors_list, search_actor_tb.Text);
        }

        
    }  
}
