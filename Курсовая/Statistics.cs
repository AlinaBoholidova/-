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
    public partial class Statistics : Form
    {
        const string ConnectionString = @"Data Source=DESKTOP-ELHNV9J\SQLEXPRESS;Initial Catalog=SchoolCourse;Integrated Security=True";

        public Statistics()
        {
            InitializeComponent();
        }

        private void Statistics_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schoolCourseDataSet.Payment". При необходимости она может быть перемещена или удалена.
            this.paymentTableAdapter.Fill(this.schoolCourseDataSet.Payment);

            // TODO: данная строка кода позволяет загрузить данные в таблицу "schoolCourseDataSet.Test". При необходимости она может быть перемещена или удалена.
            this.testTableAdapter.Fill(this.schoolCourseDataSet.Test);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schoolCourseDataSet.Pupil". При необходимости она может быть перемещена или удалена.
            this.pupilTableAdapter.Fill(this.schoolCourseDataSet.Pupil);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schoolCourseDataSet.JournalRecord". При необходимости она может быть перемещена или удалена.
            this.journalRecordTableAdapter.Fill(this.schoolCourseDataSet.JournalRecord);

            string select1 = "SELECT Pupil.Pupil_ID, Pupil.SNP," +
                "((SELECT COUNT(Test_ID) FROM TEST) - COUNT(JournalRecord.Score)) AS Missed " +
                "FROM Pupil LEFT OUTER JOIN JournalRecord ON Pupil.Pupil_ID = JournalRecord.Pupil_ID " +
                "GROUP BY Pupil.Pupil_ID, Pupil.SNP ORDER BY Missed DESC";

            string select2 = "SELECT Pupil_ID, SNP, CASE " +
                "WHEN MONTH(BirthDate) = 1 THEN 'січень' WHEN MONTH(BirthDate) = 2 THEN 'лютий' " +
                "WHEN MONTH(BirthDate) = 3 THEN 'березень' WHEN MONTH(BirthDate) = 4 THEN 'квітень' " +
                "WHEN MONTH(BirthDate) = 5 THEN 'травень' WHEN MONTH(BirthDate) = 6 THEN 'червень' " +
                "WHEN MONTH(BirthDate) = 7 THEN 'липень' WHEN MONTH(BirthDate) = 8 THEN 'серпень' " +
                "WHEN MONTH(BirthDate) = 9 THEN 'вересень' WHEN MONTH(BirthDate) = 10 THEN 'жовтень' " +
                "WHEN MONTH(BirthDate) = 11 THEN 'листопад' ELSE 'грудень' " +
                "END FROM Pupil ORDER BY MONTH(BirthDate)";

            string select3 = "SELECT Payment.Payment_ID, Pupil.SNP, PaymentRate.PaymentRate_type, Payment.Month " +
                "FROM Pupil INNER JOIN Payment ON Pupil.Pupil_ID = Payment.Pupil_ID INNER JOIN " +
                "PaymentRate ON Payment.PaymentRate_ID = PaymentRate.PaymentRate_ID " +
                "WHERE(Payment.Paid = 0)";

            string select4;

            SqlConnection sqlconn = new SqlConnection(ConnectionString);
            sqlconn.Open();
            
            SqlDataAdapter da1 = new SqlDataAdapter(select1, sqlconn);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;

            SqlDataAdapter da2 = new SqlDataAdapter(select2, sqlconn);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;

            SqlDataAdapter da3 = new SqlDataAdapter(select3, sqlconn);
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);
            dataGridView3.DataSource = dt3;

            //SqlDataAdapter da4 = new SqlDataAdapter(select4, sqlconn);
            //DataTable dt4 = new DataTable();
            //da4.Fill(dt4);
            //dataGridView4.DataSource = dt4;

            sqlconn.Close();
            
            dataGridView1.Columns[0].HeaderText = "ID учня";
            dataGridView1.Columns[1].HeaderText = "ПІБ";
            dataGridView1.Columns[2].HeaderText = "Кількість пропусків";

            dataGridView2.Columns[0].HeaderText = "ID учня";
            dataGridView2.Columns[1].HeaderText = "ПІБ";
            dataGridView2.Columns[2].HeaderText = "Місяць";

            dataGridView3.Columns[0].HeaderText = "ID оплати";
            dataGridView3.Columns[1].HeaderText = "ПІБ";
            dataGridView3.Columns[2].HeaderText = "Тип тарифу";
            dataGridView3.Columns[3].HeaderText = "Місяць";

            // chartBirthMonth
            int birthCount = dataGridView2.Rows.Count - 1;
            List<string> birthMonth = new List<string>();
            for (int i = 0; i < birthCount; i++)
            {
                if (!birthMonth.Contains(Convert.ToString(dataGridView2.Rows[i].Cells[2].Value)))
                {
                    birthMonth.Add(Convert.ToString(dataGridView2.Rows[i].Cells[2].Value));
                }
            }
            Dictionary<string, double> birthData = new Dictionary<string, double>();
            for (int i = 0; i < birthCount; i++)
            {
                if (!birthData.ContainsKey(birthMonth[i]))
                    birthData.Add(birthMonth[i], 1);

                else
                    birthData[birthMonth[i]] += 1;
            }
            foreach (string i in birthData.Keys)
                chartBirthMonth.Series[0].Points.AddXY(i, birthData[i]);

            // chartPaymentMonth
            int paymentCount = dataGridView3.Rows.Count - 1;
            List<string> paymentMonth = new List<string>();
            for (int i = 0; i < paymentCount; i++)
            {
                if (!paymentMonth.Contains(Convert.ToString(dataGridView3.Rows[i].Cells[3].Value)))
                {
                    paymentMonth.Add(Convert.ToString(dataGridView3.Rows[i].Cells[3].Value));
                }
            }
            Dictionary<string, double> paymentData = new Dictionary<string, double>();
            for (int i = 0; i < paymentCount; i++)
            {
                if (!paymentData.ContainsKey(paymentMonth[i]))
                    paymentData.Add(paymentMonth[i], 1);

                else
                    paymentData[paymentMonth[i]] += 1;
            }
            foreach (string i in paymentData.Keys)
                chartPaymentMonth.Series[0].Points.AddXY(i, paymentData[i]);
        }
    }
}
