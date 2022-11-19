using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Accounting.App.Form_Customers;
using Accounting.App.Accounting;

namespace Accounting.App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Customer_Click(object sender, EventArgs e)
        {
            frm_MainCustomer frm_CustomerMenu = new frm_MainCustomer();
            frm_CustomerMenu.ShowDialog();

        }

        private void btn_NewAccounting_Click(object sender, EventArgs e)
        {
            frm_addOrEditAccounting frm_AddAccounting = new frm_addOrEditAccounting();
            frm_AddAccounting.ShowDialog();
            if (frm_AddAccounting.DialogResult == DialogResult.OK)
            {
                MessageBox.Show("با موفقیت ثبت شد");
            }
        }

        private void btn_ReportRecive_Click(object sender, EventArgs e)
        {
            frm_AccountingReports frm_ReportRecive = new frm_AccountingReports();
            frm_ReportRecive.ShowDialog();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            frm_AccountingReports frm_ReportPay = new frm_AccountingReports();
            frm_ReportPay.AccountingType = 2;
            frm_ReportPay.ShowDialog();

        }
    }
}
