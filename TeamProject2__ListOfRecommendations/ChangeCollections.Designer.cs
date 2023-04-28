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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeCollections));
            this.panel4 = new System.Windows.Forms.Panel();
            this.select_collection_lbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.info_lbl1 = new System.Windows.Forms.Label();
            this.collections_list = new System.Windows.Forms.ListBox();
            this.delete_film_btn = new System.Windows.Forms.Button();
            this.delete_collection = new System.Windows.Forms.Button();
            this.all_films_collection_list = new System.Windows.Forms.ListBox();
            this.search_film_tb = new System.Windows.Forms.TextBox();
            this.ok_btn = new System.Windows.Forms.Button();
            this.info_lbl3 = new System.Windows.Forms.Label();
            this.info_lbl2 = new System.Windows.Forms.Label();
            this.add_film_btn = new System.Windows.Forms.Button();
            this.films_in_collection_list = new System.Windows.Forms.ListBox();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel4.Controls.Add(this.select_collection_lbl);
            this.panel4.Location = new System.Drawing.Point(33, 250);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(357, 68);
            this.panel4.TabIndex = 72;
            // 
            // select_collection_lbl
            // 
            this.select_collection_lbl.AutoSize = true;
            this.select_collection_lbl.Font = new System.Drawing.Font("XO Courser", 11F);
            this.select_collection_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(242)))));
            this.select_collection_lbl.Location = new System.Drawing.Point(9, 18);
            this.select_collection_lbl.Name = "select_collection_lbl";
            this.select_collection_lbl.Size = new System.Drawing.Size(321, 33);
            this.select_collection_lbl.TabIndex = 9;
            this.select_collection_lbl.Text = "Выберите подборку";
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
            this.info_lbl1.Font = new System.Drawing.Font("Stencil", 17F, System.Drawing.FontStyle.Bold);
            this.info_lbl1.ForeColor = System.Drawing.Color.Black;
            this.info_lbl1.Location = new System.Drawing.Point(284, 82);
            this.info_lbl1.Name = "info_lbl1";
            this.info_lbl1.Size = new System.Drawing.Size(851, 55);
            this.info_lbl1.TabIndex = 73;
            this.info_lbl1.Text = "И З М Е Н Е Н И Я    П О Д Б О Р О К";
            // 
            // collections_list
            // 
            this.collections_list.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.collections_list.Font = new System.Drawing.Font("XO Courser", 11F);
            this.collections_list.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(242)))));
            this.collections_list.FormattingEnabled = true;
            this.collections_list.ItemHeight = 32;
            this.collections_list.Location = new System.Drawing.Point(446, 259);
            this.collections_list.Name = "collections_list";
            this.collections_list.Size = new System.Drawing.Size(311, 196);
            this.collections_list.TabIndex = 84;
            this.collections_list.SelectedIndexChanged += new System.EventHandler(this.collections_list_SelectedIndexChanged);
            // 
            // delete_film_btn
            // 
            this.delete_film_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.delete_film_btn.Font = new System.Drawing.Font("XO Courser", 9F);
            this.delete_film_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(242)))));
            this.delete_film_btn.Location = new System.Drawing.Point(1138, 397);
            this.delete_film_btn.Name = "delete_film_btn";
            this.delete_film_btn.Size = new System.Drawing.Size(226, 101);
            this.delete_film_btn.TabIndex = 95;
            this.delete_film_btn.Text = "Удалить фильм из подборки";
            this.delete_film_btn.UseVisualStyleBackColor = false;
            this.delete_film_btn.Visible = false;
            this.delete_film_btn.Click += new System.EventHandler(this.delete_film_btn_Click);
            // 
            // delete_collection
            // 
            this.delete_collection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.delete_collection.Font = new System.Drawing.Font("XO Courser", 9F);
            this.delete_collection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(242)))));
            this.delete_collection.Location = new System.Drawing.Point(531, 452);
            this.delete_collection.Name = "delete_collection";
            this.delete_collection.Size = new System.Drawing.Size(226, 76);
            this.delete_collection.TabIndex = 96;
            this.delete_collection.Text = "Удалить подборку";
            this.delete_collection.UseVisualStyleBackColor = false;
            this.delete_collection.Visible = false;
            this.delete_collection.Click += new System.EventHandler(this.delete_collection_Click);
            // 
            // all_films_collection_list
            // 
            this.all_films_collection_list.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.all_films_collection_list.Font = new System.Drawing.Font("XO Courser", 11F);
            this.all_films_collection_list.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(242)))));
            this.all_films_collection_list.FormattingEnabled = true;
            this.all_films_collection_list.ItemHeight = 32;
            this.all_films_collection_list.Location = new System.Drawing.Point(813, 651);
            this.all_films_collection_list.Name = "all_films_collection_list";
            this.all_films_collection_list.Size = new System.Drawing.Size(312, 228);
            this.all_films_collection_list.TabIndex = 98;
            this.all_films_collection_list.Visible = false;
            this.all_films_collection_list.SelectedIndexChanged += new System.EventHandler(this.all_films_collection_list_SelectedIndexChanged);
            // 
            // search_film_tb
            // 
            this.search_film_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.search_film_tb.Font = new System.Drawing.Font("XO Courser", 9F);
            this.search_film_tb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(242)))));
            this.search_film_tb.Location = new System.Drawing.Point(813, 610);
            this.search_film_tb.Name = "search_film_tb";
            this.search_film_tb.Size = new System.Drawing.Size(312, 35);
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
            this.info_lbl3.Font = new System.Drawing.Font("XO Courser", 11F);
            this.info_lbl3.ForeColor = System.Drawing.Color.Black;
            this.info_lbl3.Location = new System.Drawing.Point(808, 566);
            this.info_lbl3.Name = "info_lbl3";
            this.info_lbl3.Size = new System.Drawing.Size(537, 33);
            this.info_lbl3.TabIndex = 9;
            this.info_lbl3.Text = "Добавление фильмов в подборку";
            this.info_lbl3.Visible = false;
            // 
            // info_lbl2
            // 
            this.info_lbl2.AutoSize = true;
            this.info_lbl2.Font = new System.Drawing.Font("XO Courser", 11F);
            this.info_lbl2.ForeColor = System.Drawing.Color.Black;
            this.info_lbl2.Location = new System.Drawing.Point(808, 240);
            this.info_lbl2.Name = "info_lbl2";
            this.info_lbl2.Size = new System.Drawing.Size(519, 33);
            this.info_lbl2.TabIndex = 100;
            this.info_lbl2.Text = "Управление фильмами подборки";
            this.info_lbl2.Visible = false;
            // 
            // add_film_btn
            // 
            this.add_film_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.add_film_btn.Font = new System.Drawing.Font("XO Courser", 9F);
            this.add_film_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(242)))));
            this.add_film_btn.Location = new System.Drawing.Point(1138, 785);
            this.add_film_btn.Name = "add_film_btn";
            this.add_film_btn.Size = new System.Drawing.Size(226, 94);
            this.add_film_btn.TabIndex = 101;
            this.add_film_btn.Text = "Добавить фильм в подборку";
            this.add_film_btn.UseVisualStyleBackColor = false;
            this.add_film_btn.Visible = false;
            this.add_film_btn.Click += new System.EventHandler(this.add_film_btn_Click);
            // 
            // films_in_collection_list
            // 
            this.films_in_collection_list.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.films_in_collection_list.Font = new System.Drawing.Font("XO Courser", 11F);
            this.films_in_collection_list.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(242)))));
            this.films_in_collection_list.FormattingEnabled = true;
            this.films_in_collection_list.ItemHeight = 32;
            this.films_in_collection_list.Location = new System.Drawing.Point(813, 276);
            this.films_in_collection_list.Name = "films_in_collection_list";
            this.films_in_collection_list.Size = new System.Drawing.Size(312, 228);
            this.films_in_collection_list.TabIndex = 103;
            this.films_in_collection_list.Visible = false;
            this.films_in_collection_list.SelectedIndexChanged += new System.EventHandler(this.films_in_collection_list_SelectedIndexChanged);
            // 
            // ChangeCollections
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(90)))), ((int)(((byte)(86)))));
            this.ClientSize = new System.Drawing.Size(1392, 1009);
            this.Controls.Add(this.films_in_collection_list);
            this.Controls.Add(this.add_film_btn);
            this.Controls.Add(this.info_lbl2);
            this.Controls.Add(this.info_lbl3);
            this.Controls.Add(this.ok_btn);
            this.Controls.Add(this.search_film_tb);
            this.Controls.Add(this.all_films_collection_list);
            this.Controls.Add(this.delete_collection);
            this.Controls.Add(this.delete_film_btn);
            this.Controls.Add(this.collections_list);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.info_lbl1);
            this.Controls.Add(this.panel4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.Label select_collection_lbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label info_lbl1;
        private System.Windows.Forms.ListBox collections_list;
        private System.Windows.Forms.Button delete_film_btn;
        private System.Windows.Forms.Button delete_collection;
        private System.Windows.Forms.ListBox all_films_collection_list;
        private System.Windows.Forms.TextBox search_film_tb;
        private System.Windows.Forms.Button ok_btn;
        private System.Windows.Forms.Label info_lbl3;
        private System.Windows.Forms.Label info_lbl2;
        private System.Windows.Forms.Button add_film_btn;
        private System.Windows.Forms.ListBox films_in_collection_list;
    }
}