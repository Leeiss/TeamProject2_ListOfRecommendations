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
        private string password;

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

            foreach (XmlNode actorNode in doc.SelectNodes("//actors/actor"))
            {
                actors.Add(actorNode.InnerText);
            }

            foreach (XmlNode genreNode in doc.SelectNodes("//genres/genre"))
            {
                genres.Add(genreNode.InnerText);
            }


            // Работа с элементами управления на форме
            picture_logo.SizeMode = PictureBoxSizeMode.StretchImage;

            int buttonOffset = 10; 
            int formWidth = go_to_email.Location.X + go_to_email.Width + buttonOffset; 
            int formHeight = go_to_email.Location.Y + go_to_email.Height + buttonOffset; 
            this.ClientSize = new Size(formWidth, formHeight); 

            var screenWidth = Screen.PrimaryScreen.Bounds.Width;
            var screenHeight = Screen.PrimaryScreen.Bounds.Height;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point((screenWidth - this.Width) / 2, (screenHeight - this.Height) / 2);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
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
            mail.Body = $"{login_tb.Text}, поздравляем Вас с успешной регистрацией!" + Environment.NewLine + "Мы рады приветствовать вас в нашем приложении. Вы можете приступать к выбору фильмов и созданиям подборок!";
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
                        FillWithDefaultEstimates();
                        AddAFavoritesFolderForAUser();

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
            else
            {
                MessageBox.Show("Введите все данные");
            }
        }

        private void AddAFavoritesFolderForAUser()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                MySqlCommand command = connection.CreateCommand();

                command.CommandText = "SELECT ID FROM users WHERE Login = @userLogin";
                command.Parameters.AddWithValue("@userLogin", username);
                int userId = (int)command.ExecuteScalar();

                command.CommandText = "INSERT INTO users_collections (ID, Collection_name, User_name) VALUES (@id, @collectionName, @userName)";
                command.Parameters.AddWithValue("@id", 0);
                command.Parameters.AddWithValue("@collectionName", "Избранное");
                command.Parameters.AddWithValue("@userName", username);
                command.ExecuteNonQuery();

                connection.Close();
            }
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
            email_panel.Visible = false;
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

        private void hide_btn_Click(object sender, EventArgs e)
        {
            password_tb.PasswordChar = '\0';
            hide_btn.Visible = false;
            show_btn.Visible = true;
        }

        private void show_btn_Click(object sender, EventArgs e)
        {
            password_tb.PasswordChar = '*';
            hide_btn.Visible = true;
            show_btn.Visible = false;
        }

        private void password_tb_TextChanged(object sender, EventArgs e)
        {
            password_tb.PasswordChar = '*';
            hide_btn.Visible = true;
        }

        private void hide_btn1_Click(object sender, EventArgs e)
        {
            admin_password_tb.PasswordChar = '\0';
            hide_btn1.Visible = false;
            show_btn1.Visible = true;
        }

        private void show_btn1_Click(object sender, EventArgs e)
        {
            admin_password_tb.PasswordChar = '*';
            hide_btn1.Visible = true;
            show_btn1.Visible = false;
        }

        private void admin_password_tb_TextChanged(object sender, EventArgs e)
        {
            admin_password_tb.PasswordChar = '*';
            hide_btn1.Visible = true;
        }

        private void again_btn_Click(object sender, EventArgs e)
        {
            email_panel.Visible = false;
            admin_password_tb.Text = "";
        }

        /// <summary>
        /// Отправляем email с кодом
        /// </summary>
        /// <param name="toEmail"></param>
        /// <param name="newPassword"></param>
        public void SendEmail(string toEmail, string newPassword)
        {
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("list_of_recomendations@mail.ru", "Приложение Список рекомендаций");
            try
            {
                mail.To.Add(new MailAddress(toEmail));
            }
            catch
            {
                MessageBox.Show("Такого почтового ящика не существует");
            }
            // адрес получателя
            mail.Subject = "Список рекомендаций: подтверждение почты";
            mail.Body = $"Ваш код для подтверждения почты: {newPassword}. Если аккаунт создаете не вы, то, пожалуйста, игнорируйте это письмо";

            SmtpClient smtp = new SmtpClient("smtp.mail.ru"); // адрес сервера SMTP, на котором наша почта
            smtp.Port = 587; // порт, который использует сервер SMTP, обычно 587 или 465
            smtp.EnableSsl = true; // используем SSL-шифрование для защиты от перехвата данных
            smtp.Credentials = new System.Net.NetworkCredential("list_of_recomendations@mail.ru", "xqNDEUbgA3y3MqTk3xnu"); // логин и пароль от нашей учетной записи
            try
            {
                smtp.Send(mail);
            }
            catch
            {
                email_panel.Visible=false;
            }
        }


        /// <summary>
        /// генерируем случайный код
        /// </summary>
        /// <returns></returns>
        public static string GeneratePassword()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var random = new Random();
            var password = new string(Enumerable.Repeat(chars, 4).Select(s => s[random.Next(s.Length)]).ToArray());
            return password;
        }

        private void login_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void go_to_email_Click(object sender, EventArgs e)
        {
            email_panel.Visible = true;
            close_panel.Visible = false;
            if (!login_tb.Text.Equals("") && !password_tb.Text.Equals("") && !email_tb.Text.Equals("") && !login_tb.Text.Equals("Введите логин") && !password_tb.Text.Equals("Введите пароль") && !email_tb.Text.Equals("Введите email"))
            {
                email_panel.Visible = true;
                string email = email_tb.Text;
                if (string.IsNullOrEmpty(email))
                {
                    MessageBox.Show("Введите email");
                    return;
                }
                else
                {
                    password = GeneratePassword();
                    SendEmail(email, password);
                }
            }
            else
            {
                MessageBox.Show("Введите все данные");
                email_panel.Visible = false;
            }
        }

        private void send_kod_email_Click(object sender, EventArgs e)
        {
            if (email_password.Text == password)
            {
                MessageBox.Show("Почтовый ящик подтвержден");
                go_btn.Visible= true;
            }
            else
            {
                MessageBox.Show("Введенный вами код неверный");
            }
        }
    }
}
                    
                        
   
