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

namespace Accounting.App.Form_Customers
{
    public partial class frm_MainCustomer : Form
    {
        public string FullName = "";
        public frm_MainCustomer()
        {
            InitializeComponent();
        }

        private void btn_Customer_Click(object sender, EventArgs e)
        {
            frm_AddOrEdit frm_AddCustomer = new frm_AddOrEdit();
            frm_AddCustomer.ShowDialog();
            if (frm_AddCustomer.DialogResult == DialogResult.OK)
            {
                FullName = frm_AddCustomer.AddDetail;
                MessageBox.Show(FullName + "  " + "با موفقیت افزوده شد");
            }
        }

        private void frm_MainCustomer_Load(object sender, EventArgs e)
        {
            pcb_Customer.Hide();
            Refresh();
        }
        public void Refresh()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                dgv_Customers.AutoGenerateColumns = false;
                dgv_Customers.DataSource = db.CustomerRepository.GetAllAndSearch();
            }
        }

        private void dgv_Customers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                int id = int.Parse(dgv_Customers.CurrentRow.Cells[0].Value.ToString());
                var person = db.CustomerRepository.GetByID(id);

                pcb_Customer.ImageLocation = Application.StartupPath + "/images" + person.CustomerImage;
                pcb_Customer.Show();

            }
        }

        private void dgv_Customers_Click(object sender, EventArgs e)
        {
            pcb_Customer.Hide();
        }

        private void btn_EditCustomer_Click(object sender, EventArgs e)
        {
            frm_AddOrEdit frm_EditCustomer = new frm_AddOrEdit();
            int CustomerID = int.Parse(dgv_Customers.CurrentRow.Cells[0].Value.ToString());
            frm_EditCustomer.CustomerID = CustomerID;
            frm_EditCustomer.ShowDialog();
            if (frm_EditCustomer.DialogResult == DialogResult.OK)
            {
                FullName = frm_EditCustomer.AddDetail;
                MessageBox.Show(FullName + " " + "با موفقیت ویرایش شد");
                Refresh();
            }

        }

        private void dgv_Customers_MouseLeave(object sender, EventArgs e)
        {
            pcb_Customer.Hide();
        }

        private void btn_DeleteCustomer_Click(object sender, EventArgs e)
        {
            if (dgv_Customers.CurrentRow != null)
            {

                using (UnitOfWork db = new UnitOfWork())
                {
                    int CustomerID = int.Parse(dgv_Customers.CurrentRow.Cells[0].Value.ToString());
                    var person = db.CustomerRepository.GetByID(CustomerID);
                    string fullname = person.FullName;
                    if (MessageBox.Show(fullname + "  " + "ایا از حذف شخص مطمئن هستید؟", "توجه", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        db.CustomerRepository.Delete(CustomerID);

                        MessageBox.Show(fullname + "با موفقیت حذف شد");
                        db.saveChange();
                        Refresh();

                    }

                }


            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void txt_Serach_TextChanged(object sender, EventArgs e)
        {
            using (UnitOfWork db=new UnitOfWork())
            {
                string parametr = txt_Serach.Text;
                dgv_Customers.DataSource = db.CustomerRepository.GetAllAndSearch(x => x.FullName.Contains(parametr) || x.Email.Contains(parametr) || x.Mobile.Contains(parametr)).ToList();

            }
        }
    }
}
