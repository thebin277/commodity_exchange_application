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
    public partial class ucPost : UserControl
    {
        public ucPost()
        {
            InitializeComponent();
        }
        public Image ItemImage
        {
            get
            {
                return PostPic.Image;
            }
            set
            {
                PostPic.Image = value;
            }
        }
        public string ItemLabel
        {
            get
            {
                return PostName.Text;
            }
            set
            {
                PostName.Text = value;
            }
        }
        public string ItemPrice
        {
            get
            {
                return PostPrice.Text;
            }
            set
            {
                PostPrice.Text = value;
            }
        }
    }
}
