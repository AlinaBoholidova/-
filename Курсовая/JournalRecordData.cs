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
    public partial class JournalRecordData : Form
    {
        public JournalRecordData()
        {
            InitializeComponent();
        }

        private void JournalRecordData_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schoolCourseDataSet.JournalRecord". При необходимости она может быть перемещена или удалена.
            this.journalRecordTableAdapter.Fill(this.schoolCourseDataSet.JournalRecord);

        }
    }
}
