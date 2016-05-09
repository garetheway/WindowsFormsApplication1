namespace WindowsFormsApplication1
{
    partial class frmArchiveView
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
            this.scheduleDatabaseDataSet = new WindowsFormsApplication1.ScheduleDatabaseDataSet();
            this.scheduleDatabaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workOrdersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workOrdersTableAdapter = new WindowsFormsApplication1.ScheduleDatabaseDataSetTableAdapters.WorkOrdersTableAdapter();
            this.workOrderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dueDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.completionDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleDatabaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workOrdersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.workOrderIDDataGridViewTextBoxColumn,
            this.productDataGridViewTextBoxColumn,
            this.customerDataGridViewTextBoxColumn,
            this.dueDateDataGridViewTextBoxColumn,
            this.completionDateDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.notesDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.workOrdersBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(848, 237);
            this.dataGridView1.TabIndex = 0;
            // 
            // scheduleDatabaseDataSet
            // 
            this.scheduleDatabaseDataSet.DataSetName = "ScheduleDatabaseDataSet";
            this.scheduleDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // scheduleDatabaseDataSetBindingSource
            // 
            this.scheduleDatabaseDataSetBindingSource.DataSource = this.scheduleDatabaseDataSet;
            this.scheduleDatabaseDataSetBindingSource.Position = 0;
            // 
            // workOrdersBindingSource
            // 
            this.workOrdersBindingSource.DataMember = "WorkOrders";
            this.workOrdersBindingSource.DataSource = this.scheduleDatabaseDataSetBindingSource;
            // 
            // workOrdersTableAdapter
            // 
            this.workOrdersTableAdapter.ClearBeforeFill = true;
            // 
            // workOrderIDDataGridViewTextBoxColumn
            // 
            this.workOrderIDDataGridViewTextBoxColumn.DataPropertyName = "WorkOrderID";
            this.workOrderIDDataGridViewTextBoxColumn.HeaderText = "WorkOrderID";
            this.workOrderIDDataGridViewTextBoxColumn.Name = "workOrderIDDataGridViewTextBoxColumn";
            this.workOrderIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productDataGridViewTextBoxColumn
            // 
            this.productDataGridViewTextBoxColumn.DataPropertyName = "Product";
            this.productDataGridViewTextBoxColumn.HeaderText = "Product";
            this.productDataGridViewTextBoxColumn.Name = "productDataGridViewTextBoxColumn";
            this.productDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerDataGridViewTextBoxColumn
            // 
            this.customerDataGridViewTextBoxColumn.DataPropertyName = "Customer";
            this.customerDataGridViewTextBoxColumn.HeaderText = "Customer";
            this.customerDataGridViewTextBoxColumn.Name = "customerDataGridViewTextBoxColumn";
            this.customerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dueDateDataGridViewTextBoxColumn
            // 
            this.dueDateDataGridViewTextBoxColumn.DataPropertyName = "DueDate";
            this.dueDateDataGridViewTextBoxColumn.HeaderText = "DueDate";
            this.dueDateDataGridViewTextBoxColumn.Name = "dueDateDataGridViewTextBoxColumn";
            this.dueDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // completionDateDataGridViewTextBoxColumn
            // 
            this.completionDateDataGridViewTextBoxColumn.DataPropertyName = "CompletionDate";
            this.completionDateDataGridViewTextBoxColumn.HeaderText = "CompletionDate";
            this.completionDateDataGridViewTextBoxColumn.Name = "completionDateDataGridViewTextBoxColumn";
            this.completionDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // notesDataGridViewTextBoxColumn
            // 
            this.notesDataGridViewTextBoxColumn.DataPropertyName = "Notes";
            this.notesDataGridViewTextBoxColumn.HeaderText = "Notes";
            this.notesDataGridViewTextBoxColumn.Name = "notesDataGridViewTextBoxColumn";
            this.notesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frmArchiveView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 262);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmArchiveView";
            this.Text = "frmArchiveView";
            this.Load += new System.EventHandler(this.frmArchiveView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleDatabaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workOrdersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource scheduleDatabaseDataSetBindingSource;
        private ScheduleDatabaseDataSet scheduleDatabaseDataSet;
        private System.Windows.Forms.BindingSource workOrdersBindingSource;
        private ScheduleDatabaseDataSetTableAdapters.WorkOrdersTableAdapter workOrdersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn workOrderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dueDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn completionDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notesDataGridViewTextBoxColumn;
    }
}