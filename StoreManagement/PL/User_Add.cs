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
    public partial class User_Add: Form
    {
        //init
        DB_SMPEntities db = new DB_SMPEntities();
        TB_Supp supp = new TB_Supp();
        TB_User user = new TB_User();
        BL.Methods methods = new BL.Methods();

        public int id;

        public User_Add()
        {
            InitializeComponent();
        }

        // add or edite catagory
        private void bt_Add_Cat_Click(object sender, EventArgs e)
        {
            Toast toast = new Toast();
            Dailog dailog = new Dailog();
            // check if fildes not empty
            if (User_Name.Text != "")
            {
                // check if add or edite
                if (id == 0)
                {
                    // Add
                   

                    user.User_Name = User_Name.Text;
                    user.User_Pass = User_Pass.Text;
                    user.User_Roll = User_Roll.Text;
                    user.User_Status = "false";

                    //  Supp_Image.Image.Save(methods.ma, System.Drawing.Imaging.ImageFormat.Png);
                    //   supp.Supp_Image = methods.ConvertToByte();
                    db.TB_User.Add(user);
                    db.SaveChanges();
                    toast.txt_caption.Text = "تم اضافه مستخدم جديد بنجاح";
                    toast.Show();         
                    this.Close();
                }
                else
                {
                    //Edite
                    user.ID = id;
                    user.User_Name = User_Name.Text;
                    user.User_Pass = User_Pass.Text;
                    user.User_Roll = User_Roll.Text;
                    user.User_Status = "false";

                    //Supp_Image.Image.Save(methods.ma, System.Drawing.Imaging.ImageFormat.Png);
                    //supp.Supp_Image = methods.ConvertToByte();
                    db.Entry(user).State = EntityState.Modified;
                    db.SaveChanges();
                    toast.txt_caption.Text = "تم تعديل المستخدم بنجاح";
                    toast.Show();
                    this.Close();
                }
            }
            else
            {
                dailog.Width = this.Width;
                dailog.txt_caption.Text = "يجب كتابه اسم المستخدم اولا";
                dailog.Show();
            }
        }

        private void bt_cancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
