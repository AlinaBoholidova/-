namespace Курсовая
{
    partial class AdditionalActivityData
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
            System.Windows.Forms.Label activity_nameLabel;
            System.Windows.Forms.Label activity_dateLabel;
            this.Cancel_AddActivity = new System.Windows.Forms.Button();
            this.OK_AddActivity = new System.Windows.Forms.Button();
            this.schoolCourseDataSet = new Курсовая.SchoolCourseDataSet();
            this.additionalActivityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.additionalActivityTableAdapter = new Курсовая.SchoolCourseDataSetTableAdapters.AdditionalActivityTableAdapter();
            this.tableAdapterManager = new Курсовая.SchoolCourseDataSetTableAdapters.TableAdapterManager();
            this.activity_nameTextBox = new System.Windows.Forms.TextBox();
            this.activity_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            activity_nameLabel = new System.Windows.Forms.Label();
            activity_dateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.schoolCourseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.additionalActivityBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Cancel_AddActivity
            // 
            this.Cancel_AddActivity.Location = new System.Drawing.Point(256, 171);
            this.Cancel_AddActivity.Name = "Cancel_AddActivity";
            this.Cancel_AddActivity.Size = new System.Drawing.Size(75, 23);
            this.Cancel_AddActivity.TabIndex = 15;
            this.Cancel_AddActivity.Text = "Відміна";
            this.Cancel_AddActivity.UseVisualStyleBackColor = true;
            this.Cancel_AddActivity.Click += new System.EventHandler(this.Cancel_AddActivity_Click);
            // 
            // OK_AddActivity
            // 
            this.OK_AddActivity.Location = new System.Drawing.Point(113, 171);
            this.OK_AddActivity.Name = "OK_AddActivity";
            this.OK_AddActivity.Size = new System.Drawing.Size(75, 23);
            this.OK_AddActivity.TabIndex = 14;
            this.OK_AddActivity.Text = "ОК";
            this.OK_AddActivity.UseVisualStyleBackColor = true;
            this.OK_AddActivity.Click += new System.EventHandler(this.OK_AddActivity_Click);
            // 
            // schoolCourseDataSet
            // 
            this.schoolCourseDataSet.DataSetName = "SchoolCourseDataSet";
            this.schoolCourseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // additionalActivityBindingSource
            // 
            this.additionalActivityBindingSource.DataMember = "AdditionalActivity";
            this.additionalActivityBindingSource.DataSource = this.schoolCourseDataSet;
            // 
            // additionalActivityTableAdapter
            // 
            this.additionalActivityTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdditionalActivityTableAdapter = this.additionalActivityTableAdapter;
            this.tableAdapterManager.AdditionalParticipationTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.JournalRecordTableAdapter = null;
            this.tableAdapterManager.PaymentRateTableAdapter = null;
            this.tableAdapterManager.PaymentTableAdapter = null;
            this.tableAdapterManager.PersonnelFileTableAdapter = null;
            this.tableAdapterManager.PointsDistributionTableAdapter = null;
            this.tableAdapterManager.PupilTableAdapter = null;
            this.tableAdapterManager.SubjectTableAdapter = null;
            this.tableAdapterManager.TestTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Курсовая.SchoolCourseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserTableAdapter = null;
            // 
            // activity_nameLabel
            // 
            activity_nameLabel.AutoSize = true;
            activity_nameLabel.Location = new System.Drawing.Point(46, 45);
            activity_nameLabel.Name = "activity_nameLabel";
            activity_nameLabel.Size = new System.Drawing.Size(73, 13);
            activity_nameLabel.TabIndex = 16;
            activity_nameLabel.Text = "Activity name:";
            // 
            // activity_nameTextBox
            // 
            this.activity_nameTextBox.Location = new System.Drawing.Point(145, 45);
            this.activity_nameTextBox.Name = "activity_nameTextBox";
            this.activity_nameTextBox.Size = new System.Drawing.Size(240, 20);
            this.activity_nameTextBox.TabIndex = 17;
            // 
            // activity_dateLabel
            // 
            activity_dateLabel.AutoSize = true;
            activity_dateLabel.Location = new System.Drawing.Point(46, 105);
            activity_dateLabel.Name = "activity_dateLabel";
            activity_dateLabel.Size = new System.Drawing.Size(68, 13);
            activity_dateLabel.TabIndex = 17;
            activity_dateLabel.Text = "Activity date:";
            // 
            // activity_dateDateTimePicker
            // 
            this.activity_dateDateTimePicker.Location = new System.Drawing.Point(145, 99);
            this.activity_dateDateTimePicker.MaxDate = new System.DateTime(2021, 5, 28, 0, 0, 0, 0);
            this.activity_dateDateTimePicker.MinDate = new System.DateTime(2020, 9, 1, 0, 0, 0, 0);
            this.activity_dateDateTimePicker.Name = "activity_dateDateTimePicker";
            this.activity_dateDateTimePicker.Size = new System.Drawing.Size(240, 20);
            this.activity_dateDateTimePicker.TabIndex = 18;
            // 
            // AdditionalActivityData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 239);
            this.Controls.Add(activity_dateLabel);
            this.Controls.Add(this.activity_dateDateTimePicker);
            this.Controls.Add(activity_nameLabel);
            this.Controls.Add(this.activity_nameTextBox);
            this.Controls.Add(this.Cancel_AddActivity);
            this.Controls.Add(this.OK_AddActivity);
            this.Name = "AdditionalActivityData";
            this.Text = "Додаткова активність";
            this.Load += new System.EventHandler(this.AdditionalActivityData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.schoolCourseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.additionalActivityBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cancel_AddActivity;
        private System.Windows.Forms.Button OK_AddActivity;
        private SchoolCourseDataSet schoolCourseDataSet;
        private System.Windows.Forms.BindingSource additionalActivityBindingSource;
        private SchoolCourseDataSetTableAdapters.AdditionalActivityTableAdapter additionalActivityTableAdapter;
        private SchoolCourseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox activity_nameTextBox;
        private System.Windows.Forms.DateTimePicker activity_dateDateTimePicker;
    }
}