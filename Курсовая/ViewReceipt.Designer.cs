namespace Курсовая
{
    partial class ViewReceipt
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.paymentDataGridView = new System.Windows.Forms.DataGridView();
            this.receiptReportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.receiptPreviewButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.paymentDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // paymentDataGridView
            // 
            this.paymentDataGridView.AllowUserToAddRows = false;
            this.paymentDataGridView.AllowUserToDeleteRows = false;
            this.paymentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.paymentDataGridView.Location = new System.Drawing.Point(21, 31);
            this.paymentDataGridView.Name = "paymentDataGridView";
            this.paymentDataGridView.ReadOnly = true;
            this.paymentDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.paymentDataGridView.Size = new System.Drawing.Size(344, 216);
            this.paymentDataGridView.TabIndex = 0;
            // 
            // receiptReportViewer
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource2.Name = "DataSet2";
            reportDataSource3.Name = "DataSet3";
            this.receiptReportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.receiptReportViewer.LocalReport.DataSources.Add(reportDataSource2);
            this.receiptReportViewer.LocalReport.DataSources.Add(reportDataSource3);
            this.receiptReportViewer.LocalReport.ReportEmbeddedResource = "Курсовая.Receipt.rdlc";
            this.receiptReportViewer.Location = new System.Drawing.Point(371, 31);
            this.receiptReportViewer.Name = "receiptReportViewer";
            this.receiptReportViewer.ServerReport.BearerToken = null;
            this.receiptReportViewer.Size = new System.Drawing.Size(500, 308);
            this.receiptReportViewer.TabIndex = 1;
            // 
            // receiptPreviewButton
            // 
            this.receiptPreviewButton.Location = new System.Drawing.Point(117, 290);
            this.receiptPreviewButton.Name = "receiptPreviewButton";
            this.receiptPreviewButton.Size = new System.Drawing.Size(145, 34);
            this.receiptPreviewButton.TabIndex = 2;
            this.receiptPreviewButton.Text = "Перегляд квитанції";
            this.receiptPreviewButton.UseVisualStyleBackColor = true;
            this.receiptPreviewButton.Click += new System.EventHandler(this.receiptPreviewButton_Click);
            // 
            // ViewReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 429);
            this.Controls.Add(this.receiptPreviewButton);
            this.Controls.Add(this.receiptReportViewer);
            this.Controls.Add(this.paymentDataGridView);
            this.Name = "ViewReceipt";
            this.Text = "Квитанція";
            this.Load += new System.EventHandler(this.ViewReceipt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.paymentDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView paymentDataGridView;
        private Microsoft.Reporting.WinForms.ReportViewer receiptReportViewer;
        private System.Windows.Forms.Button receiptPreviewButton;
    }
}