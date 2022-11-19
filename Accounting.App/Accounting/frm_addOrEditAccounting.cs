using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Accounting.DataLayer.Context;
using Accounting.ViewModels.Customer;
using ValidationComponents;
using Accounting.DataLayer;


namespace Accounting.App.Accounting
{
    public partial class frm_addOrEditAccounting : Form
    {
        public int AccountingID = 0;
        public frm_addOrEditAccounting()
        {
            InitializeComponent();
        }

        private void frm_addOrEditAccounting_Load(object sender, EventArgs e)
        {
            dgv_Customerlist.AutoGenerateColumns = false;
            using (UnitOfWork db = new UnitOfWork())
            {
                dgv_Customerlist.DataSource = db.CustomerRepository.GetAllAndSearch().Select
                    (x => new GetNameAndCustomerID
                    {
                        FullName = x.FullName,
                        CustomerID = x.CustomerID


                    }).ToList();

            }
        }

        private void dgv_Customerlist_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_CustomerName.Text = dgv_Customerlist.CurrentRow.Cells[1].Value.ToString();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (BaseValidator.IsFormValid(this.components))
            {
                if (rbtn_Pay.Checked || rbtn_Recive.Checked)
                {
                    DataLayer.Accounting AddEditAccounting = new DataLayer.Accounting()
                    {
                        Amount = int.Parse(txt_Amount.Text),
                        CustomerID = int.Parse(dgv_Customerlist.CurrentRow.Cells[0].Value.ToString()),
                        TypeID = (rbtn_Recive.Checked) ? 1 : 2,
                        Description = txt_Description.Text,
                        DateTime = DateTime.Now
                    };

                    using (UnitOfWork db = new UnitOfWork())
                    {
                        db.AccountingRepository.Insert(AddEditAccounting);
                        db.saveChange();
                        DialogResult = DialogResult.OK;

                    }
                };


            }
            else
            {
                MessageBox.Show("نوع تراکنش را مشخص کنید");
            }
        }



    }

}

    

