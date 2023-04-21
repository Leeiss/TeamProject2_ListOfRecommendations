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
        public ChangeCollections()
        {
            InitializeComponent();
        }

        private void ChangeCollections_Load(object sender, EventArgs e)
        {
            var screenWidth = Screen.PrimaryScreen.Bounds.Width;
            var screenHeight = Screen.PrimaryScreen.Bounds.Height;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point((screenWidth - this.Width) / 2, (screenHeight - this.Height) / 2);

            int buttonOffset = 10; // Размер отступа (10 мм)
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

        private void search_collection_tb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SearchInList(collections_list, search_collection_tb.Text);
            }
        }

        private void collections_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            delete_collection.Visible = true;
            films_in_collection_list.Visible = true;
            search_film_tb.Visible = true;
            search_collection_tb.Visible = true;
            all_films_collection_list.Visible = true;
            add_film_btn.Visible = true;   
            info_lbl2.Visible = true;
            info_lbl3.Visible = true;
        }

        private void films_in_collection_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            delete_film_btn.Visible = true;
        }

        private void all_films_collection_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            add_film_btn.Visible = true;
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

        private void search_collection_tb_Click(object sender, EventArgs e)
        {
            search_collection_tb.Text = "";
        }
    }
}
