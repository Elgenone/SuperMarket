﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreManagement
{
    public partial class Main : Form
    {
        //the forms
        PL.Catagories cat = new PL.Catagories();
        PL.Home home = new PL.Home();
        PL.Suppleries sup = new PL.Suppleries();
        DB_SMPEntities db = new DB_SMPEntities();

        public Main()
        {
            InitializeComponent();
        }

        //cancel button
        private void Cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //maxmiz button
        private void bt_bigSize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        //minimize button
        private void bt_smallSize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        //collapse button
        private void bt_collapse_Click(object sender, EventArgs e)
        {
            if (pn_navBar.Width == 215)
            {
                pn_navBar.Width = 40;
                pn_titleNav.Visible = false;
                pn_navHeader.Height = 100;
            }
            else
            {
                pn_navBar.Width = 215;
                pn_titleNav.Visible = true;
                pn_navHeader.Height = 177;
            }
        }

        //Load home Page
        private void bt_Home_Click(object sender, EventArgs e)
        {
            pn_content.Controls.Clear();
            pn_content.Controls.Add(home.pn_home);
            txt_title.Text = "الصفحه الرئيسيه";

        }

        private void Main_Load(object sender, EventArgs e)
        {
            pn_content.Controls.Clear();
            pn_content.Controls.Add(home.pn_home);
            txt_title.Text = "الصفحه الرئيسيه";
        }

        //Load catagory Page
        private void bt_cat_Click(object sender, EventArgs e)
        {
            pn_content.Controls.Clear();
            pn_content.Controls.Add(cat.pn_cat);
            db = new DB_SMPEntities();
            txt_title.Text = "الا صناف";
        }

        //Load suppleries Page
        private void bt_suppler_Click(object sender, EventArgs e)
        {
            pn_content.Controls.Clear();
            pn_content.Controls.Add(sup.pn_Supp);
            db = new DB_SMPEntities();
            txt_title.Text = "الموردين";
        }
    }
}
