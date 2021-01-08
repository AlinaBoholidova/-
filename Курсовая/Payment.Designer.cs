namespace Курсовая
{
    partial class Payment
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
            System.Windows.Forms.Label pupil_IDLabel;
            System.Windows.Forms.Label paymentRate_IDLabel;
            System.Windows.Forms.Label monthLabel;
            System.Windows.Forms.Label paidLabel;
            this.Cancel_Payment = new System.Windows.Forms.Button();
            this.OK_Payment = new System.Windows.Forms.Button();
            this.schoolCourseDataSet = new Курсовая.SchoolCourseDataSet();
            this.pupil_IDComboBox = new System.Windows.Forms.ComboBox();
            this.paymentRate_IDComboBox = new System.Windows.Forms.ComboBox();
            this.monthComboBox = new System.Windows.Forms.ComboBox();
            this.paidCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pupilBbindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pupilTableAdapter = new Курсовая.SchoolCourseDataSetTableAdapters.PupilTableAdapter();
            this.paymentRateTableAdapter = new Курсовая.SchoolCourseDataSetTableAdapters.PaymentRateTableAdapter();
            this.paymentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paymentTableAdapter = new Курсовая.SchoolCourseDataSetTableAdapters.PaymentTableAdapter();
            pupil_IDLabel = new System.Windows.Forms.Label();
            paymentRate_IDLabel = new System.Windows.Forms.Label();
            monthLabel = new System.Windows.Forms.Label();
            paidLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.schoolCourseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pupilBbindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Cancel_Payment
            // 
            this.Cancel_Payment.Location = new System.Drawing.Point(302, 241);
            this.Cancel_Payment.Name = "Cancel_Payment";
            this.Cancel_Payment.Size = new System.Drawing.Size(75, 23);
            this.Cancel_Payment.TabIndex = 13;
            this.Cancel_Payment.Text = "Відміна";
            this.Cancel_Payment.UseVisualStyleBackColor = true;
            this.Cancel_Payment.Click += new System.EventHandler(this.Cancel_Payment_Click);
            // 
            // OK_Payment
            // 
            this.OK_Payment.Location = new System.Drawing.Point(159, 241);
            this.OK_Payment.Name = "OK_Payment";
            this.OK_Payment.Size = new System.Drawing.Size(75, 23);
            this.OK_Payment.TabIndex = 12;
            this.OK_Payment.Text = "ОК";
            this.OK_Payment.UseVisualStyleBackColor = true;
            this.OK_Payment.Click += new System.EventHandler(this.OK_Payment_Click);
            // 
            // schoolCourseDataSet
            // 
            this.schoolCourseDataSet.DataSetName = "SchoolCourseDataSet";
            this.schoolCourseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pupil_IDLabel
            // 
            pupil_IDLabel.AutoSize = true;
            pupil_IDLabel.Location = new System.Drawing.Point(26, 32);
            pupil_IDLabel.Name = "pupil_IDLabel";
            pupil_IDLabel.Size = new System.Drawing.Size(46, 13);
            pupil_IDLabel.TabIndex = 14;
            pupil_IDLabel.Text = "ID учня:";
            // 
            // pupil_IDComboBox
            // 
            this.pupil_IDComboBox.DataSource = this.pupilBbindingSource;
            this.pupil_IDComboBox.DisplayMember = "Pupil_ID";
            this.pupil_IDComboBox.FormattingEnabled = true;
            this.pupil_IDComboBox.Location = new System.Drawing.Point(131, 29);
            this.pupil_IDComboBox.Name = "pupil_IDComboBox";
            this.pupil_IDComboBox.Size = new System.Drawing.Size(121, 21);
            this.pupil_IDComboBox.TabIndex = 15;
            // 
            // paymentRate_IDLabel
            // 
            paymentRate_IDLabel.AutoSize = true;
            paymentRate_IDLabel.Location = new System.Drawing.Point(26, 72);
            paymentRate_IDLabel.Name = "paymentRate_IDLabel";
            paymentRate_IDLabel.Size = new System.Drawing.Size(60, 13);
            paymentRate_IDLabel.TabIndex = 15;
            paymentRate_IDLabel.Text = "ID тарифу:";
            // 
            // paymentRate_IDComboBox
            // 
            this.paymentRate_IDComboBox.DataSource = this.rateBindingSource;
            this.paymentRate_IDComboBox.DisplayMember = "PaymentRate_ID";
            this.paymentRate_IDComboBox.FormattingEnabled = true;
            this.paymentRate_IDComboBox.Location = new System.Drawing.Point(131, 69);
            this.paymentRate_IDComboBox.Name = "paymentRate_IDComboBox";
            this.paymentRate_IDComboBox.Size = new System.Drawing.Size(121, 21);
            this.paymentRate_IDComboBox.TabIndex = 16;
            // 
            // monthLabel
            // 
            monthLabel.AutoSize = true;
            monthLabel.Location = new System.Drawing.Point(26, 119);
            monthLabel.Name = "monthLabel";
            monthLabel.Size = new System.Drawing.Size(45, 13);
            monthLabel.TabIndex = 16;
            monthLabel.Text = "Місяць:";
            // 
            // monthComboBox
            // 
            this.monthComboBox.FormattingEnabled = true;
            this.monthComboBox.Items.AddRange(new object[] {
            "січень",
            "лютий",
            "березень",
            "квітень",
            "травень",
            "червень",
            "липень",
            "серпень",
            "вересень",
            "жовтень",
            "листопад",
            "грудень"});
            this.monthComboBox.Location = new System.Drawing.Point(131, 116);
            this.monthComboBox.Name = "monthComboBox";
            this.monthComboBox.Size = new System.Drawing.Size(121, 21);
            this.monthComboBox.TabIndex = 17;
            // 
            // paidCheckBox
            // 
            this.paidCheckBox.Location = new System.Drawing.Point(131, 165);
            this.paidCheckBox.Name = "paidCheckBox";
            this.paidCheckBox.Size = new System.Drawing.Size(104, 24);
            this.paidCheckBox.TabIndex = 18;
            this.paidCheckBox.Text = "Сплачено";
            this.paidCheckBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(289, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "pupil_IDLabel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(289, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "paymentRate_IDLabel";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(289, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "monthLabel";
            // 
            // pupilBbindingSource
            // 
            this.pupilBbindingSource.DataMember = "Pupil";
            this.pupilBbindingSource.DataSource = this.schoolCourseDataSet;
            // 
            // rateBindingSource
            // 
            this.rateBindingSource.DataMember = "PaymentRate";
            this.rateBindingSource.DataSource = this.schoolCourseDataSet;
            // 
            // pupilTableAdapter
            // 
            this.pupilTableAdapter.ClearBeforeFill = true;
            // 
            // paymentRateTableAdapter
            // 
            this.paymentRateTableAdapter.ClearBeforeFill = true;
            // 
            // paidLabel
            // 
            paidLabel.AutoSize = true;
            paidLabel.Location = new System.Drawing.Point(26, 170);
            paidLabel.Name = "paidLabel";
            paidLabel.Size = new System.Drawing.Size(72, 13);
            paidLabel.TabIndex = 17;
            paidLabel.Text = "Стан сплати:";
            // 
            // paymentBindingSource
            // 
            this.paymentBindingSource.DataMember = "Payment";
            this.paymentBindingSource.DataSource = this.schoolCourseDataSet;
            // 
            // paymentTableAdapter
            // 
            this.paymentTableAdapter.ClearBeforeFill = true;
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 301);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(paidLabel);
            this.Controls.Add(this.paidCheckBox);
            this.Controls.Add(monthLabel);
            this.Controls.Add(this.monthComboBox);
            this.Controls.Add(paymentRate_IDLabel);
            this.Controls.Add(this.paymentRate_IDComboBox);
            this.Controls.Add(pupil_IDLabel);
            this.Controls.Add(this.pupil_IDComboBox);
            this.Controls.Add(this.Cancel_Payment);
            this.Controls.Add(this.OK_Payment);
            this.Name = "Payment";
            this.Text = "Дані про оплату";
            this.Load += new System.EventHandler(this.Payment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.schoolCourseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pupilBbindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cancel_Payment;
        private System.Windows.Forms.Button OK_Payment;
        private SchoolCourseDataSet schoolCourseDataSet;
        private System.Windows.Forms.ComboBox pupil_IDComboBox;
        private System.Windows.Forms.ComboBox paymentRate_IDComboBox;
        private System.Windows.Forms.ComboBox monthComboBox;
        private System.Windows.Forms.CheckBox paidCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource pupilBbindingSource;
        private System.Windows.Forms.BindingSource rateBindingSource;
        private SchoolCourseDataSetTableAdapters.PupilTableAdapter pupilTableAdapter;
        private SchoolCourseDataSetTableAdapters.PaymentRateTableAdapter paymentRateTableAdapter;
        private System.Windows.Forms.BindingSource paymentBindingSource;
        private SchoolCourseDataSetTableAdapters.PaymentTableAdapter paymentTableAdapter;
    }
}