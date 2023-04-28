using MySql.Data.MySqlClient;
using NLog;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Label = System.Windows.Forms.Label;

namespace TeamProject2__ListOfRecommendations
{
    public partial class Preferences : Form
    {

        private List<Label> labels;
        private static Logger logger = LogManager.GetCurrentClassLogger();
        XDocument doc = XDocument.Load("@./../../../ForLists.xml");
        private List<string> Genres = new List<string>();
        private List<string> Actors = new List<string>();
        private string connectionString = "server=localhost;port=3306;username=root;password=root;database=teamproject_listofrecommendations";
        private string username;

        public Preferences(string login)
        {
            InitializeComponent();
            timer = new Timer();
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
                skip_btn.Visible = true;
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

            genres_list.DrawMode = DrawMode.OwnerDrawFixed;
            genres_list.DrawItem += genres_list_DrawItem;

            actors_list.DrawMode = DrawMode.OwnerDrawFixed;
            actors_list.DrawItem += actors_list_DrawItem;

            var screenWidth = Screen.PrimaryScreen.Bounds.Width;
            var screenHeight = Screen.PrimaryScreen.Bounds.Height;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point((screenWidth - this.Width) / 2, (screenHeight - this.Height) / 2);

            // Работа с элементами управления на форме
            int buttonOffset = 10;
            int formWidth = go_btn.Location.X + go_btn.Width + buttonOffset; // Вычисляем желаемую ширину формы
            int formHeight = go_btn.Location.Y + go_btn.Height + buttonOffset; // Вычисляем желаемую высоту формы
            this.ClientSize = new Size(formWidth, formHeight);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void go_btn_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            foreach (string genre in Genres)
            {
                MySqlCommand command = new MySqlCommand("UPDATE users_genres_rating SET RatingGenre = 8 WHERE Username = @username AND Genrename = @genre", connection);
                command.Parameters.AddWithValue("@username", Login);
                command.Parameters.AddWithValue("@genre", genre);
                command.ExecuteNonQuery();
            }
            foreach (string actor in Actors)
            {
                MySqlCommand command = new MySqlCommand("UPDATE users_actors_rating SET RatingActor = 8 WHERE Username = @username AND Actorname = @actor", connection);
                command.Parameters.AddWithValue("@username", Login);
                command.Parameters.AddWithValue("@actor", actor);
                command.ExecuteNonQuery();
            }
            connection.Close();
            MessageBox.Show("Ваши предпочтения учтены, поздравляем вас с полной регистрацией!");
            this.Close();
            Registration registration = new Registration(Login);
            registration.Close();

        }

        private void add_genre_Click(object sender, EventArgs e)
        {
            if (!Genres.Contains(genres_list.SelectedItem))
            {
                Genres.Add(genres_list.SelectedItem.ToString());
                MessageBox.Show($"Жанр фильма <<{genres_list.SelectedItem.ToString()}>> добавился в список ваших любимых");
                next_btn.Visible = true;
            }
            else
            {
                MessageBox.Show($"Жанр фильма <<{genres_list.SelectedItem.ToString()}>> уже был добавлен в список ваших любимых");
            }

        }

        private void add_actor_Click(object sender, EventArgs e)
        {
            if (!Actors.Contains(actors_list.SelectedItem))
            {
                next_btn.Visible = false;
                Actors.Add(actors_list.SelectedItem.ToString());
                go_btn.Visible = true;
                MessageBox.Show($"Актер {actors_list.SelectedItem.ToString()} добавился в список ваших любимых актеров");
            }
            else
            {
                MessageBox.Show($"Актер {actors_list.SelectedItem.ToString()} уже был добавлен в список ваших любимых актеров");

            }

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

        private void next_btn_Click_1(object sender, EventArgs e)
        {
            search_actor.Visible = true;
            go_btn.Visible = true;
            actors_list.Visible = true;
            genres_list.Visible = false;
            add_actor.Visible = true;
            add_genre.Visible = false;
        }

        private void skip_btn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите выполнить эту операцию?\nЗная ваши предпочтения, мы лучше подберем фильмы, которые могли бы вам понравиться",
                                      "Подтвердите действие",
                                      MessageBoxButtons.YesNo,
                                      MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
                Registration registration = new Registration(Login);
                registration.Close();
            }
           
        }

        private void search_actor_Click(object sender, EventArgs e)
        {
            search_actor.Text = "";
        }

        private void SearchInList(ListBox list, string searchText)
        {
            int index = list.FindString(searchText);

            if (index != ListBox.NoMatches)
            {
                list.SelectedIndex = index;
            }
        }

        private void search_actor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SearchInList(actors_list, search_actor.Text);
            }
        }
    }
}

