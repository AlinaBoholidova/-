namespace Курсовая
{
    partial class JournalRecordData
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
            System.Windows.Forms.Label paymentRate_IDLabel;
            System.Windows.Forms.Label pupil_IDLabel;
            System.Windows.Forms.Label scoreLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JournalRecordData));
            this.paymentRate_ID = new System.Windows.Forms.Label();
            this.pupil = new System.Windows.Forms.Label();
            this.paymentRate_IDComboBox = new System.Windows.Forms.ComboBox();
            this.pupil_IDComboBox = new System.Windows.Forms.ComboBox();
            this.Cancel_Payment = new System.Windows.Forms.Button();
            this.OK_Payment = new System.Windows.Forms.Button();
            this.schoolCourseDataSet = new Курсовая.SchoolCourseDataSet();
            this.journalRecordBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.journalRecordTableAdapter = new Курсовая.SchoolCourseDataSetTableAdapters.JournalRecordTableAdapter();
            this.scoreNumericUpDown = new System.Windows.Forms.NumericUpDown();
            paymentRate_IDLabel = new System.Windows.Forms.Label();
            pupil_IDLabel = new System.Windows.Forms.Label();
            scoreLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.schoolCourseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.journalRecordBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // paymentRate_ID
            // 
            this.paymentRate_ID.AutoSize = true;
            this.paymentRate_ID.Location = new System.Drawing.Point(391, 135);
            this.paymentRate_ID.Name = "paymentRate_ID";
            this.paymentRate_ID.Size = new System.Drawing.Size(109, 15);
            this.paymentRate_ID.TabIndex = 26;
            this.paymentRate_ID.Text = "АнглМ 07.11.2020";
            // 
            // pupil
            // 
            this.pupil.AutoSize = true;
            this.pupil.Location = new System.Drawing.Point(391, 82);
            this.pupil.Name = "pupil";
            this.pupil.Size = new System.Drawing.Size(165, 15);
            this.pupil.TabIndex = 25;
            this.pupil.Text = "Єгоров Максим Микитович";
            // 
            // paymentRate_IDLabel
            // 
            paymentRate_IDLabel.AutoSize = true;
            paymentRate_IDLabel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            paymentRate_IDLabel.Location = new System.Drawing.Point(127, 135);
            paymentRate_IDLabel.Name = "paymentRate_IDLabel";
            paymentRate_IDLabel.Size = new System.Drawing.Size(97, 15);
            paymentRate_IDLabel.TabIndex = 22;
            paymentRate_IDLabel.Text = "ID контрольної:";
            // 
            // paymentRate_IDComboBox
            // 
            this.paymentRate_IDComboBox.DisplayMember = "PaymentRate_ID";
            this.paymentRate_IDComboBox.FormattingEnabled = true;
            this.paymentRate_IDComboBox.Location = new System.Drawing.Point(271, 132);
            this.paymentRate_IDComboBox.Name = "paymentRate_IDComboBox";
            this.paymentRate_IDComboBox.Size = new System.Drawing.Size(74, 23);
            this.paymentRate_IDComboBox.TabIndex = 24;
            this.paymentRate_IDComboBox.Text = "2";
            // 
            // pupil_IDLabel
            // 
            pupil_IDLabel.AutoSize = true;
            pupil_IDLabel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            pupil_IDLabel.Location = new System.Drawing.Point(128, 82);
            pupil_IDLabel.Name = "pupil_IDLabel";
            pupil_IDLabel.Size = new System.Drawing.Size(50, 15);
            pupil_IDLabel.TabIndex = 21;
            pupil_IDLabel.Text = "ID учня:";
            // 
            // pupil_IDComboBox
            // 
            this.pupil_IDComboBox.DisplayMember = "Pupil_ID";
            this.pupil_IDComboBox.FormattingEnabled = true;
            this.pupil_IDComboBox.Location = new System.Drawing.Point(271, 77);
            this.pupil_IDComboBox.Name = "pupil_IDComboBox";
            this.pupil_IDComboBox.Size = new System.Drawing.Size(74, 23);
            this.pupil_IDComboBox.TabIndex = 23;
            this.pupil_IDComboBox.Text = "1";
            // 
            // Cancel_Payment
            // 
            this.Cancel_Payment.Location = new System.Drawing.Point(435, 256);
            this.Cancel_Payment.Name = "Cancel_Payment";
            this.Cancel_Payment.Size = new System.Drawing.Size(101, 31);
            this.Cancel_Payment.TabIndex = 28;
            this.Cancel_Payment.Text = "Відміна";
            this.Cancel_Payment.UseVisualStyleBackColor = true;
            // 
            // OK_Payment
            // 
            this.OK_Payment.Location = new System.Drawing.Point(240, 256);
            this.OK_Payment.Name = "OK_Payment";
            this.OK_Payment.Size = new System.Drawing.Size(101, 31);
            this.OK_Payment.TabIndex = 27;
            this.OK_Payment.Text = "ОК";
            this.OK_Payment.UseVisualStyleBackColor = true;
            // 
            // schoolCourseDataSet
            // 
            this.schoolCourseDataSet.DataSetName = "SchoolCourseDataSet";
            this.schoolCourseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // journalRecordBindingSource
            // 
            this.journalRecordBindingSource.DataMember = "JournalRecord";
            this.journalRecordBindingSource.DataSource = this.schoolCourseDataSet;
            // 
            // journalRecordTableAdapter
            // 
            this.journalRecordTableAdapter.ClearBeforeFill = true;
            // 
            // scoreLabel
            // 
            scoreLabel.AutoSize = true;
            scoreLabel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            scoreLabel.Location = new System.Drawing.Point(128, 189);
            scoreLabel.Name = "scoreLabel";
            scoreLabel.Size = new System.Drawing.Size(49, 15);
            scoreLabel.TabIndex = 29;
            scoreLabel.Text = "Оцінка:";
            // 
            // scoreNumericUpDown
            // 
            this.scoreNumericUpDown.Location = new System.Drawing.Point(271, 187);
            this.scoreNumericUpDown.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.scoreNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.scoreNumericUpDown.Name = "scoreNumericUpDown";
            this.scoreNumericUpDown.Size = new System.Drawing.Size(75, 21);
            this.scoreNumericUpDown.TabIndex = 30;
            this.scoreNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // JournalRecordData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Курсовая.Properties.Resources.back_subject;
            this.ClientSize = new System.Drawing.Size(639, 327);
            this.Controls.Add(scoreLabel);
            this.Controls.Add(this.scoreNumericUpDown);
            this.Controls.Add(this.Cancel_Payment);
            this.Controls.Add(this.OK_Payment);
            this.Controls.Add(this.paymentRate_ID);
            this.Controls.Add(this.pupil);
            this.Controls.Add(paymentRate_IDLabel);
            this.Controls.Add(this.paymentRate_IDComboBox);
            this.Controls.Add(pupil_IDLabel);
            this.Controls.Add(this.pupil_IDComboBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "JournalRecordData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JournalRecordData";
            this.Load += new System.EventHandler(this.JournalRecordData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.schoolCourseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.journalRecordBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label paymentRate_ID;
        private System.Windows.Forms.Label pupil;
        private System.Windows.Forms.ComboBox paymentRate_IDComboBox;
        private System.Windows.Forms.ComboBox pupil_IDComboBox;
        private System.Windows.Forms.Button Cancel_Payment;
        private System.Windows.Forms.Button OK_Payment;
        private SchoolCourseDataSet schoolCourseDataSet;
        private System.Windows.Forms.BindingSource journalRecordBindingSource;
        private SchoolCourseDataSetTableAdapters.JournalRecordTableAdapter journalRecordTableAdapter;
        private System.Windows.Forms.NumericUpDown scoreNumericUpDown;
    }
}