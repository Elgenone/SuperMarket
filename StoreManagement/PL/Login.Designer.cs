
namespace StoreManagement.PL
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.User_Pass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Supp_Image = new DevExpress.XtraEditors.PictureEdit();
            this.User_Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bt_Add_User = new DevExpress.XtraEditors.SimpleButton();
            this.bt_cancle = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.Supp_Image.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // User_Pass
            // 
            this.User_Pass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.User_Pass.Font = new System.Drawing.Font("Arabic Typesetting", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User_Pass.Location = new System.Drawing.Point(28, 298);
            this.User_Pass.Name = "User_Pass";
            this.User_Pass.PasswordChar = '*';
            this.User_Pass.Size = new System.Drawing.Size(172, 38);
            this.User_Pass.TabIndex = 29;
            this.User_Pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arabic Typesetting", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(277, 297);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 31);
            this.label2.TabIndex = 28;
            this.label2.Text = "كلمه السر";
            // 
            // Supp_Image
            // 
            this.Supp_Image.EditValue = ((object)(resources.GetObject("Supp_Image.EditValue")));
            this.Supp_Image.Location = new System.Drawing.Point(111, 70);
            this.Supp_Image.Name = "Supp_Image";
            this.Supp_Image.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.Supp_Image.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.Supp_Image.Size = new System.Drawing.Size(154, 145);
            this.Supp_Image.TabIndex = 27;
            // 
            // User_Name
            // 
            this.User_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.User_Name.Font = new System.Drawing.Font("Arabic Typesetting", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User_Name.Location = new System.Drawing.Point(28, 239);
            this.User_Name.Name = "User_Name";
            this.User_Name.Size = new System.Drawing.Size(172, 38);
            this.User_Name.TabIndex = 26;
            this.User_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arabic Typesetting", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(252, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 31);
            this.label1.TabIndex = 25;
            this.label1.Text = "اسم المستخدم";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Arabic Typesetting", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(95, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 55);
            this.label4.TabIndex = 24;
            this.label4.Text = "تسجيل الدخول";
            // 
            // bt_Add_User
            // 
            this.bt_Add_User.Appearance.Font = new System.Drawing.Font("Arabic Typesetting", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Add_User.Appearance.Options.UseFont = true;
            this.bt_Add_User.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bt_Add_User.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bt_Add_User.ImageOptions.Image")));
            this.bt_Add_User.Location = new System.Drawing.Point(0, 392);
            this.bt_Add_User.Name = "bt_Add_User";
            this.bt_Add_User.Size = new System.Drawing.Size(377, 44);
            this.bt_Add_User.TabIndex = 23;
            this.bt_Add_User.Text = "تسجيل الدخول";
            this.bt_Add_User.Click += new System.EventHandler(this.bt_Add_Cat_Click);
            // 
            // bt_cancle
            // 
            this.bt_cancle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_cancle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bt_cancle.ImageOptions.Image")));
            this.bt_cancle.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.bt_cancle.Location = new System.Drawing.Point(325, 12);
            this.bt_cancle.Name = "bt_cancle";
            this.bt_cancle.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.bt_cancle.Size = new System.Drawing.Size(40, 40);
            this.bt_cancle.TabIndex = 30;
            this.bt_cancle.Click += new System.EventHandler(this.bt_cancle_Click);
            // 
            // Login
            // 
            this.AcceptButton = this.bt_Add_User;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.bt_cancle;
            this.ClientSize = new System.Drawing.Size(377, 436);
            this.Controls.Add(this.bt_cancle);
            this.Controls.Add(this.User_Pass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Supp_Image);
            this.Controls.Add(this.User_Name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bt_Add_User);
            this.Font = new System.Drawing.Font("Arabic Typesetting", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اضافه مستخدم جديد";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Supp_Image.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox User_Pass;
        private System.Windows.Forms.Label label2;
        public DevExpress.XtraEditors.PictureEdit Supp_Image;
        public System.Windows.Forms.TextBox User_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        public DevExpress.XtraEditors.SimpleButton bt_Add_User;
        private DevExpress.XtraEditors.SimpleButton bt_cancle;
    }
}