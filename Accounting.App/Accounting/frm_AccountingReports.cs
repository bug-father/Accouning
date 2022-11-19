using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Accounting.DataLayer.Context;
using Accounting.ViewModels.Customer;
using Accounting.Utility.Convertor;


namespace Accounting.App.Accounting
{

    public partial class frm_AccountingReports : Form
    {
        public int AccountingType = 1;
        public frm_AccountingReports()
        {
            InitializeComponent();
        }

        private void frm_AccountingReports_Load(object sender, EventArgs e)
        {

            cmb_CustomerList.DisplayMember = "milad";
            if (AccountingType == 1)
            {
                this.Text = "گزارش دریافتی ها";
            }
            else
            {
                this.Text = "";
            }
            Refresh();
            List<GetNameAndCustomerID> list = new List<GetNameAndCustomerID>()
            { new GetNameAndCustomerID { CustomerID = 0, FullName = "یک شخص را انتخاب کنید" } };

            using (UnitOfWork db = new UnitOfWork())
            {
                var Customerlist = db.CustomerRepository.GetAllAndSearch()
                    .Select(x => new GetNameAndCustomerID { FullName = x.FullName, CustomerID = x.CustomerID }).ToList();
                list.AddRange(Customerlist);
                cmb_CustomerList.DisplayMember = "FullName";
                cmb_CustomerList.ValueMember = "CustomerID";
                cmb_CustomerList.DataSource = list;
            }


        }

        private void Refresh()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                dgv_AccountingList.Rows.Clear();
                dgv_AccountingList.AutoGenerateColumns = false;
                IEnumerable<DataLayer.Accounting> List = db.AccountingRepository.GetAllAndSearch(x => x.TypeID == AccountingType).ToList();

                foreach (DataLayer.Accounting result in List)
                {
                    string FullName = db.CustomerRepository.GetByID(result.CustomerID).FullName;
                    dgv_AccountingList.Rows.Add
                        (result.AccountingID, FullName, result.AccountingType1.TypeTitle, result.Amount,
                        ConvertTime.Shamsi(result.DateTime)
                        , result.Description);

                }
            }
        }

        private void btn_Refesh_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {

            using (UnitOfWork db = new UnitOfWork())
            {

                List<DataLayer.Accounting> AccountingList = new List<DataLayer.Accounting>();
                DateTime? FromDate;
                DateTime? ToDate;

                if ((int)cmb_CustomerList.SelectedValue != 0)
                {
                    int customerID = int.Parse(cmb_CustomerList.SelectedValue.ToString());
                    AccountingList.AddRange(db.AccountingRepository.GetAllAndSearch(x => x.AccountingType1.TypeID == AccountingType && x.CustomerID == customerID));

                }
                else
                {
                    AccountingList.AddRange(db.AccountingRepository.GetAllAndSearch(x => x.AccountingType1.TypeID == AccountingType));
                }
                if (mtxt_FromDate.Text != "    /  /")
                {
                    FromDate = DateTime.Parse(mtxt_FromDate.Text.ToString());
                    FromDate = new DateTime(FromDate.Value.Year, FromDate.Value.Month, FromDate.Value.Day, new System.Globalization.PersianCalendar());

                    AccountingList = AccountingList.Where(x => x.DateTime >= FromDate.Value).ToList();



                }
                if (mtxt_ToDate.Text != "    /  /")
                {
                    ToDate = DateTime.Parse(mtxt_FromDate.Text.ToString());
                    ToDate = new DateTime(ToDate.Value.Year, ToDate.Value.Month, ToDate.Value.Day, new System.Globalization.PersianCalendar());

                    AccountingList = AccountingList.Where(x => x.DateTime <= ToDate.Value).ToList();

                }



                dgv_AccountingList.Rows.Clear();

                foreach (var result in AccountingList)
                {
                    int CustomerID = result.CustomerID;
                    string FullName = db.CustomerRepository.GetByID(CustomerID).FullName;
                    dgv_AccountingList.Rows.Add(result.AccountingID, FullName,
                        result.AccountingType1.TypeTitle, result.Amount, ConvertTime.Shamsi(result.DateTime), result.Description);

                }






            }

        }
    }
}
