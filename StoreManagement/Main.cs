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

namespace StoreManagement
{
    public partial class Main : Form
    {
        //the forms
        PL.Catagories cat = new PL.Catagories();
        PL.Home home = new PL.Home();
        PL.Suppleries sup = new PL.Suppleries();
        PL.Purchases pur = new PL.Purchases();
        PL.Customers cus = new PL.Customers();
        PL.Sales sel = new PL.Sales();
        PL.Reports rep = new PL.Reports();
        PL.Users user = new PL.Users();




        DB_SMPEntities db = new DB_SMPEntities();

        public Main()
        {
            InitializeComponent();
        }

        //cancel button
        private void Cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //maxmiz button
        private void bt_bigSize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        //minimize button
        private void bt_smallSize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        //collapse button
        private void bt_collapse_Click(object sender, EventArgs e)
        {
            if (pn_navBar.Width == 215)
            {
                pn_navBar.Width = 40;
                pn_titleNav.Visible = false;
                pn_navHeader.Height = 100;
            }
            else
            {
                pn_navBar.Width = 215;
                pn_titleNav.Visible = true;
                pn_navHeader.Height = 177;
            }
        }

        //Load home Page
        private void bt_Home_Click(object sender, EventArgs e)
        {
            pn_content.Controls.Clear();
            pn_content.Controls.Add(home.pn_home);
            txt_title.Text = "الصفحه الرئيسيه";

        }

        private void Main_Load(object sender, EventArgs e)
        {
            pn_content.Controls.Clear();
            pn_content.Controls.Add(home.pn_home);
            txt_title.Text = "الصفحه الرئيسيه";
            if (user_Roll.Text=="مستخدم")
            {
                bt_users.Visible = false;
                bt_suppler.Visible = false;
                bt_setings.Visible = false;

            }

        }

        //Load catagory Page
        private void bt_cat_Click(object sender, EventArgs e)
        {
            pn_content.Controls.Clear();
            pn_content.Controls.Add(cat.pn_cat);
            db = new DB_SMPEntities();
            txt_title.Text = "الاصناف";
        }

        //Load suppleries Page
        private void bt_suppler_Click(object sender, EventArgs e)
        {
            pn_content.Controls.Clear();
            pn_content.Controls.Add(sup.pn_Supp);
            db = new DB_SMPEntities();
            txt_title.Text = "الموردين";
        }

        //Load Purchases Page
        private void bt_products_Click(object sender, EventArgs e)
        {
            pn_content.Controls.Clear();
            pn_content.Controls.Add(pur.pn_Pur);
            db = new DB_SMPEntities();
            txt_title.Text = "المشتريات";
        }

        //Load Customers Page
        private void bt_clinets_Click(object sender, EventArgs e)
        {
            pn_content.Controls.Clear();
            pn_content.Controls.Add(cus.pn_Cus);
            db = new DB_SMPEntities();
            txt_title.Text = "العملاء";
        }


        //Load Sales Page
        private void bt_seles_Click(object sender, EventArgs e)
        {
            pn_content.Controls.Clear();
            pn_content.Controls.Add(sel.pn_Sell);
            db = new DB_SMPEntities();
            txt_title.Text = "المبيعات";
        }

        //Load Reports Page
        private void bt_reports_Click(object sender, EventArgs e)
        {
            pn_content.Controls.Clear();
            pn_content.Controls.Add(rep.pn_Rep);
            txt_title.Text = "التقارير";
        }

        private void bt_users_Click(object sender, EventArgs e)
        {
            pn_content.Controls.Clear();
            pn_content.Controls.Add(user.pn_Pur);
            db = new DB_SMPEntities();
            txt_title.Text = "المستخدمين";
        }

        private void bt_setings_Click(object sender, EventArgs e)
        {
            PL.Settings settings = new PL.Settings();
            settings.Show();
        }

        private void bt_logout_Click(object sender, EventArgs e)
        {
            TB_User tb_user = new TB_User();
            PL.Login login = new PL.Login();

            tb_user = db.TB_User.SingleOrDefault(x => x.User_Status == "True");
            tb_user.User_Status = "False";
            db.Entry(tb_user).State = EntityState.Modified;
            db.SaveChanges();

            this.Enabled = false;
            login.Show();
            this.Hide();
        }
    }
}
