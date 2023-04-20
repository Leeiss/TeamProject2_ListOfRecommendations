namespace TeamProject2__ListOfRecommendations
{
    partial class Preferences
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Preferences));
            this.info_lbl2 = new System.Windows.Forms.Label();
            this.info_lbl3 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.info_lbl4 = new System.Windows.Forms.Label();
            this.panel_lateral = new System.Windows.Forms.Panel();
            this.searchGenre_tb = new System.Windows.Forms.TextBox();
            this.searchActor_tb = new System.Windows.Forms.TextBox();
            this.actors_list = new System.Windows.Forms.ListBox();
            this.genres_list = new System.Windows.Forms.ListBox();
            this.closing_panel = new System.Windows.Forms.Panel();
            this.go_btn = new System.Windows.Forms.Button();
            this.next_btn = new System.Windows.Forms.Button();
            this.info_lbl5 = new System.Windows.Forms.Label();
            this.add_genre = new System.Windows.Forms.Button();
            this.add_actor = new System.Windows.Forms.Button();
            this.info_lbl1 = new System.Windows.Forms.Label();
            this.search_genre_btn = new System.Windows.Forms.Button();
            this.search_actor_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // info_lbl2
            // 
            this.info_lbl2.AutoSize = true;
            this.info_lbl2.Font = new System.Drawing.Font("Stencil", 22.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info_lbl2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(242)))));
            this.info_lbl2.Location = new System.Drawing.Point(75, 169);
            this.info_lbl2.Name = "info_lbl2";
            this.info_lbl2.Size = new System.Drawing.Size(483, 70);
            this.info_lbl2.TabIndex = 2;
            this.info_lbl2.Text = "рекомендации, \r\n";
            // 
            // info_lbl3
            // 
            this.info_lbl3.AutoSize = true;
            this.info_lbl3.Font = new System.Drawing.Font("Stencil", 22.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info_lbl3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(162)))), ((int)(((byte)(167)))));
            this.info_lbl3.Location = new System.Drawing.Point(75, 248);
            this.info_lbl3.Name = "info_lbl3";
            this.info_lbl3.Size = new System.Drawing.Size(898, 70);
            this.info_lbl3.TabIndex = 3;
            this.info_lbl3.Text = "нам нужно лучше о вас узнать";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // info_lbl4
            // 
            this.info_lbl4.AutoSize = true;
            this.info_lbl4.Font = new System.Drawing.Font("Stencil", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info_lbl4.Location = new System.Drawing.Point(67, 349);
            this.info_lbl4.Name = "info_lbl4";
            this.info_lbl4.Size = new System.Drawing.Size(605, 44);
            this.info_lbl4.TabIndex = 8;
            this.info_lbl4.Text = "Выберите ваши любимые жанры:";
            // 
            // panel_lateral
            // 
            this.panel_lateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(162)))), ((int)(((byte)(167)))));
            this.panel_lateral.Location = new System.Drawing.Point(57, 73);
            this.panel_lateral.Name = "panel_lateral";
            this.panel_lateral.Size = new System.Drawing.Size(12, 249);
            this.panel_lateral.TabIndex = 10;
            // 
            // searchGenre_tb
            // 
            this.searchGenre_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(242)))));
            this.searchGenre_tb.Font = new System.Drawing.Font("XO Courser", 9F);
            this.searchGenre_tb.Location = new System.Drawing.Point(724, 514);
            this.searchGenre_tb.Name = "searchGenre_tb";
            this.searchGenre_tb.Size = new System.Drawing.Size(408, 35);
            this.searchGenre_tb.TabIndex = 23;
            this.searchGenre_tb.Text = "Поиск по списку..";
            this.searchGenre_tb.Click += new System.EventHandler(this.searchGenre_tb_Click);
            // 
            // searchActor_tb
            // 
            this.searchActor_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(242)))));
            this.searchActor_tb.Font = new System.Drawing.Font("XO Courser", 9F);
            this.searchActor_tb.Location = new System.Drawing.Point(724, 514);
            this.searchActor_tb.Name = "searchActor_tb";
            this.searchActor_tb.Size = new System.Drawing.Size(408, 35);
            this.searchActor_tb.TabIndex = 27;
            this.searchActor_tb.Text = "Поиск по списку..";
            this.searchActor_tb.Click += new System.EventHandler(this.searchActor_tb_Click);
            // 
            // actors_list
            // 
            this.actors_list.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(242)))));
            this.actors_list.Font = new System.Drawing.Font("Stencil", 10.875F, System.Drawing.FontStyle.Bold);
            this.actors_list.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(162)))), ((int)(((byte)(167)))));
            this.actors_list.FormattingEnabled = true;
            this.actors_list.ItemHeight = 34;
            this.actors_list.Items.AddRange(new object[] {
            "Брэд Питт",
            "Леонардо Ди Каприо",
            "Том Круз",
            "Роберт Дауни мл.",
            "Дуэйн Джонсон",
            "Скарлетт Йоханссон",
            "Анджелина Джоли",
            "Джонни Депп",
            "Крис Хемсворт",
            "Дженнифер Лоуренс",
            "Райан Рейнольдс",
            "Гэл Гадот",
            "Уилл Смит",
            "Эмма Стоун",
            "Марго Робби",
            "Крис Эванс",
            "Сэмюэл Л. Джексон",
            "Натали Портман",
            "Харрисон Форд",
            "Кристен Стюарт",
            "Шарлиз Терон",
            "Мерил Стрип",
            "Хоакин Феникс",
            "Кристиан Бэйл",
            "Идрис Эльба",
            "Том Харди",
            "Сирша Ронан",
            "Мэтью МакКонахи",
            "Энн Хэтэуэй",
            "Роберт Паттинсон",
            "Кейт Бланшетт",
            "Мелисса Маккарти",
            "Эмма Уотсон",
            "Бен Аффлек",
            "Марк Уолберг",
            "Лиам Нисон",
            "Рассел Кроу",
            "Майкл Б. Джордан",
            "Зак Эфрон",
            "Дженнифер Энистон",
            "Сет Роген",
            ""});
            this.actors_list.Location = new System.Drawing.Point(103, 555);
            this.actors_list.Name = "actors_list";
            this.actors_list.Size = new System.Drawing.Size(1067, 344);
            this.actors_list.TabIndex = 26;
            this.actors_list.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.actors_list_DrawItem);
            this.actors_list.SelectedIndexChanged += new System.EventHandler(this.actors_list_SelectedIndexChanged);
            // 
            // genres_list
            // 
            this.genres_list.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(242)))));
            this.genres_list.Font = new System.Drawing.Font("Stencil", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genres_list.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(162)))), ((int)(((byte)(167)))));
            this.genres_list.FormattingEnabled = true;
            this.genres_list.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.genres_list.ItemHeight = 34;
            this.genres_list.Items.AddRange(new object[] {
            "Комедия  ",
            "Драма  ",
            "Триллер  ",
            "Боевик  ",
            "Фантастика  ",
            "Ужасы  ",
            "Мелодрама  ",
            "Аниме  ",
            "Детектив  ",
            "Исторический  ",
            "Музыкальный  ",
            "Военный  ",
            "Фэнтези  ",
            "Приключения  ",
            "Семейный  ",
            "Спортивный  ",
            "Документальный ",
            ""});
            this.genres_list.Location = new System.Drawing.Point(104, 555);
            this.genres_list.Name = "genres_list";
            this.genres_list.Size = new System.Drawing.Size(1068, 378);
            this.genres_list.TabIndex = 22;
            this.genres_list.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.genres_list_DrawItem);
            this.genres_list.SelectedIndexChanged += new System.EventHandler(this.genres_list_SelectedIndexChanged);
            // 
            // closing_panel
            // 
            this.closing_panel.Location = new System.Drawing.Point(24, 405);
            this.closing_panel.Name = "closing_panel";
            this.closing_panel.Size = new System.Drawing.Size(1594, 695);
            this.closing_panel.TabIndex = 33;
            // 
            // go_btn
            // 
            this.go_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(162)))), ((int)(((byte)(167)))));
            this.go_btn.Font = new System.Drawing.Font("XO Courser", 10F);
            this.go_btn.Location = new System.Drawing.Point(962, 1032);
            this.go_btn.Name = "go_btn";
            this.go_btn.Size = new System.Drawing.Size(339, 52);
            this.go_btn.TabIndex = 7;
            this.go_btn.Text = "Зарегестрироваться";
            this.go_btn.UseVisualStyleBackColor = false;
            this.go_btn.Visible = false;
            this.go_btn.Click += new System.EventHandler(this.go_btn_Click);
            // 
            // next_btn
            // 
            this.next_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(162)))), ((int)(((byte)(167)))));
            this.next_btn.Font = new System.Drawing.Font("XO Courser", 10F);
            this.next_btn.Location = new System.Drawing.Point(1083, 1032);
            this.next_btn.Name = "next_btn";
            this.next_btn.Size = new System.Drawing.Size(218, 52);
            this.next_btn.TabIndex = 31;
            this.next_btn.Text = "Далее";
            this.next_btn.UseVisualStyleBackColor = false;
            this.next_btn.Visible = false;
            this.next_btn.Click += new System.EventHandler(this.next_btn_Click);
            // 
            // info_lbl5
            // 
            this.info_lbl5.AutoSize = true;
            this.info_lbl5.Font = new System.Drawing.Font("Stencil", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info_lbl5.Location = new System.Drawing.Point(63, 349);
            this.info_lbl5.Name = "info_lbl5";
            this.info_lbl5.Size = new System.Drawing.Size(634, 44);
            this.info_lbl5.TabIndex = 32;
            this.info_lbl5.Text = "Выберите ваших любимых актеров";
            this.info_lbl5.Visible = false;
            // 
            // add_genre
            // 
            this.add_genre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(162)))), ((int)(((byte)(167)))));
            this.add_genre.Font = new System.Drawing.Font("XO Courser", 10F);
            this.add_genre.Location = new System.Drawing.Point(553, 951);
            this.add_genre.Name = "add_genre";
            this.add_genre.Size = new System.Drawing.Size(218, 44);
            this.add_genre.TabIndex = 33;
            this.add_genre.Text = "Добавить";
            this.add_genre.UseVisualStyleBackColor = false;
            this.add_genre.Visible = false;
            this.add_genre.Click += new System.EventHandler(this.add_genre_Click);
            // 
            // add_actor
            // 
            this.add_actor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(162)))), ((int)(((byte)(167)))));
            this.add_actor.Font = new System.Drawing.Font("XO Courser", 10F);
            this.add_actor.Location = new System.Drawing.Point(553, 939);
            this.add_actor.Name = "add_actor";
            this.add_actor.Size = new System.Drawing.Size(218, 56);
            this.add_actor.TabIndex = 34;
            this.add_actor.Text = "Добавить";
            this.add_actor.UseVisualStyleBackColor = false;
            this.add_actor.Visible = false;
            this.add_actor.Click += new System.EventHandler(this.add_actor_Click);
            // 
            // info_lbl1
            // 
            this.info_lbl1.AutoSize = true;
            this.info_lbl1.Font = new System.Drawing.Font("Stencil", 22.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info_lbl1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(242)))));
            this.info_lbl1.Location = new System.Drawing.Point(75, 99);
            this.info_lbl1.Name = "info_lbl1";
            this.info_lbl1.Size = new System.Drawing.Size(684, 70);
            this.info_lbl1.TabIndex = 35;
            this.info_lbl1.Text = "Чтобы создать для вас";
            // 
            // search_genre_btn
            // 
            this.search_genre_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("search_genre_btn.BackgroundImage")));
            this.search_genre_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.search_genre_btn.Location = new System.Drawing.Point(1129, 512);
            this.search_genre_btn.Name = "search_genre_btn";
            this.search_genre_btn.Size = new System.Drawing.Size(41, 37);
            this.search_genre_btn.TabIndex = 25;
            this.search_genre_btn.UseVisualStyleBackColor = true;
            // 
            // search_actor_btn
            // 
            this.search_actor_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("search_actor_btn.BackgroundImage")));
            this.search_actor_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.search_actor_btn.Location = new System.Drawing.Point(1130, 512);
            this.search_actor_btn.Name = "search_actor_btn";
            this.search_actor_btn.Size = new System.Drawing.Size(42, 37);
            this.search_actor_btn.TabIndex = 30;
            this.search_actor_btn.UseVisualStyleBackColor = true;
            this.search_actor_btn.Click += new System.EventHandler(this.search_btn3_Click);
            // 
            // Preferences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(90)))), ((int)(((byte)(86)))));
            this.ClientSize = new System.Drawing.Size(1313, 1096);
            this.Controls.Add(this.info_lbl1);
            this.Controls.Add(this.closing_panel);
            this.Controls.Add(this.add_actor);
            this.Controls.Add(this.add_genre);
            this.Controls.Add(this.next_btn);
            this.Controls.Add(this.searchActor_tb);
            this.Controls.Add(this.searchGenre_tb);
            this.Controls.Add(this.search_genre_btn);
            this.Controls.Add(this.panel_lateral);
            this.Controls.Add(this.info_lbl4);
            this.Controls.Add(this.info_lbl3);
            this.Controls.Add(this.info_lbl2);
            this.Controls.Add(this.go_btn);
            this.Controls.Add(this.info_lbl5);
            this.Controls.Add(this.search_actor_btn);
            this.Controls.Add(this.actors_list);
            this.Controls.Add(this.genres_list);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(242)))));
            this.Name = "Preferences";
            this.Text = "Ваши предпочтения";
            this.Load += new System.EventHandler(this.Preferences_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label info_lbl2;
        private System.Windows.Forms.Label info_lbl3;
        private System.Windows.Forms.Label info_lbl4;
        public System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Panel panel_lateral;
        private System.Windows.Forms.TextBox searchGenre_tb;
        private System.Windows.Forms.TextBox searchActor_tb;
        private System.Windows.Forms.ListBox actors_list;
        private System.Windows.Forms.ListBox genres_list;
        private System.Windows.Forms.Button search_genre_btn;
        private System.Windows.Forms.Button search_actor_btn;
        private System.Windows.Forms.Panel closing_panel;
        private System.Windows.Forms.Button go_btn;
        private System.Windows.Forms.Button next_btn;
        private System.Windows.Forms.Label info_lbl5;
        private System.Windows.Forms.Button add_genre;
        private System.Windows.Forms.Button add_actor;
        private System.Windows.Forms.Label info_lbl1;
    }
}