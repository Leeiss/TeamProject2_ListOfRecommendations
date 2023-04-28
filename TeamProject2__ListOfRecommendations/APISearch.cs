using Newtonsoft.Json;
using NLog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamProject2__ListOfRecommendations
{
    public partial class APISearch : Form
    {
        private List<Label> labels;
        private const string OmdbBaseUrl = "http://www.omdbapi.com/";
        private const string OmdbApiKey = "d012c630"; //API-ключ
        string plot;
        private static Logger logger = LogManager.GetCurrentClassLogger();
        public APISearch()
        {
            InitializeComponent();
            timer = new Timer();
            timer.Interval = 400;
            timer.Tick += new EventHandler(timer_Tick);
            labels = new List<Label> { info_lbl1, info_lbl2, info_lbl3, info_lbl4 };
            foreach (Label label in labels)
            {
                label.Visible = false;
            }
            panel_lateral.Visible = false;
            timer.Start();
        }

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
                ok_btn.Visible = true;
                timer.Stop();
            }
        }

        private void ok_btn_Click(object sender, EventArgs e)
        {
            closing_panel.Visible = true;
            info_lbl1.Visible = false;
            info_lbl2.Visible = false;
            info_lbl3.Visible = false;
            info_lbl4.Visible = false;
            ok_btn.Visible = false;
        }

        private void search_tb_Click(object sender, EventArgs e)
        {
            search_tb.Text = string.Empty;
        }

        private void search_tb_MouseEnter(object sender, EventArgs e)
        {
            frame_searching.Visible = true;
        }

        private void search_tb_MouseLeave(object sender, EventArgs e)
        {
            frame_searching.Visible = false;
        }

        private async void search_btn1_Click(object sender, EventArgs e)
        {
            try
            {
                string title = search_tb.Text.Trim();
                if (string.IsNullOrWhiteSpace(title))
                {
                    MessageBox.Show("Пожалуйста, введите запрос");
                    return;
                }

                string requestUrl = $"{OmdbBaseUrl}?apikey={OmdbApiKey}&t={title}";//GET-запрос к API, в качестве параметра API-ключ и название фильма
                using (var httpClient = new HttpClient())
                {
                    string responseJson = await httpClient.GetStringAsync(requestUrl);

                    //сериализуем в объект OmdbMovie при помощи метода DeserializeObject из библиотеки Newtonsoft.Json
                    var movie = JsonConvert.DeserializeObject<OmdbMovie>(responseJson);

                    if (movie == null)
                    {
                        MessageBox.Show($" Не найден фильм с названием '{title}'.");
                        return;
                    }
                    info_title.Visible = true;
                    info_title.Text = movie.Title;
                    info_year.Text = movie.Year;
                    info_mark.Text = movie.ImdbRating;
                    info_actors.Text = movie.Actors;
                    info_genre.Text = movie.Genre;
                    info_country.Text = movie.Country;
                    plot = movie.Plot;

                    if (!string.IsNullOrWhiteSpace(movie.Poster))
                    {
                        image_poster.Load(movie.Poster);
                    }
                    else
                    {
                        image_poster.Image = null;
                    }
                }
                logger.Info("Поиск по api выполнился успешно");
            }
            catch (Exception ex) 
            {
                logger.Error("Ошибка запроса с использованием api: "+ex);
            }
        }

        /// <summary>
        /// Класс для десериализации JSON-ответа, который будет приходить от API
        /// </summary>
        public class OmdbMovie
        {
            [JsonProperty("Title")]
            public string Title { get; set; }

            [JsonProperty("Year")]
            public string Year { get; set; }

            [JsonProperty("imdbRating")]
            public string ImdbRating { get; set; }

            [JsonProperty("Poster")]
            public string Poster { get; set; }

            [JsonProperty("Actors")]
            public string Actors { get; set; }

            [JsonProperty("Genre")]
            public string Genre { get; set; }

            [JsonProperty("Country")]
            public string Country { get; set; }

            [JsonProperty("Plot")]
            public string Plot { get; set; }
        }


       private void APISearch_Load(object sender, EventArgs e)
        {
            var screenWidth = Screen.PrimaryScreen.Bounds.Width;
            var screenHeight = Screen.PrimaryScreen.Bounds.Height;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point((screenWidth - this.Width) / 2, (screenHeight - this.Height) / 2);

            int buttonOffset = 20; 
            int formWidth = ok_btn.Location.X + ok_btn.Width + buttonOffset; // Вычисляем желаемую ширину формы
            int formHeight = ok_btn.Location.Y + ok_btn.Height + buttonOffset; // Вычисляем желаемую высоту формы
            this.ClientSize = new Size(formWidth, formHeight);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void show_plot_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(plot);
        }

        
    }
}
