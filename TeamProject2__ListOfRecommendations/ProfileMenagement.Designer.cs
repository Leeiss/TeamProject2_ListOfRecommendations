﻿namespace TeamProject2__ListOfRecommendations
{
    partial class ProfileMenagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileMenagement));
            this.info_lbl = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.password_lbl = new System.Windows.Forms.Label();
            this.login_lbl = new System.Windows.Forms.Label();
            this.expand_pb = new System.Windows.Forms.PictureBox();
            this.collapse_pb = new System.Windows.Forms.PictureBox();
            this.frane_expand = new System.Windows.Forms.PictureBox();
            this.frame_collapse = new System.Windows.Forms.PictureBox();
            this.command2 = new System.Windows.Forms.PictureBox();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.expand_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collapse_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frane_expand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frame_collapse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.command2)).BeginInit();
            this.SuspendLayout();
            // 
            // info_lbl
            // 
            this.info_lbl.AutoSize = true;
            this.info_lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.info_lbl.Font = new System.Drawing.Font("Stencil", 15F, System.Drawing.FontStyle.Bold);
            this.info_lbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.info_lbl.Location = new System.Drawing.Point(47, 84);
            this.info_lbl.Name = "info_lbl";
            this.info_lbl.Size = new System.Drawing.Size(541, 47);
            this.info_lbl.TabIndex = 17;
            this.info_lbl.Text = "УПРАВЛЕНИЕ ПРОФИЛЕМ";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.expand_pb);
            this.panel4.Controls.Add(this.collapse_pb);
            this.panel4.Controls.Add(this.frane_expand);
            this.panel4.Controls.Add(this.frame_collapse);
            this.panel4.Controls.Add(this.info_lbl);
            this.panel4.Location = new System.Drawing.Point(-36, 1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(715, 152);
            this.panel4.TabIndex = 2;
            // 
            // password_lbl
            // 
            this.password_lbl.AutoSize = true;
            this.password_lbl.Font = new System.Drawing.Font("XO Courser", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password_lbl.ForeColor = System.Drawing.Color.Black;
            this.password_lbl.Location = new System.Drawing.Point(14, 267);
            this.password_lbl.Name = "password_lbl";
            this.password_lbl.Size = new System.Drawing.Size(592, 32);
            this.password_lbl.TabIndex = 1;
            this.password_lbl.Text = "Изменить пароль                   ";
            this.password_lbl.Click += new System.EventHandler(this.password_lbl_Click);
            this.password_lbl.MouseEnter += new System.EventHandler(this.password_lbl_MouseEnter);
            this.password_lbl.MouseLeave += new System.EventHandler(this.password_lbl_MouseLeave);
            // 
            // login_lbl
            // 
            this.login_lbl.AutoSize = true;
            this.login_lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(90)))), ((int)(((byte)(86)))));
            this.login_lbl.Font = new System.Drawing.Font("Stencil", 13F, System.Drawing.FontStyle.Bold);
            this.login_lbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.login_lbl.Location = new System.Drawing.Point(18, 156);
            this.login_lbl.Name = "login_lbl";
            this.login_lbl.Size = new System.Drawing.Size(122, 42);
            this.login_lbl.TabIndex = 23;
            this.login_lbl.Text = "Логин";
            // 
            // expand_pb
            // 
            this.expand_pb.Image = ((System.Drawing.Image)(resources.GetObject("expand_pb.Image")));
            this.expand_pb.Location = new System.Drawing.Point(1694, 15);
            this.expand_pb.Name = "expand_pb";
            this.expand_pb.Size = new System.Drawing.Size(48, 48);
            this.expand_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.expand_pb.TabIndex = 2;
            this.expand_pb.TabStop = false;
            // 
            // collapse_pb
            // 
            this.collapse_pb.Image = ((System.Drawing.Image)(resources.GetObject("collapse_pb.Image")));
            this.collapse_pb.Location = new System.Drawing.Point(1600, 9);
            this.collapse_pb.Name = "collapse_pb";
            this.collapse_pb.Size = new System.Drawing.Size(60, 60);
            this.collapse_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.collapse_pb.TabIndex = 3;
            this.collapse_pb.TabStop = false;
            // 
            // frane_expand
            // 
            this.frane_expand.Image = ((System.Drawing.Image)(resources.GetObject("frane_expand.Image")));
            this.frane_expand.Location = new System.Drawing.Point(1685, 3);
            this.frane_expand.Name = "frane_expand";
            this.frane_expand.Size = new System.Drawing.Size(67, 73);
            this.frane_expand.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.frane_expand.TabIndex = 22;
            this.frane_expand.TabStop = false;
            this.frane_expand.Visible = false;
            // 
            // frame_collapse
            // 
            this.frame_collapse.Image = ((System.Drawing.Image)(resources.GetObject("frame_collapse.Image")));
            this.frame_collapse.Location = new System.Drawing.Point(1598, 4);
            this.frame_collapse.Name = "frame_collapse";
            this.frame_collapse.Size = new System.Drawing.Size(67, 73);
            this.frame_collapse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.frame_collapse.TabIndex = 21;
            this.frame_collapse.TabStop = false;
            this.frame_collapse.Visible = false;
            // 
            // command2
            // 
            this.command2.Image = ((System.Drawing.Image)(resources.GetObject("command2.Image")));
            this.command2.Location = new System.Drawing.Point(-1, 247);
            this.command2.Name = "command2";
            this.command2.Size = new System.Drawing.Size(667, 70);
            this.command2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.command2.TabIndex = 4;
            this.command2.TabStop = false;
            this.command2.Visible = false;
            this.command2.Click += new System.EventHandler(this.command2_Click);
            // 
            // ProfileMenagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(90)))), ((int)(((byte)(86)))));
            this.ClientSize = new System.Drawing.Size(660, 587);
            this.Controls.Add(this.login_lbl);
            this.Controls.Add(this.password_lbl);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.command2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProfileMenagement";
            this.Load += new System.EventHandler(this.ProfileMenagement_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.expand_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collapse_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frane_expand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frame_collapse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.command2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label info_lbl;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox expand_pb;
        private System.Windows.Forms.PictureBox collapse_pb;
        private System.Windows.Forms.PictureBox frane_expand;
        private System.Windows.Forms.PictureBox frame_collapse;
        private System.Windows.Forms.Label password_lbl;
        private System.Windows.Forms.PictureBox command2;
        private System.Windows.Forms.Label login_lbl;
    }
}