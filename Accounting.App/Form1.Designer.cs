
namespace Accounting.App
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btn_Customer = new System.Windows.Forms.ToolStripButton();
            this.btn_NewAccounting = new System.Windows.Forms.ToolStripButton();
            this.btn_ReportRecive = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(63, 22);
            this.toolStripDropDownButton1.Text = "تنظیمات";
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Customer,
            this.btn_NewAccounting,
            this.btn_ReportRecive,
            this.toolStripButton2});
            this.toolStrip2.Location = new System.Drawing.Point(0, 25);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(800, 62);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // btn_Customer
            // 
            this.btn_Customer.Image = global::Accounting.App.Properties.Resources._1371476468_preferences_contact_list;
            this.btn_Customer.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_Customer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Customer.Name = "btn_Customer";
            this.btn_Customer.Size = new System.Drawing.Size(71, 59);
            this.btn_Customer.Text = "طرف حساب";
            this.btn_Customer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Customer.Click += new System.EventHandler(this.btn_Customer_Click);
            // 
            // btn_NewAccounting
            // 
            this.btn_NewAccounting.Image = global::Accounting.App.Properties.Resources._1371476499_todo_list;
            this.btn_NewAccounting.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_NewAccounting.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_NewAccounting.Name = "btn_NewAccounting";
            this.btn_NewAccounting.Size = new System.Drawing.Size(72, 59);
            this.btn_NewAccounting.Text = "تراکنش جدید";
            this.btn_NewAccounting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_NewAccounting.Click += new System.EventHandler(this.btn_NewAccounting_Click);
            // 
            // btn_ReportRecive
            // 
            this.btn_ReportRecive.Image = global::Accounting.App.Properties.Resources.servicesCosts;
            this.btn_ReportRecive.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_ReportRecive.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_ReportRecive.Name = "btn_ReportRecive";
            this.btn_ReportRecive.Size = new System.Drawing.Size(98, 59);
            this.btn_ReportRecive.Text = "گزارش دریافتی ها";
            this.btn_ReportRecive.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_ReportRecive.Click += new System.EventHandler(this.btn_ReportRecive_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = global::Accounting.App.Properties.Resources._1370791030_credit_card;
            this.toolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(97, 59);
            this.toolStripButton2.Text = "گزارش پرداختی ها";
            this.toolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "حسابداری شخصی من";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btn_Customer;
        private System.Windows.Forms.ToolStripButton btn_NewAccounting;
        private System.Windows.Forms.ToolStripButton btn_ReportRecive;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
    }
}

