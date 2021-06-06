
namespace StoreManagement.PL
{
    partial class User_Add
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User_Add));
            this.bt_Add_User = new DevExpress.XtraEditors.SimpleButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.User_Name = new System.Windows.Forms.TextBox();
            this.Supp_Image = new DevExpress.XtraEditors.PictureEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.User_Pass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.User_Roll = new System.Windows.Forms.ComboBox();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.Supp_Image.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_Add_User
            // 
            this.bt_Add_User.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bt_Add_User.Appearance.Font = new System.Drawing.Font("Arabic Typesetting", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Add_User.Appearance.Options.UseFont = true;
            this.bt_Add_User.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bt_Add_User.ImageOptions.Image")));
            this.bt_Add_User.Location = new System.Drawing.Point(349, 436);
            this.bt_Add_User.Name = "bt_Add_User";
            this.bt_Add_User.Size = new System.Drawing.Size(123, 44);
            this.bt_Add_User.TabIndex = 11;
            this.bt_Add_User.Text = "اضافه ";
            this.bt_Add_User.Click += new System.EventHandler(this.bt_Add_Cat_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label4.Font = new System.Drawing.Font("Arabic Typesetting", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(149, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 55);
            this.label4.TabIndex = 16;
            this.label4.Text = "اضافه مستخدم";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arabic Typesetting", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(300, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 31);
            this.label1.TabIndex = 18;
            this.label1.Text = "اسم المستخدم";
            // 
            // User_Name
            // 
            this.User_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.User_Name.Font = new System.Drawing.Font("Arabic Typesetting", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User_Name.Location = new System.Drawing.Point(89, 90);
            this.User_Name.Name = "User_Name";
            this.User_Name.Size = new System.Drawing.Size(172, 38);
            this.User_Name.TabIndex = 19;
            this.User_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Supp_Image
            // 
            this.Supp_Image.EditValue = ((object)(resources.GetObject("Supp_Image.EditValue")));
            this.Supp_Image.Location = new System.Drawing.Point(156, 264);
            this.Supp_Image.Name = "Supp_Image";
            this.Supp_Image.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.Supp_Image.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.Supp_Image.Size = new System.Drawing.Size(172, 193);
            this.Supp_Image.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arabic Typesetting", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(325, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 31);
            this.label2.TabIndex = 21;
            this.label2.Text = "كلمه السر";
            // 
            // User_Pass
            // 
            this.User_Pass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.User_Pass.Font = new System.Drawing.Font("Arabic Typesetting", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User_Pass.Location = new System.Drawing.Point(89, 149);
            this.User_Pass.Name = "User_Pass";
            this.User_Pass.PasswordChar = '*';
            this.User_Pass.Size = new System.Drawing.Size(172, 38);
            this.User_Pass.TabIndex = 22;
            this.User_Pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arabic Typesetting", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(328, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 31);
            this.label3.TabIndex = 23;
            this.label3.Text = "الصلاحيه";
            // 
            // User_Roll
            // 
            this.User_Roll.Font = new System.Drawing.Font("Arabic Typesetting", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User_Roll.FormattingEnabled = true;
            this.User_Roll.Items.AddRange(new object[] {
            "مدير",
            "مستخدم"});
            this.User_Roll.Location = new System.Drawing.Point(89, 209);
            this.User_Roll.Name = "User_Roll";
            this.User_Roll.Size = new System.Drawing.Size(172, 35);
            this.User_Roll.TabIndex = 24;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.User_Roll);
            this.panelControl1.Controls.Add(this.label3);
            this.panelControl1.Controls.Add(this.User_Pass);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.Supp_Image);
            this.panelControl1.Controls.Add(this.User_Name);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Controls.Add(this.label4);
            this.panelControl1.Controls.Add(this.bt_Add_User);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(484, 485);
            this.panelControl1.TabIndex = 17;
            // 
            // User_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(484, 485);
            this.Controls.Add(this.panelControl1);
            this.Font = new System.Drawing.Font("Arabic Typesetting", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "User_Add";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اضافه مستخدم جديد";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.Supp_Image.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraEditors.SimpleButton bt_Add_User;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox User_Name;
        public DevExpress.XtraEditors.PictureEdit Supp_Image;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox User_Pass;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        public System.Windows.Forms.ComboBox User_Roll;
    }
}