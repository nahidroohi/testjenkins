﻿namespace EmployeeWindowsApp
{
    partial class EmployeePF
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
            this.pfDataGridView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewLinkColumn();
            this.salaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durationWorkedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployerContribution = new System.Windows.Forms.DataGridViewLinkColumn();
            this.EmployeeContribution = new System.Windows.Forms.DataGridViewLinkColumn();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeDBDataSet = new EmployeeWindowsApp.EmployeeDBDataSet();
            this.employeesTableAdapter = new EmployeeWindowsApp.EmployeeDBDataSetTableAdapters.EmployeesTableAdapter();
            this.lblEmpList = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pfDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // pfDataGridView
            // 
            this.pfDataGridView.AutoGenerateColumns = false;
            this.pfDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pfDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Name,
            this.salaryDataGridViewTextBoxColumn,
            this.durationWorkedDataGridViewTextBoxColumn,
            this.EmployerContribution,
            this.EmployeeContribution});
            this.pfDataGridView.DataSource = this.employeesBindingSource;
            this.pfDataGridView.Location = new System.Drawing.Point(41, 108);
            this.pfDataGridView.Name = "pfDataGridView";
            this.pfDataGridView.Size = new System.Drawing.Size(545, 202);
            this.pfDataGridView.TabIndex = 0;
            this.pfDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Name
            // 
            this.Name.DataPropertyName = "Name";
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            // 
            // salaryDataGridViewTextBoxColumn
            // 
            this.salaryDataGridViewTextBoxColumn.DataPropertyName = "Salary";
            this.salaryDataGridViewTextBoxColumn.HeaderText = "Salary";
            this.salaryDataGridViewTextBoxColumn.Name = "salaryDataGridViewTextBoxColumn";
            // 
            // durationWorkedDataGridViewTextBoxColumn
            // 
            this.durationWorkedDataGridViewTextBoxColumn.DataPropertyName = "DurationWorked";
            this.durationWorkedDataGridViewTextBoxColumn.HeaderText = "DurationWorked";
            this.durationWorkedDataGridViewTextBoxColumn.Name = "durationWorkedDataGridViewTextBoxColumn";
            // 
            // EmployerContribution
            // 
            this.EmployerContribution.HeaderText = "EmployerContrib";
            this.EmployerContribution.Name = "EmployerContribution";
            this.EmployerContribution.Text = "Details";
            this.EmployerContribution.UseColumnTextForLinkValue = true;
            // 
            // EmployeeContribution
            // 
            this.EmployeeContribution.HeaderText = "EmployeeContrib";
            this.EmployeeContribution.Name = "EmployeeContribution";
            this.EmployeeContribution.ReadOnly = true;
            this.EmployeeContribution.Text = "Details";
            this.EmployeeContribution.UseColumnTextForLinkValue = true;
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.employeeDBDataSet;
            // 
            // employeeDBDataSet
            // 
            this.employeeDBDataSet.DataSetName = "EmployeeDBDataSet";
            this.employeeDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // lblEmpList
            // 
            this.lblEmpList.AutoSize = true;
            this.lblEmpList.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpList.Location = new System.Drawing.Point(223, 42);
            this.lblEmpList.Name = "lblEmpList";
            this.lblEmpList.Size = new System.Drawing.Size(175, 25);
            this.lblEmpList.TabIndex = 3;
            this.lblEmpList.Text = "Employee PF Details";
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(511, 337);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(75, 23);
            this.btnHome.TabIndex = 4;
            this.btnHome.Text = "Go Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // EmployeePF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 372);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.lblEmpList);
            this.Controls.Add(this.pfDataGridView);
            this.Load += new System.EventHandler(this.EmployeePF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pfDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView pfDataGridView;
        private EmployeeDBDataSet employeeDBDataSet;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private EmployeeDBDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private System.Windows.Forms.Label lblEmpList;
        private System.Windows.Forms.DataGridViewLinkColumn EmployeeContribution;
        private System.Windows.Forms.DataGridViewLinkColumn EmployerContribution;
        private System.Windows.Forms.DataGridViewTextBoxColumn durationWorkedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewLinkColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.Button btnHome;
    }
}