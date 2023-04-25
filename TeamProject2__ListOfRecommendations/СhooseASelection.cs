using MySql.Data.MySqlClient;
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

namespace TeamProject2__ListOfRecommendations
{
    public partial class СhooseCollection : Form
    {
        public СhooseCollection(string login, int movieId)
        {
            InitializeComponent();
            Login = login;
            MovieId = movieId;
        }
        private string Login;
        private int MovieId;
        private string connectionString = "server=localhost;port=3306;username=root;password=root;database=teamproject_listofrecommendations";
        private void СhooseCollection_Load(object sender, EventArgs e)
        {
            FillListboxWithSelections();
            var screenWidth = Screen.PrimaryScreen.Bounds.Width;
            var screenHeight = Screen.PrimaryScreen.Bounds.Height;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point((screenWidth - this.Width) / 2, (screenHeight - this.Height) / 2);

            int buttonOffset = 30; 
            int formWidth = add_btn.Location.X + add_btn.Width + buttonOffset; // Вычисляем желаемую ширину формы
            int formHeight = add_btn.Location.Y + add_btn.Height + buttonOffset; // Вычисляем желаемую высоту формы
            this.ClientSize = new Size(formWidth, formHeight);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void FillListboxWithSelections()
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();


            string getCollectionNamesSql = "SELECT Collection_name FROM users_collections WHERE User_name = @username";
            MySqlCommand getCollectionNamesCmd = new MySqlCommand(getCollectionNamesSql, connection);
            getCollectionNamesCmd.Parameters.AddWithValue("@username", Login);

            List<string> collectionNames = new List<string>();
            using (MySqlDataReader reader = getCollectionNamesCmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    string collectionName = reader.GetString("Collection_name");
                    collectionNames.Add(collectionName);
                }
            }

            connection.Close();

            foreach (string collectionName in collectionNames)
            {
                collections_list.Items.Add(collectionName);
            }
        }

        private void collections_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                add_btn.Visible = true;
            }
            catch
            {
                MessageBox.Show("Выберите подборку");
            }
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            string collectionName = collections_list.SelectedItem.ToString();
            string getCollectionIdSql = "SELECT ID FROM users_collections WHERE Collection_name = @collectionName";
            MySqlCommand getCollectionIdCmd = new MySqlCommand(getCollectionIdSql, connection);
            getCollectionIdCmd.Parameters.AddWithValue("@collectionName", collectionName);
            int collectionId = Convert.ToInt32(getCollectionIdCmd.ExecuteScalar());

            string checkMovieInCollectionSql = "SELECT COUNT(*) FROM movies_collections WHERE CollectionID = @collectionId AND MovieID = @movieId";
            MySqlCommand checkMovieInCollectionCmd = new MySqlCommand(checkMovieInCollectionSql, connection);
            checkMovieInCollectionCmd.Parameters.AddWithValue("@collectionId", collectionId);
            checkMovieInCollectionCmd.Parameters.AddWithValue("@movieId", MovieId);
            int count = Convert.ToInt32(checkMovieInCollectionCmd.ExecuteScalar());

            if (count > 0) // Фильм уже есть в коллекции
            {
                MessageBox.Show("Фильм уже есть в этой коллекции");
                connection.Close();
                this.Close();
                return;
            }

            string addToCollectionSql = "INSERT INTO movies_collections (CollectionID, MovieID) VALUES (@collectionId, @movieId)";
            MySqlCommand addToCollectionCmd = new MySqlCommand(addToCollectionSql, connection);
            addToCollectionCmd.Parameters.AddWithValue("@collectionId", collectionId);
            addToCollectionCmd.Parameters.AddWithValue("@movieId", MovieId);
            addToCollectionCmd.ExecuteNonQuery();

            connection.Close();
            MessageBox.Show($"Фильм успешно добавлен в коллекцию <<{collections_list.SelectedItem.ToString()}>>");
            this.Close();
        }
    }
}
