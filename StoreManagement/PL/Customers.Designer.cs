
namespace StoreManagement.PL
{
    partial class Customers
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
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition1 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition1 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition2 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition3 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition4 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement1 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement2 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement3 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement4 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customers));
            this.pn_Cus = new System.Windows.Forms.Panel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.tileView1 = new DevExpress.XtraGrid.Views.Tile.TileView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.bt_search = new DevExpress.XtraEditors.SimpleButton();
            this.bt_update = new DevExpress.XtraEditors.SimpleButton();
            this.bt_delete = new DevExpress.XtraEditors.SimpleButton();
            this.bt_Edite = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.colID = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colCus_Name = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colCus_Phone = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colCus_Email = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colCus_Image = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.pn_Cus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_Cus
            // 
            this.pn_Cus.Controls.Add(this.gridControl1);
            this.pn_Cus.Controls.Add(this.panel1);
            this.pn_Cus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_Cus.Location = new System.Drawing.Point(0, 0);
            this.pn_Cus.Name = "pn_Cus";
            this.pn_Cus.Size = new System.Drawing.Size(694, 502);
            this.pn_Cus.TabIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = typeof(StoreManagement.TB_Cus);
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.tileView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(694, 431);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.tileView1});
            // 
            // tileView1
            // 
            this.tileView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colCus_Name,
            this.colCus_Phone,
            this.colCus_Email,
            this.colCus_Image});
            this.tileView1.GridControl = this.gridControl1;
            this.tileView1.Name = "tileView1";
            this.tileView1.OptionsTiles.ItemSize = new System.Drawing.Size(258, 304);
            this.tileView1.OptionsTiles.RowCount = 0;
            this.tileView1.TileColumns.Add(tableColumnDefinition1);
            tableRowDefinition1.Length.Value = 48D;
            tableRowDefinition2.Length.Value = 46D;
            tableRowDefinition3.Length.Value = 48D;
            tableRowDefinition4.Length.Value = 146D;
            this.tileView1.TileRows.Add(tableRowDefinition1);
            this.tileView1.TileRows.Add(tableRowDefinition2);
            this.tileView1.TileRows.Add(tableRowDefinition3);
            this.tileView1.TileRows.Add(tableRowDefinition4);
            tileViewItemElement1.Column = this.colCus_Name;
            tileViewItemElement1.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement1.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            tileViewItemElement1.Text = "colCus_Name";
            tileViewItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement2.Column = this.colCus_Phone;
            tileViewItemElement2.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement2.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            tileViewItemElement2.RowIndex = 1;
            tileViewItemElement2.Text = "colCus_Phone";
            tileViewItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement3.Column = this.colCus_Email;
            tileViewItemElement3.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement3.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            tileViewItemElement3.RowIndex = 2;
            tileViewItemElement3.Text = "colCus_Email";
            tileViewItemElement3.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement4.Column = this.colCus_Image;
            tileViewItemElement4.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement4.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            tileViewItemElement4.RowIndex = 3;
            tileViewItemElement4.Text = "colCus_Image";
            tileViewItemElement4.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tileView1.TileTemplate.Add(tileViewItemElement1);
            this.tileView1.TileTemplate.Add(tileViewItemElement2);
            this.tileView1.TileTemplate.Add(tileViewItemElement3);
            this.tileView1.TileTemplate.Add(tileViewItemElement4);
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
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            // 
            // colCus_Name
            // 
            this.colCus_Name.FieldName = "Cus_Name";
            this.colCus_Name.Name = "colCus_Name";
            this.colCus_Name.Visible = true;
            this.colCus_Name.VisibleIndex = 1;
            // 
            // colCus_Phone
            // 
            this.colCus_Phone.FieldName = "Cus_Phone";
            this.colCus_Phone.Name = "colCus_Phone";
            this.colCus_Phone.Visible = true;
            this.colCus_Phone.VisibleIndex = 2;
            // 
            // colCus_Email
            // 
            this.colCus_Email.FieldName = "Cus_Email";
            this.colCus_Email.Name = "colCus_Email";
            this.colCus_Email.Visible = true;
            this.colCus_Email.VisibleIndex = 3;
            // 
            // colCus_Image
            // 
            this.colCus_Image.FieldName = "Cus_Image";
            this.colCus_Image.Name = "colCus_Image";
            this.colCus_Image.Visible = true;
            this.colCus_Image.VisibleIndex = 4;
            // 
            // Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(694, 502);
            this.Controls.Add(this.pn_Cus);
            this.Font = new System.Drawing.Font("Arabic Typesetting", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "Customers";
            this.Text = "Catagories";
            this.pn_Cus.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel pn_Cus;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_search;
        private DevExpress.XtraEditors.SimpleButton bt_search;
        private DevExpress.XtraEditors.SimpleButton bt_update;
        private DevExpress.XtraEditors.SimpleButton bt_delete;
        private DevExpress.XtraEditors.SimpleButton bt_Edite;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraGrid.Views.Tile.TileView tileView1;
        public DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Columns.TileViewColumn colID;
        private DevExpress.XtraGrid.Columns.TileViewColumn colCus_Name;
        private DevExpress.XtraGrid.Columns.TileViewColumn colCus_Phone;
        private DevExpress.XtraGrid.Columns.TileViewColumn colCus_Email;
        private DevExpress.XtraGrid.Columns.TileViewColumn colCus_Image;
    }
}