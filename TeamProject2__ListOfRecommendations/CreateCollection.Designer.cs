namespace TeamProject2__ListOfRecommendations
{
    partial class CreateCollection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateCollection));
            this.name_tb = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.title_lbl = new System.Windows.Forms.Label();
            this.upper_panel = new System.Windows.Forms.Panel();
            this.info_lbl1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.films_lbl = new System.Windows.Forms.Label();
            this.search_film_tb = new System.Windows.Forms.TextBox();
            this.films_list = new System.Windows.Forms.ListBox();
            this.add_film_btn = new System.Windows.Forms.Button();
            this.ok_btn = new System.Windows.Forms.Button();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // name_tb
            // 
            this.name_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.name_tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.name_tb.Font = new System.Drawing.Font("XO Courser", 12F);
            this.name_tb.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.name_tb.Location = new System.Drawing.Point(431, 235);
            this.name_tb.Name = "name_tb";
            this.name_tb.Size = new System.Drawing.Size(501, 44);
            this.name_tb.TabIndex = 77;
            this.name_tb.TabStop = false;
            this.name_tb.Text = "Введите название";
            this.name_tb.Click += new System.EventHandler(this.name_tb_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel4.Controls.Add(this.title_lbl);
            this.panel4.Location = new System.Drawing.Point(29, 222);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(311, 68);
            this.panel4.TabIndex = 76;
            // 
            // title_lbl
            // 
            this.title_lbl.AutoSize = true;
            this.title_lbl.Font = new System.Drawing.Font("XO Courser", 11F);
            this.title_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(242)))));
            this.title_lbl.Location = new System.Drawing.Point(9, 18);
            this.title_lbl.Name = "title_lbl";
            this.title_lbl.Size = new System.Drawing.Size(159, 33);
            this.title_lbl.TabIndex = 9;
            this.title_lbl.Text = "Название";
            // 
            // upper_panel
            // 
            this.upper_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(162)))), ((int)(((byte)(167)))));
            this.upper_panel.Location = new System.Drawing.Point(-34, 156);
            this.upper_panel.Name = "upper_panel";
            this.upper_panel.Size = new System.Drawing.Size(1348, 14);
            this.upper_panel.TabIndex = 75;
            // 
            // info_lbl1
            // 
            this.info_lbl1.AutoSize = true;
            this.info_lbl1.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info_lbl1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(242)))));
            this.info_lbl1.Location = new System.Drawing.Point(296, 78);
            this.info_lbl1.Name = "info_lbl1";
            this.info_lbl1.Size = new System.Drawing.Size(491, 57);
            this.info_lbl1.TabIndex = 74;
            this.info_lbl1.Text = "Создание подборки";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.films_lbl);
            this.panel2.Location = new System.Drawing.Point(29, 356);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(311, 68);
            this.panel2.TabIndex = 77;
            // 
            // films_lbl
            // 
            this.films_lbl.AutoSize = true;
            this.films_lbl.Font = new System.Drawing.Font("XO Courser", 11F);
            this.films_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(242)))));
            this.films_lbl.Location = new System.Drawing.Point(9, 18);
            this.films_lbl.Name = "films_lbl";
            this.films_lbl.Size = new System.Drawing.Size(285, 33);
            this.films_lbl.TabIndex = 9;
            this.films_lbl.Text = "Фильмы подборки";
            // 
            // search_film_tb
            // 
            this.search_film_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.search_film_tb.Font = new System.Drawing.Font("XO Courser", 9F);
            this.search_film_tb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(242)))));
            this.search_film_tb.Location = new System.Drawing.Point(431, 356);
            this.search_film_tb.Name = "search_film_tb";
            this.search_film_tb.Size = new System.Drawing.Size(501, 35);
            this.search_film_tb.TabIndex = 101;
            this.search_film_tb.Text = "Поиск по списку..";
            this.search_film_tb.Click += new System.EventHandler(this.search_film_tb_Click);
            this.search_film_tb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.search_film_tb_KeyDown);
            // 
            // films_list
            // 
            this.films_list.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.films_list.Font = new System.Drawing.Font("XO Courser", 12F);
            this.films_list.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(242)))));
            this.films_list.FormattingEnabled = true;
            this.films_list.ItemHeight = 36;
            this.films_list.Location = new System.Drawing.Point(431, 397);
            this.films_list.Name = "films_list";
            this.films_list.Size = new System.Drawing.Size(501, 220);
            this.films_list.TabIndex = 100;
            this.films_list.SelectedIndexChanged += new System.EventHandler(this.films_list_SelectedIndexChanged);
            // 
            // add_film_btn
            // 
            this.add_film_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.add_film_btn.Font = new System.Drawing.Font("XO Courser", 8F);
            this.add_film_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(242)))));
            this.add_film_btn.Location = new System.Drawing.Point(773, 623);
            this.add_film_btn.Name = "add_film_btn";
            this.add_film_btn.Size = new System.Drawing.Size(159, 42);
            this.add_film_btn.TabIndex = 102;
            this.add_film_btn.Text = "Добавить";
            this.add_film_btn.UseVisualStyleBackColor = false;
            this.add_film_btn.Visible = false;
            this.add_film_btn.Click += new System.EventHandler(this.add_film_btn_Click);
            // 
            // ok_btn
            // 
            this.ok_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(210)))), ((int)(((byte)(219)))));
            this.ok_btn.Font = new System.Drawing.Font("XO Courser", 9F);
            this.ok_btn.Location = new System.Drawing.Point(842, 754);
            this.ok_btn.Name = "ok_btn";
            this.ok_btn.Size = new System.Drawing.Size(195, 54);
            this.ok_btn.TabIndex = 103;
            this.ok_btn.Text = "Завершить";
            this.ok_btn.UseVisualStyleBackColor = false;
            this.ok_btn.Visible = false;
            this.ok_btn.Click += new System.EventHandler(this.ok_btn_Click);
            // 
            // CreateCollection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(90)))), ((int)(((byte)(86)))));
            this.ClientSize = new System.Drawing.Size(1063, 846);
            this.Controls.Add(this.ok_btn);
            this.Controls.Add(this.add_film_btn);
            this.Controls.Add(this.search_film_tb);
            this.Controls.Add(this.films_list);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.name_tb);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.upper_panel);
            this.Controls.Add(this.info_lbl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreateCollection";
            this.Text = "Создание подборки";
            this.Load += new System.EventHandler(this.CreateCollection_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name_tb;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label title_lbl;
        private System.Windows.Forms.Panel upper_panel;
        private System.Windows.Forms.Label info_lbl1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label films_lbl;
        private System.Windows.Forms.TextBox search_film_tb;
        private System.Windows.Forms.ListBox films_list;
        private System.Windows.Forms.Button add_film_btn;
        private System.Windows.Forms.Button ok_btn;
    }
}