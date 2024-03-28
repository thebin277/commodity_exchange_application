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
            LoadProducts();
        }

        private void ucProduct1_MouseClick(object sender, MouseEventArgs e)
        {
            var clickedProduct = (ucProduct)sender;
            string tenSanPham = clickedProduct.ItemLabel;
            FormProductInfo formProductInfo = new FormProductInfo(tenSanPham);

            formProductInfo.ShowDialog();
        }



        public void AddItems(string name, string price, Image pimage)
        {
            var w = new ucProduct()
            {
                ItemLabel = name,
                ItemPrice = price,
                ItemImage = pimage,

            };
            ProductPanel.Controls.Add(w);


        }
        public void LoadProducts()
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
        private void FormMatHang_Load(object sender, EventArgs e)
        {
            ProductPanel.Controls.Clear();
            LoadProducts();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            foreach (var item in ProductPanel.Controls)
            {
                var pro = (ucProduct)item;
                pro.Visible = pro.ItemLabel.ToLower().Contains(txtTimKiem.Text.Trim().ToLower());
            }
        }
    }
}
