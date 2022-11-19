using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ValidationComponents;
using Accounting.DataLayer;
using System.IO;
using Accounting.DataLayer.Context;

namespace Accounting.App.Form_Customers
{
    public partial class frm_AddOrEdit : Form
    {
        public int CustomerID = 0;
        public string AddDetail = "";
        public frm_AddOrEdit()
        {
            InitializeComponent();
        }

        private void frm_AddOrEdit_Load(object sender, EventArgs e)
        {
            if (CustomerID == 0)
            {
                this.Text = "افزودن";
                btn_Save.Text = "افزودن";
            }
            else
            {
                this.Text = "ویرایش";
                btn_Save.Text = "ویرایش";
                using(UnitOfWork db=new UnitOfWork())
                {
                    Customers EditCustomer = db.CustomerRepository.GetByID(CustomerID);
                    txt_FullName.Text = EditCustomer.FullName;
                    txt_Mobile.Text = EditCustomer.Mobile;
                    txt_Email.Text = EditCustomer.Email;
                    txt_Addres.Text = EditCustomer.Addres;
                    pcb_Customer.ImageLocation = Application.StartupPath + "/images" + EditCustomer.CustomerImage;
                }
            }

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (BaseValidator.IsFormValid(this.components))
            {
                string ImageName = Guid.NewGuid().ToString() + Path.GetExtension(pcb_Customer.ImageLocation);
                string path = Application.StartupPath + "/images";
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                pcb_Customer.Image.Save(path + ImageName);
                Customers AddEditCustomer = new Customers()
                {
                    FullName = txt_FullName.Text,
                    Mobile = txt_Mobile.Text,
                    Email = txt_Email.Text,
                    Addres = txt_Addres.Text,
                    CustomerImage = ImageName
                };

                if (CustomerID == 0)
                {
                    using (UnitOfWork db = new UnitOfWork())
                    {
                        db.CustomerRepository.Insert(AddEditCustomer);

                        db.saveChange();

                    }
                }
                else
                {
                    AddEditCustomer.CustomerID = CustomerID;
                    using(UnitOfWork db=new UnitOfWork())
                    {
                        db.CustomerRepository.update(AddEditCustomer);
                        db.saveChange();
                    }
                }

                AddDetail = AddEditCustomer.FullName.ToString();
                DialogResult = DialogResult.OK;
            }
        }

        private void btn_SelectImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog SelectImage = new OpenFileDialog();
            if (SelectImage.ShowDialog() == DialogResult.OK)
            {
                pcb_Customer.ImageLocation = SelectImage.FileName;
            }
        }
    }
}
