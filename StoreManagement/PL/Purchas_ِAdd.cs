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
    public partial class Purchas_ِAdd: Form
    {
        //init
        DB_SMPEntities db = new DB_SMPEntities();
        TB_Pur pur = new TB_Pur();

        private double buy, sell, qt, tSell, tBuy, tProf;
        public int id;

        public Purchas_ِAdd()
        {
            InitializeComponent();
        }

        private void Pur_Buy_TextChanged(object sender, EventArgs e)
        {
            Pur_col();
        }

        private void Pur_Sell_TextChanged(object sender, EventArgs e)
        {
            Pur_col();
        }

        private void Pur_Qt_EditValueChanged(object sender, EventArgs e)
        {
            Pur_col();
        }



        // add or edite catagory
        private void bt_Add_Pur_Click(object sender, EventArgs e)
        {
            Toast toast = new Toast();
            Dailog dailog = new Dailog();
            // check if fildes not empty
            if (Pur_Name.Text != "")
            {
                // check if add or edite
                if (id == 0)
                {
                    // Add
                    pur.Pur_Name = Pur_Name.Text;
                    pur.Pur_Type = Pur_Type.Text;
                    pur.Pur_Cat = Pur_Cat.Text;
                    pur.Pur_Supp = Pur_Supp.Text;
                    pur.Pur_Det = Pur_Det.Text;
                    pur.Pur_Buy = Convert.ToDouble(Pur_Buy.Text);
                    pur.Pur_Sell = Convert.ToDouble(Pur_Sell.Text);
                    pur.Pur_Qu = Convert.ToDouble(Pur_Qt.Value);
                    pur.Pur_TBuy = Convert.ToDouble(Pur_TBuy.Text);
                    pur.Pur_TSell = Convert.ToDouble(Pur_TSell.Text);
                    pur.Pur_TProf = Convert.ToDouble(Pur_TPrfof.Text);
                    db.TB_Pur.Add(pur);
                    db.SaveChanges();
                    toast.txt_caption.Text = "تم اجراء عمليه شراء جديده بنجاح";
                    toast.Show();         
                    this.Close();
                }
                else
                {
                    //Edite
                    pur.ID = id;
                    pur.Pur_Name = Pur_Name.Text;
                    pur.Pur_Type = Pur_Type.Text;
                    pur.Pur_Cat = Pur_Cat.Text;
                    pur.Pur_Supp = Pur_Supp.Text;
                    pur.Pur_Det = Pur_Det.Text;
                    pur.Pur_Buy = Convert.ToDouble(Pur_Buy.Text);
                    pur.Pur_Sell = Convert.ToDouble(Pur_Sell.Text);
                    pur.Pur_Qu = Convert.ToDouble(Pur_Qt.Value);
                    pur.Pur_TBuy = Convert.ToDouble(Pur_TBuy.Text);
                    pur.Pur_TSell = Convert.ToDouble(Pur_TSell.Text);
                    pur.Pur_TProf = Convert.ToDouble(Pur_TPrfof.Text);
                    db.Entry(pur).State = EntityState.Modified;
                    db.SaveChanges();
                    toast.txt_caption.Text = "تم تعديل عمليه شراء بنجاح";
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

        private void Purchas_ِAdd_Activated(object sender, EventArgs e)
        {
            Pur_Cat.DataSource = db.TB_Cat.Select(x => x.Cat_Name).ToList();
            Pur_Supp.DataSource = db.TB_Supp.Select(x => x.Supp_Name).ToList();

        }

        private void Add_Cat_Click(object sender, EventArgs e)
        {
            Cat_Add cat = new Cat_Add();
            cat.id = 0;
            cat.bt_Add_Cat.Text = "اضافه";
            cat.Show();
        }

        private void Add_Supp_Click(object sender, EventArgs e)
        {
            Suppler_Add sup = new Suppler_Add();
            sup.id = 0;
            sup.bt_Add_Supp.Text = "اضافه";
            sup.Show();
        }

        private void Pur_col()
        {
            if (Pur_Buy.Text != "" && Pur_Sell.Text != "")
            {
               
                buy = Convert.ToDouble(Pur_Buy.Text);
                sell = Convert.ToDouble(Pur_Sell.Text);
                //if (buy > sell)
                //{
                //    MessageBox.Show("سعر الشراء اكبر من سعر البيع", "خطا"
                //        , MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}
                //else
                //{
                    qt = Convert.ToDouble(Pur_Qt.Value);
                    tBuy = buy * qt;
                    tSell = sell * qt;
                    tProf = tSell - tBuy;
                    Pur_TBuy.Text = tBuy.ToString();
                    Pur_TSell.Text = tSell.ToString();
                    Pur_TPrfof.Text = tProf.ToString();
                //}

            }


        }
    }
}
