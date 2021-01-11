namespace Курсовая
{
    partial class JournalRecord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JournalRecord));
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.delete_Record = new System.Windows.Forms.Button();
            this.edit_Record = new System.Windows.Forms.Button();
            this.add_Record = new System.Windows.Forms.Button();
            this.showAll_Record = new System.Windows.Forms.Button();
            this.recordsDataGridView = new System.Windows.Forms.DataGridView();
            this.schoolCourseDataSet = new Курсовая.SchoolCourseDataSet();
            this.recordBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.journalRecordTableAdapter = new Курсовая.SchoolCourseDataSetTableAdapters.JournalRecordTableAdapter();
            this.recordIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pupilIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scoreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.back_Record = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sortComboBox_Tests = new System.Windows.Forms.ComboBox();
            this.toSort_Tests = new System.Windows.Forms.Button();
            this.toNumericUpDown_Points = new System.Windows.Forms.NumericUpDown();
            this.fromNumericUpDown_Points = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.toFilter_Points = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.phoneCheckBox_PersonnelFiles = new System.Windows.Forms.CheckBox();
            this.addressCheckBox_PersonnelFiles = new System.Windows.Forms.CheckBox();
            this.allCheckBox_PersonnelFiles = new System.Windows.Forms.CheckBox();
            this.idCheckBox_PersonnelFiles = new System.Windows.Forms.CheckBox();
            this.toSearch_Pupils = new System.Windows.Forms.Button();
            this.snpCheckBox_PersonnelFiles = new System.Windows.Forms.CheckBox();
            this.searchTextBox_PersonnelFiles = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recordsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolCourseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recordBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.back_Record)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toNumericUpDown_Points)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromNumericUpDown_Points)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = global::Курсовая.Properties.Resources.subject;
            this.pictureBox5.Location = new System.Drawing.Point(94, 0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(128, 120);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 70;
            this.pictureBox5.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(230, 49);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(144, 20);
            this.label11.TabIndex = 69;
            this.label11.Text = "Записи журналу";
            // 
            // delete_Record
            // 
            this.delete_Record.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.delete_Record.BackgroundImage = global::Курсовая.Properties.Resources.delete;
            this.delete_Record.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.delete_Record.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete_Record.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.delete_Record.ForeColor = System.Drawing.Color.Wheat;
            this.delete_Record.Location = new System.Drawing.Point(112, 299);
            this.delete_Record.Name = "delete_Record";
            this.delete_Record.Size = new System.Drawing.Size(46, 46);
            this.delete_Record.TabIndex = 78;
            this.delete_Record.UseVisualStyleBackColor = false;
            this.delete_Record.Click += new System.EventHandler(this.delete_Record_Click);
            // 
            // edit_Record
            // 
            this.edit_Record.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.edit_Record.BackgroundImage = global::Курсовая.Properties.Resources.edit;
            this.edit_Record.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.edit_Record.Cursor = System.Windows.Forms.Cursors.Hand;
            this.edit_Record.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.edit_Record.ForeColor = System.Drawing.Color.Wheat;
            this.edit_Record.Location = new System.Drawing.Point(112, 232);
            this.edit_Record.Name = "edit_Record";
            this.edit_Record.Size = new System.Drawing.Size(46, 46);
            this.edit_Record.TabIndex = 77;
            this.edit_Record.UseVisualStyleBackColor = false;
            this.edit_Record.Click += new System.EventHandler(this.edit_Record_Click);
            // 
            // add_Record
            // 
            this.add_Record.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.add_Record.BackgroundImage = global::Курсовая.Properties.Resources.add;
            this.add_Record.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.add_Record.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_Record.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.add_Record.ForeColor = System.Drawing.Color.Wheat;
            this.add_Record.Location = new System.Drawing.Point(112, 165);
            this.add_Record.Name = "add_Record";
            this.add_Record.Size = new System.Drawing.Size(46, 46);
            this.add_Record.TabIndex = 76;
            this.add_Record.UseVisualStyleBackColor = false;
            this.add_Record.Click += new System.EventHandler(this.add_Record_Click);
            // 
            // showAll_Record
            // 
            this.showAll_Record.Location = new System.Drawing.Point(478, 109);
            this.showAll_Record.Name = "showAll_Record";
            this.showAll_Record.Size = new System.Drawing.Size(127, 31);
            this.showAll_Record.TabIndex = 75;
            this.showAll_Record.Text = "Показати всі";
            this.showAll_Record.UseVisualStyleBackColor = true;
            this.showAll_Record.Click += new System.EventHandler(this.showAll_Record_Click);
            // 
            // recordsDataGridView
            // 
            this.recordsDataGridView.AllowUserToAddRows = false;
            this.recordsDataGridView.AllowUserToDeleteRows = false;
            this.recordsDataGridView.AutoGenerateColumns = false;
            this.recordsDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.recordsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.recordsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.recordIDDataGridViewTextBoxColumn,
            this.pupilIDDataGridViewTextBoxColumn,
            this.testIDDataGridViewTextBoxColumn,
            this.scoreDataGridViewTextBoxColumn});
            this.recordsDataGridView.DataSource = this.recordBindingSource;
            this.recordsDataGridView.Location = new System.Drawing.Point(177, 146);
            this.recordsDataGridView.Name = "recordsDataGridView";
            this.recordsDataGridView.ReadOnly = true;
            this.recordsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.recordsDataGridView.Size = new System.Drawing.Size(446, 226);
            this.recordsDataGridView.TabIndex = 74;
            // 
            // schoolCourseDataSet
            // 
            this.schoolCourseDataSet.DataSetName = "SchoolCourseDataSet";
            this.schoolCourseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // recordBindingSource
            // 
            this.recordBindingSource.DataMember = "JournalRecord";
            this.recordBindingSource.DataSource = this.schoolCourseDataSet;
            // 
            // journalRecordTableAdapter
            // 
            this.journalRecordTableAdapter.ClearBeforeFill = true;
            // 
            // recordIDDataGridViewTextBoxColumn
            // 
            this.recordIDDataGridViewTextBoxColumn.DataPropertyName = "Record_ID";
            this.recordIDDataGridViewTextBoxColumn.HeaderText = "ID запису";
            this.recordIDDataGridViewTextBoxColumn.Name = "recordIDDataGridViewTextBoxColumn";
            this.recordIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.recordIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // pupilIDDataGridViewTextBoxColumn
            // 
            this.pupilIDDataGridViewTextBoxColumn.DataPropertyName = "Pupil_ID";
            this.pupilIDDataGridViewTextBoxColumn.HeaderText = "ID учня";
            this.pupilIDDataGridViewTextBoxColumn.Name = "pupilIDDataGridViewTextBoxColumn";
            this.pupilIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.pupilIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // testIDDataGridViewTextBoxColumn
            // 
            this.testIDDataGridViewTextBoxColumn.DataPropertyName = "Test_ID";
            this.testIDDataGridViewTextBoxColumn.HeaderText = "ID контрольної";
            this.testIDDataGridViewTextBoxColumn.Name = "testIDDataGridViewTextBoxColumn";
            this.testIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.testIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // scoreDataGridViewTextBoxColumn
            // 
            this.scoreDataGridViewTextBoxColumn.DataPropertyName = "Score";
            this.scoreDataGridViewTextBoxColumn.HeaderText = "Оцінка";
            this.scoreDataGridViewTextBoxColumn.Name = "scoreDataGridViewTextBoxColumn";
            this.scoreDataGridViewTextBoxColumn.ReadOnly = true;
            this.scoreDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // back_Record
            // 
            this.back_Record.BackColor = System.Drawing.Color.Transparent;
            this.back_Record.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back_Record.Image = global::Курсовая.Properties.Resources.goback;
            this.back_Record.Location = new System.Drawing.Point(39, 551);
            this.back_Record.Name = "back_Record";
            this.back_Record.Size = new System.Drawing.Size(52, 48);
            this.back_Record.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.back_Record.TabIndex = 83;
            this.back_Record.TabStop = false;
            this.back_Record.Click += new System.EventHandler(this.back_Record_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(236, 389);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 18);
            this.label2.TabIndex = 86;
            this.label2.Text = "Сортування";
            // 
            // sortComboBox_Tests
            // 
            this.sortComboBox_Tests.FormattingEnabled = true;
            this.sortComboBox_Tests.Items.AddRange(new object[] {
            "ID контрольної",
            "Абревіатура предмету",
            "Дата написання"});
            this.sortComboBox_Tests.Location = new System.Drawing.Point(200, 444);
            this.sortComboBox_Tests.Name = "sortComboBox_Tests";
            this.sortComboBox_Tests.Size = new System.Drawing.Size(163, 21);
            this.sortComboBox_Tests.TabIndex = 85;
            // 
            // toSort_Tests
            // 
            this.toSort_Tests.Location = new System.Drawing.Point(231, 502);
            this.toSort_Tests.Name = "toSort_Tests";
            this.toSort_Tests.Size = new System.Drawing.Size(97, 27);
            this.toSort_Tests.TabIndex = 84;
            this.toSort_Tests.Text = "Сортувати";
            this.toSort_Tests.UseVisualStyleBackColor = true;
            // 
            // toNumericUpDown_Points
            // 
            this.toNumericUpDown_Points.Location = new System.Drawing.Point(558, 459);
            this.toNumericUpDown_Points.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.toNumericUpDown_Points.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.toNumericUpDown_Points.Name = "toNumericUpDown_Points";
            this.toNumericUpDown_Points.Size = new System.Drawing.Size(54, 20);
            this.toNumericUpDown_Points.TabIndex = 135;
            this.toNumericUpDown_Points.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // fromNumericUpDown_Points
            // 
            this.fromNumericUpDown_Points.Location = new System.Drawing.Point(468, 459);
            this.fromNumericUpDown_Points.Maximum = new decimal(new int[] {
            11,
            0,
            0,
            0});
            this.fromNumericUpDown_Points.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.fromNumericUpDown_Points.Name = "fromNumericUpDown_Points";
            this.fromNumericUpDown_Points.Size = new System.Drawing.Size(54, 20);
            this.fromNumericUpDown_Points.TabIndex = 134;
            this.fromNumericUpDown_Points.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(471, 390);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 18);
            this.label4.TabIndex = 133;
            this.label4.Text = "Фільтрація";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(531, 463);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 15);
            this.label10.TabIndex = 132;
            this.label10.Text = "та";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(424, 463);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 15);
            this.label9.TabIndex = 131;
            this.label9.Text = "Між";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(497, 426);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 18);
            this.label8.TabIndex = 130;
            this.label8.Text = "Оцінка";
            // 
            // toFilter_Points
            // 
            this.toFilter_Points.Location = new System.Drawing.Point(478, 502);
            this.toFilter_Points.Name = "toFilter_Points";
            this.toFilter_Points.Size = new System.Drawing.Size(97, 27);
            this.toFilter_Points.TabIndex = 129;
            this.toFilter_Points.Text = "Фільтрувати";
            this.toFilter_Points.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(756, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 18);
            this.label5.TabIndex = 143;
            this.label5.Text = "Пошук";
            // 
            // phoneCheckBox_PersonnelFiles
            // 
            this.phoneCheckBox_PersonnelFiles.AutoSize = true;
            this.phoneCheckBox_PersonnelFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneCheckBox_PersonnelFiles.Location = new System.Drawing.Point(688, 289);
            this.phoneCheckBox_PersonnelFiles.Name = "phoneCheckBox_PersonnelFiles";
            this.phoneCheckBox_PersonnelFiles.Size = new System.Drawing.Size(65, 19);
            this.phoneCheckBox_PersonnelFiles.TabIndex = 142;
            this.phoneCheckBox_PersonnelFiles.Text = "Оцінка";
            this.phoneCheckBox_PersonnelFiles.UseVisualStyleBackColor = true;
            // 
            // addressCheckBox_PersonnelFiles
            // 
            this.addressCheckBox_PersonnelFiles.AutoSize = true;
            this.addressCheckBox_PersonnelFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addressCheckBox_PersonnelFiles.Location = new System.Drawing.Point(688, 265);
            this.addressCheckBox_PersonnelFiles.Name = "addressCheckBox_PersonnelFiles";
            this.addressCheckBox_PersonnelFiles.Size = new System.Drawing.Size(113, 19);
            this.addressCheckBox_PersonnelFiles.TabIndex = 141;
            this.addressCheckBox_PersonnelFiles.Text = "ID контрольної";
            this.addressCheckBox_PersonnelFiles.UseVisualStyleBackColor = true;
            // 
            // allCheckBox_PersonnelFiles
            // 
            this.allCheckBox_PersonnelFiles.AutoSize = true;
            this.allCheckBox_PersonnelFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.allCheckBox_PersonnelFiles.Location = new System.Drawing.Point(688, 196);
            this.allCheckBox_PersonnelFiles.Name = "allCheckBox_PersonnelFiles";
            this.allCheckBox_PersonnelFiles.Size = new System.Drawing.Size(74, 19);
            this.allCheckBox_PersonnelFiles.TabIndex = 140;
            this.allCheckBox_PersonnelFiles.Text = "Усі поля";
            this.allCheckBox_PersonnelFiles.UseVisualStyleBackColor = true;
            // 
            // idCheckBox_PersonnelFiles
            // 
            this.idCheckBox_PersonnelFiles.AutoSize = true;
            this.idCheckBox_PersonnelFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idCheckBox_PersonnelFiles.Location = new System.Drawing.Point(688, 219);
            this.idCheckBox_PersonnelFiles.Name = "idCheckBox_PersonnelFiles";
            this.idCheckBox_PersonnelFiles.Size = new System.Drawing.Size(79, 19);
            this.idCheckBox_PersonnelFiles.TabIndex = 139;
            this.idCheckBox_PersonnelFiles.Text = "ID запису";
            this.idCheckBox_PersonnelFiles.UseVisualStyleBackColor = true;
            // 
            // toSearch_Pupils
            // 
            this.toSearch_Pupils.Location = new System.Drawing.Point(731, 349);
            this.toSearch_Pupils.Name = "toSearch_Pupils";
            this.toSearch_Pupils.Size = new System.Drawing.Size(97, 27);
            this.toSearch_Pupils.TabIndex = 138;
            this.toSearch_Pupils.Text = "Знайти";
            this.toSearch_Pupils.UseVisualStyleBackColor = true;
            // 
            // snpCheckBox_PersonnelFiles
            // 
            this.snpCheckBox_PersonnelFiles.AutoSize = true;
            this.snpCheckBox_PersonnelFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.snpCheckBox_PersonnelFiles.Location = new System.Drawing.Point(688, 241);
            this.snpCheckBox_PersonnelFiles.Name = "snpCheckBox_PersonnelFiles";
            this.snpCheckBox_PersonnelFiles.Size = new System.Drawing.Size(66, 19);
            this.snpCheckBox_PersonnelFiles.TabIndex = 137;
            this.snpCheckBox_PersonnelFiles.Text = "ID учня";
            this.snpCheckBox_PersonnelFiles.UseVisualStyleBackColor = true;
            // 
            // searchTextBox_PersonnelFiles
            // 
            this.searchTextBox_PersonnelFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchTextBox_PersonnelFiles.Location = new System.Drawing.Point(731, 314);
            this.searchTextBox_PersonnelFiles.Name = "searchTextBox_PersonnelFiles";
            this.searchTextBox_PersonnelFiles.Size = new System.Drawing.Size(97, 21);
            this.searchTextBox_PersonnelFiles.TabIndex = 136;
            // 
            // JournalRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Курсовая.Properties.Resources.back_subject;
            this.ClientSize = new System.Drawing.Size(933, 616);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.phoneCheckBox_PersonnelFiles);
            this.Controls.Add(this.addressCheckBox_PersonnelFiles);
            this.Controls.Add(this.allCheckBox_PersonnelFiles);
            this.Controls.Add(this.idCheckBox_PersonnelFiles);
            this.Controls.Add(this.toSearch_Pupils);
            this.Controls.Add(this.snpCheckBox_PersonnelFiles);
            this.Controls.Add(this.searchTextBox_PersonnelFiles);
            this.Controls.Add(this.toNumericUpDown_Points);
            this.Controls.Add(this.fromNumericUpDown_Points);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.toFilter_Points);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sortComboBox_Tests);
            this.Controls.Add(this.toSort_Tests);
            this.Controls.Add(this.back_Record);
            this.Controls.Add(this.delete_Record);
            this.Controls.Add(this.edit_Record);
            this.Controls.Add(this.add_Record);
            this.Controls.Add(this.showAll_Record);
            this.Controls.Add(this.recordsDataGridView);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.label11);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "JournalRecord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Записи журналу";
            this.Load += new System.EventHandler(this.JournalRecord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recordsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolCourseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recordBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.back_Record)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toNumericUpDown_Points)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromNumericUpDown_Points)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button delete_Record;
        private System.Windows.Forms.Button edit_Record;
        private System.Windows.Forms.Button add_Record;
        private System.Windows.Forms.Button showAll_Record;
        private System.Windows.Forms.DataGridView recordsDataGridView;
        private SchoolCourseDataSet schoolCourseDataSet;
        private System.Windows.Forms.BindingSource recordBindingSource;
        private SchoolCourseDataSetTableAdapters.JournalRecordTableAdapter journalRecordTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn recordIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pupilIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn testIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scoreDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox back_Record;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox sortComboBox_Tests;
        private System.Windows.Forms.Button toSort_Tests;
        private System.Windows.Forms.NumericUpDown toNumericUpDown_Points;
        private System.Windows.Forms.NumericUpDown fromNumericUpDown_Points;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button toFilter_Points;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox phoneCheckBox_PersonnelFiles;
        private System.Windows.Forms.CheckBox addressCheckBox_PersonnelFiles;
        private System.Windows.Forms.CheckBox allCheckBox_PersonnelFiles;
        private System.Windows.Forms.CheckBox idCheckBox_PersonnelFiles;
        private System.Windows.Forms.Button toSearch_Pupils;
        private System.Windows.Forms.CheckBox snpCheckBox_PersonnelFiles;
        private System.Windows.Forms.TextBox searchTextBox_PersonnelFiles;
    }
}