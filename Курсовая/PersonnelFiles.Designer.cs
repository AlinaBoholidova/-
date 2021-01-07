namespace Курсовая
{
    partial class PersonnelFiles
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
            this.label1 = new System.Windows.Forms.Label();
            this.pfilesDataGridView = new System.Windows.Forms.DataGridView();
            this.pupilIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sNPfatherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sNPmotherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sNPcustodianDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pfileBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.schoolCourseDataSet = new Курсовая.SchoolCourseDataSet();
            this.back_PersonelFiles = new System.Windows.Forms.Button();
            this.showAll_PersonnelFiles = new System.Windows.Forms.Button();
            this.delete_PersonnelFiles = new System.Windows.Forms.Button();
            this.change_PersonnelFiles = new System.Windows.Forms.Button();
            this.add_PersonnelFiles = new System.Windows.Forms.Button();
            this.sortComboBox_PersonnelFiles = new System.Windows.Forms.ComboBox();
            this.toSort_PersonnelFiles = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.allCheckBox_PersonnelFiles = new System.Windows.Forms.CheckBox();
            this.idCheckBox_PersonnelFiles = new System.Windows.Forms.CheckBox();
            this.toSearch_Pupils = new System.Windows.Forms.Button();
            this.snpCheckBox_PersonnelFiles = new System.Windows.Forms.CheckBox();
            this.searchTextBox_PersonnelFiles = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addressCheckBox_PersonnelFiles = new System.Windows.Forms.CheckBox();
            this.phoneCheckBox_PersonnelFiles = new System.Windows.Forms.CheckBox();
            this.personnelFileTableAdapter = new Курсовая.SchoolCourseDataSetTableAdapters.PersonnelFileTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pfilesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pfileBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolCourseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Особові справи";
            // 
            // pfilesDataGridView
            // 
            this.pfilesDataGridView.AllowUserToAddRows = false;
            this.pfilesDataGridView.AllowUserToDeleteRows = false;
            this.pfilesDataGridView.AutoGenerateColumns = false;
            this.pfilesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pfilesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pupilIDDataGridViewTextBoxColumn,
            this.sNPfatherDataGridViewTextBoxColumn,
            this.sNPmotherDataGridViewTextBoxColumn,
            this.sNPcustodianDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn});
            this.pfilesDataGridView.DataSource = this.pfileBindingSource;
            this.pfilesDataGridView.Location = new System.Drawing.Point(17, 103);
            this.pfilesDataGridView.Name = "pfilesDataGridView";
            this.pfilesDataGridView.ReadOnly = true;
            this.pfilesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.pfilesDataGridView.Size = new System.Drawing.Size(730, 150);
            this.pfilesDataGridView.TabIndex = 1;
            // 
            // pupilIDDataGridViewTextBoxColumn
            // 
            this.pupilIDDataGridViewTextBoxColumn.DataPropertyName = "Pupil_ID";
            this.pupilIDDataGridViewTextBoxColumn.HeaderText = "ID учня";
            this.pupilIDDataGridViewTextBoxColumn.Name = "pupilIDDataGridViewTextBoxColumn";
            this.pupilIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.pupilIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // sNPfatherDataGridViewTextBoxColumn
            // 
            this.sNPfatherDataGridViewTextBoxColumn.DataPropertyName = "SNP_father";
            this.sNPfatherDataGridViewTextBoxColumn.HeaderText = "ПІБ батька";
            this.sNPfatherDataGridViewTextBoxColumn.Name = "sNPfatherDataGridViewTextBoxColumn";
            this.sNPfatherDataGridViewTextBoxColumn.ReadOnly = true;
            this.sNPfatherDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // sNPmotherDataGridViewTextBoxColumn
            // 
            this.sNPmotherDataGridViewTextBoxColumn.DataPropertyName = "SNP_mother";
            this.sNPmotherDataGridViewTextBoxColumn.HeaderText = "ПІБ матері";
            this.sNPmotherDataGridViewTextBoxColumn.Name = "sNPmotherDataGridViewTextBoxColumn";
            this.sNPmotherDataGridViewTextBoxColumn.ReadOnly = true;
            this.sNPmotherDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // sNPcustodianDataGridViewTextBoxColumn
            // 
            this.sNPcustodianDataGridViewTextBoxColumn.DataPropertyName = "SNP_custodian";
            this.sNPcustodianDataGridViewTextBoxColumn.HeaderText = "ПІБ опікуна";
            this.sNPcustodianDataGridViewTextBoxColumn.Name = "sNPcustodianDataGridViewTextBoxColumn";
            this.sNPcustodianDataGridViewTextBoxColumn.ReadOnly = true;
            this.sNPcustodianDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Адреса";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            this.addressDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
            this.phoneDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // pfileBindingSource
            // 
            this.pfileBindingSource.DataMember = "PersonnelFile";
            this.pfileBindingSource.DataSource = this.schoolCourseDataSet;
            // 
            // schoolCourseDataSet
            // 
            this.schoolCourseDataSet.DataSetName = "SchoolCourseDataSet";
            this.schoolCourseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // back_PersonelFiles
            // 
            this.back_PersonelFiles.Location = new System.Drawing.Point(17, 416);
            this.back_PersonelFiles.Name = "back_PersonelFiles";
            this.back_PersonelFiles.Size = new System.Drawing.Size(105, 31);
            this.back_PersonelFiles.TabIndex = 2;
            this.back_PersonelFiles.Text = "Повернутися";
            this.back_PersonelFiles.UseVisualStyleBackColor = true;
            this.back_PersonelFiles.Click += new System.EventHandler(this.back_PersonelFiles_Click);
            // 
            // showAll_PersonnelFiles
            // 
            this.showAll_PersonnelFiles.Location = new System.Drawing.Point(38, 56);
            this.showAll_PersonnelFiles.Name = "showAll_PersonnelFiles";
            this.showAll_PersonnelFiles.Size = new System.Drawing.Size(109, 27);
            this.showAll_PersonnelFiles.TabIndex = 14;
            this.showAll_PersonnelFiles.Text = "Показати всі";
            this.showAll_PersonnelFiles.UseVisualStyleBackColor = true;
            this.showAll_PersonnelFiles.Click += new System.EventHandler(this.showAll_PersonnelFiles_Click);
            // 
            // delete_PersonnelFiles
            // 
            this.delete_PersonnelFiles.Location = new System.Drawing.Point(623, 56);
            this.delete_PersonnelFiles.Name = "delete_PersonnelFiles";
            this.delete_PersonnelFiles.Size = new System.Drawing.Size(106, 27);
            this.delete_PersonnelFiles.TabIndex = 13;
            this.delete_PersonnelFiles.Text = "Видалити справу";
            this.delete_PersonnelFiles.UseVisualStyleBackColor = true;
            this.delete_PersonnelFiles.Click += new System.EventHandler(this.delete_PersonnelFiles_Click);
            // 
            // change_PersonnelFiles
            // 
            this.change_PersonnelFiles.Location = new System.Drawing.Point(516, 56);
            this.change_PersonnelFiles.Name = "change_PersonnelFiles";
            this.change_PersonnelFiles.Size = new System.Drawing.Size(96, 27);
            this.change_PersonnelFiles.TabIndex = 12;
            this.change_PersonnelFiles.Text = "Змінити дані";
            this.change_PersonnelFiles.UseVisualStyleBackColor = true;
            this.change_PersonnelFiles.Click += new System.EventHandler(this.change_PersonnelFiles_Click);
            // 
            // add_PersonnelFiles
            // 
            this.add_PersonnelFiles.Location = new System.Drawing.Point(410, 56);
            this.add_PersonnelFiles.Name = "add_PersonnelFiles";
            this.add_PersonnelFiles.Size = new System.Drawing.Size(96, 27);
            this.add_PersonnelFiles.TabIndex = 11;
            this.add_PersonnelFiles.Text = "Додати справу";
            this.add_PersonnelFiles.UseVisualStyleBackColor = true;
            this.add_PersonnelFiles.Click += new System.EventHandler(this.add_PersonnelFiles_Click);
            // 
            // sortComboBox_PersonnelFiles
            // 
            this.sortComboBox_PersonnelFiles.FormattingEnabled = true;
            this.sortComboBox_PersonnelFiles.Items.AddRange(new object[] {
            "ID учня",
            "ПІБ батька",
            "ПІБ матері",
            "ПІБ опікуна",
            "Адреса",
            "Телефон"});
            this.sortComboBox_PersonnelFiles.Location = new System.Drawing.Point(437, 328);
            this.sortComboBox_PersonnelFiles.Name = "sortComboBox_PersonnelFiles";
            this.sortComboBox_PersonnelFiles.Size = new System.Drawing.Size(140, 21);
            this.sortComboBox_PersonnelFiles.TabIndex = 22;
            // 
            // toSort_PersonnelFiles
            // 
            this.toSort_PersonnelFiles.Location = new System.Drawing.Point(471, 375);
            this.toSort_PersonnelFiles.Name = "toSort_PersonnelFiles";
            this.toSort_PersonnelFiles.Size = new System.Drawing.Size(75, 23);
            this.toSort_PersonnelFiles.TabIndex = 21;
            this.toSort_PersonnelFiles.Text = "Сортувати";
            this.toSort_PersonnelFiles.UseVisualStyleBackColor = true;
            this.toSort_PersonnelFiles.Click += new System.EventHandler(this.toSort_PersonnelFiles_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(468, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Сортування";
            // 
            // allCheckBox_PersonnelFiles
            // 
            this.allCheckBox_PersonnelFiles.AutoSize = true;
            this.allCheckBox_PersonnelFiles.Location = new System.Drawing.Point(224, 285);
            this.allCheckBox_PersonnelFiles.Name = "allCheckBox_PersonnelFiles";
            this.allCheckBox_PersonnelFiles.Size = new System.Drawing.Size(69, 17);
            this.allCheckBox_PersonnelFiles.TabIndex = 32;
            this.allCheckBox_PersonnelFiles.Text = "Усі поля";
            this.allCheckBox_PersonnelFiles.UseVisualStyleBackColor = true;
            // 
            // idCheckBox_PersonnelFiles
            // 
            this.idCheckBox_PersonnelFiles.AutoSize = true;
            this.idCheckBox_PersonnelFiles.Location = new System.Drawing.Point(224, 308);
            this.idCheckBox_PersonnelFiles.Name = "idCheckBox_PersonnelFiles";
            this.idCheckBox_PersonnelFiles.Size = new System.Drawing.Size(62, 17);
            this.idCheckBox_PersonnelFiles.TabIndex = 31;
            this.idCheckBox_PersonnelFiles.Text = "ID учня";
            this.idCheckBox_PersonnelFiles.UseVisualStyleBackColor = true;
            // 
            // toSearch_Pupils
            // 
            this.toSearch_Pupils.Location = new System.Drawing.Point(243, 427);
            this.toSearch_Pupils.Name = "toSearch_Pupils";
            this.toSearch_Pupils.Size = new System.Drawing.Size(75, 23);
            this.toSearch_Pupils.TabIndex = 30;
            this.toSearch_Pupils.Text = "Знайти";
            this.toSearch_Pupils.UseVisualStyleBackColor = true;
            this.toSearch_Pupils.Click += new System.EventHandler(this.toSearch_Pupils_Click);
            // 
            // snpCheckBox_PersonnelFiles
            // 
            this.snpCheckBox_PersonnelFiles.AutoSize = true;
            this.snpCheckBox_PersonnelFiles.Location = new System.Drawing.Point(224, 330);
            this.snpCheckBox_PersonnelFiles.Name = "snpCheckBox_PersonnelFiles";
            this.snpCheckBox_PersonnelFiles.Size = new System.Drawing.Size(44, 17);
            this.snpCheckBox_PersonnelFiles.TabIndex = 29;
            this.snpCheckBox_PersonnelFiles.Text = "ПІБ";
            this.snpCheckBox_PersonnelFiles.UseVisualStyleBackColor = true;
            // 
            // searchTextBox_PersonnelFiles
            // 
            this.searchTextBox_PersonnelFiles.Location = new System.Drawing.Point(193, 401);
            this.searchTextBox_PersonnelFiles.Name = "searchTextBox_PersonnelFiles";
            this.searchTextBox_PersonnelFiles.Size = new System.Drawing.Size(195, 20);
            this.searchTextBox_PersonnelFiles.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(274, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Пошук";
            // 
            // addressCheckBox_PersonnelFiles
            // 
            this.addressCheckBox_PersonnelFiles.AutoSize = true;
            this.addressCheckBox_PersonnelFiles.Location = new System.Drawing.Point(224, 354);
            this.addressCheckBox_PersonnelFiles.Name = "addressCheckBox_PersonnelFiles";
            this.addressCheckBox_PersonnelFiles.Size = new System.Drawing.Size(63, 17);
            this.addressCheckBox_PersonnelFiles.TabIndex = 33;
            this.addressCheckBox_PersonnelFiles.Text = "Адреса";
            this.addressCheckBox_PersonnelFiles.UseVisualStyleBackColor = true;
            // 
            // phoneCheckBox_PersonnelFiles
            // 
            this.phoneCheckBox_PersonnelFiles.AutoSize = true;
            this.phoneCheckBox_PersonnelFiles.Location = new System.Drawing.Point(224, 378);
            this.phoneCheckBox_PersonnelFiles.Name = "phoneCheckBox_PersonnelFiles";
            this.phoneCheckBox_PersonnelFiles.Size = new System.Drawing.Size(71, 17);
            this.phoneCheckBox_PersonnelFiles.TabIndex = 34;
            this.phoneCheckBox_PersonnelFiles.Text = "Телефон";
            this.phoneCheckBox_PersonnelFiles.UseVisualStyleBackColor = true;
            // 
            // personnelFileTableAdapter
            // 
            this.personnelFileTableAdapter.ClearBeforeFill = true;
            // 
            // PersonnelFiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 459);
            this.Controls.Add(this.phoneCheckBox_PersonnelFiles);
            this.Controls.Add(this.addressCheckBox_PersonnelFiles);
            this.Controls.Add(this.allCheckBox_PersonnelFiles);
            this.Controls.Add(this.idCheckBox_PersonnelFiles);
            this.Controls.Add(this.toSearch_Pupils);
            this.Controls.Add(this.snpCheckBox_PersonnelFiles);
            this.Controls.Add(this.searchTextBox_PersonnelFiles);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sortComboBox_PersonnelFiles);
            this.Controls.Add(this.toSort_PersonnelFiles);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.showAll_PersonnelFiles);
            this.Controls.Add(this.delete_PersonnelFiles);
            this.Controls.Add(this.change_PersonnelFiles);
            this.Controls.Add(this.add_PersonnelFiles);
            this.Controls.Add(this.back_PersonelFiles);
            this.Controls.Add(this.pfilesDataGridView);
            this.Controls.Add(this.label1);
            this.Name = "PersonnelFiles";
            this.Text = "Особові справи";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PersonnelFiles_FormClosing);
            this.Load += new System.EventHandler(this.PersonnelFiles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pfilesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pfileBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolCourseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView pfilesDataGridView;
        private System.Windows.Forms.Button back_PersonelFiles;
        private System.Windows.Forms.Button showAll_PersonnelFiles;
        private System.Windows.Forms.Button delete_PersonnelFiles;
        private System.Windows.Forms.Button change_PersonnelFiles;
        private System.Windows.Forms.Button add_PersonnelFiles;
        private SchoolCourseDataSet schoolCourseDataSet;
        private System.Windows.Forms.BindingSource pfileBindingSource;
        private SchoolCourseDataSetTableAdapters.PersonnelFileTableAdapter personnelFileTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pupilIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNPfatherDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNPmotherDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNPcustodianDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox sortComboBox_PersonnelFiles;
        private System.Windows.Forms.Button toSort_PersonnelFiles;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox allCheckBox_PersonnelFiles;
        private System.Windows.Forms.CheckBox idCheckBox_PersonnelFiles;
        private System.Windows.Forms.Button toSearch_Pupils;
        private System.Windows.Forms.CheckBox snpCheckBox_PersonnelFiles;
        private System.Windows.Forms.TextBox searchTextBox_PersonnelFiles;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox addressCheckBox_PersonnelFiles;
        private System.Windows.Forms.CheckBox phoneCheckBox_PersonnelFiles;
    }
}