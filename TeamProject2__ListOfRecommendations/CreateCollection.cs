using MySql.Data.MySqlClient;
using NLog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace TeamProject2__ListOfRecommendations
{
    public partial class CreateCollection : Form
    {
        public CreateCollection(string Login)
        {
            InitializeComponent();
            login = Login;
        }
        private string login;
        private static Logger logger = LogManager.GetCurrentClassLogger();
        private string connectionString = "server=localhost;port=3306;username=root;password=root;database=teamproject_listofrecommendations";

        private List<string> MovieTitles = new List<string>();
        private List <int> MovieIds = new List<int>();
        private List <int> SelectedMovies = new List<int>();
        private List <string> SelectedMoviesTitles = new List<string>();
        private int id;

        private void CreateCollection_Load(object sender, EventArgs e)
        {
            FillLists();
            foreach (string movietitle in MovieTitles)
            {
                films_list.Items.Add(movietitle);
            }

            var screenWidth = Screen.PrimaryScreen.Bounds.Width;
            var screenHeight = Screen.PrimaryScreen.Bounds.Height;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point((screenWidth - this.Width) / 2, (screenHeight - this.Height) / 2);

            int buttonOffset = 30; 
            int formWidth = ok_btn.Location.X + ok_btn.Width + buttonOffset; // Вычисляем желаемую ширину формы
            int formHeight = ok_btn.Location.Y + ok_btn.Height + buttonOffset; // Вычисляем желаемую высоту формы
            this.ClientSize = new Size(formWidth, formHeight);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void SearchInList(System.Windows.Forms.ListBox list, string searchText)
        {
            int index = list.FindString(searchText);

            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                list.SelectedIndex = index;
            }
        }

        private void name_tb_Click(object sender, EventArgs e)
        {
            name_tb.Text = string.Empty;
        }

        private void films_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                add_film_btn.Visible = true;
            }
            catch
            {
                MessageBox.Show("Выберите фильм из подборки");
            }

        }

        private void CreateUserCollection(List <int> movieIds)
        {
            
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();

                string getUserIdSql = "SELECT ID FROM users WHERE Login = @login";
                MySqlCommand getUserIdCmd = new MySqlCommand(getUserIdSql, connection);

                string createCollectionSql = "INSERT INTO users_collections (Collection_name, User_name) VALUES (@collectionName, @username)";
                MySqlCommand createCollectionCmd = new MySqlCommand(createCollectionSql, connection);
                createCollectionCmd.Parameters.AddWithValue("@collectionName", name_tb.Text);
                createCollectionCmd.Parameters.AddWithValue("@username", login);
                createCollectionCmd.ExecuteNonQuery();

                string getNewCollectionIdSql = "SELECT LAST_INSERT_ID()";
                MySqlCommand getNewCollectionIdCmd = new MySqlCommand(getNewCollectionIdSql, connection);
                int collectionId = Convert.ToInt32(getNewCollectionIdCmd.ExecuteScalar());

                foreach (int movieId in movieIds)
                {
                    string addToCollectionSql = "INSERT INTO movies_collections (CollectionID, MovieID) VALUES (@collectionId, @movieId)";
                    MySqlCommand addToCollectionCmd = new MySqlCommand(addToCollectionSql, connection);
                    addToCollectionCmd.Parameters.AddWithValue("@collectionId", collectionId);
                    addToCollectionCmd.Parameters.AddWithValue("@movieId", movieId);
                    addToCollectionCmd.ExecuteNonQuery();
                }

                connection.Close();
            
        }    
            

        private void add_film_btn_Click(object sender, EventArgs e)
        {

            
            if (SelectedMoviesTitles.Contains(films_list.SelectedItem.ToString()))
            {
                MessageBox.Show("Вы уже добавили фильм в эту подборку");
            }
            else
            {
                for (int i = 0; i < MovieTitles.Count; i++)
                {
                    if (films_list.SelectedItem.ToString() == MovieTitles[i])
                        id = MovieIds[i];
                }
                SelectedMovies.Add(id);
                SelectedMoviesTitles.Add(films_list.SelectedItem.ToString().ToString());
                MessageBox.Show("Фильм успешно добавлен в подборку");
                ok_btn.Visible = true;
            }
           
            
        }

        private void search_film_tb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SearchInList(films_list, search_film_tb.Text);
            }
        }

        private void search_film_tb_Click(object sender, EventArgs e)
        {
            search_film_tb.Text = "";
        }

        private void FillLists()
        {
            MySqlConnection connection = new MySqlConnection(connectionString);

            connection.Open();

            string getMoviesSql = "SELECT * FROM movies";
            MySqlCommand getMoviesCommand = new MySqlCommand(getMoviesSql, connection);
            MySqlDataReader reader = getMoviesCommand.ExecuteReader();

            while (reader.Read())
            {
                int movieId = reader.GetInt32(0);
                string title = reader.GetString(1);

                MovieTitles.Add(title);
                MovieIds.Add(movieId);
            }

            connection.Close();
        }

        private void ok_btn_Click(object sender, EventArgs e)
        {
            if (name_tb.Text.Equals("")|| name_tb.Text.Equals("Введите название"))
            {
                MessageBox.Show("Некорректно введено название подборки");
                
            }
            else
            {
                CreateUserCollection(SelectedMovies);
                MessageBox.Show("Подборка успешно добавлена в список подборок пользователя");
                this.Close();
                MainForm mainForm = new MainForm(login);
                mainForm.Activate();
            }
        }

        
    }
}
