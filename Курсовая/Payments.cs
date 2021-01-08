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
    public partial class Payments : Form
    {
        public Payments()
        {
            InitializeComponent();
        }

        private void back_Payments_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }

        private void Payments_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Payments_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schoolCourseDataSet.PaymentRate". При необходимости она может быть перемещена или удалена.
            this.paymentRateTableAdapter.Fill(this.schoolCourseDataSet.PaymentRate);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schoolCourseDataSet.Payment". При необходимости она может быть перемещена или удалена.
            this.paymentTableAdapter.Fill(this.schoolCourseDataSet.Payment);
        }


    }
}
