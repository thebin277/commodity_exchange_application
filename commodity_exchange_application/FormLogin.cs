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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormHome formHome = new FormHome();
            formHome.ShowDialog();
            this.Close();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormSignUp FormSignUp = new FormSignUp();
            FormSignUp.ShowDialog();
            this.Close();
        }
    }
}
