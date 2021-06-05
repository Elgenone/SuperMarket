
namespace StoreManagement.PL
{
    partial class Users
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Users));
            this.pn_Pur = new System.Windows.Forms.Panel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.bt_search = new DevExpress.XtraEditors.SimpleButton();
            this.bt_update = new DevExpress.XtraEditors.SimpleButton();
            this.bt_delete = new DevExpress.XtraEditors.SimpleButton();
            this.bt_Edite = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.colUser_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUser_Pass = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUser_Roll = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUser_Status = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pn_Pur.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_Pur
            // 
            this.pn_Pur.Controls.Add(this.gridControl1);
            this.pn_Pur.Controls.Add(this.panel1);
            this.pn_Pur.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_Pur.Location = new System.Drawing.Point(0, 0);
            this.pn_Pur.Name = "pn_Pur";
            this.pn_Pur.Size = new System.Drawing.Size(694, 502);
            this.pn_Pur.TabIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = typeof(StoreManagement.TB_User);
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(694, 431);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.GroupPanel.Font = new System.Drawing.Font("Arabic Typesetting", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.GroupPanel.Options.UseFont = true;
            this.gridView1.Appearance.GroupPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.GroupPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.GroupPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Arabic Typesetting", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Arabic Typesetting", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Appearance.Row.Options.UseTextOptions = true;
            this.gridView1.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colUser_Name,
            this.colUser_Pass,
            this.colUser_Roll,
            this.colUser_Status});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txt_search);
            this.panel1.Controls.Add(this.bt_search);
            this.panel1.Controls.Add(this.bt_update);
            this.panel1.Controls.Add(this.bt_delete);
            this.panel1.Controls.Add(this.bt_Edite);
            this.panel1.Controls.Add(this.simpleButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 431);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(694, 71);
            this.panel1.TabIndex = 2;
            // 
            // txt_search
            // 
            this.txt_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_search.Font = new System.Drawing.Font("Arabic Typesetting", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.Location = new System.Drawing.Point(408, 14);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(206, 38);
            this.txt_search.TabIndex = 2;
            this.txt_search.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // bt_search
            // 
            this.bt_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_search.Appearance.Font = new System.Drawing.Font("Arabic Typesetting", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_search.Appearance.Options.UseFont = true;
            this.bt_search.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.bt_search.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bt_search.ImageOptions.SvgImage")));
            this.bt_search.Location = new System.Drawing.Point(628, 14);
            this.bt_search.Name = "bt_search";
            this.bt_search.Size = new System.Drawing.Size(50, 38);
            this.bt_search.TabIndex = 1;
            this.bt_search.Click += new System.EventHandler(this.bt_search_Click);
            // 
            // bt_update
            // 
            this.bt_update.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bt_update.Appearance.Font = new System.Drawing.Font("Arabic Typesetting", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_update.Appearance.Options.UseFont = true;
            this.bt_update.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bt_update.ImageOptions.SvgImage")));
            this.bt_update.Location = new System.Drawing.Point(277, 14);
            this.bt_update.Name = "bt_update";
            this.bt_update.Size = new System.Drawing.Size(80, 44);
            this.bt_update.TabIndex = 1;
            this.bt_update.Text = "تحديث";
            this.bt_update.Click += new System.EventHandler(this.bt_update_Click);
            // 
            // bt_delete
            // 
            this.bt_delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bt_delete.Appearance.Font = new System.Drawing.Font("Arabic Typesetting", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_delete.Appearance.Options.UseFont = true;
            this.bt_delete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bt_delete.ImageOptions.Image")));
            this.bt_delete.Location = new System.Drawing.Point(191, 14);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(80, 44);
            this.bt_delete.TabIndex = 1;
            this.bt_delete.Text = "حذف";
            this.bt_delete.Click += new System.EventHandler(this.bt_delete_Click);
            // 
            // bt_Edite
            // 
            this.bt_Edite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bt_Edite.Appearance.Font = new System.Drawing.Font("Arabic Typesetting", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Edite.Appearance.Options.UseFont = true;
            this.bt_Edite.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bt_Edite.ImageOptions.Image")));
            this.bt_Edite.Location = new System.Drawing.Point(105, 14);
            this.bt_Edite.Name = "bt_Edite";
            this.bt_Edite.Size = new System.Drawing.Size(80, 44);
            this.bt_Edite.TabIndex = 1;
            this.bt_Edite.Text = "تعديل";
            this.bt_Edite.Click += new System.EventHandler(this.bt_Edite_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Arabic Typesetting", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.simpleButton1.Location = new System.Drawing.Point(19, 14);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(80, 44);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "اضافه";
            this.simpleButton1.Click += new System.EventHandler(this.bt_Add);
            // 
            // colUser_Name
            // 
            this.colUser_Name.Caption = "اسم المستخدم";
            this.colUser_Name.FieldName = "User_Name";
            this.colUser_Name.Name = "colUser_Name";
            this.colUser_Name.Visible = true;
            this.colUser_Name.VisibleIndex = 0;
            // 
            // colUser_Pass
            // 
            this.colUser_Pass.Caption = "كلمه السر";
            this.colUser_Pass.FieldName = "User_Pass";
            this.colUser_Pass.Name = "colUser_Pass";
            this.colUser_Pass.Visible = true;
            this.colUser_Pass.VisibleIndex = 1;
            // 
            // colUser_Roll
            // 
            this.colUser_Roll.Caption = "الصلاحيه";
            this.colUser_Roll.FieldName = "User_Roll";
            this.colUser_Roll.Name = "colUser_Roll";
            this.colUser_Roll.Visible = true;
            this.colUser_Roll.VisibleIndex = 2;
            // 
            // colUser_Status
            // 
            this.colUser_Status.Caption = "حاله الدخول";
            this.colUser_Status.FieldName = "User_Status";
            this.colUser_Status.Name = "colUser_Status";
            this.colUser_Status.Visible = true;
            this.colUser_Status.VisibleIndex = 3;
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(694, 502);
            this.Controls.Add(this.pn_Pur);
            this.Font = new System.Drawing.Font("Arabic Typesetting", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "Users";
            this.Text = "Catagories";
            this.Activated += new System.EventHandler(this.Purchases_Activated);
            this.pn_Pur.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel pn_Pur;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_search;
        private DevExpress.XtraEditors.SimpleButton bt_search;
        private DevExpress.XtraEditors.SimpleButton bt_update;
        private DevExpress.XtraEditors.SimpleButton bt_delete;
        private DevExpress.XtraEditors.SimpleButton bt_Edite;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        public DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colUser_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colUser_Pass;
        private DevExpress.XtraGrid.Columns.GridColumn colUser_Roll;
        private DevExpress.XtraGrid.Columns.GridColumn colUser_Status;
    }
}