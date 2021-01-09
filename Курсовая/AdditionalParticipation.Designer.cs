namespace Курсовая
{
    partial class AdditionalParticipation
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
            System.Windows.Forms.Label pupil_ID;
            System.Windows.Forms.Label activity_ID;
            System.Windows.Forms.Label distribution_ID;
            this.Cancel_Participation = new System.Windows.Forms.Button();
            this.OK_Participation = new System.Windows.Forms.Button();
            this.schoolCourseDataSet = new Курсовая.SchoolCourseDataSet();
            this.additionalParticipationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.additionalParticipationTableAdapter = new Курсовая.SchoolCourseDataSetTableAdapters.AdditionalParticipationTableAdapter();
            this.tableAdapterManager = new Курсовая.SchoolCourseDataSetTableAdapters.TableAdapterManager();
            this.pupil_IDComboBox = new System.Windows.Forms.ComboBox();
            this.activity_IDComboBox = new System.Windows.Forms.ComboBox();
            this.distribution_IDComboBox = new System.Windows.Forms.ComboBox();
            this.pupil_IDLabel = new System.Windows.Forms.Label();
            this.activity_IDLabel = new System.Windows.Forms.Label();
            this.distribution_IDLabel = new System.Windows.Forms.Label();
            this.pupilBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pupilTableAdapter = new Курсовая.SchoolCourseDataSetTableAdapters.PupilTableAdapter();
            this.activityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.additionalActivityTableAdapter = new Курсовая.SchoolCourseDataSetTableAdapters.AdditionalActivityTableAdapter();
            this.distributionBndingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pointsDistributionTableAdapter = new Курсовая.SchoolCourseDataSetTableAdapters.PointsDistributionTableAdapter();
            pupil_ID = new System.Windows.Forms.Label();
            activity_ID = new System.Windows.Forms.Label();
            distribution_ID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.schoolCourseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.additionalParticipationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pupilBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.distributionBndingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Cancel_Participation
            // 
            this.Cancel_Participation.Location = new System.Drawing.Point(305, 205);
            this.Cancel_Participation.Name = "Cancel_Participation";
            this.Cancel_Participation.Size = new System.Drawing.Size(75, 23);
            this.Cancel_Participation.TabIndex = 15;
            this.Cancel_Participation.Text = "Відміна";
            this.Cancel_Participation.UseVisualStyleBackColor = true;
            this.Cancel_Participation.Click += new System.EventHandler(this.Cancel_Participation_Click);
            // 
            // OK_Participation
            // 
            this.OK_Participation.Location = new System.Drawing.Point(162, 205);
            this.OK_Participation.Name = "OK_Participation";
            this.OK_Participation.Size = new System.Drawing.Size(75, 23);
            this.OK_Participation.TabIndex = 14;
            this.OK_Participation.Text = "ОК";
            this.OK_Participation.UseVisualStyleBackColor = true;
            this.OK_Participation.Click += new System.EventHandler(this.OK_Participation_Click);
            // 
            // schoolCourseDataSet
            // 
            this.schoolCourseDataSet.DataSetName = "SchoolCourseDataSet";
            this.schoolCourseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // additionalParticipationBindingSource
            // 
            this.additionalParticipationBindingSource.DataMember = "AdditionalParticipation";
            this.additionalParticipationBindingSource.DataSource = this.schoolCourseDataSet;
            // 
            // additionalParticipationTableAdapter
            // 
            this.additionalParticipationTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdditionalActivityTableAdapter = this.additionalActivityTableAdapter;
            this.tableAdapterManager.AdditionalParticipationTableAdapter = this.additionalParticipationTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.JournalRecordTableAdapter = null;
            this.tableAdapterManager.PaymentRateTableAdapter = null;
            this.tableAdapterManager.PaymentTableAdapter = null;
            this.tableAdapterManager.PersonnelFileTableAdapter = null;
            this.tableAdapterManager.PointsDistributionTableAdapter = this.pointsDistributionTableAdapter;
            this.tableAdapterManager.PupilTableAdapter = this.pupilTableAdapter;
            this.tableAdapterManager.SubjectTableAdapter = null;
            this.tableAdapterManager.TestTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Курсовая.SchoolCourseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserTableAdapter = null;
            // 
            // pupil_ID
            // 
            pupil_ID.AutoSize = true;
            pupil_ID.Location = new System.Drawing.Point(22, 42);
            pupil_ID.Name = "pupil_ID";
            pupil_ID.Size = new System.Drawing.Size(47, 13);
            pupil_ID.TabIndex = 16;
            pupil_ID.Text = "Pupil ID:";
            // 
            // pupil_IDComboBox
            // 
            this.pupil_IDComboBox.DataSource = this.pupilBindingSource;
            this.pupil_IDComboBox.DisplayMember = "Pupil_ID";
            this.pupil_IDComboBox.FormattingEnabled = true;
            this.pupil_IDComboBox.Location = new System.Drawing.Point(104, 37);
            this.pupil_IDComboBox.Name = "pupil_IDComboBox";
            this.pupil_IDComboBox.Size = new System.Drawing.Size(121, 21);
            this.pupil_IDComboBox.TabIndex = 17;
            this.pupil_IDComboBox.SelectedIndexChanged += new System.EventHandler(this.pupil_IDComboBox_SelectedIndexChanged);
            // 
            // activity_ID
            // 
            activity_ID.AutoSize = true;
            activity_ID.Location = new System.Drawing.Point(22, 89);
            activity_ID.Name = "activity_ID";
            activity_ID.Size = new System.Drawing.Size(58, 13);
            activity_ID.TabIndex = 17;
            activity_ID.Text = "Activity ID:";
            // 
            // activity_IDComboBox
            // 
            this.activity_IDComboBox.DataSource = this.activityBindingSource;
            this.activity_IDComboBox.DisplayMember = "Activity_ID";
            this.activity_IDComboBox.FormattingEnabled = true;
            this.activity_IDComboBox.Location = new System.Drawing.Point(104, 81);
            this.activity_IDComboBox.Name = "activity_IDComboBox";
            this.activity_IDComboBox.Size = new System.Drawing.Size(121, 21);
            this.activity_IDComboBox.TabIndex = 18;
            this.activity_IDComboBox.SelectedIndexChanged += new System.EventHandler(this.activity_IDComboBox_SelectedIndexChanged);
            // 
            // distribution_ID
            // 
            distribution_ID.AutoSize = true;
            distribution_ID.Location = new System.Drawing.Point(22, 136);
            distribution_ID.Name = "distribution_ID";
            distribution_ID.Size = new System.Drawing.Size(76, 13);
            distribution_ID.TabIndex = 18;
            distribution_ID.Text = "Distribution ID:";
            // 
            // distribution_IDComboBox
            // 
            this.distribution_IDComboBox.DataSource = this.distributionBndingSource;
            this.distribution_IDComboBox.DisplayMember = "Distribution_ID";
            this.distribution_IDComboBox.FormattingEnabled = true;
            this.distribution_IDComboBox.Location = new System.Drawing.Point(104, 128);
            this.distribution_IDComboBox.Name = "distribution_IDComboBox";
            this.distribution_IDComboBox.Size = new System.Drawing.Size(121, 21);
            this.distribution_IDComboBox.TabIndex = 19;
            this.distribution_IDComboBox.SelectedIndexChanged += new System.EventHandler(this.distribution_IDComboBox_SelectedIndexChanged);
            // 
            // pupil_IDLabel
            // 
            this.pupil_IDLabel.AutoSize = true;
            this.pupil_IDLabel.Location = new System.Drawing.Point(288, 45);
            this.pupil_IDLabel.Name = "pupil_IDLabel";
            this.pupil_IDLabel.Size = new System.Drawing.Size(35, 13);
            this.pupil_IDLabel.TabIndex = 20;
            this.pupil_IDLabel.Text = "label1";
            // 
            // activity_IDLabel
            // 
            this.activity_IDLabel.AutoSize = true;
            this.activity_IDLabel.Location = new System.Drawing.Point(288, 89);
            this.activity_IDLabel.Name = "activity_IDLabel";
            this.activity_IDLabel.Size = new System.Drawing.Size(35, 13);
            this.activity_IDLabel.TabIndex = 21;
            this.activity_IDLabel.Text = "label2";
            // 
            // distribution_IDLabel
            // 
            this.distribution_IDLabel.AutoSize = true;
            this.distribution_IDLabel.Location = new System.Drawing.Point(288, 136);
            this.distribution_IDLabel.Name = "distribution_IDLabel";
            this.distribution_IDLabel.Size = new System.Drawing.Size(35, 13);
            this.distribution_IDLabel.TabIndex = 22;
            this.distribution_IDLabel.Text = "label3";
            // 
            // pupilBindingSource
            // 
            this.pupilBindingSource.DataMember = "Pupil";
            this.pupilBindingSource.DataSource = this.schoolCourseDataSet;
            // 
            // pupilTableAdapter
            // 
            this.pupilTableAdapter.ClearBeforeFill = true;
            // 
            // activityBindingSource
            // 
            this.activityBindingSource.DataMember = "AdditionalActivity";
            this.activityBindingSource.DataSource = this.schoolCourseDataSet;
            // 
            // additionalActivityTableAdapter
            // 
            this.additionalActivityTableAdapter.ClearBeforeFill = true;
            // 
            // distributionBndingSource
            // 
            this.distributionBndingSource.DataMember = "PointsDistribution";
            this.distributionBndingSource.DataSource = this.schoolCourseDataSet;
            // 
            // pointsDistributionTableAdapter
            // 
            this.pointsDistributionTableAdapter.ClearBeforeFill = true;
            // 
            // AdditionalParticipation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 261);
            this.Controls.Add(this.distribution_IDLabel);
            this.Controls.Add(this.activity_IDLabel);
            this.Controls.Add(this.pupil_IDLabel);
            this.Controls.Add(distribution_ID);
            this.Controls.Add(this.distribution_IDComboBox);
            this.Controls.Add(activity_ID);
            this.Controls.Add(this.activity_IDComboBox);
            this.Controls.Add(pupil_ID);
            this.Controls.Add(this.pupil_IDComboBox);
            this.Controls.Add(this.Cancel_Participation);
            this.Controls.Add(this.OK_Participation);
            this.Name = "AdditionalParticipation";
            this.Text = "Додаткова участь";
            this.Load += new System.EventHandler(this.AdditionalParticipation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.schoolCourseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.additionalParticipationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pupilBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.distributionBndingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cancel_Participation;
        private System.Windows.Forms.Button OK_Participation;
        private SchoolCourseDataSet schoolCourseDataSet;
        private System.Windows.Forms.BindingSource additionalParticipationBindingSource;
        private SchoolCourseDataSetTableAdapters.AdditionalParticipationTableAdapter additionalParticipationTableAdapter;
        private SchoolCourseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox pupil_IDComboBox;
        private System.Windows.Forms.ComboBox activity_IDComboBox;
        private System.Windows.Forms.ComboBox distribution_IDComboBox;
        private System.Windows.Forms.Label pupil_IDLabel;
        private System.Windows.Forms.Label activity_IDLabel;
        private System.Windows.Forms.Label distribution_IDLabel;
        private SchoolCourseDataSetTableAdapters.PupilTableAdapter pupilTableAdapter;
        private System.Windows.Forms.BindingSource pupilBindingSource;
        private SchoolCourseDataSetTableAdapters.AdditionalActivityTableAdapter additionalActivityTableAdapter;
        private System.Windows.Forms.BindingSource activityBindingSource;
        private SchoolCourseDataSetTableAdapters.PointsDistributionTableAdapter pointsDistributionTableAdapter;
        private System.Windows.Forms.BindingSource distributionBndingSource;
    }
}