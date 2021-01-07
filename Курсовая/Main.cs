using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсовая
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void pupilsButton_Main_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pupils pupils = new Pupils();
            pupils.Show();
        }

        private void pfilesButton_Main_Click(object sender, EventArgs e)
        {
            this.Hide();
            PersonnelFiles pfiles = new PersonnelFiles();
            pfiles.Show();
        }

        private void birthdaysButton_Click(object sender, EventArgs e)
        {
            Statistics statistics = new Statistics();
            statistics.statsTabControl.SelectedTab = statistics.birthdaysTabPage;
            statistics.Show();
        }

        private void skipsButton_Click(object sender, EventArgs e)
        {
            Statistics statistics = new Statistics();
            statistics.statsTabControl.SelectedTab = statistics.skipsTabPage;
            statistics.Show();
        }

        private void activititesButton_Click(object sender, EventArgs e)
        {
            Statistics statistics = new Statistics();
            statistics.statsTabControl.SelectedTab = statistics.activitiesTabPage;
            statistics.Show();
        }

        private void debtersButton_Click(object sender, EventArgs e)
        {
            Statistics statistics = new Statistics();
            statistics.statsTabControl.SelectedTab = statistics.debtersTabPage;
            statistics.Show();
        }

        private void testsSubjectsButton_Main_Click(object sender, EventArgs e)
        {
            Subjects subjects = new Subjects();
            this.Hide();
            subjects.Show();
        }
    }
}
