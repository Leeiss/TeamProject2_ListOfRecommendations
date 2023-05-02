using MySql.Data.MySqlClient;
using NLog;
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

    public partial class InfoAboutFilm : Form
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        public InfoAboutFilm(string login, int id, string Title, string Path, string Genres, string Actors, string Countries, string Date)
        {
            InitializeComponent();
            info_title.Text = Title.ToUpper();
            try
            {
                image_poster.Image = Image.FromFile(Path);
            }
            catch
            {
                image_poster.Image = Properties.Resources.безфото;
            }
            info_genre.Text = Genres;
            info_actors.Text = Actors;
            info_country.Text = Countries;
            info_year.Text = Date;
            Idmovie = id;
            Login = login;
        }

        private string connectionString = "server=localhost;port=3306;username=root;password=root;database=teamproject_listofrecommendations";
        private int Idmovie;
        private string Login;
        private void InfoAboutFilm_Load(object sender, EventArgs e)
        {
            var screenWidth = Screen.PrimaryScreen.Bounds.Width;
            var screenHeight = Screen.PrimaryScreen.Bounds.Height;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point((screenWidth - this.Width) / 2, (screenHeight - this.Height) / 2);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void administration_btn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Будет ли выходить фильм Вам в рекомендации или нет, зависит от ваших предпочтений ваших оценок. \t\tВы хотите дальше видеть этот фильм в ваших рекомендациях?", "Рекомендованный фильм", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                try
                {
                    MySqlConnection connection = new MySqlConnection(connectionString);
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand("INSERT INTO not_recommended_movies (IDmovie, Username) VALUES (@movieID, @userLogin)", connection))
                    {
                        command.Parameters.AddWithValue("@movieID", Idmovie); 
                        command.Parameters.AddWithValue("@userLogin", Login); 
                        command.ExecuteNonQuery();
                    }

                    connection.Close();
                    MessageBox.Show("Фильм <<" + info_title.Text + ">> больше не будет вам рекомендоваться");
                    logger.Info("Фильм с ID " + Idmovie.ToString() + " добавлен в список нежелательных для пользователя " + Login);
                }
                catch (Exception ex)
                {
                    logger.Error("Не удалось добавить фильм с ID " + Idmovie.ToString() + " в список нежелательных для пользователя " + Login + ": " + ex.Message);
                }
            }
        }

        private void administration_btn_MouseEnter(object sender, EventArgs e)
        {
            administration_btn.ForeColor = Color.FromArgb(197, 210, 219);
        }

        private void administration_btn_MouseLeave(object sender, EventArgs e)
        {
            administration_btn.ForeColor = Color.FromArgb(133, 162, 167);
        }
    }
}
