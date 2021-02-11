using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nusantara.Util;

namespace Nusantara.Forms
{
    public partial class FormSchedule : Form
    {
        EditMode? mode = null;

        bool initialized = false;

        public FormSchedule()
        {
            InitializeComponent();

            ClassBox.DataSource = Program.Entities.Classes.ToList();
            ClassBox.DisplayMember = "ClassName";

            DayBox.DataSource = Enum.GetValues(typeof(DayOfWeek));
            DayBox.SelectedItem = DayOfWeek.Monday;

            SubjectBox.DisplayMember = "SubjectId";

            ShiftBox.DataSource = Program.Entities.Shifts.ToList();
            ShiftBox.DisplayMember = "ShiftId";

            ChangeMode(null);
        }

        private void Reset()
        {
            initialized = true;

            var clazz = ((Data.Class)ClassBox.SelectedItem);
            var day = Enum.GetName(typeof(DayOfWeek), (DayOfWeek)DayBox.SelectedItem);

            dataGridView1.DataSource = Program.Entities.Schedules
                .Where(s => s.Day == day && s.ClassName == clazz.ClassName)
                .ToList();

            SubjectBox.DataSource = Program.Entities.Subjects
                .Where(s => s.ForGrade == clazz.Grade)
                .ToList();
        }

        private void ChangeMode(EditMode? mode)
        {
            this.mode = mode;
            ErrorLabel.Text = "";

            SubjectBox.Enabled
                = ShiftBox.Enabled
                = TeacherBox.Enabled
                = SaveButton.Enabled
                = CancelButton.Enabled
                = mode != null;

            InsertButton.Enabled
                = UpdateButton.Enabled
                = DeleteButton.Enabled
                = mode == null;
        }

        private void FormSchedule_FormClosed(object sender, FormClosedEventArgs e)
        {
            NavAdmin.INSTANCE.Show();
        }

        private void ClassBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (initialized) Reset();
        }

        private void DayBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Reset();
        }

        private void SubjectBox_Format(object sender, ListControlConvertEventArgs e)
        {
            e.Value += " - " + ((Data.Subject)e.ListItem).Name;
        }

        private void TeacherBox_Format(object sender, ListControlConvertEventArgs e)
        {
            e.Value += " - " + ((Data.Teacher)e.ListItem).Name;
        }

        private void SubjectBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            TeacherBox.DataSource = Program.Entities.Teachers
                .Where(t => t.Expertises.Any(x => x.SubjectId == ((Data.Subject)SubjectBox.SelectedItem).SubjectId))
                .ToList();
            TeacherBox.DisplayMember = "TeacherId";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell == null) return;
            if (e.RowIndex == -1) return;
            if (mode != null) return;

            DataGridViewCellCollection cells = dataGridView1.Rows[e.RowIndex].Cells;

            var subject = Convert.ToString(cells[subjectIdDataGridViewTextBoxColumn.Index].Value);
            SubjectBox.SelectedItem = Program.Entities.Subjects
                .Where(s => s.SubjectId == subject)
                .FirstOrDefault();

            var shift = Convert.ToInt32(cells[shiftIdDataGridViewTextBoxColumn.Index].Value);
            ShiftBox.SelectedItem = Program.Entities.Shifts
                .Where(s => s.ShiftId == shift)
                .FirstOrDefault();

            var teacher = Convert.ToString(cells[teacherIdDataGridViewTextBoxColumn.Index].Value);
            TeacherBox.SelectedItem = Program.Entities.Teachers
                .Where(t => t.TeacherId == teacher)
                .FirstOrDefault();
        }

        private void ShiftBox_Format(object sender, ListControlConvertEventArgs e)
        {
            e.Value += " - " + ((Data.Shift)e.ListItem).Time;
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            ChangeMode(EditMode.INSERT);
            Reset();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null) ChangeMode(EditMode.UPDATE);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            ChangeMode(null);
            Reset();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Index == -1) return;

            DialogResult result = MessageBox.Show(
                "Delete Schedule?", "Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                var id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[detailIdDataGridViewTextBoxColumn.Index].Value);
                var schedule = Program.Entities.DetailSchedules
                    .Where(d => d.DetailId == id)
                    .FirstOrDefault();

                Program.Entities.DetailSchedules.Remove(schedule);
                Program.Entities.SaveChanges();

                Reset();
                ChangeMode(null);
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            var subject = (Data.Subject)SubjectBox.SelectedItem;
            var shift = (Data.Shift)ShiftBox.SelectedItem;
            var teacher = (Data.Teacher)TeacherBox.SelectedItem;

            var id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[detailIdDataGridViewTextBoxColumn.Index].Value);
            var schedule = mode == EditMode.INSERT ? new Data.DetailSchedule() : Program.Entities.DetailSchedules
                .Where(d => d.DetailId == id)
                .FirstOrDefault();

            schedule.Day = ((DayOfWeek)DayBox.SelectedItem).ToString();
            schedule.Subject = subject;
            schedule.Shift = shift;
            schedule.TeacherId = teacher.TeacherId;
            schedule.HeaderSchedule = Program.Entities.HeaderSchedules
                .Where(h => h.ClassName == ((Data.Class)ClassBox.SelectedItem).ClassName)
                .FirstOrDefault();

            if (mode == EditMode.INSERT)
            {
                Program.Entities.DetailSchedules.Add(schedule);
            }

            Program.Entities.SaveChanges();

            Reset();
            ChangeMode(null);
        }
    }
}
