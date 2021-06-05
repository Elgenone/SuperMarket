
namespace StoreManagement.PL
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.bt_Add_User = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.Server_Name = new System.Windows.Forms.TextBox();
            this.Pn_Settings = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.Pn_Settings)).BeginInit();
            this.Pn_Settings.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_Add_User
            // 
            this.bt_Add_User.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_Add_User.Appearance.Font = new System.Drawing.Font("Arabic Typesetting", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Add_User.Appearance.Options.UseFont = true;
            this.bt_Add_User.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bt_Add_User.ImageOptions.Image")));
            this.bt_Add_User.Location = new System.Drawing.Point(239, 284);
            this.bt_Add_User.Name = "bt_Add_User";
            this.bt_Add_User.Size = new System.Drawing.Size(132, 48);
            this.bt_Add_User.TabIndex = 11;
            this.bt_Add_User.Text = "حفظ";
            this.bt_Add_User.Click += new System.EventHandler(this.bt_Add_Cat_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arabic Typesetting", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(256, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 42);
            this.label1.TabIndex = 18;
            this.label1.Text = "السيرفر";
            // 
            // Server_Name
            // 
            this.Server_Name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Server_Name.Font = new System.Drawing.Font("Arabic Typesetting", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Server_Name.Location = new System.Drawing.Point(129, 131);
            this.Server_Name.Name = "Server_Name";
            this.Server_Name.Size = new System.Drawing.Size(333, 53);
            this.Server_Name.TabIndex = 19;
            this.Server_Name.Text = ".\\SQLEXPRESS";
            this.Server_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Pn_Settings
            // 
            this.Pn_Settings.Controls.Add(this.Server_Name);
            this.Pn_Settings.Controls.Add(this.label1);
            this.Pn_Settings.Controls.Add(this.bt_Add_User);
            this.Pn_Settings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pn_Settings.Location = new System.Drawing.Point(0, 0);
            this.Pn_Settings.Name = "Pn_Settings";
            this.Pn_Settings.Size = new System.Drawing.Size(590, 391);
            this.Pn_Settings.TabIndex = 17;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(590, 391);
            this.Controls.Add(this.Pn_Settings);
            this.Font = new System.Drawing.Font("Arabic Typesetting", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تعديل الاعدادات";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.Pn_Settings)).EndInit();
            this.Pn_Settings.ResumeLayout(false);
            this.Pn_Settings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraEditors.SimpleButton bt_Add_User;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox Server_Name;
        private DevExpress.XtraEditors.PanelControl Pn_Settings;
    }
}