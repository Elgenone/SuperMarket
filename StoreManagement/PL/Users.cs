﻿using System;
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
    public partial class Users: Form
    {
        //init
        DB_SMPEntities db = new DB_SMPEntities();
        TB_User User = new TB_User();
        TB_Pur Pur = new TB_Pur();
        BL.Methods methods = new BL.Methods();

        int id;

        public Users()
        {
            InitializeComponent();
         
            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext
            StoreManagement.DB_SMPEntities dbContext = new StoreManagement.DB_SMPEntities();
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContext.TB_User.LoadAsync().ContinueWith(loadTask =>
            {
    // Bind data to control when loading complete
    gridControl1.DataSource = dbContext.TB_User.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }

        // add database
        private void bt_Add(object sender, EventArgs e)
        {
            User_Add form_add = new User_Add();
            form_add.id = 0;
            form_add.bt_Add_User.Text = "اضافه";
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
                dailog.txt_caption.Text = "لا يوجد مستخدم لحذفه";
                dailog.Width = this.Width;
                dailog.Show();
            }
            else
            {
                try
                {

                    var rs = MessageBox.Show("هل انت متاكد انك تريد حذف هذا المستخدم", "عمليه حذف",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (rs == DialogResult.Yes)
                    {
                        User = db.TB_User.Where(x => x.ID == id).FirstOrDefault();
                        db.Entry(User).State = EntityState.Deleted;
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
                dailog.txt_caption.Text = "لا يوجد مستخدم لتعديله";
                dailog.Width = this.Width;
                dailog.Show();
            }
            else
            {
                try
                {

                    User = db.TB_User.Where(x => x.ID == id).FirstOrDefault();

                    User_Add form_add = new User_Add();
                    form_add.id = id;
                    form_add.User_Name.Text = User.User_Name;
                    form_add.User_Pass.Text = User.User_Pass;
                    form_add.User_Roll.Text = User.User_Roll;


                    form_add.bt_Add_User.Text = "تعديل";
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
            gridControl1.DataSource = db.TB_User.Where(x => x.User_Name.Contains(search)
                || x.User_Pass.Contains(search) || x.User_Roll.Contains(search)).ToList();
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            var search = txt_search.Text;
            gridControl1.DataSource = db.TB_User.Where(x => x.User_Name.Contains(search)
                 || x.User_Pass.Contains(search) || x.User_Roll.Contains(search)).ToList();
        }

        // update database
        private void UpdateData()
        {
            db = new DB_SMPEntities();
            gridControl1.DataSource = db.TB_User.ToList();
        }

        private void Purchases_Activated(object sender, EventArgs e)
        {

        }

        
    }//end class
}//end namespace
