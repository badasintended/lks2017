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
    public partial class FormViewScheduleTeacher : Form
    {
        public FormViewScheduleTeacher()
        {
            InitializeComponent();

            dataGridView1.DataSource = Program.Entities.Schedules
                .Where(s => s.TeacherId == Program.User.Teacher.TeacherId)
                .ToList();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell == null) return;
            if (e.RowIndex == -1) return;

            var clazz = dataGridView1
                .Rows[e.RowIndex]
                .Cells[classNameDataGridViewTextBoxColumn.Index]
                .Value;

            dataGridView2.DataSource = Program.Entities.ClassStudents
                .Where(s => s.ClassName == clazz)
                .ToList();
        }

        private void FormViewScheduleTeacher_FormClosed(object sender, FormClosedEventArgs e)
        {
            NavTeacher.GetInstance().Show();
        }
    }
}
