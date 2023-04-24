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
            this.info_lbl2 = new System.Windows.Forms.Label();
            this.info_lbl3 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.info_lbl4 = new System.Windows.Forms.Label();
            this.panel_lateral = new System.Windows.Forms.Panel();
            this.actors_list = new System.Windows.Forms.ListBox();
            this.genres_list = new System.Windows.Forms.ListBox();
            this.closing_panel = new System.Windows.Forms.Panel();
            this.go_btn = new System.Windows.Forms.Button();
            this.info_lbl5 = new System.Windows.Forms.Label();
            this.add_genre = new System.Windows.Forms.Button();
            this.add_actor = new System.Windows.Forms.Button();
            this.info_lbl1 = new System.Windows.Forms.Label();
            this.next_btn = new System.Windows.Forms.Button();
            this.skip_btn = new System.Windows.Forms.Button();
            this.search_actor = new System.Windows.Forms.TextBox();
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
            // actors_list
            // 
            this.actors_list.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.actors_list.Font = new System.Drawing.Font("Stencil", 10.875F, System.Drawing.FontStyle.Bold);
            this.actors_list.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(162)))), ((int)(((byte)(167)))));
            this.actors_list.FormattingEnabled = true;
            this.actors_list.ItemHeight = 34;
            this.actors_list.Location = new System.Drawing.Point(57, 453);
            this.actors_list.Name = "actors_list";
            this.actors_list.Size = new System.Drawing.Size(1177, 548);
            this.actors_list.TabIndex = 26;
            this.actors_list.Visible = false;
            this.actors_list.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.actors_list_DrawItem);
            this.actors_list.SelectedIndexChanged += new System.EventHandler(this.actors_list_SelectedIndexChanged);
            // 
            // genres_list
            // 
            this.genres_list.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.genres_list.Font = new System.Drawing.Font("Stencil", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genres_list.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(162)))), ((int)(((byte)(167)))));
            this.genres_list.FormattingEnabled = true;
            this.genres_list.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.genres_list.ItemHeight = 34;
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
            this.genres_list.Location = new System.Drawing.Point(57, 453);
            this.genres_list.Name = "genres_list";
            this.genres_list.Size = new System.Drawing.Size(1177, 548);
            this.genres_list.TabIndex = 22;
            this.genres_list.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.genres_list_DrawItem);
            this.genres_list.SelectedIndexChanged += new System.EventHandler(this.genres_list_SelectedIndexChanged);
            // 
            // closing_panel
            // 
            this.closing_panel.Location = new System.Drawing.Point(2, 389);
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
            this.add_genre.Location = new System.Drawing.Point(554, 994);
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
            this.add_actor.Location = new System.Drawing.Point(554, 988);
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
            // next_btn
            // 
            this.next_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(162)))), ((int)(((byte)(167)))));
            this.next_btn.Font = new System.Drawing.Font("XO Courser", 10F);
            this.next_btn.Location = new System.Drawing.Point(962, 1032);
            this.next_btn.Name = "next_btn";
            this.next_btn.Size = new System.Drawing.Size(339, 52);
            this.next_btn.TabIndex = 36;
            this.next_btn.Text = "Далее";
            this.next_btn.UseVisualStyleBackColor = false;
            this.next_btn.Visible = false;
            this.next_btn.Click += new System.EventHandler(this.next_btn_Click_1);
            // 
            // skip_btn
            // 
            this.skip_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.skip_btn.Font = new System.Drawing.Font("XO Courser", 8F);
            this.skip_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(242)))));
            this.skip_btn.Location = new System.Drawing.Point(44, 1032);
            this.skip_btn.Name = "skip_btn";
            this.skip_btn.Size = new System.Drawing.Size(176, 42);
            this.skip_btn.TabIndex = 128;
            this.skip_btn.Text = "Пропустить";
            this.skip_btn.UseVisualStyleBackColor = false;
            this.skip_btn.Visible = false;
            this.skip_btn.Click += new System.EventHandler(this.skip_btn_Click);
            // 
            // search_actor
            // 
            this.search_actor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.search_actor.Font = new System.Drawing.Font("XO Courser", 9F);
            this.search_actor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(242)))));
            this.search_actor.Location = new System.Drawing.Point(801, 412);
            this.search_actor.Name = "search_actor";
            this.search_actor.Size = new System.Drawing.Size(433, 35);
            this.search_actor.TabIndex = 129;
            this.search_actor.Text = "Поиск по списку..";
            this.search_actor.Visible = false;
            this.search_actor.Click += new System.EventHandler(this.search_actor_Click);
            this.search_actor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.search_actor_KeyDown);
            // 
            // Preferences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(90)))), ((int)(((byte)(86)))));
            this.ClientSize = new System.Drawing.Size(1313, 1096);
            this.Controls.Add(this.search_actor);
            this.Controls.Add(this.skip_btn);
            this.Controls.Add(this.add_genre);
            this.Controls.Add(this.add_actor);
            this.Controls.Add(this.info_lbl1);
            this.Controls.Add(this.closing_panel);
            this.Controls.Add(this.panel_lateral);
            this.Controls.Add(this.info_lbl4);
            this.Controls.Add(this.info_lbl3);
            this.Controls.Add(this.info_lbl2);
            this.Controls.Add(this.info_lbl5);
            this.Controls.Add(this.next_btn);
            this.Controls.Add(this.genres_list);
            this.Controls.Add(this.actors_list);
            this.Controls.Add(this.go_btn);
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
        private System.Windows.Forms.ListBox actors_list;
        private System.Windows.Forms.ListBox genres_list;
        private System.Windows.Forms.Panel closing_panel;
        private System.Windows.Forms.Button go_btn;
        private System.Windows.Forms.Label info_lbl5;
        private System.Windows.Forms.Button add_genre;
        private System.Windows.Forms.Button add_actor;
        private System.Windows.Forms.Label info_lbl1;
        private System.Windows.Forms.Button next_btn;
        private System.Windows.Forms.Button skip_btn;
        private System.Windows.Forms.TextBox search_actor;
    }
}