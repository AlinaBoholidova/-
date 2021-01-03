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
    public partial class Subjects : Form
    {
        public Subjects()
        {
            InitializeComponent();
        }

        private void Subjects_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schoolCourseDataSet.Test". При необходимости она может быть перемещена или удалена.
            this.testTableAdapter.Fill(this.schoolCourseDataSet.Test);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schoolCourseDataSet.Subject". При необходимости она может быть перемещена или удалена.
            this.subjectTableAdapter.Fill(this.schoolCourseDataSet.Subject);

        }
    }
}
