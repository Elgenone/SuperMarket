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
using System.Configuration;

namespace StoreManagement.PL
{
    public partial class Settings: Form
    {
        //init
      

        public int id;

        public Settings()
        {
            InitializeComponent();
        }

        // add or edite catagory
        private void bt_Add_Cat_Click(object sender, EventArgs e)
        {
            Toast toast = new Toast();
            Dailog dailog = new Dailog();
            // check if fildes not empty
            if (Server_Name.Text != "")
            {
                const string qu = "\"";
                var sv = Server_Name.Text; 
                var conStr = @"metadata=res://*/SAPM.csdl|res://*/SAPM.ssdl|res://*/SAPM.msl;provider=System.Data.SqlClient;provider connection string="+qu+";data source="+ sv +";initial catalog=DB_SMP;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework"+qu+";";

                var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.ConnectionStrings.ConnectionStrings["DB_SMPEntities"].ConnectionString = conStr;
                config.Save();
                ConfigurationManager.RefreshSection("connectionString");

                var str = config.ConnectionStrings.ConnectionStrings["DB_SMPEntities"].ConnectionString;
                MessageBox.Show(str);
                Application.Restart();
            }
            else
            {
                dailog.Width = this.Width;
                dailog.txt_caption.Text = "يجب كتابه اسم السيرفر اولا";
                dailog.Show();
            }
        }

    }
}
