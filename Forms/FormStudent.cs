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
    public partial class FormStudent : Form
    {
        EditMode? mode = null;

        public FormStudent()
        {
            InitializeComponent();

            Reset();
            ChangeMode(null);
        }

        private void ChangeMode(EditMode? mode)
        {
            this.mode = mode;
            ErrorLabel.Text = "";

            NameBox.Enabled
                = AddressBox.Enabled
                = MaleButton.Enabled
                = FemaleButton.Enabled
                = DobBox.Enabled
                = PhoneBox.Enabled
                = SaveButton.Enabled
                = CancelButton.Enabled
                = mode != null;

            IdBox.Enabled = mode == EditMode.INSERT;

            InsertButton.Enabled
                = UpdateButton.Enabled
                = DeleteButton.Enabled
                = mode == null;
        }

        private void Reset()
        {
            string text = SearchBox.Text.Trim();

            View.DataSource = Program.Entities.Students
               .Where(s => text.Length == 0 || s.Name.Contains(text))
               .ToList();

            IdBox.Clear();
            NameBox.Clear();
            AddressBox.Clear();
            MaleButton.Checked = FemaleButton.Checked = false;
            DobBox.Value = DateTime.Today;
            PhoneBox.Clear();
        }

        private void FormStudent_FormClosed(object sender, FormClosedEventArgs e)
        {
            NavAdmin.INSTANCE.Show();
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            string text = SearchBox.Text.Trim();

            View.DataSource = Program.Entities.Students
               .Where(s => text.Length == 0 || s.Name.Contains(text))
               .ToList();
        }

        private void View_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (View.CurrentCell == null) return;
            if (e.RowIndex == -1) return;
            if (mode != null) return;

            DataGridViewCellCollection cells = View.Rows[e.RowIndex].Cells;

            IdBox.Text = Convert.ToString(cells[studentIdDataGridViewTextBoxColumn.Index].Value);
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

            DobBox.Value = Program.Entities.Students
                .Where(s => s.StudentId == IdBox.Text)
                .FirstOrDefault()
                .DateofBirth
                .GetValueOrDefault(DateTime.Today);

            PhoneBox.Text = Convert.ToString(cells[phoneNumberDataGridViewTextBoxColumn.Index].Value);
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


            Data.Student student = mode == EditMode.INSERT
                ? new Data.Student()
                : Program.Entities.Students.Where(s => s.StudentId == id).FirstOrDefault();


            student.StudentId = id;
            student.Name = name;
            student.Address = address;
            student.Gender = gender;
            student.DateofBirth = DobBox.Value;
            student.PhoneNumber = phone;

            if (mode == EditMode.INSERT)
            {
                Program.Entities.Students.Add(student);
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
                Data.Student student = Program.Entities.Students
                    .Where(s => s.StudentId == IdBox.Text)
                    .FirstOrDefault();

                Program.Entities.Students.Remove(student);
                Program.Entities.SaveChanges();

                Reset();
            }
        }
    }
}
