using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StoreManagement.PL
{
    public partial class Start : SplashScreen
    {
        //init
        DB_SMPEntities db = new DB_SMPEntities();
        TB_User tb_user = new TB_User();
        Main main = new Main();
        Login login = new Login();

        public Start()
        {
            InitializeComponent();
            this.labelCopyright.Text = "Copyright © 1998-" + DateTime.Now.Year.ToString();
        }

        #region Overrides

        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion

        public enum SplashScreenCommand
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tb_user = db.TB_User.SingleOrDefault(x => x.User_Status=="True");

            if (tb_user != null)
            {
                
                main.user_Name.Text = tb_user.User_Name;
                main.user_Roll.Text = tb_user.User_Roll;
                main.Show();
            }
            else
            {
                login.Show();
            }
            this.Hide();
            timer1.Enabled = false;
        }

        private void peImage_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}