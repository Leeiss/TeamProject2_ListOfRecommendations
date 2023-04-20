using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using Label = System.Windows.Forms.Label;

namespace TeamProject2__ListOfRecommendations
{
    public partial class Preferences : Form
    {

        private List<Label> labels;


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
            if (this.Tag != null && this.Tag.ToString() == "зарегистрироваться")
            {
                go_btn.Text = "Зарегестрироваться";
            }
            else if  (this.Tag != null && this.Tag.ToString() == "изменить")
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
            
            search_genre_btn.Height = searchGenre_tb.Height;
            search_genre_btn.Width = search_genre_btn.Height;
            search_genre_btn.Location = new Point(searchGenre_tb.Right, search_genre_btn.Top);

            search_actor_btn.Height = searchGenre_tb.Height;
            search_actor_btn.Width = search_actor_btn.Height;
            search_actor_btn.Location = new Point(searchActor_tb.Right, search_actor_btn.Top);

        }

        private void searchGenre_tb_Click(object sender, EventArgs e)
        {
            searchGenre_tb.Text = "";
        }

        private void searchActor_tb_Click(object sender, EventArgs e)
        {
            searchActor_tb.Text = "";
        }

        private void go_btn_Click(object sender, EventArgs e)
        {
            if (this.Tag != null && this.Tag.ToString() == "зарегистрироваться")
            {
                MessageBox.Show("Вы успешно зарегестрированы!");
                MainForm mainform = new MainForm(Login);
                mainform.ShowDialog();
            }
            else if (this.Tag != null && this.Tag.ToString() == "изменить")
            {
                MainForm mainform = new MainForm(Login);
                mainform.ShowDialog();
            }
           
        }
       
       private void add_genre_Click(object sender, EventArgs e)
        {
            next_btn.Visible = true;
        }

        private void add_actor_Click(object sender, EventArgs e)
        {
            go_btn.Visible = true;
        }

        private void actors_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            add_actor.Visible = true;
        }

        private void genres_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            add_genre.Visible = true;
        }

        private void search_btn3_Click(object sender, EventArgs e)
        {
            string searchValue = searchActor_tb.Text.ToLower();

            for (int i = 0; i < genres_list.Items.Count; i++)
            {
                string itemText = genres_list.Items[i].ToString().ToLower(); // Получаем значение элемента списка и приводим его к нижнему регистру
                if (itemText.Contains(searchValue))
                {
                    genres_list.SetSelected(i, true); // Выделяем элемент в списке, если он содержит значения из текстового поля
                }
                else
                {
                    genres_list.SetSelected(i, false); // Убираем выделение, если элемент не содержит значение из текстового поля
                }
            }
        }

        private void next_btn_Click(object sender, EventArgs e)
        {
            actors_list.DrawMode = DrawMode.OwnerDrawFixed;
            actors_list.DrawItem += actors_list_DrawItem;

            next_btn.Visible = false;
            info_lbl5.Visible = true;
            genres_list.Visible = false;
            searchGenre_tb.Visible = false;
            search_genre_btn.Visible = false;
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

