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
    public partial class FormPersonal_Information : Form
    {
        public FormPersonal_Information()
        {
            InitializeComponent();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
         //   this.Hide();
            FormPersonalIdentification FormPersonalIdentification = new FormPersonalIdentification();
            FormPersonalIdentification.ShowDialog();
           // this.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            //   this.Hide();
            FormPersonalIdentification FormPersonalIdentification = new FormPersonalIdentification();
            FormPersonalIdentification.ShowDialog();
            // this.Close();
        }
    }
}
