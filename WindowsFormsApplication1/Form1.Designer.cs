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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.scheduleDatabaseDataSet = new WindowsFormsApplication1.ScheduleDatabaseDataSet();
            this.scheduleDatabaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workOrdersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workOrdersTableAdapter = new WindowsFormsApplication1.ScheduleDatabaseDataSetTableAdapters.WorkOrdersTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication1.ScheduleDatabaseDataSetTableAdapters.TableAdapterManager();
            this.lblSwinprod = new System.Windows.Forms.Label();
            this.panelTop = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleDatabaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workOrdersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "PRODUCTION LINE 1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 298);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "PRODUCTION LINE 2";
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            this.panelTop.Location = new System.Drawing.Point(-7, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1507, 166);
            this.panelTop.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 506);
            this.Controls.Add(this.lblSwinprod);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panelTop);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.scheduleDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleDatabaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workOrdersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource scheduleDatabaseDataSetBindingSource;
        private ScheduleDatabaseDataSet scheduleDatabaseDataSet;
        private System.Windows.Forms.BindingSource workOrdersBindingSource;
        private ScheduleDatabaseDataSetTableAdapters.WorkOrdersTableAdapter workOrdersTableAdapter;
        private ScheduleDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label lblSwinprod;
        private System.Windows.Forms.Panel panelTop;



    }
}

