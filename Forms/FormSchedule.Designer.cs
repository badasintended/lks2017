namespace Nusantara.Forms
{
    partial class FormSchedule
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
            this.components = new System.ComponentModel.Container();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ClassBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DayBox = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.subjectIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shiftIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scheduleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Nusantara.Data.DataSet1();
            this.label3 = new System.Windows.Forms.Label();
            this.SubjectBox = new System.Windows.Forms.ComboBox();
            this.ViewSubjectNeededButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ShiftBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TeacherBox = new System.Windows.Forms.ComboBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.InsertButton = new System.Windows.Forms.Button();
            this.scheduleTableAdapter = new Nusantara.Data.DataSet1TableAdapters.ScheduleTableAdapter();
            this.ErrorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(800, 35);
            this.label8.TabIndex = 45;
            this.label8.Text = "Manage Schedule Form";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 46;
            this.label1.Text = "Class ID";
            // 
            // ClassBox
            // 
            this.ClassBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ClassBox.FormattingEnabled = true;
            this.ClassBox.Location = new System.Drawing.Point(146, 57);
            this.ClassBox.Name = "ClassBox";
            this.ClassBox.Size = new System.Drawing.Size(121, 24);
            this.ClassBox.TabIndex = 47;
            this.ClassBox.SelectedIndexChanged += new System.EventHandler(this.ClassBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(493, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 48;
            this.label2.Text = "Day";
            // 
            // DayBox
            // 
            this.DayBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DayBox.FormattingEnabled = true;
            this.DayBox.Location = new System.Drawing.Point(552, 57);
            this.DayBox.Name = "DayBox";
            this.DayBox.Size = new System.Drawing.Size(121, 24);
            this.DayBox.TabIndex = 49;
            this.DayBox.SelectedIndexChanged += new System.EventHandler(this.DayBox_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.subjectIdDataGridViewTextBoxColumn,
            this.subjectNameDataGridViewTextBoxColumn,
            this.teacherIdDataGridViewTextBoxColumn,
            this.teacherNameDataGridViewTextBoxColumn,
            this.shiftIdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.scheduleBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 97);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 345);
            this.dataGridView1.TabIndex = 50;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // subjectIdDataGridViewTextBoxColumn
            // 
            this.subjectIdDataGridViewTextBoxColumn.DataPropertyName = "SubjectId";
            this.subjectIdDataGridViewTextBoxColumn.HeaderText = "SubjectId";
            this.subjectIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.subjectIdDataGridViewTextBoxColumn.Name = "subjectIdDataGridViewTextBoxColumn";
            this.subjectIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.subjectIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // subjectNameDataGridViewTextBoxColumn
            // 
            this.subjectNameDataGridViewTextBoxColumn.DataPropertyName = "SubjectName";
            this.subjectNameDataGridViewTextBoxColumn.HeaderText = "Subject";
            this.subjectNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.subjectNameDataGridViewTextBoxColumn.Name = "subjectNameDataGridViewTextBoxColumn";
            this.subjectNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.subjectNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // teacherIdDataGridViewTextBoxColumn
            // 
            this.teacherIdDataGridViewTextBoxColumn.DataPropertyName = "TeacherId";
            this.teacherIdDataGridViewTextBoxColumn.HeaderText = "TeacherId";
            this.teacherIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.teacherIdDataGridViewTextBoxColumn.Name = "teacherIdDataGridViewTextBoxColumn";
            this.teacherIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.teacherIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // teacherNameDataGridViewTextBoxColumn
            // 
            this.teacherNameDataGridViewTextBoxColumn.DataPropertyName = "TeacherName";
            this.teacherNameDataGridViewTextBoxColumn.HeaderText = "Teacher Name";
            this.teacherNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.teacherNameDataGridViewTextBoxColumn.Name = "teacherNameDataGridViewTextBoxColumn";
            this.teacherNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.teacherNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // shiftIdDataGridViewTextBoxColumn
            // 
            this.shiftIdDataGridViewTextBoxColumn.DataPropertyName = "ShiftId";
            this.shiftIdDataGridViewTextBoxColumn.HeaderText = "ShiftId";
            this.shiftIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.shiftIdDataGridViewTextBoxColumn.Name = "shiftIdDataGridViewTextBoxColumn";
            this.shiftIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.shiftIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // scheduleBindingSource
            // 
            this.scheduleBindingSource.DataMember = "Schedule";
            this.scheduleBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(257, 453);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 51;
            this.label3.Text = "Subject";
            // 
            // SubjectBox
            // 
            this.SubjectBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.SubjectBox.FormattingEnabled = true;
            this.SubjectBox.Location = new System.Drawing.Point(324, 450);
            this.SubjectBox.Name = "SubjectBox";
            this.SubjectBox.Size = new System.Drawing.Size(220, 24);
            this.SubjectBox.TabIndex = 52;
            this.SubjectBox.SelectedIndexChanged += new System.EventHandler(this.SubjectBox_SelectedIndexChanged);
            this.SubjectBox.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.SubjectBox_Format);
            // 
            // ViewSubjectNeededButton
            // 
            this.ViewSubjectNeededButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ViewSubjectNeededButton.Location = new System.Drawing.Point(552, 448);
            this.ViewSubjectNeededButton.Name = "ViewSubjectNeededButton";
            this.ViewSubjectNeededButton.Size = new System.Drawing.Size(160, 26);
            this.ViewSubjectNeededButton.TabIndex = 53;
            this.ViewSubjectNeededButton.Text = "View Subject Needed";
            this.ViewSubjectNeededButton.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(257, 483);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 17);
            this.label4.TabIndex = 54;
            this.label4.Text = "Shift";
            // 
            // ShiftBox
            // 
            this.ShiftBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ShiftBox.FormattingEnabled = true;
            this.ShiftBox.Location = new System.Drawing.Point(324, 480);
            this.ShiftBox.Name = "ShiftBox";
            this.ShiftBox.Size = new System.Drawing.Size(220, 24);
            this.ShiftBox.TabIndex = 55;
            this.ShiftBox.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.ShiftBox_Format);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(257, 513);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 56;
            this.label5.Text = "Teacher";
            // 
            // TeacherBox
            // 
            this.TeacherBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.TeacherBox.FormattingEnabled = true;
            this.TeacherBox.Location = new System.Drawing.Point(324, 510);
            this.TeacherBox.Name = "TeacherBox";
            this.TeacherBox.Size = new System.Drawing.Size(220, 24);
            this.TeacherBox.TabIndex = 57;
            this.TeacherBox.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.TeacherBox_Format);
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.CancelButton.Location = new System.Drawing.Point(411, 606);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 35);
            this.CancelButton.TabIndex = 62;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.SaveButton.Location = new System.Drawing.Point(319, 606);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 35);
            this.SaveButton.TabIndex = 61;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.DeleteButton.Location = new System.Drawing.Point(460, 565);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 35);
            this.DeleteButton.TabIndex = 60;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.UpdateButton.Location = new System.Drawing.Point(366, 565);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(75, 35);
            this.UpdateButton.TabIndex = 59;
            this.UpdateButton.Text = "Upate";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // InsertButton
            // 
            this.InsertButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.InsertButton.Location = new System.Drawing.Point(271, 565);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(75, 35);
            this.InsertButton.TabIndex = 58;
            this.InsertButton.Text = "Insert";
            this.InsertButton.UseVisualStyleBackColor = true;
            this.InsertButton.Click += new System.EventHandler(this.InsertButton_Click);
            // 
            // scheduleTableAdapter
            // 
            this.scheduleTableAdapter.ClearBeforeFill = true;
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel.Location = new System.Drawing.Point(12, 537);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(776, 23);
            this.ErrorLabel.TabIndex = 63;
            this.ErrorLabel.Text = "label9";
            this.ErrorLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FormSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 657);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.InsertButton);
            this.Controls.Add(this.TeacherBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ShiftBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ViewSubjectNeededButton);
            this.Controls.Add(this.SubjectBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.DayBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ClassBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Name = "FormSchedule";
            this.Text = "FormSchedule";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormSchedule_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ClassBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox DayBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox SubjectBox;
        private System.Windows.Forms.Button ViewSubjectNeededButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ShiftBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox TeacherBox;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button InsertButton;
        private Data.DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource scheduleBindingSource;
        private Data.DataSet1TableAdapters.ScheduleTableAdapter scheduleTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacherIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacherNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shiftIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label ErrorLabel;
    }
}