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
    public partial class ViewReceipt : Form
    {
        const string ConnectionString = @"Data Source=DESKTOP-ELHNV9J\SQLEXPRESS;Initial Catalog=SchoolCourse;Integrated Security=True";

        public ViewReceipt()
        {
            InitializeComponent();
        }

        private void ViewReceipt_Load(object sender, EventArgs e)
        {


            string select = "SELECT Payment.Payment_ID, Pupil.SNP, PaymentRate.PaymentRate_type, PaymentRate.Sum, Payment.Month " +
                "FROM Pupil INNER JOIN Payment ON Pupil.Pupil_ID = Payment.Pupil_ID INNER JOIN " +
                "PaymentRate ON Payment.PaymentRate_ID = PaymentRate.PaymentRate_ID " +
                $"WHERE Payment.Paid = 0";

            SqlConnection sqlconn = new SqlConnection(ConnectionString);
            sqlconn.Open();
            SqlDataAdapter da = new SqlDataAdapter(select, sqlconn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            paymentDataGridView.DataSource = dt;
            sqlconn.Close();
        }

        private void receiptPreviewButton_Click(object sender, EventArgs e)
        {
            this.receiptReportViewer.RefreshReport();

            int id = Convert.ToInt32(paymentDataGridView.SelectedRows[0].Cells[0].Value);

            string select = "SELECT Payment.Payment_ID, Pupil.SNP, PaymentRate.PaymentRate_type, " +
                "PaymentRate.Sum, Payment.Month " +
                "FROM Pupil INNER JOIN Payment ON Pupil.Pupil_ID = Payment.Pupil_ID INNER JOIN " +
                "PaymentRate ON Payment.PaymentRate_ID = PaymentRate.PaymentRate_ID " +
                $"WHERE Payment.Paid = 0 AND Payment.Pupil_ID = " +
                $"(SELECT Pupil_ID FROM Payment WHERE Payment_ID = {id})";

            SqlConnection sqlconn = new SqlConnection(ConnectionString);
            sqlconn.Open();
            SqlDataAdapter da = new SqlDataAdapter(select, sqlconn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            sqlconn.Close();
            ReportDataSource pupilRDS = new ReportDataSource("pupilDataSet", dt);
            ReportDataSource paymentRDS = new ReportDataSource("paymentDataSet", dt);
            ReportDataSource paymentRateRDS = new ReportDataSource("paymentRateDataSet", dt);
            receiptReportViewer.LocalReport.DataSources.Clear();
            receiptReportViewer.LocalReport.DataSources.Add(pupilRDS);
            receiptReportViewer.LocalReport.DataSources.Add(paymentRDS);
            receiptReportViewer.LocalReport.DataSources.Add(paymentRateRDS);
            receiptReportViewer.RefreshReport();
        }
    }
}
