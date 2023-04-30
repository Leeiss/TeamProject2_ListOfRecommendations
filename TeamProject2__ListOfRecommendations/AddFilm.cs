using MySql.Data.MySqlClient;
using NLog;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Schema;
using TeamProject1_ToDoList.Classes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace TeamProject2__ListOfRecommendations
{
    public partial class AddFilm : Form
    {
        public AddFilm()
        {
            InitializeComponent();
        }
        private string connectionString = "server=localhost;port=3306;username=root;password=root;database=teamproject_listofrecommendations";
        private bool ImageSelect = false;
        private bool GenreSelect = false;
        private bool ActorSelect = false;
        private bool DateSelect = false;
        private bool CountrySelect = false;
        private string selectedFile;
        private string chosenDate;
        private List<string> Genres = new List<string>();
        private List<string> Actors = new List<string>();
        private List<string> Countries = new List<string>();
        private string Xmlpath = "@./../../../ForLists.xml";
        XDocument doc = XDocument.Load("@./../../../ForLists.xml");
        private static Logger logger = LogManager.GetCurrentClassLogger();

        private void AddFilm_Load(object sender, EventArgs e)
        {
            selected_date.MaxDate = DateTime.Now;
            try
            {
                IEnumerable<string> actors = doc.Element("for_lists").Element("actors").Elements("actor").Select(x => x.Value);

                foreach (string actor in actors)
                {
                    actors_list.Items.Add(actor);
                }
                logger.Info("Список актеров добавлен в лист");
            }
            catch (Exception ex) 
            { 
                logger.Error("Проблемы с xml-файлом: "+ex.ToString());
            }
            
            var screenWidth = Screen.PrimaryScreen.Bounds.Width;
            var screenHeight = Screen.PrimaryScreen.Bounds.Height;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point((screenWidth - this.Width) / 2, (screenHeight - this.Height) / 2);

            int buttonOffset = 30;
            int formWidth = add_film_btn.Location.X + add_film_btn.Width + buttonOffset; // Вычисляем желаемую ширину формы
            int formHeight = add_film_btn.Location.Y + add_film_btn.Height + buttonOffset; // Вычисляем желаемую высоту формы
            this.ClientSize = new Size(formWidth, formHeight);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void YesNoShowBtn()
        {
            if (ImageSelect == true && GenreSelect == true && ActorSelect == true && DateSelect == true && CountrySelect == true)
            {
                add_film_btn.Visible = true;
            }
        }

        private void search_genre_Click(object sender, EventArgs e)
        {
            search_genre.Text = string.Empty;
        }

        private void search_country_Click(object sender, EventArgs e)
        {
            search_country.Text = string.Empty;
        }

        private void search_actor_Click(object sender, EventArgs e)
        {
            search_actor.Text = string.Empty;
        }

        private void SearchInList(System.Windows.Forms.ListBox list, string searchText)
        {
            int index = list.FindString(searchText);

            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                list.SelectedIndex = index;
            }
        }
        private void search_genre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SearchInList(genres_list, search_genre.Text);
            }
        }

        private void title_tb_Click(object sender, EventArgs e)
        {
            title_tb.Text = string.Empty;
        }

        private void search_country_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SearchInList(countries_list, search_country.Text);
            }
        }

        private void search_actor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SearchInList(actors_list, search_actor.Text);
            }
        }

        private void genres_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            add_genre.Visible = true;
        }

        private void countries_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            add_country.Visible = true;
        }

        private void actors_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            add_actor.Visible = true;
        }

        private void select_poster_btn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog fileDialog = new OpenFileDialog();
                fileDialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    ImageSelect = true;
                    selectedFile = fileDialog.FileName;
                }
                YesNoShowBtn();
                logger.Info("Добавлен фильм в базу данных");
            }
            catch (Exception ex)
            {
                logger.Error("Не удается добавить фильм: "+ex);
            }
           
        }

        private void add_genre_Click(object sender, EventArgs e)
        {
            if (!Genres.Contains(genres_list.SelectedItem))
            {
                GenreSelect = true;
                Genres.Add(genres_list.SelectedItem.ToString());
                MessageBox.Show("Выбранный вами жанр добавлен в информацию о жанрах фильма");
                YesNoShowBtn();
            }
            else
            {
                MessageBox.Show("Данный жанр уже был добавлен");
            }
        }

        private void add_country_Click(object sender, EventArgs e)
        {
            if (!Countries.Contains(countries_list.SelectedItem))
            {
                CountrySelect = true;
                Countries.Add((string)countries_list.SelectedItem);
                MessageBox.Show("Выбранная вами страна добавлена в информацию странах-производителях фильма");
                YesNoShowBtn();
            }
            else
            {
                MessageBox.Show("Данная страна уже была добавлена");
            }
        }

        private void add_actor_Click(object sender, EventArgs e)
        {
            if (!Actors.Contains(actors_list.SelectedItem))
            {
                ActorSelect = true;
            Actors.Add((string)actors_list.SelectedItem);
            MessageBox.Show("Выбранное вами имя актера добавлено в информацию об актерах фильма");
            YesNoShowBtn();
            }
            else
            {
                MessageBox.Show("Данный актер уже был добавлен");
            }
        }

        private void selected_date_ValueChanged(object sender, EventArgs e)
        {
            DateSelect = true;
            chosenDate = selected_date.Value.ToString("dd.MM.yyyy");
            YesNoShowBtn();
        }

        private void add_film_btn_Click(object sender, EventArgs e)
        {
            if (!title_tb.Text.Equals("") && !title_tb.Text.Equals("Введите название") && !link_tb.Text.Equals("") && !link_tb.Text.Equals("Введите ссылку"))
            {
                DataBase db = new DataBase();
                db.OpenConnection();

                // Проверяем, есть ли в базе фильм с таким же названием 
                MySqlCommand command1 = new MySqlCommand("SELECT * FROM movies WHERE Title = @Title", db.GetConnection());
                command1.Parameters.Add("@Title", MySqlDbType.VarChar).Value = title_tb.Text;
                int titleCount = Convert.ToInt32(command1.ExecuteScalar());

                // Проверяем, есть ли в базе фильм с такой же датой выхода 
                MySqlCommand command2 = new MySqlCommand("SELECT * FROM movies WHERE Date = @Date", db.GetConnection());
                command2.Parameters.Add("@Date", MySqlDbType.VarChar).Value = chosenDate;
                int dateCount = Convert.ToInt32(command2.ExecuteScalar());

                if (titleCount > 0 && dateCount > 0)
                {
                    // Если уже есть фильм с таким названием и датой выхода, выводим сообщение 
                    MessageBox.Show("Данный фильм уже добавлен в приложение");
                }
                else
                {
                    // Если фильм уникален по названию и дате выхода, добавляем его в базу 
                    AddMovie();
                    MessageBox.Show("Фильм успешно добавлен");
                    this.Close();
                }

                db.CloseConnection();
            }
            else
            {
                MessageBox.Show("Пожалуйста, заполните все поля");
            }
        }


        private void AddMovie()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string insertFilmQuery = "INSERT INTO movies (`Title`, `Date` , `PicturePath`, `Link`) VALUES(@Title, @Date, @PicturePath, @Link)";
                    using (MySqlCommand command = new MySqlCommand(insertFilmQuery, connection))
                    {
                        command.Parameters.Add("@Title", MySqlDbType.VarChar).Value = title_tb.Text;
                        command.Parameters.Add("@Date", MySqlDbType.VarChar).Value = chosenDate;
                        command.Parameters.Add("@PicturePath", MySqlDbType.VarChar).Value = selectedFile;
                        command.Parameters.Add("@Link", MySqlDbType.VarChar).Value = link_tb.Text;

                        command.ExecuteNonQuery();
                        int filmId = Convert.ToInt32(command.LastInsertedId);

                        string insertGenreQuery = "INSERT INTO film_genres (Genre, FilmId) VALUES (@Genre, @FilmId)";
                        using (MySqlCommand genreCommand = new MySqlCommand(insertGenreQuery, connection))
                        {
                            foreach (string genre in Genres)
                            {
                                genreCommand.Parameters.Clear();
                                genreCommand.Parameters.AddWithValue("@FilmId", filmId);
                                genreCommand.Parameters.AddWithValue("@Genre", genre);
                                genreCommand.ExecuteNonQuery();
                            }
                        }

                        string insertActorQuery = "INSERT INTO film_actors (Actor, FilmId) VALUES (@Actor, @FilmId)";
                        using (MySqlCommand actorCommand = new MySqlCommand(insertActorQuery, connection))
                        {
                            foreach (string actor in Actors)
                            {
                                actorCommand.Parameters.Clear();
                                actorCommand.Parameters.AddWithValue("@FilmId", filmId);
                                actorCommand.Parameters.AddWithValue("@Actor", actor);
                                actorCommand.ExecuteNonQuery();
                            }
                        }

                        string insertCountryQuery = "INSERT INTO film_countries (Country, FilmId) VALUES (@Country, @FilmId)";
                        using (MySqlCommand countryCommand = new MySqlCommand(insertCountryQuery, connection))
                        {
                            foreach (string country in Countries)
                            {
                                countryCommand.Parameters.Clear();
                                countryCommand.Parameters.AddWithValue("@FilmId", filmId);
                                countryCommand.Parameters.AddWithValue("@Country", country);
                                countryCommand.ExecuteNonQuery();
                            }
                        }
                    }
                    connection.Close();
                    logger.Info("Фильм успешно добавлен");
                }
            }
            catch
            {
                logger.Error("Ошибка в добавлении фильма");
            }
        }
        private void add_actor_btn_MouseEnter(object sender, EventArgs e)
        {
            add_actor_btn.ForeColor = Color.FromArgb(197, 210, 219);
        }

        private void add_actor_btn_MouseLeave(object sender, EventArgs e)
        {
            add_actor_btn.ForeColor = Color.FromArgb(133, 162, 167);
        }

        private void actor_tb_Click(object sender, EventArgs e)
        {
            actor_tb.Text = "";
        }

        private void add_actor_btn_Click(object sender, EventArgs e)
        {
            closing_actors.Visible = true;
            cancel_btn2.Visible = true;
            add_actor_in_list_btn.Visible = true;
            actor_tb.Visible = true;
        }

        private void cancel_btn2_Click(object sender, EventArgs e)
        {
            closing_actors.Visible = false;
            cancel_btn2.Visible = false;
            add_actor_in_list_btn.Visible = false;
            actor_tb.Visible = false;
        }

        private void add_actor_in_list_btn_Click(object sender, EventArgs e)
        {
            try
            {
                XElement actors = doc.Element("for_lists").Element("actors");

                string actorName = actor_tb.Text;

                if (actor_tb.Text.Equals("") || actor_tb.Text.Equals("Введите имя и фамилию актера"))
                {
                    MessageBox.Show("Введите имя и фамилию актера");
                }
                else
                {
                    if (actors.Descendants().Any(c => c.Value.Equals(actorName)))
                    {
                        MessageBox.Show("Данный актер уже есть в списке");
                    }
                    else
                    {
                        AddFilmInBD(actor_tb.Text);
                        doc.Element("for_lists").Element("actors").Add(new XElement("actor", actor_tb.Text));
                        doc.Save(Xmlpath);
                        actors_list.Items.Add(actor_tb.Text);

                        closing_actors.Visible = false;
                        cancel_btn2.Visible = false;
                        add_actor_in_list_btn.Visible = false;
                        actor_tb.Visible = false;
                        MessageBox.Show("Введенные вами данные об актере добавлены в список актеров приложения");
                    }
                }
                logger.Info("Процесс добавления актеров прошел успешно");
            }
            catch
            {
                logger.Error("Проблемы с xml-файлом");
            }
        }

        private void AddFilmInBD(string actorName)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(connectionString);
                conn.Open();
                List<string> userLogins = new List<string>();
                string selectUsersQuery = "SELECT Login FROM users";
                MySqlCommand selectUsersCommand = new MySqlCommand(selectUsersQuery, conn);
                MySqlDataReader selectUsersReader = selectUsersCommand.ExecuteReader();
                while (selectUsersReader.Read())
                {
                    string login = selectUsersReader.GetString(0);
                    userLogins.Add(login);

                }
                selectUsersReader.Close();

                foreach (string login in userLogins)
                {
                    string insertActorQuery = "INSERT INTO users_actors_rating (Username, Actorname, RatingActor, MarksCount) VALUES (@Username, @Actorname, @RatingActor, @MarksCount)";
                    MySqlCommand insertActorCommand = new MySqlCommand(insertActorQuery, conn);
                    insertActorCommand.Parameters.AddWithValue("@Username", login);
                    insertActorCommand.Parameters.AddWithValue("@Actorname", actorName);
                    insertActorCommand.Parameters.AddWithValue("@RatingActor", 5);
                    insertActorCommand.Parameters.AddWithValue("@MarksCount", 0);
                    int rowsAffected = insertActorCommand.ExecuteNonQuery();

                }
            }
            catch
            {
                logger.Error("Не удается добавить фильм в базу данных");
            }
        }

        private void link_tb_Click(object sender, EventArgs e)
        {
            link_tb.Text = string.Empty;
        }
    }
}





