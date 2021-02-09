namespace Nusantara.Forms
{
    partial class NavStudent
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
            this.TitleLabel = new System.Windows.Forms.Label();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.ViewScoreButton = new System.Windows.Forms.Button();
            this.ScheduleButton = new System.Windows.Forms.Button();
            this.EditProfileButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(0, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(269, 60);
            this.TitleLabel.TabIndex = 9;
            this.TitleLabel.Text = "Welcome, NAME";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // LogoutButton
            // 
            this.LogoutButton.Location = new System.Drawing.Point(48, 215);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(176, 41);
            this.LogoutButton.TabIndex = 8;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // ViewScoreButton
            // 
            this.ViewScoreButton.Location = new System.Drawing.Point(48, 168);
            this.ViewScoreButton.Name = "ViewScoreButton";
            this.ViewScoreButton.Size = new System.Drawing.Size(176, 41);
            this.ViewScoreButton.TabIndex = 7;
            this.ViewScoreButton.Text = "View Score";
            this.ViewScoreButton.UseVisualStyleBackColor = true;
            // 
            // ScheduleButton
            // 
            this.ScheduleButton.Location = new System.Drawing.Point(48, 121);
            this.ScheduleButton.Name = "ScheduleButton";
            this.ScheduleButton.Size = new System.Drawing.Size(176, 41);
            this.ScheduleButton.TabIndex = 6;
            this.ScheduleButton.Text = "Class Schedule";
            this.ScheduleButton.UseVisualStyleBackColor = true;
            // 
            // EditProfileButton
            // 
            this.EditProfileButton.Location = new System.Drawing.Point(48, 74);
            this.EditProfileButton.Name = "EditProfileButton";
            this.EditProfileButton.Size = new System.Drawing.Size(176, 41);
            this.EditProfileButton.TabIndex = 5;
            this.EditProfileButton.Text = "Edit Profile";
            this.EditProfileButton.UseVisualStyleBackColor = true;
            // 
            // NavStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 280);
            this.ControlBox = false;
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.ViewScoreButton);
            this.Controls.Add(this.ScheduleButton);
            this.Controls.Add(this.EditProfileButton);
            this.Name = "NavStudent";
            this.Text = "NavStudent";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NavStudent_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.Button ViewScoreButton;
        private System.Windows.Forms.Button ScheduleButton;
        private System.Windows.Forms.Button EditProfileButton;
    }
}