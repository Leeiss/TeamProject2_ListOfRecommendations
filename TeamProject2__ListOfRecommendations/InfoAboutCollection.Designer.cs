namespace TeamProject2__ListOfRecommendations
{
    partial class InfoAboutCollection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoAboutCollection));
            this.go_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.films_list = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.collection_title_lbl = new System.Windows.Forms.Label();
            this.just_panel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // go_btn
            // 
            this.go_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(210)))), ((int)(((byte)(219)))));
            this.go_btn.Font = new System.Drawing.Font("XO Courser", 9F);
            this.go_btn.Location = new System.Drawing.Point(565, 541);
            this.go_btn.Name = "go_btn";
            this.go_btn.Size = new System.Drawing.Size(243, 74);
            this.go_btn.TabIndex = 109;
            this.go_btn.Text = "Перейти к просмотру";
            this.go_btn.UseVisualStyleBackColor = false;
            this.go_btn.Visible = false;
            this.go_btn.Click += new System.EventHandler(this.go_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("XO Courser", 10F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(242)))));
            this.label2.Location = new System.Drawing.Point(71, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(253, 30);
            this.label2.TabIndex = 105;
            this.label2.Text = "Фильмы подборки";
            // 
            // films_list
            // 
            this.films_list.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.films_list.Font = new System.Drawing.Font("XO Courser", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.films_list.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(242)))));
            this.films_list.FormattingEnabled = true;
            this.films_list.ItemHeight = 36;
            this.films_list.Location = new System.Drawing.Point(76, 295);
            this.films_list.Name = "films_list";
            this.films_list.Size = new System.Drawing.Size(732, 220);
            this.films_list.TabIndex = 108;
            this.films_list.SelectedIndexChanged += new System.EventHandler(this.films_list_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(162)))), ((int)(((byte)(167)))));
            this.panel1.Location = new System.Drawing.Point(-94, 134);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1348, 14);
            this.panel1.TabIndex = 107;
            // 
            // collection_title_lbl
            // 
            this.collection_title_lbl.AutoSize = true;
            this.collection_title_lbl.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.collection_title_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(242)))));
            this.collection_title_lbl.Location = new System.Drawing.Point(294, 53);
            this.collection_title_lbl.Name = "collection_title_lbl";
            this.collection_title_lbl.Size = new System.Drawing.Size(283, 57);
            this.collection_title_lbl.TabIndex = 106;
            this.collection_title_lbl.Text = "Избранное";
            // 
            // just_panel
            // 
            this.just_panel.Location = new System.Drawing.Point(817, 693);
            this.just_panel.Name = "just_panel";
            this.just_panel.Size = new System.Drawing.Size(46, 45);
            this.just_panel.TabIndex = 110;
            // 
            // InfoAboutCollection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(90)))), ((int)(((byte)(86)))));
            this.ClientSize = new System.Drawing.Size(880, 760);
            this.Controls.Add(this.just_panel);
            this.Controls.Add(this.go_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.films_list);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.collection_title_lbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InfoAboutCollection";
            this.Text = "Информация по подборке";
            this.Load += new System.EventHandler(this.InfoAboutCollection_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button go_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox films_list;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label collection_title_lbl;
        private System.Windows.Forms.Panel just_panel;
    }
}