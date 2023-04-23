using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Xml.Linq;
using System.Data;
using System.Linq;

namespace TeamProject2__ListOfRecommendations
{

    public partial class MainForm : Form
    {
        public MainForm(string login)
        {
            InitializeComponent();
            Login = login;
        }
        private bool individual = true;
        private bool notindividual = false;
        private bool isComedyList = false;


        
        private bool SelectDate1 = false;
        private bool SelectGenre = false;
        private bool SelectActor = false;
        private bool SelectCountry = false;
        private List<string> Genres = new List<string>();
        private List<string> Actors = new List<string>();
        private List<string> Countries = new List<string>();

        private List<Movie> FiltrationMovies = new List<Movie>();
        private List<Movie> FiltrartionMovieList = new List<Movie>();

        private string Date = null;
        public string[] characteristics = new string[4];
        XDocument doc = XDocument.Load("@./../../../ForLists.xml");
        private string connectionString = "server=localhost;port=3306;username=root;password=root;database=teamproject_listofrecommendations";
        
        private List<Movie> ComedyFilms = new List<Movie>();
        private List<Movie> ComedyFilmsList = new List<Movie>();
        public string Login;
        private string Link;
       private List<Movie> movies = new List<Movie>();
        private List<Movie> movielist = new List<Movie>();
        private List<PictureBox> starBoxes = new List<PictureBox>();
        private int Rating;
        private int MovieID;
        private void ShowInfo(List <Movie> list)
        {
                Rating = int.Parse(list[0].Rating);
                film_title_lbl.Text = list[0].Title.ToUpper();
                MovieID = list[0].MovieID;
                picture_poster.Image = Image.FromFile(list[0].PicturePath);
                Link = list[0].Link;
            
        }

        public void ShowComedyFilms(bool YesNoComedy)
        {
            ShowInfo(ComedyFilms);
            isComedyList = YesNoComedy;
        }

       private void FillFilmsList(List<Movie> list, List<Movie> list1, string genre)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string selectQuery = "SELECT m.*, GROUP_CONCAT(DISTINCT g.Genre SEPARATOR ', ') as Genres"
                            + " FROM movies m"
                            + " JOIN film_genres g ON m.MovieID = g.FilmId"
                            + " WHERE g.Genre = 'Комедия'"
                            + " GROUP BY m.MovieID";

