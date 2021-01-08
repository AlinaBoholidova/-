namespace Курсовая
{
    partial class Payments
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.delete_Payment = new System.Windows.Forms.Button();
            this.change_Payment = new System.Windows.Forms.Button();
            this.add_Payment = new System.Windows.Forms.Button();
            this.showAll_Payment = new System.Windows.Forms.Button();
            this.delete_Rate = new System.Windows.Forms.Button();
            this.change_Rate = new System.Windows.Forms.Button();
            this.add_Rate = new System.Windows.Forms.Button();
            this.showAll_Rate = new System.Windows.Forms.Button();
            this.back_Payments = new System.Windows.Forms.Button();
            this.schoolCourseDataSet = new Курсовая.SchoolCourseDataSet();
            this.paymentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paymentTableAdapter = new Курсовая.SchoolCourseDataSetTableAdapters.PaymentTableAdapter();
            this.rateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paymentRateTableAdapter = new Курсовая.SchoolCourseDataSetTableAdapters.PaymentRateTableAdapter();
            this.paymentRateIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentRatetypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pupilIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentRateIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paidDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolCourseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rateBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.paymentIDDataGridViewTextBoxColumn,
            this.pupilIDDataGridViewTextBoxColumn,
            this.paymentRateIDDataGridViewTextBoxColumn,
            this.monthDataGridViewTextBoxColumn,
            this.paidDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.paymentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 97);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(438, 180);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.paymentRateIDDataGridViewTextBoxColumn1,
            this.paymentRatetypeDataGridViewTextBoxColumn,
            this.sumDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.rateBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(514, 97);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(312, 180);
            this.dataGridView2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Списки оплати";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(483, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Тарифи оплати";
            // 
            // delete_Payment
            // 
            this.delete_Payment.Location = new System.Drawing.Point(344, 57);
            this.delete_Payment.Name = "delete_Payment";
            this.delete_Payment.Size = new System.Drawing.Size(106, 34);
            this.delete_Payment.TabIndex = 60;
            this.delete_Payment.Text = "Видалити оплату";
            this.delete_Payment.UseVisualStyleBackColor = true;
            // 
            // change_Payment
            // 
            this.change_Payment.Location = new System.Drawing.Point(242, 57);
            this.change_Payment.Name = "change_Payment";
            this.change_Payment.Size = new System.Drawing.Size(96, 34);
            this.change_Payment.TabIndex = 59;
            this.change_Payment.Text = "Змінити дані";
            this.change_Payment.UseVisualStyleBackColor = true;
            // 
            // add_Payment
            // 
            this.add_Payment.Location = new System.Drawing.Point(140, 57);
            this.add_Payment.Name = "add_Payment";
            this.add_Payment.Size = new System.Drawing.Size(96, 34);
            this.add_Payment.TabIndex = 58;
            this.add_Payment.Text = "Додати оплату";
            this.add_Payment.UseVisualStyleBackColor = true;
            // 
            // showAll_Payment
            // 
            this.showAll_Payment.Location = new System.Drawing.Point(12, 64);
            this.showAll_Payment.Name = "showAll_Payment";
            this.showAll_Payment.Size = new System.Drawing.Size(109, 27);
            this.showAll_Payment.TabIndex = 57;
            this.showAll_Payment.Text = "Показати всі";
            this.showAll_Payment.UseVisualStyleBackColor = true;
            // 
            // delete_Rate
            // 
            this.delete_Rate.Location = new System.Drawing.Point(806, 57);
            this.delete_Rate.Name = "delete_Rate";
            this.delete_Rate.Size = new System.Drawing.Size(106, 34);
            this.delete_Rate.TabIndex = 64;
            this.delete_Rate.Text = "Видалити тариф";
            this.delete_Rate.UseVisualStyleBackColor = true;
            // 
            // change_Rate
            // 
            this.change_Rate.Location = new System.Drawing.Point(704, 57);
            this.change_Rate.Name = "change_Rate";
            this.change_Rate.Size = new System.Drawing.Size(96, 34);
            this.change_Rate.TabIndex = 63;
            this.change_Rate.Text = "Змінити дані";
            this.change_Rate.UseVisualStyleBackColor = true;
            // 
            // add_Rate
            // 
            this.add_Rate.Location = new System.Drawing.Point(602, 57);
            this.add_Rate.Name = "add_Rate";
            this.add_Rate.Size = new System.Drawing.Size(96, 34);
            this.add_Rate.TabIndex = 62;
            this.add_Rate.Text = "Додати тариф";
            this.add_Rate.UseVisualStyleBackColor = true;
            // 
            // showAll_Rate
            // 
            this.showAll_Rate.Location = new System.Drawing.Point(487, 61);
            this.showAll_Rate.Name = "showAll_Rate";
            this.showAll_Rate.Size = new System.Drawing.Size(109, 27);
            this.showAll_Rate.TabIndex = 61;
            this.showAll_Rate.Text = "Показати всі";
            this.showAll_Rate.UseVisualStyleBackColor = true;
            // 
            // back_Payments
            // 
            this.back_Payments.Location = new System.Drawing.Point(12, 530);
            this.back_Payments.Name = "back_Payments";
            this.back_Payments.Size = new System.Drawing.Size(105, 31);
            this.back_Payments.TabIndex = 65;
            this.back_Payments.Text = "Повернутися";
            this.back_Payments.UseVisualStyleBackColor = true;
            this.back_Payments.Click += new System.EventHandler(this.back_Payments_Click);
            // 
            // schoolCourseDataSet
            // 
            this.schoolCourseDataSet.DataSetName = "SchoolCourseDataSet";
            this.schoolCourseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // rateBindingSource
            // 
            this.rateBindingSource.DataMember = "PaymentRate";
            this.rateBindingSource.DataSource = this.schoolCourseDataSet;
            // 
            // paymentRateTableAdapter
            // 
            this.paymentRateTableAdapter.ClearBeforeFill = true;
            // 
            // paymentRateIDDataGridViewTextBoxColumn1
            // 
            this.paymentRateIDDataGridViewTextBoxColumn1.DataPropertyName = "PaymentRate_ID";
            this.paymentRateIDDataGridViewTextBoxColumn1.HeaderText = "ID тарифу";
            this.paymentRateIDDataGridViewTextBoxColumn1.Name = "paymentRateIDDataGridViewTextBoxColumn1";
            this.paymentRateIDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.paymentRateIDDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // paymentRatetypeDataGridViewTextBoxColumn
            // 
            this.paymentRatetypeDataGridViewTextBoxColumn.DataPropertyName = "PaymentRate_type";
            this.paymentRatetypeDataGridViewTextBoxColumn.HeaderText = "Тип тарифу";
            this.paymentRatetypeDataGridViewTextBoxColumn.Name = "paymentRatetypeDataGridViewTextBoxColumn";
            this.paymentRatetypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.paymentRatetypeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // sumDataGridViewTextBoxColumn
            // 
            this.sumDataGridViewTextBoxColumn.DataPropertyName = "Sum";
            this.sumDataGridViewTextBoxColumn.HeaderText = "Сума";
            this.sumDataGridViewTextBoxColumn.Name = "sumDataGridViewTextBoxColumn";
            this.sumDataGridViewTextBoxColumn.ReadOnly = true;
            this.sumDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // paymentIDDataGridViewTextBoxColumn
            // 
            this.paymentIDDataGridViewTextBoxColumn.DataPropertyName = "Payment_ID";
            this.paymentIDDataGridViewTextBoxColumn.HeaderText = "ID оплати";
            this.paymentIDDataGridViewTextBoxColumn.Name = "paymentIDDataGridViewTextBoxColumn";
            this.paymentIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.paymentIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // pupilIDDataGridViewTextBoxColumn
            // 
            this.pupilIDDataGridViewTextBoxColumn.DataPropertyName = "Pupil_ID";
            this.pupilIDDataGridViewTextBoxColumn.HeaderText = "ID учня";
            this.pupilIDDataGridViewTextBoxColumn.Name = "pupilIDDataGridViewTextBoxColumn";
            this.pupilIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.pupilIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // paymentRateIDDataGridViewTextBoxColumn
            // 
            this.paymentRateIDDataGridViewTextBoxColumn.DataPropertyName = "PaymentRate_ID";
            this.paymentRateIDDataGridViewTextBoxColumn.HeaderText = "ID тарифу";
            this.paymentRateIDDataGridViewTextBoxColumn.Name = "paymentRateIDDataGridViewTextBoxColumn";
            this.paymentRateIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.paymentRateIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // monthDataGridViewTextBoxColumn
            // 
            this.monthDataGridViewTextBoxColumn.DataPropertyName = "Month";
            this.monthDataGridViewTextBoxColumn.HeaderText = "Місяць";
            this.monthDataGridViewTextBoxColumn.Name = "monthDataGridViewTextBoxColumn";
            this.monthDataGridViewTextBoxColumn.ReadOnly = true;
            this.monthDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // paidDataGridViewCheckBoxColumn
            // 
            this.paidDataGridViewCheckBoxColumn.DataPropertyName = "Paid";
            this.paidDataGridViewCheckBoxColumn.HeaderText = "Сплачено";
            this.paidDataGridViewCheckBoxColumn.Name = "paidDataGridViewCheckBoxColumn";
            this.paidDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // Payments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 573);
            this.Controls.Add(this.back_Payments);
            this.Controls.Add(this.delete_Rate);
            this.Controls.Add(this.change_Rate);
            this.Controls.Add(this.add_Rate);
            this.Controls.Add(this.showAll_Rate);
            this.Controls.Add(this.delete_Payment);
            this.Controls.Add(this.change_Payment);
            this.Controls.Add(this.add_Payment);
            this.Controls.Add(this.showAll_Payment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Payments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Оплата";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Payments_FormClosing);
            this.Load += new System.EventHandler(this.Payments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolCourseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rateBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button delete_Payment;
        private System.Windows.Forms.Button change_Payment;
        private System.Windows.Forms.Button add_Payment;
        private System.Windows.Forms.Button showAll_Payment;
        private System.Windows.Forms.Button delete_Rate;
        private System.Windows.Forms.Button change_Rate;
        private System.Windows.Forms.Button add_Rate;
        private System.Windows.Forms.Button showAll_Rate;
        private System.Windows.Forms.Button back_Payments;
        private SchoolCourseDataSet schoolCourseDataSet;
        private System.Windows.Forms.BindingSource paymentBindingSource;
        private SchoolCourseDataSetTableAdapters.PaymentTableAdapter paymentTableAdapter;
        private System.Windows.Forms.BindingSource rateBindingSource;
        private SchoolCourseDataSetTableAdapters.PaymentRateTableAdapter paymentRateTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pupilIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentRateIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn monthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn paidDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentRateIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentRatetypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sumDataGridViewTextBoxColumn;
    }
}