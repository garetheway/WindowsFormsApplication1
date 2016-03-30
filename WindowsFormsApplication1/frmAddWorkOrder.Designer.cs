namespace WindowsFormsApplication1
{
    partial class frmAddWorkOrder
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
            System.Windows.Forms.Label statusLabel;
            System.Windows.Forms.Label workOrderIDLabel;
            System.Windows.Forms.Label productLabel;
            System.Windows.Forms.Label customerLabel;
            System.Windows.Forms.Label dueDateLabel;
            System.Windows.Forms.Label quantityLabel;
            this.scheduleDatabaseDataSet = new WindowsFormsApplication1.ScheduleDatabaseDataSet();
            this.workOrdersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workOrdersTableAdapter = new WindowsFormsApplication1.ScheduleDatabaseDataSetTableAdapters.WorkOrdersTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication1.ScheduleDatabaseDataSetTableAdapters.TableAdapterManager();
            this.workOrderIDTextBox = new System.Windows.Forms.TextBox();
            this.productTextBox = new System.Windows.Forms.TextBox();
            this.customerTextBox = new System.Windows.Forms.TextBox();
            this.dueDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtStatus = new System.Windows.Forms.TextBox();
            statusLabel = new System.Windows.Forms.Label();
            workOrderIDLabel = new System.Windows.Forms.Label();
            productLabel = new System.Windows.Forms.Label();
            customerLabel = new System.Windows.Forms.Label();
            dueDateLabel = new System.Windows.Forms.Label();
            quantityLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workOrdersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new System.Drawing.Point(12, 170);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(40, 13);
            statusLabel.TabIndex = 0;
            statusLabel.Text = "Status:";
            // 
            // workOrderIDLabel
            // 
            workOrderIDLabel.AutoSize = true;
            workOrderIDLabel.Location = new System.Drawing.Point(12, 18);
            workOrderIDLabel.Name = "workOrderIDLabel";
            workOrderIDLabel.Size = new System.Drawing.Size(79, 13);
            workOrderIDLabel.TabIndex = 2;
            workOrderIDLabel.Text = "Work Order ID:";
            // 
            // productLabel
            // 
            productLabel.AutoSize = true;
            productLabel.Location = new System.Drawing.Point(12, 46);
            productLabel.Name = "productLabel";
            productLabel.Size = new System.Drawing.Size(47, 13);
            productLabel.TabIndex = 4;
            productLabel.Text = "Product:";
            // 
            // customerLabel
            // 
            customerLabel.AutoSize = true;
            customerLabel.Location = new System.Drawing.Point(12, 72);
            customerLabel.Name = "customerLabel";
            customerLabel.Size = new System.Drawing.Size(54, 13);
            customerLabel.TabIndex = 6;
            customerLabel.Text = "Customer:";
            // 
            // dueDateLabel
            // 
            dueDateLabel.AutoSize = true;
            dueDateLabel.Location = new System.Drawing.Point(12, 103);
            dueDateLabel.Name = "dueDateLabel";
            dueDateLabel.Size = new System.Drawing.Size(56, 13);
            dueDateLabel.TabIndex = 8;
            dueDateLabel.Text = "Due Date:";
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.Location = new System.Drawing.Point(12, 134);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new System.Drawing.Size(49, 13);
            quantityLabel.TabIndex = 10;
            quantityLabel.Text = "Quantity:";
            // 
            // scheduleDatabaseDataSet
            // 
            this.scheduleDatabaseDataSet.DataSetName = "ScheduleDatabaseDataSet";
            this.scheduleDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // workOrdersBindingSource
            // 
            this.workOrdersBindingSource.DataMember = "WorkOrders";
            this.workOrdersBindingSource.DataSource = this.scheduleDatabaseDataSet;
            // 
            // workOrdersTableAdapter
            // 
            this.workOrdersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.LinesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplication1.ScheduleDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WorkOrdersTableAdapter = this.workOrdersTableAdapter;
            // 
            // workOrderIDTextBox
            // 
            this.workOrderIDTextBox.Location = new System.Drawing.Point(97, 15);
            this.workOrderIDTextBox.Name = "workOrderIDTextBox";
            this.workOrderIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.workOrderIDTextBox.TabIndex = 3;
            // 
            // productTextBox
            // 
            this.productTextBox.Location = new System.Drawing.Point(97, 43);
            this.productTextBox.Name = "productTextBox";
            this.productTextBox.Size = new System.Drawing.Size(100, 20);
            this.productTextBox.TabIndex = 5;
            // 
            // customerTextBox
            // 
            this.customerTextBox.Location = new System.Drawing.Point(97, 69);
            this.customerTextBox.Name = "customerTextBox";
            this.customerTextBox.Size = new System.Drawing.Size(100, 20);
            this.customerTextBox.TabIndex = 7;
            // 
            // dueDateDateTimePicker
            // 
            this.dueDateDateTimePicker.Location = new System.Drawing.Point(97, 97);
            this.dueDateDateTimePicker.Name = "dueDateDateTimePicker";
            this.dueDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dueDateDateTimePicker.TabIndex = 9;
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(97, 131);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(100, 20);
            this.quantityTextBox.TabIndex = 11;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(97, 206);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(121, 23);
            this.btnSubmit.TabIndex = 12;
            this.btnSubmit.Text = "Create Work Order";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(97, 167);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(100, 20);
            this.txtStatus.TabIndex = 13;
            // 
            // frmAddWorkOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 262);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(quantityLabel);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(dueDateLabel);
            this.Controls.Add(this.dueDateDateTimePicker);
            this.Controls.Add(customerLabel);
            this.Controls.Add(this.customerTextBox);
            this.Controls.Add(productLabel);
            this.Controls.Add(this.productTextBox);
            this.Controls.Add(workOrderIDLabel);
            this.Controls.Add(this.workOrderIDTextBox);
            this.Controls.Add(statusLabel);
            this.Name = "frmAddWorkOrder";
            this.Text = "Add New Work Order";
            this.Load += new System.EventHandler(this.frmAddWorkOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.scheduleDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workOrdersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ScheduleDatabaseDataSet scheduleDatabaseDataSet;
        private System.Windows.Forms.BindingSource workOrdersBindingSource;
        private ScheduleDatabaseDataSetTableAdapters.WorkOrdersTableAdapter workOrdersTableAdapter;
        private ScheduleDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox workOrderIDTextBox;
        private System.Windows.Forms.TextBox productTextBox;
        private System.Windows.Forms.TextBox customerTextBox;
        private System.Windows.Forms.DateTimePicker dueDateDateTimePicker;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtStatus;
    }
}