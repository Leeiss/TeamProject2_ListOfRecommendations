using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using Label = System.Windows.Forms.Label;

namespace TeamProject2__ListOfRecommendations
{
    public partial class Preferences : Form
    {

        private List<Label> labels;
        XDocument doc = XDocument.Load("@./../../../ForLists.xml");
        private List<string> Genres = new List<string>();
        private List<string> Actors = new List<string>();
        private string connectionString = "server=localhost;port=3306;username=root;password=root;database=teamproject_listofrecommendations";

        public Preferences(string login)
        {
            InitializeComponent();
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 400;
            timer.Tick += new EventHandler(timer_Tick);
            labels = new List<Label> { info_lbl1, info_lbl2, info_lbl3 };
            foreach (Label label in labels)
            {
                label.Visible = false;
            }
            closing_panel.Visible = true;
            panel_lateral.Visible = false;
            info_lbl4.Visible = false;
            go_btn.Visible = false;
            timer.Start();

            Login = login;
        }
        public string Login;
        private void timer_Tick(object sender, EventArgs e)
        {
            Label nextLabel = labels.FirstOrDefault(l => !l.Visible);
            if (nextLabel != null)
            {
                panel_lateral.Visible = true;
                nextLabel.Visible = true;
            }
            else
            {
                closing_panel.Visible = false;
                info_lbl4.Visible = true;
                timer.Stop();
            }

        }

        private void Preferences_Load(object sender, EventArgs e)
        {
            IEnumerable<string> actors = doc.Element("for_lists").Element("actors").Elements("actor").Select(x => x.Value);

            foreach (string actor in actors)
            {
                actors_list.Items.Add(actor);
            }


            if (this.Tag != null && this.Tag.ToString() == "зарегистрироваться")
            {
                go_btn.Text = "Зарегестрироваться";
            }
            else if (this.Tag != null && this.Tag.ToString() == "изменить")
            {
                go_btn.Text = "Изменить";
            }


            genres_list.DrawMode = DrawMode.OwnerDrawFixed;
            genres_list.DrawItem += genres_list_DrawItem;

            var screenWidth = Screen.PrimaryScreen.Bounds.Width;
            var screenHeight = Screen.PrimaryScreen.Bounds.Height;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point((screenWidth - this.Width) / 2, (screenHeight - this.Height) / 2);

            // Работа с элементами управления на форме
            int buttonOffset = 10;
            int formWidth = go_btn.Location.X + go_btn.Width + buttonOffset; // Вычисляем желаемую ширину формы
            int formHeight = go_btn.Location.Y + go_btn.Height + buttonOffset; // Вычисляем желаемую высоту формы
            this.ClientSize = new Size(formWidth, formHeight); // Устанавливаем размер формы
        }

        private void go_btn_Click(object sender, EventArgs e)
        {
            if (this.Tag != null && this.Tag.ToString() == "зарегистрироваться")
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string insertGenreQuery = "INSERT INTO users_favoritegenres (Genre, Username) VALUES (@Genre, @Username)";
                    using (MySqlCommand genreCommand = new MySqlCommand(insertGenreQuery, connection))
                    {
                        foreach (string genre in Genres)
                        {
                            genreCommand.Parameters.Clear();
                            genreCommand.Parameters.AddWithValue("@Username", Login);
                            genreCommand.Parameters.AddWithValue("@Genre", genre);
                            genreCommand.ExecuteNonQuery();
                        }
                    }
                    string insertActorQuery = "INSERT INTO users_favoriteactors (Actor, Username) VALUES (@Actor, @Username)";
                    using (MySqlCommand actorCommand = new MySqlCommand(insertActorQuery, connection))
                    {
                        foreach (string actor in Actors)
                        {
                            actorCommand.Parameters.Clear();
                            actorCommand.Parameters.AddWithValue("@Username", Login);
                            actorCommand.Parameters.AddWithValue("@Actor", actor);
                            actorCommand.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Вы успешно зарегестрированы!");
                    Authorization authorization = new Authorization();
                    authorization.Show();
                    connection.Close();
                }
            }
            else if (this.Tag != null && this.Tag.ToString() == "изменить")
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string deleteGenreQuery = "DELETE FROM users_favoritegenres WHERE Username = @Username";
                    using (MySqlCommand cmd = new MySqlCommand(deleteGenreQuery, connection))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@Username", Login);
                        cmd.ExecuteNonQuery();
                    }

                    string deleteActorQuery = "DELETE FROM users_favoriteactors WHERE Username = @Username";
                    using (MySqlCommand cmd = new MySqlCommand(deleteActorQuery, connection))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@Username", Login);
                        cmd.ExecuteNonQuery();
                    }

                    string insertGenreQuery = "INSERT INTO users_favoritegenres (Genre, Username) VALUES (@Genre, @Username)";
                    using (MySqlCommand genreCommand = new MySqlCommand(insertGenreQuery, connection))
                    {
                        foreach (string genre in Genres)
                        {
                            genreCommand.Parameters.Clear();
                            genreCommand.Parameters.AddWithValue("@Username", Login);
                            genreCommand.Parameters.AddWithValue("@Genre", genre);
                            genreCommand.ExecuteNonQuery();
                        }
                    }
                    string insertActorQuery = "INSERT INTO users_favoriteactors (Actor, Username) VALUES (@Actor, @Username)";
                    using (MySqlCommand actorCommand = new MySqlCommand(insertActorQuery, connection))
                    {
                        foreach (string actor in Actors)
                        {
                            actorCommand.Parameters.Clear();
                            actorCommand.Parameters.AddWithValue("@Username", Login);
                            actorCommand.Parameters.AddWithValue("@Actor", actor);
                            actorCommand.ExecuteNonQuery();
                        }
                    }
                    connection.Close();
                }
               
                MessageBox.Show("Ваши предпочтения изменены");
                MainForm mainform = new MainForm(Login);
                mainform.ShowDialog();
            }

        }

        private void add_genre_Click(object sender, EventArgs e)
        {
            Genres.Add(genres_list.SelectedItem.ToString());
            next_btn.Visible = true;
            MessageBox.Show("Выбранный вами жанр фильма добавился в список ваших любимых");

        }

        private void add_actor_Click(object sender, EventArgs e)
        {
            Actors.Add(actors_list.SelectedItem.ToString());
            go_btn.Visible = true;
            MessageBox.Show("Выбранный вами актер добавился в список ваших любимых");

        }

        private void actors_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            add_actor.Visible = true;
        }

        private void genres_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            add_genre.Visible = true;
        }

        private void next_btn_Click(object sender, EventArgs e)
        {
            actors_list.DrawMode = DrawMode.OwnerDrawFixed;
            actors_list.DrawItem += actors_list_DrawItem;

            actors_list.Visible = true;
            genres_list.Visible = false;

            next_btn.Visible = false;
            info_lbl5.Visible = true;
            genres_list.Visible = false;
            info_lbl4.Visible = false;
            add_genre.Visible = false;
            go_btn.Visible = false;
        }

        private void genres_list_DrawItem(object sender, DrawItemEventArgs e)
        {
            TextRenderer.DrawText(e.Graphics, genres_list.Items[e.Index].ToString(), e.Font,
                e.Bounds, e.ForeColor, e.BackColor, TextFormatFlags.HorizontalCenter);
        }

        private void actors_list_DrawItem(object sender, DrawItemEventArgs e)
        {
            TextRenderer.DrawText(e.Graphics, actors_list.Items[e.Index].ToString(), e.Font,
                e.Bounds, e.ForeColor, e.BackColor, TextFormatFlags.HorizontalCenter);
        }
    }
}

