using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Nusantara.Forms
{
    public partial class FormEditProfile : Form
    {
        private static readonly string ProfilePictures = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\lks2017\profilepictures\";

        private readonly Form nav;

        private string oldPfp = null;

        public FormEditProfile(Form nav)
        {
            InitializeComponent();

            if (!Directory.Exists(ProfilePictures))
            {
                Directory.CreateDirectory(ProfilePictures);
            }

            this.nav = nav;

            Clear();
        }

        private void Clear()
        {
            ErrorLabel.Text = "";

            var student = Program.User.Student;
            var teacher = Program.User.Teacher;

            if (student != null)
            {
                IdBox.Text = student.StudentId;
                NameBox.Text = student.Name;
                PhoneBox.Text = student.PhoneNumber;
                AddressBox.Text = student.Address;

                if (student.Photo != null)
                {
                    oldPfp = ProfilePictures + student.StudentId + "-" + student.Photo;
                }
            }

            if (teacher != null)
            {
                IdBox.Text = teacher.TeacherId;
                NameBox.Text = teacher.Name;
                PhoneBox.Text = teacher.PhoneNumber;
                AddressBox.Text = teacher.Address;

                if (teacher.Photo != null)
                {
                    oldPfp = ProfilePictures + teacher.TeacherId + "-" + teacher.Photo;
                }
            }

            try
            {
                pictureBox1.Image = Image.FromFile(oldPfp);
            }
            catch {
                oldPfp = null;
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

            if (student != null)
            {
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

        private void button4_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var path = dialog.FileName;
                var file = Path.GetFileName(path);

                if (oldPfp != null) File.Delete(oldPfp);

                File.Copy(path, ProfilePictures + Program.User.username + "-" + file);

                var student = Program.User.Student;
                var teacher = Program.User.Teacher;

                if (student != null)
                {
                    student.Photo = file;
                }

                if (teacher != null)
                {
                    teacher.Photo = file;
                }

                Program.Entities.SaveChanges();
                Clear();
            }
        }
    }
}
