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
    public partial class FormEntryScore : Form
    {
        private readonly Action action;
        private readonly Data.DetailScore Score;

        public FormEntryScore(Action action, Data.DetailScore score)
        {
            InitializeComponent();
            this.action = action;
            this.Score = score;

            AssignmentBox.Text = score.Assignment?.ToString();
            MidExamBox.Text = score.MidExam?.ToString();
            FinalExamBox.Text = score.FinalExam?.ToString();

            StudentLabel.Text = score.StudentId + " - " + score.Student.Name;

            this.Activate();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            int? assignment = null;
            int? mid = null;
            int? final = null;

            if (AssignmentBox.TextLength > 0) try
                {
                    assignment = Convert.ToInt32(AssignmentBox.Text);
                }
                catch { }

            if (MidExamBox.TextLength > 0) try
                {
                    mid = Convert.ToInt32(MidExamBox.Text);
                }
                catch { }

            if (FinalExamBox.TextLength > 0) try
                {
                    final = Convert.ToInt32(FinalExamBox.Text);
                }
                catch { }

            Score.Assignment = assignment;
            Score.MidExam = mid;
            Score.FinalExam = final;

            Program.Entities.SaveChanges();
            action.Invoke();

            Close();
        }
    }
}
