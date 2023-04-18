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
            this.info_lbl1 = new System.Windows.Forms.Label();
            this.info_lbl2 = new System.Windows.Forms.Label();
            this.info_lbl3 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.info_lbl4 = new System.Windows.Forms.Label();
            this.year_lbl = new System.Windows.Forms.Label();
            this.panel_lateral = new System.Windows.Forms.Panel();
            this.frame1 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.date1 = new System.Windows.Forms.DateTimePicker();
            this.from_lbl = new System.Windows.Forms.Label();
            this.to_lbl = new System.Windows.Forms.Label();
            this.date2 = new System.Windows.Forms.DateTimePicker();
            this.searchCountry_tb = new System.Windows.Forms.TextBox();
            this.searchGenre_tb = new System.Windows.Forms.TextBox();
            this.searchDirector_tb = new System.Windows.Forms.TextBox();
            this.searchActor_tb = new System.Windows.Forms.TextBox();
            this.countries_list = new System.Windows.Forms.ListBox();
            this.actors_list = new System.Windows.Forms.ListBox();
            this.genres_list = new System.Windows.Forms.ListBox();
            this.directrors_list = new System.Windows.Forms.ListBox();
            this.closing_panel = new System.Windows.Forms.Panel();
            this.go_btn = new System.Windows.Forms.Button();
            this.search_btn4 = new System.Windows.Forms.Button();
            this.search_btn3 = new System.Windows.Forms.Button();
            this.search_btn2 = new System.Windows.Forms.Button();
            this.search_btn1 = new System.Windows.Forms.Button();
            this.frame1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // info_lbl1
            // 
            this.info_lbl1.AutoSize = true;
            this.info_lbl1.Font = new System.Drawing.Font("Stencil", 22.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info_lbl1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(242)))));
            this.info_lbl1.Location = new System.Drawing.Point(75, 97);
            this.info_lbl1.Name = "info_lbl1";
            this.info_lbl1.Size = new System.Drawing.Size(700, 210);
            this.info_lbl1.TabIndex = 0;
            this.info_lbl1.Text = "Чтобы создать для вас \r\n\r\n\r\n";
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
            this.info_lbl4.Size = new System.Drawing.Size(1451, 44);
            this.info_lbl4.TabIndex = 8;
            this.info_lbl4.Text = "Выберите характеристики для фильма, который вероятнее всего вам понравится";
            // 
            // year_lbl
            // 
            this.year_lbl.AutoSize = true;
            this.year_lbl.Font = new System.Drawing.Font("XO Courser", 11F);
            this.year_lbl.Location = new System.Drawing.Point(15, 17);
            this.year_lbl.Name = "year_lbl";
            this.year_lbl.Size = new System.Drawing.Size(195, 66);
            this.year_lbl.TabIndex = 9;
            this.year_lbl.Text = "временной\r\nпромежуток";
            // 
            // panel_lateral
            // 
            this.panel_lateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(162)))), ((int)(((byte)(167)))));
            this.panel_lateral.Location = new System.Drawing.Point(57, 73);
            this.panel_lateral.Name = "panel_lateral";
            this.panel_lateral.Size = new System.Drawing.Size(12, 249);
            this.panel_lateral.TabIndex = 10;
            // 
            // frame1
            // 
            this.frame1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.frame1.Controls.Add(this.year_lbl);
            this.frame1.Location = new System.Drawing.Point(87, 507);
            this.frame1.Name = "frame1";
            this.frame1.Size = new System.Drawing.Size(311, 102);
            this.frame1.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(87, 659);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(311, 96);
            this.panel1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("XO Courser", 11F);
            this.label1.Location = new System.Drawing.Point(15, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 33);
            this.label1.TabIndex = 9;
            this.label1.Text = "страны";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(87, 861);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(311, 102);
            this.panel2.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("XO Courser", 11F);
            this.label2.Location = new System.Drawing.Point(15, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 33);
            this.label2.TabIndex = 9;
            this.label2.Text = "жанры";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(858, 507);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(311, 102);
            this.panel3.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("XO Courser", 11F);
            this.label3.Location = new System.Drawing.Point(15, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(267, 33);
            this.label3.TabIndex = 9;
            this.label3.Text = "любимые актеры";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(858, 697);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(311, 102);
            this.panel4.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("XO Courser", 11F);
            this.label4.Location = new System.Drawing.Point(15, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 33);
            this.label4.TabIndex = 9;
            this.label4.Text = "режиссеры";
            // 
            // date1
            // 
            this.date1.CalendarMonthBackground = System.Drawing.Color.Silver;
            this.date1.Font = new System.Drawing.Font("XO Courser", 9F);
            this.date1.Location = new System.Drawing.Point(485, 508);
            this.date1.Name = "date1";
            this.date1.Size = new System.Drawing.Size(260, 35);
            this.date1.TabIndex = 16;
            this.date1.TabStop = false;
            // 
            // from_lbl
            // 
            this.from_lbl.AutoSize = true;
            this.from_lbl.Font = new System.Drawing.Font("XO Courser", 9F);
            this.from_lbl.Location = new System.Drawing.Point(425, 513);
            this.from_lbl.Name = "from_lbl";
            this.from_lbl.Size = new System.Drawing.Size(54, 27);
            this.from_lbl.TabIndex = 10;
            this.from_lbl.Text = "от-";
            // 
            // to_lbl
            // 
            this.to_lbl.AutoSize = true;
            this.to_lbl.Font = new System.Drawing.Font("XO Courser", 9F);
            this.to_lbl.Location = new System.Drawing.Point(425, 570);
            this.to_lbl.Name = "to_lbl";
            this.to_lbl.Size = new System.Drawing.Size(54, 27);
            this.to_lbl.TabIndex = 18;
            this.to_lbl.Text = "до-";
            // 
            // date2
            // 
            this.date2.CalendarMonthBackground = System.Drawing.Color.Gray;
            this.date2.Font = new System.Drawing.Font("XO Courser", 9F);
            this.date2.Location = new System.Drawing.Point(485, 570);
            this.date2.Name = "date2";
            this.date2.Size = new System.Drawing.Size(260, 35);
            this.date2.TabIndex = 20;
            // 
            // searchCountry_tb
            // 
            this.searchCountry_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(242)))));
            this.searchCountry_tb.Font = new System.Drawing.Font("XO Courser", 9F);
            this.searchCountry_tb.Location = new System.Drawing.Point(458, 652);
            this.searchCountry_tb.Name = "searchCountry_tb";
            this.searchCountry_tb.Size = new System.Drawing.Size(255, 35);
            this.searchCountry_tb.TabIndex = 21;
            this.searchCountry_tb.Text = "Поиск по списку..";
            this.searchCountry_tb.Click += new System.EventHandler(this.searchCountry_tb_Click);
            // 
            // searchGenre_tb
            // 
            this.searchGenre_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(242)))));
            this.searchGenre_tb.Font = new System.Drawing.Font("XO Courser", 9F);
            this.searchGenre_tb.Location = new System.Drawing.Point(458, 820);
            this.searchGenre_tb.Name = "searchGenre_tb";
            this.searchGenre_tb.Size = new System.Drawing.Size(255, 35);
            this.searchGenre_tb.TabIndex = 23;
            this.searchGenre_tb.Text = "Поиск по списку..";
            this.searchGenre_tb.Click += new System.EventHandler(this.searchGenre_tb_Click);
            this.searchGenre_tb.TextChanged += new System.EventHandler(this.searchGenre_tb_TextChanged);
            // 
            // searchDirector_tb
            // 
            this.searchDirector_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(242)))));
            this.searchDirector_tb.Font = new System.Drawing.Font("XO Courser", 9F);
            this.searchDirector_tb.Location = new System.Drawing.Point(1207, 693);
            this.searchDirector_tb.Name = "searchDirector_tb";
            this.searchDirector_tb.Size = new System.Drawing.Size(249, 35);
            this.searchDirector_tb.TabIndex = 29;
            this.searchDirector_tb.Text = "Поиск по списку..";
            this.searchDirector_tb.Click += new System.EventHandler(this.searchDirector_tb_Click);
            // 
            // searchActor_tb
            // 
            this.searchActor_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(242)))));
            this.searchActor_tb.Font = new System.Drawing.Font("XO Courser", 9F);
            this.searchActor_tb.Location = new System.Drawing.Point(1207, 504);
            this.searchActor_tb.Name = "searchActor_tb";
            this.searchActor_tb.Size = new System.Drawing.Size(249, 35);
            this.searchActor_tb.TabIndex = 27;
            this.searchActor_tb.Text = "Поиск по списку..";
            this.searchActor_tb.Click += new System.EventHandler(this.searchActor_tb_Click);
            // 
            // countries_list
            // 
            this.countries_list.BackColor = System.Drawing.Color.Silver;
            this.countries_list.Font = new System.Drawing.Font("XO Courser", 9F);
            this.countries_list.FormattingEnabled = true;
            this.countries_list.ItemHeight = 27;
            this.countries_list.Items.AddRange(new object[] {
            "страны"});
            this.countries_list.Location = new System.Drawing.Point(458, 693);
            this.countries_list.Name = "countries_list";
            this.countries_list.Size = new System.Drawing.Size(287, 85);
            this.countries_list.TabIndex = 19;
            this.countries_list.SelectedIndexChanged += new System.EventHandler(this.countries_list_SelectedIndexChanged);
            // 
            // actors_list
            // 
            this.actors_list.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(242)))));
            this.actors_list.Font = new System.Drawing.Font("XO Courser", 9F);
            this.actors_list.FormattingEnabled = true;
            this.actors_list.ItemHeight = 27;
            this.actors_list.Items.AddRange(new object[] {
            "актеры"});
            this.actors_list.Location = new System.Drawing.Point(1207, 545);
            this.actors_list.Name = "actors_list";
            this.actors_list.Size = new System.Drawing.Size(279, 85);
            this.actors_list.TabIndex = 26;
            // 
            // genres_list
            // 
            this.genres_list.BackColor = System.Drawing.Color.DarkGray;
            this.genres_list.Font = new System.Drawing.Font("XO Courser", 9F);
            this.genres_list.FormattingEnabled = true;
            this.genres_list.ItemHeight = 27;
            this.genres_list.Items.AddRange(new object[] {
            "жанры"});
            this.genres_list.Location = new System.Drawing.Point(458, 861);
            this.genres_list.Name = "genres_list";
            this.genres_list.Size = new System.Drawing.Size(287, 85);
            this.genres_list.TabIndex = 22;
            // 
            // directrors_list
            // 
            this.directrors_list.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(242)))));
            this.directrors_list.Font = new System.Drawing.Font("XO Courser", 9F);
            this.directrors_list.FormattingEnabled = true;
            this.directrors_list.ItemHeight = 27;
            this.directrors_list.Items.AddRange(new object[] {
            "режиссеры"});
            this.directrors_list.Location = new System.Drawing.Point(1207, 734);
            this.directrors_list.Name = "directrors_list";
            this.directrors_list.Size = new System.Drawing.Size(279, 85);
            this.directrors_list.TabIndex = 28;
            // 
            // closing_panel
            // 
            this.closing_panel.Location = new System.Drawing.Point(1, 460);
            this.closing_panel.Name = "closing_panel";
            this.closing_panel.Size = new System.Drawing.Size(1594, 639);
            this.closing_panel.TabIndex = 33;
            // 
            // go_btn
            // 
            this.go_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(162)))), ((int)(((byte)(167)))));
            this.go_btn.Font = new System.Drawing.Font("XO Courser", 10F);
            this.go_btn.Location = new System.Drawing.Point(1224, 1013);
            this.go_btn.Name = "go_btn";
            this.go_btn.Size = new System.Drawing.Size(339, 59);
            this.go_btn.TabIndex = 7;
            this.go_btn.Text = "Зарегестрироваться";
            this.go_btn.UseVisualStyleBackColor = false;
            this.go_btn.Click += new System.EventHandler(this.go_btn_Click);
            // 
            // search_btn4
            // 
            this.search_btn4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("search_btn4.BackgroundImage")));
            this.search_btn4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.search_btn4.Location = new System.Drawing.Point(1454, 692);
            this.search_btn4.Name = "search_btn4";
            this.search_btn4.Size = new System.Drawing.Size(42, 37);
            this.search_btn4.TabIndex = 31;
            this.search_btn4.UseVisualStyleBackColor = true;
            // 
            // search_btn3
            // 
            this.search_btn3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("search_btn3.BackgroundImage")));
            this.search_btn3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.search_btn3.Location = new System.Drawing.Point(1454, 502);
            this.search_btn3.Name = "search_btn3";
            this.search_btn3.Size = new System.Drawing.Size(42, 37);
            this.search_btn3.TabIndex = 30;
            this.search_btn3.UseVisualStyleBackColor = true;
            // 
            // search_btn2
            // 
            this.search_btn2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("search_btn2.BackgroundImage")));
            this.search_btn2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.search_btn2.Location = new System.Drawing.Point(709, 818);
            this.search_btn2.Name = "search_btn2";
            this.search_btn2.Size = new System.Drawing.Size(42, 37);
            this.search_btn2.TabIndex = 25;
            this.search_btn2.UseVisualStyleBackColor = true;
            // 
            // search_btn1
            // 
            this.search_btn1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("search_btn1.BackgroundImage")));
            this.search_btn1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.search_btn1.Location = new System.Drawing.Point(709, 650);
            this.search_btn1.Name = "search_btn1";
            this.search_btn1.Size = new System.Drawing.Size(42, 37);
            this.search_btn1.TabIndex = 24;
            this.search_btn1.UseVisualStyleBackColor = true;
            // 
            // Preferences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(90)))), ((int)(((byte)(86)))));
            this.ClientSize = new System.Drawing.Size(1590, 1096);
            this.Controls.Add(this.closing_panel);
            this.Controls.Add(this.directrors_list);
            this.Controls.Add(this.search_btn4);
            this.Controls.Add(this.searchDirector_tb);
            this.Controls.Add(this.searchActor_tb);
            this.Controls.Add(this.search_btn3);
            this.Controls.Add(this.searchGenre_tb);
            this.Controls.Add(this.actors_list);
            this.Controls.Add(this.search_btn2);
            this.Controls.Add(this.genres_list);
            this.Controls.Add(this.searchCountry_tb);
            this.Controls.Add(this.date2);
            this.Controls.Add(this.to_lbl);
            this.Controls.Add(this.from_lbl);
            this.Controls.Add(this.countries_list);
            this.Controls.Add(this.search_btn1);
            this.Controls.Add(this.date1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.frame1);
            this.Controls.Add(this.panel_lateral);
            this.Controls.Add(this.info_lbl4);
            this.Controls.Add(this.info_lbl3);
            this.Controls.Add(this.info_lbl2);
            this.Controls.Add(this.info_lbl1);
            this.Controls.Add(this.go_btn);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(242)))));
            this.Name = "Preferences";
            this.Text = "Ваши предпочтения";
            this.Load += new System.EventHandler(this.Preferences_Load);
            this.frame1.ResumeLayout(false);
            this.frame1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label info_lbl1;
        private System.Windows.Forms.Label info_lbl2;
        private System.Windows.Forms.Label info_lbl3;
        private System.Windows.Forms.Label info_lbl4;
        private System.Windows.Forms.Label year_lbl;
        public System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Panel panel_lateral;
        private System.Windows.Forms.Panel frame1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker date1;
        private System.Windows.Forms.Label from_lbl;
        private System.Windows.Forms.Label to_lbl;
        private System.Windows.Forms.DateTimePicker date2;
        private System.Windows.Forms.TextBox searchCountry_tb;
        private System.Windows.Forms.TextBox searchGenre_tb;
        private System.Windows.Forms.TextBox searchDirector_tb;
        private System.Windows.Forms.TextBox searchActor_tb;
        private System.Windows.Forms.ListBox countries_list;
        private System.Windows.Forms.ListBox actors_list;
        private System.Windows.Forms.ListBox genres_list;
        private System.Windows.Forms.Button search_btn2;
        private System.Windows.Forms.Button search_btn3;
        private System.Windows.Forms.Button search_btn1;
        private System.Windows.Forms.ListBox directrors_list;
        private System.Windows.Forms.Button search_btn4;
        private System.Windows.Forms.Panel closing_panel;
        private System.Windows.Forms.Button go_btn;
    }
}