
namespace StoreManagement.PL
{
    partial class Sales_ِAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sales_ِAdd));
            this.bt_Add_Sal = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.Sal_CusName = new System.Windows.Forms.ComboBox();
            this.Sal_PurName = new System.Windows.Forms.ComboBox();
            this.Add_Cus = new DevExpress.XtraEditors.SimpleButton();
            this.Add_Pur = new DevExpress.XtraEditors.SimpleButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.Sal_Qt = new DevExpress.XtraEditors.SpinEdit();
            this.Sal_Sell = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Sal_TSell = new System.Windows.Forms.Label();
            this.Sal_TQt = new System.Windows.Forms.Label();
            this.Sal_TBuy = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Sal_Qt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_Add_Sal
            // 
            this.bt_Add_Sal.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bt_Add_Sal.Appearance.Font = new System.Drawing.Font("Arabic Typesetting", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Add_Sal.Appearance.Options.UseFont = true;
            this.bt_Add_Sal.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bt_Add_Sal.ImageOptions.Image")));
            this.bt_Add_Sal.Location = new System.Drawing.Point(760, 477);
            this.bt_Add_Sal.Name = "bt_Add_Sal";
            this.bt_Add_Sal.Size = new System.Drawing.Size(102, 44);
            this.bt_Add_Sal.TabIndex = 20;
            this.bt_Add_Sal.Text = "اضافه ";
            this.bt_Add_Sal.Click += new System.EventHandler(this.bt_Add_Pur_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupControl1.CaptionImageOptions.Image")));
            this.groupControl1.Controls.Add(this.Sal_CusName);
            this.groupControl1.Controls.Add(this.Sal_PurName);
            this.groupControl1.Controls.Add(this.Add_Cus);
            this.groupControl1.Controls.Add(this.Add_Pur);
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.groupControl1.Location = new System.Drawing.Point(369, 54);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupControl1.Size = new System.Drawing.Size(493, 189);
            this.groupControl1.TabIndex = 26;
            this.groupControl1.Text = "المعلومات الاساسيه";
            // 
            // Sal_CusName
            // 
            this.Sal_CusName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Sal_CusName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.Sal_CusName.Font = new System.Drawing.Font("Arabic Typesetting", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sal_CusName.FormattingEnabled = true;
            this.Sal_CusName.IntegralHeight = false;
            this.Sal_CusName.Location = new System.Drawing.Point(28, 113);
            this.Sal_CusName.Name = "Sal_CusName";
            this.Sal_CusName.Size = new System.Drawing.Size(230, 29);
            this.Sal_CusName.TabIndex = 40;
            // 
            // Sal_PurName
            // 
            this.Sal_PurName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Sal_PurName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.Sal_PurName.Font = new System.Drawing.Font("Arabic Typesetting", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sal_PurName.FormattingEnabled = true;
            this.Sal_PurName.Location = new System.Drawing.Point(28, 67);
            this.Sal_PurName.Name = "Sal_PurName";
            this.Sal_PurName.Size = new System.Drawing.Size(230, 29);
            this.Sal_PurName.TabIndex = 39;
            this.Sal_PurName.SelectedIndexChanged += new System.EventHandler(this.Sal_PurName_SelectedIndexChanged);
            // 
            // Add_Cus
            // 
            this.Add_Cus.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.Add_Cus.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Add_Cus.ImageOptions.SvgImage")));
            this.Add_Cus.Location = new System.Drawing.Point(264, 112);
            this.Add_Cus.Name = "Add_Cus";
            this.Add_Cus.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.Add_Cus.Size = new System.Drawing.Size(30, 31);
            this.Add_Cus.TabIndex = 37;
            this.Add_Cus.Click += new System.EventHandler(this.Add_Cus_Click);
            // 
            // Add_Pur
            // 
            this.Add_Pur.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.Add_Pur.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Add_Pur.ImageOptions.SvgImage")));
            this.Add_Pur.Location = new System.Drawing.Point(264, 65);
            this.Add_Pur.Name = "Add_Pur";
            this.Add_Pur.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.Add_Pur.Size = new System.Drawing.Size(30, 31);
            this.Add_Pur.TabIndex = 38;
            this.Add_Pur.Click += new System.EventHandler(this.Add_Pur_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arabic Typesetting", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(419, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 31);
            this.label6.TabIndex = 29;
            this.label6.Text = "العميل";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arabic Typesetting", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(409, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 31);
            this.label5.TabIndex = 30;
            this.label5.Text = "اسم الماده";
            // 
            // groupControl2
            // 
            this.groupControl2.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupControl2.CaptionImageOptions.Image")));
            this.groupControl2.Controls.Add(this.Sal_Qt);
            this.groupControl2.Controls.Add(this.Sal_Sell);
            this.groupControl2.Controls.Add(this.label8);
            this.groupControl2.Controls.Add(this.label9);
            this.groupControl2.GroupStyle = DevExpress.Utils.GroupStyle.Card;
            this.groupControl2.Location = new System.Drawing.Point(369, 307);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupControl2.Size = new System.Drawing.Size(493, 156);
            this.groupControl2.TabIndex = 27;
            this.groupControl2.Text = "البيع ";
            // 
            // Sal_Qt
            // 
            this.Sal_Qt.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Sal_Qt.Location = new System.Drawing.Point(15, 99);
            this.Sal_Qt.Name = "Sal_Qt";
            this.Sal_Qt.Properties.AutoHeight = false;
            this.Sal_Qt.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Sal_Qt.Size = new System.Drawing.Size(230, 29);
            this.Sal_Qt.TabIndex = 41;
            this.Sal_Qt.EditValueChanged += new System.EventHandler(this.Pur_Qt_EditValueChanged);
            // 
            // Sal_Sell
            // 
            this.Sal_Sell.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Sal_Sell.Font = new System.Drawing.Font("Arabic Typesetting", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sal_Sell.Location = new System.Drawing.Point(14, 46);
            this.Sal_Sell.Name = "Sal_Sell";
            this.Sal_Sell.Size = new System.Drawing.Size(230, 29);
            this.Sal_Sell.TabIndex = 40;
            this.Sal_Sell.Text = "0";
            this.Sal_Sell.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Sal_Sell.TextChanged += new System.EventHandler(this.Pur_Sell_TextChanged);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arabic Typesetting", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gray;
            this.label8.Location = new System.Drawing.Point(419, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 31);
            this.label8.TabIndex = 38;
            this.label8.Text = "الكميه";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arabic Typesetting", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Gray;
            this.label9.Location = new System.Drawing.Point(400, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 31);
            this.label9.TabIndex = 39;
            this.label9.Text = "سعر البيع ";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.panel1);
            this.panelControl1.Controls.Add(this.Sal_TSell);
            this.panelControl1.Controls.Add(this.Sal_TQt);
            this.panelControl1.Controls.Add(this.Sal_TBuy);
            this.panelControl1.Controls.Add(this.label14);
            this.panelControl1.Controls.Add(this.label12);
            this.panelControl1.Controls.Add(this.label10);
            this.panelControl1.Location = new System.Drawing.Point(12, 50);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(338, 365);
            this.panelControl1.TabIndex = 28;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(334, 68);
            this.panel1.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arabic Typesetting", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(88, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 55);
            this.label1.TabIndex = 28;
            this.label1.Text = "تفاصيل الماده";
            // 
            // Sal_TSell
            // 
            this.Sal_TSell.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Sal_TSell.AutoSize = true;
            this.Sal_TSell.Font = new System.Drawing.Font("Arabic Typesetting", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sal_TSell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Sal_TSell.Location = new System.Drawing.Point(156, 202);
            this.Sal_TSell.Name = "Sal_TSell";
            this.Sal_TSell.Size = new System.Drawing.Size(40, 55);
            this.Sal_TSell.TabIndex = 28;
            this.Sal_TSell.Text = "0";
            // 
            // Sal_TQt
            // 
            this.Sal_TQt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Sal_TQt.AutoSize = true;
            this.Sal_TQt.Font = new System.Drawing.Font("Arabic Typesetting", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sal_TQt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Sal_TQt.Location = new System.Drawing.Point(156, 294);
            this.Sal_TQt.Name = "Sal_TQt";
            this.Sal_TQt.Size = new System.Drawing.Size(40, 55);
            this.Sal_TQt.TabIndex = 28;
            this.Sal_TQt.Text = "0";
            // 
            // Sal_TBuy
            // 
            this.Sal_TBuy.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Sal_TBuy.AutoSize = true;
            this.Sal_TBuy.Font = new System.Drawing.Font("Arabic Typesetting", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sal_TBuy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Sal_TBuy.Location = new System.Drawing.Point(156, 110);
            this.Sal_TBuy.Name = "Sal_TBuy";
            this.Sal_TBuy.Size = new System.Drawing.Size(40, 55);
            this.Sal_TBuy.TabIndex = 28;
            this.Sal_TBuy.Text = "0";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arabic Typesetting", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.DimGray;
            this.label14.Location = new System.Drawing.Point(136, 165);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(81, 37);
            this.label14.TabIndex = 28;
            this.label14.Text = "سعر البيع";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arabic Typesetting", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DimGray;
            this.label12.Location = new System.Drawing.Point(142, 257);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 37);
            this.label12.TabIndex = 28;
            this.label12.Text = "الكميه";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arabic Typesetting", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DimGray;
            this.label10.Location = new System.Drawing.Point(122, 73);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 37);
            this.label10.TabIndex = 28;
            this.label10.Text = "سعر الشراء";
            // 
            // Sales_ِAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(874, 533);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.bt_Add_Sal);
            this.Font = new System.Drawing.Font("Arabic Typesetting", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Sales_ِAdd";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اضافه مشتريات جديده";
            this.TopMost = true;
            this.Activated += new System.EventHandler(this.Purchas_ِAdd_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Sal_Qt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public DevExpress.XtraEditors.SimpleButton bt_Add_Sal;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton Add_Cus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton Add_Pur;
        public System.Windows.Forms.TextBox Sal_Sell;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.ComboBox Sal_CusName;
        public System.Windows.Forms.ComboBox Sal_PurName;
        public DevExpress.XtraEditors.SpinEdit Sal_Qt;
        public System.Windows.Forms.Label Sal_TSell;
        public System.Windows.Forms.Label Sal_TQt;
        public System.Windows.Forms.Label Sal_TBuy;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}