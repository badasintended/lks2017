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
    public partial class NavAdmin : Form
    {
        public static readonly NavAdmin INSTANCE = new NavAdmin();
        public NavAdmin()
        {
            InitializeComponent();
        }

        private void NavAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormLogin.GetInstance().Show();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            FormLogin.GetInstance().Show();
            Hide();
        }

        private void ManageStudentButton_Click(object sender, EventArgs e)
        {
            new FormStudent().Show();
            Hide();
        }

        private void ManageTeacherButton_Click(object sender, EventArgs e)
        {
            new FormTeacher().Show();
            Hide();
        }

        private void ManageClassButton_Click(object sender, EventArgs e)
        {
            new FormClass().Show();
            Hide();
        }

        private void ManageScheduleButton_Click(object sender, EventArgs e)
        {
            new FormSchedule().Show();
            Hide();
        }
    }
}
