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
using System.Windows.Forms;
using TeamProject1_ToDoList.Classes;
using TeamProject2__ListOfRecommendations.Properties;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace TeamProject2__ListOfRecommendations
{
    public partial class Registration : Form
    {
        public Registration(string login)
        {
            InitializeComponent();
            Login = login;  
        }
        public string Login;
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

        private void go_btn_Click(object sender, EventArgs e)
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
            smtp.Credentials = new System.Net.NetworkCredential("list_of_recomendations@mail.ru", "xqNDEUbgA3y3MqTk3xnu"); // логин и пароль от нашей учетной записи
            try
            {
                smtp.Send(mail);
            }
            catch
            {
                MessageBox.Show("Такого почтового ящика не существует");
            }


            if (login_tb.Text != "" & password_tb.Text != "")
            {
                DataBase db = new DataBase();
                db.OpenConnection();
                MySqlCommand command1 = new MySqlCommand("SELECT * FROM users WHERE login = @Ul ", db.GetConnection()); // создаем объект и передаем команду для вытягивания из бд логина и пароля из бд
                command1.Parameters.Add("@Ul", MySqlDbType.VarChar).Value = login_tb.Text;

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
                    MySqlCommand command = new MySqlCommand("INSERT INTO users (`login`, `password`, `email`) VALUES(@login, @password, @email)", db.GetConnection());
                    command.Parameters.Add("@login", MySqlDbType.VarChar).Value = login_tb.Text;
                    command.Parameters.Add("@password", MySqlDbType.VarChar).Value = password_tb.Text;
                    command.Parameters.Add("@email", MySqlDbType.VarChar).Value = email_tb.Text;
                    
                    
                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Отлично! Приступим к подборке рекомендаций");
                        Preferences preferences = new Preferences(Login);
                        preferences.Tag = "зарегистрироваться";
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
                MessageBox.Show("Некорректно введен логин или пароль");
            }
        }

        private void email_tb_Click(object sender, EventArgs e)
        {
            email_tb.Text = string.Empty;
        }

        
    }
}

