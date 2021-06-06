
namespace StoreManagement
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.pn_topBar = new System.Windows.Forms.Panel();
            this.txt_title = new System.Windows.Forms.Label();
            this.bt_logout = new DevExpress.XtraEditors.SimpleButton();
            this.bt_smallSize = new DevExpress.XtraEditors.SimpleButton();
            this.bt_bigSize = new DevExpress.XtraEditors.SimpleButton();
            this.bt_cancle = new DevExpress.XtraEditors.SimpleButton();
            this.pn_navBar = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.bt_Home = new DevExpress.XtraEditors.SimpleButton();
            this.bt_cat = new DevExpress.XtraEditors.SimpleButton();
            this.bt_suppler = new DevExpress.XtraEditors.SimpleButton();
            this.bt_products = new DevExpress.XtraEditors.SimpleButton();
            this.bt_clinets = new DevExpress.XtraEditors.SimpleButton();
            this.bt_seles = new DevExpress.XtraEditors.SimpleButton();
            this.bt_reports = new DevExpress.XtraEditors.SimpleButton();
            this.bt_users = new DevExpress.XtraEditors.SimpleButton();
            this.bt_setings = new DevExpress.XtraEditors.SimpleButton();
            this.pn_navHeader = new System.Windows.Forms.Panel();
            this.pn_titleNav = new System.Windows.Forms.Panel();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.user_Roll = new System.Windows.Forms.Label();
            this.user_Name = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.bt_collapse = new DevExpress.XtraEditors.SimpleButton();
            this.pn_content = new System.Windows.Forms.Panel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.pn_topBar.SuspendLayout();
            this.pn_navBar.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.pn_navHeader.SuspendLayout();
            this.pn_titleNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_topBar
            // 
            this.pn_topBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.pn_topBar.Controls.Add(this.txt_title);
            this.pn_topBar.Controls.Add(this.bt_logout);
            this.pn_topBar.Controls.Add(this.bt_smallSize);
            this.pn_topBar.Controls.Add(this.bt_bigSize);
            this.pn_topBar.Controls.Add(this.bt_cancle);
            this.pn_topBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_topBar.Location = new System.Drawing.Point(0, 0);
            this.pn_topBar.Name = "pn_topBar";
            this.pn_topBar.Size = new System.Drawing.Size(694, 55);
            this.pn_topBar.TabIndex = 0;
            // 
            // txt_title
            // 
            this.txt_title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_title.AutoSize = true;
            this.txt_title.Font = new System.Drawing.Font("Arabic Typesetting", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_title.ForeColor = System.Drawing.Color.White;
            this.txt_title.Location = new System.Drawing.Point(326, 10);
            this.txt_title.Name = "txt_title";
            this.txt_title.Size = new System.Drawing.Size(118, 34);
            this.txt_title.TabIndex = 6;
            this.txt_title.Text = "الصفحه الرئيسيه";
            // 
            // bt_logout
            // 
            this.bt_logout.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bt_logout.ImageOptions.Image")));
            this.bt_logout.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.bt_logout.Location = new System.Drawing.Point(140, 12);
            this.bt_logout.Name = "bt_logout";
            this.bt_logout.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.bt_logout.Size = new System.Drawing.Size(40, 40);
            this.bt_logout.TabIndex = 2;
            this.bt_logout.Click += new System.EventHandler(this.bt_logout_Click);
            // 
            // bt_smallSize
            // 
            this.bt_smallSize.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bt_smallSize.ImageOptions.Image")));
            this.bt_smallSize.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.bt_smallSize.Location = new System.Drawing.Point(96, 12);
            this.bt_smallSize.Name = "bt_smallSize";
            this.bt_smallSize.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.bt_smallSize.Size = new System.Drawing.Size(40, 40);
            this.bt_smallSize.TabIndex = 3;
            this.bt_smallSize.Click += new System.EventHandler(this.bt_smallSize_Click);
            // 
            // bt_bigSize
            // 
            this.bt_bigSize.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bt_bigSize.ImageOptions.Image")));
            this.bt_bigSize.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.bt_bigSize.Location = new System.Drawing.Point(52, 12);
            this.bt_bigSize.Name = "bt_bigSize";
            this.bt_bigSize.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.bt_bigSize.Size = new System.Drawing.Size(40, 40);
            this.bt_bigSize.TabIndex = 4;
            this.bt_bigSize.Click += new System.EventHandler(this.bt_bigSize_Click);
            // 
            // bt_cancle
            // 
            this.bt_cancle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bt_cancle.ImageOptions.Image")));
            this.bt_cancle.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.bt_cancle.Location = new System.Drawing.Point(8, 12);
            this.bt_cancle.Name = "bt_cancle";
            this.bt_cancle.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.bt_cancle.Size = new System.Drawing.Size(40, 40);
            this.bt_cancle.TabIndex = 5;
            this.bt_cancle.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // pn_navBar
            // 
            this.pn_navBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.pn_navBar.Controls.Add(this.flowLayoutPanel1);
            this.pn_navBar.Controls.Add(this.pn_navHeader);
            this.pn_navBar.Dock = System.Windows.Forms.DockStyle.Right;
            this.pn_navBar.Location = new System.Drawing.Point(694, 0);
            this.pn_navBar.Name = "pn_navBar";
            this.pn_navBar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pn_navBar.Size = new System.Drawing.Size(215, 560);
            this.pn_navBar.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.bt_Home);
            this.flowLayoutPanel1.Controls.Add(this.bt_cat);
            this.flowLayoutPanel1.Controls.Add(this.bt_suppler);
            this.flowLayoutPanel1.Controls.Add(this.bt_products);
            this.flowLayoutPanel1.Controls.Add(this.bt_clinets);
            this.flowLayoutPanel1.Controls.Add(this.bt_seles);
            this.flowLayoutPanel1.Controls.Add(this.bt_reports);
            this.flowLayoutPanel1.Controls.Add(this.bt_users);
            this.flowLayoutPanel1.Controls.Add(this.bt_setings);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 177);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(215, 383);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // bt_Home
            // 
            this.bt_Home.Appearance.Font = new System.Drawing.Font("Arabic Typesetting", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Home.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.bt_Home.Appearance.Options.UseFont = true;
            this.bt_Home.Appearance.Options.UseForeColor = true;
            this.bt_Home.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bt_Home.ImageOptions.Image")));
            this.bt_Home.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.bt_Home.Location = new System.Drawing.Point(0, 3);
            this.bt_Home.Name = "bt_Home";
            this.bt_Home.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.bt_Home.Size = new System.Drawing.Size(212, 35);
            this.bt_Home.TabIndex = 2;
            this.bt_Home.Text = "الصفحه الرئيسيه";
            this.bt_Home.Click += new System.EventHandler(this.bt_Home_Click);
            // 
            // bt_cat
            // 
            this.bt_cat.Appearance.Font = new System.Drawing.Font("Arabic Typesetting", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cat.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.bt_cat.Appearance.Options.UseFont = true;
            this.bt_cat.Appearance.Options.UseForeColor = true;
            this.bt_cat.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.bt_cat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bt_cat.ImageOptions.SvgImage")));
            this.bt_cat.Location = new System.Drawing.Point(0, 44);
            this.bt_cat.Name = "bt_cat";
            this.bt_cat.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.bt_cat.Size = new System.Drawing.Size(212, 35);
            this.bt_cat.TabIndex = 3;
            this.bt_cat.Text = "الاصناف";
            this.bt_cat.Click += new System.EventHandler(this.bt_cat_Click);
            // 
            // bt_suppler
            // 
            this.bt_suppler.Appearance.Font = new System.Drawing.Font("Arabic Typesetting", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_suppler.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.bt_suppler.Appearance.Options.UseFont = true;
            this.bt_suppler.Appearance.Options.UseForeColor = true;
            this.bt_suppler.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bt_suppler.ImageOptions.Image")));
            this.bt_suppler.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.bt_suppler.Location = new System.Drawing.Point(0, 85);
            this.bt_suppler.Name = "bt_suppler";
            this.bt_suppler.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.bt_suppler.Size = new System.Drawing.Size(212, 35);
            this.bt_suppler.TabIndex = 4;
            this.bt_suppler.Text = "الموردين";
            this.bt_suppler.Click += new System.EventHandler(this.bt_suppler_Click);
            // 
            // bt_products
            // 
            this.bt_products.Appearance.Font = new System.Drawing.Font("Arabic Typesetting", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_products.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.bt_products.Appearance.Options.UseFont = true;
            this.bt_products.Appearance.Options.UseForeColor = true;
            this.bt_products.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.bt_products.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bt_products.ImageOptions.SvgImage")));
            this.bt_products.Location = new System.Drawing.Point(0, 126);
            this.bt_products.Name = "bt_products";
            this.bt_products.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.bt_products.Size = new System.Drawing.Size(212, 35);
            this.bt_products.TabIndex = 5;
            this.bt_products.Text = "المشتريات";
            this.bt_products.Click += new System.EventHandler(this.bt_products_Click);
            // 
            // bt_clinets
            // 
            this.bt_clinets.Appearance.Font = new System.Drawing.Font("Arabic Typesetting", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_clinets.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.bt_clinets.Appearance.Options.UseFont = true;
            this.bt_clinets.Appearance.Options.UseForeColor = true;
            this.bt_clinets.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.bt_clinets.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bt_clinets.ImageOptions.SvgImage")));
            this.bt_clinets.Location = new System.Drawing.Point(0, 167);
            this.bt_clinets.Name = "bt_clinets";
            this.bt_clinets.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.bt_clinets.Size = new System.Drawing.Size(212, 35);
            this.bt_clinets.TabIndex = 6;
            this.bt_clinets.Text = "العملاء";
            this.bt_clinets.Click += new System.EventHandler(this.bt_clinets_Click);
            // 
            // bt_seles
            // 
            this.bt_seles.Appearance.Font = new System.Drawing.Font("Arabic Typesetting", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_seles.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.bt_seles.Appearance.Options.UseFont = true;
            this.bt_seles.Appearance.Options.UseForeColor = true;
            this.bt_seles.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.bt_seles.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bt_seles.ImageOptions.SvgImage")));
            this.bt_seles.Location = new System.Drawing.Point(0, 208);
            this.bt_seles.Name = "bt_seles";
            this.bt_seles.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.bt_seles.Size = new System.Drawing.Size(212, 35);
            this.bt_seles.TabIndex = 7;
            this.bt_seles.Text = "المبيعات";
            this.bt_seles.Click += new System.EventHandler(this.bt_seles_Click);
            // 
            // bt_reports
            // 
            this.bt_reports.Appearance.Font = new System.Drawing.Font("Arabic Typesetting", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_reports.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.bt_reports.Appearance.Options.UseFont = true;
            this.bt_reports.Appearance.Options.UseForeColor = true;
            this.bt_reports.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.bt_reports.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bt_reports.ImageOptions.SvgImage")));
            this.bt_reports.Location = new System.Drawing.Point(0, 249);
            this.bt_reports.Name = "bt_reports";
            this.bt_reports.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.bt_reports.Size = new System.Drawing.Size(212, 35);
            this.bt_reports.TabIndex = 8;
            this.bt_reports.Text = "التقارير";
            this.bt_reports.Click += new System.EventHandler(this.bt_reports_Click);
            // 
            // bt_users
            // 
            this.bt_users.Appearance.Font = new System.Drawing.Font("Arabic Typesetting", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_users.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.bt_users.Appearance.Options.UseFont = true;
            this.bt_users.Appearance.Options.UseForeColor = true;
            this.bt_users.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bt_users.ImageOptions.Image")));
            this.bt_users.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.bt_users.Location = new System.Drawing.Point(0, 290);
            this.bt_users.Name = "bt_users";
            this.bt_users.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.bt_users.Size = new System.Drawing.Size(212, 35);
            this.bt_users.TabIndex = 9;
            this.bt_users.Text = "المستخدمين";
            this.bt_users.Click += new System.EventHandler(this.bt_users_Click);
            // 
            // bt_setings
            // 
            this.bt_setings.Appearance.Font = new System.Drawing.Font("Arabic Typesetting", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_setings.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.bt_setings.Appearance.Options.UseFont = true;
            this.bt_setings.Appearance.Options.UseForeColor = true;
            this.bt_setings.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bt_setings.ImageOptions.Image")));
            this.bt_setings.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.bt_setings.Location = new System.Drawing.Point(0, 331);
            this.bt_setings.Name = "bt_setings";
            this.bt_setings.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.bt_setings.Size = new System.Drawing.Size(212, 35);
            this.bt_setings.TabIndex = 10;
            this.bt_setings.Text = "الاعدادات";
            this.bt_setings.Click += new System.EventHandler(this.bt_setings_Click);
            // 
            // pn_navHeader
            // 
            this.pn_navHeader.Controls.Add(this.pn_titleNav);
            this.pn_navHeader.Controls.Add(this.flowLayoutPanel2);
            this.pn_navHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_navHeader.Location = new System.Drawing.Point(0, 0);
            this.pn_navHeader.Name = "pn_navHeader";
            this.pn_navHeader.Size = new System.Drawing.Size(215, 177);
            this.pn_navHeader.TabIndex = 0;
            // 
            // pn_titleNav
            // 
            this.pn_titleNav.Controls.Add(this.pictureEdit1);
            this.pn_titleNav.Controls.Add(this.user_Roll);
            this.pn_titleNav.Controls.Add(this.user_Name);
            this.pn_titleNav.Location = new System.Drawing.Point(6, 3);
            this.pn_titleNav.Name = "pn_titleNav";
            this.pn_titleNav.Size = new System.Drawing.Size(147, 161);
            this.pn_titleNav.TabIndex = 1;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(26, 9);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pictureEdit1.Size = new System.Drawing.Size(100, 96);
            this.pictureEdit1.TabIndex = 0;
            // 
            // user_Roll
            // 
            this.user_Roll.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.user_Roll.AutoSize = true;
            this.user_Roll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.user_Roll.Location = new System.Drawing.Point(58, 130);
            this.user_Roll.Name = "user_Roll";
            this.user_Roll.Size = new System.Drawing.Size(30, 21);
            this.user_Roll.TabIndex = 6;
            this.user_Roll.Text = "ادمن";
            // 
            // user_Name
            // 
            this.user_Name.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.user_Name.AutoSize = true;
            this.user_Name.ForeColor = System.Drawing.Color.Silver;
            this.user_Name.Location = new System.Drawing.Point(44, 109);
            this.user_Name.Name = "user_Name";
            this.user_Name.Size = new System.Drawing.Size(59, 21);
            this.user_Name.TabIndex = 6;
            this.user_Name.Text = "محمود عاطف";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.bt_collapse);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(172, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(43, 177);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // bt_collapse
            // 
            this.bt_collapse.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bt_collapse.ImageOptions.Image")));
            this.bt_collapse.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.bt_collapse.Location = new System.Drawing.Point(2, 3);
            this.bt_collapse.Name = "bt_collapse";
            this.bt_collapse.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.bt_collapse.Size = new System.Drawing.Size(38, 35);
            this.bt_collapse.TabIndex = 2;
            this.bt_collapse.Click += new System.EventHandler(this.bt_collapse_Click);
            // 
            // pn_content
            // 
            this.pn_content.BackColor = System.Drawing.Color.White;
            this.pn_content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_content.Location = new System.Drawing.Point(0, 55);
            this.pn_content.Name = "pn_content";
            this.pn_content.Size = new System.Drawing.Size(694, 505);
            this.pn_content.TabIndex = 2;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.pn_topBar;
            this.bunifuDragControl1.Vertical = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 560);
            this.Controls.Add(this.pn_content);
            this.Controls.Add(this.pn_topBar);
            this.Controls.Add(this.pn_navBar);
            this.Font = new System.Drawing.Font("Arabic Typesetting", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "Main";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Store";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            this.pn_topBar.ResumeLayout(false);
            this.pn_topBar.PerformLayout();
            this.pn_navBar.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.pn_navHeader.ResumeLayout(false);
            this.pn_titleNav.ResumeLayout(false);
            this.pn_titleNav.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_topBar;
        private System.Windows.Forms.Panel pn_navBar;
        private System.Windows.Forms.Panel pn_content;
        private System.Windows.Forms.Label txt_title;
        private DevExpress.XtraEditors.SimpleButton bt_logout;
        private DevExpress.XtraEditors.SimpleButton bt_smallSize;
        private DevExpress.XtraEditors.SimpleButton bt_bigSize;
        private DevExpress.XtraEditors.SimpleButton bt_cancle;
        private System.Windows.Forms.Panel pn_navHeader;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private DevExpress.XtraEditors.SimpleButton bt_Home;
        private DevExpress.XtraEditors.SimpleButton bt_collapse;
        private DevExpress.XtraEditors.SimpleButton bt_cat;
        private DevExpress.XtraEditors.SimpleButton bt_suppler;
        private DevExpress.XtraEditors.SimpleButton bt_products;
        private DevExpress.XtraEditors.SimpleButton bt_clinets;
        private DevExpress.XtraEditors.SimpleButton bt_seles;
        private DevExpress.XtraEditors.SimpleButton bt_reports;
        private DevExpress.XtraEditors.SimpleButton bt_users;
        private DevExpress.XtraEditors.SimpleButton bt_setings;
        private System.Windows.Forms.Panel pn_titleNav;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        public System.Windows.Forms.Label user_Roll;
        public System.Windows.Forms.Label user_Name;
    }
}

