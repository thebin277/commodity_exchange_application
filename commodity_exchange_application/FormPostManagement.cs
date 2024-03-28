using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace commodity_exchange_application
{
    public partial class FormPostManagement : Form
    {
        public FormPostManagement()
        {
            InitializeComponent();
        }

       

        

        private void PostPanel_Paint(object sender, PaintEventArgs e)
        {

        }
        public void AddItems(string name, string price, Image pimage)
        {
            var w = new ucPost()
            {
                ItemLabel = name,
                ItemPrice = price,
                ItemImage = pimage,

            };
            PostPanel.Controls.Add(w);


        }

        private void FormPostManagement_Load(object sender, EventArgs e)
        {
            string qry = "select * from products";
            SqlCommand cmd = new SqlCommand(qry, DBConnection.con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            foreach (DataRow item in dt.Rows)
            {
                Byte[] imagearray = (byte[])item["HinhAnh"];
                byte[] imagebytearray = imagearray;

                AddItems(item["TenSanPham"].ToString(),
                    item["GiaTienMoi"].ToString(), Image.FromStream(new MemoryStream(imagearray)));
            }
        }
    }
}
