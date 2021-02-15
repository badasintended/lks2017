namespace Nusantara.Forms
{
    partial class FormInputScore
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
            this.SubjectBox = new System.Windows.Forms.ComboBox();
            this.ClassBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.studentScoreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Nusantara.Data.DataSet1();
            this.studentScoreTableAdapter = new Nusantara.Data.DataSet1TableAdapters.StudentScoreTableAdapter();
            this.EntryButton = new System.Windows.Forms.Button();
            this.scoreDetailIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assignmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.midExamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finalExamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finalColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentScoreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(822, 35);
            this.label8.TabIndex = 47;
            this.label8.Text = "Form Input Score";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SubjectBox
            // 
            this.SubjectBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SubjectBox.FormattingEnabled = true;
            this.SubjectBox.Location = new System.Drawing.Point(229, 61);
            this.SubjectBox.Name = "SubjectBox";
            this.SubjectBox.Size = new System.Drawing.Size(140, 24);
            this.SubjectBox.TabIndex = 48;
            this.SubjectBox.SelectedIndexChanged += new System.EventHandler(this.SubjectBox_SelectedIndexChanged);
            this.SubjectBox.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.SubjectBox_Format);
            // 
            // ClassBox
            // 
            this.ClassBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ClassBox.FormattingEnabled = true;
            this.ClassBox.Location = new System.Drawing.Point(504, 61);
            this.ClassBox.Name = "ClassBox";
            this.ClassBox.Size = new System.Drawing.Size(121, 24);
            this.ClassBox.TabIndex = 49;
            this.ClassBox.SelectedIndexChanged += new System.EventHandler(this.ClassBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 50;
            this.label1.Text = "Subject";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(456, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 51;
            this.label2.Text = "Class";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Location = new System.Drawing.Point(12, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(798, 23);
            this.label3.TabIndex = 52;
            this.label3.Text = "Assignment: 20%, Mid Exam: 30%, Final Exam: 50%";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.scoreDetailIdDataGridViewTextBoxColumn,
            this.studentIdDataGridViewTextBoxColumn,
            this.studentNameDataGridViewTextBoxColumn,
            this.assignmentDataGridViewTextBoxColumn,
            this.midExamDataGridViewTextBoxColumn,
            this.finalExamDataGridViewTextBoxColumn,
            this.finalColumn});
            this.dataGridView1.DataSource = this.studentScoreBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 133);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(798, 433);
            this.dataGridView1.TabIndex = 53;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // studentScoreBindingSource
            // 
            this.studentScoreBindingSource.DataMember = "StudentScore";
            this.studentScoreBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentScoreTableAdapter
            // 
            this.studentScoreTableAdapter.ClearBeforeFill = true;
            // 
            // EntryButton
            // 
            this.EntryButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.EntryButton.Location = new System.Drawing.Point(350, 572);
            this.EntryButton.Name = "EntryButton";
            this.EntryButton.Size = new System.Drawing.Size(98, 28);
            this.EntryButton.TabIndex = 54;
            this.EntryButton.Text = "Entry Score";
            this.EntryButton.UseVisualStyleBackColor = true;
            this.EntryButton.Click += new System.EventHandler(this.EntryButton_Click);
            // 
            // scoreDetailIdDataGridViewTextBoxColumn
            // 
            this.scoreDetailIdDataGridViewTextBoxColumn.DataPropertyName = "ScoreDetailId";
            this.scoreDetailIdDataGridViewTextBoxColumn.HeaderText = "ScoreDetailId";
            this.scoreDetailIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.scoreDetailIdDataGridViewTextBoxColumn.Name = "scoreDetailIdDataGridViewTextBoxColumn";
            this.scoreDetailIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.scoreDetailIdDataGridViewTextBoxColumn.Visible = false;
            this.scoreDetailIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // studentIdDataGridViewTextBoxColumn
            // 
            this.studentIdDataGridViewTextBoxColumn.DataPropertyName = "StudentId";
            this.studentIdDataGridViewTextBoxColumn.HeaderText = "StudentId";
            this.studentIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.studentIdDataGridViewTextBoxColumn.Name = "studentIdDataGridViewTextBoxColumn";
            this.studentIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.studentIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // studentNameDataGridViewTextBoxColumn
            // 
            this.studentNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.studentNameDataGridViewTextBoxColumn.DataPropertyName = "StudentName";
            this.studentNameDataGridViewTextBoxColumn.HeaderText = "StudentName";
            this.studentNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.studentNameDataGridViewTextBoxColumn.Name = "studentNameDataGridViewTextBoxColumn";
            this.studentNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.studentNameDataGridViewTextBoxColumn.Width = 24;
            // 
            // assignmentDataGridViewTextBoxColumn
            // 
            this.assignmentDataGridViewTextBoxColumn.DataPropertyName = "Assignment";
            this.assignmentDataGridViewTextBoxColumn.HeaderText = "Assignment";
            this.assignmentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.assignmentDataGridViewTextBoxColumn.Name = "assignmentDataGridViewTextBoxColumn";
            this.assignmentDataGridViewTextBoxColumn.ReadOnly = true;
            this.assignmentDataGridViewTextBoxColumn.Width = 125;
            // 
            // midExamDataGridViewTextBoxColumn
            // 
            this.midExamDataGridViewTextBoxColumn.DataPropertyName = "MidExam";
            this.midExamDataGridViewTextBoxColumn.HeaderText = "MidExam";
            this.midExamDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.midExamDataGridViewTextBoxColumn.Name = "midExamDataGridViewTextBoxColumn";
            this.midExamDataGridViewTextBoxColumn.ReadOnly = true;
            this.midExamDataGridViewTextBoxColumn.Width = 125;
            // 
            // finalExamDataGridViewTextBoxColumn
            // 
            this.finalExamDataGridViewTextBoxColumn.DataPropertyName = "FinalExam";
            this.finalExamDataGridViewTextBoxColumn.HeaderText = "FinalExam";
            this.finalExamDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.finalExamDataGridViewTextBoxColumn.Name = "finalExamDataGridViewTextBoxColumn";
            this.finalExamDataGridViewTextBoxColumn.ReadOnly = true;
            this.finalExamDataGridViewTextBoxColumn.Width = 125;
            // 
            // finalColumn
            // 
            this.finalColumn.HeaderText = "Final";
            this.finalColumn.MinimumWidth = 6;
            this.finalColumn.Name = "finalColumn";
            this.finalColumn.ReadOnly = true;
            this.finalColumn.Width = 125;
            // 
            // FormInputScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 612);
            this.Controls.Add(this.EntryButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ClassBox);
            this.Controls.Add(this.SubjectBox);
            this.Controls.Add(this.label8);
            this.Name = "FormInputScore";
            this.Text = "FormInputScore";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormInputScore_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentScoreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox SubjectBox;
        private System.Windows.Forms.ComboBox ClassBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Data.DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource studentScoreBindingSource;
        private Data.DataSet1TableAdapters.StudentScoreTableAdapter studentScoreTableAdapter;
        private System.Windows.Forms.Button EntryButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn scoreDetailIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn assignmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn midExamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn finalExamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn finalColumn;
    }
}