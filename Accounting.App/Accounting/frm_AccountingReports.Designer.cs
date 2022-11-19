
namespace Accounting.App.Accounting
{
    partial class frm_AccountingReports
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
            this.btn_EditAccounting = new System.Windows.Forms.ToolStripButton();
            this.btn_DeleteAccounting = new System.Windows.Forms.ToolStripButton();
            this.btn_Refesh = new System.Windows.Forms.ToolStripButton();
            this.btn_Print = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txt_Serach = new System.Windows.Forms.ToolStripTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.mtxt_ToDate = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mtxt_FromDate = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_CustomerList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_AccountingList = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AccountingList)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_EditAccounting,
            this.btn_DeleteAccounting,
            this.btn_Refesh,
            this.btn_Print,
            this.toolStripLabel1,
            this.txt_Serach});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(800, 62);
            this.toolStrip2.TabIndex = 3;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // btn_EditAccounting
            // 
            this.btn_EditAccounting.Image = global::Accounting.App.Properties.Resources._1371475973_document_edit;
            this.btn_EditAccounting.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_EditAccounting.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_EditAccounting.Name = "btn_EditAccounting";
            this.btn_EditAccounting.Size = new System.Drawing.Size(47, 59);
            this.btn_EditAccounting.Text = "ویرایش";
            this.btn_EditAccounting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btn_DeleteAccounting
            // 
            this.btn_DeleteAccounting.Image = global::Accounting.App.Properties.Resources._1371476007_Close_Box_Red;
            this.btn_DeleteAccounting.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_DeleteAccounting.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_DeleteAccounting.Name = "btn_DeleteAccounting";
            this.btn_DeleteAccounting.Size = new System.Drawing.Size(44, 59);
            this.btn_DeleteAccounting.Text = "حذف";
            this.btn_DeleteAccounting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btn_Refesh
            // 
            this.btn_Refesh.Image = global::Accounting.App.Properties.Resources._1371476368_Synchronize;
            this.btn_Refesh.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_Refesh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Refesh.Name = "btn_Refesh";
            this.btn_Refesh.Size = new System.Drawing.Size(73, 59);
            this.btn_Refesh.Text = "به روز رسانی";
            this.btn_Refesh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Refesh.Click += new System.EventHandler(this.btn_Refesh_Click);
            // 
            // btn_Print
            // 
            this.btn_Print.Image = global::Accounting.App.Properties.Resources._1371476276_Print;
            this.btn_Print.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_Print.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(44, 59);
            this.btn_Print.Text = "چاپ";
            this.btn_Print.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
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
            this.txt_Serach.Size = new System.Drawing.Size(180, 62);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Search);
            this.groupBox1.Controls.Add(this.mtxt_ToDate);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.mtxt_FromDate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmb_CustomerList);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 99);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "جستجو";
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(7, 70);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 23);
            this.btn_Search.TabIndex = 6;
            this.btn_Search.Text = "جستحو";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // mtxt_ToDate
            // 
            this.mtxt_ToDate.Location = new System.Drawing.Point(103, 33);
            this.mtxt_ToDate.Mask = "0000/00/00";
            this.mtxt_ToDate.Name = "mtxt_ToDate";
            this.mtxt_ToDate.Size = new System.Drawing.Size(122, 20);
            this.mtxt_ToDate.TabIndex = 5;
            this.mtxt_ToDate.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(231, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "تا تاریخ :";
            // 
            // mtxt_FromDate
            // 
            this.mtxt_FromDate.Location = new System.Drawing.Point(301, 30);
            this.mtxt_FromDate.Mask = "0000/00/00";
            this.mtxt_FromDate.Name = "mtxt_FromDate";
            this.mtxt_FromDate.Size = new System.Drawing.Size(122, 20);
            this.mtxt_FromDate.TabIndex = 3;
            this.mtxt_FromDate.ValidatingType = typeof(System.DateTime);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(429, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "از تاریخ :";
            // 
            // cmb_CustomerList
            // 
            this.cmb_CustomerList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_CustomerList.FormattingEnabled = true;
            this.cmb_CustomerList.Location = new System.Drawing.Point(493, 30);
            this.cmb_CustomerList.Name = "cmb_CustomerList";
            this.cmb_CustomerList.Size = new System.Drawing.Size(203, 21);
            this.cmb_CustomerList.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(702, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "طرف حساب :";
            // 
            // dgv_AccountingList
            // 
            this.dgv_AccountingList.AllowUserToAddRows = false;
            this.dgv_AccountingList.AllowUserToDeleteRows = false;
            this.dgv_AccountingList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_AccountingList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_AccountingList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column6,
            this.Column4,
            this.Column5});
            this.dgv_AccountingList.Location = new System.Drawing.Point(12, 171);
            this.dgv_AccountingList.Name = "dgv_AccountingList";
            this.dgv_AccountingList.ReadOnly = true;
            this.dgv_AccountingList.Size = new System.Drawing.Size(776, 267);
            this.dgv_AccountingList.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "AccountingID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "نام و نام خانوادگی";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "نوع تراکنش";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "مبلغ";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "زمان";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "توضیحات";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // frm_AccountingReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_AccountingList);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip2);
            this.Name = "frm_AccountingReports";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Load += new System.EventHandler(this.frm_AccountingReports_Load);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AccountingList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btn_EditAccounting;
        private System.Windows.Forms.ToolStripButton btn_DeleteAccounting;
        private System.Windows.Forms.ToolStripButton btn_Refesh;
        private System.Windows.Forms.ToolStripButton btn_Print;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox txt_Serach;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.MaskedTextBox mtxt_ToDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mtxt_FromDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_CustomerList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_AccountingList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}