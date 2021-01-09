namespace Курсовая
{
    partial class PaymentRate
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
            System.Windows.Forms.Label paymentRate_typeLabel;
            System.Windows.Forms.Label sumLabel;
            this.Cancel_PaymentRate = new System.Windows.Forms.Button();
            this.OK_PaymentRate = new System.Windows.Forms.Button();
            this.schoolCourseDataSet = new Курсовая.SchoolCourseDataSet();
            this.paymentRateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paymentRateTableAdapter = new Курсовая.SchoolCourseDataSetTableAdapters.PaymentRateTableAdapter();
            this.tableAdapterManager = new Курсовая.SchoolCourseDataSetTableAdapters.TableAdapterManager();
            this.paymentRate_typeTextBox = new System.Windows.Forms.TextBox();
            this.sumNumericUpDown = new System.Windows.Forms.NumericUpDown();
            paymentRate_typeLabel = new System.Windows.Forms.Label();
            sumLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.schoolCourseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentRateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sumNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // paymentRate_typeLabel
            // 
            paymentRate_typeLabel.AutoSize = true;
            paymentRate_typeLabel.Location = new System.Drawing.Point(23, 32);
            paymentRate_typeLabel.Name = "paymentRate_typeLabel";
            paymentRate_typeLabel.Size = new System.Drawing.Size(68, 13);
            paymentRate_typeLabel.TabIndex = 16;
            paymentRate_typeLabel.Text = "Тип тарифу:";
            // 
            // sumLabel
            // 
            sumLabel.AutoSize = true;
            sumLabel.Location = new System.Drawing.Point(23, 101);
            sumLabel.Name = "sumLabel";
            sumLabel.Size = new System.Drawing.Size(36, 13);
            sumLabel.TabIndex = 17;
            sumLabel.Text = "Сума:";
            // 
            // Cancel_PaymentRate
            // 
            this.Cancel_PaymentRate.Location = new System.Drawing.Point(209, 175);
            this.Cancel_PaymentRate.Name = "Cancel_PaymentRate";
            this.Cancel_PaymentRate.Size = new System.Drawing.Size(75, 23);
            this.Cancel_PaymentRate.TabIndex = 15;
            this.Cancel_PaymentRate.Text = "Відміна";
            this.Cancel_PaymentRate.UseVisualStyleBackColor = true;
            this.Cancel_PaymentRate.Click += new System.EventHandler(this.Cancel_PaymentRate_Click);
            // 
            // OK_PaymentRate
            // 
            this.OK_PaymentRate.Location = new System.Drawing.Point(66, 175);
            this.OK_PaymentRate.Name = "OK_PaymentRate";
            this.OK_PaymentRate.Size = new System.Drawing.Size(75, 23);
            this.OK_PaymentRate.TabIndex = 14;
            this.OK_PaymentRate.Text = "ОК";
            this.OK_PaymentRate.UseVisualStyleBackColor = true;
            this.OK_PaymentRate.Click += new System.EventHandler(this.OK_PaymentRate_Click);
            // 
            // schoolCourseDataSet
            // 
            this.schoolCourseDataSet.DataSetName = "SchoolCourseDataSet";
            this.schoolCourseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // paymentRateBindingSource
            // 
            this.paymentRateBindingSource.DataMember = "PaymentRate";
            this.paymentRateBindingSource.DataSource = this.schoolCourseDataSet;
            // 
            // paymentRateTableAdapter
            // 
            this.paymentRateTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdditionalActivityTableAdapter = null;
            this.tableAdapterManager.AdditionalParticipationTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.JournalRecordTableAdapter = null;
            this.tableAdapterManager.PaymentRateTableAdapter = this.paymentRateTableAdapter;
            this.tableAdapterManager.PaymentTableAdapter = null;
            this.tableAdapterManager.PersonnelFileTableAdapter = null;
            this.tableAdapterManager.PointsDistributionTableAdapter = null;
            this.tableAdapterManager.PupilTableAdapter = null;
            this.tableAdapterManager.SubjectTableAdapter = null;
            this.tableAdapterManager.TestTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Курсовая.SchoolCourseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserTableAdapter = null;
            // 
            // paymentRate_typeTextBox
            // 
            this.paymentRate_typeTextBox.Location = new System.Drawing.Point(139, 29);
            this.paymentRate_typeTextBox.Name = "paymentRate_typeTextBox";
            this.paymentRate_typeTextBox.Size = new System.Drawing.Size(160, 20);
            this.paymentRate_typeTextBox.TabIndex = 17;
            // 
            // sumNumericUpDown
            // 
            this.sumNumericUpDown.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.sumNumericUpDown.Location = new System.Drawing.Point(139, 101);
            this.sumNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.sumNumericUpDown.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.sumNumericUpDown.Name = "sumNumericUpDown";
            this.sumNumericUpDown.Size = new System.Drawing.Size(81, 20);
            this.sumNumericUpDown.TabIndex = 18;
            this.sumNumericUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // PaymentRate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 225);
            this.Controls.Add(sumLabel);
            this.Controls.Add(this.sumNumericUpDown);
            this.Controls.Add(paymentRate_typeLabel);
            this.Controls.Add(this.paymentRate_typeTextBox);
            this.Controls.Add(this.Cancel_PaymentRate);
            this.Controls.Add(this.OK_PaymentRate);
            this.Name = "PaymentRate";
            this.Text = "Тариф оплати";
            this.Load += new System.EventHandler(this.PaymentRate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.schoolCourseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentRateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sumNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cancel_PaymentRate;
        private System.Windows.Forms.Button OK_PaymentRate;
        private SchoolCourseDataSet schoolCourseDataSet;
        private System.Windows.Forms.BindingSource paymentRateBindingSource;
        private SchoolCourseDataSetTableAdapters.PaymentRateTableAdapter paymentRateTableAdapter;
        private SchoolCourseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox paymentRate_typeTextBox;
        private System.Windows.Forms.NumericUpDown sumNumericUpDown;
    }
}