using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Diagnostics;
using System.Xml.Linq;
using System.Data;
using System.Linq;
using System.Collections;

namespace TeamProject2__ListOfRecommendations
{

    public partial class MainForm : Form
    {
        
       
        public MainForm(string login)
        {
            InitializeComponent();
            
            connection = new MySqlConnection(connectionString);
            Login = login;
        }
        private MySqlConnection conn;
        private static MySqlConnection connection;

        private bool SelectDate1 = false;
        private bool SelectGenre = false;
        private bool SelectActor = false;
        private bool SelectCountry = false;
        private bool IsIndividual = true;//если подборка фильмов происходит на основе предпочтений пользователя
        private bool IsNotIndividual = false;//есди подборка фильма происходит из готовых коллекций (коллекций приложения по жанрам)

        private List<string> Genres = new List<string>();
        private List<string> Actors = new List<string>();
        private List<string> Countries = new List<string>();
        private List<PictureBox> starBoxes = new List<PictureBox>();
        private List<Movie> CollectionMovies = new List<Movie>();
        private List<Movie> CollectionMoviesList = new List<Movie>();
        private List<int> CollectionsIds = new List<int>();
        public string LinkForCollection;

        int formWidth;
        int formHeight;




        private string Date = null;
        public string Login;
        private string Link;
        private int MovieID;
        private int Rating;


        XDocument doc = XDocument.Load("@./../../../ForLists.xml");
        private string connectionString = "server=localhost;port=3306;username=root;password=root;database=teamproject_listofrecommendations";

       private void ClearLbls()
        {
            genre_info.Text = "";
            actors_info.Text = "";
            countries_info.Text = "";
            dateinterval_info.Text = "";
        }     

       

        private void ShowInfoInLblForCollection()
        {
            try
            {
                string year = CollectionMoviesList[0].Date;
                year = year.Remove(0, 6);
                film_title_lbl.Text = $"{CollectionMoviesList[0].Title} ({year})";
                MovieID = CollectionMoviesList[0].MovieID;
                Link = CollectionMoviesList[0].Link;
                picture_poster.Image = Image.FromFile(CollectionMoviesList[0].PicturePath);
            }
            catch
            {
                MessageBox.Show("В базе данных приложения еще нет фильмов с таким жанром");
            }
            
        }

        public Movie GetMovieDetails()
        {
            MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=teamproject_listofrecommendations");
            connection.Open();

            MySqlCommand command = connection.CreateCommand();
            command.CommandText = @"
        SELECT movies.Title, movies.PicturePath, movies.Date,
            GROUP_CONCAT(DISTINCT film_genres.Genre SEPARATOR ', ') AS Genres,
            GROUP_CONCAT(DISTINCT film_actors.Actor SEPARATOR ', ') AS Actors,
            GROUP_CONCAT(DISTINCT film_countries.Country SEPARATOR ', ') AS Countries
        FROM movies
            LEFT JOIN film_genres ON movies.MovieID = film_genres.FilmId
            LEFT JOIN film_actors ON movies.MovieID = film_actors.FilmId
            LEFT JOIN film_countries ON movies.MovieID = film_countries.FilmId
        WHERE movies.MovieID = @movieId
        GROUP BY movies.MovieID;
    ";
            command.Parameters.AddWithValue("@movieId", MovieID);

            MySqlDataReader reader = command.ExecuteReader();
            Movie result_movie = new Movie();
            if (reader.HasRows)
            {
                reader.Read();
                string title = reader.GetString("Title");
                string path = reader.GetString("PicturePath");
                string date = reader.GetString("Date");
                string genres = reader.IsDBNull(reader.GetOrdinal("Genres")) ? "" : reader.GetString("Genres");
                string actors = reader.IsDBNull(reader.GetOrdinal("Actors")) ? "" : reader.GetString("Actors");
                string countries = reader.IsDBNull(reader.GetOrdinal("Countries")) ? "" : reader.GetString("Countries");

                result_movie.Date = date;
                result_movie.Title = title;
                result_movie.PicturePath = path;
                result_movie.Genres = genres;
                result_movie.Actors = actors;
                result_movie.Countries = countries;
            }
            reader.Close();

            connection.Close();

            return result_movie;
        }

