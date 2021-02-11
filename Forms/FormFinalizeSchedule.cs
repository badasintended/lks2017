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
    public partial class FormFinalizeSchedule : Form
    {
        public FormFinalizeSchedule()
        {
            InitializeComponent();

            ClassBox.DataSource = Program.Entities.Classes.ToList();
            ClassBox.DisplayMember = "ClassName";
        }

        private void FinalizeButton_Click(object sender, EventArgs e)
        {
            var clazz = ((Data.Class)ClassBox.SelectedItem).ClassName;

            Program.Entities.HeaderSchedules
                .Where(s => s.ClassName == clazz)
                .FirstOrDefault()
                .Finalize = 1;

            Program.Entities.SaveChanges();
        }

        private void ClassBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var clazz = ((Data.Class)ClassBox.SelectedItem).ClassName;

            dataGridView1.DataSource = Program.Entities.Schedules
                .Where(s => s.ClassName == clazz)
                .ToList();
        }

        private void FormFinalizeSchedule_FormClosed(object sender, FormClosedEventArgs e)
        {
            NavAdmin.INSTANCE.Show();
        }
    }
}
