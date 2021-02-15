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
    public partial class FormInputScore : Form
    {
        public FormInputScore()
        {
            InitializeComponent();
            Reset();
        }

        private void RefreshView()
        {
            dataGridView1.DataSource = Program.Entities.StudentScores
                .Where(s => s.SubjectId == ((Data.Subject)SubjectBox.SelectedItem).SubjectId)
                .ToList();
        }

        private void Reset()
        {
            ClassBox.DataSource = Program.Entities.Classes
                .Where(c => c.HeaderSchedules.Any(h => h.DetailSchedules.Any(d => d.TeacherId == Program.User.Teacher.TeacherId)))
                .ToList();
            ClassBox.DisplayMember = "ClassName";
        }

        private void ClassBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SubjectBox.DataSource = Program.Entities.Subjects
                .Where(s => s.ForGrade == ((Data.Class)ClassBox.SelectedItem).Grade)
                .Where(s => s.DetailSchedules.Any(d => d.TeacherId == Program.User.Teacher.TeacherId))
                .ToList();
            SubjectBox.DisplayMember = "SubjectId";
        }

        private void SubjectBox_Format(object sender, ListControlConvertEventArgs e)
        {
            e.Value += " " + ((Data.Subject)e.ListItem).Name;
        }

        private void SubjectBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshView();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void EntryButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;
            if (dataGridView1.CurrentRow.Index == -1) return;

            var cells = dataGridView1.CurrentRow.Cells;

            var id = Convert.ToInt32(cells[scoreDetailIdDataGridViewTextBoxColumn.Index].Value);
            new FormEntryScore(() => RefreshView(), Program.Entities.DetailScores.Where(s => s.ScoreDetailId == id).FirstOrDefault()).ShowDialog();
        }

        private void FormInputScore_FormClosed(object sender, FormClosedEventArgs e)
        {
            NavTeacher.GetInstance().Show();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex == -1) return;

            if (e.ColumnIndex == finalColumn.Index)
            {
                var row = dataGridView1.Rows[e.RowIndex];
                var subject = ((Data.Subject)SubjectBox.SelectedItem);

                var assignment = Convert.ToDouble(row.Cells[assignmentDataGridViewTextBoxColumn.Index].Value);
                var mid = Convert.ToDouble(row.Cells[midExamDataGridViewTextBoxColumn.Index].Value);
                var final = Convert.ToDouble(row.Cells[finalExamDataGridViewTextBoxColumn.Index].Value);
                e.Value = ((assignment * subject.Assignment) + (mid * subject.MidExam) + (final * subject.FinalExam)) / 100;
            }
        }
    }
}
