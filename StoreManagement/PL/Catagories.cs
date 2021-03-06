using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using StoreManagement.EPL;

namespace StoreManagement.PL
{
    public partial class Catagories : Form
    {
        //init
        DB_SMPEntities db = new DB_SMPEntities();
        TB_Cat Cat = new TB_Cat();
        BL.Methods methods = new BL.Methods();

        int id;

        public Catagories()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext
            StoreManagement.DB_SMPEntities dbContext = new StoreManagement.DB_SMPEntities();
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContext.TB_Cat.LoadAsync().ContinueWith(loadTask =>
            {
    // Bind data to control when loading complete
    gridControl1.DataSource = dbContext.TB_Cat.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }

        // add database
        private void bt_Add(object sender, EventArgs e)
        {
            Cat_Add form_add = new Cat_Add();
            form_add.id = 0;
            form_add.bt_Add_Cat.Text = "اضافه";
            form_add.Show();
        }

        // update database
        private void bt_update_Click(object sender, EventArgs e)
        {
            UpdateData();
        }

        // delete database
        private void bt_delete_Click(object sender, EventArgs e)
        {
            Toast toast = new Toast();
            Dailog dailog = new Dailog();
            id = Convert.ToInt32(tileView1.GetFocusedRowCellValue("ID"));
            if (id == 0)
            {
                dailog.txt_caption.Text = "لا يوجد صنف لحذفه";
                dailog.Width = this.Width;
                dailog.Show();
            }
            else
            {
                try
                {

                    var rs = MessageBox.Show("هل انت متاكد انك تريد حذف هذا الصنف", "عمليه حذف",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (rs == DialogResult.Yes)
                    {
                        Cat = db.TB_Cat.Where(x => x.ID == id).FirstOrDefault();
                        db.Entry(Cat).State = EntityState.Deleted;
                        toast.txt_caption.Text = "تم الحذف بنجاح";
                        toast.Show();
                        db.SaveChanges();
                        UpdateData();
                    }
                }
                catch
                {

                }
            }

           
         
         
        }

        // Edite database
        private void bt_Edite_Click(object sender, EventArgs e)
        {
            Dailog dailog = new Dailog();
            id = Convert.ToInt32(tileView1.GetFocusedRowCellValue("ID"));
            if (id == 0)
            {
                dailog.txt_caption.Text = "لا يوجد صنف لتعديله";
                dailog.Width = this.Width;
                dailog.Show();
            }
            else
            {
                try
                {

                    Cat = db.TB_Cat.Where(x => x.ID == id).FirstOrDefault();

                    Cat_Add form_add = new Cat_Add();
                    form_add.id = id;
                    form_add.Cat_Name.Text = Cat.Cat_Name;
                    methods.by = Cat.Cat_Image;
                    form_add.Cat_Image.Image = Image.FromStream(methods.ConvertToImage());


                    form_add.bt_Add_Cat.Text = "تعديل";
                    form_add.Show();
                }
                catch
                {

                }
            }
          
           
        }

        // search in database
        private void bt_search_Click(object sender, EventArgs e)
        {
            var search = txt_search.Text;
            gridControl1.DataSource = db.TB_Cat.Where(x => x.Cat_Name.Contains(search)).ToList();
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            var search = txt_search.Text;
            gridControl1.DataSource = db.TB_Cat.Where(x => x.Cat_Name.Contains(search)).ToList();
        }

        // update database
        private void UpdateData()
        {
            db = new DB_SMPEntities();
            gridControl1.DataSource = db.TB_Cat.ToList();
        }
    }//end class
}//end namespace
