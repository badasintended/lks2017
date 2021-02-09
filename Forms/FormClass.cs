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
    public partial class FormClass : Form
    {
        public FormClass()
        {
            InitializeComponent();

            ClassBox.DataSource = Program.Entities.Classes.ToList();
            ClassBox.DisplayMember = "ClassName";

            Reset();
        }

        private void Reset()
        {
            var clazz = ((Data.Class)ClassBox.SelectedItem).ClassName;

            dataGridView1.DataSource = Program.Entities.Students
                .Where(s => !s.DetailClasses.Any(d => d.ClassName == clazz))
                .ToList();

            dataGridView2.DataSource = Program.Entities.ClassStudents
                .Where(it => it.ClassName == clazz)
                .ToList();
        }

        private void ClassBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Reset();
        }

        private void FormClass_FormClosed(object sender, FormClosedEventArgs e)
        {
            NavAdmin.INSTANCE.Show();
        }

        private void L2RButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count == 0) return;

            foreach (DataGridViewCell cell in dataGridView1.SelectedCells)
            {
                var row = cell.OwningRow;
                if (row.Index == -1) continue;

                var id = Convert.ToString(row.Cells[studentIdDataGridViewTextBoxColumn.Index].Value);

                var details = Program.Entities.DetailClasses
                    .Where(d => d.StudentId == id)
                    .ToList();

                foreach (Data.DetailClass d in details) Program.Entities.DetailClasses.Remove(d);

                var detail = new Data.DetailClass();
                detail.Class = (Data.Class)ClassBox.SelectedItem;
                detail.Student = Program.Entities.Students
                    .Where(s => s.StudentId == id)
                    .FirstOrDefault();

                Program.Entities.DetailClasses.Add(detail);
            }

            Program.Entities.SaveChanges();
            Reset();
        }

        private void R2LButton_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedCells.Count == 0) return;

            foreach (DataGridViewCell cell in dataGridView2.SelectedCells)
            {
                var row = cell.OwningRow;
                if (row.Index == -1) continue;

                var clazz = ((Data.Class)ClassBox.SelectedItem).ClassName;
                var id = Convert.ToString(row.Cells[studentIdDataGridViewTextBoxColumn.Index].Value);

                Data.DetailClass detail = Program.Entities.DetailClasses
                    .Where(d => d.ClassName == clazz && d.StudentId == id)
                    .FirstOrDefault();


                Program.Entities.DetailClasses.Remove(detail);
            }

            Program.Entities.SaveChanges();
            Reset();
        }
    }
}
