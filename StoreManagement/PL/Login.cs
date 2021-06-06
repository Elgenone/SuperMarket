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
    public partial class Login: Form
    {
        //init
        DB_SMPEntities db = new DB_SMPEntities();
        TB_User user = new TB_User();


        public Login()
        {
            InitializeComponent();
        }

        // add or edite catagory
        private void bt_Add_Cat_Click(object sender, EventArgs e)
        {
            Toast toast = new Toast();
            Dailog dailog = new Dailog();
            // check if fildes not empty
            if (User_Name.Text != ""&& User_Pass.Text != "")
            {

                //Login
                user = db.TB_User.SingleOrDefault(x => x.User_Name == User_Name.Text && x.User_Pass == User_Pass.Text);

                if (user != null)
                {
                    user.User_Status = "True";
                    db.Entry(user).State = EntityState.Modified;
                    db.SaveChanges();

                    Main main = new Main();
                    main.user_Name.Text = user.User_Name;
                    main.user_Roll.Text = user.User_Roll;
                    main.Enabled = true;
                    main.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("ادخل الاسم و كلمه السر الصحيحه", "خطا فى التسجيل",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
          
            }
            else
            {
                dailog.Width = this.Width;
                dailog.txt_caption.Text = "يجب كتابه اسم المستخدم و كلمه السر اولا";
                dailog.Show();
            }
        }

        private void bt_cancle_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
