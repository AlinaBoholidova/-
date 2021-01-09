namespace Курсовая
{
    partial class PointsData
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
            System.Windows.Forms.Label placeLabel;
            System.Windows.Forms.Label pointsLabel;
            this.Cancel_Points = new System.Windows.Forms.Button();
            this.OK_Points = new System.Windows.Forms.Button();
            this.schoolCourseDataSet = new Курсовая.SchoolCourseDataSet();
            this.pointsDistributionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pointsDistributionTableAdapter = new Курсовая.SchoolCourseDataSetTableAdapters.PointsDistributionTableAdapter();
            this.placeTextBox = new System.Windows.Forms.TextBox();
            this.pointsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            placeLabel = new System.Windows.Forms.Label();
            pointsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.schoolCourseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointsDistributionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointsNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // placeLabel
            // 
            placeLabel.AutoSize = true;
            placeLabel.Location = new System.Drawing.Point(34, 48);
            placeLabel.Name = "placeLabel";
            placeLabel.Size = new System.Drawing.Size(39, 13);
            placeLabel.TabIndex = 18;
            placeLabel.Text = "Місце:";
            // 
            // pointsLabel
            // 
            pointsLabel.AutoSize = true;
            pointsLabel.Location = new System.Drawing.Point(34, 100);
            pointsLabel.Name = "pointsLabel";
            pointsLabel.Size = new System.Drawing.Size(85, 13);
            pointsLabel.TabIndex = 19;
            pointsLabel.Text = "Кількість балів:";
            // 
            // Cancel_Points
            // 
            this.Cancel_Points.Location = new System.Drawing.Point(231, 185);
            this.Cancel_Points.Name = "Cancel_Points";
            this.Cancel_Points.Size = new System.Drawing.Size(75, 23);
            this.Cancel_Points.TabIndex = 17;
            this.Cancel_Points.Text = "Відміна";
            this.Cancel_Points.UseVisualStyleBackColor = true;
            this.Cancel_Points.Click += new System.EventHandler(this.Cancel_Points_Click);
            // 
            // OK_Points
            // 
            this.OK_Points.Location = new System.Drawing.Point(88, 185);
            this.OK_Points.Name = "OK_Points";
            this.OK_Points.Size = new System.Drawing.Size(75, 23);
            this.OK_Points.TabIndex = 16;
            this.OK_Points.Text = "ОК";
            this.OK_Points.UseVisualStyleBackColor = true;
            this.OK_Points.Click += new System.EventHandler(this.OK_Points_Click);
            // 
            // schoolCourseDataSet
            // 
            this.schoolCourseDataSet.DataSetName = "SchoolCourseDataSet";
            this.schoolCourseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pointsDistributionBindingSource
            // 
            this.pointsDistributionBindingSource.DataMember = "PointsDistribution";
            this.pointsDistributionBindingSource.DataSource = this.schoolCourseDataSet;
            // 
            // pointsDistributionTableAdapter
            // 
            this.pointsDistributionTableAdapter.ClearBeforeFill = true;
            // 
            // placeTextBox
            // 
            this.placeTextBox.Location = new System.Drawing.Point(133, 48);
            this.placeTextBox.Name = "placeTextBox";
            this.placeTextBox.Size = new System.Drawing.Size(187, 20);
            this.placeTextBox.TabIndex = 19;
            // 
            // pointsNumericUpDown
            // 
            this.pointsNumericUpDown.Location = new System.Drawing.Point(133, 100);
            this.pointsNumericUpDown.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.pointsNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pointsNumericUpDown.Name = "pointsNumericUpDown";
            this.pointsNumericUpDown.Size = new System.Drawing.Size(48, 20);
            this.pointsNumericUpDown.TabIndex = 20;
            this.pointsNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // PointsData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 246);
            this.Controls.Add(pointsLabel);
            this.Controls.Add(this.pointsNumericUpDown);
            this.Controls.Add(placeLabel);
            this.Controls.Add(this.placeTextBox);
            this.Controls.Add(this.Cancel_Points);
            this.Controls.Add(this.OK_Points);
            this.Name = "PointsData";
            this.Text = "Розбаловка";
            this.Load += new System.EventHandler(this.Points_Load);
            ((System.ComponentModel.ISupportInitialize)(this.schoolCourseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointsDistributionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointsNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cancel_Points;
        private System.Windows.Forms.Button OK_Points;
        private SchoolCourseDataSet schoolCourseDataSet;
        private System.Windows.Forms.BindingSource pointsDistributionBindingSource;
        private SchoolCourseDataSetTableAdapters.PointsDistributionTableAdapter pointsDistributionTableAdapter;
        private System.Windows.Forms.TextBox placeTextBox;
        private System.Windows.Forms.NumericUpDown pointsNumericUpDown;
    }
}