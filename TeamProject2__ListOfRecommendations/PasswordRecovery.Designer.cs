namespace TeamProject2__ListOfRecommendations
{
    partial class PasswordRecovery
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordRecovery));
            this.go_btn = new System.Windows.Forms.Button();
            this.forgotpassword_btn = new System.Windows.Forms.Label();
            this.registration_btn = new System.Windows.Forms.Label();
            this.info_lbl1 = new System.Windows.Forms.Label();
            this.info_lbl = new System.Windows.Forms.Label();
            this.email_tb = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.information_lbl = new System.Windows.Forms.Label();
            this.cod_tb = new System.Windows.Forms.TextBox();
            this.send_btn = new System.Windows.Forms.Button();
            this.newpassword_tb = new System.Windows.Forms.TextBox();
            this.changepassword_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // go_btn
            // 
            this.go_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(210)))), ((int)(((byte)(219)))));
            this.go_btn.Font = new System.Drawing.Font("XO Courser", 10F);
            this.go_btn.Location = new System.Drawing.Point(712, 577);
            this.go_btn.Name = "go_btn";
            this.go_btn.Size = new System.Drawing.Size(204, 47);
            this.go_btn.TabIndex = 13;
            this.go_btn.Text = "Войти";
            this.go_btn.UseVisualStyleBackColor = false;
            // 
            // forgotpassword_btn
            // 
            this.forgotpassword_btn.AutoSize = true;
            this.forgotpassword_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.forgotpassword_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(162)))), ((int)(((byte)(167)))));
            this.forgotpassword_btn.Location = new System.Drawing.Point(-115, 586);
            this.forgotpassword_btn.Name = "forgotpassword_btn";
            this.forgotpassword_btn.Size = new System.Drawing.Size(204, 29);
            this.forgotpassword_btn.TabIndex = 12;
            this.forgotpassword_btn.Text = "Забыли пароль?";
            // 
            // registration_btn
            // 
            this.registration_btn.AutoSize = true;
            this.registration_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registration_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(162)))), ((int)(((byte)(167)))));
            this.registration_btn.Location = new System.Drawing.Point(401, 586);
            this.registration_btn.Name = "registration_btn";
            this.registration_btn.Size = new System.Drawing.Size(252, 29);
            this.registration_btn.TabIndex = 11;
            this.registration_btn.Text = "Зарегестрироваться";
            // 
            // info_lbl1
            // 
            this.info_lbl1.AutoSize = true;
            this.info_lbl1.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info_lbl1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(242)))));
            this.info_lbl1.Location = new System.Drawing.Point(121, 220);
            this.info_lbl1.Name = "info_lbl1";
            this.info_lbl1.Size = new System.Drawing.Size(589, 57);
            this.info_lbl1.TabIndex = 15;
            this.info_lbl1.Text = "Восстановление пароля";
            // 
            // info_lbl
            // 
            this.info_lbl.AutoSize = true;
            this.info_lbl.Font = new System.Drawing.Font("XO Courser", 10F);
            this.info_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(242)))));
            this.info_lbl.Location = new System.Drawing.Point(164, 323);
            this.info_lbl.Name = "info_lbl";
            this.info_lbl.Size = new System.Drawing.Size(509, 30);
            this.info_lbl.TabIndex = 17;
            this.info_lbl.Text = "Введите email для сброса пароля";
            // 
            // email_tb
            // 
            this.email_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(242)))));
            this.email_tb.Font = new System.Drawing.Font("XO Courser", 10F);
            this.email_tb.ForeColor = System.Drawing.Color.Gray;
            this.email_tb.Location = new System.Drawing.Point(157, 370);
            this.email_tb.Name = "email_tb";
            this.email_tb.Size = new System.Drawing.Size(516, 38);
            this.email_tb.TabIndex = 18;
            this.email_tb.TabStop = false;
            this.email_tb.Text = "Введите email";
            this.email_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.email_tb.Click += new System.EventHandler(this.email_tb_Click);
            this.email_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.email_tb_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(162)))), ((int)(((byte)(167)))));
            this.panel1.Location = new System.Drawing.Point(2, 293);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(807, 12);
            this.panel1.TabIndex = 20;
            // 
            // information_lbl
            // 
            this.information_lbl.AutoSize = true;
            this.information_lbl.Font = new System.Drawing.Font("XO Courser", 10F);
            this.information_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(242)))));
            this.information_lbl.Location = new System.Drawing.Point(103, 323);
            this.information_lbl.Name = "information_lbl";
            this.information_lbl.Size = new System.Drawing.Size(637, 30);
            this.information_lbl.TabIndex = 21;
            this.information_lbl.Text = "Введите код, отправленный вам на email ";
            this.information_lbl.Visible = false;
            // 
            // cod_tb
            // 
            this.cod_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(242)))));
            this.cod_tb.Font = new System.Drawing.Font("XO Courser", 10F);
            this.cod_tb.ForeColor = System.Drawing.Color.Gray;
            this.cod_tb.Location = new System.Drawing.Point(157, 370);
            this.cod_tb.Name = "cod_tb";
            this.cod_tb.Size = new System.Drawing.Size(516, 38);
            this.cod_tb.TabIndex = 22;
            this.cod_tb.TabStop = false;
            this.cod_tb.Text = "Введите код";
            this.cod_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cod_tb.Visible = false;
            this.cod_tb.Click += new System.EventHandler(this.cod_tb_Click);
            // 
            // send_btn
            // 
            this.send_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(210)))), ((int)(((byte)(219)))));
            this.send_btn.Font = new System.Drawing.Font("XO Courser", 9F);
            this.send_btn.Location = new System.Drawing.Point(593, 476);
            this.send_btn.Name = "send_btn";
            this.send_btn.Size = new System.Drawing.Size(195, 47);
            this.send_btn.TabIndex = 23;
            this.send_btn.Text = "Отправить";
            this.send_btn.UseVisualStyleBackColor = false;
            this.send_btn.Visible = false;
            this.send_btn.Click += new System.EventHandler(this.send_btn_Click);
            // 
            // newpassword_tb
            // 
            this.newpassword_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(242)))));
            this.newpassword_tb.Font = new System.Drawing.Font("XO Courser", 10F);
            this.newpassword_tb.ForeColor = System.Drawing.Color.Gray;
            this.newpassword_tb.Location = new System.Drawing.Point(157, 370);
            this.newpassword_tb.Name = "newpassword_tb";
            this.newpassword_tb.Size = new System.Drawing.Size(516, 38);
            this.newpassword_tb.TabIndex = 24;
            this.newpassword_tb.TabStop = false;
            this.newpassword_tb.Text = "Введите новый пароль";
            this.newpassword_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.newpassword_tb.Visible = false;
            this.newpassword_tb.Click += new System.EventHandler(this.newpassword_tb_Click);
            // 
            // changepassword_btn
            // 
            this.changepassword_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(210)))), ((int)(((byte)(219)))));
            this.changepassword_btn.Font = new System.Drawing.Font("XO Courser", 9F);
            this.changepassword_btn.Location = new System.Drawing.Point(593, 476);
            this.changepassword_btn.Name = "changepassword_btn";
            this.changepassword_btn.Size = new System.Drawing.Size(195, 47);
            this.changepassword_btn.TabIndex = 25;
            this.changepassword_btn.Text = "Изменить";
            this.changepassword_btn.UseVisualStyleBackColor = false;
            this.changepassword_btn.Visible = false;
            this.changepassword_btn.Click += new System.EventHandler(this.changepassword_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(344, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 146);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // PasswordRecovery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(90)))), ((int)(((byte)(86)))));
            this.ClientSize = new System.Drawing.Size(800, 535);
            this.Controls.Add(this.changepassword_btn);
            this.Controls.Add(this.newpassword_tb);
            this.Controls.Add(this.send_btn);
            this.Controls.Add(this.cod_tb);
            this.Controls.Add(this.information_lbl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.email_tb);
            this.Controls.Add(this.info_lbl);
            this.Controls.Add(this.info_lbl1);
            this.Controls.Add(this.go_btn);
            this.Controls.Add(this.forgotpassword_btn);
            this.Controls.Add(this.registration_btn);
            this.Name = "PasswordRecovery";
            this.Text = "PasswordRecovery";
            this.Load += new System.EventHandler(this.PasswordRecovery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button go_btn;
        private System.Windows.Forms.Label forgotpassword_btn;
        private System.Windows.Forms.Label registration_btn;
        private System.Windows.Forms.Label info_lbl1;
        private System.Windows.Forms.Label info_lbl;
        private System.Windows.Forms.TextBox email_tb;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label information_lbl;
        private System.Windows.Forms.TextBox cod_tb;
        private System.Windows.Forms.Button send_btn;
        private System.Windows.Forms.TextBox newpassword_tb;
        private System.Windows.Forms.Button changepassword_btn;
    }
}