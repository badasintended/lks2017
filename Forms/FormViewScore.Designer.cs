namespace Nusantara.Forms
{
    partial class FormViewScore
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
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.subjectIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assignmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.midExamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finalExamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finalColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentScoreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Nusantara.Data.DataSet1();
            this.studentScoreTableAdapter = new Nusantara.Data.DataSet1TableAdapters.StudentScoreTableAdapter();
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
            this.label8.Size = new System.Drawing.Size(800, 35);
            this.label8.TabIndex = 48;
            this.label8.Text = "View Score";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Location = new System.Drawing.Point(5, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(783, 23);
            this.label3.TabIndex = 53;
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
            this.subjectIdDataGridViewTextBoxColumn,
            this.subjectNameDataGridViewTextBoxColumn,
            this.assignmentDataGridViewTextBoxColumn,
            this.midExamDataGridViewTextBoxColumn,
            this.finalExamDataGridViewTextBoxColumn,
            this.finalColumn});
            this.dataGridView1.DataSource = this.studentScoreBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 364);
            this.dataGridView1.TabIndex = 54;
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
            this.subjectNameDataGridViewTextBoxColumn.HeaderText = "SubjectName";
            this.subjectNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.subjectNameDataGridViewTextBoxColumn.Name = "subjectNameDataGridViewTextBoxColumn";
            this.subjectNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.subjectNameDataGridViewTextBoxColumn.Width = 125;
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
            // FormViewScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Name = "FormViewScore";
            this.Text = "FormViewScore";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentScoreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Data.DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource studentScoreBindingSource;
        private Data.DataSet1TableAdapters.StudentScoreTableAdapter studentScoreTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn assignmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn midExamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn finalExamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn finalColumn;
    }
}