        private void FillFilmsList(List<Movie> list, List<Movie> list1, string genre)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string selectQuery = "SELECT m.*, GROUP_CONCAT(DISTINCT g.Genre SEPARATOR ', ') as Genres"
                            + " FROM movies m"
                            + " JOIN film_genres g ON m.MovieID = g.FilmId"
                            + $" WHERE g.Genre = '{genre}'"
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

        private void ShowInfoInLbls(Movie movie)
        {
            string year = movie.Date;
            year = year.Remove(0, 6);
            film_title_lbl.Text = $"{movie.Title} ({year})";
            Link = movie.Link;
            picture_poster.Image = Image.FromFile(movie.PicturePath);
            MovieID = movie.MovieID;


        }

        private void ShowRecomendedMovie()
        {
            ClearLbls();
            Movie topRatedMovie = GetTopRatedMovie(Login);
            ShowInfoInLbls(topRatedMovie);
        }

        static Movie GetTopRatedMovie(string userLogin)
        {
            connection.Open();

            MySqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT m.MovieID, m.Title, m.Date, m.PicturePath, m.Link, GROUP_CONCAT(DISTINCT fg.Genre SEPARATOR ', ') as Genres, GROUP_CONCAT(DISTINCT fa.Actor SEPARATOR ', ') as Actors, GROUP_CONCAT(DISTINCT fc.Country SEPARATOR ', ') as Countries, AVG(ugr.RatingGenre) + AVG(uar.RatingActor) as MovieRating " +
                "FROM movies m " +
                "JOIN film_genres fg ON m.MovieID = fg.FilmID " +
                "JOIN film_actors fa ON m.MovieID = fa.FilmID " +
                "JOIN film_countries fc ON m.MovieID = fc.FilmID " +
                "JOIN users_genres_rating ugr ON fg.Genre = ugr.Genrename " +
                "JOIN users_actors_rating uar ON fa.Actor = uar.Actorname " +
                "JOIN users u ON u.Login = ugr.Username " +
                "WHERE u.Login = @userLogin " +
                "GROUP BY m.MovieID " +
                "ORDER BY MovieRating DESC " +
                "LIMIT 1";
            command.Parameters.AddWithValue("@userLogin", userLogin);

            Movie topRatedMovie = null;

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    topRatedMovie = new Movie();
                    topRatedMovie.MovieID = reader.GetInt32("MovieID");
                    topRatedMovie.Title = reader.GetString("Title");
                    topRatedMovie.Date = reader.GetString("Date");
                    topRatedMovie.PicturePath = reader.GetString("PicturePath");
                    topRatedMovie.Link = reader.GetString("Link");
                    topRatedMovie.Genres = reader.GetString("Genres");
                    topRatedMovie.Actors = reader.GetString("Actors");
                    topRatedMovie.Countries = reader.GetString("Countries");
                }
            }

            connection.Close();

