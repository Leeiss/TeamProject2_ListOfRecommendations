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
            this.administration_btn = new System.Windows.Forms.Label();
            this.close_panel = new System.Windows.Forms.Panel();
            this.email_panel = new System.Windows.Forms.Panel();
            this.again_btn = new System.Windows.Forms.Button();
            this.send_kod_email = new System.Windows.Forms.Button();
            this.email_password = new System.Windows.Forms.TextBox();
            this.info_email_lbl = new System.Windows.Forms.Label();
            this.hide_btn1 = new System.Windows.Forms.PictureBox();
            this.show_btn1 = new System.Windows.Forms.PictureBox();
            this.adminrights_btn_cancel = new System.Windows.Forms.Button();
            this.admin_btn = new System.Windows.Forms.Button();
            this.admin_password_tb = new System.Windows.Forms.TextBox();
            this.info_lbl1 = new System.Windows.Forms.Label();
            this.picture_logo = new System.Windows.Forms.PictureBox();
            this.hide_btn = new System.Windows.Forms.PictureBox();
            this.show_btn = new System.Windows.Forms.PictureBox();
            this.go_to_email = new System.Windows.Forms.Button();
            this.close_panel.SuspendLayout();
            this.email_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hide_btn1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.show_btn1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hide_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.show_btn)).BeginInit();
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
            this.go_btn.Location = new System.Drawing.Point(800, 412);
            this.go_btn.Name = "go_btn";
            this.go_btn.Size = new System.Drawing.Size(246, 47);
            this.go_btn.TabIndex = 14;
            this.go_btn.Text = "Далее";
            this.go_btn.UseVisualStyleBackColor = false;
            this.go_btn.Visible = false;
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
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
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
            this.password_tb.TextChanged += new System.EventHandler(this.password_tb_TextChanged);
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
            this.login_tb.TextChanged += new System.EventHandler(this.login_tb_TextChanged);
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
            // administration_btn
            // 
            this.administration_btn.AutoSize = true;
            this.administration_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.administration_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(162)))), ((int)(((byte)(167)))));
            this.administration_btn.Location = new System.Drawing.Point(347, 792);
            this.administration_btn.Name = "administration_btn";
            this.administration_btn.Size = new System.Drawing.Size(417, 29);
            this.administration_btn.TabIndex = 21;
            this.administration_btn.Text = "У вас есть права администратора?";
            this.administration_btn.Click += new System.EventHandler(this.administration_btn_Click);
            this.administration_btn.MouseEnter += new System.EventHandler(this.administration_btn_MouseEnter);
            this.administration_btn.MouseLeave += new System.EventHandler(this.administration_btn_MouseLeave);
            // 
            // close_panel
            // 
            this.close_panel.Controls.Add(this.hide_btn1);
            this.close_panel.Controls.Add(this.show_btn1);
            this.close_panel.Controls.Add(this.adminrights_btn_cancel);
            this.close_panel.Controls.Add(this.admin_btn);
            this.close_panel.Controls.Add(this.admin_password_tb);
            this.close_panel.Controls.Add(this.info_lbl1);
            this.close_panel.Location = new System.Drawing.Point(12, 428);
            this.close_panel.Name = "close_panel";
            this.close_panel.Size = new System.Drawing.Size(1057, 476);
            this.close_panel.TabIndex = 22;
            this.close_panel.Visible = false;
            // 
            // email_panel
            // 
            this.email_panel.Controls.Add(this.again_btn);
            this.email_panel.Controls.Add(this.email_password);
            this.email_panel.Controls.Add(this.info_email_lbl);
            this.email_panel.Controls.Add(this.go_btn);
            this.email_panel.Controls.Add(this.send_kod_email);
            this.email_panel.Location = new System.Drawing.Point(6, 438);
            this.email_panel.Name = "email_panel";
            this.email_panel.Size = new System.Drawing.Size(1060, 474);
            this.email_panel.TabIndex = 25;
            this.email_panel.Visible = false;
            // 
            // again_btn
            // 
            this.again_btn.BackColor = System.Drawing.Color.Gray;
            this.again_btn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.again_btn.Font = new System.Drawing.Font("XO Courser", 10F);
            this.again_btn.Location = new System.Drawing.Point(21, 407);
            this.again_btn.Name = "again_btn";
            this.again_btn.Size = new System.Drawing.Size(251, 47);
            this.again_btn.TabIndex = 75;
            this.again_btn.Text = "Изменить адрес";
            this.again_btn.UseVisualStyleBackColor = false;
            this.again_btn.Click += new System.EventHandler(this.again_btn_Click);
            // 
            // send_kod_email
            // 
            this.send_kod_email.BackColor = System.Drawing.Color.Gray;
            this.send_kod_email.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.send_kod_email.Font = new System.Drawing.Font("XO Courser", 10F);
            this.send_kod_email.Location = new System.Drawing.Point(804, 412);
            this.send_kod_email.Name = "send_kod_email";
            this.send_kod_email.Size = new System.Drawing.Size(246, 47);
            this.send_kod_email.TabIndex = 23;
            this.send_kod_email.Text = "Ввод";
            this.send_kod_email.UseVisualStyleBackColor = false;
            this.send_kod_email.Click += new System.EventHandler(this.send_kod_email_Click);
            // 
            // email_password
            // 
            this.email_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.email_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.email_password.Font = new System.Drawing.Font("XO Courser", 12F);
            this.email_password.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.email_password.Location = new System.Drawing.Point(327, 148);
            this.email_password.Name = "email_password";
            this.email_password.Size = new System.Drawing.Size(378, 44);
            this.email_password.TabIndex = 74;
            this.email_password.TabStop = false;
            // 
            // info_email_lbl
            // 
            this.info_email_lbl.AutoSize = true;
            this.info_email_lbl.Font = new System.Drawing.Font("XO Courser", 11F);
            this.info_email_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(242)))));
            this.info_email_lbl.Location = new System.Drawing.Point(204, 52);
            this.info_email_lbl.Name = "info_email_lbl";
            this.info_email_lbl.Size = new System.Drawing.Size(663, 66);
            this.info_email_lbl.TabIndex = 23;
            this.info_email_lbl.Text = "Подтвердите адрес электронной почты \r\nкодом, который мы вам отправили";
            this.info_email_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hide_btn1
            // 
            this.hide_btn1.Image = ((System.Drawing.Image)(resources.GetObject("hide_btn1.Image")));
            this.hide_btn1.Location = new System.Drawing.Point(732, 143);
            this.hide_btn1.Name = "hide_btn1";
            this.hide_btn1.Size = new System.Drawing.Size(79, 55);
            this.hide_btn1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hide_btn1.TabIndex = 24;
            this.hide_btn1.TabStop = false;
            this.hide_btn1.Visible = false;
            this.hide_btn1.Click += new System.EventHandler(this.hide_btn1_Click);
            // 
            // show_btn1
            // 
            this.show_btn1.Image = ((System.Drawing.Image)(resources.GetObject("show_btn1.Image")));
            this.show_btn1.Location = new System.Drawing.Point(732, 143);
            this.show_btn1.Name = "show_btn1";
            this.show_btn1.Size = new System.Drawing.Size(79, 55);
            this.show_btn1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.show_btn1.TabIndex = 23;
            this.show_btn1.TabStop = false;
            this.show_btn1.Visible = false;
            this.show_btn1.Click += new System.EventHandler(this.show_btn1_Click);
            // 
            // adminrights_btn_cancel
            // 
            this.adminrights_btn_cancel.BackColor = System.Drawing.Color.Gray;
            this.adminrights_btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.adminrights_btn_cancel.Font = new System.Drawing.Font("XO Courser", 10F);
            this.adminrights_btn_cancel.Location = new System.Drawing.Point(18, 388);
            this.adminrights_btn_cancel.Name = "adminrights_btn_cancel";
            this.adminrights_btn_cancel.Size = new System.Drawing.Size(151, 47);
            this.adminrights_btn_cancel.TabIndex = 75;
            this.adminrights_btn_cancel.Text = "Отмена";
            this.adminrights_btn_cancel.UseVisualStyleBackColor = false;
            this.adminrights_btn_cancel.Visible = false;
            this.adminrights_btn_cancel.Click += new System.EventHandler(this.adminrights_btn_cancel_Click);
            // 
            // admin_btn
            // 
            this.admin_btn.BackColor = System.Drawing.Color.Gray;
            this.admin_btn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.admin_btn.Font = new System.Drawing.Font("XO Courser", 10F);
            this.admin_btn.Location = new System.Drawing.Point(889, 388);
            this.admin_btn.Name = "admin_btn";
            this.admin_btn.Size = new System.Drawing.Size(151, 47);
            this.admin_btn.TabIndex = 23;
            this.admin_btn.Text = "Ввод";
            this.admin_btn.UseVisualStyleBackColor = false;
            this.admin_btn.Visible = false;
            this.admin_btn.Click += new System.EventHandler(this.admin_btn_Click);
            // 
            // admin_password_tb
            // 
            this.admin_password_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.admin_password_tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.admin_password_tb.Font = new System.Drawing.Font("XO Courser", 12F);
            this.admin_password_tb.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.admin_password_tb.Location = new System.Drawing.Point(327, 148);
            this.admin_password_tb.Name = "admin_password_tb";
            this.admin_password_tb.Size = new System.Drawing.Size(378, 44);
            this.admin_password_tb.TabIndex = 74;
            this.admin_password_tb.TabStop = false;
            this.admin_password_tb.Visible = false;
            this.admin_password_tb.TextChanged += new System.EventHandler(this.admin_password_tb_TextChanged);
            // 
            // info_lbl1
            // 
            this.info_lbl1.AutoSize = true;
            this.info_lbl1.Font = new System.Drawing.Font("XO Courser", 11F);
            this.info_lbl1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(242)))));
            this.info_lbl1.Location = new System.Drawing.Point(241, 75);
            this.info_lbl1.Name = "info_lbl1";
            this.info_lbl1.Size = new System.Drawing.Size(537, 33);
            this.info_lbl1.TabIndex = 23;
            this.info_lbl1.Text = "Введите пароль администратора";
            this.info_lbl1.Visible = false;
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
            // hide_btn
            // 
            this.hide_btn.Image = ((System.Drawing.Image)(resources.GetObject("hide_btn.Image")));
            this.hide_btn.Location = new System.Drawing.Point(815, 611);
            this.hide_btn.Name = "hide_btn";
            this.hide_btn.Size = new System.Drawing.Size(79, 55);
            this.hide_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hide_btn.TabIndex = 24;
            this.hide_btn.TabStop = false;
            this.hide_btn.Visible = false;
            this.hide_btn.Click += new System.EventHandler(this.hide_btn_Click);
            // 
            // show_btn
            // 
            this.show_btn.Image = ((System.Drawing.Image)(resources.GetObject("show_btn.Image")));
            this.show_btn.Location = new System.Drawing.Point(815, 611);
            this.show_btn.Name = "show_btn";
            this.show_btn.Size = new System.Drawing.Size(79, 55);
            this.show_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.show_btn.TabIndex = 23;
            this.show_btn.TabStop = false;
            this.show_btn.Visible = false;
            this.show_btn.Click += new System.EventHandler(this.show_btn_Click);
            // 
            // go_to_email
            // 
            this.go_to_email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(210)))), ((int)(((byte)(219)))));
            this.go_to_email.Font = new System.Drawing.Font("XO Courser", 10F);
            this.go_to_email.Location = new System.Drawing.Point(848, 857);
            this.go_to_email.Name = "go_to_email";
            this.go_to_email.Size = new System.Drawing.Size(204, 47);
            this.go_to_email.TabIndex = 25;
            this.go_to_email.Text = "Далее";
            this.go_to_email.UseVisualStyleBackColor = false;
            this.go_to_email.Click += new System.EventHandler(this.go_to_email_Click);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(90)))), ((int)(((byte)(86)))));
            this.CancelButton = this.cancel_btn;
            this.ClientSize = new System.Drawing.Size(1074, 923);
            this.Controls.Add(this.close_panel);
            this.Controls.Add(this.email_panel);
            this.Controls.Add(this.registration_lbl);
            this.Controls.Add(this.picture_logo);
            this.Controls.Add(this.login_tb);
            this.Controls.Add(this.password_tb);
            this.Controls.Add(this.email_tb);
            this.Controls.Add(this.info_lbl);
            this.Controls.Add(this.hide_btn);
            this.Controls.Add(this.show_btn);
            this.Controls.Add(this.administration_btn);
            this.Controls.Add(this.go_to_email);
            this.Controls.Add(this.cancel_btn);
            this.Name = "Registration";
            this.Text = "Регистрация";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Registration_FormClosed);
            this.Load += new System.EventHandler(this.Registration_Load);
            this.close_panel.ResumeLayout(false);
            this.close_panel.PerformLayout();
            this.email_panel.ResumeLayout(false);
            this.email_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hide_btn1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.show_btn1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hide_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.show_btn)).EndInit();
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
        private System.Windows.Forms.Label administration_btn;
        private System.Windows.Forms.Panel close_panel;
        private System.Windows.Forms.Label info_lbl1;
        private System.Windows.Forms.Button admin_btn;
        private System.Windows.Forms.TextBox admin_password_tb;
        private System.Windows.Forms.Button adminrights_btn_cancel;
        private System.Windows.Forms.PictureBox hide_btn1;
        private System.Windows.Forms.PictureBox show_btn1;
        private System.Windows.Forms.PictureBox hide_btn;
        private System.Windows.Forms.PictureBox show_btn;
        private System.Windows.Forms.Panel email_panel;
        private System.Windows.Forms.Button again_btn;
        private System.Windows.Forms.Button send_kod_email;
        private System.Windows.Forms.TextBox email_password;
        private System.Windows.Forms.Label info_email_lbl;
        private System.Windows.Forms.Button go_to_email;
    }
}