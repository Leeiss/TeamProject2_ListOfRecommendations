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
            this.changepassword_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.info_lbl1 = new System.Windows.Forms.Label();
            this.just_panel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // changepassword_btn
            // 
            this.changepassword_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(210)))), ((int)(((byte)(219)))));
            this.changepassword_btn.Font = new System.Drawing.Font("XO Courser", 9F);
            this.changepassword_btn.Location = new System.Drawing.Point(565, 541);
            this.changepassword_btn.Name = "changepassword_btn";
            this.changepassword_btn.Size = new System.Drawing.Size(243, 74);
            this.changepassword_btn.TabIndex = 109;
            this.changepassword_btn.Text = "Перейти к просмотру";
            this.changepassword_btn.UseVisualStyleBackColor = false;
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
            // listBox2
            // 
            this.listBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.listBox2.Font = new System.Drawing.Font("XO Courser", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(242)))));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 36;
            this.listBox2.Items.AddRange(new object[] {
            "Фильм1",
            "Фильм2",
            "Фильм3"});
            this.listBox2.Location = new System.Drawing.Point(76, 295);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(732, 220);
            this.listBox2.TabIndex = 108;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(162)))), ((int)(((byte)(167)))));
            this.panel1.Location = new System.Drawing.Point(-94, 134);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1348, 14);
            this.panel1.TabIndex = 107;
            // 
            // info_lbl1
            // 
            this.info_lbl1.AutoSize = true;
            this.info_lbl1.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info_lbl1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(242)))));
            this.info_lbl1.Location = new System.Drawing.Point(294, 53);
            this.info_lbl1.Name = "info_lbl1";
            this.info_lbl1.Size = new System.Drawing.Size(283, 57);
            this.info_lbl1.TabIndex = 106;
            this.info_lbl1.Text = "Избранное";
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
            this.Controls.Add(this.changepassword_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.info_lbl1);
            this.Name = "InfoAboutCollection";
            this.Text = "Информация по подборке";
            this.Load += new System.EventHandler(this.InfoAboutCollection_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button changepassword_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label info_lbl1;
        private System.Windows.Forms.Panel just_panel;
    }
}