            return topRatedMovie;
        }

        private void ShowUserCollectionsList()
        {
            list_collections.Items.Clear();
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            string getCollectionNamesSql = "SELECT ID, Collection_name FROM users_collections WHERE User_name = @username";
            MySqlCommand getCollectionNamesCmd = new MySqlCommand(getCollectionNamesSql, connection);
            getCollectionNamesCmd.Parameters.AddWithValue("@username", Login);

            List<string> collectionNames = new List<string>();
            using (MySqlDataReader reader = getCollectionNamesCmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    int collectionId = reader.GetInt32("ID");
                    string collectionName = reader.GetString("Collection_name");
                    CollectionsIds.Add(collectionId);
                    collectionNames.Add(collectionName);
                }
            }

            connection.Close();

            foreach (string collectionName in collectionNames)
            {
                list_collections.Items.Add(collectionName);
            }
        }
    

        private void MainForm_Load(object sender, EventArgs e)
        {
            
            ShowRecomendedMovie();
            ShowUserCollectionsList();
            
            conn = new MySqlConnection(connectionString);

            
            CheckAdminRights(Login, add_film_btn);

            IEnumerable<string> actors = doc.Element("for_lists").Element("actors").Elements("actor").Select(x => x.Value);

            
            starBoxes.Add(grayStar1); starBoxes.Add(grayStar2); starBoxes.Add(grayStar3); starBoxes.Add(grayStar4); starBoxes.Add(grayStar5); starBoxes.Add(grayStar6); starBoxes.Add(grayStar7); starBoxes.Add(grayStar8); starBoxes.Add(grayStar9); starBoxes.Add(grayStar10);
            
            
            StartPosition = FormStartPosition.CenterScreen;

            int buttonOffset = 10; 
            formWidth = just_panel.Location.X + just_panel.Width + buttonOffset; // Вычисляем желаемую ширину формы
            formHeight = just_panel.Location.Y + just_panel.Height + buttonOffset; // Вычисляем желаемую высоту формы
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
            profileMenagement.Location = new Point(this.Location.X-20, this.Location.Y-20);
            profileMenagement.ShowDialog(); 
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

            
        }

        private void add_in_compilation_btn_Click(object sender, EventArgs e)
        {
            СhooseCollection chooseASelection = new СhooseCollection(Login, MovieID);
            chooseASelection.Show();
        }

        private void add_film_btn_Click(object sender, EventArgs e)
        {
            AddFilm addFilm = new AddFilm();
            addFilm.Show();
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            FillListWithCollectionsAgain();
            CollectionsIds.Clear();
            ShowUserCollectionsList();
        } 

        public void FillListWithCollectionsAgain()
        {
            list_collections.Items.Clear();
            ShowUserCollectionsList();
        }

        private void add_compilation_Click(object sender, EventArgs e)
        {
            CreateCollection createCollection = new CreateCollection(Login);
            createCollection.Show();
        }


        private void change_compilation_Click(object sender, EventArgs e)
        {
            ChangeCollections changeCollections = new ChangeCollections(Login);
            changeCollections.Show();
        }

        private void list_collections_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            try
            {

                int index = list_collections.SelectedIndex;
                int collection_id = CollectionsIds[index];
                InfoAboutCollection infoAboutCollection = new InfoAboutCollection(Login, collection_id);
                infoAboutCollection.Show();
            }
            catch
            {
                MessageBox.Show("Выберите коллекцию");
            }
            

        }

        public void ShowPanel()
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
            Movie movie = GetMovieDetails();
            InfoAboutFilm infoAboutFilm = new InfoAboutFilm(movie.Title, movie.PicturePath, movie.Genres, movie.Actors, movie.Countries, movie.Date);
            infoAboutFilm.Show();
        }


        private void pass_btn_Click(object sender, EventArgs e)
        {
            ShowRecomendedMovie();
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
            
        }
            

        private void grayStar2_MouseClick(object sender, MouseEventArgs e)
        {
            OperationsClickStar();
        }

        private void collections_btn_Click(object sender, EventArgs e)
        {
            collections_panel.Visible = true;
            panel_show_collectionfilm.Visible = false;
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
            pass__individual__btn.Visible = true;
            pass_collection_btn.Visible = false;


            ClearLbls();

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

                string query = "SELECT Movies.MovieID, Movies.Title, IFNULL(Movies.Date, '') AS Date,  IFNULL(Movies.PicturePath, '') AS PicturePath, IFNULL(Movies.Link, '') AS Link, GROUP_CONCAT(DISTINCT Film_Genres.Genre SEPARATOR ', ') AS Genres, GROUP_CONCAT(DISTINCT Film_Actors.Actor SEPARATOR ', ') AS Actors, GROUP_CONCAT(DISTINCT Film_Countries.Country SEPARATOR ', ') AS Countries FROM Movies " +
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
                    m.PicturePath = reader.GetString("PicturePath");
                    m.Link = reader.GetString("Link");
                    m.Genres = reader.GetString("Genres");
                    m.Actors = reader.GetString("Actors");
                    m.Countries = reader.GetString("Countries");

                    
                }

                reader.Close();

                connection.Close();
            }
            if (!dateinterval_info.Text.Equals("") || !genre_info.Text.Equals("") || !countries_info.Text.Equals("") || !actors_info.Text.Equals(""))
            {
                reset_stats_btn.Visible = true;
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

        private void pass_filtration_btn_Click(object sender, EventArgs e)
        {
           
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        // Методы для работы с подброками приложения
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
            reset_stats_btn.Visible = true;
            genre_info.Text = "Комедия";
            collections_panel.Visible = false;
            CollectionMovies.Clear();
            CollectionMoviesList.Clear();
            pass_collection_btn.Visible = true;
            pass__individual__btn.Visible = false;
            IsIndividual = false;
            IsNotIndividual = true;
            FillFilmsList(CollectionMovies, CollectionMoviesList, "Комедия");
            ShowInfoInLblForCollection();
        }

        private void adventure_btn_Click(object sender, EventArgs e)
        {
            collections_panel.Visible = false;
            genre_info.Text = "Приключенческий фильм";
            reset_stats_btn.Visible = true;
            CollectionMovies.Clear();
            CollectionMoviesList.Clear();
            IsNotIndividual = true;
            pass_collection_btn.Visible = true;
            pass__individual__btn.Visible = false;
            IsIndividual = false;
            FillFilmsList(CollectionMovies, CollectionMoviesList, "Приключенческий фильм");
            ShowInfoInLblForCollection();
        }

        private void action_btn_Click(object sender, EventArgs e)
        {
            collections_panel.Visible = false;
            reset_stats_btn.Visible = true;
            genre_info.Text = "Боевик";
            CollectionMovies.Clear();
            IsNotIndividual = true;
            CollectionMoviesList.Clear();
            pass_collection_btn.Visible = true;
            pass__individual__btn.Visible = false;
            IsIndividual = false;
            FillFilmsList(CollectionMovies, CollectionMoviesList, "Боевик");
            ShowInfoInLblForCollection();
        }

        private void fantasy_btn_Click(object sender, EventArgs e)
        {
            collections_panel.Visible = false;
            reset_stats_btn.Visible = true;
            CollectionMovies.Clear();
            genre_info.Text = "Фантастический фильм";
            CollectionMoviesList.Clear();
            IsNotIndividual = true;
            pass_collection_btn.Visible = true;
            pass__individual__btn.Visible = false;
            IsIndividual = false;
            FillFilmsList(CollectionMovies, CollectionMoviesList, "Фантастический фильм");
            ShowInfoInLblForCollection();
        }

        private void detective_btn_Click(object sender, EventArgs e)
        {
            collections_panel.Visible = false;
            CollectionMovies.Clear();
            CollectionMoviesList.Clear();
            genre_info.Text = "Детектив";
            reset_stats_btn.Visible = true;
            IsNotIndividual = true;
            pass_collection_btn.Visible = true;
            pass__individual__btn.Visible = false;
            IsIndividual = false;
            FillFilmsList(CollectionMovies, CollectionMoviesList, "Детектив");
            ShowInfoInLblForCollection();
        }

        private void history_btn_Click(object sender, EventArgs e)
        {
            collections_panel.Visible = false;
            CollectionMovies.Clear();
            genre_info.Text = "Исторический фильм";
            CollectionMoviesList.Clear();
            reset_stats_btn.Visible = true;
            pass_collection_btn.Visible = true;
            pass__individual__btn.Visible = false;
            IsNotIndividual = true;
            IsIndividual = false;
            FillFilmsList(CollectionMovies, CollectionMoviesList, "Исторический фильм");
            ShowInfoInLblForCollection();
        }

        private void add_country_Click(object sender, EventArgs e)
        {
            collections_panel.Visible = false;
        }

        private void pass_collection_btn_Click(object sender, EventArgs e)
        {
            CollectionMoviesList.RemoveAt(0);
            if (CollectionMoviesList.Count == 0) 
            { 
                foreach (Movie movie in CollectionMovies) 
                { 
                    CollectionMoviesList.Add(movie);
                }
            }
            ShowInfoInLblForCollection();
        }

        private void title_lbl_Click(object sender, EventArgs e)
        {

        }

        private void reset_stats_btn_Click(object sender, EventArgs e)
        {
            pass_collection_btn.Visible = false;
            pass__individual__btn.Visible = true;
            ShowRecomendedMovie();
            

        }

        private void reset_stats_btn_MouseEnter(object sender, EventArgs e)
        {
            reset_stats_btn.ForeColor = Color.FromArgb(133, 162, 167);
        }


        private void reset_stats_btn_MouseLeave(object sender, EventArgs e)
        {
            reset_stats_btn.ForeColor = Color.FromArgb(64, 64, 64);
        }

        private void add_to_favorites_btn_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);

            connection.Open();

            string collectionName = "Избранное";
            string getCollectionIdSql = "SELECT ID FROM users_collections WHERE Collection_name = @collectionName";
            MySqlCommand getCollectionIdCmd = new MySqlCommand(getCollectionIdSql, connection);
            getCollectionIdCmd.Parameters.AddWithValue("@collectionName", collectionName);
            int collectionId = Convert.ToInt32(getCollectionIdCmd.ExecuteScalar());

            string checkMovieSql = "SELECT COUNT(*) FROM movies_collections WHERE CollectionID=@collectionId AND MovieID=@movieId";
            MySqlCommand checkMovieCmd = new MySqlCommand(checkMovieSql, connection);
            checkMovieCmd.Parameters.AddWithValue("@collectionId", collectionId);
            checkMovieCmd.Parameters.AddWithValue("@movieId", MovieID);
            int count = Convert.ToInt32(checkMovieCmd.ExecuteScalar());

            if (count > 0)
            {
                MessageBox.Show("Фильм уже в списке ваших любимых");
                connection.Close();
                return;
            }

            string addToCollectionSql = "INSERT INTO movies_collections (CollectionID, MovieID) VALUES (@collectionId, @movieId)";
            MySqlCommand addToCollectionCmd = new MySqlCommand(addToCollectionSql, connection);
            addToCollectionCmd.Parameters.AddWithValue("@collectionId", collectionId);
            addToCollectionCmd.Parameters.AddWithValue("@movieId", MovieID);
            addToCollectionCmd.ExecuteNonQuery();

            connection.Close();
            MessageBox.Show("Фильм успешно добавлен в список ваших любимых");
        }

        private void picture_poster_forcollection_MouseEnter(object sender, EventArgs e)
        {
            poster_substrate.Visible = true;
        }

        private void picture_poster_forcollection_MouseLeave(object sender, EventArgs e)
        {
            poster_substrate.Visible = false;
        }

        private void picture_poster_forcollection_Click(object sender, EventArgs e)
        {
            Process.Start(LinkForCollection);
        }

        private void close_showing_collection_film_btn_Click(object sender, EventArgs e)
        {
            panel_show_collectionfilm.Visible = false;
        }

        private void collapse_pb_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void expand_pb_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            expand_pb.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            decrease_btn.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            collapse_pb.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            api_btn.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            collections_btn.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            substrate_collection.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            frame_api.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            frame_collapse.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            frame_decrease.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            frane_expand.Anchor = AnchorStyles.Top | AnchorStyles.Left;


        }

        private void decrease_btn_MouseEnter(object sender, EventArgs e)
        {
            frame_decrease.Visible= true;
        }

        private void decrease_btn_MouseLeave(object sender, EventArgs e)
        {
            frame_decrease.Visible = false;

        }

        private void decrease_btn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }
    }
}









