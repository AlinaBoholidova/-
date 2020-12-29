namespace Курсовая
{
    partial class Pupils
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
            this.back_Pupils = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.add_Pupils = new System.Windows.Forms.Button();
            this.change_Pupils = new System.Windows.Forms.Button();
            this.delete_Pupils = new System.Windows.Forms.Button();
            this.pupilDataGridView = new System.Windows.Forms.DataGridView();
            this.pupilIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sNPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pupilBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.schoolCourseDataSet = new Курсовая.SchoolCourseDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.showAll_Pupils = new System.Windows.Forms.Button();
            this.searchTextBox_Pupils = new System.Windows.Forms.TextBox();
            this.toSort_Pupils = new System.Windows.Forms.Button();
            this.toFilter_Pupils = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.monthComboBox_Pupils = new System.Windows.Forms.ComboBox();
            this.sortComboBox_Pupils = new System.Windows.Forms.ComboBox();
            this.snpCheckBox_Pupils = new System.Windows.Forms.CheckBox();
            this.birthCheckBox_Pupils = new System.Windows.Forms.CheckBox();
            this.toSearch_Pupils = new System.Windows.Forms.Button();
            this.maleRadioButton_Pupils = new System.Windows.Forms.RadioButton();
            this.femaleRadioButton_Pupils = new System.Windows.Forms.RadioButton();
            this.idCheckBox_Pupils = new System.Windows.Forms.CheckBox();
            this.allCheckBox_Pupils = new System.Windows.Forms.CheckBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.personnelFileButton_Pupils = new System.Windows.Forms.Button();
            this.pupilTableAdapter = new Курсовая.SchoolCourseDataSetTableAdapters.PupilTableAdapter();
            this.pfileBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personnelFileTableAdapter = new Курсовая.SchoolCourseDataSetTableAdapters.PersonnelFileTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pupilDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pupilBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolCourseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pfileBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // back_Pupils
            // 
            this.back_Pupils.Location = new System.Drawing.Point(12, 531);
            this.back_Pupils.Name = "back_Pupils";
            this.back_Pupils.Size = new System.Drawing.Size(105, 31);
            this.back_Pupils.TabIndex = 0;
            this.back_Pupils.Text = "Повернутися";
            this.back_Pupils.UseVisualStyleBackColor = true;
            this.back_Pupils.Click += new System.EventHandler(this.back_Pupils_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Список учнів";
            // 
            // add_Pupils
            // 
            this.add_Pupils.Location = new System.Drawing.Point(333, 62);
            this.add_Pupils.Name = "add_Pupils";
            this.add_Pupils.Size = new System.Drawing.Size(96, 27);
            this.add_Pupils.TabIndex = 3;
            this.add_Pupils.Text = "Додати учня";
            this.add_Pupils.UseVisualStyleBackColor = true;
            this.add_Pupils.Click += new System.EventHandler(this.add_Pupils_Click);
            // 
            // change_Pupils
            // 
            this.change_Pupils.Location = new System.Drawing.Point(435, 62);
            this.change_Pupils.Name = "change_Pupils";
            this.change_Pupils.Size = new System.Drawing.Size(96, 27);
            this.change_Pupils.TabIndex = 4;
            this.change_Pupils.Text = "Змінити дані";
            this.change_Pupils.UseVisualStyleBackColor = true;
            this.change_Pupils.Click += new System.EventHandler(this.change_Pupils_Click);
            // 
            // delete_Pupils
            // 
            this.delete_Pupils.Location = new System.Drawing.Point(537, 62);
            this.delete_Pupils.Name = "delete_Pupils";
            this.delete_Pupils.Size = new System.Drawing.Size(96, 27);
            this.delete_Pupils.TabIndex = 5;
            this.delete_Pupils.Text = "Видалити учня";
            this.delete_Pupils.UseVisualStyleBackColor = true;
            this.delete_Pupils.Click += new System.EventHandler(this.delete_Pupils_Click);
            // 
            // pupilDataGridView
            // 
            this.pupilDataGridView.AllowUserToAddRows = false;
            this.pupilDataGridView.AllowUserToDeleteRows = false;
            this.pupilDataGridView.AutoGenerateColumns = false;
            this.pupilDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pupilDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pupilIDDataGridViewTextBoxColumn,
            this.sNPDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.birthDateDataGridViewTextBoxColumn});
            this.pupilDataGridView.DataSource = this.pupilBindingSource;
            this.pupilDataGridView.Location = new System.Drawing.Point(50, 105);
            this.pupilDataGridView.Name = "pupilDataGridView";
            this.pupilDataGridView.ReadOnly = true;
            this.pupilDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.pupilDataGridView.Size = new System.Drawing.Size(583, 196);
            this.pupilDataGridView.TabIndex = 6;
            // 
            // pupilIDDataGridViewTextBoxColumn
            // 
            this.pupilIDDataGridViewTextBoxColumn.DataPropertyName = "Pupil_ID";
            this.pupilIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.pupilIDDataGridViewTextBoxColumn.Name = "pupilIDDataGridViewTextBoxColumn";
            this.pupilIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.pupilIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // sNPDataGridViewTextBoxColumn
            // 
            this.sNPDataGridViewTextBoxColumn.DataPropertyName = "SNP";
            this.sNPDataGridViewTextBoxColumn.HeaderText = "ПІБ";
            this.sNPDataGridViewTextBoxColumn.Name = "sNPDataGridViewTextBoxColumn";
            this.sNPDataGridViewTextBoxColumn.ReadOnly = true;
            this.sNPDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Стать";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.ReadOnly = true;
            this.genderDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // birthDateDataGridViewTextBoxColumn
            // 
            this.birthDateDataGridViewTextBoxColumn.DataPropertyName = "BirthDate";
            this.birthDateDataGridViewTextBoxColumn.HeaderText = "Дата народження";
            this.birthDateDataGridViewTextBoxColumn.Name = "birthDateDataGridViewTextBoxColumn";
            this.birthDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.birthDateDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // pupilBindingSource
            // 
            this.pupilBindingSource.DataMember = "Pupil";
            this.pupilBindingSource.DataSource = this.schoolCourseDataSet;
            // 
            // schoolCourseDataSet
            // 
            this.schoolCourseDataSet.DataSetName = "SchoolCourseDataSet";
            this.schoolCourseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 319);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Пошук";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(245, 319);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Сортування";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(511, 323);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Фільтрація";
            // 
            // showAll_Pupils
            // 
            this.showAll_Pupils.Location = new System.Drawing.Point(50, 62);
            this.showAll_Pupils.Name = "showAll_Pupils";
            this.showAll_Pupils.Size = new System.Drawing.Size(109, 27);
            this.showAll_Pupils.TabIndex = 10;
            this.showAll_Pupils.Text = "Показати всіх";
            this.showAll_Pupils.UseVisualStyleBackColor = true;
            this.showAll_Pupils.Click += new System.EventHandler(this.showAll_Pupils_Click);
            // 
            // searchTextBox_Pupils
            // 
            this.searchTextBox_Pupils.Location = new System.Drawing.Point(19, 434);
            this.searchTextBox_Pupils.Name = "searchTextBox_Pupils";
            this.searchTextBox_Pupils.Size = new System.Drawing.Size(140, 20);
            this.searchTextBox_Pupils.TabIndex = 11;
            // 
            // toSort_Pupils
            // 
            this.toSort_Pupils.Location = new System.Drawing.Point(248, 407);
            this.toSort_Pupils.Name = "toSort_Pupils";
            this.toSort_Pupils.Size = new System.Drawing.Size(75, 23);
            this.toSort_Pupils.TabIndex = 12;
            this.toSort_Pupils.Text = "Сортувати";
            this.toSort_Pupils.UseVisualStyleBackColor = true;
            this.toSort_Pupils.Click += new System.EventHandler(this.toSort_Pupils_Click);
            // 
            // toFilter_Pupils
            // 
            this.toFilter_Pupils.Location = new System.Drawing.Point(511, 448);
            this.toFilter_Pupils.Name = "toFilter_Pupils";
            this.toFilter_Pupils.Size = new System.Drawing.Size(83, 23);
            this.toFilter_Pupils.TabIndex = 13;
            this.toFilter_Pupils.Text = "Фільтрувати";
            this.toFilter_Pupils.UseVisualStyleBackColor = true;
            this.toFilter_Pupils.Click += new System.EventHandler(this.toFilter_Pupils_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(424, 366);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Стать";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(424, 409);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Місяць народження";
            // 
            // monthComboBox_Pupils
            // 
            this.monthComboBox_Pupils.FormattingEnabled = true;
            this.monthComboBox_Pupils.Items.AddRange(new object[] {
            "01 (січень)",
            "02 (лютий)",
            "03 (березень)",
            "04 (квітень)",
            "05 (травень)",
            "06 (червень)",
            "07 (липень)",
            "08 (серпень)",
            "09 (вересень)",
            "10 (жовтень)",
            "11 (листопад)",
            "12 (грудень)"});
            this.monthComboBox_Pupils.Location = new System.Drawing.Point(537, 407);
            this.monthComboBox_Pupils.Name = "monthComboBox_Pupils";
            this.monthComboBox_Pupils.Size = new System.Drawing.Size(140, 21);
            this.monthComboBox_Pupils.TabIndex = 17;
            // 
            // sortComboBox_Pupils
            // 
            this.sortComboBox_Pupils.FormattingEnabled = true;
            this.sortComboBox_Pupils.Items.AddRange(new object[] {
            "ID",
            "ПІБ",
            "Стать",
            "Дата народження"});
            this.sortComboBox_Pupils.Location = new System.Drawing.Point(214, 360);
            this.sortComboBox_Pupils.Name = "sortComboBox_Pupils";
            this.sortComboBox_Pupils.Size = new System.Drawing.Size(140, 21);
            this.sortComboBox_Pupils.TabIndex = 19;
            // 
            // snpCheckBox_Pupils
            // 
            this.snpCheckBox_Pupils.AutoSize = true;
            this.snpCheckBox_Pupils.Location = new System.Drawing.Point(31, 388);
            this.snpCheckBox_Pupils.Name = "snpCheckBox_Pupils";
            this.snpCheckBox_Pupils.Size = new System.Drawing.Size(44, 17);
            this.snpCheckBox_Pupils.TabIndex = 20;
            this.snpCheckBox_Pupils.Text = "ПІБ";
            this.snpCheckBox_Pupils.UseVisualStyleBackColor = true;
            // 
            // birthCheckBox_Pupils
            // 
            this.birthCheckBox_Pupils.AutoSize = true;
            this.birthCheckBox_Pupils.Location = new System.Drawing.Point(31, 411);
            this.birthCheckBox_Pupils.Name = "birthCheckBox_Pupils";
            this.birthCheckBox_Pupils.Size = new System.Drawing.Size(117, 17);
            this.birthCheckBox_Pupils.TabIndex = 21;
            this.birthCheckBox_Pupils.Text = "Дата народження";
            this.birthCheckBox_Pupils.UseVisualStyleBackColor = true;
            // 
            // toSearch_Pupils
            // 
            this.toSearch_Pupils.Location = new System.Drawing.Point(49, 469);
            this.toSearch_Pupils.Name = "toSearch_Pupils";
            this.toSearch_Pupils.Size = new System.Drawing.Size(75, 23);
            this.toSearch_Pupils.TabIndex = 22;
            this.toSearch_Pupils.Text = "Знайти";
            this.toSearch_Pupils.UseVisualStyleBackColor = true;
            this.toSearch_Pupils.Click += new System.EventHandler(this.toSearch_Pupils_Click);
            // 
            // maleRadioButton_Pupils
            // 
            this.maleRadioButton_Pupils.AutoSize = true;
            this.maleRadioButton_Pupils.Location = new System.Drawing.Point(537, 364);
            this.maleRadioButton_Pupils.Name = "maleRadioButton_Pupils";
            this.maleRadioButton_Pupils.Size = new System.Drawing.Size(33, 17);
            this.maleRadioButton_Pupils.TabIndex = 23;
            this.maleRadioButton_Pupils.TabStop = true;
            this.maleRadioButton_Pupils.Text = "Ч";
            this.maleRadioButton_Pupils.UseVisualStyleBackColor = true;
            // 
            // femaleRadioButton_Pupils
            // 
            this.femaleRadioButton_Pupils.AutoSize = true;
            this.femaleRadioButton_Pupils.Location = new System.Drawing.Point(581, 364);
            this.femaleRadioButton_Pupils.Name = "femaleRadioButton_Pupils";
            this.femaleRadioButton_Pupils.Size = new System.Drawing.Size(36, 17);
            this.femaleRadioButton_Pupils.TabIndex = 24;
            this.femaleRadioButton_Pupils.TabStop = true;
            this.femaleRadioButton_Pupils.Text = "Ж";
            this.femaleRadioButton_Pupils.UseVisualStyleBackColor = true;
            // 
            // idCheckBox_Pupils
            // 
            this.idCheckBox_Pupils.AutoSize = true;
            this.idCheckBox_Pupils.Location = new System.Drawing.Point(31, 345);
            this.idCheckBox_Pupils.Name = "idCheckBox_Pupils";
            this.idCheckBox_Pupils.Size = new System.Drawing.Size(37, 17);
            this.idCheckBox_Pupils.TabIndex = 25;
            this.idCheckBox_Pupils.Text = "ID";
            this.idCheckBox_Pupils.UseVisualStyleBackColor = true;
            // 
            // allCheckBox_Pupils
            // 
            this.allCheckBox_Pupils.AutoSize = true;
            this.allCheckBox_Pupils.Location = new System.Drawing.Point(31, 366);
            this.allCheckBox_Pupils.Name = "allCheckBox_Pupils";
            this.allCheckBox_Pupils.Size = new System.Drawing.Size(69, 17);
            this.allCheckBox_Pupils.TabIndex = 26;
            this.allCheckBox_Pupils.Text = "Усі поля";
            this.allCheckBox_Pupils.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(623, 364);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(30, 17);
            this.radioButton1.TabIndex = 27;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "–";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // personnelFileButton_Pupils
            // 
            this.personnelFileButton_Pupils.Location = new System.Drawing.Point(683, 125);
            this.personnelFileButton_Pupils.Name = "personnelFileButton_Pupils";
            this.personnelFileButton_Pupils.Size = new System.Drawing.Size(115, 23);
            this.personnelFileButton_Pupils.TabIndex = 28;
            this.personnelFileButton_Pupils.Text = "Особова справа";
            this.personnelFileButton_Pupils.UseVisualStyleBackColor = true;
            this.personnelFileButton_Pupils.Click += new System.EventHandler(this.personnelFileButton_Pupils_Click);
            // 
            // pupilTableAdapter
            // 
            this.pupilTableAdapter.ClearBeforeFill = true;
            // 
            // pfileBindingSource
            // 
            this.pfileBindingSource.DataMember = "PersonnelFile";
            this.pfileBindingSource.DataSource = this.schoolCourseDataSet;
            // 
            // personnelFileTableAdapter
            // 
            this.personnelFileTableAdapter.ClearBeforeFill = true;
            // 
            // Pupils
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 574);
            this.Controls.Add(this.personnelFileButton_Pupils);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.allCheckBox_Pupils);
            this.Controls.Add(this.idCheckBox_Pupils);
            this.Controls.Add(this.femaleRadioButton_Pupils);
            this.Controls.Add(this.maleRadioButton_Pupils);
            this.Controls.Add(this.toSearch_Pupils);
            this.Controls.Add(this.birthCheckBox_Pupils);
            this.Controls.Add(this.snpCheckBox_Pupils);
            this.Controls.Add(this.sortComboBox_Pupils);
            this.Controls.Add(this.monthComboBox_Pupils);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.toFilter_Pupils);
            this.Controls.Add(this.toSort_Pupils);
            this.Controls.Add(this.searchTextBox_Pupils);
            this.Controls.Add(this.showAll_Pupils);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pupilDataGridView);
            this.Controls.Add(this.delete_Pupils);
            this.Controls.Add(this.change_Pupils);
            this.Controls.Add(this.add_Pupils);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.back_Pupils);
            this.Name = "Pupils";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Учні";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Pupils_FormClosing);
            this.Load += new System.EventHandler(this.Учні_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pupilDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pupilBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolCourseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pfileBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back_Pupils;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button add_Pupils;
        private System.Windows.Forms.Button change_Pupils;
        private System.Windows.Forms.Button delete_Pupils;
        private System.Windows.Forms.DataGridView pupilDataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button showAll_Pupils;
        private System.Windows.Forms.TextBox searchTextBox_Pupils;
        private System.Windows.Forms.Button toSort_Pupils;
        private System.Windows.Forms.Button toFilter_Pupils;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox monthComboBox_Pupils;
        private System.Windows.Forms.ComboBox sortComboBox_Pupils;
        private System.Windows.Forms.CheckBox snpCheckBox_Pupils;
        private System.Windows.Forms.CheckBox birthCheckBox_Pupils;
        private System.Windows.Forms.Button toSearch_Pupils;
        private System.Windows.Forms.RadioButton maleRadioButton_Pupils;
        private System.Windows.Forms.RadioButton femaleRadioButton_Pupils;
        private System.Windows.Forms.CheckBox idCheckBox_Pupils;
        private System.Windows.Forms.CheckBox allCheckBox_Pupils;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button personnelFileButton_Pupils;
        private System.Windows.Forms.BindingSource pupilBindingSource;
        private SchoolCourseDataSet schoolCourseDataSet;
        private SchoolCourseDataSetTableAdapters.PupilTableAdapter pupilTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pupilIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource pfileBindingSource;
        private SchoolCourseDataSetTableAdapters.PersonnelFileTableAdapter personnelFileTableAdapter;
    }
}