namespace TeamProject2__ListOfRecommendations
{
    partial class APISearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(APISearch));
            this.info_lbl1 = new System.Windows.Forms.Label();
            this.panel_lateral = new System.Windows.Forms.Panel();
            this.info_lbl3 = new System.Windows.Forms.Label();
            this.info_lbl2 = new System.Windows.Forms.Label();
            this.ok_btn = new System.Windows.Forms.Button();
            this.info_lbl4 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.closing_panel = new System.Windows.Forms.Panel();
            this.show_plot_btn = new System.Windows.Forms.Button();
            this.info_country = new System.Windows.Forms.RichTextBox();
            this.substrate5 = new System.Windows.Forms.Panel();
            this.country_lbl = new System.Windows.Forms.Label();
            this.info_title = new System.Windows.Forms.Label();
            this.info_mark = new System.Windows.Forms.RichTextBox();
            this.info_year = new System.Windows.Forms.RichTextBox();
            this.info_actors = new System.Windows.Forms.RichTextBox();
            this.info_genre = new System.Windows.Forms.RichTextBox();
            this.substrate4 = new System.Windows.Forms.Panel();
            this.mark_lbl = new System.Windows.Forms.Label();
            this.substrate2 = new System.Windows.Forms.Panel();
            this.actors_lbl = new System.Windows.Forms.Label();
            this.substrate1 = new System.Windows.Forms.Panel();
            this.genre_lbl = new System.Windows.Forms.Label();
            this.substrate3 = new System.Windows.Forms.Panel();
            this.year_lbl = new System.Windows.Forms.Label();
            this.search_tb = new System.Windows.Forms.TextBox();
            this.image_poster = new System.Windows.Forms.PictureBox();
            this.search_btn1 = new System.Windows.Forms.Button();
            this.frame_searching = new System.Windows.Forms.PictureBox();
            this.closing_panel.SuspendLayout();
            this.substrate5.SuspendLayout();
            this.substrate4.SuspendLayout();
            this.substrate2.SuspendLayout();
            this.substrate1.SuspendLayout();
            this.substrate3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image_poster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frame_searching)).BeginInit();
            this.SuspendLayout();
            // 
            // info_lbl1
            // 
            this.info_lbl1.AutoSize = true;
            this.info_lbl1.Font = new System.Drawing.Font("Stencil", 22.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info_lbl1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(162)))), ((int)(((byte)(167)))));
            this.info_lbl1.Location = new System.Drawing.Point(49, 100);
            this.info_lbl1.Name = "info_lbl1";
            this.info_lbl1.Size = new System.Drawing.Size(408, 70);
            this.info_lbl1.TabIndex = 41;
            this.info_lbl1.Text = "Здравствуте!";
            // 
            // panel_lateral
            // 
            this.panel_lateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(162)))), ((int)(((byte)(167)))));
            this.panel_lateral.Location = new System.Drawing.Point(32, 76);
            this.panel_lateral.Name = "panel_lateral";
            this.panel_lateral.Size = new System.Drawing.Size(11, 261);
            this.panel_lateral.TabIndex = 39;
            // 
            // info_lbl3
            // 
            this.info_lbl3.AutoSize = true;
            this.info_lbl3.Font = new System.Drawing.Font("Stencil", 22.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info_lbl3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(242)))));
            this.info_lbl3.Location = new System.Drawing.Point(49, 255);
            this.info_lbl3.Name = "info_lbl3";
            this.info_lbl3.Size = new System.Drawing.Size(1428, 70);
            this.info_lbl3.TabIndex = 37;
            this.info_lbl3.Text = "с использованием данных веб-службы OMDb API\r\n";
            // 
            // info_lbl2
            // 
            this.info_lbl2.AutoSize = true;
            this.info_lbl2.Font = new System.Drawing.Font("Stencil", 22.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info_lbl2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(242)))));
            this.info_lbl2.Location = new System.Drawing.Point(34, 180);
            this.info_lbl2.Name = "info_lbl2";
            this.info_lbl2.Size = new System.Drawing.Size(1123, 70);
            this.info_lbl2.TabIndex = 36;
            this.info_lbl2.Text = " Вы попали в раздел поиска фильмов ";
            // 
            // ok_btn
            // 
            this.ok_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(210)))), ((int)(((byte)(219)))));
            this.ok_btn.Font = new System.Drawing.Font("XO Courser", 9F);
            this.ok_btn.Location = new System.Drawing.Point(1346, 861);
            this.ok_btn.Name = "ok_btn";
            this.ok_btn.Size = new System.Drawing.Size(131, 47);
            this.ok_btn.TabIndex = 42;
            this.ok_btn.Text = "Ок";
            this.ok_btn.UseVisualStyleBackColor = false;
            this.ok_btn.Visible = false;
            this.ok_btn.Click += new System.EventHandler(this.ok_btn_Click);
            // 
            // info_lbl4
            // 
            this.info_lbl4.AutoSize = true;
            this.info_lbl4.Font = new System.Drawing.Font("XO Thames", 13F);
            this.info_lbl4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(242)))));
            this.info_lbl4.Location = new System.Drawing.Point(74, 396);
            this.info_lbl4.Name = "info_lbl4";
            this.info_lbl4.Size = new System.Drawing.Size(1176, 320);
            this.info_lbl4.TabIndex = 43;
            this.info_lbl4.Text = resources.GetString("info_lbl4.Text");
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // closing_panel
            // 
            this.closing_panel.Controls.Add(this.show_plot_btn);
            this.closing_panel.Controls.Add(this.info_country);
            this.closing_panel.Controls.Add(this.substrate5);
            this.closing_panel.Controls.Add(this.info_title);
            this.closing_panel.Controls.Add(this.image_poster);
            this.closing_panel.Controls.Add(this.info_mark);
            this.closing_panel.Controls.Add(this.info_year);
            this.closing_panel.Controls.Add(this.info_actors);
            this.closing_panel.Controls.Add(this.info_genre);
            this.closing_panel.Controls.Add(this.substrate4);
            this.closing_panel.Controls.Add(this.substrate2);
            this.closing_panel.Controls.Add(this.substrate1);
            this.closing_panel.Controls.Add(this.substrate3);
            this.closing_panel.Controls.Add(this.search_tb);
            this.closing_panel.Controls.Add(this.search_btn1);
            this.closing_panel.Controls.Add(this.frame_searching);
            this.closing_panel.Location = new System.Drawing.Point(2, 2);
            this.closing_panel.Name = "closing_panel";
            this.closing_panel.Size = new System.Drawing.Size(1484, 930);
            this.closing_panel.TabIndex = 44;
            this.closing_panel.Visible = false;
            // 
            // show_plot_btn
            // 
            this.show_plot_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(162)))), ((int)(((byte)(167)))));
            this.show_plot_btn.Font = new System.Drawing.Font("XO Courser", 9F);
            this.show_plot_btn.Location = new System.Drawing.Point(960, 859);
            this.show_plot_btn.Name = "show_plot_btn";
            this.show_plot_btn.Size = new System.Drawing.Size(256, 48);
            this.show_plot_btn.TabIndex = 88;
            this.show_plot_btn.Text = "Краткий сюжет";
            this.show_plot_btn.UseVisualStyleBackColor = false;
            this.show_plot_btn.Click += new System.EventHandler(this.show_plot_btn_Click);
            // 
            // info_country
            // 
            this.info_country.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.info_country.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.info_country.Font = new System.Drawing.Font("XO Courser", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.info_country.ForeColor = System.Drawing.Color.DarkGray;
            this.info_country.Location = new System.Drawing.Point(997, 595);
            this.info_country.Name = "info_country";
            this.info_country.ReadOnly = true;
            this.info_country.Size = new System.Drawing.Size(337, 102);
            this.info_country.TabIndex = 87;
            this.info_country.Text = "";
            // 
            // substrate5
            // 
            this.substrate5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(162)))), ((int)(((byte)(167)))));
            this.substrate5.Controls.Add(this.country_lbl);
            this.substrate5.Location = new System.Drawing.Point(799, 601);
            this.substrate5.Name = "substrate5";
            this.substrate5.Size = new System.Drawing.Size(190, 96);
            this.substrate5.TabIndex = 86;
            // 
            // country_lbl
            // 
            this.country_lbl.AutoSize = true;
            this.country_lbl.Font = new System.Drawing.Font("XO Courser", 11F);
            this.country_lbl.Location = new System.Drawing.Point(9, 17);
            this.country_lbl.Name = "country_lbl";
            this.country_lbl.Size = new System.Drawing.Size(123, 33);
            this.country_lbl.TabIndex = 9;
            this.country_lbl.Text = "Страна";
            // 
            // info_title
            // 
            this.info_title.AutoSize = true;
            this.info_title.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(242)))));
            this.info_title.Location = new System.Drawing.Point(788, 122);
            this.info_title.Name = "info_title";
            this.info_title.Size = new System.Drawing.Size(183, 57);
            this.info_title.TabIndex = 45;
            this.info_title.Text = "фильм";
            this.info_title.Visible = false;
            // 
            // info_mark
            // 
            this.info_mark.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.info_mark.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.info_mark.Font = new System.Drawing.Font("XO Courser", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.info_mark.ForeColor = System.Drawing.Color.DarkGray;
            this.info_mark.Location = new System.Drawing.Point(997, 727);
            this.info_mark.Name = "info_mark";
            this.info_mark.ReadOnly = true;
            this.info_mark.Size = new System.Drawing.Size(337, 102);
            this.info_mark.TabIndex = 83;
            this.info_mark.Text = "";
            // 
            // info_year
            // 
            this.info_year.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.info_year.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.info_year.Font = new System.Drawing.Font("XO Courser", 11F);
            this.info_year.ForeColor = System.Drawing.Color.DarkGray;
            this.info_year.Location = new System.Drawing.Point(996, 468);
            this.info_year.Name = "info_year";
            this.info_year.ReadOnly = true;
            this.info_year.Size = new System.Drawing.Size(337, 96);
            this.info_year.TabIndex = 82;
            this.info_year.Text = "";
            // 
            // info_actors
            // 
            this.info_actors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.info_actors.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.info_actors.Font = new System.Drawing.Font("XO Courser", 11F);
            this.info_actors.ForeColor = System.Drawing.Color.DarkGray;
            this.info_actors.Location = new System.Drawing.Point(996, 327);
            this.info_actors.Name = "info_actors";
            this.info_actors.ReadOnly = true;
            this.info_actors.Size = new System.Drawing.Size(337, 102);
            this.info_actors.TabIndex = 81;
            this.info_actors.Text = "";
            // 
            // info_genre
            // 
            this.info_genre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.info_genre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.info_genre.Font = new System.Drawing.Font("XO Courser", 11F);
            this.info_genre.ForeColor = System.Drawing.Color.DarkGray;
            this.info_genre.Location = new System.Drawing.Point(996, 204);
            this.info_genre.Name = "info_genre";
            this.info_genre.ReadOnly = true;
            this.info_genre.Size = new System.Drawing.Size(337, 102);
            this.info_genre.TabIndex = 80;
            this.info_genre.Text = "";
            // 
            // substrate4
            // 
            this.substrate4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(162)))), ((int)(((byte)(167)))));
            this.substrate4.Controls.Add(this.mark_lbl);
            this.substrate4.Location = new System.Drawing.Point(799, 733);
            this.substrate4.Name = "substrate4";
            this.substrate4.Size = new System.Drawing.Size(190, 96);
            this.substrate4.TabIndex = 77;
            // 
            // mark_lbl
            // 
            this.mark_lbl.AutoSize = true;
            this.mark_lbl.Font = new System.Drawing.Font("XO Courser", 11F);
            this.mark_lbl.Location = new System.Drawing.Point(9, 17);
            this.mark_lbl.Name = "mark_lbl";
            this.mark_lbl.Size = new System.Drawing.Size(141, 33);
            this.mark_lbl.TabIndex = 9;
            this.mark_lbl.Text = "Рейтинг";
            // 
            // substrate2
            // 
            this.substrate2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(162)))), ((int)(((byte)(167)))));
            this.substrate2.Controls.Add(this.actors_lbl);
            this.substrate2.Location = new System.Drawing.Point(799, 327);
            this.substrate2.Name = "substrate2";
            this.substrate2.Size = new System.Drawing.Size(190, 102);
            this.substrate2.TabIndex = 79;
            // 
            // actors_lbl
            // 
            this.actors_lbl.AutoSize = true;
            this.actors_lbl.Font = new System.Drawing.Font("XO Courser", 11F);
            this.actors_lbl.Location = new System.Drawing.Point(9, 16);
            this.actors_lbl.Name = "actors_lbl";
            this.actors_lbl.Size = new System.Drawing.Size(123, 33);
            this.actors_lbl.TabIndex = 9;
            this.actors_lbl.Text = "Актеры";
            // 
            // substrate1
            // 
            this.substrate1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(162)))), ((int)(((byte)(167)))));
            this.substrate1.Controls.Add(this.genre_lbl);
            this.substrate1.Location = new System.Drawing.Point(799, 204);
            this.substrate1.Name = "substrate1";
            this.substrate1.Size = new System.Drawing.Size(190, 102);
            this.substrate1.TabIndex = 78;
            // 
            // genre_lbl
            // 
            this.genre_lbl.AutoSize = true;
            this.genre_lbl.Font = new System.Drawing.Font("XO Courser", 11F);
            this.genre_lbl.Location = new System.Drawing.Point(9, 19);
            this.genre_lbl.Name = "genre_lbl";
            this.genre_lbl.Size = new System.Drawing.Size(87, 33);
            this.genre_lbl.TabIndex = 9;
            this.genre_lbl.Text = "Жанр";
            // 
            // substrate3
            // 
            this.substrate3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(162)))), ((int)(((byte)(167)))));
            this.substrate3.Controls.Add(this.year_lbl);
            this.substrate3.Location = new System.Drawing.Point(798, 468);
            this.substrate3.Name = "substrate3";
            this.substrate3.Size = new System.Drawing.Size(190, 102);
            this.substrate3.TabIndex = 76;
            // 
            // year_lbl
            // 
            this.year_lbl.AutoSize = true;
            this.year_lbl.Font = new System.Drawing.Font("XO Courser", 10F);
            this.year_lbl.Location = new System.Drawing.Point(12, 19);
            this.year_lbl.Name = "year_lbl";
            this.year_lbl.Size = new System.Drawing.Size(61, 30);
            this.year_lbl.TabIndex = 9;
            this.year_lbl.Text = "Год";
            // 
            // search_tb
            // 
            this.search_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(90)))), ((int)(((byte)(86)))));
            this.search_tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.search_tb.Font = new System.Drawing.Font("XO Courser", 10F);
            this.search_tb.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.search_tb.Location = new System.Drawing.Point(528, 39);
            this.search_tb.Name = "search_tb";
            this.search_tb.Size = new System.Drawing.Size(378, 38);
            this.search_tb.TabIndex = 31;
            this.search_tb.TabStop = false;
            this.search_tb.Text = "Поиск фильмов";
            this.search_tb.Click += new System.EventHandler(this.search_tb_Click);
            this.search_tb.MouseEnter += new System.EventHandler(this.search_tb_MouseEnter);
            this.search_tb.MouseLeave += new System.EventHandler(this.search_tb_MouseLeave);
            // 
            // image_poster
            // 
            this.image_poster.Location = new System.Drawing.Point(69, 126);
            this.image_poster.Name = "image_poster";
            this.image_poster.Size = new System.Drawing.Size(656, 767);
            this.image_poster.TabIndex = 85;
            this.image_poster.TabStop = false;
            // 
            // search_btn1
            // 
            this.search_btn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(90)))), ((int)(((byte)(86)))));
            this.search_btn1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("search_btn1.BackgroundImage")));
            this.search_btn1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.search_btn1.Location = new System.Drawing.Point(906, 35);
            this.search_btn1.Name = "search_btn1";
            this.search_btn1.Size = new System.Drawing.Size(52, 48);
            this.search_btn1.TabIndex = 32;
            this.search_btn1.UseVisualStyleBackColor = false;
            this.search_btn1.Click += new System.EventHandler(this.search_btn1_Click);
            // 
            // frame_searching
            // 
            this.frame_searching.Image = ((System.Drawing.Image)(resources.GetObject("frame_searching.Image")));
            this.frame_searching.Location = new System.Drawing.Point(522, 35);
            this.frame_searching.Name = "frame_searching";
            this.frame_searching.Size = new System.Drawing.Size(395, 50);
            this.frame_searching.TabIndex = 33;
            this.frame_searching.TabStop = false;
            this.frame_searching.Visible = false;
            // 
            // APISearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(90)))), ((int)(((byte)(86)))));
            this.ClientSize = new System.Drawing.Size(1498, 931);
            this.Controls.Add(this.closing_panel);
            this.Controls.Add(this.info_lbl4);
            this.Controls.Add(this.ok_btn);
            this.Controls.Add(this.info_lbl1);
            this.Controls.Add(this.panel_lateral);
            this.Controls.Add(this.info_lbl3);
            this.Controls.Add(this.info_lbl2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "APISearch";
            this.Text = "Поиск фильмов";
            this.Load += new System.EventHandler(this.APISearch_Load);
            this.closing_panel.ResumeLayout(false);
            this.closing_panel.PerformLayout();
            this.substrate5.ResumeLayout(false);
            this.substrate5.PerformLayout();
            this.substrate4.ResumeLayout(false);
            this.substrate4.PerformLayout();
            this.substrate2.ResumeLayout(false);
            this.substrate2.PerformLayout();
            this.substrate1.ResumeLayout(false);
            this.substrate1.PerformLayout();
            this.substrate3.ResumeLayout(false);
            this.substrate3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image_poster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frame_searching)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label info_lbl1;
        private System.Windows.Forms.Panel panel_lateral;
        private System.Windows.Forms.Label info_lbl3;
        private System.Windows.Forms.Label info_lbl2;
        private System.Windows.Forms.Button ok_btn;
        private System.Windows.Forms.Label info_lbl4;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Panel closing_panel;
        private System.Windows.Forms.TextBox search_tb;
        private System.Windows.Forms.Button search_btn1;
        private System.Windows.Forms.PictureBox frame_searching;
        private System.Windows.Forms.RichTextBox info_mark;
        private System.Windows.Forms.RichTextBox info_year;
        private System.Windows.Forms.RichTextBox info_actors;
        private System.Windows.Forms.RichTextBox info_genre;
        private System.Windows.Forms.Panel substrate4;
        private System.Windows.Forms.Label mark_lbl;
        private System.Windows.Forms.Panel substrate2;
        private System.Windows.Forms.Label actors_lbl;
        private System.Windows.Forms.Panel substrate1;
        private System.Windows.Forms.Label genre_lbl;
        private System.Windows.Forms.Panel substrate3;
        private System.Windows.Forms.Label year_lbl;
        private System.Windows.Forms.PictureBox image_poster;
        private System.Windows.Forms.Label info_title;
        private System.Windows.Forms.RichTextBox info_country;
        private System.Windows.Forms.Panel substrate5;
        private System.Windows.Forms.Label country_lbl;
        private System.Windows.Forms.Button show_plot_btn;
    }
}