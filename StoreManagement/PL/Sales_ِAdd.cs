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
    public partial class Sales_ِAdd: Form
    {
        //init
        DB_SMPEntities db = new DB_SMPEntities();
        TB_Pur tb_Pur = new TB_Pur();
        TB_Sal tb_Sal = new TB_Sal();


        private double qtP,qtN,qtR;
        public int id;

        public Sales_ِAdd()
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

        private void Sal_PurName_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_Pur = db.TB_Pur.FirstOrDefault(x => x.Pur_Name == Sal_PurName.Text);
            Sal_TBuy.Text = tb_Pur.Pur_Buy.ToString();
            Sal_TSell.Text = tb_Pur.Pur_Sell.ToString();
            Sal_TQt.Text = tb_Pur.Pur_Qu.ToString();
            Sal_Sell.Text = tb_Pur.Pur_Sell.ToString();

        }




        // add or edite catagory
        private void bt_Add_Pur_Click(object sender, EventArgs e)
        {
            Toast toast = new Toast();
            Dailog dailog = new Dailog();

            qtP = Convert.ToDouble(Sal_TQt.Text);
            qtN = Convert.ToDouble(Sal_Qt.Text);
            qtR = qtP - qtN;

            // check if fildes not empty
            if (Sal_PurName.Text != "")
            {
                // check if add or edite
                if (id == 0)
                {
                    if (qtR >= 0)
                    {
                        // Add
                        tb_Sal.Sal_Name = Sal_PurName.Text;
                        tb_Sal.Sal_Cus = Sal_CusName.Text;
                        tb_Sal.Sal_Sell = Convert.ToDouble(Sal_Sell.Text);
                        tb_Sal.Sal_Qt = Convert.ToDouble(Sal_Qt.Value);
                        tb_Sal.Sal_TSell = Convert.ToDouble(Sal_Qt.Value) * Convert.ToDouble(Sal_Sell.Text);
                        tb_Sal.Sal_Date = DateTime.Now;
                        db.TB_Sal.Add(tb_Sal);
                        tb_Pur.Pur_Qu = qtR;
                        db.Entry(tb_Pur).State = EntityState.Modified;
                        db.SaveChanges();
                        toast.txt_caption.Text = "تم اجراء عمليه بيع جديده بنجاح";
                        toast.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("الكميه غير كافيه", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                  
                }
                else
                {
                    //Edite
                    tb_Pur.ID = id;
                    tb_Pur.Pur_Name = Sal_PurName.Text;
                 //  pur.Pur_Type = Pur_Type.Text;
                    tb_Pur.Pur_Cat = Sal_PurName.Text;
                    tb_Pur.Pur_Supp = Sal_CusName.Text;
                  //  pur.Pur_Det = Pur_Det.Text;
                 //   pur.Pur_Buy = Convert.ToDouble(Pur_Buy.Text);
                    tb_Pur.Pur_Sell = Convert.ToDouble(Sal_Sell.Text);
                    tb_Pur.Pur_Qu = Convert.ToDouble(Sal_Qt.Value);
                    tb_Pur.Pur_TBuy = Convert.ToDouble(Sal_TBuy.Text);
                    tb_Pur.Pur_TSell = Convert.ToDouble(Sal_TSell.Text);
                    tb_Pur.Pur_TProf = Convert.ToDouble(Sal_TQt.Text);
                    db.Entry(tb_Pur).State = EntityState.Modified;
                    db.SaveChanges();
                    toast.txt_caption.Text = "تم تعديل عمليه البيع بنجاح";
                    toast.Show();
                    this.Close();
                }
            }
            else
            {
                dailog.Width = this.Width;
                dailog.txt_caption.Text = "يجب كتابه اسم الماده اولا";
                dailog.Show();
            }
        }

        private void Purchas_ِAdd_Activated(object sender, EventArgs e)
        {
            //load data
            var rs1 = db.TB_Pur.Select(x => x.Pur_Name).ToList();
            var rs2 = db.TB_Cus.Select(x => x.Cus_Name).ToList();
            Sal_PurName.DataSource = rs1;
            Sal_CusName.DataSource = rs2;

            //active AutoComplete
            AutoCompleteStringCollection auto1 = new AutoCompleteStringCollection();
            AutoCompleteStringCollection auto2 = new AutoCompleteStringCollection();
            auto1.AddRange(rs1.ToArray());
            auto2.AddRange(rs2.ToArray());
            Sal_PurName.AutoCompleteCustomSource = auto1;
            Sal_CusName.AutoCompleteCustomSource = auto2;

           



        }

        private void Add_Pur_Click(object sender, EventArgs e)
        {
            Purchas_ِAdd pur = new Purchas_ِAdd();
            pur.id = 0;
            pur.bt_Add_Pur.Text = "اضافه";
            pur.Show();
        }

        private void Add_Cus_Click(object sender, EventArgs e)
        {
            Customer_Add cus = new Customer_Add();
            cus.id = 0;
            cus.bt_Add_Supp.Text = "اضافه";
            cus.Show();
        }

        private void Pur_col()
        {
            if ( Sal_Sell.Text != "")
            {
               
               // buy = Convert.ToDouble(Pur_Buy.Text);
               // sell = Convert.ToDouble(Sal_Sell.Text);
                //if (buy > sell)
                //{
                //    MessageBox.Show("سعر الشراء اكبر من سعر البيع", "خطا"
                //        , MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}
                //else
                //{
                    //qt = Convert.ToDouble(Sal_Qt.Value);
                    //tBuy = buy * qt;
                    //tSell = sell * qt;
                    //tProf = tSell - tBuy;
                    //Sal_TBuy.Text = tBuy.ToString();
                    //Sal_TSell.Text = tSell.ToString();
                    //Sal_TQt.Text = tProf.ToString();
                //}

            }


        }
    }
}
