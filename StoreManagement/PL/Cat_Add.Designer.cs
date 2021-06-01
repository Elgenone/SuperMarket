
namespace StoreManagement.PL
{
    partial class Cat_Add
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cat_Add));
            this.label1 = new System.Windows.Forms.Label();
            this.bt_cancle = new DevExpress.XtraEditors.SimpleButton();
            this.Cat_Name = new System.Windows.Forms.TextBox();
            this.Cat_Image = new DevExpress.XtraEditors.PictureEdit();
            this.bt_Add_Cat = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.Cat_Image.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arabic Typesetting", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(212, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 31);
            this.label1.TabIndex = 8;
            this.label1.Text = "اسم الصنف";
            // 
            // bt_cancle
            // 
            this.bt_cancle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bt_cancle.ImageOptions.Image")));
            this.bt_cancle.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.bt_cancle.Location = new System.Drawing.Point(454, 12);
            this.bt_cancle.Name = "bt_cancle";
            this.bt_cancle.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.bt_cancle.Size = new System.Drawing.Size(40, 40);
            this.bt_cancle.TabIndex = 7;
            this.bt_cancle.Click += new System.EventHandler(this.bt_cancle_Click);
            // 
            // Cat_Name
            // 
            this.Cat_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Cat_Name.Font = new System.Drawing.Font("Arabic Typesetting", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cat_Name.Location = new System.Drawing.Point(167, 91);
            this.Cat_Name.Name = "Cat_Name";
            this.Cat_Name.Size = new System.Drawing.Size(172, 38);
            this.Cat_Name.TabIndex = 9;
            this.Cat_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Cat_Image
            // 
            this.Cat_Image.EditValue = ((object)(resources.GetObject("Cat_Image.EditValue")));
            this.Cat_Image.Location = new System.Drawing.Point(167, 148);
            this.Cat_Image.Name = "Cat_Image";
            this.Cat_Image.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.Cat_Image.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.Cat_Image.Size = new System.Drawing.Size(172, 193);
            this.Cat_Image.TabIndex = 10;
            // 
            // bt_Add_Cat
            // 
            this.bt_Add_Cat.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bt_Add_Cat.Appearance.Font = new System.Drawing.Font("Arabic Typesetting", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Add_Cat.Appearance.Options.UseFont = true;
            this.bt_Add_Cat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bt_Add_Cat.ImageOptions.Image")));
            this.bt_Add_Cat.Location = new System.Drawing.Point(392, 393);
            this.bt_Add_Cat.Name = "bt_Add_Cat";
            this.bt_Add_Cat.Size = new System.Drawing.Size(102, 44);
            this.bt_Add_Cat.TabIndex = 11;
            this.bt_Add_Cat.Text = "اضافه ";
            this.bt_Add_Cat.Click += new System.EventHandler(this.bt_Add_Cat_Click);
            // 
            // Cat_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(506, 449);
            this.Controls.Add(this.bt_Add_Cat);
            this.Controls.Add(this.Cat_Image);
            this.Controls.Add(this.Cat_Name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_cancle);
            this.Font = new System.Drawing.Font("Arabic Typesetting", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "Cat_Add";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cat_Add";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.Cat_Image.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton bt_cancle;
        public DevExpress.XtraEditors.SimpleButton bt_Add_Cat;
        public System.Windows.Forms.TextBox Cat_Name;
        public DevExpress.XtraEditors.PictureEdit Cat_Image;
    }
}