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
    public partial class Points : Form
    {
        public Points()
        {
            InitializeComponent();
        }

        private void showAll_Points_Click(object sender, EventArgs e)
        {
            this.pointsDistributionTableAdapter.Fill(this.schoolCourseDataSet.PointsDistribution);
            pointsDataGridView.DataSource = pointsBindingSource;
        }

        private void Points_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schoolCourseDataSet.PointsDistribution". При необходимости она может быть перемещена или удалена.
            this.pointsDistributionTableAdapter.Fill(this.schoolCourseDataSet.PointsDistribution);
        }

        private void back_Points_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            this.Hide();
            main.Show();
        }

        private void add_Points_Click(object sender, EventArgs e)
        {
            var add = new PointsData();
            add.ShowDialog();
            pointsDistributionTableAdapter.Fill(schoolCourseDataSet.PointsDistribution);
            schoolCourseDataSet.AcceptChanges();
        }

        private void edit_Points_Click(object sender, EventArgs e)
        {
            var ds = new SchoolCourseDataSet.PointsDistributionDataTable();
            pointsDistributionTableAdapter.FillBy(ds,
                Convert.ToInt32(pointsDataGridView.SelectedRows[0].Cells[0].Value));
            object[] row = ds.Rows[0].ItemArray;
            var edt = new PointsData(Convert.ToInt32(row[0]),
                row[1].ToString(),
                Convert.ToInt32(row[2]));
            edt.ShowDialog();
            pointsDistributionTableAdapter.Fill(schoolCourseDataSet.PointsDistribution);
            schoolCourseDataSet.AcceptChanges();
        }

        private void delete_Points_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ви дійсно хочете видалити обрану розбаловку?", "Видалення розбаловки",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                pointsDistributionTableAdapter.DeleteQuery(
                    Convert.ToInt32(pointsDataGridView.SelectedRows[0].Cells[0].Value));
                pointsDistributionTableAdapter.Fill(schoolCourseDataSet.PointsDistribution);
                schoolCourseDataSet.AcceptChanges();
            }
        }
    }
}
