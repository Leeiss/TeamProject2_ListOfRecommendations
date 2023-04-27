using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamProject2__ListOfRecommendations
{
    public partial class ChangeCollections : Form
    {
        public ChangeCollections(string login)
        {
            InitializeComponent();
            Login = login;
        }
        private string Login;
        List<int> collectionIds = new List<int>();
        List<int> allfilmsIds = new List<int>();
        List<int> collectionfilmsIds = new List<int>();
        private string connectionString = "server=localhost;port=3306;username=root;password=root;database=teamproject_listofrecommendations";

        private void ChangeCollections_Load(object sender, EventArgs e)
        {
            FillCollectionList();
            FillFilmsList();

            var screenWidth = Screen.PrimaryScreen.Bounds.Width;
            var screenHeight = Screen.PrimaryScreen.Bounds.Height;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point((screenWidth - this.Width) / 2, (screenHeight - this.Height) / 2);

            int buttonOffset = 10; 
            int formWidth = ok_btn.Location.X + ok_btn.Width + buttonOffset; 
            int formHeight = ok_btn.Location.Y + ok_btn.Height + buttonOffset; 
            this.ClientSize = new Size(formWidth, formHeight);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void SearchInList(ListBox list, string searchText)
        {
            int index = list.FindString(searchText);

            if (index != ListBox.NoMatches)
            {
                list.SelectedIndex = index;
            }
        }

        private void FillCollectionList()
        {
            string query = "SELECT Collection_name, ID FROM users_collections WHERE User_name = @UserName";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@UserName", Login);
                connection.Open();

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string collectionName = reader.GetString("Collection_name");
                        int collectionId = reader.GetInt32("ID");

                        collections_list.Items.Add(collectionName);
                        collectionIds.Add(collectionId);
                    }
                }
            }
        }


        private void FillFilmsList()
        {
            string queryAllMovies = "SELECT MovieID, Title FROM movies";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            using (MySqlCommand command = new MySqlCommand(queryAllMovies, connection))
            {
                connection.Open();

                DataTable resultTable = new DataTable();
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                {
                    adapter.Fill(resultTable);
                }
                List<int> movieIds = new List<int>();

                foreach (DataRow row in resultTable.Rows)
                {
                    int movieId = Convert.ToInt32(row["MovieID"]);
                    string movieTitle = row["Title"].ToString();
                    all_films_collection_list.Items.Add(movieTitle);
                    allfilmsIds.Add(movieId);
                }
            }
        }

        private void FillCollectionFilmsList()
        {
            int index = collections_list.SelectedIndex;
            int collectionId = collectionIds[index];
            string queryAllMoviesInCollection = "SELECT movies.MovieID, movies.Title FROM movies JOIN movies_collections " +
                                                "ON movies.MovieID = movies_collections.MovieID " +
                                                "WHERE movies_collections.CollectionID = @CollectionID";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            using (MySqlCommand commandMovies = new MySqlCommand(queryAllMoviesInCollection, connection))
            {
                commandMovies.Parameters.AddWithValue("@CollectionID", collectionId);
                connection.Open();

                using (MySqlDataReader reader = commandMovies.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int movieId = reader.GetInt32(0);
                        string movieTitle = reader.GetString(1);

                        films_in_collection_list.Items.Add(movieTitle);
                        collectionfilmsIds.Add(movieId);
                    }
                }

                string queryCollectionName = "SELECT Collection_name FROM users_collections WHERE User_name = @UserName AND ID = @CollectionId";

                using (MySqlCommand commandCollectionName = new MySqlCommand(queryCollectionName, connection))
                {
                    commandCollectionName.Parameters.AddWithValue("@UserName", Login);
                    commandCollectionName.Parameters.AddWithValue("@CollectionId", collectionId);

                    string collectionName = commandCollectionName.ExecuteScalar().ToString();

                }
            }

        }

        private void collections_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                films_in_collection_list.Items.Clear();
                FillCollectionFilmsList();
                delete_collection.Visible = true;
                films_in_collection_list.Visible = true;
                search_film_tb.Visible = true;
                all_films_collection_list.Visible = true;
                info_lbl2.Visible = true;
                info_lbl3.Visible = true;
            }
            catch
            {
                MessageBox.Show("Выберите подборку");
            }

        }

        private void films_in_collection_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                delete_film_btn.Visible = true;
            }
            catch
            {
                MessageBox.Show("Выберите фильм");
            }
        }

        private void all_films_collection_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                add_film_btn.Visible = true;
            }
            catch
            {
                MessageBox.Show("Выберите фильм");
            }
        }

        private void search_film_tb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SearchInList(all_films_collection_list, search_film_tb.Text);
            }
        }

        private void search_film_tb_Click(object sender, EventArgs e)
        {
            search_film_tb.Text = "";
        }

        private void ok_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void delete_collection_Click(object sender, EventArgs e)
        {
            if (!collections_list.SelectedItem.ToString().Equals("Избранное"))
            {
                int index = collections_list.SelectedIndex;
                int collectionId = collectionIds[index];

                string query = "DELETE FROM users_collections WHERE User_name = @UserName AND ID = @CollectionId";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserName", Login);
                    command.Parameters.AddWithValue("@CollectionId", collectionId);
                    connection.Open();

                    int rowsAffected = command.ExecuteNonQuery();
                }
                RemoveRelationship(collectionId);
                MessageBox.Show("Подборка удалена");
                collections_list.Items.Clear();
                allfilmsIds.Clear();
                collectionIds.Clear();
                FillCollectionList();
            }
            else
                MessageBox.Show("Вы не можете удалить папку <<Избранное>>");
        }

        private void RemoveRelationship(int id)
        {
            string query = "DELETE FROM movies_collections WHERE CollectionID = @CollectionID";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@CollectionID", id);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }


        private void delete_film_btn_Click(object sender, EventArgs e)
        {
            films_in_collection_list.Items.Clear();
            FillCollectionFilmsList();

            int index1 = collections_list.SelectedIndex;
            int collectionId = collectionIds[index1];

            int index2 = films_in_collection_list.SelectedIndex;
            if (index2<0)
            {
                MessageBox.Show("Выберите фильм");
            }
            else
            {
                int movieIdToRemove = collectionfilmsIds[index2];
                string queryRemoveMovieFromCollection = "DELETE FROM movies_collections WHERE CollectionID = @CollectionID AND MovieID = @MovieID";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                using (MySqlCommand commandRemove = new MySqlCommand(queryRemoveMovieFromCollection, connection))
                {
                    commandRemove.Parameters.AddWithValue("@CollectionID", collectionId);
                    commandRemove.Parameters.AddWithValue("@MovieID", movieIdToRemove);
                    connection.Open();

                    int rowsAffected = commandRemove.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show($"Фильм <<{films_in_collection_list.SelectedItem.ToString()}>> удален из подборки <<{collections_list.SelectedItem.ToString()}>>");
                        films_in_collection_list.Items.Clear();
                        FillCollectionFilmsList();
                    }

                }
                films_in_collection_list.Items.Clear();
                FillCollectionFilmsList();
            }
               

        }

        private void add_film_btn_Click(object sender, EventArgs e)
        {
            films_in_collection_list.Items.Clear();
            FillCollectionFilmsList();

            int index1 = collections_list.SelectedIndex;
            int collectionId = collectionIds[index1];

            int index2 = all_films_collection_list.SelectedIndex;
            int movieIdToAdd = allfilmsIds[index2];

            string queryCheckMovieInCollection = "SELECT COUNT(*) FROM movies_collections WHERE CollectionID = @CollectionID AND MovieID = @MovieID";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            using (MySqlCommand command = new MySqlCommand(queryCheckMovieInCollection, connection))
            {
                command.Parameters.AddWithValue("@CollectionID", collectionId);
                command.Parameters.AddWithValue("@MovieID", movieIdToAdd);
                connection.Open();
                int count = Convert.ToInt32(command.ExecuteScalar());
                if (count > 0)
                {
                    MessageBox.Show($"Фильм <<{all_films_collection_list.SelectedItem.ToString()}>> уже есть в подборке <<{collections_list.SelectedItem.ToString()}>>");
                    return;
                }
            }

            string queryAddMovieToCollection = "INSERT INTO movies_collections (CollectionID, MovieID) VALUES (@CollectionID, @MovieID)";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            using (MySqlCommand command = new MySqlCommand(queryAddMovieToCollection, connection))
            {
                command.Parameters.AddWithValue("@CollectionID", collectionId);
                command.Parameters.AddWithValue("@MovieID", movieIdToAdd);
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show($"Фильм <<{all_films_collection_list.SelectedItem.ToString()}>> добавлен в подборку <<{collections_list.SelectedItem.ToString()}>>");
                    films_in_collection_list.Items.Clear();
                    FillCollectionFilmsList();
                }
            }
        }
    }
}

