namespace WindowsFormsApplication1
{
    partial class frmUnallocatedOrderDetail
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
            System.Windows.Forms.Label workOrderIDLabel;
            System.Windows.Forms.Label quantityLabel;
            System.Windows.Forms.Label dueDateLabel;
            System.Windows.Forms.Label customerLabel;
            System.Windows.Forms.Label productLabel;
            System.Windows.Forms.Label label1;
            this.scheduleDatabaseDataSet = new WindowsFormsApplication1.ScheduleDatabaseDataSet();
            this.workOrdersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workOrdersTableAdapter = new WindowsFormsApplication1.ScheduleDatabaseDataSetTableAdapters.WorkOrdersTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication1.ScheduleDatabaseDataSetTableAdapters.TableAdapterManager();
            this.txtWorkOrderID = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtDueDate = new System.Windows.Forms.DateTimePicker();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.txtProduct = new System.Windows.Forms.TextBox();
            this.chckReadySchedule = new System.Windows.Forms.CheckBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            workOrderIDLabel = new System.Windows.Forms.Label();
            quantityLabel = new System.Windows.Forms.Label();
            dueDateLabel = new System.Windows.Forms.Label();
            customerLabel = new System.Windows.Forms.Label();
            productLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workOrdersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // workOrderIDLabel
            // 
            workOrderIDLabel.AutoSize = true;
            workOrderIDLabel.Location = new System.Drawing.Point(5, 10);
            workOrderIDLabel.Name = "workOrderIDLabel";
            workOrderIDLabel.Size = new System.Drawing.Size(79, 13);
            workOrderIDLabel.TabIndex = 1;
            workOrderIDLabel.Text = "Work Order ID:";
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.Location = new System.Drawing.Point(5, 124);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new System.Drawing.Size(49, 13);
            quantityLabel.TabIndex = 18;
            quantityLabel.Text = "Quantity:";
            // 
            // dueDateLabel
            // 
            dueDateLabel.AutoSize = true;
            dueDateLabel.Location = new System.Drawing.Point(5, 93);
            dueDateLabel.Name = "dueDateLabel";
            dueDateLabel.Size = new System.Drawing.Size(56, 13);
            dueDateLabel.TabIndex = 16;
            dueDateLabel.Text = "Due Date:";
            // 
            // customerLabel
            // 
            customerLabel.AutoSize = true;
            customerLabel.Location = new System.Drawing.Point(5, 62);
            customerLabel.Name = "customerLabel";
            customerLabel.Size = new System.Drawing.Size(54, 13);
            customerLabel.TabIndex = 14;
            customerLabel.Text = "Customer:";
            // 
            // productLabel
            // 
            productLabel.AutoSize = true;
            productLabel.Location = new System.Drawing.Point(5, 36);
            productLabel.Name = "productLabel";
            productLabel.Size = new System.Drawing.Size(47, 13);
            productLabel.TabIndex = 12;
            productLabel.Text = "Product:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(5, 157);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(101, 13);
            label1.TabIndex = 21;
            label1.Text = "Ready to Schedule:";
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
            // txtWorkOrderID
            // 
            this.txtWorkOrderID.Location = new System.Drawing.Point(90, 7);
            this.txtWorkOrderID.Name = "txtWorkOrderID";
            this.txtWorkOrderID.Size = new System.Drawing.Size(100, 20);
            this.txtWorkOrderID.TabIndex = 2;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(90, 121);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtQuantity.TabIndex = 19;
            // 
            // txtDueDate
            // 
            this.txtDueDate.Location = new System.Drawing.Point(90, 87);
            this.txtDueDate.Name = "txtDueDate";
            this.txtDueDate.Size = new System.Drawing.Size(200, 20);
            this.txtDueDate.TabIndex = 17;
            // 
            // txtCustomer
            // 
            this.txtCustomer.Location = new System.Drawing.Point(90, 59);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(100, 20);
            this.txtCustomer.TabIndex = 15;
            // 
            // txtProduct
            // 
            this.txtProduct.Location = new System.Drawing.Point(90, 33);
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Size = new System.Drawing.Size(100, 20);
            this.txtProduct.TabIndex = 13;
            // 
            // chckReadySchedule
            // 
            this.chckReadySchedule.AutoSize = true;
            this.chckReadySchedule.Location = new System.Drawing.Point(129, 157);
            this.chckReadySchedule.Name = "chckReadySchedule";
            this.chckReadySchedule.Size = new System.Drawing.Size(15, 14);
            this.chckReadySchedule.TabIndex = 22;
            this.chckReadySchedule.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(239, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(91, 23);
            this.btnUpdate.TabIndex = 23;
            this.btnUpdate.Text = "Update Order";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // frmUnallocatedOrderDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 262);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.chckReadySchedule);
            this.Controls.Add(label1);
            this.Controls.Add(quantityLabel);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(dueDateLabel);
            this.Controls.Add(this.txtDueDate);
            this.Controls.Add(customerLabel);
            this.Controls.Add(this.txtCustomer);
            this.Controls.Add(productLabel);
            this.Controls.Add(this.txtProduct);
            this.Controls.Add(workOrderIDLabel);
            this.Controls.Add(this.txtWorkOrderID);
            this.Name = "frmUnallocatedOrderDetail";
            this.Text = "Work Order - Detailed View";
            this.Load += new System.EventHandler(this.frmUnallocatedOrderDetail_Load);
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
        private System.Windows.Forms.TextBox txtWorkOrderID;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.DateTimePicker txtDueDate;
        private System.Windows.Forms.TextBox txtCustomer;
        private System.Windows.Forms.TextBox txtProduct;
        private System.Windows.Forms.CheckBox chckReadySchedule;
        private System.Windows.Forms.Button btnUpdate;
    }
}