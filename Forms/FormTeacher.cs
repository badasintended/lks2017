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
    public partial class FormTeacher : Form
    {
        EditMode? mode = null;

        public FormTeacher()
        {
            InitializeComponent();

            Reset();
            ChangeMode(null);
        }

        private void ChangeMode(EditMode? mode)
        {
            this.mode = mode;
            ErrorLabel.Text = "";

            NameBox.Enabled =
                AddressBox.Enabled =
                MaleButton.Enabled =
                FemaleButton.Enabled =
                DobBox.Enabled =
                PhoneBox.Enabled =
                SaveButton.Enabled =
                CancelButton.Enabled =
                mode != null;

            IdBox.Enabled = mode == EditMode.INSERT;

            InsertButton.Enabled =
                UpdateButton.Enabled =
                DeleteButton.Enabled =
                mode == null;
        }

        private void Reset()
        {
            string text = SearchBox.Text.Trim();

            View.DataSource = Program.Entities.Teachers
               .Where(s => text.Length == 0 || s.Name.Contains(text))
               .ToList();

            IdBox.Clear();
            NameBox.Clear();
            AddressBox.Clear();
            MaleButton.Checked = FemaleButton.Checked = false;
            DobBox.Value = DateTime.Today;
            PhoneBox.Clear();
        }

        private void View_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (View.CurrentCell == null) return;
            if (e.RowIndex == -1) return;
            if (mode != null) return;

            DataGridViewCellCollection cells = View.Rows[e.RowIndex].Cells;

            IdBox.Text = Convert.ToString(cells[teacherIdDataGridViewTextBoxColumn.Index].Value);
            NameBox.Text = Convert.ToString(cells[nameDataGridViewTextBoxColumn.Index].Value);
            AddressBox.Text = Convert.ToString(cells[addressDataGridViewTextBoxColumn.Index].Value);

            switch (Convert.ToString(cells[genderDataGridViewTextBoxColumn.Index].Value))
            {
                case "Male":
                    MaleButton.Checked = true;
                    FemaleButton.Checked = false;
                    break;
                case "Female":
                    MaleButton.Checked = false;
                    FemaleButton.Checked = true;
                    break;
            }

            DobBox.Value = Program.Entities.Teachers
                .Where(s => s.TeacherId == IdBox.Text)
                .FirstOrDefault()
                .DateofBirth
                .GetValueOrDefault(DateTime.Today);

            PhoneBox.Text = Convert.ToString(cells[phoneNumberDataGridViewTextBoxColumn.Index].Value);
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            string text = SearchBox.Text.Trim();

            View.DataSource = Program.Entities.Teachers
               .Where(s => text.Length == 0 || s.Name.Contains(text))
               .ToList();
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            ChangeMode(EditMode.INSERT);
            Reset();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (IdBox.TextLength > 0) ChangeMode(EditMode.UPDATE);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            ChangeMode(null);
            Reset();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            var id = IdBox.Text.Trim();
            if (id.Length == 0)
            {
                ErrorLabel.Text = "Needs an id";
                return;
            }

            var name = NameBox.Text.Trim();
            if (name.Length == 0)
            {
                ErrorLabel.Text = "Needs a name";
                return;
            }

            var address = AddressBox.Text.Trim();
            if (address.Length == 0)
            {
                ErrorLabel.Text = "Needs an address";
                return;
            }

            if (!MaleButton.Checked && !FemaleButton.Checked)
            {
                ErrorLabel.Text = "Needs a gender";
                return;
            }
            var gender = MaleButton.Checked ? "Male" : "Female";

            var phone = PhoneBox.Text.Trim();
            if (phone.Length == 0)
            {
                ErrorLabel.Text = "Needs a phone number";
                return;
            }


            Data.Teacher teacher = mode == EditMode.INSERT
                ? new Data.Teacher()
                : Program.Entities.Teachers.Where(s => s.TeacherId == id).FirstOrDefault();


            teacher.TeacherId = id;
            teacher.Name = name;
            teacher.Address = address;
            teacher.Gender = gender;
            teacher.DateofBirth = DobBox.Value;
            teacher.PhoneNumber = phone;

            if (mode == EditMode.INSERT)
            {
                Program.Entities.Teachers.Add(teacher);
            }

            Program.Entities.SaveChanges();

            Reset();
            ChangeMode(null);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (IdBox.Text.Length == 0) return;

            DialogResult result = MessageBox.Show(
                "Delete " + NameBox.Text + "?", "Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                Data.Teacher teacher = Program.Entities.Teachers
                    .Where(s => s.TeacherId == IdBox.Text)
                    .FirstOrDefault();

                Program.Entities.Teachers.Remove(teacher);
                Program.Entities.SaveChanges();

                Reset();
            }
        }

        private void FormTeacher_FormClosed(object sender, FormClosedEventArgs e)
        {
            NavAdmin.INSTANCE.Show();
        }
    }
}
