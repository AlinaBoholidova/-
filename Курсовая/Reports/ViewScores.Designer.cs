namespace Курсовая
{
    partial class ViewScores
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
            this.scoresDataGridView = new System.Windows.Forms.DataGridView();
            this.scoresReportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.idComboBox = new System.Windows.Forms.ComboBox();
            this.pupilBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.schoolCourseDataSet = new Курсовая.SchoolCourseDataSet();
            this.SNPlabel = new System.Windows.Forms.Label();
            this.previewButton = new System.Windows.Forms.Button();
            this.fromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.toDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.timeCheckBox = new System.Windows.Forms.CheckBox();
            this.pupilTableAdapter = new Курсовая.SchoolCourseDataSetTableAdapters.PupilTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.back_Subjects = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.scoresDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pupilBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolCourseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // scoresDataGridView
            // 
            this.scoresDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.scoresDataGridView.Location = new System.Drawing.Point(12, 83);
            this.scoresDataGridView.Name = "scoresDataGridView";
            this.scoresDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.scoresDataGridView.Size = new System.Drawing.Size(391, 233);
            this.scoresDataGridView.TabIndex = 0;
            // 
            // scoresReportViewer
            // 
            this.scoresReportViewer.LocalReport.ReportEmbeddedResource = "Курсовая.Scores.rdlc";
            this.scoresReportViewer.Location = new System.Drawing.Point(445, 33);
            this.scoresReportViewer.Name = "scoresReportViewer";
            this.scoresReportViewer.ServerReport.BearerToken = null;
            this.scoresReportViewer.Size = new System.Drawing.Size(434, 312);
            this.scoresReportViewer.TabIndex = 1;
            // 
            // idComboBox
            // 
            this.idComboBox.DataSource = this.pupilBindingSource;
            this.idComboBox.DisplayMember = "Pupil_ID";
            this.idComboBox.FormattingEnabled = true;
            this.idComboBox.Location = new System.Drawing.Point(59, 34);
            this.idComboBox.Name = "idComboBox";
            this.idComboBox.Size = new System.Drawing.Size(55, 21);
            this.idComboBox.TabIndex = 2;
            this.idComboBox.SelectedIndexChanged += new System.EventHandler(this.idComboBox_SelectedIndexChanged);
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
            // SNPlabel
            // 
            this.SNPlabel.AutoSize = true;
            this.SNPlabel.Location = new System.Drawing.Point(129, 40);
            this.SNPlabel.Name = "SNPlabel";
            this.SNPlabel.Size = new System.Drawing.Size(35, 13);
            this.SNPlabel.TabIndex = 3;
            this.SNPlabel.Text = "label1";
            // 
            // previewButton
            // 
            this.previewButton.Location = new System.Drawing.Point(309, 22);
            this.previewButton.Name = "previewButton";
            this.previewButton.Size = new System.Drawing.Size(94, 49);
            this.previewButton.TabIndex = 4;
            this.previewButton.Text = "Перегляд виписки оцінок";
            this.previewButton.UseVisualStyleBackColor = true;
            this.previewButton.Click += new System.EventHandler(this.previewButton_Click);
            // 
            // fromDateTimePicker
            // 
            this.fromDateTimePicker.Location = new System.Drawing.Point(48, 378);
            this.fromDateTimePicker.Name = "fromDateTimePicker";
            this.fromDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fromDateTimePicker.TabIndex = 5;
            // 
            // toDateTimePicker
            // 
            this.toDateTimePicker.Location = new System.Drawing.Point(298, 378);
            this.toDateTimePicker.Name = "toDateTimePicker";
            this.toDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.toDateTimePicker.TabIndex = 6;
            // 
            // timeCheckBox
            // 
            this.timeCheckBox.AutoSize = true;
            this.timeCheckBox.Location = new System.Drawing.Point(634, 378);
            this.timeCheckBox.Name = "timeCheckBox";
            this.timeCheckBox.Size = new System.Drawing.Size(86, 17);
            this.timeCheckBox.TabIndex = 9;
            this.timeCheckBox.Text = "За весь час";
            this.timeCheckBox.UseVisualStyleBackColor = true;
            // 
            // pupilTableAdapter
            // 
            this.pupilTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "ID учня:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 378);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Між";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(263, 382);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "та";
            // 
            // back_Subjects
            // 
            this.back_Subjects.Location = new System.Drawing.Point(15, 404);
            this.back_Subjects.Name = "back_Subjects";
            this.back_Subjects.Size = new System.Drawing.Size(105, 31);
            this.back_Subjects.TabIndex = 13;
            this.back_Subjects.Text = "Повернутися";
            this.back_Subjects.UseVisualStyleBackColor = true;
            this.back_Subjects.Click += new System.EventHandler(this.back_Subjects_Click);
            // 
            // ViewScores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 446);
            this.Controls.Add(this.back_Subjects);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.timeCheckBox);
            this.Controls.Add(this.toDateTimePicker);
            this.Controls.Add(this.fromDateTimePicker);
            this.Controls.Add(this.previewButton);
            this.Controls.Add(this.SNPlabel);
            this.Controls.Add(this.idComboBox);
            this.Controls.Add(this.scoresReportViewer);
            this.Controls.Add(this.scoresDataGridView);
            this.Name = "ViewScores";
            this.Text = "ViewScores";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ViewScores_FormClosing);
            this.Load += new System.EventHandler(this.ViewScores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.scoresDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pupilBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolCourseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView scoresDataGridView;
        private Microsoft.Reporting.WinForms.ReportViewer scoresReportViewer;
        private System.Windows.Forms.ComboBox idComboBox;
        private System.Windows.Forms.Label SNPlabel;
        private System.Windows.Forms.Button previewButton;
        private System.Windows.Forms.DateTimePicker fromDateTimePicker;
        private System.Windows.Forms.DateTimePicker toDateTimePicker;
        private System.Windows.Forms.CheckBox timeCheckBox;
        private SchoolCourseDataSet schoolCourseDataSet;
        private System.Windows.Forms.BindingSource pupilBindingSource;
        private SchoolCourseDataSetTableAdapters.PupilTableAdapter pupilTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button back_Subjects;
    }
}