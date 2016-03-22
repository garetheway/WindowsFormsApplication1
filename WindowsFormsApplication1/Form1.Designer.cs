namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.lblProdLine1 = new System.Windows.Forms.Label();
            this.lblProdLine2 = new System.Windows.Forms.Label();
            this.scheduleDatabaseDataSet = new WindowsFormsApplication1.ScheduleDatabaseDataSet();
            this.scheduleDatabaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workOrdersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workOrdersTableAdapter = new WindowsFormsApplication1.ScheduleDatabaseDataSetTableAdapters.WorkOrdersTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication1.ScheduleDatabaseDataSetTableAdapters.TableAdapterManager();
            this.lblSwinprod = new System.Windows.Forms.Label();
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.pnlBottom = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleDatabaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workOrdersBindingSource)).BeginInit();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblProdLine1
            // 
            this.lblProdLine1.AutoSize = true;
            this.lblProdLine1.BackColor = System.Drawing.Color.Transparent;
            this.lblProdLine1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdLine1.ForeColor = System.Drawing.Color.White;
            this.lblProdLine1.Location = new System.Drawing.Point(2, 178);
            this.lblProdLine1.Name = "lblProdLine1";
            this.lblProdLine1.Size = new System.Drawing.Size(117, 15);
            this.lblProdLine1.TabIndex = 3;
            this.lblProdLine1.Text = "PRODUCTION LINE 1";
            // 
            // lblProdLine2
            // 
            this.lblProdLine2.AutoSize = true;
            this.lblProdLine2.BackColor = System.Drawing.Color.Transparent;
            this.lblProdLine2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdLine2.ForeColor = System.Drawing.Color.White;
            this.lblProdLine2.Location = new System.Drawing.Point(2, 298);
            this.lblProdLine2.Name = "lblProdLine2";
            this.lblProdLine2.Size = new System.Drawing.Size(117, 15);
            this.lblProdLine2.TabIndex = 4;
            this.lblProdLine2.Text = "PRODUCTION LINE 2";
            this.lblProdLine2.Click += new System.EventHandler(this.label1_Click);
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
            // lblSwinprod
            // 
            this.lblSwinprod.AutoSize = true;
            this.lblSwinprod.BackColor = System.Drawing.Color.Transparent;
            this.lblSwinprod.Font = new System.Drawing.Font("Calibri Light", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSwinprod.ForeColor = System.Drawing.Color.White;
            this.lblSwinprod.Location = new System.Drawing.Point(2, 4);
            this.lblSwinprod.Name = "lblSwinprod";
            this.lblSwinprod.Size = new System.Drawing.Size(340, 26);
            this.lblSwinprod.TabIndex = 5;
            this.lblSwinprod.Text = "SWINDON PRODUCTION SCHEDULE";
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.btnAddNew);
            this.panelTop.Location = new System.Drawing.Point(-7, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1935, 166);
            this.panelTop.TabIndex = 6;
            // 
            // btnAddNew
            // 
            this.btnAddNew.BackColor = System.Drawing.Color.White;
            this.btnAddNew.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNew.Location = new System.Drawing.Point(1548, 5);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(194, 30);
            this.btnAddNew.TabIndex = 0;
            this.btnAddNew.Text = "Add New Work Order";
            this.btnAddNew.UseVisualStyleBackColor = false;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // pnlBottom
            // 
            this.pnlBottom.Location = new System.Drawing.Point(0, 166);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(1928, 889);
            this.pnlBottom.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1042);
            this.Controls.Add(this.lblSwinprod);
            this.Controls.Add(this.lblProdLine2);
            this.Controls.Add(this.lblProdLine1);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.pnlBottom);
            this.Name = "Form1";
            this.Text = "SWINDON PRODUCTION SCHEDULE";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.scheduleDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleDatabaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workOrdersBindingSource)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProdLine1;
        private System.Windows.Forms.Label lblProdLine2;
        private System.Windows.Forms.BindingSource scheduleDatabaseDataSetBindingSource;
        private ScheduleDatabaseDataSet scheduleDatabaseDataSet;
        private System.Windows.Forms.BindingSource workOrdersBindingSource;
        private ScheduleDatabaseDataSetTableAdapters.WorkOrdersTableAdapter workOrdersTableAdapter;
        private ScheduleDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label lblSwinprod;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Panel pnlBottom;



    }
}

