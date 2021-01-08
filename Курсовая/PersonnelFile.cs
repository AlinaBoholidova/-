using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсовая
{
    public partial class PersonnelFile : Form
    {
        const string ConnectionString = @"Data Source=DESKTOP-ELHNV9J\SQLEXPRESS;Initial Catalog=SchoolCourse;Integrated Security=True";

        readonly bool edit;
        private readonly int id;
        public PersonnelFile()
        {
            InitializeComponent();
            edit = false;
        }
        public PersonnelFile(int id) : this()
        {
            this.id = id;
            pupil_IDTextBox.Text = Convert.ToString(this.id);
        }

        public PersonnelFile(int id, string snp_father, string snp_mother, string snp_custodian,
            string address, string phone) : this()
        {
            edit = true;
            this.id = id;
            pupil_IDTextBox.Text = Convert.ToString(id);
            SNP_fatherTextBox.Text = snp_father;
            SNP_motherTextBox.Text = snp_mother;
            SNP_custodianTextBox.Text = snp_custodian;
            addressTextBox.Text = address;
            phoneTextBox.Text = phone;
        }

        private void PersonnelFile_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schoolCourseDataSet.PersonnelFile". При необходимости она может быть перемещена или удалена.
            this.personnelFileTableAdapter.Fill(this.schoolCourseDataSet.PersonnelFile);
        }

        // Обробка зміни або додавання даних
        private void OK_PersonnelFile_Click(object sender, EventArgs e)
        {
            string snp_custodian = "";
            if (SNP_custodianTextBox.Text == "")
            {
                snp_custodian = "–";
            }
            else if (SNP_custodianTextBox.Text != "")
            {
                snp_custodian = SNP_custodianTextBox.Text;
            }

            DataContext db = new DataContext(ConnectionString);
            // Зміна даних
            if (edit)
            {
                personnelFileTableAdapter.UpdateQuery(SNP_fatherTextBox.Text, SNP_motherTextBox.Text,
                    snp_custodian, addressTextBox.Text, phoneTextBox.Text, Convert.ToInt32(pupil_IDTextBox.Text));

                Table<User> users = db.GetTable<User>();
                List<int> edit = new List<int>();
                foreach (var user in users)
                {
                    if (user.Password == pupil_IDTextBox.Text)
                    {
                        edit.Add(user.User_ID);
                    }
                }

                User user1 = db.GetTable<User>().Where(t => t.User_ID == edit[0]).Single();
                User user2 = db.GetTable<User>().Where(t => t.User_ID == edit[1]).Single();
                user1.Login = SNP_fatherTextBox.Text;
                user2.Login = SNP_motherTextBox.Text;

                if (edit.Count == 3)
                {
                    User user3 = db.GetTable<User>().Where(t => t.User_ID == edit[2]).Single();
                    user3.Login = SNP_custodianTextBox.Text;
                }

                db.SubmitChanges();
            }
            // Додавання даних
            else
            {
                try
                {
                    personnelFileTableAdapter.InsertQuery(Convert.ToInt32(pupil_IDTextBox.Text),
                    SNP_fatherTextBox.Text, SNP_motherTextBox.Text, snp_custodian,
                    addressTextBox.Text, phoneTextBox.Text);


                    // Створюємо нових користувачів
                    User user1 = new User { Login = $"{SNP_fatherTextBox.Text}", Password = $"{pupil_IDTextBox.Text}" };
                    User user2 = new User { Login = $"{SNP_motherTextBox.Text}", Password = $"{pupil_IDTextBox.Text}" };
                    if (SNP_custodianTextBox.Text != "")
                    {
                        User user3 = new User
                        {
                            Login = $"{SNP_custodianTextBox.Text}",
                            Password = $"{pupil_IDTextBox.Text}"
                        };
                        db.GetTable<User>().InsertOnSubmit(user3);
                    }
                    // Додаємо їх до таблиці User
                    db.GetTable<User>().InsertOnSubmit(user1);
                    db.GetTable<User>().InsertOnSubmit(user2);
                    db.SubmitChanges();
                }
                catch
                {
                    MessageBox.Show("Учня з таким ID не існує.", "Помилка");
                }
            }

            Close();
        }

        private void Cancel_PersonnelFile_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
