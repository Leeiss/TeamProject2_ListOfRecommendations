using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Schema;

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
        private void AddFilm_Load(object sender, EventArgs e)
        {
           IEnumerable<string> actors = doc.Element("for_lists").Element("actors").Elements("actor").Select(x => x.Value);

            foreach (string actor in actors)
            {
                actors_list.Items.Add(actor);
            }

            IEnumerable<string> countries = doc.Element("for_lists").Element("countries").Elements("country").Select(x => x.Value);

            foreach (string country in countries)
            {
                countries_list.Items.Add(country);
            }

            var screenWidth = Screen.PrimaryScreen.Bounds.Width;
            var screenHeight = Screen.PrimaryScreen.Bounds.Height;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point((screenWidth - this.Width) / 2, (screenHeight - this.Height) / 2);

            int buttonOffset = 30;
            int formWidth = add_film_btn.Location.X + add_film_btn.Width + buttonOffset; // Вычисляем желаемую ширину формы
            int formHeight = add_film_btn.Location.Y + add_film_btn.Height + buttonOffset; // Вычисляем желаемую высоту формы
            this.ClientSize = new Size(formWidth, formHeight); 
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

        private void SearchInList(ListBox list, string searchText)
        {
            int index = list.FindString(searchText);

            if (index != ListBox.NoMatches)
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
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                ImageSelect = true;
                selectedFile = fileDialog.FileName;
            }
            YesNoShowBtn();
        }

        private void add_genre_Click(object sender, EventArgs e)
        {
            GenreSelect = true;
            Genres.Add(genres_list.SelectedItem.ToString());
            MessageBox.Show("Выбранный вами жанр добавлен в информацию о жанрах фильма");
            YesNoShowBtn();
        }

        private void add_country_Click(object sender, EventArgs e)
        {
            CountrySelect = true;
            Countries.Add((string)countries_list.SelectedItem);
            MessageBox.Show("Выбранная вами страна добавлена в информацию странах-производителях фильма");
            YesNoShowBtn();
        }

        private void add_actor_Click(object sender, EventArgs e)
        {
            ActorSelect = true;
            Actors.Add((string)actors_list.SelectedItem);
            MessageBox.Show("Выбранное вами имя актера добавлено в информацию об актерах фильма");
            YesNoShowBtn();
        }

        private void selected_date_ValueChanged(object sender, EventArgs e)
        {
            DateSelect = true;
            chosenDate = selected_date.Value.ToString("dd.MM.yyyy");
            YesNoShowBtn();
        }

        private void add_film_btn_Click(object sender, EventArgs e)
        {
            if (title_tb.Text == "" || title_tb.Text.Equals("Введите название"))
            {
                MessageBox.Show("Пожалуйста, введите название фильма");
            }
            else
            {
              using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Создаем команду SQL для вставки фильма
                    string insertFilmQuery = "INSERT INTO movies (`Title`, `Date` , `PicturePath`) VALUES(@Title, @Date, @PicturePath)";
                    using (MySqlCommand command = new MySqlCommand(insertFilmQuery, connection))
                    {
                        // Добавляем параметр названия фильма
                        command.Parameters.Add("@Title", MySqlDbType.VarChar).Value = title_tb.Text;
                        command.Parameters.Add("@Date", MySqlDbType.VarChar).Value = chosenDate;
                        command.Parameters.Add("@PicturePath", MySqlDbType.VarChar).Value = selectedFile;

                        // Выполняем команду и получаем идентификатор добавленного фильма
                        int filmId = Convert.ToInt32(command.ExecuteScalar());

                        // Создаем команду SQL для вставки жанров фильма
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
                }
                MessageBox.Show("Фильм успешно добавлен");
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

        private void add_country_btn_MouseEnter(object sender, EventArgs e)
        {
            add_country_btn.ForeColor = Color.FromArgb(197, 210, 219);
        }

        private void add_country_btn_MouseLeave(object sender, EventArgs e)
        {
            add_country_btn.ForeColor = Color.FromArgb(133, 162, 167);
        }

        private void actor_tb_Click(object sender, EventArgs e)
        {
            actor_tb.Text = "";
        }

        private void country_tb_Click(object sender, EventArgs e)
        {
            country_tb.Text = "";
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
            if (actor_tb.Text.Equals("") || actor_tb.Text.Equals("Введите имя и фамилию актера"))
            {
                MessageBox.Show("Введите имя и фамилию актера");
            }
            else
            {
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

       private void add_country_btn_Click_1(object sender, EventArgs e)
        {
            closing_countries.Visible = true;
            cancel_btn.Visible = true;
            add_country_in_list_btn.Visible = true;
            country_tb.Visible = true;
        }

        private void add_country_in_list_btn_Click(object sender, EventArgs e)
        {
            if (country_tb.Text.Equals("") || country_tb.Text.Equals("Введите название страны"))
            {
                MessageBox.Show("Введите название страны");
            }
            else
            {
                doc.Element("for_lists").Element("countries").Add(new XElement("country", country_tb.Text));
                doc.Save(Xmlpath);
                countries_list.Items.Add(country_tb.Text);

                closing_countries.Visible = false;
                cancel_btn.Visible = false;
                add_country_in_list_btn.Visible = false;
                country_tb.Visible = false;
                MessageBox.Show("Введенные вами данные о стране добавлены в список стран приложения");
            }
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            closing_countries.Visible = false;
            cancel_btn.Visible = false;
            add_country_in_list_btn.Visible = false;
            country_tb.Visible = false;
        }
    }
}