namespace Курсовая
{
    partial class Test
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
            System.Windows.Forms.Label subject_abbrLabel;
            System.Windows.Forms.Label test_dateLabel;
            this.Cancel_Test = new System.Windows.Forms.Button();
            this.OK_Test = new System.Windows.Forms.Button();
            this.schoolCourseDataSet = new Курсовая.SchoolCourseDataSet();
            this.subject_abbrComboBox = new System.Windows.Forms.ComboBox();
            this.test_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.subjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.subjectTableAdapter = new Курсовая.SchoolCourseDataSetTableAdapters.SubjectTableAdapter();
            this.testBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testTableAdapter = new Курсовая.SchoolCourseDataSetTableAdapters.TestTableAdapter();
            subject_abbrLabel = new System.Windows.Forms.Label();
            test_dateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.schoolCourseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Cancel_Test
            // 
            this.Cancel_Test.Location = new System.Drawing.Point(216, 166);
            this.Cancel_Test.Name = "Cancel_Test";
            this.Cancel_Test.Size = new System.Drawing.Size(75, 23);
            this.Cancel_Test.TabIndex = 9;
            this.Cancel_Test.Text = "Відміна";
            this.Cancel_Test.UseVisualStyleBackColor = true;
            this.Cancel_Test.Click += new System.EventHandler(this.Cancel_Test_Click);
            // 
            // OK_Test
            // 
            this.OK_Test.Location = new System.Drawing.Point(73, 166);
            this.OK_Test.Name = "OK_Test";
            this.OK_Test.Size = new System.Drawing.Size(75, 23);
            this.OK_Test.TabIndex = 8;
            this.OK_Test.Text = "ОК";
            this.OK_Test.UseVisualStyleBackColor = true;
            this.OK_Test.Click += new System.EventHandler(this.OK_Test_Click);
            // 
            // schoolCourseDataSet
            // 
            this.schoolCourseDataSet.DataSetName = "SchoolCourseDataSet";
            this.schoolCourseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // subject_abbrLabel
            // 
            subject_abbrLabel.AutoSize = true;
            subject_abbrLabel.Location = new System.Drawing.Point(12, 58);
            subject_abbrLabel.Name = "subject_abbrLabel";
            subject_abbrLabel.Size = new System.Drawing.Size(122, 13);
            subject_abbrLabel.TabIndex = 10;
            subject_abbrLabel.Text = "Абревіатура предмету:";
            // 
            // subject_abbrComboBox
            // 
            this.subject_abbrComboBox.DataSource = this.subjectBindingSource;
            this.subject_abbrComboBox.DisplayMember = "Subject_abbr";
            this.subject_abbrComboBox.FormattingEnabled = true;
            this.subject_abbrComboBox.Location = new System.Drawing.Point(140, 55);
            this.subject_abbrComboBox.Name = "subject_abbrComboBox";
            this.subject_abbrComboBox.Size = new System.Drawing.Size(133, 21);
            this.subject_abbrComboBox.TabIndex = 11;
            // 
            // test_dateLabel
            // 
            test_dateLabel.AutoSize = true;
            test_dateLabel.Location = new System.Drawing.Point(12, 108);
            test_dateLabel.Name = "test_dateLabel";
            test_dateLabel.Size = new System.Drawing.Size(101, 13);
            test_dateLabel.TabIndex = 11;
            test_dateLabel.Text = "Дата контрольної:";
            // 
            // test_dateDateTimePicker
            // 
            this.test_dateDateTimePicker.Location = new System.Drawing.Point(140, 102);
            this.test_dateDateTimePicker.Name = "test_dateDateTimePicker";
            this.test_dateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.test_dateDateTimePicker.TabIndex = 12;
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
            // testBindingSource
            // 
            this.testBindingSource.DataMember = "Test";
            this.testBindingSource.DataSource = this.schoolCourseDataSet;
            // 
            // testTableAdapter
            // 
            this.testTableAdapter.ClearBeforeFill = true;
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 216);
            this.Controls.Add(test_dateLabel);
            this.Controls.Add(this.test_dateDateTimePicker);
            this.Controls.Add(subject_abbrLabel);
            this.Controls.Add(this.subject_abbrComboBox);
            this.Controls.Add(this.Cancel_Test);
            this.Controls.Add(this.OK_Test);
            this.Name = "Test";
            this.Text = "Контрольна робота";
            this.Load += new System.EventHandler(this.Test_Load);
            ((System.ComponentModel.ISupportInitialize)(this.schoolCourseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cancel_Test;
        private System.Windows.Forms.Button OK_Test;
        private SchoolCourseDataSet schoolCourseDataSet;
        private System.Windows.Forms.ComboBox subject_abbrComboBox;
        private System.Windows.Forms.DateTimePicker test_dateDateTimePicker;
        private System.Windows.Forms.BindingSource subjectBindingSource;
        private SchoolCourseDataSetTableAdapters.SubjectTableAdapter subjectTableAdapter;
        private System.Windows.Forms.BindingSource testBindingSource;
        private SchoolCourseDataSetTableAdapters.TestTableAdapter testTableAdapter;
    }
}