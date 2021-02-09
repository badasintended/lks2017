namespace Nusantara.Forms
{
    partial class FormChangePassword
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
            this.OldPassBox = new System.Windows.Forms.TextBox();
            this.NewPassBox = new System.Windows.Forms.TextBox();
            this.ConfirmPassBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(370, 35);
            this.label8.TabIndex = 43;
            this.label8.Text = "Form Change Password";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OldPassBox
            // 
            this.OldPassBox.Location = new System.Drawing.Point(174, 58);
            this.OldPassBox.Name = "OldPassBox";
            this.OldPassBox.Size = new System.Drawing.Size(158, 22);
            this.OldPassBox.TabIndex = 44;
            // 
            // NewPassBox
            // 
            this.NewPassBox.Location = new System.Drawing.Point(174, 86);
            this.NewPassBox.Name = "NewPassBox";
            this.NewPassBox.Size = new System.Drawing.Size(158, 22);
            this.NewPassBox.TabIndex = 45;
            // 
            // ConfirmPassBox
            // 
            this.ConfirmPassBox.Location = new System.Drawing.Point(174, 114);
            this.ConfirmPassBox.Name = "ConfirmPassBox";
            this.ConfirmPassBox.Size = new System.Drawing.Size(158, 22);
            this.ConfirmPassBox.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 47;
            this.label1.Text = "Old Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 48;
            this.label2.Text = "New Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 17);
            this.label3.TabIndex = 49;
            this.label3.Text = "Confirm Password";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(142, 159);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 28);
            this.SaveButton.TabIndex = 50;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            // 
            // FormChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 218);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ConfirmPassBox);
            this.Controls.Add(this.NewPassBox);
            this.Controls.Add(this.OldPassBox);
            this.Controls.Add(this.label8);
            this.Name = "FormChangePassword";
            this.Text = "FormChangePassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox OldPassBox;
        private System.Windows.Forms.TextBox NewPassBox;
        private System.Windows.Forms.TextBox ConfirmPassBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SaveButton;
    }
}