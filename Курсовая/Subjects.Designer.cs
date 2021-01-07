namespace Курсовая
{
    partial class Subjects
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.subjectsDataGridView = new System.Windows.Forms.DataGridView();
            this.testsDataGridView = new System.Windows.Forms.DataGridView();
            this.back_Subjects = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.allCheckBox_Subjects = new System.Windows.Forms.CheckBox();
            this.abbrCheckBox_Subjects = new System.Windows.Forms.CheckBox();
            this.toSearch_Subjects = new System.Windows.Forms.Button();
            this.nameCheckBox_Subjects = new System.Windows.Forms.CheckBox();
            this.searchTextBox_Subjects = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.allCheckBox_Tests = new System.Windows.Forms.CheckBox();
            this.abbrCheckBox_Tests = new System.Windows.Forms.CheckBox();
            this.toSearch_Tests = new System.Windows.Forms.Button();
            this.dateCheckBox_Tests = new System.Windows.Forms.CheckBox();
            this.searchTextBox_Tests = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.idCheckBox_Tests = new System.Windows.Forms.CheckBox();
            this.sortComboBox_Tests = new System.Windows.Forms.ComboBox();
            this.toSort_Tests = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.sortComboBox_Subjects = new System.Windows.Forms.ComboBox();
            this.toSort_Subjects = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.showAll_Tests = new System.Windows.Forms.Button();
            this.showAll_Subjects = new System.Windows.Forms.Button();
            this.add_Tests = new System.Windows.Forms.Button();
            this.change_Tests = new System.Windows.Forms.Button();
            this.delete_Tests = new System.Windows.Forms.Button();
            this.delete_Subjects = new System.Windows.Forms.Button();
            this.change_Subjects = new System.Windows.Forms.Button();
            this.add_Subjects = new System.Windows.Forms.Button();
            this.testIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectabbrDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.schoolCourseDataSet = new Курсовая.SchoolCourseDataSet();
            this.subjectabbrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.subjectTableAdapter = new Курсовая.SchoolCourseDataSetTableAdapters.SubjectTableAdapter();
            this.testTableAdapter = new Курсовая.SchoolCourseDataSetTableAdapters.TestTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolCourseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // subjectsDataGridView
            // 
            this.subjectsDataGridView.AllowUserToAddRows = false;
            this.subjectsDataGridView.AllowUserToDeleteRows = false;
            this.subjectsDataGridView.AutoGenerateColumns = false;
            this.subjectsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.subjectsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.subjectabbrDataGridViewTextBoxColumn,
            this.subjectnameDataGridViewTextBoxColumn});
            this.subjectsDataGridView.DataSource = this.subjectBindingSource;
            this.subjectsDataGridView.Location = new System.Drawing.Point(536, 88);
            this.subjectsDataGridView.Name = "subjectsDataGridView";
            this.subjectsDataGridView.ReadOnly = true;
            this.subjectsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.subjectsDataGridView.Size = new System.Drawing.Size(319, 196);
            this.subjectsDataGridView.TabIndex = 0;
            // 
            // testsDataGridView
            // 
            this.testsDataGridView.AllowUserToAddRows = false;
            this.testsDataGridView.AllowUserToDeleteRows = false;
            this.testsDataGridView.AutoGenerateColumns = false;
            this.testsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.testsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.testIDDataGridViewTextBoxColumn,
            this.subjectabbrDataGridViewTextBoxColumn1,
            this.testdateDataGridViewTextBoxColumn});
            this.testsDataGridView.DataSource = this.testBindingSource;
            this.testsDataGridView.Location = new System.Drawing.Point(37, 88);
            this.testsDataGridView.Name = "testsDataGridView";
            this.testsDataGridView.ReadOnly = true;
            this.testsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.testsDataGridView.Size = new System.Drawing.Size(362, 196);
            this.testsDataGridView.TabIndex = 1;
            // 
            // back_Subjects
            // 
            this.back_Subjects.Location = new System.Drawing.Point(16, 521);
            this.back_Subjects.Name = "back_Subjects";
            this.back_Subjects.Size = new System.Drawing.Size(105, 31);
            this.back_Subjects.TabIndex = 3;
            this.back_Subjects.Text = "Повернутися";
            this.back_Subjects.UseVisualStyleBackColor = true;
            this.back_Subjects.Click += new System.EventHandler(this.back_Subjects_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Контрольні роботи";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(544, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Навчальні предмети";
            // 
            // allCheckBox_Subjects
            // 
            this.allCheckBox_Subjects.AutoSize = true;
            this.allCheckBox_Subjects.Location = new System.Drawing.Point(522, 345);
            this.allCheckBox_Subjects.Name = "allCheckBox_Subjects";
            this.allCheckBox_Subjects.Size = new System.Drawing.Size(69, 17);
            this.allCheckBox_Subjects.TabIndex = 38;
            this.allCheckBox_Subjects.Text = "Усі поля";
            this.allCheckBox_Subjects.UseVisualStyleBackColor = true;
            // 
            // abbrCheckBox_Subjects
            // 
            this.abbrCheckBox_Subjects.AutoSize = true;
            this.abbrCheckBox_Subjects.Location = new System.Drawing.Point(522, 368);
            this.abbrCheckBox_Subjects.Name = "abbrCheckBox_Subjects";
            this.abbrCheckBox_Subjects.Size = new System.Drawing.Size(138, 17);
            this.abbrCheckBox_Subjects.TabIndex = 37;
            this.abbrCheckBox_Subjects.Text = "Абревіатура предмету";
            this.abbrCheckBox_Subjects.UseVisualStyleBackColor = true;
            // 
            // toSearch_Subjects
            // 
            this.toSearch_Subjects.Location = new System.Drawing.Point(536, 439);
            this.toSearch_Subjects.Name = "toSearch_Subjects";
            this.toSearch_Subjects.Size = new System.Drawing.Size(75, 23);
            this.toSearch_Subjects.TabIndex = 36;
            this.toSearch_Subjects.Text = "Знайти";
            this.toSearch_Subjects.UseVisualStyleBackColor = true;
            this.toSearch_Subjects.Click += new System.EventHandler(this.toSearch_Subjects_Click);
            // 
            // nameCheckBox_Subjects
            // 
            this.nameCheckBox_Subjects.AutoSize = true;
            this.nameCheckBox_Subjects.Location = new System.Drawing.Point(522, 390);
            this.nameCheckBox_Subjects.Name = "nameCheckBox_Subjects";
            this.nameCheckBox_Subjects.Size = new System.Drawing.Size(109, 17);
            this.nameCheckBox_Subjects.TabIndex = 35;
            this.nameCheckBox_Subjects.Text = "Назва предмету";
            this.nameCheckBox_Subjects.UseVisualStyleBackColor = true;
            // 
            // searchTextBox_Subjects
            // 
            this.searchTextBox_Subjects.Location = new System.Drawing.Point(483, 413);
            this.searchTextBox_Subjects.Name = "searchTextBox_Subjects";
            this.searchTextBox_Subjects.Size = new System.Drawing.Size(195, 20);
            this.searchTextBox_Subjects.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(544, 320);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Пошук";
            // 
            // allCheckBox_Tests
            // 
            this.allCheckBox_Tests.AutoSize = true;
            this.allCheckBox_Tests.Location = new System.Drawing.Point(37, 336);
            this.allCheckBox_Tests.Name = "allCheckBox_Tests";
            this.allCheckBox_Tests.Size = new System.Drawing.Size(69, 17);
            this.allCheckBox_Tests.TabIndex = 44;
            this.allCheckBox_Tests.Text = "Усі поля";
            this.allCheckBox_Tests.UseVisualStyleBackColor = true;
            // 
            // abbrCheckBox_Tests
            // 
            this.abbrCheckBox_Tests.AutoSize = true;
            this.abbrCheckBox_Tests.Location = new System.Drawing.Point(37, 378);
            this.abbrCheckBox_Tests.Name = "abbrCheckBox_Tests";
            this.abbrCheckBox_Tests.Size = new System.Drawing.Size(138, 17);
            this.abbrCheckBox_Tests.TabIndex = 43;
            this.abbrCheckBox_Tests.Text = "Абревіатура предмету";
            this.abbrCheckBox_Tests.UseVisualStyleBackColor = true;
            // 
            // toSearch_Tests
            // 
            this.toSearch_Tests.Location = new System.Drawing.Point(70, 449);
            this.toSearch_Tests.Name = "toSearch_Tests";
            this.toSearch_Tests.Size = new System.Drawing.Size(75, 23);
            this.toSearch_Tests.TabIndex = 42;
            this.toSearch_Tests.Text = "Знайти";
            this.toSearch_Tests.UseVisualStyleBackColor = true;
            this.toSearch_Tests.Click += new System.EventHandler(this.toSearch_Tests_Click);
            // 
            // dateCheckBox_Tests
            // 
            this.dateCheckBox_Tests.AutoSize = true;
            this.dateCheckBox_Tests.Location = new System.Drawing.Point(37, 400);
            this.dateCheckBox_Tests.Name = "dateCheckBox_Tests";
            this.dateCheckBox_Tests.Size = new System.Drawing.Size(109, 17);
            this.dateCheckBox_Tests.TabIndex = 41;
            this.dateCheckBox_Tests.Text = "Дата написання";
            this.dateCheckBox_Tests.UseVisualStyleBackColor = true;
            // 
            // searchTextBox_Tests
            // 
            this.searchTextBox_Tests.Location = new System.Drawing.Point(16, 423);
            this.searchTextBox_Tests.Name = "searchTextBox_Tests";
            this.searchTextBox_Tests.Size = new System.Drawing.Size(195, 20);
            this.searchTextBox_Tests.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 320);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "Пошук";
            // 
            // idCheckBox_Tests
            // 
            this.idCheckBox_Tests.AutoSize = true;
            this.idCheckBox_Tests.Location = new System.Drawing.Point(37, 355);
            this.idCheckBox_Tests.Name = "idCheckBox_Tests";
            this.idCheckBox_Tests.Size = new System.Drawing.Size(102, 17);
            this.idCheckBox_Tests.TabIndex = 45;
            this.idCheckBox_Tests.Text = "ID контрольної";
            this.idCheckBox_Tests.UseVisualStyleBackColor = true;
            // 
            // sortComboBox_Tests
            // 
            this.sortComboBox_Tests.FormattingEnabled = true;
            this.sortComboBox_Tests.Items.AddRange(new object[] {
            "ID контрольної",
            "Абревіатура предмету",
            "Дата написання"});
            this.sortComboBox_Tests.Location = new System.Drawing.Point(240, 371);
            this.sortComboBox_Tests.Name = "sortComboBox_Tests";
            this.sortComboBox_Tests.Size = new System.Drawing.Size(140, 21);
            this.sortComboBox_Tests.TabIndex = 48;
            // 
            // toSort_Tests
            // 
            this.toSort_Tests.Location = new System.Drawing.Point(274, 418);
            this.toSort_Tests.Name = "toSort_Tests";
            this.toSort_Tests.Size = new System.Drawing.Size(75, 23);
            this.toSort_Tests.TabIndex = 47;
            this.toSort_Tests.Text = "Сортувати";
            this.toSort_Tests.UseVisualStyleBackColor = true;
            this.toSort_Tests.Click += new System.EventHandler(this.toSort_Tests_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(271, 330);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 46;
            this.label5.Text = "Сортування";
            // 
            // sortComboBox_Subjects
            // 
            this.sortComboBox_Subjects.FormattingEnabled = true;
            this.sortComboBox_Subjects.Items.AddRange(new object[] {
            "Абревіатура предмету",
            "Назва предмету"});
            this.sortComboBox_Subjects.Location = new System.Drawing.Point(702, 386);
            this.sortComboBox_Subjects.Name = "sortComboBox_Subjects";
            this.sortComboBox_Subjects.Size = new System.Drawing.Size(140, 21);
            this.sortComboBox_Subjects.TabIndex = 51;
            // 
            // toSort_Subjects
            // 
            this.toSort_Subjects.Location = new System.Drawing.Point(736, 433);
            this.toSort_Subjects.Name = "toSort_Subjects";
            this.toSort_Subjects.Size = new System.Drawing.Size(75, 23);
            this.toSort_Subjects.TabIndex = 50;
            this.toSort_Subjects.Text = "Сортувати";
            this.toSort_Subjects.UseVisualStyleBackColor = true;
            this.toSort_Subjects.Click += new System.EventHandler(this.toSort_Subjects_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(733, 345);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 49;
            this.label6.Text = "Сортування";
            // 
            // showAll_Tests
            // 
            this.showAll_Tests.Location = new System.Drawing.Point(37, 55);
            this.showAll_Tests.Name = "showAll_Tests";
            this.showAll_Tests.Size = new System.Drawing.Size(109, 27);
            this.showAll_Tests.TabIndex = 52;
            this.showAll_Tests.Text = "Показати всі";
            this.showAll_Tests.UseVisualStyleBackColor = true;
            this.showAll_Tests.Click += new System.EventHandler(this.showAll_Tests_Click);
            // 
            // showAll_Subjects
            // 
            this.showAll_Subjects.Location = new System.Drawing.Point(522, 55);
            this.showAll_Subjects.Name = "showAll_Subjects";
            this.showAll_Subjects.Size = new System.Drawing.Size(109, 27);
            this.showAll_Subjects.TabIndex = 53;
            this.showAll_Subjects.Text = "Показати всі";
            this.showAll_Subjects.UseVisualStyleBackColor = true;
            this.showAll_Subjects.Click += new System.EventHandler(this.showAll_Subjects_Click);
            // 
            // add_Tests
            // 
            this.add_Tests.Location = new System.Drawing.Point(183, 48);
            this.add_Tests.Name = "add_Tests";
            this.add_Tests.Size = new System.Drawing.Size(96, 34);
            this.add_Tests.TabIndex = 54;
            this.add_Tests.Text = "Додати контрольну";
            this.add_Tests.UseVisualStyleBackColor = true;
            this.add_Tests.Click += new System.EventHandler(this.add_Tests_Click);
            // 
            // change_Tests
            // 
            this.change_Tests.Location = new System.Drawing.Point(285, 48);
            this.change_Tests.Name = "change_Tests";
            this.change_Tests.Size = new System.Drawing.Size(96, 34);
            this.change_Tests.TabIndex = 55;
            this.change_Tests.Text = "Змінити дані";
            this.change_Tests.UseVisualStyleBackColor = true;
            // 
            // delete_Tests
            // 
            this.delete_Tests.Location = new System.Drawing.Point(387, 48);
            this.delete_Tests.Name = "delete_Tests";
            this.delete_Tests.Size = new System.Drawing.Size(106, 34);
            this.delete_Tests.TabIndex = 56;
            this.delete_Tests.Text = "Видалити контрольну";
            this.delete_Tests.UseVisualStyleBackColor = true;
            this.delete_Tests.Click += new System.EventHandler(this.delete_Tests_Click);
            // 
            // delete_Subjects
            // 
            this.delete_Subjects.Location = new System.Drawing.Point(849, 48);
            this.delete_Subjects.Name = "delete_Subjects";
            this.delete_Subjects.Size = new System.Drawing.Size(106, 34);
            this.delete_Subjects.TabIndex = 59;
            this.delete_Subjects.Text = "Видалити предмет";
            this.delete_Subjects.UseVisualStyleBackColor = true;
            this.delete_Subjects.Click += new System.EventHandler(this.delete_Subjects_Click);
            // 
            // change_Subjects
            // 
            this.change_Subjects.Location = new System.Drawing.Point(747, 48);
            this.change_Subjects.Name = "change_Subjects";
            this.change_Subjects.Size = new System.Drawing.Size(96, 34);
            this.change_Subjects.TabIndex = 58;
            this.change_Subjects.Text = "Змінити дані";
            this.change_Subjects.UseVisualStyleBackColor = true;
            // 
            // add_Subjects
            // 
            this.add_Subjects.Location = new System.Drawing.Point(645, 48);
            this.add_Subjects.Name = "add_Subjects";
            this.add_Subjects.Size = new System.Drawing.Size(96, 34);
            this.add_Subjects.TabIndex = 57;
            this.add_Subjects.Text = "Додати предмет";
            this.add_Subjects.UseVisualStyleBackColor = true;
            // 
            // testIDDataGridViewTextBoxColumn
            // 
            this.testIDDataGridViewTextBoxColumn.DataPropertyName = "Test_ID";
            this.testIDDataGridViewTextBoxColumn.HeaderText = "ID контрольної";
            this.testIDDataGridViewTextBoxColumn.Name = "testIDDataGridViewTextBoxColumn";
            this.testIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.testIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // subjectabbrDataGridViewTextBoxColumn1
            // 
            this.subjectabbrDataGridViewTextBoxColumn1.DataPropertyName = "Subject_abbr";
            this.subjectabbrDataGridViewTextBoxColumn1.HeaderText = "Абревіатура предмету";
            this.subjectabbrDataGridViewTextBoxColumn1.Name = "subjectabbrDataGridViewTextBoxColumn1";
            this.subjectabbrDataGridViewTextBoxColumn1.ReadOnly = true;
            this.subjectabbrDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // testdateDataGridViewTextBoxColumn
            // 
            this.testdateDataGridViewTextBoxColumn.DataPropertyName = "Test_date";
            this.testdateDataGridViewTextBoxColumn.HeaderText = "Дата написання";
            this.testdateDataGridViewTextBoxColumn.Name = "testdateDataGridViewTextBoxColumn";
            this.testdateDataGridViewTextBoxColumn.ReadOnly = true;
            this.testdateDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // testBindingSource
            // 
            this.testBindingSource.DataMember = "Test";
            this.testBindingSource.DataSource = this.schoolCourseDataSet;
            // 
            // schoolCourseDataSet
            // 
            this.schoolCourseDataSet.DataSetName = "SchoolCourseDataSet";
            this.schoolCourseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // subjectabbrDataGridViewTextBoxColumn
            // 
            this.subjectabbrDataGridViewTextBoxColumn.DataPropertyName = "Subject_abbr";
            this.subjectabbrDataGridViewTextBoxColumn.HeaderText = "Абревіатура предмету";
            this.subjectabbrDataGridViewTextBoxColumn.Name = "subjectabbrDataGridViewTextBoxColumn";
            this.subjectabbrDataGridViewTextBoxColumn.ReadOnly = true;
            this.subjectabbrDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // subjectnameDataGridViewTextBoxColumn
            // 
            this.subjectnameDataGridViewTextBoxColumn.DataPropertyName = "Subject_name";
            this.subjectnameDataGridViewTextBoxColumn.HeaderText = "Назва предмету";
            this.subjectnameDataGridViewTextBoxColumn.Name = "subjectnameDataGridViewTextBoxColumn";
            this.subjectnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.subjectnameDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // subjectBindingSource
            // 
            this.subjectBindingSource.DataMember = "Subject";
            this.subjectBindingSource.DataSource = this.schoolCourseDataSet;
            // 
            // subjectTableAdapter
            // 
            this.subjectTableAdapter.ClearBeforeFill = true;
            // 
            // testTableAdapter
            // 
            this.testTableAdapter.ClearBeforeFill = true;
            // 
            // Subjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 564);
            this.Controls.Add(this.delete_Subjects);
            this.Controls.Add(this.change_Subjects);
            this.Controls.Add(this.add_Subjects);
            this.Controls.Add(this.delete_Tests);
            this.Controls.Add(this.change_Tests);
            this.Controls.Add(this.add_Tests);
            this.Controls.Add(this.showAll_Subjects);
            this.Controls.Add(this.showAll_Tests);
            this.Controls.Add(this.sortComboBox_Subjects);
            this.Controls.Add(this.toSort_Subjects);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.sortComboBox_Tests);
            this.Controls.Add(this.toSort_Tests);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.idCheckBox_Tests);
            this.Controls.Add(this.allCheckBox_Tests);
            this.Controls.Add(this.abbrCheckBox_Tests);
            this.Controls.Add(this.toSearch_Tests);
            this.Controls.Add(this.dateCheckBox_Tests);
            this.Controls.Add(this.searchTextBox_Tests);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.allCheckBox_Subjects);
            this.Controls.Add(this.abbrCheckBox_Subjects);
            this.Controls.Add(this.toSearch_Subjects);
            this.Controls.Add(this.nameCheckBox_Subjects);
            this.Controls.Add(this.searchTextBox_Subjects);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.back_Subjects);
            this.Controls.Add(this.testsDataGridView);
            this.Controls.Add(this.subjectsDataGridView);
            this.Name = "Subjects";
            this.Text = "Предмети";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Subjects_FormClosing);
            this.Load += new System.EventHandler(this.Subjects_Load);
            ((System.ComponentModel.ISupportInitialize)(this.subjectsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolCourseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView subjectsDataGridView;
        private SchoolCourseDataSet schoolCourseDataSet;
        private System.Windows.Forms.BindingSource subjectBindingSource;
        private SchoolCourseDataSetTableAdapters.SubjectTableAdapter subjectTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectabbrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView testsDataGridView;
        private System.Windows.Forms.BindingSource testBindingSource;
        private SchoolCourseDataSetTableAdapters.TestTableAdapter testTableAdapter;
        private System.Windows.Forms.Button back_Subjects;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn testIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectabbrDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn testdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.CheckBox allCheckBox_Subjects;
        private System.Windows.Forms.CheckBox abbrCheckBox_Subjects;
        private System.Windows.Forms.Button toSearch_Subjects;
        private System.Windows.Forms.CheckBox nameCheckBox_Subjects;
        private System.Windows.Forms.TextBox searchTextBox_Subjects;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox allCheckBox_Tests;
        private System.Windows.Forms.CheckBox abbrCheckBox_Tests;
        private System.Windows.Forms.Button toSearch_Tests;
        private System.Windows.Forms.CheckBox dateCheckBox_Tests;
        private System.Windows.Forms.TextBox searchTextBox_Tests;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox idCheckBox_Tests;
        private System.Windows.Forms.ComboBox sortComboBox_Tests;
        private System.Windows.Forms.Button toSort_Tests;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox sortComboBox_Subjects;
        private System.Windows.Forms.Button toSort_Subjects;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button showAll_Tests;
        private System.Windows.Forms.Button showAll_Subjects;
        private System.Windows.Forms.Button add_Tests;
        private System.Windows.Forms.Button change_Tests;
        private System.Windows.Forms.Button delete_Tests;
        private System.Windows.Forms.Button delete_Subjects;
        private System.Windows.Forms.Button change_Subjects;
        private System.Windows.Forms.Button add_Subjects;
    }
}