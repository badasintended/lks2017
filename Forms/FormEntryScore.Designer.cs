namespace Nusantara.Forms
{
    partial class FormEntryScore
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
            this.label8 = new System.Windows.Forms.Label();
            this.StudentLabel = new System.Windows.Forms.Label();
            this.AssignmentBox = new System.Windows.Forms.TextBox();
            this.MidExamBox = new System.Windows.Forms.TextBox();
            this.FinalExamBox = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(403, 35);
            this.label8.TabIndex = 48;
            this.label8.Text = "Entry Score";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StudentLabel
            // 
            this.StudentLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StudentLabel.Location = new System.Drawing.Point(12, 58);
            this.StudentLabel.Name = "StudentLabel";
            this.StudentLabel.Size = new System.Drawing.Size(379, 27);
            this.StudentLabel.TabIndex = 49;
            this.StudentLabel.Text = "label1";
            this.StudentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AssignmentBox
            // 
            this.AssignmentBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AssignmentBox.Location = new System.Drawing.Point(194, 103);
            this.AssignmentBox.Name = "AssignmentBox";
            this.AssignmentBox.Size = new System.Drawing.Size(100, 22);
            this.AssignmentBox.TabIndex = 50;
            // 
            // MidExamBox
            // 
            this.MidExamBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MidExamBox.Location = new System.Drawing.Point(194, 131);
            this.MidExamBox.Name = "MidExamBox";
            this.MidExamBox.Size = new System.Drawing.Size(100, 22);
            this.MidExamBox.TabIndex = 51;
            // 
            // FinalExamBox
            // 
            this.FinalExamBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FinalExamBox.Location = new System.Drawing.Point(194, 159);
            this.FinalExamBox.Name = "FinalExamBox";
            this.FinalExamBox.Size = new System.Drawing.Size(100, 22);
            this.FinalExamBox.TabIndex = 52;
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SaveButton.Location = new System.Drawing.Point(159, 214);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 30);
            this.SaveButton.TabIndex = 53;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 54;
            this.label2.Text = "Assignment";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 55;
            this.label3.Text = "Mid Exam";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(98, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 56;
            this.label4.Text = "Final Exam";
            // 
            // FormEntryScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 275);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.FinalExamBox);
            this.Controls.Add(this.MidExamBox);
            this.Controls.Add(this.AssignmentBox);
            this.Controls.Add(this.StudentLabel);
            this.Controls.Add(this.label8);
            this.Name = "FormEntryScore";
            this.Text = "FormEntryScore";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label StudentLabel;
        private System.Windows.Forms.TextBox AssignmentBox;
        private System.Windows.Forms.TextBox MidExamBox;
        private System.Windows.Forms.TextBox FinalExamBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}