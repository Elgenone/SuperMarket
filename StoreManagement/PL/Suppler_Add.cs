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
    public partial class Suppler_Add: Form
    {
        //init
        DB_SMPEntities db = new DB_SMPEntities();
        TB_Supp supp = new TB_Supp();
        BL.Methods methods = new BL.Methods();

        public int id;

        public Suppler_Add()
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
                    supp.Supp_Name = Supp_Name.Text;
                    supp.Supp_Phone = Supp_Phone.Text;
                    supp.Supp_Email = Supp_Email.Text;
                    supp.Supp_Image = methods.ConvertToByte();
                    db.TB_Supp.Add(supp);
                    db.SaveChanges();
                    toast.txt_caption.Text = "تم اضافه مورد جديد بنجاح";
                    toast.Show();         
                    this.Close();
                }
                else
                {
                    //Edite
                    supp.ID = id;
                    supp.Supp_Name = Supp_Name.Text;
                    supp.Supp_Phone = Supp_Phone.Text;
                    supp.Supp_Email = Supp_Email.Text;
                    Supp_Image.Image.Save(methods.ma, System.Drawing.Imaging.ImageFormat.Png);
                    supp.Supp_Image = methods.ConvertToByte();
                    db.Entry(supp).State = EntityState.Modified;
                    db.SaveChanges();
                    toast.txt_caption.Text = "تم تعديل المورد بنجاح";
                    toast.Show();
                    this.Close();
                }
            }
            else
            {
                dailog.Width = this.Width;
                dailog.txt_caption.Text = "يجب كتابه اسم المورد اولا";
                dailog.Show();
            }
        }

        private void bt_cancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
