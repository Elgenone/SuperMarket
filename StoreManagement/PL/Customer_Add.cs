using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StoreManagement.EPL;

namespace StoreManagement.PL
{
    public partial class Customer_Add: Form
    {
        //init
        DB_SMPEntities db = new DB_SMPEntities();
        TB_Cus cus = new TB_Cus();
        BL.Methods methods = new BL.Methods();

        public int id;

        public Customer_Add()
        {
            InitializeComponent();
        }

        // add or edite catagory
        private void bt_Add_Cat_Click(object sender, EventArgs e)
        {
            Toast toast = new Toast();
            Dailog dailog = new Dailog();
            // check if fildes not empty
            if (Supp_Name.Text != "")
            {
                // check if add or edite
                if (id == 0)
                {
                    // Add
                    Supp_Image.Image.Save(methods.ma, System.Drawing.Imaging.ImageFormat.Png);
                    cus.Cus_Name = Supp_Name.Text;
                    cus.Cus_Phone = Supp_Phone.Text;
                    cus.Cus_Email = Supp_Email.Text;
                    cus.Cus_Image = methods.ConvertToByte();
                    db.TB_Cus.Add(cus);
                    db.SaveChanges();
                    toast.txt_caption.Text = "تم اضافه عميل جديد بنجاح";
                    toast.Show();         
                    this.Close();
                }
                else
                {
                    //Edite
                    cus.ID = id;
                    cus.Cus_Name = Supp_Name.Text;
                    cus.Cus_Phone = Supp_Phone.Text;
                    cus.Cus_Email = Supp_Email.Text;
                    Supp_Image.Image.Save(methods.ma, System.Drawing.Imaging.ImageFormat.Png);
                    cus.Cus_Image = methods.ConvertToByte();
                    db.Entry(cus).State = EntityState.Modified;
                    db.SaveChanges();
                    toast.txt_caption.Text = "تم تعديل العميل بنجاح";
                    toast.Show();
                    this.Close();
                }
            }
            else
            {
                dailog.Width = this.Width;
                dailog.txt_caption.Text = "يجب كتابه اسم العميل اولا";
                dailog.Show();
            }
        }

        private void bt_cancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
