﻿namespace WindowsFormsApplication1
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
            this.lblSwinprod = new System.Windows.Forms.Label();
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnArchive = new System.Windows.Forms.Button();
            this.btnRunSchedule = new System.Windows.Forms.Button();
            this.pnlUnallocated = new System.Windows.Forms.Panel();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.pnlLine2 = new System.Windows.Forms.Panel();
            this.pnlLine1 = new System.Windows.Forms.Panel();
            this.linesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.linesTableAdapter = new WindowsFormsApplication1.ScheduleDatabaseDataSetTableAdapters.LinesTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication1.ScheduleDatabaseDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleDatabaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workOrdersBindingSource)).BeginInit();
            this.panelTop.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.linesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProdLine1
            // 
            this.lblProdLine1.AutoSize = true;
            this.lblProdLine1.BackColor = System.Drawing.Color.Transparent;
            this.lblProdLine1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdLine1.ForeColor = System.Drawing.Color.White;
            this.lblProdLine1.Location = new System.Drawing.Point(9, 12);
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
            this.lblProdLine2.Location = new System.Drawing.Point(9, 142);
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
            this.panelTop.Controls.Add(this.btnArchive);
            this.panelTop.Controls.Add(this.btnRunSchedule);
            this.panelTop.Controls.Add(this.pnlUnallocated);
            this.panelTop.Controls.Add(this.btnAddNew);
            this.panelTop.Location = new System.Drawing.Point(-7, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1935, 164);
            this.panelTop.TabIndex = 6;
            // 
            // btnArchive
            // 
            this.btnArchive.BackColor = System.Drawing.Color.White;
            this.btnArchive.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArchive.Location = new System.Drawing.Point(1752, 5);
            this.btnArchive.Name = "btnArchive";
            this.btnArchive.Size = new System.Drawing.Size(123, 30);
            this.btnArchive.TabIndex = 3;
            this.btnArchive.Text = "Archive";
            this.btnArchive.UseVisualStyleBackColor = false;
            this.btnArchive.Click += new System.EventHandler(this.btnArchive_Click);
            // 
            // btnRunSchedule
            // 
            this.btnRunSchedule.BackColor = System.Drawing.Color.White;
            this.btnRunSchedule.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.btnRunSchedule.Location = new System.Drawing.Point(14, 128);
            this.btnRunSchedule.Name = "btnRunSchedule";
            this.btnRunSchedule.Size = new System.Drawing.Size(120, 27);
            this.btnRunSchedule.TabIndex = 2;
            this.btnRunSchedule.Text = "Schedule";
            this.btnRunSchedule.UseVisualStyleBackColor = false;
            this.btnRunSchedule.Click += new System.EventHandler(this.btnRunSchedule_Click);
            // 
            // pnlUnallocated
            // 
            this.pnlUnallocated.Location = new System.Drawing.Point(14, 41);
            this.pnlUnallocated.Name = "pnlUnallocated";
            this.pnlUnallocated.Size = new System.Drawing.Size(2240, 81);
            this.pnlUnallocated.TabIndex = 1;
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
            this.pnlBottom.Controls.Add(this.pnlLine2);
            this.pnlBottom.Controls.Add(this.lblProdLine2);
            this.pnlBottom.Controls.Add(this.pnlLine1);
            this.pnlBottom.Controls.Add(this.lblProdLine1);
            this.pnlBottom.Location = new System.Drawing.Point(0, 164);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(1935, 900);
            this.pnlBottom.TabIndex = 7;
            // 
            // pnlLine2
            // 
            this.pnlLine2.Location = new System.Drawing.Point(12, 160);
            this.pnlLine2.Name = "pnlLine2";
            this.pnlLine2.Size = new System.Drawing.Size(1880, 277);
            this.pnlLine2.TabIndex = 1;
            // 
            // pnlLine1
            // 
            this.pnlLine1.Location = new System.Drawing.Point(12, 30);
            this.pnlLine1.Name = "pnlLine1";
            this.pnlLine1.Size = new System.Drawing.Size(1880, 100);
            this.pnlLine1.TabIndex = 0;
            // 
            // linesBindingSource
            // 
            this.linesBindingSource.DataMember = "Lines";
            this.linesBindingSource.DataSource = this.scheduleDatabaseDataSet;
            // 
            // linesTableAdapter
            // 
            this.linesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.LinesTableAdapter = this.linesTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplication1.ScheduleDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WorkOrdersTableAdapter = this.workOrdersTableAdapter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1952, 1062);
            this.Controls.Add(this.lblSwinprod);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.panelTop);
            this.Name = "Form1";
            this.Text = "SWINDON PRODUCTION SCHEDULE";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.scheduleDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleDatabaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workOrdersBindingSource)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.pnlBottom.ResumeLayout(false);
            this.pnlBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.linesBindingSource)).EndInit();
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
        private System.Windows.Forms.Label lblSwinprod;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Panel pnlLine1;
        private System.Windows.Forms.Panel pnlLine2;
        private System.Windows.Forms.Panel pnlUnallocated;
        private System.Windows.Forms.Button btnRunSchedule;
        private System.Windows.Forms.Button btnArchive;
        private System.Windows.Forms.BindingSource linesBindingSource;
        private ScheduleDatabaseDataSetTableAdapters.LinesTableAdapter linesTableAdapter;
        private ScheduleDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;



    }
}

