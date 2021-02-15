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
    public partial class FormLogin : Form, IForm
    {
        private static FormLogin INSTANCE = new FormLogin();

        public static FormLogin GetInstance()
        {
            INSTANCE.Clear();
            return INSTANCE;
        }

        public FormLogin()
        {
            InitializeComponent();
        }

        public void Clear()
        {
            UsernameBox.Clear();
            PasswordBox.Clear();

            ErrorLabel.Text = "";
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (UsernameBox.Text == "admin" && PasswordBox.Text == "admin")
            {
                new NavAdmin().Show();
                Hide();
                return;
            }

            Program.User = Program.Entities.Users
                .Where(u => u.username == UsernameBox.Text)
                .Where(u => u.password == PasswordBox.Text)
                .FirstOrDefault();

            if (Program.User == null)
            {
                ErrorLabel.Text = "Try Again";
                return;
            }

            switch (Program.User.role)
            {
                case "Teacher":
                    NavTeacher.GetInstance().Show();
                    break;
                case "Student":
                    NavStudent.GetInstance().Show();
                    break;
            }

            Hide();
        }
    }
}
