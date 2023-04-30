namespace TeamProject2__ListOfRecommendations
{
    partial class СhooseCollection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(СhooseCollection));
            this.info_lbl1 = new System.Windows.Forms.Label();
            this.collections_list = new System.Windows.Forms.ListBox();
            this.add_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // info_lbl1
            // 
            this.info_lbl1.AutoSize = true;
            this.info_lbl1.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info_lbl1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(242)))));
            this.info_lbl1.Location = new System.Drawing.Point(103, 79);
            this.info_lbl1.Name = "info_lbl1";
            this.info_lbl1.Size = new System.Drawing.Size(506, 57);
            this.info_lbl1.TabIndex = 76;
            this.info_lbl1.Text = "Выберите подборку:";
            // 
            // collections_list
            // 
            this.collections_list.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.collections_list.Font = new System.Drawing.Font("XO Courser", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.collections_list.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(242)))));
            this.collections_list.FormattingEnabled = true;
            this.collections_list.ItemHeight = 36;
            this.collections_list.Location = new System.Drawing.Point(49, 206);
            this.collections_list.Name = "collections_list";
            this.collections_list.Size = new System.Drawing.Size(617, 364);
            this.collections_list.TabIndex = 103;
            this.collections_list.SelectedIndexChanged += new System.EventHandler(this.collections_list_SelectedIndexChanged);
            // 
            // add_btn
            // 
            this.add_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(210)))), ((int)(((byte)(219)))));
            this.add_btn.Font = new System.Drawing.Font("XO Courser", 9F);
            this.add_btn.Location = new System.Drawing.Point(518, 612);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(165, 52);
            this.add_btn.TabIndex = 104;
            this.add_btn.Text = "Добавить";
            this.add_btn.UseVisualStyleBackColor = false;
            this.add_btn.Visible = false;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // СhooseCollection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(90)))), ((int)(((byte)(86)))));
            this.ClientSize = new System.Drawing.Size(707, 696);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.collections_list);
            this.Controls.Add(this.info_lbl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "СhooseCollection";
            this.Text = "Выбор подборки";
            this.Load += new System.EventHandler(this.СhooseCollection_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label info_lbl1;
        private System.Windows.Forms.ListBox collections_list;
        private System.Windows.Forms.Button add_btn;
    }
}