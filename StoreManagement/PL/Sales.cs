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
    public partial class Sales: Form
    {
        //init
        DB_SMPEntities db = new DB_SMPEntities();
        TB_Sal Sal = new TB_Sal();
        TB_Pur Pur = new TB_Pur();
        BL.Methods methods = new BL.Methods();

        int id;

        public Sales()
        {
            InitializeComponent();
          
            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext
            StoreManagement.DB_SMPEntities dbContext = new StoreManagement.DB_SMPEntities();
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContext.TB_Sal.LoadAsync().ContinueWith(loadTask =>
            {
    // Bind data to control when loading complete
    gridControl1.DataSource = dbContext.TB_Sal.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }

        // add database
        private void bt_Add(object sender, EventArgs e)
        {
            Sales_ِAdd form_add = new Sales_ِAdd();
            form_add.id = 0;
            form_add.bt_Add_Sal.Text = "اضافه";
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
            id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("ID"));
            if (id == 0)
            {
                dailog.txt_caption.Text = "لا يوجد عمليه لحذفها";
                dailog.Width = this.Width;
                dailog.Show();
            }
            else
            {
                try
                {

                    var rs = MessageBox.Show("هل انت متاكد انك تريد حذف هذا العمليه", "عمليه حذف",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (rs == DialogResult.Yes)
                    {
                        Sal = db.TB_Sal.Where(x => x.ID == id).FirstOrDefault();
                        db.Entry(Sal).State = EntityState.Deleted;
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
            id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("ID"));
            if (id == 0)
            {
                dailog.txt_caption.Text = "لا يوجد عمليه لتعديلها";
                dailog.Width = this.Width;
                dailog.Show();
            }
            else
            {
                try
                {

                    Pur = db.TB_Pur.Where(x => x.ID == id).FirstOrDefault();

                    Purchas_ِAdd form_add = new Purchas_ِAdd();
                    form_add.id = id;
                    form_add.Pur_Name.Text = Pur.Pur_Name;
                    form_add.Pur_Type.Text = Pur.Pur_Type;
                    form_add.Pur_Det.Text = Pur.Pur_Det;
                    form_add.Pur_Cat.Text = Pur.Pur_Cat;
                    form_add.Pur_Supp.Text = Pur.Pur_Supp;
                    form_add.Pur_Buy.Text = Pur.Pur_Buy.ToString();
                    form_add.Pur_Sell.Text = Pur.Pur_Sell.ToString();
                    form_add.Pur_Qt.Text = Pur.Pur_Qu.ToString();
                    form_add.Pur_TBuy.Text = Pur.Pur_TBuy.ToString();
                    form_add.Pur_TSell.Text = Pur.Pur_TSell.ToString();
                    form_add.Pur_TPrfof.Text = Pur.Pur_TProf.ToString();

                    form_add.bt_Add_Pur.Text = "تعديل";
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
            gridControl1.DataSource = db.TB_Sal.Where(x => x.Sal_Name.Contains(search)
                || x.Sal_Cus.Contains(search)).ToList();
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            var search = txt_search.Text;
            gridControl1.DataSource = db.TB_Sal.Where(x => x.Sal_Name.Contains(search)
               || x.Sal_Cus.Contains(search)).ToList();
        }

        // update database
        private void UpdateData()
        {
            db = new DB_SMPEntities();
            gridControl1.DataSource = db.TB_Sal.ToList();
        }

        private void Purchases_Activated(object sender, EventArgs e)
        {

        }

        
    }//end class
}//end namespace
