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
    public partial class FormViewScheduleStudent : Form
    {
        public FormViewScheduleStudent()
        {
            InitializeComponent();

            DayBox.DataSource = Enum.GetValues(typeof(DayOfWeek));
            DayBox.SelectedItem = DayOfWeek.Monday;
        }

        private void DayBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var day = Enum.GetName(typeof(DayOfWeek), (DayOfWeek)DayBox.SelectedItem);
            var clazz = Program.User.Student.DetailClasses
                .FirstOrDefault();

            if (clazz == null) return;

            dataGridView1.DataSource = Program.Entities.Schedules
                .Where(s => s.Day == day && s.ClassName == clazz.ClassName)
                .ToList();
        }

        private void FormViewScheduleStudent_FormClosed(object sender, FormClosedEventArgs e)
        {
            NavStudent.GetInstance().Show();
        }
    }
}
