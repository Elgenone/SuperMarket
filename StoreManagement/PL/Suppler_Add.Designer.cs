
namespace StoreManagement.PL
{
    partial class Suppler_Add
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Suppler_Add));
            this.label1 = new System.Windows.Forms.Label();
            this.Supp_Name = new System.Windows.Forms.TextBox();
            this.Supp_Image = new DevExpress.XtraEditors.PictureEdit();
            this.bt_Add_Supp = new DevExpress.XtraEditors.SimpleButton();
            this.Supp_Phone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Supp_Email = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Supp_Image.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arabic Typesetting", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(275, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 31);
            this.label1.TabIndex = 8;
            this.label1.Text = "اسم المورد";
            // 
            // Supp_Name
            // 
            this.Supp_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Supp_Name.Font = new System.Drawing.Font("Arabic Typesetting", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Supp_Name.Location = new System.Drawing.Point(33, 65);
            this.Supp_Name.Name = "Supp_Name";
            this.Supp_Name.Size = new System.Drawing.Size(172, 38);
            this.Supp_Name.TabIndex = 9;
            this.Supp_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Supp_Image
            // 
            this.Supp_Image.EditValue = ((object)(resources.GetObject("Supp_Image.EditValue")));
            this.Supp_Image.Location = new System.Drawing.Point(33, 258);
            this.Supp_Image.Name = "Supp_Image";
            this.Supp_Image.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.Supp_Image.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.Supp_Image.Size = new System.Drawing.Size(172, 193);
            this.Supp_Image.TabIndex = 10;
            // 
            // bt_Add_Supp
            // 
            this.bt_Add_Supp.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bt_Add_Supp.Appearance.Font = new System.Drawing.Font("Arabic Typesetting", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Add_Supp.Appearance.Options.UseFont = true;
            this.bt_Add_Supp.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bt_Add_Cat.ImageOptions.Image")));
            this.bt_Add_Supp.Location = new System.Drawing.Point(282, 429);
            this.bt_Add_Supp.Name = "bt_Add_Supp";
            this.bt_Add_Supp.Size = new System.Drawing.Size(102, 44);
            this.bt_Add_Supp.TabIndex = 11;
            this.bt_Add_Supp.Text = "اضافه ";
            this.bt_Add_Supp.Click += new System.EventHandler(this.bt_Add_Cat_Click);
            // 
            // Supp_Phone
            // 
            this.Supp_Phone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Supp_Phone.Font = new System.Drawing.Font("Arabic Typesetting", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Supp_Phone.Location = new System.Drawing.Point(33, 124);
            this.Supp_Phone.Name = "Supp_Phone";
            this.Supp_Phone.Size = new System.Drawing.Size(172, 38);
            this.Supp_Phone.TabIndex = 13;
            this.Supp_Phone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arabic Typesetting", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(276, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 31);
            this.label2.TabIndex = 12;
            this.label2.Text = "رقم الهاتف";
            // 
            // Supp_Email
            // 
            this.Supp_Email.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Supp_Email.Font = new System.Drawing.Font("Arabic Typesetting", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Supp_Email.Location = new System.Drawing.Point(33, 183);
            this.Supp_Email.Name = "Supp_Email";
            this.Supp_Email.Size = new System.Drawing.Size(172, 38);
            this.Supp_Email.TabIndex = 15;
            this.Supp_Email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arabic Typesetting", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(238, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 31);
            this.label3.TabIndex = 14;
            this.label3.Text = "البريد الالكترونى";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arabic Typesetting", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(94, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 31);
            this.label4.TabIndex = 16;
            this.label4.Text = "الصوره";
            // 
            // Suppler_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(396, 485);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Supp_Email);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Supp_Phone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bt_Add_Supp);
            this.Controls.Add(this.Supp_Image);
            this.Controls.Add(this.Supp_Name);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arabic Typesetting", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Suppler_Add";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اضافه مورد جديد";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.Supp_Image.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public DevExpress.XtraEditors.SimpleButton bt_Add_Supp;
        public System.Windows.Forms.TextBox Supp_Name;
        public DevExpress.XtraEditors.PictureEdit Supp_Image;
        public System.Windows.Forms.TextBox Supp_Phone;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox Supp_Email;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}