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
    public partial class Cat_Add : Form
    {
        //init
        DB_SMPEntities db = new DB_SMPEntities();
        TB_Cat cat = new TB_Cat();
        BL.Methods methods = new BL.Methods();
        PL.Catagories form_cat = new PL.Catagories();


        public int id;

        public Cat_Add()
        {
            InitializeComponent();
        }

        // add or edite catagory
        private void bt_Add_Cat_Click(object sender, EventArgs e)
        {
            Toast toast = new Toast();
            Dailog dailog = new Dailog();
            // check if fildes not empty
            if (Cat_Name.Text != "")
            {
                // check if add or edite
                if (id == 0)
                {
                    // Add
                    Cat_Image.Image.Save(methods.ma, System.Drawing.Imaging.ImageFormat.Jpeg);
                    cat.Cat_Name = Cat_Name.Text;
                    cat.Cat_Image = methods.ConvertToByte();
                    db.TB_Cat.Add(cat);
                    db.SaveChanges();
                    toast.txt_caption.Text = "تم اضافه صنف جديد بنجاح";
                    toast.Show();
                    db = new DB_SMPEntities();
                    form_cat.gridControl1.DataSource = db.TB_Cat.ToList();
                    this.Close();
                }
                else
                {
                    //Edite
                    cat.ID = id;
                    cat.Cat_Name = Cat_Name.Text;
                    Cat_Image.Image.Save(methods.ma, System.Drawing.Imaging.ImageFormat.Jpeg);
                    cat.Cat_Image = methods.ConvertToByte();
                    db.Entry(cat).State = EntityState.Modified;
                    db.SaveChanges();
                    toast.txt_caption.Text = "تم تعديل الصنف بنجاح";
                    toast.Show();
                    db = new DB_SMPEntities();
                    form_cat.gridControl1.DataSource = db.TB_Cat.ToList();
                    this.Close();
                }
            }
            else
            {
                dailog.Width = this.Width;
                dailog.txt_caption.Text = "يجب كتابه اسم الصنف اولا";
                dailog.Show();
            }
        }

        private void bt_cancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
