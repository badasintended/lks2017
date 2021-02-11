namespace Nusantara.Forms
{
    partial class NavAdmin
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
            this.ManageStudentButton = new System.Windows.Forms.Button();
            this.ManageTeacherButton = new System.Windows.Forms.Button();
            this.ManageClassButton = new System.Windows.Forms.Button();
            this.ManageScheduleButton = new System.Windows.Forms.Button();
            this.FinalizeScheduleButton = new System.Windows.Forms.Button();
            this.ViewReportScoreButton = new System.Windows.Forms.Button();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(12, 21);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(163, 25);
            this.TitleLabel.TabIndex = 9;
            this.TitleLabel.Text = "Welcome, NAME";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // ManageStudentButton
            // 
            this.ManageStudentButton.Location = new System.Drawing.Point(17, 63);
            this.ManageStudentButton.Name = "ManageStudentButton";
            this.ManageStudentButton.Size = new System.Drawing.Size(176, 41);
            this.ManageStudentButton.TabIndex = 10;
            this.ManageStudentButton.Text = "Manage Student";
            this.ManageStudentButton.UseVisualStyleBackColor = true;
            this.ManageStudentButton.Click += new System.EventHandler(this.ManageStudentButton_Click);
            // 
            // ManageTeacherButton
            // 
            this.ManageTeacherButton.Location = new System.Drawing.Point(17, 110);
            this.ManageTeacherButton.Name = "ManageTeacherButton";
            this.ManageTeacherButton.Size = new System.Drawing.Size(176, 41);
            this.ManageTeacherButton.TabIndex = 11;
            this.ManageTeacherButton.Text = "Manage Teacher";
            this.ManageTeacherButton.UseVisualStyleBackColor = true;
            this.ManageTeacherButton.Click += new System.EventHandler(this.ManageTeacherButton_Click);
            // 
            // ManageClassButton
            // 
            this.ManageClassButton.Location = new System.Drawing.Point(17, 157);
            this.ManageClassButton.Name = "ManageClassButton";
            this.ManageClassButton.Size = new System.Drawing.Size(176, 41);
            this.ManageClassButton.TabIndex = 12;
            this.ManageClassButton.Text = "Manage Class";
            this.ManageClassButton.UseVisualStyleBackColor = true;
            this.ManageClassButton.Click += new System.EventHandler(this.ManageClassButton_Click);
            // 
            // ManageScheduleButton
            // 
            this.ManageScheduleButton.Location = new System.Drawing.Point(225, 63);
            this.ManageScheduleButton.Name = "ManageScheduleButton";
            this.ManageScheduleButton.Size = new System.Drawing.Size(176, 41);
            this.ManageScheduleButton.TabIndex = 13;
            this.ManageScheduleButton.Text = "Manage Schedule";
            this.ManageScheduleButton.UseVisualStyleBackColor = true;
            this.ManageScheduleButton.Click += new System.EventHandler(this.ManageScheduleButton_Click);
            // 
            // FinalizeScheduleButton
            // 
            this.FinalizeScheduleButton.Location = new System.Drawing.Point(225, 110);
            this.FinalizeScheduleButton.Name = "FinalizeScheduleButton";
            this.FinalizeScheduleButton.Size = new System.Drawing.Size(176, 41);
            this.FinalizeScheduleButton.TabIndex = 14;
            this.FinalizeScheduleButton.Text = "Finalize Schedule";
            this.FinalizeScheduleButton.UseVisualStyleBackColor = true;
            this.FinalizeScheduleButton.Click += new System.EventHandler(this.FinalizeScheduleButton_Click);
            // 
            // ViewReportScoreButton
            // 
            this.ViewReportScoreButton.Location = new System.Drawing.Point(225, 157);
            this.ViewReportScoreButton.Name = "ViewReportScoreButton";
            this.ViewReportScoreButton.Size = new System.Drawing.Size(176, 41);
            this.ViewReportScoreButton.TabIndex = 15;
            this.ViewReportScoreButton.Text = "View Report Score";
            this.ViewReportScoreButton.UseVisualStyleBackColor = true;
            this.ViewReportScoreButton.Click += new System.EventHandler(this.ViewReportScoreButton_Click);
            // 
            // LogoutButton
            // 
            this.LogoutButton.Location = new System.Drawing.Point(312, 21);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(89, 31);
            this.LogoutButton.TabIndex = 16;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // NavAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 215);
            this.ControlBox = false;
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.ViewReportScoreButton);
            this.Controls.Add(this.FinalizeScheduleButton);
            this.Controls.Add(this.ManageScheduleButton);
            this.Controls.Add(this.ManageClassButton);
            this.Controls.Add(this.ManageTeacherButton);
            this.Controls.Add(this.ManageStudentButton);
            this.Controls.Add(this.TitleLabel);
            this.Name = "NavAdmin";
            this.Text = "NavAdmin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NavAdmin_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Button ManageStudentButton;
        private System.Windows.Forms.Button ManageTeacherButton;
        private System.Windows.Forms.Button ManageClassButton;
        private System.Windows.Forms.Button ManageScheduleButton;
        private System.Windows.Forms.Button FinalizeScheduleButton;
        private System.Windows.Forms.Button ViewReportScoreButton;
        private System.Windows.Forms.Button LogoutButton;
    }
}