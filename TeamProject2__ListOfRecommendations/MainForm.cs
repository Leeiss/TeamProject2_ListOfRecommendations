using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Diagnostics;
using System.Xml.Linq;
using System.Data;
using System.Linq;
using NLog;

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
        private static Logger logger = LogManager.GetCurrentClassLogger();
        
        private bool SelectDate1 = false;
        private bool SelectGenre = false;
        private bool SelectActor = false;
        private bool SelectCountry = false;
        private bool IsIndividual = true;//если подборка фильмов происходит на основе предпочтений пользователя
        private bool IsNotIndividual = false;//если подборка фильма происходит из готовых коллекций (коллекций приложения по жанрам)

        private List<string> Genres = new List<string>();
        private List<string> Actors = new List<string>();
        private List<string> Countries = new List<string>();
        private List<PictureBox> starBoxes = new List<PictureBox>();
        private List<Movie> CollectionMovies = new List<Movie>(); //лист для работы с готовыми коллекциями приложения
        private List<Movie> CollectionMoviesList = new List<Movie>();//лист для работы с готовыми коллекциями приложения
        private List<int> CollectionsIds = new List<int>();//лист для работы с готовыми коллекциями приложения
        private List<Movie> TopRatedMovies = new List<Movie>(); //лист, в котором хранится 5 фильмов с самым высоким рейтингом на данный момент
        private List<Movie> TopRatedFilteredMovies = new List<Movie>(); //лист, в котором хранится 5 фильмов с самым высоким рейтингом с конкретными характеристиками
        List<int> Searching_movieIds = new List<int>();
        List<int> Ids = new List<int>();
        private string datelbl;
        private string actorslbl;
        private string countrieslbl;
        private string genreslbl;
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



        /// <summary>
        /// Заполняет данными о фильме в основной форме
        /// </summary>
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
                logger.Info("Элементы главной формы заполнились данными о фильме из коллекции");
            }
            catch (Exception ex) 
            {
                MessageBox.Show("В базе данных приложения еще нет фильмов с таким жанром");
                logger.Warn("В базе данных нет фильмов с нужным рейтингом: " + ex.Message);
            }

        }
        /// <summary>
        /// вспомогательный метод, который получает информацию о фильме по его id
        /// </summary>
        /// <returns></returns>
        public Movie GetMovieDetails()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=teamproject_listofrecommendations");
                connection.Open();
            

            MySqlCommand command = connection.CreateCommand();
            command.CommandText = @"
        SELECT movies.Title, movies.PicturePath, movies.Link, movies.Date,
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
                string link = reader.GetString("Link");
                string path = reader.GetString("PicturePath");
                string date = reader.GetString("Date");
                string genres = reader.IsDBNull(reader.GetOrdinal("Genres")) ? "" : reader.GetString("Genres");
                string actors = reader.IsDBNull(reader.GetOrdinal("Actors")) ? "" : reader.GetString("Actors");
                string countries = reader.IsDBNull(reader.GetOrdinal("Countries")) ? "" : reader.GetString("Countries");


                result_movie.Date = date;
                result_movie.Title = title;
                result_movie.PicturePath = path;
                result_movie.Genres = genres;
                result_movie.Link = link;
                result_movie.Actors = actors;
                result_movie.Countries = countries;
            }
            reader.Close();

            connection.Close();
                logger.Info("Успешно получены данные фильма по его id");   

            return result_movie;
            }
            catch
            {
                logger.Error("Нет подключения к базе данных");
                return null;
            }

        }

        /// <summary>
        /// Вспомогательный метод для коллекций, который находит все фильмы с нужным жанром
        /// </summary>
        /// <param name="list"></param>
        /// <param name="list1"></param>
        /// <param name="genre"></param>
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
            logger.Info("Найдены все фильмы с нужным жанром");
        }

        /// <summary>
        /// Заполняем label-ы информацией по фильму
        /// </summary>
        /// <param name="movie"></param>
        private void ShowInfoInLbls(Movie movie)
        {
            if (movie != null)
            {
                string year = movie.Date;
                year = year.Remove(0, 6);
                film_title_lbl.Text = $"{movie.Title} ({year})";
                Link = movie.Link;
                try
                {
                    picture_poster.Image = Image.FromFile(movie.PicturePath);
                }
                catch (Exception ex)
                {
                    DialogResult result = MessageBox.Show("К сожалению, путь к постеру фильма устарел или неправильно добавлен.Хотите сообщить службе поддержки об этой проблеме", "Отсутствие постера", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        string subject = $"Отсутствие постера у фильма {film_title_lbl.Text}";
                        string email = "list_of_recomendations@mail.ru";
                        string mailtoCommand = string.Format("mailto:{0}?subject={1}", email, subject);
                        Process.Start(mailtoCommand);
                    }
                    picture_poster.Image = Properties.Resources.безфото;
                    logger.Warn("У постера неправильный путь: " + ex.Message);
                }
                MovieID = movie.MovieID;
            }
            else
            {
                MessageBox.Show("В приложении еще нет фильмов");
            }


        }

        /// <summary>
        /// Показывает информацию по фильму с наивысшим рейтингом
        /// </summary>
        private void ShowRecomendedMovie(Movie movie)
        {
            ShowInfoInLbls(movie);
        }

        /// <summary>
        /// Находит 5 или менее фильмов с самым высоким общим рейтингом
        /// </summary>
        /// <param name="userLogin"></param>
        /// <returns></returns>
        static List<Movie> GetTopRatedMovie(string userLogin)
        {
            try
            {
                connection.Open();

                MySqlCommand command = connection.CreateCommand();
                command.CommandText = "SELECT m.MovieID, m.Title, m.Date, m.PicturePath, m.Link, " +
                    "GROUP_CONCAT(DISTINCT fg.Genre SEPARATOR ', ') as Genres, " +
                    "GROUP_CONCAT(DISTINCT fa.Actor SEPARATOR ', ') as Actors, " +
                    "GROUP_CONCAT(DISTINCT fc.Country SEPARATOR ', ') as Countries, " +
                    "AVG(ugr.RatingGenre) + AVG(uar.RatingActor) as MovieRating " +
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
                    "LIMIT 5";

                command.Parameters.AddWithValue("@userLogin", userLogin);
                List<Movie> topRatedMovies = new List<Movie>();

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Movie topRatedMovie = new Movie();
                        topRatedMovie.MovieID = reader.GetInt32("MovieID");
                        topRatedMovie.Title = reader.GetString("Title");
                        topRatedMovie.Date = reader.GetString("Date");
                        topRatedMovie.PicturePath = reader.GetString("PicturePath");
                        topRatedMovie.Link = reader.GetString("Link");
                        topRatedMovie.Genres = reader.GetString("Genres");
                        topRatedMovie.Actors = reader.GetString("Actors");
                        topRatedMovie.Countries = reader.GetString("Countries");

                        topRatedMovies.Add(topRatedMovie);
                    }
                }

                // Проверяем, сколько фильмов вернул запрос 
                if (topRatedMovies.Count < 5)
                {
                    // Если запрос вернул менее 5 фильмов, выполняем другой запрос, который вернет оставшиеся фильмы с самым высоким рейтингом 
                    int remainingMovies = 5 - topRatedMovies.Count;
                    MySqlCommand command2 = connection.CreateCommand();
                    command2.CommandText = "SELECT m.MovieID, m.Title, m.Date, m.PicturePath, m.Link, " +
                        "GROUP_CONCAT(DISTINCT fg.Genre SEPARATOR ', ') as Genres, " +
                        "GROUP_CONCAT(DISTINCT fa.Actor SEPARATOR ', ') as Actors, " +
                        "GROUP_CONCAT(DISTINCT fc.Country SEPARATOR ', ') as Countries, " +
                        "AVG(ugr.RatingGenre) + AVG(uar.RatingActor) as MovieRating " +
                        "FROM movies m " +
                        "JOIN film_genres fg ON m.MovieID = fg.FilmID " +
                        "JOIN film_actors fa ON m.MovieID = fa.FilmID " +
                        "JOIN film_countries fc ON m.MovieID = fc.FilmID " +
                        "JOIN users_genres_rating ugr ON fg.Genre = ugr.Genrename " +
                        "JOIN users_actors_rating uar ON fa.Actor = uar.Actorname " +
                        "JOIN users u ON u.Login = ugr.Username " +
                        "WHERE u.Login = @userLogin " +
                        "GROUP BY m.MovieID " +
                        "HAVING COUNT(*) = 1 " +  // исключаем уже полученные фильмы 
                        "ORDER BY MovieRating DESC " +
                        "LIMIT " + remainingMovies.ToString();
                    command2.Parameters.AddWithValue("@userLogin", userLogin);

                    using (MySqlDataReader reader = command2.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Movie topRatedMovie = new Movie();
                            topRatedMovie.MovieID = reader.GetInt32("MovieID");
                            topRatedMovie.Title = reader.GetString("Title");
                            topRatedMovie.Date = reader.GetString("Date");
                            topRatedMovie.PicturePath = reader.GetString("PicturePath");
                            topRatedMovie.Link = reader.GetString("Link");
                            topRatedMovie.Genres = reader.GetString("Genres");
                            topRatedMovie.Actors = reader.GetString("Actors");
                            topRatedMovie.Countries = reader.GetString("Countries");

                            topRatedMovies.Add(topRatedMovie);
                        }
                    }
                }

                connection.Close();
                logger.Info("Успешно получены рекомендуемы для пользователя фильмы");
                return topRatedMovies;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка");
                logger.Error("Не удается получить рекомендуемые фильмы для пользователя: "+ex.Message);
                return null;
                
            }
            
        }

        static List<Movie> AllMovies(string userLogin)
        {
            try
            {
                connection.Open();

                MySqlCommand command = connection.CreateCommand();
                command.CommandText = "SELECT m.MovieID, m.Title, m.Date, m.PicturePath, m.Link, " +
                    "GROUP_CONCAT(DISTINCT fg.Genre SEPARATOR ', ') as Genres, " +
                    "GROUP_CONCAT(DISTINCT fa.Actor SEPARATOR ', ') as Actors, " +
                    "GROUP_CONCAT(DISTINCT fc.Country SEPARATOR ', ') as Countries, " +
                    "AVG(ugr.RatingGenre) + AVG(uar.RatingActor) as Rating " + // добавленное поле Rating
                    "FROM movies m " +
                    "JOIN film_genres fg ON m.MovieID = fg.FilmID " +
                    "JOIN film_actors fa ON m.MovieID = fa.FilmID " +
                    "JOIN film_countries fc ON m.MovieID = fc.FilmID " +
                    "JOIN users_genres_rating ugr ON fg.Genre = ugr.Genrename " +
                    "JOIN users_actors_rating uar ON fa.Actor = uar.Actorname " +
                    "JOIN users u ON u.Login = ugr.Username " +
                    "WHERE u.Login = @userLogin " +
                    "GROUP BY m.MovieID ";

                command.Parameters.AddWithValue("@userLogin", userLogin);
                List<Movie> allMovies = new List<Movie>();

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Movie topRatedMovie = new Movie();
                        topRatedMovie.MovieID = reader.GetInt32("MovieID");
                        topRatedMovie.Title = reader.GetString("Title");
                        topRatedMovie.Date = reader.GetString("Date");
                        topRatedMovie.PicturePath = reader.GetString("PicturePath");
                        topRatedMovie.Link = reader.GetString("Link");
                        topRatedMovie.Genres = reader.GetString("Genres");
                        topRatedMovie.Actors = reader.GetString("Actors");
                        topRatedMovie.Countries = reader.GetString("Countries");
                        topRatedMovie.OverallRating = reader.GetDouble("Rating");

                        allMovies.Add(topRatedMovie);
                    }
                }

                connection.Close();
                logger.Info("Данные о фильмах приложения успешно выгружены");
                return allMovies;
            }
            catch (Exception ex)
            {
                logger.Error("Не удается получить фильмы с базы данных: " + ex);
                return null;
            }
            
        }

        /// <summary>
        /// Выводит информацию по подборкам пользователя в лист
        /// </summary>
        private void ShowUserCollectionsList()
        {
            try
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
                logger.Info("Информация по подборкам пользователя успешно получена");
            }
            catch
            {
                logger.Error("Не удается получить подборки пользователя");
            }
            
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            date1.MaxDate = dt;
            TopRatedMovies.Clear();
            TopRatedMovies = GetTopRatedMovie(Login);
            TopRatedMovies = GetTopRatedMovie(Login);
            if (TopRatedMovies.Count == 0)
            {
                MessageBox.Show("К сожалению, у нас пока нет нужных для вас фильмов");
                logger.Info("Не удается получить список рекомендуемых фильмов для пользователя");
            }
            else
            {
                ShowRecomendedMovie(TopRatedMovies[0]);
            }
            ShowUserCollectionsList();

            conn = new MySqlConnection(connectionString);


            CheckAdminRights(Login, add_film_btn);

            IEnumerable<string> actors = doc.Element("for_lists").Element("actors").Elements("actor").Select(x => x.Value);
            foreach (string actor in actors)
            {
                actors_list.Items.Add(actor);
            }

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


       
        private void profile_pb_Click(object sender, EventArgs e)
        {
            ProfileMenagement profileMenagement = new ProfileMenagement(Login);
            profileMenagement.Location = new Point(this.Location.X - 20, this.Location.Y - 20);
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
            search_genre_btn.Text = "Поиск по списку..";
            search_actor_tb.Text = "Поиск по списку..";
            search_country_tb.Text = "Поиск по списку..";
            star_btn.Visible = false;
            actors_list.SelectedItem = null;
            genres_list.SelectedItem = null;
            countries_list.SelectedItem = null;
            date1.Text = date1.MaxDate.ToString();
            add_actor_btn.Visible = false;
            add_country_btn.Visible = false;
            add_genre_btn.Visible = false;
            Ids.Clear();
            Actors.Clear();
            Genres.Clear();
            Date = null;
            Countries.Clear();
            closing_panel.Visible = true;
            if (TopRatedFilteredMovies != null)
                TopRatedFilteredMovies.Clear();

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


        /// <summary>
        /// Вспомогательный метод для того, чтобы проверить, является ли пользователь администратором
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        private int isAdmin(string login)
        {
            try
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
                logger.Info("Права админа для пользователя проверены");

                return adminRights;
            }
            catch
            {
                logger.Error("Не удается получить данные о правах админа из-за ошибки в базе данных");
                return 0;
            }
        }

        /// <summary>
        ///  Проверяет, является ли пользователь администратором
        /// </summary>
        /// <param name="login"></param>
        /// <param name="button"></param>
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
            try
            {
                Process.Start(Link);
                logger.Info("Переход по ссылке на фильм был успешен");
            }
            catch
            {
                DialogResult result = MessageBox.Show("К сожалению, ссылка на данный фильм устарела или неправильно добавлена.Хотите сообщить службе поддержки об этой проблеме", "Отсутствие ссылки", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    string subject = $"Отсутствие cсылки у фильма";
                    string email = "list_of_recomendations@mail.ru";
                    string mailtoCommand = string.Format("mailto:{0}?subject={1}", email, subject);
                    Process.Start(mailtoCommand);
                }
                logger.Error("Ссылка на фильм недействительна");
            }
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
            TopRatedMovies.RemoveAt(0);
            if (TopRatedMovies.Count == 0)
            {
                TopRatedMovies = GetTopRatedMovie(Login);
            }
            ShowRecomendedMovie(TopRatedMovies[0]);
            for (int i = 0; i <= 9; i++)
            {
                starBoxes[i].Image = Properties.Resources.grayStar;
            }
            star_btn.Visible = false;

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
            for (int i = 0; i <= 9; i++)
            {
                starBoxes[i].Image = Properties.Resources.grayStar;
            }
            for (int i = 0; i <= selectedIndex; i++)
            {
                starBoxes[i].Image = Properties.Resources.star;
            }
            Rating = selectedIndex + 1;
        }

        private void grayStar2_MouseClick(object sender, MouseEventArgs e)
        {
            OperationsClickStar();
        }

        private void collections_btn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 9; i++)
            {
                starBoxes[i].Image = Properties.Resources.grayStar;
            }
            collections_panel.Visible = true;
            panel_show_collectionfilm.Visible = false;
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
            if (!Genres.Contains((genres_list.SelectedItem.ToString())))
            {
                Genres.Add(genres_list.SelectedItem.ToString());
                SelectGenre = true;
                ShowBtn();
                MessageBox.Show("Жанр добавлен в характеристики фильмов");

            }
            else
            {
                MessageBox.Show("Данный жанр уже была добавлен в характеристики фильмов");
            }

        }

        private void add_country_btn_Click(object sender, EventArgs e)
        {
            if (!Countries.Contains((countries_list.SelectedItem.ToString())))
            {
                Countries.Add(countries_list.SelectedItem.ToString());
                SelectCountry = true;
                ShowBtn();
                MessageBox.Show("Страна добавлена в характеристики фильмов");
            }
            else
            { 
                MessageBox.Show("Данная страна уже была добавлена в характеристики фильмов");
            }

        }

        private void date1_ValueChanged(object sender, EventArgs e)
        {
            SelectDate1 = true;
            Date = date1.Value.ToString("dd.MM.yyyy");
            if (date1.Checked)
            ShowBtn();

        }

        private void add_actor_btn_Click(object sender, EventArgs e)
        {
            if (!Actors.Contains(actors_list.SelectedItem.ToString()))
            {
                Actors.Add(actors_list.SelectedItem.ToString());
                SelectActor = true;
                ShowBtn();
                MessageBox.Show("Актер добавлен в характеристики фильмов");
            }
            else
            {
                MessageBox.Show("Данный актер уже был добавлен в характеристики фильмов");
            }

        }

        private List<int> GetFilteredMoviesIds()
        {
            try
            {
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
                        Ids.Add(reader.GetInt32("MovieID"));

                    }

                    reader.Close();

                    connection.Close();
                    logger.Info("Получен список id фильмов, подходящих под нужные характеристики. Количество найденных - "+Ids.Count());
                    return Ids;
                }
            }
            catch (Exception ex)
            {
                logger.Info("Не удается сделать фильтрацию фильмов: "+ex);
                return null;
            }
        }


        /// <summary>
        /// Метод, возвращающий лист с фильмами с наивысшими рейтингами, подходящие под конкретные характеристики
        /// </summary>
        private List<Movie> GetRatedFiltredMovies()
        {
           
            List<Movie> allMovies = AllMovies(Login);
            List<Movie> movies = new List<Movie>();
            if (Ids.Count > 0 && Ids.Count >= 5)
            {
                foreach (int id in Ids)
                {
                    foreach (Movie movie in allMovies)
                    {
                        if (movie.MovieID == id)
                            movies.Add(movie);
                    }
                }
                List<Movie> resultlist1 = movies.OrderBy(m => m.OverallRating).ToList();
                List<Movie> resultlist = resultlist1.GetRange(0, 5);
                logger.Info("Фильмы с конкретными характеристиками отсортированы по общему рейтингу");

                return resultlist;
            }
            else if (Ids.Count > 0 && Ids.Count < 5)
            {
                foreach (int id in Ids)
                {
                    foreach (Movie movie in allMovies)
                    {
                        if (movie.MovieID == id)
                            movies.Add(movie);
                    }
                }
                List<Movie> resultlist1 = movies.OrderBy(m => m.OverallRating).ToList();
                logger.Info("Фильмы с конкретными характеристиками отсортированы по общему рейтингу");

                return resultlist1;
            }

            else
            {
                logger.Info("Не найдены фильмы с введенными характеристиками");
                return null;
            }
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            Ids = GetFilteredMoviesIds();
            pass__individual__btn.Visible = false;
            pass_filtration_btn.Visible = true;
            pass_collection_btn.Visible = false;
            closing_panel.Visible = false;

            for (int i = 0; i <= 9; i++)
            {
                starBoxes[i].Image = Properties.Resources.grayStar;
            }

            genre_info.Text = string.Join(",", Genres);
            actors_info.Text = string.Join(",", Actors);
            countries_info.Text = string.Join(",", Countries);
            dateinterval_info.Text = Date;

            if (TopRatedFilteredMovies != null)
                TopRatedFilteredMovies.Clear();
            TopRatedFilteredMovies = GetRatedFiltredMovies();
            if (TopRatedFilteredMovies == null)
            {
                MessageBox.Show("К сожалению, не нашлось фильмов с такими характеристиками");
            }
            else
            {
                ShowRecomendedMovie(TopRatedFilteredMovies[0]);
            }
            datelbl = Date;
            actorslbl = string.Join(",", Actors);
            countrieslbl = string.Join(",", Countries);
            genreslbl = string.Join(",", Genres);

            dateinterval_info.Text = Date;
            genre_info.Text = string.Join(",", Genres);
            actors_info.Text = string.Join(",", Actors);
            countries_info.Text = string.Join(",", Countries);
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
            pass_filtration_btn.Visible = false;
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
            pass_filtration_btn.Visible = false;
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
            pass_filtration_btn.Visible = false;
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
            pass_filtration_btn.Visible = false;
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
            pass_filtration_btn.Visible = false;
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
            pass_filtration_btn.Visible = false;
            pass__individual__btn.Visible = false;
            IsNotIndividual = true;
            IsIndividual = false;
            FillFilmsList(CollectionMovies, CollectionMoviesList, "Исторический фильм");
            ShowInfoInLblForCollection();
        }
        // Методы для работы с подброками приложения (конец)

        private void add_country_Click(object sender, EventArgs e)
        {
            collections_panel.Visible = false;
        }

        private void pass_collection_btn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 9; i++)
            {
                starBoxes[i].Image = Properties.Resources.grayStar;
            }

            CollectionMoviesList.RemoveAt(0);
            if (CollectionMoviesList.Count == 0)
            {
                foreach (Movie movie in CollectionMovies)
                {
                    CollectionMoviesList.Add(movie);
                }
            }
            ShowInfoInLblForCollection();
            star_btn.Visible = false;
        }

        private void reset_stats_btn_Click(object sender, EventArgs e)
        {
            search_genre_btn.Text = "Поиск по списку..";
            search_actor_tb.Text = "Поиск по списку..";
            search_country_tb.Text = "Поиск по списку..";
            actors_list.SelectedItem = null;
            genres_list.SelectedItem = null;
            countries_list.SelectedItem = null;
            star_btn.Visible=false;
            add_actor_btn.Visible = false;
            date1.Text = date1.MaxDate.ToString();
            add_country_btn.Visible = false;
            add_genre_btn.Visible = false;
            for (int i = 0; i <= 9; i++)
            {
                starBoxes[i].Image = Properties.Resources.grayStar;
            }
            Ids.Clear();
            dateinterval_info.Text = "";
            genre_info.Text = "";
            actors_info.Text = "";
            countries_info.Text = "";
            pass_collection_btn.Visible = false;
            pass__individual__btn.Visible = true;
            ShowRecomendedMovie(TopRatedMovies[0]);

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
            try
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
            catch
            {
                logger.Error("Пользователь не может добавить фильм в избранное");
            }
           
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

        private void decrease_btn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void upper_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pass_filtration_btn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 9; i++)
            {
                starBoxes[i].Image = Properties.Resources.grayStar;
            }

            dateinterval_info.Text = datelbl;
            genre_info.Text = genreslbl;
            actors_info.Text = actorslbl;
            countries_info.Text = countrieslbl;
            if (TopRatedFilteredMovies != null)
                TopRatedFilteredMovies.RemoveAt(0);
            if (TopRatedFilteredMovies.Count == 0)
            {
                TopRatedFilteredMovies = GetRatedFiltredMovies();
            }
            ShowRecomendedMovie(TopRatedFilteredMovies[0]);
            star_btn.Visible = false;
        }


        private void star_btn_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection(connectionString);


                string commandText = "UPDATE users_actors_rating " +
                                     "SET RatingActor = (RatingActor * (MarksCount + 1) + @Rating) / (MarksCount + 2), " +
                                     "MarksCount = MarksCount + 1 " +
                                     "WHERE Username = @Username AND Actorname IN (" +
                                     "SELECT Actor FROM film_actors WHERE FilmId = @FilmId)";
                MySqlCommand command = new MySqlCommand(commandText, connection);

                command.Parameters.AddWithValue("@Rating", Rating);
                command.Parameters.AddWithValue("@Username", Login);
                command.Parameters.AddWithValue("@FilmId", MovieID);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                commandText = "UPDATE users_genres_rating " +
                              "SET RatingGenre = (RatingGenre * (MarksCount + 1) + @Rating) / (MarksCount + 2), " +
                              "MarksCount = MarksCount + 1 " +
                              "WHERE Username = @Username AND Genrename IN (" +
                              "SELECT Genre FROM film_genres WHERE FilmId = @FilmId)";
                command = new MySqlCommand(commandText, connection);
                command.Parameters.AddWithValue("@Rating", Rating);
                command.Parameters.AddWithValue("@Username", Login);
                command.Parameters.AddWithValue("@FilmId", MovieID);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Оценка фильму поставлена");
                logger.Info("Поставлена оценка фильму c id" + MovieID);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка");
                logger.Error(ex);
            }
            
        }
       private void search_tb_Click(object sender, EventArgs e)
        {
            search_tb.Text = "";
        }

        private void search_tb_MouseEnter(object sender, EventArgs e)
        {
            frame_searching.Visible = true;
        }

        private void search_tb_MouseLeave(object sender, EventArgs e)
        {
            frame_searching.Visible = false;
        }


        private void search_tb_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {

                    if (search_tb.Text.Equals(""))
                    {
                        MessageBox.Show("Некорректный запрос");
                    }
                    else
                    {
                        string searchText = search_tb.Text.Trim();
                        string query = "SELECT MovieID, Title FROM movies WHERE Title LIKE @SearchText";
                        search_results_lb.Items.Clear();

                        using (MySqlConnection conn = new MySqlConnection(connectionString))
                        {
                            conn.Open();
                            MySqlCommand cmd = new MySqlCommand(query, conn);
                            cmd.Parameters.AddWithValue("@SearchText", "%" + searchText + "%");
                            MySqlDataReader reader = cmd.ExecuteReader();
                            while (reader.Read())
                            {
                                int movieId = reader.GetInt32(0);
                                string title = reader.GetString(1);
                                search_results_lb.Items.Add(title);
                                Searching_movieIds.Add(movieId);
                            }
                            reader.Close();
                        }
                        if (search_results_lb == null)
                        {
                            MessageBox.Show("Ничего не найдено");
                        }
                        else
                        {
                            search_results_lb.Visible = true;
                        }

                        logger.Info("Совершился поиск фильма");
                    }
                }
            
            }
            catch
            {
                logger.Error("Не работает поиск фильмов");
            }
        }

        private void search_tb_TextChanged(object sender, EventArgs e)
        {
            if (search_tb.Text == "")
            {
                pass__individual__btn.Visible = true;
                if (TopRatedMovies.Count == 0)
                {
                    MessageBox.Show("К сожалению, у нас пока нет нужных для вас фильмов");
                }
                else
                {
                    panel_show_collectionfilm.Visible = false;
                    ShowRecomendedMovie(TopRatedMovies[0]);
                }
            }
        }

        private void MainForm_Click(object sender, EventArgs e)
        {
            if (search_results_lb.Visible)
            {
                if (!search_results_lb.Bounds.Contains(this.PointToClient(Cursor.Position)))
                {
                    search_results_lb.Visible=false;
                    search_results_lb.Text = "Поиск фильмов..";
                    pass__individual__btn.Visible = true;
                    

                }
            }
            
        }
            
        private void search_results_lb_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                close_showing_collection_film_btn.Visible = false;
                pass__individual__btn.Visible = false;
                pass_filtration_btn.Visible = false;
                pass_collection_btn.Visible=false;
                int index = search_results_lb.SelectedIndex;
                search_results_lb.Visible = false;
                int id = Searching_movieIds[index];
                MovieID = id;
                panel_show_collectionfilm.Visible = true;
                Movie movie = GetMovieDetails();
                string year = movie.Date;
                year = year.Remove(0, 6);
                collections_panel.Visible = false;
                panel_show_collectionfilm.Visible = true;
                LinkForCollection = movie.Link;
                title_film_fromcollection.Text = $"{movie.Title.ToUpper()} ({year})";
                genres_collectionfilm.Text = movie.Genres;
                date_collectionfilm.Text = movie.Date;
                actors_collectionfilm.Text = movie.Actors;
                countries_collectionfilm.Text = movie.Countries;
                try
                {

                    picture_poster_forcollection.Image = System.Drawing.Image.FromFile(movie.PicturePath);

                }
                catch
                {
                    MessageBox.Show("Некорректный адрес изображения");
                    logger.Warn("У фильма некорректный путь к фотографии постера");
                }


            }
            catch
            {
                MessageBox.Show("Ничего не найдено");
            }
        }
    }
}