                using (MySqlCommand command = new MySqlCommand(selectQuery, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Movie movie = new Movie();
                            movie.MovieID = reader.GetInt32("MovieID");
                            movie.Title = reader.GetString("Title");
                            movie.Date = reader.GetString("Date");
                            movie.Rating = reader.GetString("Rating");
                            movie.PicturePath = reader.GetString("PicturePath");
                            movie.Link = reader.GetString("Link");
                            movie.Genres = reader.GetString("Genres");

                            list.Add(movie);
                        }
                    }
                }
                }
           foreach (Movie movie in list) 
            { 
                list1.Add(movie);
            }
           
        }


       private void MainForm_Load(object sender, EventArgs e)
        {
            FillFilmsList(ComedyFilms, ComedyFilmsList, "Комедия");
            CheckAdminRights(Login, add_film_btn);
            movies = GetMoviesByPreferences(Login);
            foreach (Movie movie in movies)
            {
                movielist.Add(movie);
            }

            IEnumerable<string> actors = doc.Element("for_lists").Element("actors").Elements("actor").Select(x => x.Value);

            foreach (string actor in actors)
            {
                actors_list.Items.Add(actor);
            }

            ShowInfo(movielist);

            starBoxes.Add(grayStar1); starBoxes.Add(grayStar2); starBoxes.Add(grayStar3); starBoxes.Add(grayStar4); starBoxes.Add(grayStar5); starBoxes.Add(grayStar6); starBoxes.Add(grayStar7); starBoxes.Add(grayStar8); starBoxes.Add(grayStar9); starBoxes.Add(grayStar10);
            
            
            StartPosition = FormStartPosition.CenterScreen;

            int buttonOffset = 40; // Размер отступа (30 мм)
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
            closing_panel.Visible = true;
            isComedyList = false;
            notindividual = true;
            
            
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
                        WHERE ufa.Username = @Username OR ufg.Username = @Username OR m.Rating > 7 
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
                InfoAboutFilm infoAboutFilm = new InfoAboutFilm(movielist[0].Title, movielist[0].PicturePath, movielist[0].Genres, movielist[0].Actors, movielist[0].Countries, movielist[0].Date, movielist[0].Rating);
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
                MovieID = movielist[0].MovieID;
                ShowInfo(movielist);
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            
        }

        private void picture_poster_MouseLeave(object sender, EventArgs e)
        {
            substrate_picture.Visible = false;
        }

        private void grayStar1_Click(object sender, EventArgs e)
        {
            OperationsClickStar();
        }

        private void grayStar2_Click(object sender, EventArgs e)
        {
            OperationsClickStar();
        }

        private void grayStar3_Click(object sender, EventArgs e)
        {
            OperationsClickStar();
        }

        private void grayStar4_Click(object sender, EventArgs e)
        {
            OperationsClickStar();
        }

        private void grayStar5_Click(object sender, EventArgs e)
        {
            OperationsClickStar();
        }

        private void grayStar6_Click(object sender, EventArgs e)
        {
            OperationsClickStar();
        }

        private void grayStar7_Click(object sender, EventArgs e)
        {
            OperationsClickStar();
        }

        private void grayStar8_Click(object sender, EventArgs e)
        {
            OperationsClickStar();
        }

        private void grayStar9_Click(object sender, EventArgs e)
        {
            OperationsClickStar();
        }

        private void grayStar10_Click(object sender, EventArgs e)
        {
            OperationsClickStar();
        }

        private void OperationsClickStar()
        {
            star_btn.Visible = true;
            foreach (PictureBox starBox in starBoxes)
            {
                starBox.Click += StarBox_Click;
            }
        }

        private void StarBox_Click(object sender, EventArgs e)
        {
            int selectedIndex = starBoxes.IndexOf((PictureBox)sender);
            for (int i = 0; i <= selectedIndex; i++)
            {
                starBoxes[i].Image = Properties.Resources.star;
            }
            Rating = selectedIndex + 1;
        }

        private void star_btn_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i <= 9; i++)
                {
                    starBoxes[i].Image = Properties.Resources.grayStar;
                }

                string addUserRatingQuery = "INSERT INTO user_ratings (Username, MovieID, Rating) VALUES (@username, @movieId, @rating)";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(addUserRatingQuery, connection))
                    {
                        command.Parameters.AddWithValue("@username", Login);
                        command.Parameters.AddWithValue("@movieId", MovieID);
                        command.Parameters.AddWithValue("@rating", Rating);
                        command.ExecuteNonQuery();
                    }
                }

                string updateMovieRatingQuery = "UPDATE movies SET Rating = (SELECT AVG(Rating) FROM user_ratings WHERE MovieID = @movieId) WHERE MovieID = @movieId";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(updateMovieRatingQuery, connection))
                    {
                        command.Parameters.AddWithValue("@movieId", MovieID);
                        command.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Оценка фильму успешно добавлена");
            }
            catch
            {
                MessageBox.Show("Ошибка");
            }
         }
            

        private void grayStar2_MouseClick(object sender, MouseEventArgs e)
        {
            OperationsClickStar();
        }

        private void collections_btn_Click(object sender, EventArgs e)
        {
            isComedyList = false;
            notindividual = false;
            Collections collections = new Collections(Login);
            collections.Show();
        }

        public void Filtration()
        {
            if (FiltrationMovies.Count == 0)
            {
                MessageBox.Show("Ни один из фильмов приложения не подходит под заданные вами параметры");
            }
            else
            {
                foreach (Movie movie in FiltrationMovies)
                {
                    FiltrartionMovieList.Add(movie);
                }
            notindividual = true;   
            ShowInfo(FiltrartionMovieList);


            }
        }

       
        private void film_title_lbl_TextChanged(object sender, EventArgs e)
        {

        }


        private void ShowBtn()
        {
            if (SelectGenre || SelectActor || SelectDate1 || SelectCountry)
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
            SelectDate1 = true;
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
            pass__individual__btn.Visible = false;
            pass_filtration_btn.Visible = true;
            notindividual = true;
            isComedyList = false;


            genre_info.Text = "";
            actors_info.Text = "";
            countries_info.Text = "";
            dateinterval_info.Text = "";

            genre_info.Text = string.Join(",", Genres);
            actors_info.Text = string.Join(",", Actors);
            countries_info.Text = string.Join(",", Countries);
            dateinterval_info.Text = Date;


            closing_panel.Visible = false;
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

                    FiltrationMovies.Add(m);
                }

                reader.Close();

                connection.Close();
            }
            Filtration();
            
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
            search_actor_tb.Text = string.Empty;
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

        private void button1_Click(object sender, EventArgs e)
        {
            closing_panel.Visible = false;
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            foreach (Movie movie in FiltrationMovies)
            {
                listBox1.Items.Add(movie.Title);
            }
        }

        private void pass_filtration_btn_Click(object sender, EventArgs e)
        {
            /*ComedyFilmsList.RemoveAt(0);

            if (ComedyFilmsList.Count == 0)
            {
                foreach (Movie movie in ComedyFilms)
                {
                    ComedyFilmsList.Add(movie);
                }
            }
            MovieID = ComedyFilmsList[0].MovieID;
            ShowInfo(ComedyFilmsList);*/


            FiltrartionMovieList.RemoveAt(0);

            if (FiltrartionMovieList.Count == 0)
            {
                foreach (Movie movie in FiltrationMovies)
                {
                    FiltrartionMovieList.Add(movie);
                }
            }
            MovieID = FiltrartionMovieList[0].MovieID;
            ShowInfo(FiltrartionMovieList);
        }
    }
}









