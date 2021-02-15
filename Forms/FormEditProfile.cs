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
    public partial class FormEditProfile : Form
    {
        private readonly Form nav;
        public FormEditProfile(Form nav)
        {
            InitializeComponent();

            this.nav = nav;

            ErrorLabel.Text = "";

            var student = Program.User.Student;
            var teacher = Program.User.Teacher;

            if (student != null)
            {
                IdBox.Text = student.StudentId;
                NameBox.Text = student.Name;
                PhoneBox.Text = student.PhoneNumber;
                AddressBox.Text = student.Address;
            }

            if (teacher != null)
            {
                IdBox.Text = teacher.TeacherId;
                NameBox.Text = teacher.Name;
                PhoneBox.Text = teacher.PhoneNumber;
                AddressBox.Text = teacher.Address;
            }
        }

        private void ChangePasswordButton_Click(object sender, EventArgs e)
        {
            new FormChangePassword().ShowDialog();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            ErrorLabel.Text = "";

            var name = NameBox.Text;
            var phone = PhoneBox.Text;
            var address = AddressBox.Text;

            if (name.Length <= 0)
            {
                ErrorLabel.Text = "Needs a name";
                return;
            }

            if (phone.Length <= 0)
            {
                ErrorLabel.Text = "Needs a phone number";
                return;
            }

            if (address.Length <= 0)
            {
                ErrorLabel.Text = "Needs an address";
                return;
            }

            var student = Program.User.Student;
            var teacher = Program.User.Teacher;

            if (student != null) {
                student.Name = name;
                student.PhoneNumber = phone;
                student.Address = address;
            }

            if (teacher != null)
            {
                teacher.Name = name;
                teacher.PhoneNumber = phone;
                teacher.Address = address;
            }

            Program.Entities.SaveChanges();
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormEditProfile_FormClosed(object sender, FormClosedEventArgs e)
        {
            nav.Show();
        }
    }
}
