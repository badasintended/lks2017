using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nusantara.Forms
{
    public partial class FormViewScore : Form
    {
        public FormViewScore()
        {
            InitializeComponent();

            dataGridView1.DataSource = Program.Entities.StudentScores
                .Where(s => s.StudentId == Program.User.Student.StudentId)
                .ToList();

            ScoreLabel.Text = "";
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex == -1) return;

            if (e.ColumnIndex == finalColumn.Index)
            {
                var row = dataGridView1.Rows[e.RowIndex];
                var id = Convert.ToString(row.Cells[subjectIdDataGridViewTextBoxColumn.Index].Value);
                var subject = Program.Entities.Subjects
                    .Where(s => s.SubjectId == id)
                    .FirstOrDefault();

                var assignment = Convert.ToDouble(row.Cells[assignmentDataGridViewTextBoxColumn.Index].Value);
                var mid = Convert.ToDouble(row.Cells[midExamDataGridViewTextBoxColumn.Index].Value);
                var final = Convert.ToDouble(row.Cells[finalExamDataGridViewTextBoxColumn.Index].Value);
                e.Value = ((assignment * subject.Assignment) + (mid * subject.MidExam) + (final * subject.FinalExam)) / 100;
            }
        }

        private void FormViewScore_FormClosed(object sender, FormClosedEventArgs e)
        {
            NavStudent.GetInstance().Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell == null) return;
            if (e.RowIndex == -1) return;

            DataGridViewCellCollection cells = dataGridView1.Rows[e.RowIndex].Cells;

            var id = Convert.ToString(cells[subjectIdDataGridViewTextBoxColumn.Index].Value);
            var subject = Program.Entities.Subjects
                .Where(s => s.SubjectId == id)
                .FirstOrDefault();

            ScoreLabel.Text = "Assignment: " + subject.Assignment + "%, Mid Exam: " + subject.MidExam + "%, Final Exam: " + subject.FinalExam + "%";
        }
    }
}
