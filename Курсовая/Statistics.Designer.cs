namespace Курсовая
{
    partial class Statistics
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.statsTabControl = new System.Windows.Forms.TabControl();
            this.skipsTabPage = new System.Windows.Forms.TabPage();
            this.skipsDataGridView = new System.Windows.Forms.DataGridView();
            this.birthdaysTabPage = new System.Windows.Forms.TabPage();
            this.chartBirthMonth = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.birthdaysDataGridView = new System.Windows.Forms.DataGridView();
            this.debtersTabPage = new System.Windows.Forms.TabPage();
            this.chartPaymentMonth = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.debtorsDataGridView = new System.Windows.Forms.DataGridView();
            this.activitiesTabPage = new System.Windows.Forms.TabPage();
            this.activitiesDataGridView = new System.Windows.Forms.DataGridView();
            this.journalRecordBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.schoolCourseDataSet = new Курсовая.SchoolCourseDataSet();
            this.journalRecordTableAdapter = new Курсовая.SchoolCourseDataSetTableAdapters.JournalRecordTableAdapter();
            this.pupilBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pupilTableAdapter = new Курсовая.SchoolCourseDataSetTableAdapters.PupilTableAdapter();
            this.testBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testTableAdapter = new Курсовая.SchoolCourseDataSetTableAdapters.TestTableAdapter();
            this.paymentRateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paymentRateTableAdapter = new Курсовая.SchoolCourseDataSetTableAdapters.PaymentRateTableAdapter();
            this.paymentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paymentTableAdapter = new Курсовая.SchoolCourseDataSetTableAdapters.PaymentTableAdapter();
            this.chartActivity = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.statsTabControl.SuspendLayout();
            this.skipsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skipsDataGridView)).BeginInit();
            this.birthdaysTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartBirthMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.birthdaysDataGridView)).BeginInit();
            this.debtersTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartPaymentMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.debtorsDataGridView)).BeginInit();
            this.activitiesTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.activitiesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.journalRecordBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolCourseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pupilBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentRateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartActivity)).BeginInit();
            this.SuspendLayout();
            // 
            // statsTabControl
            // 
            this.statsTabControl.Controls.Add(this.skipsTabPage);
            this.statsTabControl.Controls.Add(this.birthdaysTabPage);
            this.statsTabControl.Controls.Add(this.debtersTabPage);
            this.statsTabControl.Controls.Add(this.activitiesTabPage);
            this.statsTabControl.Location = new System.Drawing.Point(12, 12);
            this.statsTabControl.Name = "statsTabControl";
            this.statsTabControl.SelectedIndex = 0;
            this.statsTabControl.Size = new System.Drawing.Size(849, 426);
            this.statsTabControl.TabIndex = 0;
            // 
            // skipsTabPage
            // 
            this.skipsTabPage.Controls.Add(this.skipsDataGridView);
            this.skipsTabPage.Location = new System.Drawing.Point(4, 22);
            this.skipsTabPage.Name = "skipsTabPage";
            this.skipsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.skipsTabPage.Size = new System.Drawing.Size(841, 400);
            this.skipsTabPage.TabIndex = 0;
            this.skipsTabPage.Text = "Пропуски контрольних";
            this.skipsTabPage.UseVisualStyleBackColor = true;
            // 
            // skipsDataGridView
            // 
            this.skipsDataGridView.AllowUserToAddRows = false;
            this.skipsDataGridView.AllowUserToDeleteRows = false;
            this.skipsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.skipsDataGridView.Location = new System.Drawing.Point(17, 34);
            this.skipsDataGridView.Name = "skipsDataGridView";
            this.skipsDataGridView.ReadOnly = true;
            this.skipsDataGridView.Size = new System.Drawing.Size(391, 200);
            this.skipsDataGridView.TabIndex = 0;
            // 
            // birthdaysTabPage
            // 
            this.birthdaysTabPage.Controls.Add(this.chartBirthMonth);
            this.birthdaysTabPage.Controls.Add(this.birthdaysDataGridView);
            this.birthdaysTabPage.Location = new System.Drawing.Point(4, 22);
            this.birthdaysTabPage.Name = "birthdaysTabPage";
            this.birthdaysTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.birthdaysTabPage.Size = new System.Drawing.Size(841, 400);
            this.birthdaysTabPage.TabIndex = 1;
            this.birthdaysTabPage.Text = "Дні народження";
            this.birthdaysTabPage.UseVisualStyleBackColor = true;
            // 
            // chartBirthMonth
            // 
            chartArea5.Name = "ChartArea1";
            this.chartBirthMonth.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chartBirthMonth.Legends.Add(legend5);
            this.chartBirthMonth.Location = new System.Drawing.Point(412, 30);
            this.chartBirthMonth.Name = "chartBirthMonth";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series5.IsValueShownAsLabel = true;
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chartBirthMonth.Series.Add(series5);
            this.chartBirthMonth.Size = new System.Drawing.Size(332, 300);
            this.chartBirthMonth.TabIndex = 1;
            this.chartBirthMonth.Text = "chart1";
            // 
            // birthdaysDataGridView
            // 
            this.birthdaysDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.birthdaysDataGridView.Location = new System.Drawing.Point(15, 20);
            this.birthdaysDataGridView.Name = "birthdaysDataGridView";
            this.birthdaysDataGridView.Size = new System.Drawing.Size(352, 239);
            this.birthdaysDataGridView.TabIndex = 0;
            // 
            // debtersTabPage
            // 
            this.debtersTabPage.Controls.Add(this.chartPaymentMonth);
            this.debtersTabPage.Controls.Add(this.debtorsDataGridView);
            this.debtersTabPage.Location = new System.Drawing.Point(4, 22);
            this.debtersTabPage.Name = "debtersTabPage";
            this.debtersTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.debtersTabPage.Size = new System.Drawing.Size(841, 400);
            this.debtersTabPage.TabIndex = 2;
            this.debtersTabPage.Text = "Боржники по оплаті";
            this.debtersTabPage.UseVisualStyleBackColor = true;
            // 
            // chartPaymentMonth
            // 
            chartArea6.Name = "ChartArea1";
            this.chartPaymentMonth.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chartPaymentMonth.Legends.Add(legend6);
            this.chartPaymentMonth.Location = new System.Drawing.Point(437, 25);
            this.chartPaymentMonth.Name = "chartPaymentMonth";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series6.IsValueShownAsLabel = true;
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.chartPaymentMonth.Series.Add(series6);
            this.chartPaymentMonth.Size = new System.Drawing.Size(300, 300);
            this.chartPaymentMonth.TabIndex = 1;
            this.chartPaymentMonth.Text = "chart1";
            // 
            // debtorsDataGridView
            // 
            this.debtorsDataGridView.AllowUserToAddRows = false;
            this.debtorsDataGridView.AllowUserToDeleteRows = false;
            this.debtorsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.debtorsDataGridView.Location = new System.Drawing.Point(21, 25);
            this.debtorsDataGridView.Name = "debtorsDataGridView";
            this.debtorsDataGridView.ReadOnly = true;
            this.debtorsDataGridView.Size = new System.Drawing.Size(410, 228);
            this.debtorsDataGridView.TabIndex = 0;
            // 
            // activitiesTabPage
            // 
            this.activitiesTabPage.Controls.Add(this.chartActivity);
            this.activitiesTabPage.Controls.Add(this.activitiesDataGridView);
            this.activitiesTabPage.Location = new System.Drawing.Point(4, 22);
            this.activitiesTabPage.Name = "activitiesTabPage";
            this.activitiesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.activitiesTabPage.Size = new System.Drawing.Size(841, 400);
            this.activitiesTabPage.TabIndex = 3;
            this.activitiesTabPage.Text = "Участь в активності";
            this.activitiesTabPage.UseVisualStyleBackColor = true;
            // 
            // activitiesDataGridView
            // 
            this.activitiesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.activitiesDataGridView.Location = new System.Drawing.Point(16, 18);
            this.activitiesDataGridView.Name = "activitiesDataGridView";
            this.activitiesDataGridView.Size = new System.Drawing.Size(484, 202);
            this.activitiesDataGridView.TabIndex = 0;
            // 
            // journalRecordBindingSource
            // 
            this.journalRecordBindingSource.DataMember = "JournalRecord";
            this.journalRecordBindingSource.DataSource = this.schoolCourseDataSet;
            // 
            // schoolCourseDataSet
            // 
            this.schoolCourseDataSet.DataSetName = "SchoolCourseDataSet";
            this.schoolCourseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // journalRecordTableAdapter
            // 
            this.journalRecordTableAdapter.ClearBeforeFill = true;
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
            // testBindingSource
            // 
            this.testBindingSource.DataMember = "Test";
            this.testBindingSource.DataSource = this.schoolCourseDataSet;
            // 
            // testTableAdapter
            // 
            this.testTableAdapter.ClearBeforeFill = true;
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
            // paymentBindingSource
            // 
            this.paymentBindingSource.DataMember = "Payment";
            this.paymentBindingSource.DataSource = this.schoolCourseDataSet;
            // 
            // paymentTableAdapter
            // 
            this.paymentTableAdapter.ClearBeforeFill = true;
            // 
            // chartActivity
            // 
            chartArea4.Name = "ChartArea1";
            this.chartActivity.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartActivity.Legends.Add(legend4);
            this.chartActivity.Location = new System.Drawing.Point(517, 18);
            this.chartActivity.Name = "chartActivity";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series4.IsValueShownAsLabel = true;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartActivity.Series.Add(series4);
            this.chartActivity.Size = new System.Drawing.Size(318, 300);
            this.chartActivity.TabIndex = 1;
            this.chartActivity.Text = "chart1";
            // 
            // Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 450);
            this.Controls.Add(this.statsTabControl);
            this.Name = "Statistics";
            this.Text = "Статистика";
            this.Load += new System.EventHandler(this.Statistics_Load);
            this.statsTabControl.ResumeLayout(false);
            this.skipsTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.skipsDataGridView)).EndInit();
            this.birthdaysTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartBirthMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.birthdaysDataGridView)).EndInit();
            this.debtersTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartPaymentMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.debtorsDataGridView)).EndInit();
            this.activitiesTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.activitiesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.journalRecordBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolCourseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pupilBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentRateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartActivity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView skipsDataGridView;
        private SchoolCourseDataSet schoolCourseDataSet;
        private System.Windows.Forms.BindingSource journalRecordBindingSource;
        private SchoolCourseDataSetTableAdapters.JournalRecordTableAdapter journalRecordTableAdapter;
        private System.Windows.Forms.BindingSource pupilBindingSource;
        private SchoolCourseDataSetTableAdapters.PupilTableAdapter pupilTableAdapter;
        private System.Windows.Forms.BindingSource testBindingSource;
        private SchoolCourseDataSetTableAdapters.TestTableAdapter testTableAdapter;
        private System.Windows.Forms.DataGridView birthdaysDataGridView;
        private System.Windows.Forms.DataGridView debtorsDataGridView;
        private System.Windows.Forms.DataGridView activitiesDataGridView;
        private System.Windows.Forms.BindingSource paymentRateBindingSource;
        private SchoolCourseDataSetTableAdapters.PaymentRateTableAdapter paymentRateTableAdapter;
        private System.Windows.Forms.BindingSource paymentBindingSource;
        private SchoolCourseDataSetTableAdapters.PaymentTableAdapter paymentTableAdapter;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartBirthMonth;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPaymentMonth;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartActivity;
        public System.Windows.Forms.TabControl statsTabControl;
        public System.Windows.Forms.TabPage skipsTabPage;
        public System.Windows.Forms.TabPage birthdaysTabPage;
        public System.Windows.Forms.TabPage debtersTabPage;
        public System.Windows.Forms.TabPage activitiesTabPage;
    }
}