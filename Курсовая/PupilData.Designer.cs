namespace Курсовая
{
    partial class PupilData
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SNP_PupilData = new System.Windows.Forms.TextBox();
            this.birthDate_PupilData = new System.Windows.Forms.DateTimePicker();
            this.gender_PupilData = new System.Windows.Forms.ComboBox();
            this.OK_PupilData = new System.Windows.Forms.Button();
            this.Cancel_PupilData = new System.Windows.Forms.Button();
            this.schoolCourseDataSet = new Курсовая.SchoolCourseDataSet();
            this.pupilBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pupilTableAdapter = new Курсовая.SchoolCourseDataSetTableAdapters.PupilTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.schoolCourseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pupilBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ПІБ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Стать:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Дата народження:";
            // 
            // SNP_PupilData
            // 
            this.SNP_PupilData.Location = new System.Drawing.Point(158, 26);
            this.SNP_PupilData.Name = "SNP_PupilData";
            this.SNP_PupilData.Size = new System.Drawing.Size(237, 20);
            this.SNP_PupilData.TabIndex = 3;
            // 
            // birthDate_PupilData
            // 
            this.birthDate_PupilData.Location = new System.Drawing.Point(158, 111);
            this.birthDate_PupilData.MaxDate = new System.DateTime(2014, 12, 31, 0, 0, 0, 0);
            this.birthDate_PupilData.MinDate = new System.DateTime(2002, 1, 1, 0, 0, 0, 0);
            this.birthDate_PupilData.Name = "birthDate_PupilData";
            this.birthDate_PupilData.Size = new System.Drawing.Size(237, 20);
            this.birthDate_PupilData.TabIndex = 4;
            this.birthDate_PupilData.Value = new System.DateTime(2008, 1, 1, 0, 0, 0, 0);
            // 
            // gender_PupilData
            // 
            this.gender_PupilData.FormattingEnabled = true;
            this.gender_PupilData.Items.AddRange(new object[] {
            "Ч",
            "Ж"});
            this.gender_PupilData.Location = new System.Drawing.Point(158, 66);
            this.gender_PupilData.Name = "gender_PupilData";
            this.gender_PupilData.Size = new System.Drawing.Size(52, 21);
            this.gender_PupilData.TabIndex = 5;
            // 
            // OK_PupilData
            // 
            this.OK_PupilData.Location = new System.Drawing.Point(105, 171);
            this.OK_PupilData.Name = "OK_PupilData";
            this.OK_PupilData.Size = new System.Drawing.Size(75, 23);
            this.OK_PupilData.TabIndex = 6;
            this.OK_PupilData.Text = "ОК";
            this.OK_PupilData.UseVisualStyleBackColor = true;
            this.OK_PupilData.Click += new System.EventHandler(this.OK_PupilData_Click);
            // 
            // Cancel_PupilData
            // 
            this.Cancel_PupilData.Location = new System.Drawing.Point(248, 171);
            this.Cancel_PupilData.Name = "Cancel_PupilData";
            this.Cancel_PupilData.Size = new System.Drawing.Size(75, 23);
            this.Cancel_PupilData.TabIndex = 7;
            this.Cancel_PupilData.Text = "Відміна";
            this.Cancel_PupilData.UseVisualStyleBackColor = true;
            this.Cancel_PupilData.Click += new System.EventHandler(this.Cancel_PupilData_Click);
            // 
            // schoolCourseDataSet
            // 
            this.schoolCourseDataSet.DataSetName = "SchoolCourseDataSet";
            this.schoolCourseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // PupilData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 231);
            this.Controls.Add(this.Cancel_PupilData);
            this.Controls.Add(this.OK_PupilData);
            this.Controls.Add(this.gender_PupilData);
            this.Controls.Add(this.birthDate_PupilData);
            this.Controls.Add(this.SNP_PupilData);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PupilData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Дані учня";
            this.Load += new System.EventHandler(this.PupilData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.schoolCourseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pupilBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SNP_PupilData;
        private System.Windows.Forms.DateTimePicker birthDate_PupilData;
        private System.Windows.Forms.ComboBox gender_PupilData;
        private System.Windows.Forms.Button OK_PupilData;
        private System.Windows.Forms.Button Cancel_PupilData;
        private SchoolCourseDataSet schoolCourseDataSet;
        private System.Windows.Forms.BindingSource pupilBindingSource;
        private SchoolCourseDataSetTableAdapters.PupilTableAdapter pupilTableAdapter;
    }
}