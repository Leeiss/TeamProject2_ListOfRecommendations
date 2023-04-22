namespace TeamProject2__ListOfRecommendations
{
    partial class СhangeСharacteristics
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(СhangeСharacteristics));
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.actors_list = new System.Windows.Forms.ListBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.directrors_list = new System.Windows.Forms.ListBox();
            this.searchDirector_tb = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.countries_list = new System.Windows.Forms.ListBox();
            this.date2 = new System.Windows.Forms.DateTimePicker();
            this.to_lbl = new System.Windows.Forms.Label();
            this.from_lbl = new System.Windows.Forms.Label();
            this.date1 = new System.Windows.Forms.DateTimePicker();
            this.frame1 = new System.Windows.Forms.Panel();
            this.year_lbl = new System.Windows.Forms.Label();
            this.save_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.frame1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(162)))), ((int)(((byte)(167)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(714, 360);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(236, 96);
            this.panel3.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("XO Courser", 11F);
            this.label3.Location = new System.Drawing.Point(15, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 33);
            this.label3.TabIndex = 9;
            this.label3.Text = "Страна";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(242)))));
            this.textBox2.Font = new System.Drawing.Font("XO Courser", 9F);
            this.textBox2.Location = new System.Drawing.Point(992, 601);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(289, 35);
            this.textBox2.TabIndex = 56;
            this.textBox2.Text = "Поиск по списку..";
            // 
            // actors_list
            // 
            this.actors_list.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(242)))));
            this.actors_list.Font = new System.Drawing.Font("XO Courser", 9F);
            this.actors_list.FormattingEnabled = true;
            this.actors_list.ItemHeight = 27;
            this.actors_list.Location = new System.Drawing.Point(992, 642);
            this.actors_list.Name = "actors_list";
            this.actors_list.Size = new System.Drawing.Size(289, 85);
            this.actors_list.TabIndex = 55;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(162)))), ((int)(((byte)(167)))));
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(714, 612);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(236, 102);
            this.panel5.TabIndex = 50;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("XO Courser", 11F);
            this.label5.Location = new System.Drawing.Point(15, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 33);
            this.label5.TabIndex = 9;
            this.label5.Text = "Актеры";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(242)))));
            this.textBox1.Font = new System.Drawing.Font("XO Courser", 9F);
            this.textBox1.Location = new System.Drawing.Point(335, 600);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(289, 35);
            this.textBox1.TabIndex = 53;
            this.textBox1.Text = "Поиск по списку..";
            // 
            // directrors_list
            // 
            this.directrors_list.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(242)))));
            this.directrors_list.Font = new System.Drawing.Font("XO Courser", 9F);
            this.directrors_list.FormattingEnabled = true;
            this.directrors_list.ItemHeight = 27;
            this.directrors_list.Items.AddRange(new object[] {
            "Боевик",
            "Вестерн",
            "Детектив",
            "Драма",
            "Исторический фильм",
            "Комедия",
            "Мелодрама",
            "Музыкальный фильм",
            "Нуар",
            "Политический фильм",
            "Приключенческий фильм",
            "Сказка",
            "Трагедия",
            "Трагикомедия",
            "Триллер",
            "Фантастический фильм",
            "Фильм ужасов",
            "Фильм-катастрофа"});
            this.directrors_list.Location = new System.Drawing.Point(335, 641);
            this.directrors_list.Name = "directrors_list";
            this.directrors_list.Size = new System.Drawing.Size(289, 85);
            this.directrors_list.TabIndex = 49;
            // 
            // searchDirector_tb
            // 
            this.searchDirector_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(242)))));
            this.searchDirector_tb.Font = new System.Drawing.Font("XO Courser", 9F);
            this.searchDirector_tb.Location = new System.Drawing.Point(988, 360);
            this.searchDirector_tb.Name = "searchDirector_tb";
            this.searchDirector_tb.Size = new System.Drawing.Size(293, 35);
            this.searchDirector_tb.TabIndex = 51;
            this.searchDirector_tb.Text = "Поиск по списку..";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(162)))), ((int)(((byte)(167)))));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(34, 612);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(236, 102);
            this.panel4.TabIndex = 48;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("XO Courser", 11F);
            this.label4.Location = new System.Drawing.Point(15, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 33);
            this.label4.TabIndex = 9;
            this.label4.Text = "Жанр";
            // 
            // countries_list
            // 
            this.countries_list.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(242)))));
            this.countries_list.Font = new System.Drawing.Font("XO Courser", 9F);
            this.countries_list.FormattingEnabled = true;
            this.countries_list.ItemHeight = 27;
            this.countries_list.Items.AddRange(new object[] {
            "Австралия ",
            "Австрия ",
            "Азербайджан ",
            "Албания ",
            "Алжир ",
            "Англия ",
            "Ангилья ",
            "Ангола ",
            "Андорра ",
            "Антигуа и Барбуда ",
            "Аргентина ",
            "Армения ",
            "Аруба ",
            "Багамы ",
            "Бангладеш ",
            "Барбадос ",
            "Бахрейн ",
            "Беларусь ",
            "Белиз ",
            "Бельгия ",
            "Бенин ",
            "Бермудские Острова ",
            "Болгария ",
            "Боливия ",
            "Босния и Герцеговина ",
            "Ботсвана ",
            "Бразилия ",
            "Бруней ",
            "Буркина-Фасо ",
            "Бурунди ",
            "Вануату ",
            "Великобритания ",
            "Венгрия ",
            "Венесуэла ",
            "Вьетнам ",
            "Габон ",
            "Гаити ",
            "Гайана ",
            "Гамбия ",
            "Гана ",
            "Гваделупа ",
            "Гватемала ",
            "Гвинея ",
            "Гвинея-Бисау ",
            "Германия ",
            "Гибралтар ",
            "Гондурас ",
            "Гренада ",
            "Гренландия ",
            "Греция ",
            "Грузия ",
            "Дания ",
            "Джерси ",
            "Джибути ",
            "Доминика ",
            "Доминиканская Республика ",
            "Египет ",
            "Замбия ",
            "Западная Сахара ",
            "Зимбабве ",
            "Израиль ",
            "Индия ",
            "Индонезия ",
            "Иордания ",
            "Ирак ",
            "Иран ",
            "Ирландия ",
            "Исландия ",
            "Испания ",
            "Италия ",
            "Йемен ",
            "Кабо-Верде ",
            "Казахстан ",
            "Камбоджа ",
            "Камерун ",
            "Канада ",
            "Катар ",
            "Кения ",
            "Кипр ",
            "Киргизия ",
            "Китай ",
            "Колумбия ",
            "Коморы ",
            "Коста-Рика ",
            "Кот-д\'Ивуар ",
            "Куба ",
            "Кувейт ",
            "Лаос ",
            "Латвия ",
            "Лесото ",
            "Либерия ",
            "Ливан ",
            "Ливия ",
            "Литва ",
            "Лихтенштейн ",
            "Люксембург ",
            "Маврикий ",
            "Мавритания ",
            "Мадагаскар ",
            "Македония ",
            "Малави ",
            "Малайзия ",
            "Мали ",
            "Мальдивы ",
            "Мальта ",
            "Марокко ",
            "Мартиника ",
            "Мексика ",
            "Микронезия ",
            "Мозамбик ",
            "Молдова ",
            "Монако ",
            "Монголия ",
            "Монтсеррат ",
            "Мьянма ",
            "Намибия ",
            "Непал ",
            "Нигер ",
            "Нигерия ",
            "Нидерланды ",
            "Никарагуа ",
            "Новая Зеландия ",
            "Новая Каледония ",
            "Норвегия ",
            "Объединенные Арабские Эмираты ",
            "Оман ",
            "Остров Мэн ",
            "Острова Кука ",
            "Острова Теркс и Кайкос ",
            "Острова Уоллис и Футуна ",
            "Пакистан ",
            "Палау ",
            "Палестина ",
            "Панама ",
            "Папуа – Новая Гвинея ",
            "Парагвай ",
            "Перу ",
            "Польша ",
            "Португалия ",
            "Пуэрто-Рико ",
            "Реюньон ",
            "Россия ",
            "Руанда ",
            "Румыния ",
            "Сальвадор ",
            "Самоа ",
            "Сан-Марино ",
            "Сан-Томе и Принсипи ",
            "Саудовская Аравия ",
            "Святая Люсия ",
            "Святой Винсент и Гренадины ",
            "Северные Марианские острова ",
            "Сенегал ",
            "Сент-Китс и Невис ",
            "Сент-Люсия ",
            "Сербия ",
            "Сейшельские Острова ",
            "Сен-Пьер и Микелон ",
            "Сингапур ",
            "Сирия ",
            "Словакия ",
            "Словения ",
            "Сомали ",
            "Судан ",
            "Суринам ",
            "США ",
            "Сьерра-Леоне ",
            "Таджикистан ",
            "Таиланд ",
            "Танзания ",
            "Того ",
            "Токелау ",
            "Тонга ",
            "Тринидад и Тобаго ",
            "Тувалу ",
            "Тунис ",
            "Туркменистан ",
            "Турция ",
            "Уганда ",
            "Узбекистан ",
            "Украина ",
            "Уругвай ",
            "Фиджи ",
            "Филиппины ",
            "Финляндия ",
            "Франция ",
            "Французская Гвиана ",
            "Французская Полинезия ",
            "Хорватия ",
            "Центральноафриканская Республика ",
            "Чад ",
            "Черногория ",
            "Чехия ",
            "Чили ",
            "Швейцария ",
            "Швеция ",
            "Шри-Ланка ",
            "Эквадор ",
            "Экваториальная Гвинея ",
            "Эритрея ",
            "Эстония ",
            "Эфиопия ",
            "Южная Африка ",
            "Южная Корея ",
            "Ямайка ",
            "Япония"});
            this.countries_list.Location = new System.Drawing.Point(988, 401);
            this.countries_list.Name = "countries_list";
            this.countries_list.Size = new System.Drawing.Size(293, 85);
            this.countries_list.TabIndex = 47;
            // 
            // date2
            // 
            this.date2.CalendarMonthBackground = System.Drawing.Color.Gray;
            this.date2.Font = new System.Drawing.Font("XO Courser", 9F);
            this.date2.Location = new System.Drawing.Point(364, 414);
            this.date2.Name = "date2";
            this.date2.Size = new System.Drawing.Size(260, 35);
            this.date2.TabIndex = 45;
            // 
            // to_lbl
            // 
            this.to_lbl.AutoSize = true;
            this.to_lbl.Font = new System.Drawing.Font("XO Courser", 9F);
            this.to_lbl.Location = new System.Drawing.Point(304, 420);
            this.to_lbl.Name = "to_lbl";
            this.to_lbl.Size = new System.Drawing.Size(54, 27);
            this.to_lbl.TabIndex = 44;
            this.to_lbl.Text = "до-";
            // 
            // from_lbl
            // 
            this.from_lbl.AutoSize = true;
            this.from_lbl.Font = new System.Drawing.Font("XO Courser", 9F);
            this.from_lbl.Location = new System.Drawing.Point(304, 363);
            this.from_lbl.Name = "from_lbl";
            this.from_lbl.Size = new System.Drawing.Size(54, 27);
            this.from_lbl.TabIndex = 41;
            this.from_lbl.Text = "от-";
            // 
            // date1
            // 
            this.date1.CalendarMonthBackground = System.Drawing.Color.Silver;
            this.date1.Font = new System.Drawing.Font("XO Courser", 9F);
            this.date1.Location = new System.Drawing.Point(364, 357);
            this.date1.Name = "date1";
            this.date1.Size = new System.Drawing.Size(260, 35);
            this.date1.TabIndex = 43;
            this.date1.TabStop = false;
            // 
            // frame1
            // 
            this.frame1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(162)))), ((int)(((byte)(167)))));
            this.frame1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.frame1.Controls.Add(this.year_lbl);
            this.frame1.Location = new System.Drawing.Point(34, 354);
            this.frame1.Name = "frame1";
            this.frame1.Size = new System.Drawing.Size(236, 102);
            this.frame1.TabIndex = 42;
            // 
            // year_lbl
            // 
            this.year_lbl.AutoSize = true;
            this.year_lbl.Font = new System.Drawing.Font("XO Courser", 11F);
            this.year_lbl.Location = new System.Drawing.Point(15, 12);
            this.year_lbl.Name = "year_lbl";
            this.year_lbl.Size = new System.Drawing.Size(195, 66);
            this.year_lbl.TabIndex = 9;
            this.year_lbl.Text = "Временной\r\nпромежуток";
            // 
            // save_btn
            // 
            this.save_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(210)))), ((int)(((byte)(219)))));
            this.save_btn.Font = new System.Drawing.Font("XO Courser", 9F);
            this.save_btn.Location = new System.Drawing.Point(1132, 866);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(195, 47);
            this.save_btn.TabIndex = 58;
            this.save_btn.Text = "Сохранить";
            this.save_btn.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(162)))), ((int)(((byte)(167)))));
            this.panel1.Location = new System.Drawing.Point(0, 174);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1378, 13);
            this.panel1.TabIndex = 59;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(595, 109);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 146);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // СhangeСharacteristics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(90)))), ((int)(((byte)(86)))));
            this.ClientSize = new System.Drawing.Size(1339, 936);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.actors_list);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.directrors_list);
            this.Controls.Add(this.searchDirector_tb);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.countries_list);
            this.Controls.Add(this.date2);
            this.Controls.Add(this.to_lbl);
            this.Controls.Add(this.from_lbl);
            this.Controls.Add(this.date1);
            this.Controls.Add(this.frame1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "СhangeСharacteristics";
            this.Text = "Изменение характеристик";
            this.Load += new System.EventHandler(this.СhangeСharacteristics_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.frame1.ResumeLayout(false);
            this.frame1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ListBox actors_list;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox directrors_list;
        private System.Windows.Forms.TextBox searchDirector_tb;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox countries_list;
        private System.Windows.Forms.DateTimePicker date2;
        private System.Windows.Forms.Label to_lbl;
        private System.Windows.Forms.Label from_lbl;
        private System.Windows.Forms.DateTimePicker date1;
        private System.Windows.Forms.Panel frame1;
        private System.Windows.Forms.Label year_lbl;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Panel panel1;
    }
}