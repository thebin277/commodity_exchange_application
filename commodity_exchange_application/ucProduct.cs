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
        public ucProduct()
        {
            InitializeComponent();

        }

        public event EventHandler onSelect = null;

        public int id { get; set; }

        public string PPrice 
        { 
            get { return lblPrice.Text; }
            set { lblPrice.Text = value; }
        }

        public string POriPrice 
        { 
            get { return lblOriPrice.Text; }
            set { lblOriPrice.Text = value; }
        }

        public Image PImage 
        {
            get { return txtImage.Image; }
            set { txtImage.Image = value; }
        }    
        public string PName
        {
            get { return lblName.Text; }           
            set { lblName.Text = value; }            
        }
        
        public string PAddress
        { 
           get { return lblAddress.Text; } 
           set { lblAddress.Text = value; } 
        }

        
    }
}
