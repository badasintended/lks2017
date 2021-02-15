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
    public partial class NavTeacher : Form
    {
        private static readonly NavTeacher INSTANCE = new NavTeacher();

        public static NavTeacher GetInstance()
        {
            INSTANCE.TitleLabel.Text = "Welcome, " + Program.User.Teacher.Name;
            return INSTANCE;
        }

        public NavTeacher()
        {
            InitializeComponent();
        }

        private void NavTeacher_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormLogin.GetInstance().Show();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            FormLogin.GetInstance().Show();
            Hide();
        }

        private void InputScoreButton_Click(object sender, EventArgs e)
        {
            new FormInputScore().Show();
            Hide();
        }

        private void ScheduleButton_Click(object sender, EventArgs e)
        {
            new FormViewScheduleTeacher().Show();
            Hide();
        }

        private void EditProfileButton_Click(object sender, EventArgs e)
        {
            new FormEditProfile(this).Show();
            Hide();
        }
    }
}
