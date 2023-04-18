namespace TeamProject2__ListOfRecommendations
{
    partial class Authorization
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authorization));
            this.info_lbl = new System.Windows.Forms.Label();
            this.registration_btn = new System.Windows.Forms.Label();
            this.forgotpassword_btn = new System.Windows.Forms.Label();
            this.go_btn = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.login_tb = new System.Windows.Forms.TextBox();
            this.password_tb = new System.Windows.Forms.TextBox();
            this.picture_logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picture_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // info_lbl
            // 
            this.info_lbl.AutoSize = true;
            this.info_lbl.Font = new System.Drawing.Font("XO Courser", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.info_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(242)))));
            this.info_lbl.Location = new System.Drawing.Point(174, 397);
            this.info_lbl.Name = "info_lbl";
            this.info_lbl.Size = new System.Drawing.Size(775, 36);
            this.info_lbl.TabIndex = 1;
            this.info_lbl.Text = "Войдите в учетную запись для продолжения";
            // 
            // registration_btn
            // 
            this.registration_btn.AutoSize = true;
            this.registration_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registration_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(162)))), ((int)(((byte)(167)))));
            this.registration_btn.Location = new System.Drawing.Point(30, 748);
            this.registration_btn.Name = "registration_btn";
            this.registration_btn.Size = new System.Drawing.Size(252, 29);
            this.registration_btn.TabIndex = 4;
            this.registration_btn.Text = "Зарегестрироваться";
            this.registration_btn.Click += new System.EventHandler(this.registration_btn_Click);
            this.registration_btn.MouseEnter += new System.EventHandler(this.registration_btn_MouseEnter);
            this.registration_btn.MouseLeave += new System.EventHandler(this.registration_btn_MouseLeave);
            // 
            // forgotpassword_btn
            // 
            this.forgotpassword_btn.AutoSize = true;
            this.forgotpassword_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.forgotpassword_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(162)))), ((int)(((byte)(167)))));
            this.forgotpassword_btn.Location = new System.Drawing.Point(458, 625);
            this.forgotpassword_btn.Name = "forgotpassword_btn";
            this.forgotpassword_btn.Size = new System.Drawing.Size(204, 29);
            this.forgotpassword_btn.TabIndex = 5;
            this.forgotpassword_btn.Text = "Забыли пароль?";
            this.forgotpassword_btn.Visible = false;
            this.forgotpassword_btn.Click += new System.EventHandler(this.forgotpassword_btn_Click);
            this.forgotpassword_btn.MouseEnter += new System.EventHandler(this.forgotpassword_btn_MouseEnter);
            this.forgotpassword_btn.MouseLeave += new System.EventHandler(this.forgotpassword_btn_MouseLeave);
            // 
            // go_btn
            // 
            this.go_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(210)))), ((int)(((byte)(219)))));
            this.go_btn.Font = new System.Drawing.Font("XO Courser", 10F);
            this.go_btn.Location = new System.Drawing.Point(859, 740);
            this.go_btn.Name = "go_btn";
            this.go_btn.Size = new System.Drawing.Size(204, 47);
            this.go_btn.TabIndex = 6;
            this.go_btn.Text = "Войти";
            this.go_btn.UseVisualStyleBackColor = false;
            this.go_btn.Click += new System.EventHandler(this.go_btn_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // login_tb
            // 
            this.login_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(242)))));
            this.login_tb.Font = new System.Drawing.Font("XO Courser", 10F);
            this.login_tb.ForeColor = System.Drawing.Color.Gray;
            this.login_tb.Location = new System.Drawing.Point(295, 490);
            this.login_tb.Name = "login_tb";
            this.login_tb.Size = new System.Drawing.Size(516, 38);
            this.login_tb.TabIndex = 2;
            this.login_tb.TabStop = false;
            this.login_tb.Text = "Введите логин";
            this.login_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.login_tb.Click += new System.EventHandler(this.login_tb_Click);
            this.login_tb.MouseEnter += new System.EventHandler(this.login_tb_MouseEnter);
            this.login_tb.MouseLeave += new System.EventHandler(this.login_tb_MouseLeave);
            // 
            // password_tb
            // 
            this.password_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(242)))));
            this.password_tb.Font = new System.Drawing.Font("XO Courser", 10F);
            this.password_tb.ForeColor = System.Drawing.Color.Gray;
            this.password_tb.Location = new System.Drawing.Point(295, 567);
            this.password_tb.Name = "password_tb";
            this.password_tb.Size = new System.Drawing.Size(516, 38);
            this.password_tb.TabIndex = 3;
            this.password_tb.TabStop = false;
            this.password_tb.Text = "Введите пароль";
            this.password_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.password_tb.Click += new System.EventHandler(this.password_tb_Click);
            this.password_tb.MouseEnter += new System.EventHandler(this.password_tb_MouseEnter);
            this.password_tb.MouseLeave += new System.EventHandler(this.password_tb_MouseLeave);
            // 
            // picture_logo
            // 
            this.picture_logo.Image = ((System.Drawing.Image)(resources.GetObject("picture_logo.Image")));
            this.picture_logo.Location = new System.Drawing.Point(169, 63);
            this.picture_logo.Name = "picture_logo";
            this.picture_logo.Size = new System.Drawing.Size(780, 331);
            this.picture_logo.TabIndex = 0;
            this.picture_logo.TabStop = false;
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(90)))), ((int)(((byte)(86)))));
            this.ClientSize = new System.Drawing.Size(1089, 810);
            this.Controls.Add(this.go_btn);
            this.Controls.Add(this.forgotpassword_btn);
            this.Controls.Add(this.registration_btn);
            this.Controls.Add(this.password_tb);
            this.Controls.Add(this.login_tb);
            this.Controls.Add(this.info_lbl);
            this.Controls.Add(this.picture_logo);
            this.Name = "Authorization";
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.Authorization_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picture_logo;
        private System.Windows.Forms.Label info_lbl;
        private System.Windows.Forms.Label registration_btn;
        private System.Windows.Forms.Label forgotpassword_btn;
        private System.Windows.Forms.Button go_btn;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TextBox login_tb;
        private System.Windows.Forms.TextBox password_tb;
    }
}

