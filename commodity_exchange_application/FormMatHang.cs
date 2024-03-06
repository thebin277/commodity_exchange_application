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
    public partial class FormMatHang : Form
    {
        public FormMatHang()
        {
            InitializeComponent();
            
        }

        private void guna2DangBan_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ucProduct1_Load(object sender, EventArgs e)
        {
           
        }

        private void btnDangBan_Click(object sender, EventArgs e)
        {
            FormDK_Ban formDK_Ban = new FormDK_Ban();
            formDK_Ban.Show();
        }
    }
}
