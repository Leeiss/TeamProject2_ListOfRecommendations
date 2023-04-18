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


        public Preferences()
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
                closing_panel.Visible = false;
                info_lbl4.Visible = true;
                go_btn.Visible = true;
                timer.Stop();
            }

        }

        private void Preferences_Load(object sender, EventArgs e)
        {
            // Работа с элементами управления на форме
            int buttonOffset = 10; // Размер отступа (10 мм)
            int formWidth = go_btn.Location.X + go_btn.Width + buttonOffset; // Вычисляем желаемую ширину формы
            int formHeight = go_btn.Location.Y + go_btn.Height + buttonOffset; // Вычисляем желаемую высоту формы
            this.ClientSize = new Size(formWidth, formHeight); // Устанавливаем размер формы
            
            search_btn1.Height = searchCountry_tb.Height;
            search_btn1.Width = search_btn1.Height;
            search_btn1.Location = new Point(searchCountry_tb.Right, search_btn1.Top);

            search_btn2.Height = searchCountry_tb.Height;
            search_btn2.Width = search_btn2.Height;
            search_btn2.Location = new Point(searchGenre_tb.Right, search_btn2.Top);

            search_btn3.Height = searchCountry_tb.Height;
            search_btn3.Width = search_btn3.Height;
            search_btn3.Location = new Point(searchActor_tb.Right, search_btn3.Top);

            search_btn4.Height = searchCountry_tb.Height;
            search_btn4.Width = search_btn4.Height;
            search_btn4.Location = new Point(searchDirector_tb.Right, search_btn4.Top);
        }

        private void searchCountry_tb_Click(object sender, EventArgs e)
        {
            searchCountry_tb.Text = "";
        }

        private void searchGenre_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchGenre_tb_Click(object sender, EventArgs e)
        {
            searchGenre_tb.Text = "";
        }

        private void searchActor_tb_Click(object sender, EventArgs e)
        {
            searchActor_tb.Text = "";
        }

        private void searchDirector_tb_Click(object sender, EventArgs e)
        {
            searchDirector_tb.Text = "";
        }

        private void go_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вы успешно зарегестрированы!");
            Preferences preferences = new Preferences();
            preferences.Show();
        }

        private void countries_list_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

