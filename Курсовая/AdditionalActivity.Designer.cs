namespace Курсовая
{
    partial class AdditionalActivity
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
            this.delete_Activity = new System.Windows.Forms.Button();
            this.change_Activity = new System.Windows.Forms.Button();
            this.add_Activity = new System.Windows.Forms.Button();
            this.showAll_Activity = new System.Windows.Forms.Button();
            this.delete_Participation = new System.Windows.Forms.Button();
            this.change_Participation = new System.Windows.Forms.Button();
            this.add_Participation = new System.Windows.Forms.Button();
            this.showAll_Participation = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.activityDataGridView = new System.Windows.Forms.DataGridView();
            this.participationDataGridView = new System.Windows.Forms.DataGridView();
            this.back_AddActivity = new System.Windows.Forms.Button();
            this.activityIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activitynameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activitydateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.schoolCourseDataSet = new Курсовая.SchoolCourseDataSet();
            this.pupilIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activityIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.distributionIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.participationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.additionalParticipationTableAdapter = new Курсовая.SchoolCourseDataSetTableAdapters.AdditionalParticipationTableAdapter();
            this.additionalActivityTableAdapter = new Курсовая.SchoolCourseDataSetTableAdapters.AdditionalActivityTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.activityDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.participationDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolCourseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.participationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // delete_Activity
            // 
            this.delete_Activity.Location = new System.Drawing.Point(813, 51);
            this.delete_Activity.Name = "delete_Activity";
            this.delete_Activity.Size = new System.Drawing.Size(106, 34);
            this.delete_Activity.TabIndex = 76;
            this.delete_Activity.Text = "Видалити активність";
            this.delete_Activity.UseVisualStyleBackColor = true;
            this.delete_Activity.Click += new System.EventHandler(this.delete_Activity_Click);
            // 
            // change_Activity
            // 
            this.change_Activity.Location = new System.Drawing.Point(711, 51);
            this.change_Activity.Name = "change_Activity";
            this.change_Activity.Size = new System.Drawing.Size(96, 34);
            this.change_Activity.TabIndex = 75;
            this.change_Activity.Text = "Змінити дані";
            this.change_Activity.UseVisualStyleBackColor = true;
            this.change_Activity.Click += new System.EventHandler(this.change_Activity_Click);
            // 
            // add_Activity
            // 
            this.add_Activity.Location = new System.Drawing.Point(609, 51);
            this.add_Activity.Name = "add_Activity";
            this.add_Activity.Size = new System.Drawing.Size(96, 34);
            this.add_Activity.TabIndex = 74;
            this.add_Activity.Text = "Додати активність";
            this.add_Activity.UseVisualStyleBackColor = true;
            this.add_Activity.Click += new System.EventHandler(this.add_Activity_Click);
            // 
            // showAll_Activity
            // 
            this.showAll_Activity.Location = new System.Drawing.Point(494, 55);
            this.showAll_Activity.Name = "showAll_Activity";
            this.showAll_Activity.Size = new System.Drawing.Size(109, 27);
            this.showAll_Activity.TabIndex = 73;
            this.showAll_Activity.Text = "Показати всі";
            this.showAll_Activity.UseVisualStyleBackColor = true;
            this.showAll_Activity.Click += new System.EventHandler(this.showAll_Activity_Click);
            // 
            // delete_Participation
            // 
            this.delete_Participation.Location = new System.Drawing.Point(351, 51);
            this.delete_Participation.Name = "delete_Participation";
            this.delete_Participation.Size = new System.Drawing.Size(106, 34);
            this.delete_Participation.TabIndex = 72;
            this.delete_Participation.Text = "Видалити участь";
            this.delete_Participation.UseVisualStyleBackColor = true;
            this.delete_Participation.Click += new System.EventHandler(this.delete_Participation_Click);
            // 
            // change_Participation
            // 
            this.change_Participation.Location = new System.Drawing.Point(249, 51);
            this.change_Participation.Name = "change_Participation";
            this.change_Participation.Size = new System.Drawing.Size(96, 34);
            this.change_Participation.TabIndex = 71;
            this.change_Participation.Text = "Змінити дані";
            this.change_Participation.UseVisualStyleBackColor = true;
            this.change_Participation.Click += new System.EventHandler(this.change_Participation_Click);
            // 
            // add_Participation
            // 
            this.add_Participation.Location = new System.Drawing.Point(147, 51);
            this.add_Participation.Name = "add_Participation";
            this.add_Participation.Size = new System.Drawing.Size(96, 34);
            this.add_Participation.TabIndex = 70;
            this.add_Participation.Text = "Додати участь";
            this.add_Participation.UseVisualStyleBackColor = true;
            this.add_Participation.Click += new System.EventHandler(this.add_Participation_Click);
            // 
            // showAll_Participation
            // 
            this.showAll_Participation.Location = new System.Drawing.Point(19, 58);
            this.showAll_Participation.Name = "showAll_Participation";
            this.showAll_Participation.Size = new System.Drawing.Size(109, 27);
            this.showAll_Participation.TabIndex = 69;
            this.showAll_Participation.Text = "Показати всі";
            this.showAll_Participation.UseVisualStyleBackColor = true;
            this.showAll_Participation.Click += new System.EventHandler(this.showAll_Participation_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(490, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 68;
            this.label2.Text = "Додаткова активність";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 67;
            this.label1.Text = "Додаткова участь";
            // 
            // activityDataGridView
            // 
            this.activityDataGridView.AllowUserToAddRows = false;
            this.activityDataGridView.AllowUserToDeleteRows = false;
            this.activityDataGridView.AutoGenerateColumns = false;
            this.activityDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.activityDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.activityIDDataGridViewTextBoxColumn1,
            this.activitynameDataGridViewTextBoxColumn,
            this.activitydateDataGridViewTextBoxColumn});
            this.activityDataGridView.DataSource = this.activityBindingSource;
            this.activityDataGridView.Location = new System.Drawing.Point(476, 91);
            this.activityDataGridView.Name = "activityDataGridView";
            this.activityDataGridView.ReadOnly = true;
            this.activityDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.activityDataGridView.Size = new System.Drawing.Size(445, 180);
            this.activityDataGridView.TabIndex = 66;
            // 
            // participationDataGridView
            // 
            this.participationDataGridView.AllowUserToAddRows = false;
            this.participationDataGridView.AllowUserToDeleteRows = false;
            this.participationDataGridView.AutoGenerateColumns = false;
            this.participationDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.participationDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pupilIDDataGridViewTextBoxColumn,
            this.activityIDDataGridViewTextBoxColumn,
            this.distributionIDDataGridViewTextBoxColumn});
            this.participationDataGridView.DataSource = this.participationBindingSource;
            this.participationDataGridView.Location = new System.Drawing.Point(19, 91);
            this.participationDataGridView.Name = "participationDataGridView";
            this.participationDataGridView.ReadOnly = true;
            this.participationDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.participationDataGridView.Size = new System.Drawing.Size(311, 180);
            this.participationDataGridView.TabIndex = 65;
            // 
            // back_AddActivity
            // 
            this.back_AddActivity.Location = new System.Drawing.Point(12, 475);
            this.back_AddActivity.Name = "back_AddActivity";
            this.back_AddActivity.Size = new System.Drawing.Size(105, 31);
            this.back_AddActivity.TabIndex = 77;
            this.back_AddActivity.Text = "Повернутися";
            this.back_AddActivity.UseVisualStyleBackColor = true;
            this.back_AddActivity.Click += new System.EventHandler(this.back_AddActivity_Click);
            // 
            // activityIDDataGridViewTextBoxColumn1
            // 
            this.activityIDDataGridViewTextBoxColumn1.DataPropertyName = "Activity_ID";
            this.activityIDDataGridViewTextBoxColumn1.HeaderText = "ID активності";
            this.activityIDDataGridViewTextBoxColumn1.Name = "activityIDDataGridViewTextBoxColumn1";
            this.activityIDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.activityIDDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // activitynameDataGridViewTextBoxColumn
            // 
            this.activitynameDataGridViewTextBoxColumn.DataPropertyName = "Activity_name";
            this.activitynameDataGridViewTextBoxColumn.HeaderText = "Назва активності";
            this.activitynameDataGridViewTextBoxColumn.Name = "activitynameDataGridViewTextBoxColumn";
            this.activitynameDataGridViewTextBoxColumn.ReadOnly = true;
            this.activitynameDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // activitydateDataGridViewTextBoxColumn
            // 
            this.activitydateDataGridViewTextBoxColumn.DataPropertyName = "Activity_date";
            this.activitydateDataGridViewTextBoxColumn.HeaderText = "Дата активності";
            this.activitydateDataGridViewTextBoxColumn.Name = "activitydateDataGridViewTextBoxColumn";
            this.activitydateDataGridViewTextBoxColumn.ReadOnly = true;
            this.activitydateDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // activityBindingSource
            // 
            this.activityBindingSource.DataMember = "AdditionalActivity";
            this.activityBindingSource.DataSource = this.schoolCourseDataSet;
            // 
            // schoolCourseDataSet
            // 
            this.schoolCourseDataSet.DataSetName = "SchoolCourseDataSet";
            this.schoolCourseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pupilIDDataGridViewTextBoxColumn
            // 
            this.pupilIDDataGridViewTextBoxColumn.DataPropertyName = "Pupil_ID";
            this.pupilIDDataGridViewTextBoxColumn.HeaderText = "ID учня";
            this.pupilIDDataGridViewTextBoxColumn.Name = "pupilIDDataGridViewTextBoxColumn";
            this.pupilIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.pupilIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // activityIDDataGridViewTextBoxColumn
            // 
            this.activityIDDataGridViewTextBoxColumn.DataPropertyName = "Activity_ID";
            this.activityIDDataGridViewTextBoxColumn.HeaderText = "ID активності";
            this.activityIDDataGridViewTextBoxColumn.Name = "activityIDDataGridViewTextBoxColumn";
            this.activityIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.activityIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // distributionIDDataGridViewTextBoxColumn
            // 
            this.distributionIDDataGridViewTextBoxColumn.DataPropertyName = "Distribution_ID";
            this.distributionIDDataGridViewTextBoxColumn.HeaderText = "ID розбаловки";
            this.distributionIDDataGridViewTextBoxColumn.Name = "distributionIDDataGridViewTextBoxColumn";
            this.distributionIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.distributionIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // participationBindingSource
            // 
            this.participationBindingSource.DataMember = "AdditionalParticipation";
            this.participationBindingSource.DataSource = this.schoolCourseDataSet;
            // 
            // additionalParticipationTableAdapter
            // 
            this.additionalParticipationTableAdapter.ClearBeforeFill = true;
            // 
            // additionalActivityTableAdapter
            // 
            this.additionalActivityTableAdapter.ClearBeforeFill = true;
            // 
            // AdditionalActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 518);
            this.Controls.Add(this.back_AddActivity);
            this.Controls.Add(this.delete_Activity);
            this.Controls.Add(this.change_Activity);
            this.Controls.Add(this.add_Activity);
            this.Controls.Add(this.showAll_Activity);
            this.Controls.Add(this.delete_Participation);
            this.Controls.Add(this.change_Participation);
            this.Controls.Add(this.add_Participation);
            this.Controls.Add(this.showAll_Participation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.activityDataGridView);
            this.Controls.Add(this.participationDataGridView);
            this.Name = "AdditionalActivity";
            this.Text = "Додаткова активність та участь";
            this.Load += new System.EventHandler(this.AdditionalActivity_Load);
            ((System.ComponentModel.ISupportInitialize)(this.activityDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.participationDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolCourseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.participationBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button delete_Activity;
        private System.Windows.Forms.Button change_Activity;
        private System.Windows.Forms.Button add_Activity;
        private System.Windows.Forms.Button showAll_Activity;
        private System.Windows.Forms.Button delete_Participation;
        private System.Windows.Forms.Button change_Participation;
        private System.Windows.Forms.Button add_Participation;
        private System.Windows.Forms.Button showAll_Participation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView activityDataGridView;
        private System.Windows.Forms.DataGridView participationDataGridView;
        private System.Windows.Forms.Button back_AddActivity;
        private SchoolCourseDataSet schoolCourseDataSet;
        private System.Windows.Forms.BindingSource participationBindingSource;
        private SchoolCourseDataSetTableAdapters.AdditionalParticipationTableAdapter additionalParticipationTableAdapter;
        private System.Windows.Forms.BindingSource activityBindingSource;
        private SchoolCourseDataSetTableAdapters.AdditionalActivityTableAdapter additionalActivityTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn activityIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn activitynameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn activitydateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pupilIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn activityIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn distributionIDDataGridViewTextBoxColumn;
    }
}