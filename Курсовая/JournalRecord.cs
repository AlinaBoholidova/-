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
    public partial class JournalRecord : Form
    {
        public JournalRecord()
        {
            InitializeComponent();
        }

        private void JournalRecord_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schoolCourseDataSet.JournalRecord". При необходимости она может быть перемещена или удалена.
            this.journalRecordTableAdapter.Fill(this.schoolCourseDataSet.JournalRecord);

        }

        private void back_Record_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }

        private void add_Record_Click(object sender, EventArgs e)
        {
            var add = new JournalRecordData();
            add.ShowDialog();
        }

        private void edit_Record_Click(object sender, EventArgs e)
        {

        }

        private void delete_Record_Click(object sender, EventArgs e)
        {

        }

        private void showAll_Record_Click(object sender, EventArgs e)
        {
            this.journalRecordTableAdapter.Fill(this.schoolCourseDataSet.JournalRecord);
            recordsDataGridView.DataSource = recordBindingSource;
        }
    }
}
