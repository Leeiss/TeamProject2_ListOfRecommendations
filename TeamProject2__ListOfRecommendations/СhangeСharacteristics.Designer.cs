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
            this.search_actor_tb = new System.Windows.Forms.TextBox();
            this.actors_list = new System.Windows.Forms.ListBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.search_genre_btn = new System.Windows.Forms.TextBox();
            this.genres_list = new System.Windows.Forms.ListBox();
            this.search_country_tb = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.countries_list = new System.Windows.Forms.ListBox();
            this.date1 = new System.Windows.Forms.DateTimePicker();
            this.frame1 = new System.Windows.Forms.Panel();
            this.year_lbl = new System.Windows.Forms.Label();
            this.save_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.add_country_btn = new System.Windows.Forms.Button();
            this.add_genre_btn = new System.Windows.Forms.Button();
            this.add_actor_btn = new System.Windows.Forms.Button();
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
            // search_actor_tb
            // 
            this.search_actor_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(242)))));
            this.search_actor_tb.Font = new System.Drawing.Font("XO Courser", 9F);
            this.search_actor_tb.Location = new System.Drawing.Point(992, 601);
            this.search_actor_tb.Name = "search_actor_tb";
            this.search_actor_tb.Size = new System.Drawing.Size(289, 35);
            this.search_actor_tb.TabIndex = 56;
            this.search_actor_tb.Text = "Поиск по списку..";
            this.search_actor_tb.Click += new System.EventHandler(this.search_actor_tb_Click);
            this.search_actor_tb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.search_actor_tb_KeyDown);
            // 
            // actors_list
            // 
            this.actors_list.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(242)))));
            this.actors_list.Font = new System.Drawing.Font("XO Courser", 9F);
            this.actors_list.FormattingEnabled = true;
            this.actors_list.ItemHeight = 27;
            this.actors_list.Location = new System.Drawing.Point(992, 642);
            this.actors_list.Name = "actors_list";
            this.actors_list.Size = new System.Drawing.Size(289, 166);
            this.actors_list.TabIndex = 55;
            this.actors_list.SelectedIndexChanged += new System.EventHandler(this.actors_list_SelectedIndexChanged);
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
            // search_genre_btn
            // 
            this.search_genre_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(242)))));
            this.search_genre_btn.Font = new System.Drawing.Font("XO Courser", 9F);
            this.search_genre_btn.Location = new System.Drawing.Point(335, 600);
            this.search_genre_btn.Name = "search_genre_btn";
            this.search_genre_btn.Size = new System.Drawing.Size(289, 35);
            this.search_genre_btn.TabIndex = 53;
            this.search_genre_btn.Text = "Поиск по списку..";
            this.search_genre_btn.Click += new System.EventHandler(this.search_genre_btn_Click);
            this.search_genre_btn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.search_genre_btn_KeyDown);
            // 
            // genres_list
            // 
            this.genres_list.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(242)))));
            this.genres_list.Font = new System.Drawing.Font("XO Courser", 9F);
            this.genres_list.FormattingEnabled = true;
            this.genres_list.ItemHeight = 27;
            this.genres_list.Items.AddRange(new object[] {
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
            this.genres_list.Location = new System.Drawing.Point(335, 641);
            this.genres_list.Name = "genres_list";
            this.genres_list.Size = new System.Drawing.Size(289, 166);
            this.genres_list.TabIndex = 49;
            this.genres_list.SelectedIndexChanged += new System.EventHandler(this.genres_list_SelectedIndexChanged);
            // 
            // search_country_tb
            // 
            this.search_country_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(242)))));
            this.search_country_tb.Font = new System.Drawing.Font("XO Courser", 9F);
            this.search_country_tb.Location = new System.Drawing.Point(988, 360);
            this.search_country_tb.Name = "search_country_tb";
            this.search_country_tb.Size = new System.Drawing.Size(293, 35);
            this.search_country_tb.TabIndex = 51;
            this.search_country_tb.Text = "Поиск по списку..";
            this.search_country_tb.Click += new System.EventHandler(this.search_country_tb_Click);
            this.search_country_tb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.search_country_tb_KeyDown);
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
            this.countries_list.Size = new System.Drawing.Size(293, 166);
            this.countries_list.TabIndex = 47;
            this.countries_list.SelectedIndexChanged += new System.EventHandler(this.countries_list_SelectedIndexChanged);
            // 
            // date1
            // 
            this.date1.CalendarMonthBackground = System.Drawing.Color.Silver;
            this.date1.Font = new System.Drawing.Font("XO Courser", 9F);
            this.date1.Location = new System.Drawing.Point(349, 379);
            this.date1.Name = "date1";
            this.date1.Size = new System.Drawing.Size(260, 35);
            this.date1.TabIndex = 43;
            this.date1.TabStop = false;
            this.date1.ValueChanged += new System.EventHandler(this.date1_ValueChanged);
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
            this.year_lbl.Location = new System.Drawing.Point(3, 18);
            this.year_lbl.Name = "year_lbl";
            this.year_lbl.Size = new System.Drawing.Size(213, 33);
            this.year_lbl.TabIndex = 9;
            this.year_lbl.Text = "Дата выхода";
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
            this.save_btn.Visible = false;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
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
            // add_country_btn
            // 
            this.add_country_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.add_country_btn.Font = new System.Drawing.Font("XO Courser", 8F);
            this.add_country_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(242)))));
            this.add_country_btn.Location = new System.Drawing.Point(1124, 546);
            this.add_country_btn.Name = "add_country_btn";
            this.add_country_btn.Size = new System.Drawing.Size(157, 42);
            this.add_country_btn.TabIndex = 112;
            this.add_country_btn.Text = "Добавить";
            this.add_country_btn.UseVisualStyleBackColor = false;
            this.add_country_btn.Visible = false;
            this.add_country_btn.Click += new System.EventHandler(this.add_country_btn_Click);
            // 
            // add_genre_btn
            // 
            this.add_genre_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.add_genre_btn.Font = new System.Drawing.Font("XO Courser", 8F);
            this.add_genre_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(242)))));
            this.add_genre_btn.Location = new System.Drawing.Point(467, 799);
            this.add_genre_btn.Name = "add_genre_btn";
            this.add_genre_btn.Size = new System.Drawing.Size(157, 42);
            this.add_genre_btn.TabIndex = 113;
            this.add_genre_btn.Text = "Добавить";
            this.add_genre_btn.UseVisualStyleBackColor = false;
            this.add_genre_btn.Visible = false;
            this.add_genre_btn.Click += new System.EventHandler(this.add_genre_btn_Click);
            // 
            // add_actor_btn
            // 
            this.add_actor_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.add_actor_btn.Font = new System.Drawing.Font("XO Courser", 8F);
            this.add_actor_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(242)))));
            this.add_actor_btn.Location = new System.Drawing.Point(1124, 799);
            this.add_actor_btn.Name = "add_actor_btn";
            this.add_actor_btn.Size = new System.Drawing.Size(157, 42);
            this.add_actor_btn.TabIndex = 114;
            this.add_actor_btn.Text = "Добавить";
            this.add_actor_btn.UseVisualStyleBackColor = false;
            this.add_actor_btn.Visible = false;
            this.add_actor_btn.Click += new System.EventHandler(this.add_actor_btn_Click);
            // 
            // СhangeСharacteristics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(90)))), ((int)(((byte)(86)))));
            this.ClientSize = new System.Drawing.Size(1339, 936);
            this.Controls.Add(this.add_actor_btn);
            this.Controls.Add(this.add_genre_btn);
            this.Controls.Add(this.add_country_btn);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.search_actor_tb);
            this.Controls.Add(this.actors_list);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.search_genre_btn);
            this.Controls.Add(this.genres_list);
            this.Controls.Add(this.search_country_tb);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.countries_list);
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
        private System.Windows.Forms.TextBox search_actor_tb;
        private System.Windows.Forms.ListBox actors_list;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox search_genre_btn;
        private System.Windows.Forms.ListBox genres_list;
        private System.Windows.Forms.TextBox search_country_tb;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox countries_list;
        private System.Windows.Forms.DateTimePicker date1;
        private System.Windows.Forms.Panel frame1;
        private System.Windows.Forms.Label year_lbl;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button add_country_btn;
        private System.Windows.Forms.Button add_genre_btn;
        private System.Windows.Forms.Button add_actor_btn;
    }
}