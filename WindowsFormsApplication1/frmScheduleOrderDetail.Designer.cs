namespace WindowsFormsApplication1
{
    partial class frmScheduleOrderDetail
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
            System.Windows.Forms.Label quantityLabel;
            System.Windows.Forms.Label dueDateLabel;
            System.Windows.Forms.Label customerLabel;
            System.Windows.Forms.Label productLabel;
            System.Windows.Forms.Label workOrderIDLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.txtProduct = new System.Windows.Forms.TextBox();
            this.txtWorkOrderID = new System.Windows.Forms.TextBox();
            this.txtDueDate = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.txtOrderNotes = new System.Windows.Forms.RichTextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.scheduleDatabaseDataSet = new WindowsFormsApplication1.ScheduleDatabaseDataSet();
            this.workOrdersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workOrdersTableAdapter = new WindowsFormsApplication1.ScheduleDatabaseDataSetTableAdapters.WorkOrdersTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication1.ScheduleDatabaseDataSetTableAdapters.TableAdapterManager();
            this.btnArchive = new System.Windows.Forms.Button();
            quantityLabel = new System.Windows.Forms.Label();
            dueDateLabel = new System.Windows.Forms.Label();
            customerLabel = new System.Windows.Forms.Label();
            productLabel = new System.Windows.Forms.Label();
            workOrderIDLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workOrdersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.Location = new System.Drawing.Point(6, 121);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new System.Drawing.Size(76, 13);
            quantityLabel.TabIndex = 28;
            quantityLabel.Text = "Total Quantity:";
            // 
            // dueDateLabel
            // 
            dueDateLabel.AutoSize = true;
            dueDateLabel.Location = new System.Drawing.Point(6, 92);
            dueDateLabel.Name = "dueDateLabel";
            dueDateLabel.Size = new System.Drawing.Size(56, 13);
            dueDateLabel.TabIndex = 26;
            dueDateLabel.Text = "Due Date:";
            // 
            // customerLabel
            // 
            customerLabel.AutoSize = true;
            customerLabel.Location = new System.Drawing.Point(6, 61);
            customerLabel.Name = "customerLabel";
            customerLabel.Size = new System.Drawing.Size(54, 13);
            customerLabel.TabIndex = 24;
            customerLabel.Text = "Customer:";
            // 
            // productLabel
            // 
            productLabel.AutoSize = true;
            productLabel.Location = new System.Drawing.Point(6, 35);
            productLabel.Name = "productLabel";
            productLabel.Size = new System.Drawing.Size(47, 13);
            productLabel.TabIndex = 22;
            productLabel.Text = "Product:";
            // 
            // workOrderIDLabel
            // 
            workOrderIDLabel.AutoSize = true;
            workOrderIDLabel.Location = new System.Drawing.Point(6, 9);
            workOrderIDLabel.Name = "workOrderIDLabel";
            workOrderIDLabel.Size = new System.Drawing.Size(79, 13);
            workOrderIDLabel.TabIndex = 20;
            workOrderIDLabel.Text = "Work Order ID:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(9, 78);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(67, 13);
            label1.TabIndex = 32;
            label1.Text = "Order Notes:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(9, 27);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(69, 13);
            label2.TabIndex = 34;
            label2.Text = "Order Status:";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Enabled = false;
            this.txtQuantity.Location = new System.Drawing.Point(97, 118);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtQuantity.TabIndex = 29;
            // 
            // txtCustomer
            // 
            this.txtCustomer.Enabled = false;
            this.txtCustomer.Location = new System.Drawing.Point(97, 58);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(100, 20);
            this.txtCustomer.TabIndex = 25;
            // 
            // txtProduct
            // 
            this.txtProduct.Enabled = false;
            this.txtProduct.Location = new System.Drawing.Point(97, 32);
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Size = new System.Drawing.Size(100, 20);
            this.txtProduct.TabIndex = 23;
            // 
            // txtWorkOrderID
            // 
            this.txtWorkOrderID.Enabled = false;
            this.txtWorkOrderID.Location = new System.Drawing.Point(97, 6);
            this.txtWorkOrderID.Name = "txtWorkOrderID";
            this.txtWorkOrderID.Size = new System.Drawing.Size(100, 20);
            this.txtWorkOrderID.TabIndex = 21;
            // 
            // txtDueDate
            // 
            this.txtDueDate.Enabled = false;
            this.txtDueDate.Location = new System.Drawing.Point(97, 88);
            this.txtDueDate.Name = "txtDueDate";
            this.txtDueDate.Size = new System.Drawing.Size(100, 20);
            this.txtDueDate.TabIndex = 30;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.cmbStatus);
            this.panel1.Controls.Add(label2);
            this.panel1.Controls.Add(this.txtOrderNotes);
            this.panel1.Controls.Add(label1);
            this.panel1.Location = new System.Drawing.Point(-3, 146);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(371, 206);
            this.panel1.TabIndex = 31;
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "SCHED",
            "WIP",
            "KITTING",
            "HOLD"});
            this.cmbStatus.Location = new System.Drawing.Point(100, 24);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(121, 21);
            this.cmbStatus.TabIndex = 35;
            // 
            // txtOrderNotes
            // 
            this.txtOrderNotes.Location = new System.Drawing.Point(100, 78);
            this.txtOrderNotes.Name = "txtOrderNotes";
            this.txtOrderNotes.Size = new System.Drawing.Size(240, 96);
            this.txtOrderNotes.TabIndex = 33;
            this.txtOrderNotes.Text = "";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(239, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(91, 23);
            this.btnUpdate.TabIndex = 36;
            this.btnUpdate.Text = "Update Order";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
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
            // btnArchive
            // 
            this.btnArchive.Location = new System.Drawing.Point(239, 35);
            this.btnArchive.Name = "btnArchive";
            this.btnArchive.Size = new System.Drawing.Size(91, 23);
            this.btnArchive.TabIndex = 37;
            this.btnArchive.Text = "Archive Order";
            this.btnArchive.UseVisualStyleBackColor = true;
            this.btnArchive.Click += new System.EventHandler(this.btnArchive_Click);
            // 
            // frmScheduleOrderDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 340);
            this.Controls.Add(this.btnArchive);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtDueDate);
            this.Controls.Add(quantityLabel);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(dueDateLabel);
            this.Controls.Add(customerLabel);
            this.Controls.Add(this.txtCustomer);
            this.Controls.Add(productLabel);
            this.Controls.Add(this.txtProduct);
            this.Controls.Add(workOrderIDLabel);
            this.Controls.Add(this.txtWorkOrderID);
            this.Name = "frmScheduleOrderDetail";
            this.Text = "frmScheduleOrderDetail";
            this.Load += new System.EventHandler(this.frmScheduleOrderDetail_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workOrdersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtCustomer;
        private System.Windows.Forms.TextBox txtProduct;
        private System.Windows.Forms.TextBox txtWorkOrderID;
        private System.Windows.Forms.TextBox txtDueDate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.RichTextBox txtOrderNotes;
        private System.Windows.Forms.Button btnUpdate;
        private ScheduleDatabaseDataSet scheduleDatabaseDataSet;
        private System.Windows.Forms.BindingSource workOrdersBindingSource;
        private ScheduleDatabaseDataSetTableAdapters.WorkOrdersTableAdapter workOrdersTableAdapter;
        private ScheduleDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button btnArchive;
    }
}