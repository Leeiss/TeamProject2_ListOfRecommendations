using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TeamProject2__ListOfRecommendations;
using System.Data;
using TeamProject1_ToDoList.Classes;
using System.Windows.Forms;
using System.Linq;
using System.Data.Entity;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using MySqlX.XDevAPI.Relational;
using System.Reflection.Emit;
using System.Data.SqlClient;

namespace TeamProject2__ListOfRecommendations.Tests
{

    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void FindsOneMatchingRowInDatabase()
        {
            Registration form = new Registration("");
            TextBox textBox = form.Controls["email_tb"] as TextBox;
            textBox.Text = "user@email.com";

            bool containsAtSymbol = textBox.Text.Contains("@");

            Assert.IsTrue(containsAtSymbol);

        }

        [TestMethod]

        public void TestOpenAnotherForm()
        {
            Authorization form1 = new Authorization();
            Button button1 = form1.Controls["go_btn"] as Button;

            button1.PerformClick();

            Assert.IsNull(Application.OpenForms["MainForm"]);
        }

        [TestMethod]

        public void TestTextBoxContainsAsciiCharacters()
        {

            Registration form = new Registration("");
            TextBox textBox = form.Controls["email_tb"] as TextBox;
            textBox.Text = "Something";


            bool containsNonAsciiCharacters = textBox.Text.Any(c => c > 127);


            Assert.IsFalse(containsNonAsciiCharacters);
        }
        [TestMethod]

        public void TestTextBoxContainsLogin()
        {

            Registration form = new Registration("");
            TextBox textBox = form.Controls["login_tb"] as TextBox;
            textBox.Text = "Something";


            bool containsNonAsciiCharacters = textBox.Text.Any(c => c > 127);


            Assert.IsFalse(containsNonAsciiCharacters);
        }

        [TestMethod]
        public void TestFindRowsDatabase()
        {
            DataBase db = new DataBase();
            db.OpenConnection();
            MySqlCommand command1 = new MySqlCommand("SELECT * FROM users WHERE login = 'kirill' and Password = '123' ", db.GetConnection());

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            adapter.SelectCommand = command1;
            DataTable table1 = new DataTable();
            adapter.Fill(table1);
            Assert.IsTrue(table1.Rows.Count == 1);
        }

        [TestMethod]
        public void TestTextBoxContainsPassword()
        {

            Registration form = new Registration("");
            TextBox textBox = form.Controls["password_tb"] as TextBox;
            textBox.Text = "Something";


            bool containsNonAsciiCharacters = textBox.Text.Any(c => c > 127);


            Assert.IsFalse(containsNonAsciiCharacters);
        }

        [TestMethod]
        public void TestUpdateDatabase()
        {
            DataBase db = new DataBase();
            db.OpenConnection();
            MySqlCommand command = new MySqlCommand("INSERT INTO users (`Login`, `Password`, `Email`, `admin_rights`) VALUES('kir', '111', 'email', '1')", db.GetConnection());
            command.ExecuteNonQuery();
            MySqlCommand command1 = new MySqlCommand("SELECT * FROM users WHERE login = 'kir' ", db.GetConnection());

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            adapter.SelectCommand = command1;
            DataTable table1 = new DataTable();
            adapter.Fill(table1);
            Assert.IsTrue(table1.Rows.Count >= 1);


        }

        [TestMethod]
        public void TestRemoveDatabase()
        {
            DataBase db = new DataBase();
            db.OpenConnection();
            MySqlCommand command = new MySqlCommand("INSERT INTO users (`Login`, `Password`, `Email`, `admin_rights`) VALUES('kirya', '111', 'email', '1')", db.GetConnection());
            command.ExecuteNonQuery();

            MySqlCommand command1 = new MySqlCommand("DELETE FROM users WHERE login = 'kirya' ", db.GetConnection());

            MySqlDataAdapter adapter1 = new MySqlDataAdapter();

            adapter1.SelectCommand = command1;
            DataTable table1 = new DataTable();
            adapter1.Fill(table1);

            MySqlCommand command2 = new MySqlCommand("SELECT * FROM users WHERE login = 'kirya' ", db.GetConnection());

            MySqlDataAdapter adapter2 = new MySqlDataAdapter();

            adapter2.SelectCommand = command2;
            DataTable table2 = new DataTable();
            adapter2.Fill(table2);
            Assert.IsTrue(table2.Rows.Count == 0);


        }
        [TestMethod]

        public void TestUpdateDatabaseActors()
        {
            DataBase db = new DataBase();
            db.OpenConnection();
            MySqlCommand command = new MySqlCommand("INSERT INTO film_actors (`Actor`, `FilmId`) VALUES('actor', '1')", db.GetConnection());
            command.ExecuteNonQuery();
            MySqlCommand command1 = new MySqlCommand("SELECT * FROM film_actors WHERE Actor = 'actor' ", db.GetConnection());

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            adapter.SelectCommand = command1;
            DataTable table1 = new DataTable();
            adapter.Fill(table1);
            Assert.IsTrue(table1.Rows.Count >= 1);




        }
        [TestMethod]

        public void TestLabelIsDisplayedOnForm()
        {
            Registration form = new Registration("");
            PictureBox box = form.Controls["picture_logo"] as PictureBox;

            Assert.IsNotNull(box);
        }
    }
}
