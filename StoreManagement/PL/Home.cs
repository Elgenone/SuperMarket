using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreManagement.PL
{
    public partial class Home : Form
    {
        DB_SMPEntities db = new DB_SMPEntities();
        public Home()
        {
            InitializeComponent();
            lb_cat.Text = db.TB_Cat.ToList().Count.ToString();
            lb_cus.Text = db.TB_Cus.ToList().Count.ToString();
            lb_pur.Text = db.TB_Pur.ToList().Count.ToString();
            lb_sal.Text = db.TB_Sal.ToList().Count.ToString();
            lb_supp.Text = db.TB_Supp.ToList().Count.ToString();

        }
        private void Add_Cat_Click(object sender, EventArgs e)
        {
            Cat_Add form_add = new Cat_Add();
            form_add.id = 0;
            form_add.bt_Add_Cat.Text = "اضافه";
            form_add.Show();
        }

        private void Add_Supp_Click(object sender, EventArgs e)
        {
            Suppler_Add form_add = new Suppler_Add();
            form_add.id = 0;
            form_add.bt_Add_Supp.Text = "اضافه";
            form_add.Show();
        }

        private void Add_Pur_Click(object sender, EventArgs e)
        {
            Purchas_ِAdd form_add = new Purchas_ِAdd();
            form_add.id = 0;
            form_add.bt_Add_Pur.Text = "اضافه";
            form_add.Show();
        }

        private void Add_Client_Click(object sender, EventArgs e)
        {
            Customer_Add form_add = new Customer_Add();
            form_add.id = 0;
            form_add.bt_Add_Supp.Text = "اضافه";
            form_add.Show();
        }

        private void Add_Sal_Click(object sender, EventArgs e)
        {
            Sales_ِAdd form_add = new Sales_ِAdd();
            form_add.id = 0;
            form_add.bt_Add_Sal.Text = "اضافه";
            form_add.Show();
        }
    }
}
