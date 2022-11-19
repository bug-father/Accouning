
namespace Accounting.App.Form_Customers
{
    partial class frm_MainCustomer
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
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btn_Customer = new System.Windows.Forms.ToolStripButton();
            this.btn_EditCustomer = new System.Windows.Forms.ToolStripButton();
            this.btn_DeleteCustomer = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txt_Serach = new System.Windows.Forms.ToolStripTextBox();
            this.dgv_Customers = new System.Windows.Forms.DataGridView();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Customers)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Customer,
            this.btn_EditCustomer,
            this.btn_DeleteCustomer,
            this.toolStripButton2,
            this.toolStripLabel1,
            this.txt_Serach});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(800, 62);
            this.toolStrip2.TabIndex = 2;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // btn_Customer
            // 
            this.btn_Customer.Image = global::Accounting.App.Properties.Resources._1371475930_filenew;
            this.btn_Customer.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_Customer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Customer.Name = "btn_Customer";
            this.btn_Customer.Size = new System.Drawing.Size(44, 59);
            this.btn_Customer.Text = "افزودن";
            this.btn_Customer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btn_EditCustomer
            // 
            this.btn_EditCustomer.Image = global::Accounting.App.Properties.Resources._1371475973_document_edit;
            this.btn_EditCustomer.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_EditCustomer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_EditCustomer.Name = "btn_EditCustomer";
            this.btn_EditCustomer.Size = new System.Drawing.Size(47, 59);
            this.btn_EditCustomer.Text = "ویرایش";
            this.btn_EditCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btn_DeleteCustomer
            // 
            this.btn_DeleteCustomer.Image = global::Accounting.App.Properties.Resources._1371476007_Close_Box_Red;
            this.btn_DeleteCustomer.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_DeleteCustomer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_DeleteCustomer.Name = "btn_DeleteCustomer";
            this.btn_DeleteCustomer.Size = new System.Drawing.Size(44, 59);
            this.btn_DeleteCustomer.Text = "حذف";
            this.btn_DeleteCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = global::Accounting.App.Properties.Resources._1371476368_Synchronize;
            this.toolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(73, 59);
            this.toolStripButton2.Text = "به روز رسانی";
            this.toolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(41, 59);
            this.toolStripLabel1.Text = "جستجو";
            // 
            // txt_Serach
            // 
            this.txt_Serach.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_Serach.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Serach.Name = "txt_Serach";
            this.txt_Serach.Size = new System.Drawing.Size(100, 62);
            // 
            // dgv_Customers
            // 
            this.dgv_Customers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Customers.Location = new System.Drawing.Point(12, 66);
            this.dgv_Customers.Name = "dgv_Customers";
            this.dgv_Customers.Size = new System.Drawing.Size(776, 372);
            this.dgv_Customers.TabIndex = 3;
            // 
            // frm_MainCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_Customers);
            this.Controls.Add(this.toolStrip2);
            this.Name = "frm_MainCustomer";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "طرف حساب";
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Customers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btn_Customer;
        private System.Windows.Forms.ToolStripButton btn_EditCustomer;
        private System.Windows.Forms.ToolStripButton btn_DeleteCustomer;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox txt_Serach;
        private System.Windows.Forms.DataGridView dgv_Customers;
    }
}