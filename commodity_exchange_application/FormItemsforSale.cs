using System;
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
    public partial class FormItemsforSale : Form
    {
        public FormItemsforSale()
        {
            InitializeComponent();
        }

        private void guna2ShadowPanel1_MouseEnter(object sender, EventArgs e)
        {
            ((Guna.UI2.WinForms.Guna2ShadowPanel)sender).FillColor = Color.LightBlue;
        }

        private void guna2ShadowPanel1_MouseLeave(object sender, EventArgs e)
        {
            ((Guna.UI2.WinForms.Guna2ShadowPanel)sender).FillColor = Color.White;
        }
    }
}
