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
        public InfoAboutFilm(string Title, string Path, string Genres, string Actors, string Countries, string Date)
        {
            InitializeComponent();
            info_title.Text = Title.ToUpper();
            image_poster.Image = Image.FromFile(Path);
            info_genre.Text = Genres;
            info_actors.Text = Actors;
            info_country.Text = Countries;
            info_year.Text = Date;
        }

        private void InfoAboutFilm_Load(object sender, EventArgs e)
        {
            var screenWidth = Screen.PrimaryScreen.Bounds.Width;
            var screenHeight = Screen.PrimaryScreen.Bounds.Height;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point((screenWidth - this.Width) / 2, (screenHeight - this.Height) / 2);
        }
    }
}
