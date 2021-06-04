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
using DevExpress.XtraReports.UI;

namespace StoreManagement.PL
{
    public partial class Reports : Form
    {
        //init
      
        public Reports()
        {
            InitializeComponent();
        }

        private void bt_Sell_Click(object sender, EventArgs e)
        {
            SalesReport1 report = new SalesReport1();
            //report.ShowDesigner(); // make the user edite the report
            report.ShowPreview(); // give to user the options to extrect the report as he want and some othe features 
             
        }
    }//end class
}//end namespace
