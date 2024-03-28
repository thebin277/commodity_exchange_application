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
    public partial class ucChiTietSP : UserControl
    {
        public ucChiTietSP()
        {
            InitializeComponent();
        }

        public Image ItemImageCT
        {
            get
            {
                return txtImageCT.Image;
            }
            set
            {
                txtImageCT.Image = value;
            }
        }
        public string ItemNameCT
        {
            get
            {
                return lblNameCT.Text;
            }
            set
            {
                lblNameCT.Text = value;
            }
        }
        public string ItemPriceCT
        {
            get
            {
                return lblPrice.Text;
            }
            set
            {
                lblPrice.Text = value;
            }
        }
    }
}
