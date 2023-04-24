using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Xml;
using TeamProject1_ToDoList.Classes;
using TeamProject2__ListOfRecommendations.Properties;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace TeamProject2__ListOfRecommendations
{
    public partial class Registration : Form
    {
        public Registration(string login)
        {
            InitializeComponent();
        }
        List<string> actors = new List<string>();
        List<string> genres = new List<string>();
        private int AdminRight = 0;
        private string connectionString = "server=localhost;port=3306;username=root;password=root;database=teamproject_listofrecommendations";
        private string username;
        private void password_tb_Click(object sender, EventArgs e)
        {
            password_tb.Text = "";
        }

        private void login_tb_Click(object sender, EventArgs e)
        {
            login_tb.Text = "";
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("@./../../../ForLists.xml");

            // добавляем все актеры в лист actors
            foreach (XmlNode actorNode in doc.SelectNodes("//actors/actor"))
            {
                actors.Add(actorNode.InnerText);
            }

            // добавляем все жанры в лист genres
            foreach (XmlNode genreNode in doc.SelectNodes("//genres/genre"))
            {
                genres.Add(genreNode.InnerText);
            }


            // Работа с элементами управления на форме
            picture_logo.SizeMode = PictureBoxSizeMode.StretchImage;

            int buttonOffset = 10; // Размер отступа (10 мм)
            int formWidth = go_btn.Location.X + go_btn.Width + buttonOffset; // Вычисляем желаемую ширину формы
            int formHeight = go_btn.Location.Y + go_btn.Height + buttonOffset; // Вычисляем желаемую высоту формы
            this.ClientSize = new Size(formWidth, formHeight); // Устанавливаем размер формы

            var screenWidth = Screen.PrimaryScreen.Bounds.Width;
            var screenHeight = Screen.PrimaryScreen.Bounds.Height;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point((screenWidth - this.Width) / 2, (screenHeight - this.Height) / 2);
        }

        private void SendEmail()
        {
            // Отправляем письмо об успешной регистрации
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("list_of_recomendations@mail.ru", "Приложение Список рекомендаций"); // адрес отправителя
            try
            {
                mail.To.Add(new MailAddress(email_tb.Text, login_tb.Text));
            }
            catch
            {
                MessageBox.Show("Форма указанной строки не годится для адреса электронной почты");
            }
            // адрес получателя
            mail.Subject = "Добро пожаловать в Список рекомендаций!"; ;
            mail.Body = $"{login_tb.Text}, поздравляем тебя с успешной регистрацией!" + Environment.NewLine + "Мы рады приветствовать вас в нашем приложении. Вы можете приступать к выбору фильма, созданию подборок и к добавлению фильмов!";
            mail.Attachments.Add(new Attachment(@".\..\..\Resources\к письму.jpg"));

            SmtpClient smtp = new SmtpClient("smtp.mail.ru"); // адрес сервера SMTP, на котором наша почта
            smtp.Port = 587; // порт, который использует сервер SMTP, обычно 587 или 465
            smtp.EnableSsl = true; // используем SSL-шифрование для защиты от перехвата данных
            smtp.Credentials = new System.Net.NetworkCredential("list_of_recomendations@mail.ru", "xqNDEUbgA3y3MqTk3xnu"); 
            try
            {
                smtp.Send(mail);
            }
            catch
            {
                MessageBox.Show("Такого почтового ящика не существует");
            }

        }

        private void go_btn_Click(object sender, EventArgs e)
        {
            if (!login_tb.Text.Equals("") && !password_tb.Text.Equals("") && !email_tb.Text.Equals("") && !login_tb.Text.Equals("Введите логин") && !password_tb.Text.Equals("Введите пароль") && !email_tb.Text.Equals("Введите email"))
            {
                username = login_tb.Text;
                DataBase db = new DataBase();
                db.OpenConnection();
                MySqlCommand command1 = new MySqlCommand("SELECT * FROM users WHERE login = @Ul ", db.GetConnection()); // создаем объект и передаем команду для вытягивания из бд логина и пароля из бд
                command1.Parameters.Add("@Ul", MySqlDbType.VarChar).Value = username;

                MySqlCommand command2 = new MySqlCommand("SELECT * FROM users WHERE email = @UE ", db.GetConnection()); // создаем объект и передаем команду для вытягивания из бд логина и пароля из бд
                command2.Parameters.Add("@UE", MySqlDbType.VarChar).Value = email_tb.Text;

                MySqlDataAdapter adapter = new MySqlDataAdapter();

                adapter.SelectCommand = command1;
                DataTable table1 = new DataTable();
                adapter.Fill(table1);// записываем данные в объект класса DataTable

                adapter.SelectCommand = command2;
                DataTable table2 = new DataTable();
                adapter.Fill(table2);

                if (table1.Rows.Count == 0 && table2.Rows.Count == 0)
                {
                    MySqlCommand command = new MySqlCommand("INSERT INTO users (`login`, `password`, `email`, `admin_rights`) VALUES(@login, @password, @email, @admin_rights)", db.GetConnection());
                    command.Parameters.Add("@login", MySqlDbType.VarChar).Value = username;
                    command.Parameters.Add("@password", MySqlDbType.VarChar).Value = password_tb.Text;
                    command.Parameters.Add("@email", MySqlDbType.VarChar).Value = email_tb.Text;
                    command.Parameters.Add("@admin_rights", MySqlDbType.VarChar).Value = AdminRight;

                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Отлично! Приступим к подборке рекомендаций");
                        Preferences preferences = new Preferences(username);
                        SendEmail();
                        preferences.Show();
                    }
                    else
                    {
                        MessageBox.Show("Ошибка");
                    }
                    db.CloseConnection();
                    Close();
                }
                else
                {
                    MessageBox.Show("Введенные вами логин или email уже были раннее зарегестрированы");
                }
            }
            FillWithDefaultEstimates();



        }


        private void FillWithDefaultEstimates()
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            foreach (string genre in genres)
            {
                MySqlCommand command = new MySqlCommand("INSERT INTO users_genres_rating (Username, Genrename, RatingGenre, MarksCount) VALUES (@username, @genre, 5, 0)", connection);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@genre", genre);
                command.ExecuteNonQuery();
            }

            foreach (string actor in actors)
            {
                MySqlCommand command = new MySqlCommand("INSERT INTO users_actors_rating (Username, Actorname, RatingActor, MarksCount) VALUES (@username, @actor, 5, 0)", connection);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@actor", actor);
                command.ExecuteNonQuery();
            }
            connection.Close();
        }



        private void email_tb_Click(object sender, EventArgs e)
        {
            email_tb.Text = string.Empty;
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void administration_btn_MouseEnter(object sender, EventArgs e)
        {
            administration_btn.ForeColor = Color.FromArgb(197, 210, 219);
        }

       private void administration_btn_MouseLeave(object sender, EventArgs e)
        {
            administration_btn.ForeColor = Color.FromArgb(133, 162, 167);
        }

        private void administration_btn_Click(object sender, EventArgs e)
        {
            close_panel.Visible = true;
            admin_btn.Visible = true;
            admin_password_tb.Visible = true;
            info_lbl1.Visible = true;
            adminrights_btn_cancel.Visible = true;
        }

        private void admin_btn_Click(object sender, EventArgs e)
        {
            close_panel.Visible = false;
            admin_btn.Visible = false;
            admin_password_tb.Visible = false;
            info_lbl1.Visible = false;
            adminrights_btn_cancel.Visible = false;


            if (admin_password_tb.Text.Equals(string.Empty)) 
            {
                MessageBox.Show("Вы ничего не ввели");
            }
            else if (admin_password_tb.Text.Equals("admin"))
            {
                AdminRight = 1;
                admin_btn.Visible = false;
                MessageBox.Show("Права админа подтверждены");
            }
            else
            {
                MessageBox.Show("Пароль неверный");
            }
        }

        private void adminrights_btn_cancel_Click(object sender, EventArgs e)
        {
            close_panel.Visible = false;
            admin_btn.Visible = false;
            admin_password_tb.Visible = false;
            info_lbl1.Visible = false;
            adminrights_btn_cancel.Visible = false;
        }

        private void Registration_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}

