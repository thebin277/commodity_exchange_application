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
    public partial class ucProduct : UserControl
    {
            public event EventHandler Click;

        public ucProduct()
        {
            InitializeComponent();
            // Đăng ký sự kiện Click cho UserControl
            this.Click += ucProduct_Click;
        }

        private void ucProduct_Click(object sender, EventArgs e)
        {
            FormProductInfo formProductInfo = new FormProductInfo();
            formProductInfo.ShowDialog();
        }

        public Image ItemImage 
        {
            get
            {
                return pictureBox1.Image;
            }
            set
            {
                pictureBox1.Image = value;
            }
        }    
        public string ItemLabel
        {
            get
            {
                return label1.Text;
            }
            set
            {
                label1.Text = value;
            }
        }
        public string ItemPrice
        {
            get
            {
                return label14.Text;
            }
            set
            {
                label14.Text = value;
            }
        }

        
    }
}
