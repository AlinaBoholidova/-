using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсовая
{
    public partial class ViewScores : Form
    {
        const string ConnectionString = @"Data Source=DESKTOP-ELHNV9J\SQLEXPRESS;Initial Catalog=SchoolCourse;Integrated Security=True";

        public ViewScores()
        {
            InitializeComponent();
        }

        private void ViewScores_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schoolCourseDataSet.Pupil". При необходимости она может быть перемещена или удалена.
            this.pupilTableAdapter.Fill(this.schoolCourseDataSet.Pupil);

            int id = Convert.ToInt32(comboBox1.Text);

            string select1 = "SELECT JournalRecord.Pupil_ID, Pupil.SNP, Test.Test_date, " +
                "Test.Subject_abbr, JournalRecord.Score " +
                "FROM Pupil LEFT OUTER JOIN JournalRecord ON Pupil.Pupil_ID = JournalRecord.Pupil_ID LEFT OUTER JOIN " +
                $"Test ON JournalRecord.Test_ID = Test.Test_ID WHERE JournalRecord.Pupil_ID = {id}";
            
            string select2 = $"SELECT SNP FROM Pupil WHERE Pupil_ID = {id}";

            SqlConnection sqlconn = new SqlConnection(ConnectionString);
            sqlconn.Open();
            SqlDataAdapter da = new SqlDataAdapter(select1, sqlconn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            SqlCommand command = new SqlCommand(select2, sqlconn);
            SqlDataReader myreader;
            myreader = command.ExecuteReader();

            List<String> lstSNP = new List<String>();
            while (myreader.Read())
            {
                lstSNP.Add(myreader[0].ToString());
                //strValue=myreader["email"].ToString();
                //strValue=myreader.GetString(0);
            }
            label1.Text = lstSNP[0];
            sqlconn.Close();
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(comboBox1.Text);
                string snp = "";

                string select = $"SELECT SNP FROM Pupil WHERE Pupil_ID = {id}";

                SqlConnection sqlconn = new SqlConnection(ConnectionString);
                SqlCommand command = new SqlCommand(select, sqlconn);
                SqlDataReader myreader;
                sqlconn.Open();

                myreader = command.ExecuteReader();

                List<String> lstSNP = new List<String>();
                while (myreader.Read())
                {
                    lstSNP.Add(myreader[0].ToString());
                    //strValue=myreader["email"].ToString();
                    //strValue=myreader.GetString(0);
                }
                sqlconn.Close();

                snp = lstSNP[0];
                label1.Text = snp;

                string select1 = "SELECT JournalRecord.Pupil_ID, Pupil.SNP, Test.Test_date, " +
                    "Test.Subject_abbr, JournalRecord.Score " +
                "FROM Pupil LEFT OUTER JOIN JournalRecord ON Pupil.Pupil_ID = JournalRecord.Pupil_ID LEFT OUTER JOIN " +
                 $"Test ON JournalRecord.Test_ID = Test.Test_ID WHERE JournalRecord.Pupil_ID = {id}";

                sqlconn.Open();
                SqlDataAdapter da = new SqlDataAdapter(select1, sqlconn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                sqlconn.Close();
            }
            catch
            {

            }
        }

        private void ViewScores_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
            int id = Convert.ToInt32(comboBox1.Text);
            string date1 = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string date2 = dateTimePicker2.Value.Date.ToString("yyyy-MM-dd");

            label2.Text = date1;
            label3.Text = date2;

            ReportParameterCollection reportParameters = new ReportParameterCollection();
            if (checkBox1.Checked)
            {
                reportParameters.Add(new ReportParameter("ReportParameter1", checkBox1.Text));
                reportParameters.Add(new ReportParameter("ReportParameter2", " "));
                reportParameters.Add(new ReportParameter("ReportParameter3", label1.Text));
            }
            else
            {
                reportParameters.Add(new ReportParameter("ReportParameter1", label2.Text));
                reportParameters.Add(new ReportParameter("ReportParameter2", label3.Text));
                reportParameters.Add(new ReportParameter("ReportParameter3", label1.Text));
            }

            string select = "";

            if (checkBox1.Checked)
            {
                select = "SELECT JournalRecord.Pupil_ID, Pupil.SNP, Test.Test_date, Test.Subject_abbr, " +
                "JournalRecord.Score " +
                "FROM Pupil LEFT OUTER JOIN JournalRecord ON Pupil.Pupil_ID = JournalRecord.Pupil_ID LEFT OUTER JOIN " +
                 $"Test ON JournalRecord.Test_ID = Test.Test_ID WHERE JournalRecord.Pupil_ID = {id} ";
            }
            else
            {
                select = "SELECT JournalRecord.Pupil_ID, Pupil.SNP, Test.Test_date, Test.Subject_abbr, " +
                "JournalRecord.Score " +
                "FROM Pupil LEFT OUTER JOIN JournalRecord ON Pupil.Pupil_ID = JournalRecord.Pupil_ID LEFT OUTER JOIN " +
                 $"Test ON JournalRecord.Test_ID = Test.Test_ID WHERE JournalRecord.Pupil_ID = {id} " +
                 $"AND Test.Test_date BETWEEN CONVERT(datetime, '{date1}') AND CONVERT(datetime, '{date2}')";
            }
            

            SqlConnection sqlconn = new SqlConnection(ConnectionString);
            sqlconn.Open();
            SqlDataAdapter da = new SqlDataAdapter(select, sqlconn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            sqlconn.Close();
            ReportDataSource pupilRDS = new ReportDataSource("DataSet1", dt);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(pupilRDS);
            reportViewer1.LocalReport.SetParameters(reportParameters);
            reportViewer1.RefreshReport();
        }
    }
}
