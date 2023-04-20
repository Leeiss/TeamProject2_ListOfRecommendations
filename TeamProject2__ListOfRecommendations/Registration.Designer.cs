namespace TeamProject2__ListOfRecommendations
{
    partial class Registration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration));
            this.registration_lbl = new System.Windows.Forms.Label();
            this.go_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.info_lbl = new System.Windows.Forms.Label();
            this.password_tb = new System.Windows.Forms.TextBox();
            this.login_tb = new System.Windows.Forms.TextBox();
            this.email_tb = new System.Windows.Forms.TextBox();
            this.picture_logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picture_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // registration_lbl
            // 
            this.registration_lbl.AutoSize = true;
            this.registration_lbl.Font = new System.Drawing.Font("XO Courser", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registration_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(242)))));
            this.registration_lbl.Location = new System.Drawing.Point(159, 375);
            this.registration_lbl.Name = "registration_lbl";
            this.registration_lbl.Size = new System.Drawing.Size(775, 36);
            this.registration_lbl.TabIndex = 15;
            this.registration_lbl.Text = "Добро пожаловать в Список рекомендаций !";
            // 
            // go_btn
            // 
            this.go_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(210)))), ((int)(((byte)(219)))));
            this.go_btn.Font = new System.Drawing.Font("XO Courser", 10F);
            this.go_btn.Location = new System.Drawing.Point(852, 852);
            this.go_btn.Name = "go_btn";
            this.go_btn.Size = new System.Drawing.Size(204, 47);
            this.go_btn.TabIndex = 14;
            this.go_btn.Text = "Далее";
            this.go_btn.UseVisualStyleBackColor = false;
            this.go_btn.Click += new System.EventHandler(this.go_btn_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.BackColor = System.Drawing.Color.Gray;
            this.cancel_btn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel_btn.Font = new System.Drawing.Font("XO Courser", 10F);
            this.cancel_btn.Location = new System.Drawing.Point(27, 852);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(151, 47);
            this.cancel_btn.TabIndex = 16;
            this.cancel_btn.Text = "Отмена";
            this.cancel_btn.UseVisualStyleBackColor = false;
            // 
            // info_lbl
            // 
            this.info_lbl.AutoSize = true;
            this.info_lbl.Font = new System.Drawing.Font("XO Courser", 10F);
            this.info_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(242)))));
            this.info_lbl.Location = new System.Drawing.Point(324, 482);
            this.info_lbl.Name = "info_lbl";
            this.info_lbl.Size = new System.Drawing.Size(429, 30);
            this.info_lbl.TabIndex = 17;
            this.info_lbl.Text = "Придумайте логин и пароль ";
            // 
            // password_tb
            // 
            this.password_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(242)))));
            this.password_tb.Font = new System.Drawing.Font("XO Courser", 10F);
            this.password_tb.ForeColor = System.Drawing.Color.Gray;
            this.password_tb.Location = new System.Drawing.Point(281, 618);
            this.password_tb.Name = "password_tb";
            this.password_tb.Size = new System.Drawing.Size(516, 38);
            this.password_tb.TabIndex = 19;
            this.password_tb.TabStop = false;
            this.password_tb.Text = "Введите пароль";
            this.password_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.password_tb.Click += new System.EventHandler(this.password_tb_Click);
            // 
            // login_tb
            // 
            this.login_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(242)))));
            this.login_tb.Font = new System.Drawing.Font("XO Courser", 10F);
            this.login_tb.ForeColor = System.Drawing.Color.Gray;
            this.login_tb.Location = new System.Drawing.Point(281, 541);
            this.login_tb.Name = "login_tb";
            this.login_tb.Size = new System.Drawing.Size(516, 38);
            this.login_tb.TabIndex = 18;
            this.login_tb.TabStop = false;
            this.login_tb.Text = "Введите логин";
            this.login_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.login_tb.Click += new System.EventHandler(this.login_tb_Click);
            // 
            // email_tb
            // 
            this.email_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(242)))));
            this.email_tb.Font = new System.Drawing.Font("XO Courser", 10F);
            this.email_tb.ForeColor = System.Drawing.Color.Gray;
            this.email_tb.Location = new System.Drawing.Point(281, 720);
            this.email_tb.Name = "email_tb";
            this.email_tb.Size = new System.Drawing.Size(516, 38);
            this.email_tb.TabIndex = 20;
            this.email_tb.TabStop = false;
            this.email_tb.Text = "Введите email";
            this.email_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.email_tb.Click += new System.EventHandler(this.email_tb_Click);
            // 
            // picture_logo
            // 
            this.picture_logo.Image = ((System.Drawing.Image)(resources.GetObject("picture_logo.Image")));
            this.picture_logo.Location = new System.Drawing.Point(154, 41);
            this.picture_logo.Name = "picture_logo";
            this.picture_logo.Size = new System.Drawing.Size(780, 331);
            this.picture_logo.TabIndex = 8;
            this.picture_logo.TabStop = false;
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(90)))), ((int)(((byte)(86)))));
            this.CancelButton = this.cancel_btn;
            this.ClientSize = new System.Drawing.Size(1074, 923);
            this.Controls.Add(this.email_tb);
            this.Controls.Add(this.password_tb);
            this.Controls.Add(this.login_tb);
            this.Controls.Add(this.info_lbl);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.registration_lbl);
            this.Controls.Add(this.go_btn);
            this.Controls.Add(this.picture_logo);
            this.Name = "Registration";
            this.Text = "Регистрация";
            this.Load += new System.EventHandler(this.Registration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label registration_lbl;
        private System.Windows.Forms.Button go_btn;
        private System.Windows.Forms.PictureBox picture_logo;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Label info_lbl;
        private System.Windows.Forms.TextBox password_tb;
        private System.Windows.Forms.TextBox login_tb;
        private System.Windows.Forms.TextBox email_tb;
    }
}