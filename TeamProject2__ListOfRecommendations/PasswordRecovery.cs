using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using TeamProject1_ToDoList.Classes;
using System.Security.Cryptography;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Net.Configuration;

namespace TeamProject2__ListOfRecommendations
{
    public partial class PasswordRecovery : Form
    {
        public PasswordRecovery(string login)
        {
            InitializeComponent();
            Login = login;
        }
        public string Login;
        public string newPassword;
        public string email;
        public int userId;
        string connectionString = "server=localhost;port=3306;username=root;password=root;database=teamproject_listofrecommendations";
        private void PasswordRecovery_Load(object sender, EventArgs e)
        {

            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            var screenWidth = Screen.PrimaryScreen.Bounds.Width;
            var screenHeight = Screen.PrimaryScreen.Bounds.Height;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point((screenWidth - this.Width) / 2, (screenHeight - this.Height) / 2);
        }

        private void email_tb_Click(object sender, EventArgs e)
        {
            email_tb.Text = string.Empty;
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

        /// <summary>
        /// Отправляем email с кодом
        /// </summary>
        /// <param name="toEmail"></param>
        /// <param name="newPassword"></param>
        public void SendEmail(string toEmail, string newPassword)
        {
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("list_of_recomendations@mail.ru", "Приложение Список рекомендаций"); // адрес отправителя
            try
            {
                mail.To.Add(new MailAddress(toEmail));
            }
            catch
            {
                MessageBox.Show("Форма указанной строки не годится для адреса электронной почты");
            }
            // адрес получателя
            mail.Subject = "Список рекомендаций: восстановление пароля";
            mail.Body = $"Ваш код для сброса пароля: {newPassword}. Пожалуйста, никому его не сообщайте";
            mail.Attachments.Add(new Attachment(@".\..\..\Resources\к письму 2.jpg"));

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


        }
        private void email_tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) // Проверяем, что нажата клавиша Enter
            {
                email = email_tb.Text;

                if (string.IsNullOrEmpty(email))
                {
                    MessageBox.Show("Введите email");
                    return;
                }

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string selectQuery = $"SELECT * FROM `users` WHERE email='{email}'";

                    MySqlCommand command = new MySqlCommand("SELECT id FROM users WHERE email = @Email", connection);
                    command.Parameters.AddWithValue("@Email", email);

                    object result = command.ExecuteScalar();
                    if (result == null)
                    {
                        MessageBox.Show("Введенный вами email неверен");
                    }
                    else
                    {
                        int id = (int)command.ExecuteScalar();

                    }

                    MySqlCommand command1 = new MySqlCommand(selectQuery, connection);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (!reader.HasRows)
                        {
                            return;
                        }

                        reader.Read();
                        newPassword = GeneratePassword();
                        userId = reader.GetInt32(0); // id пользователя в таблице
                        info_lbl.Visible = false;
                        email_tb.Visible = false;
                        reader.Close();

                        MySqlCommand command2 = new MySqlCommand("SELECT id FROM users WHERE login = @Login AND email = @Email", connection);
                        command2.Parameters.AddWithValue("@Email", email);
                        command2.Parameters.AddWithValue("@Login", Login);

                        MySqlDataAdapter adapter = new MySqlDataAdapter();
                        adapter.SelectCommand = command2; // выполняем команду
                        DataTable table = new DataTable();
                        
                        adapter.Fill(table);// записываем данные в объект класса DataTable
                        if (table.Rows.Count > 0)
                        {
                            MessageBox.Show("На указанный email был отправлен код подтверждения");
                            information_lbl.Visible = true;
                            cod_tb.Visible = true;
                            send_btn.Visible = true;

                            SendEmail(email, newPassword);
                        }
                        else
                        {
                            MessageBox.Show("Пользователя с такими логином и email нет");
                        }
                    }
                    connection.Close();
                }
            }
        }

        private void cod_tb_Click(object sender, EventArgs e)
        {
            cod_tb.Text = string.Empty;
        }

        private void send_btn_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string selectQuery = $"SELECT * FROM `users` WHERE email='{email}'";
                    MySqlCommand command = new MySqlCommand(selectQuery, connection);
                    if (newPassword.Equals(cod_tb.Text))
                    {
                        information_lbl.Visible = false;
                        cod_tb.Visible = false;
                        send_btn.Visible = false;
                        changepassword_btn.Visible = true;
                        newpassword_tb.Visible = true;
                        
                    }
                    else
                    {
                        MessageBox.Show("Введенный вами код неверный");
                    }
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка: " + ex.Message);
                }

            }
        }

        private void newpassword_tb_Click(object sender, EventArgs e)
        {
            newpassword_tb.Text = string.Empty;
        }

        private void changepassword_btn_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string selectQuery = $"SELECT * FROM `users` WHERE email='{email}'";
                    MySqlCommand command = new MySqlCommand(selectQuery, connection);
                    string updateQuery = $"UPDATE `users` SET `password`='{newpassword_tb.Text}' WHERE `id`={userId}";
                    command = new MySqlCommand(updateQuery, connection);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Пароль успешно изменен");
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка: " + ex.Message);
                }
            }
        }

    }
}
