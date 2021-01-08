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
    public partial class Payment : Form
    {
        const string ConnectionString = @"Data Source=DESKTOP-ELHNV9J\SQLEXPRESS;Initial Catalog=SchoolCourse;Integrated Security=True";
        readonly bool edit;
        private readonly int id;

        public Payment()
        {
            InitializeComponent();
            edit = false;
        }

        public Payment(int id, int pupil_id, int rate_id, string month, bool paid) : this()
        {
            edit = true;
            this.id = id;
            pupil_IDComboBox.SelectedIndex = pupil_IDComboBox.Items.IndexOf(pupil_id);
            paymentRate_IDComboBox.SelectedIndex = paymentRate_IDComboBox.Items.IndexOf(rate_id);
            monthComboBox.SelectedIndex = monthComboBox.Items.IndexOf(month);
            if (paid)
            {
                paidCheckBox.Checked = true;
            }

            string pupil_IDSelect = $"SELECT Pupil_ID FROM Pupil WHERE Pupil_ID = {id}";
            string paymentRate_IDSelect = $"SELECT PaymentRate_ID FROM PaymentRate " +
                $"WHERE PaymentRate_ID = {paymentRate_IDComboBox.SelectedIndex}";
            string 
            SqlConnection sqlconn = new SqlConnection(ConnectionString);
            SqlCommand pupil_IDCommand = new SqlCommand(pupil_IDSelect, sqlconn);
            SqlCommand paymentRate_IDCommand = new SqlCommand(pupil_IDSelect, sqlconn);
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schoolCourseDataSet.Payment". При необходимости она может быть перемещена или удалена.
            this.paymentTableAdapter.Fill(this.schoolCourseDataSet.Payment);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schoolCourseDataSet.PaymentRate". При необходимости она может быть перемещена или удалена.
            this.paymentRateTableAdapter.Fill(this.schoolCourseDataSet.PaymentRate);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schoolCourseDataSet.Pupil". При необходимости она может быть перемещена или удалена.
            this.pupilTableAdapter.Fill(this.schoolCourseDataSet.Pupil);
        }

        private void Cancel_Payment_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OK_Payment_Click(object sender, EventArgs e)
        {

            if (edit)
            {
                paymentTableAdapter.UpdateQuery();
            }
            else
            {
                paymentTableAdapter.InsertQuery();
            }
        }
    }
}
