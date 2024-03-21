﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace commodity_exchange_application
{
    public partial class FormMatHang : Form
    {
        public FormMatHang()
        {
            InitializeComponent();
        }

        public void AddControls(Form f)
        {
            ProductPanel.Controls.Clear();
            f.Dock = DockStyle.Fill;
            f.TopLevel = false;
            ProductPanel.Controls.Add(f);
            f.Show();
        }
        
        private void btnDangBan_Click(object sender, EventArgs e)
        {
            FormDK_Ban ban = new FormDK_Ban();
            ban.ShowDialog();
        }

        private void ucProduct1_MouseClick(object sender, MouseEventArgs e)
        {
            FormProductInfo ban = new FormProductInfo();
            ban.ShowDialog();
        }
    }
}
