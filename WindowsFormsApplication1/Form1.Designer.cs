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
            this.prodLine1txt = new System.Windows.Forms.TextBox();
            this.prodLine2txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // prodLine1txt
            // 
            this.prodLine1txt.Location = new System.Drawing.Point(12, 68);
            this.prodLine1txt.Multiline = true;
            this.prodLine1txt.Name = "prodLine1txt";
            this.prodLine1txt.Size = new System.Drawing.Size(544, 25);
            this.prodLine1txt.TabIndex = 0;
            // 
            // prodLine2txt
            // 
            this.prodLine2txt.Location = new System.Drawing.Point(12, 145);
            this.prodLine2txt.Multiline = true;
            this.prodLine2txt.Name = "prodLine2txt";
            this.prodLine2txt.Size = new System.Drawing.Size(544, 25);
            this.prodLine2txt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "PRODUCTION LINE 2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "PRODUCTION LINE 1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 306);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.prodLine2txt);
            this.Controls.Add(this.prodLine1txt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox prodLine1txt;
        private System.Windows.Forms.TextBox prodLine2txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;



    }
}

