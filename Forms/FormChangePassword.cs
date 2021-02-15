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
    public partial class FormChangePassword : Form
    {
        public FormChangePassword()
        {
            InitializeComponent();

            ErrorLabel.Text = "";
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            ErrorLabel.Text = "";

            var oldPw = OldPassBox.Text;
            var newPw = NewPassBox.Text;
            var confirm = ConfirmPassBox.Text;

            if (oldPw != Program.User.password)
            {
                ErrorLabel.Text = "wrong old password";
                return;
            }

            if (confirm.Length <= 0)
            {
                ErrorLabel.Text = "Confirm your password";
                return;
            }

            if (newPw != confirm)
            {
                ErrorLabel.Text = "Wrong confirmation";
                return;
            }

            Program.User.password = newPw;
            Program.Entities.SaveChanges();
            Close();
        }
    }
}
