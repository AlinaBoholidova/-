namespace Курсовая
{
    partial class Points
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
            this.pointsDataGridView = new System.Windows.Forms.DataGridView();
            this.delete_Points = new System.Windows.Forms.Button();
            this.change_Points = new System.Windows.Forms.Button();
            this.add_Points = new System.Windows.Forms.Button();
            this.showAll_Points = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.back_Points = new System.Windows.Forms.Button();
            this.schoolCourseDataSet = new Курсовая.SchoolCourseDataSet();
            this.pointsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pointsDistributionTableAdapter = new Курсовая.SchoolCourseDataSetTableAdapters.PointsDistributionTableAdapter();
            this.distributionIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pointsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pointsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolCourseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pointsDataGridView
            // 
            this.pointsDataGridView.AllowUserToAddRows = false;
            this.pointsDataGridView.AllowUserToDeleteRows = false;
            this.pointsDataGridView.AutoGenerateColumns = false;
            this.pointsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pointsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.distributionIDDataGridViewTextBoxColumn,
            this.placeDataGridViewTextBoxColumn,
            this.pointsDataGridViewTextBoxColumn});
            this.pointsDataGridView.DataSource = this.pointsBindingSource;
            this.pointsDataGridView.Location = new System.Drawing.Point(56, 115);
            this.pointsDataGridView.Name = "pointsDataGridView";
            this.pointsDataGridView.ReadOnly = true;
            this.pointsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.pointsDataGridView.Size = new System.Drawing.Size(353, 186);
            this.pointsDataGridView.TabIndex = 0;
            // 
            // delete_Points
            // 
            this.delete_Points.Location = new System.Drawing.Point(358, 64);
            this.delete_Points.Name = "delete_Points";
            this.delete_Points.Size = new System.Drawing.Size(106, 34);
            this.delete_Points.TabIndex = 76;
            this.delete_Points.Text = "Видалити розбаловку";
            this.delete_Points.UseVisualStyleBackColor = true;
            this.delete_Points.Click += new System.EventHandler(this.delete_Points_Click);
            // 
            // change_Points
            // 
            this.change_Points.Location = new System.Drawing.Point(256, 64);
            this.change_Points.Name = "change_Points";
            this.change_Points.Size = new System.Drawing.Size(96, 34);
            this.change_Points.TabIndex = 75;
            this.change_Points.Text = "Змінити дані";
            this.change_Points.UseVisualStyleBackColor = true;
            this.change_Points.Click += new System.EventHandler(this.change_Points_Click);
            // 
            // add_Points
            // 
            this.add_Points.Location = new System.Drawing.Point(154, 64);
            this.add_Points.Name = "add_Points";
            this.add_Points.Size = new System.Drawing.Size(96, 34);
            this.add_Points.TabIndex = 74;
            this.add_Points.Text = "Додати розбаловку";
            this.add_Points.UseVisualStyleBackColor = true;
            this.add_Points.Click += new System.EventHandler(this.add_Points_Click);
            // 
            // showAll_Points
            // 
            this.showAll_Points.Location = new System.Drawing.Point(26, 71);
            this.showAll_Points.Name = "showAll_Points";
            this.showAll_Points.Size = new System.Drawing.Size(109, 27);
            this.showAll_Points.TabIndex = 73;
            this.showAll_Points.Text = "Показати всі";
            this.showAll_Points.UseVisualStyleBackColor = true;
            this.showAll_Points.Click += new System.EventHandler(this.showAll_Points_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 77;
            this.label1.Text = "Розподіл балів";
            // 
            // back_Points
            // 
            this.back_Points.Location = new System.Drawing.Point(12, 345);
            this.back_Points.Name = "back_Points";
            this.back_Points.Size = new System.Drawing.Size(105, 31);
            this.back_Points.TabIndex = 78;
            this.back_Points.Text = "Повернутися";
            this.back_Points.UseVisualStyleBackColor = true;
            this.back_Points.Click += new System.EventHandler(this.back_Points_Click);
            // 
            // schoolCourseDataSet
            // 
            this.schoolCourseDataSet.DataSetName = "SchoolCourseDataSet";
            this.schoolCourseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pointsBindingSource
            // 
            this.pointsBindingSource.DataMember = "PointsDistribution";
            this.pointsBindingSource.DataSource = this.schoolCourseDataSet;
            // 
            // pointsDistributionTableAdapter
            // 
            this.pointsDistributionTableAdapter.ClearBeforeFill = true;
            // 
            // distributionIDDataGridViewTextBoxColumn
            // 
            this.distributionIDDataGridViewTextBoxColumn.DataPropertyName = "Distribution_ID";
            this.distributionIDDataGridViewTextBoxColumn.HeaderText = "ID розбаловки";
            this.distributionIDDataGridViewTextBoxColumn.Name = "distributionIDDataGridViewTextBoxColumn";
            this.distributionIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.distributionIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // placeDataGridViewTextBoxColumn
            // 
            this.placeDataGridViewTextBoxColumn.DataPropertyName = "Place";
            this.placeDataGridViewTextBoxColumn.HeaderText = "Місце";
            this.placeDataGridViewTextBoxColumn.Name = "placeDataGridViewTextBoxColumn";
            this.placeDataGridViewTextBoxColumn.ReadOnly = true;
            this.placeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // pointsDataGridViewTextBoxColumn
            // 
            this.pointsDataGridViewTextBoxColumn.DataPropertyName = "Points";
            this.pointsDataGridViewTextBoxColumn.HeaderText = "Бали";
            this.pointsDataGridViewTextBoxColumn.Name = "pointsDataGridViewTextBoxColumn";
            this.pointsDataGridViewTextBoxColumn.ReadOnly = true;
            this.pointsDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Points
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 388);
            this.Controls.Add(this.back_Points);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.delete_Points);
            this.Controls.Add(this.change_Points);
            this.Controls.Add(this.add_Points);
            this.Controls.Add(this.showAll_Points);
            this.Controls.Add(this.pointsDataGridView);
            this.Name = "Points";
            this.Text = "Розподіл балів";
            this.Load += new System.EventHandler(this.Points_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pointsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolCourseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView pointsDataGridView;
        private System.Windows.Forms.Button delete_Points;
        private System.Windows.Forms.Button change_Points;
        private System.Windows.Forms.Button add_Points;
        private System.Windows.Forms.Button showAll_Points;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button back_Points;
        private SchoolCourseDataSet schoolCourseDataSet;
        private System.Windows.Forms.BindingSource pointsBindingSource;
        private SchoolCourseDataSetTableAdapters.PointsDistributionTableAdapter pointsDistributionTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn distributionIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn placeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pointsDataGridViewTextBoxColumn;
    }
}