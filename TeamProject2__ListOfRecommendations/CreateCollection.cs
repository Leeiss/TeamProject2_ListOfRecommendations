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
    public partial class CreateCollection : Form
    {
        public CreateCollection()
        {
            InitializeComponent();
        }

        private void CreateCollection_Load(object sender, EventArgs e)
        {
            var screenWidth = Screen.PrimaryScreen.Bounds.Width;
            var screenHeight = Screen.PrimaryScreen.Bounds.Height;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point((screenWidth - this.Width) / 2, (screenHeight - this.Height) / 2);

            int buttonOffset = 30; // Размер отступа (10 мм)
            int formWidth = ok_btn.Location.X + ok_btn.Width + buttonOffset; // Вычисляем желаемую ширину формы
            int formHeight = ok_btn.Location.Y + ok_btn.Height + buttonOffset; // Вычисляем желаемую высоту формы
            this.ClientSize = new Size(formWidth, formHeight); // Устанавливаем размер формы
        }

        private void SearchInList(ListBox list, string searchText)
        {
            int index = list.FindString(searchText);

            if (index != ListBox.NoMatches)
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
            add_film_btn.Visible = true;
        }

        private void add_film_btn_Click(object sender, EventArgs e)
        {
            ok_btn.Visible = true;
        }

        private void search_film_tb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SearchInList(films_list, search_film_tb.Text);
            }
        }
    }
}
