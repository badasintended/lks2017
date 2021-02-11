using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Nusantara.Forms
{
    public partial class FormReportScore : Form
    {
        public FormReportScore()
        {
            InitializeComponent();

            SubjectBox.DataSource = Program.Entities.Subjects.Select(s => s.Name).Distinct().ToList();
            SubjectBox.DisplayMember = "Name";
        }

        private void SubjectBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            chart1.Series.Add("Class A");
            chart1.Series.Add("Class B");
            chart1.ChartAreas[0].AxisY.Maximum = 100;

            foreach (Series series in chart1.Series)
            {
                series.IsValueShownAsLabel = true;
            }

            var subject = (string) SubjectBox.SelectedItem;

            int i = 0;
            string[] grades = { "X", "XI", "XII" };
            foreach (var grade in grades)
            {
                chart1.ChartAreas[0].AxisX.CustomLabels.Add(new CustomLabel(i + 0.5, i + 1.5, grade, 0, LabelMarkStyle.None));

                var scoreA = Program.Entities.DetailSchedules
                    .Where(s => s.Subject.Name == subject && s.HeaderSchedule.ClassName == grade + "A")
                    .Select(s => s.DetailScores.Select(d => ((d.Assignment * s.Subject.Assignment) + (d.MidExam * s.Subject.MidExam) + (d.FinalExam * s.Subject.FinalExam)) / 100))
                    .SelectMany(x => x)
                    .ToList()
                    .Average() ?? 0;

                var scoreB = Program.Entities.DetailSchedules
                    .Where(s => s.Subject.Name == subject && s.HeaderSchedule.ClassName == grade + "B")
                    .Select(s => s.DetailScores.Select(d => ((d.Assignment * s.Subject.Assignment) + (d.MidExam * s.Subject.MidExam) + (d.FinalExam * s.Subject.FinalExam)) / 100))
                    .SelectMany(x => x)
                    .ToList()
                    .Average() ?? 0;

                chart1.Series["Class A"].Points.AddY(scoreA);
                chart1.Series["Class B"].Points.AddY(scoreB);

                i++;
            }
        }
    }
}
