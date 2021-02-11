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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormViewScore_FormClosed(object sender, FormClosedEventArgs e)
        {
            NavStudent.GetInstance().Show();
        }
    }
}
