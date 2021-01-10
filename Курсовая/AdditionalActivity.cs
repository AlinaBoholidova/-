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
    public partial class AdditionalActivity : Form
    {
        public AdditionalActivity()
        {
            InitializeComponent();
        }

        private void AdditionalActivity_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schoolCourseDataSet.AdditionalActivity". При необходимости она может быть перемещена или удалена.
            this.additionalActivityTableAdapter.Fill(this.schoolCourseDataSet.AdditionalActivity);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schoolCourseDataSet.AdditionalParticipation". При необходимости она может быть перемещена или удалена.
            this.additionalParticipationTableAdapter.Fill(this.schoolCourseDataSet.AdditionalParticipation);
        }

        // Додаткова участь
        private void showAll_Participation_Click(object sender, EventArgs e)
        {
            this.additionalParticipationTableAdapter.Fill(this.schoolCourseDataSet.AdditionalParticipation);
            participationDataGridView.DataSource = participationBindingSource;
        }

        private void add_Participation_Click(object sender, EventArgs e)
        {
            var add = new AdditionalParticipation();
            add.ShowDialog();
            additionalParticipationTableAdapter.Fill(schoolCourseDataSet.AdditionalParticipation);
            schoolCourseDataSet.AcceptChanges();
        }

        private void edit_Participation_Click(object sender, EventArgs e)
        {
            var ds = new SchoolCourseDataSet.AdditionalParticipationDataTable();
            additionalParticipationTableAdapter.FillBy2(ds,
                Convert.ToInt32(participationDataGridView.SelectedRows[0].Cells[0].Value),
                Convert.ToInt32(participationDataGridView.SelectedRows[0].Cells[1].Value));
            object[] row = ds.Rows[0].ItemArray;
            var edt = new AdditionalParticipation(Convert.ToInt32(row[0]),
                Convert.ToInt32(row[1]),
                Convert.ToInt32(row[2]));
            edt.ShowDialog();
            additionalParticipationTableAdapter.Fill(schoolCourseDataSet.AdditionalParticipation);
            schoolCourseDataSet.AcceptChanges();
        }

        private void delete_Participation_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ви дійсно хочете видалити обрану участь?", "Видалення участі",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                additionalParticipationTableAdapter.DeleteQuery(
                    Convert.ToInt32(participationDataGridView.SelectedRows[0].Cells[0].Value),
                    Convert.ToInt32(participationDataGridView.SelectedRows[0].Cells[1].Value));
                additionalParticipationTableAdapter.Fill(schoolCourseDataSet.AdditionalParticipation);
                schoolCourseDataSet.AcceptChanges();
            }
        }

        // Додаткова активність
        private void showAll_Activity_Click(object sender, EventArgs e)
        {
            this.additionalActivityTableAdapter.Fill(this.schoolCourseDataSet.AdditionalActivity);
            activityDataGridView.DataSource = activityBindingSource;
        }

        private void add_Activity_Click(object sender, EventArgs e)
        {
            var add = new AdditionalActivityData();
            add.ShowDialog();
            additionalActivityTableAdapter.Fill(schoolCourseDataSet.AdditionalActivity);
            schoolCourseDataSet.AcceptChanges();
        }

        private void edit_Activity_Click(object sender, EventArgs e)
        {
            var ds = new SchoolCourseDataSet.AdditionalActivityDataTable();
            additionalActivityTableAdapter.FillBy(ds, Convert.ToInt32(activityDataGridView.SelectedRows[0].Cells[0].Value));
            object[] row = ds.Rows[0].ItemArray;
            var edt = new AdditionalActivityData(Convert.ToInt32(row[0]),
                row[1].ToString(),
                Convert.ToDateTime(row[2]));
            edt.ShowDialog();
            additionalActivityTableAdapter.Fill(schoolCourseDataSet.AdditionalActivity);
            schoolCourseDataSet.AcceptChanges();
        }

        private void delete_Activity_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ви дійсно хочете видалити обрану активність?", "Видалення активності",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                additionalActivityTableAdapter.DeleteQuery(Convert.ToInt32(activityDataGridView.SelectedRows[0].Cells[0].Value));
                additionalActivityTableAdapter.Fill(schoolCourseDataSet.AdditionalActivity);
                schoolCourseDataSet.AcceptChanges();
            }
        }

        private void back_AddActivity_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            this.Hide();
            main.Show();
        }

        private void AdditionalActivity_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main main = new Main();
            this.Hide();
            main.Show();
        }
    }
}
