namespace TeamProject2__ListOfRecommendations
{
    partial class ChangeCollections
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.info_lbl1 = new System.Windows.Forms.Label();
            this.collections_list = new System.Windows.Forms.ListBox();
            this.films_in_collection_list = new System.Windows.Forms.ListBox();
            this.delete_film_btn = new System.Windows.Forms.Button();
            this.delete_collection = new System.Windows.Forms.Button();
            this.all_films_collection_list = new System.Windows.Forms.ListBox();
            this.search_film_tb = new System.Windows.Forms.TextBox();
            this.ok_btn = new System.Windows.Forms.Button();
            this.info_lbl3 = new System.Windows.Forms.Label();
            this.info_lbl2 = new System.Windows.Forms.Label();
            this.add_film_btn = new System.Windows.Forms.Button();
            this.search_collection_tb = new System.Windows.Forms.TextBox();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(33, 250);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(357, 68);
            this.panel4.TabIndex = 72;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("XO Courser", 11F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(242)))));
            this.label4.Location = new System.Drawing.Point(9, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(321, 33);
            this.label4.TabIndex = 9;
            this.label4.Text = "Выберите подборку";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(162)))), ((int)(((byte)(167)))));
            this.panel1.Location = new System.Drawing.Point(-95, 155);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1497, 14);
            this.panel1.TabIndex = 74;
            // 
            // info_lbl1
            // 
            this.info_lbl1.AutoSize = true;
            this.info_lbl1.Font = new System.Drawing.Font("Stencil", 19F, System.Drawing.FontStyle.Bold);
            this.info_lbl1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(242)))));
            this.info_lbl1.Location = new System.Drawing.Point(436, 75);
            this.info_lbl1.Name = "info_lbl1";
            this.info_lbl1.Size = new System.Drawing.Size(549, 60);
            this.info_lbl1.TabIndex = 73;
            this.info_lbl1.Text = "Изменение подборок";
            // 
            // collections_list
            // 
            this.collections_list.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.collections_list.Font = new System.Drawing.Font("XO Courser", 9F);
            this.collections_list.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(242)))));
            this.collections_list.FormattingEnabled = true;
            this.collections_list.ItemHeight = 27;
            this.collections_list.Items.AddRange(new object[] {
            "Фильмы дня",
            "Избранное"});
            this.collections_list.Location = new System.Drawing.Point(446, 291);
            this.collections_list.Name = "collections_list";
            this.collections_list.Size = new System.Drawing.Size(311, 112);
            this.collections_list.TabIndex = 84;
            this.collections_list.SelectedIndexChanged += new System.EventHandler(this.collections_list_SelectedIndexChanged);
            // 
            // films_in_collection_list
            // 
            this.films_in_collection_list.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.films_in_collection_list.Font = new System.Drawing.Font("XO Courser", 9F);
            this.films_in_collection_list.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(242)))));
            this.films_in_collection_list.FormattingEnabled = true;
            this.films_in_collection_list.ItemHeight = 27;
            this.films_in_collection_list.Items.AddRange(new object[] {
            "Фильм1",
            "Фильм2",
            "Фильм3"});
            this.films_in_collection_list.Location = new System.Drawing.Point(794, 291);
            this.films_in_collection_list.Name = "films_in_collection_list";
            this.films_in_collection_list.Size = new System.Drawing.Size(289, 220);
            this.films_in_collection_list.TabIndex = 89;
            this.films_in_collection_list.Visible = false;
            this.films_in_collection_list.SelectedIndexChanged += new System.EventHandler(this.films_in_collection_list_SelectedIndexChanged);
            // 
            // delete_film_btn
            // 
            this.delete_film_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.delete_film_btn.Font = new System.Drawing.Font("XO Courser", 8F);
            this.delete_film_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(242)))));
            this.delete_film_btn.Location = new System.Drawing.Point(1102, 443);
            this.delete_film_btn.Name = "delete_film_btn";
            this.delete_film_btn.Size = new System.Drawing.Size(226, 68);
            this.delete_film_btn.TabIndex = 95;
            this.delete_film_btn.Text = "Удалить фильм из подборки";
            this.delete_film_btn.UseVisualStyleBackColor = false;
            this.delete_film_btn.Visible = false;
            // 
            // delete_collection
            // 
            this.delete_collection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.delete_collection.Font = new System.Drawing.Font("XO Courser", 8F);
            this.delete_collection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(242)))));
            this.delete_collection.Location = new System.Drawing.Point(531, 382);
            this.delete_collection.Name = "delete_collection";
            this.delete_collection.Size = new System.Drawing.Size(226, 42);
            this.delete_collection.TabIndex = 96;
            this.delete_collection.Text = "Удалить подборку";
            this.delete_collection.UseVisualStyleBackColor = false;
            this.delete_collection.Visible = false;
            // 
            // all_films_collection_list
            // 
            this.all_films_collection_list.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.all_films_collection_list.Font = new System.Drawing.Font("XO Courser", 9F);
            this.all_films_collection_list.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(242)))));
            this.all_films_collection_list.FormattingEnabled = true;
            this.all_films_collection_list.ItemHeight = 27;
            this.all_films_collection_list.Items.AddRange(new object[] {
            "Фильм1",
            "Фильм2",
            "Фильм3"});
            this.all_films_collection_list.Location = new System.Drawing.Point(794, 661);
            this.all_films_collection_list.Name = "all_films_collection_list";
            this.all_films_collection_list.Size = new System.Drawing.Size(289, 220);
            this.all_films_collection_list.TabIndex = 98;
            this.all_films_collection_list.Visible = false;
            this.all_films_collection_list.SelectedIndexChanged += new System.EventHandler(this.all_films_collection_list_SelectedIndexChanged);
            // 
            // search_film_tb
            // 
            this.search_film_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.search_film_tb.Font = new System.Drawing.Font("XO Courser", 9F);
            this.search_film_tb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(242)))));
            this.search_film_tb.Location = new System.Drawing.Point(794, 620);
            this.search_film_tb.Name = "search_film_tb";
            this.search_film_tb.Size = new System.Drawing.Size(289, 35);
            this.search_film_tb.TabIndex = 99;
            this.search_film_tb.Text = "Поиск по списку..";
            this.search_film_tb.Visible = false;
            this.search_film_tb.Click += new System.EventHandler(this.search_film_tb_Click);
            this.search_film_tb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.search_film_tb_KeyDown);
            // 
            // ok_btn
            // 
            this.ok_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(210)))), ((int)(((byte)(219)))));
            this.ok_btn.Font = new System.Drawing.Font("XO Courser", 9F);
            this.ok_btn.Location = new System.Drawing.Point(1185, 943);
            this.ok_btn.Name = "ok_btn";
            this.ok_btn.Size = new System.Drawing.Size(195, 54);
            this.ok_btn.TabIndex = 96;
            this.ok_btn.Text = "Завершить";
            this.ok_btn.UseVisualStyleBackColor = false;
            this.ok_btn.Click += new System.EventHandler(this.ok_btn_Click);
            // 
            // info_lbl3
            // 
            this.info_lbl3.AutoSize = true;
            this.info_lbl3.Font = new System.Drawing.Font("XO Courser", 10F);
            this.info_lbl3.ForeColor = System.Drawing.Color.Black;
            this.info_lbl3.Location = new System.Drawing.Point(789, 576);
            this.info_lbl3.Name = "info_lbl3";
            this.info_lbl3.Size = new System.Drawing.Size(477, 30);
            this.info_lbl3.TabIndex = 9;
            this.info_lbl3.Text = "Добавление фильмов в подборку";
            this.info_lbl3.Visible = false;
            // 
            // info_lbl2
            // 
            this.info_lbl2.AutoSize = true;
            this.info_lbl2.Font = new System.Drawing.Font("XO Courser", 10F);
            this.info_lbl2.ForeColor = System.Drawing.Color.Black;
            this.info_lbl2.Location = new System.Drawing.Point(789, 250);
            this.info_lbl2.Name = "info_lbl2";
            this.info_lbl2.Size = new System.Drawing.Size(461, 30);
            this.info_lbl2.TabIndex = 100;
            this.info_lbl2.Text = "Управление фильмами подборки";
            this.info_lbl2.Visible = false;
            // 
            // add_film_btn
            // 
            this.add_film_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.add_film_btn.Font = new System.Drawing.Font("XO Courser", 8F);
            this.add_film_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(242)))));
            this.add_film_btn.Location = new System.Drawing.Point(1102, 813);
            this.add_film_btn.Name = "add_film_btn";
            this.add_film_btn.Size = new System.Drawing.Size(226, 68);
            this.add_film_btn.TabIndex = 101;
            this.add_film_btn.Text = "Добавить фильм в подборку";
            this.add_film_btn.UseVisualStyleBackColor = false;
            this.add_film_btn.Visible = false;
            // 
            // search_collection_tb
            // 
            this.search_collection_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.search_collection_tb.Font = new System.Drawing.Font("XO Courser", 9F);
            this.search_collection_tb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(242)))));
            this.search_collection_tb.Location = new System.Drawing.Point(445, 252);
            this.search_collection_tb.Name = "search_collection_tb";
            this.search_collection_tb.Size = new System.Drawing.Size(311, 35);
            this.search_collection_tb.TabIndex = 102;
            this.search_collection_tb.Text = "Поиск по списку..";
            this.search_collection_tb.Click += new System.EventHandler(this.search_collection_tb_Click);
            this.search_collection_tb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.search_collection_tb_KeyDown);
            // 
            // ChangeCollections
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(90)))), ((int)(((byte)(86)))));
            this.ClientSize = new System.Drawing.Size(1392, 1009);
            this.Controls.Add(this.search_collection_tb);
            this.Controls.Add(this.add_film_btn);
            this.Controls.Add(this.info_lbl2);
            this.Controls.Add(this.info_lbl3);
            this.Controls.Add(this.ok_btn);
            this.Controls.Add(this.search_film_tb);
            this.Controls.Add(this.all_films_collection_list);
            this.Controls.Add(this.delete_collection);
            this.Controls.Add(this.delete_film_btn);
            this.Controls.Add(this.films_in_collection_list);
            this.Controls.Add(this.collections_list);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.info_lbl1);
            this.Controls.Add(this.panel4);
            this.Name = "ChangeCollections";
            this.Text = "Изменение подборок";
            this.Load += new System.EventHandler(this.ChangeCollections_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label info_lbl1;
        private System.Windows.Forms.ListBox collections_list;
        private System.Windows.Forms.ListBox films_in_collection_list;
        private System.Windows.Forms.Button delete_film_btn;
        private System.Windows.Forms.Button delete_collection;
        private System.Windows.Forms.ListBox all_films_collection_list;
        private System.Windows.Forms.TextBox search_film_tb;
        private System.Windows.Forms.Button ok_btn;
        private System.Windows.Forms.Label info_lbl3;
        private System.Windows.Forms.Label info_lbl2;
        private System.Windows.Forms.Button add_film_btn;
        private System.Windows.Forms.TextBox search_collection_tb;
    }
}