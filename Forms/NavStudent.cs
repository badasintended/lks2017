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
    public partial class NavStudent : Form
    {
        private static readonly NavStudent INSTANCE = new NavStudent();
        public static NavStudent GetInstance()
        {
            INSTANCE.TitleLabel.Text = "Welcome, " + Program.User.Student.Name;
            return INSTANCE;
        }

        public NavStudent()
        {
            InitializeComponent();
        }

        private void NavStudent_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormLogin.GetInstance().Show();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            FormLogin.GetInstance().Show();
            Hide();
        }

        private void EditProfileButton_Click(object sender, EventArgs e)
        {

        }

        private void ScheduleButton_Click(object sender, EventArgs e)
        {
            new FormViewScheduleStudent().Show();
            Hide();
        }

        private void ViewScoreButton_Click(object sender, EventArgs e)
        {
            new FormViewScore().Show();
            Hide();
        }
    }
}
