namespace Nusantara.Forms
{
    partial class NavTeacher
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
            this.EditProfileButton = new System.Windows.Forms.Button();
            this.ScheduleButton = new System.Windows.Forms.Button();
            this.InputScoreButton = new System.Windows.Forms.Button();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EditProfileButton
            // 
            this.EditProfileButton.Location = new System.Drawing.Point(46, 72);
            this.EditProfileButton.Name = "EditProfileButton";
            this.EditProfileButton.Size = new System.Drawing.Size(176, 41);
            this.EditProfileButton.TabIndex = 0;
            this.EditProfileButton.Text = "Edit Profile";
            this.EditProfileButton.UseVisualStyleBackColor = true;
            this.EditProfileButton.Click += new System.EventHandler(this.EditProfileButton_Click);
            // 
            // ScheduleButton
            // 
            this.ScheduleButton.Location = new System.Drawing.Point(46, 119);
            this.ScheduleButton.Name = "ScheduleButton";
            this.ScheduleButton.Size = new System.Drawing.Size(176, 41);
            this.ScheduleButton.TabIndex = 1;
            this.ScheduleButton.Text = "Teaching Schedule";
            this.ScheduleButton.UseVisualStyleBackColor = true;
            this.ScheduleButton.Click += new System.EventHandler(this.ScheduleButton_Click);
            // 
            // InputScoreButton
            // 
            this.InputScoreButton.Location = new System.Drawing.Point(46, 166);
            this.InputScoreButton.Name = "InputScoreButton";
            this.InputScoreButton.Size = new System.Drawing.Size(176, 41);
            this.InputScoreButton.TabIndex = 2;
            this.InputScoreButton.Text = "Input Score";
            this.InputScoreButton.UseVisualStyleBackColor = true;
            this.InputScoreButton.Click += new System.EventHandler(this.InputScoreButton_Click);
            // 
            // LogoutButton
            // 
            this.LogoutButton.Location = new System.Drawing.Point(46, 213);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(176, 41);
            this.LogoutButton.TabIndex = 3;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // TitleLabel
            // 
            this.TitleLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(0, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(272, 60);
            this.TitleLabel.TabIndex = 4;
            this.TitleLabel.Text = "Welcome, NAME";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // NavTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 277);
            this.ControlBox = false;
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.InputScoreButton);
            this.Controls.Add(this.ScheduleButton);
            this.Controls.Add(this.EditProfileButton);
            this.Name = "NavTeacher";
            this.Text = "NavTeacher";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NavTeacher_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button EditProfileButton;
        private System.Windows.Forms.Button ScheduleButton;
        private System.Windows.Forms.Button InputScoreButton;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.Label TitleLabel;
    }
}