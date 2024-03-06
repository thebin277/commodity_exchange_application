namespace commodity_exchange_application
{
    partial class FormMatHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.guna2MatHang = new Guna.UI2.WinForms.Guna2Panel();
            this.lbMatHang = new System.Windows.Forms.Label();
            this.CategoryPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ProductPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2DangBan = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.ucProduct1 = new commodity_exchange_application.ucProduct();
            this.ucProduct2 = new commodity_exchange_application.ucProduct();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.btnDangBan = new Guna.UI2.WinForms.Guna2Button();
            this.guna2MatHang.SuspendLayout();
            this.CategoryPanel.SuspendLayout();
            this.ProductPanel.SuspendLayout();
            this.guna2DangBan.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2MatHang
            // 
            this.guna2MatHang.Controls.Add(this.lbMatHang);
            this.guna2MatHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2MatHang.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2MatHang.Location = new System.Drawing.Point(0, 0);
            this.guna2MatHang.Name = "guna2MatHang";
            this.guna2MatHang.Size = new System.Drawing.Size(1193, 100);
            this.guna2MatHang.TabIndex = 0;
            // 
            // lbMatHang
            // 
            this.lbMatHang.AutoSize = true;
            this.lbMatHang.BackColor = System.Drawing.Color.Transparent;
            this.lbMatHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lbMatHang.ForeColor = System.Drawing.Color.White;
            this.lbMatHang.Location = new System.Drawing.Point(51, 31);
            this.lbMatHang.Name = "lbMatHang";
            this.lbMatHang.Size = new System.Drawing.Size(160, 37);
            this.lbMatHang.TabIndex = 0;
            this.lbMatHang.Text = "Mặt hàng ";
            // 
            // CategoryPanel
            // 
            this.CategoryPanel.Controls.Add(this.guna2Button1);
            this.CategoryPanel.Controls.Add(this.guna2Button2);
            this.CategoryPanel.Controls.Add(this.guna2Button3);
            this.CategoryPanel.Location = new System.Drawing.Point(11, 186);
            this.CategoryPanel.Name = "CategoryPanel";
            this.CategoryPanel.Size = new System.Drawing.Size(200, 543);
            this.CategoryPanel.TabIndex = 1;
            // 
            // ProductPanel
            // 
            this.ProductPanel.Controls.Add(this.ucProduct1);
            this.ProductPanel.Controls.Add(this.ucProduct2);
            this.ProductPanel.Location = new System.Drawing.Point(217, 186);
            this.ProductPanel.Name = "ProductPanel";
            this.ProductPanel.Size = new System.Drawing.Size(953, 543);
            this.ProductPanel.TabIndex = 2;
            // 
            // guna2DangBan
            // 
            this.guna2DangBan.Controls.Add(this.btnDangBan);
            this.guna2DangBan.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2DangBan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2DangBan.Location = new System.Drawing.Point(0, 735);
            this.guna2DangBan.Name = "guna2DangBan";
            this.guna2DangBan.Size = new System.Drawing.Size(1193, 74);
            this.guna2DangBan.TabIndex = 3;
            this.guna2DangBan.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2DangBan_Paint);
            // 
            // guna2Button1
            // 
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(3, 3);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(197, 70);
            this.guna2Button1.TabIndex = 0;
            this.guna2Button1.Text = "Mat hang 1";
            // 
            // ucProduct1
            // 
            this.ucProduct1.Location = new System.Drawing.Point(3, 3);
            this.ucProduct1.Name = "ucProduct1";
            this.ucProduct1.Size = new System.Drawing.Size(314, 373);
            this.ucProduct1.TabIndex = 0;
            this.ucProduct1.Load += new System.EventHandler(this.ucProduct1_Load);
            // 
            // ucProduct2
            // 
            this.ucProduct2.Location = new System.Drawing.Point(323, 3);
            this.ucProduct2.Name = "ucProduct2";
            this.ucProduct2.Size = new System.Drawing.Size(314, 373);
            this.ucProduct2.TabIndex = 1;
            // 
            // guna2Button2
            // 
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Location = new System.Drawing.Point(3, 79);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(197, 70);
            this.guna2Button2.TabIndex = 1;
            this.guna2Button2.Text = "Mat hang 2";
            // 
            // guna2Button3
            // 
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.Location = new System.Drawing.Point(3, 155);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(197, 70);
            this.guna2Button3.TabIndex = 2;
            this.guna2Button3.Text = "Mat hang 3";
            // 
            // btnDangBan
            // 
            this.btnDangBan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDangBan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDangBan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDangBan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDangBan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDangBan.ForeColor = System.Drawing.Color.White;
            this.btnDangBan.Location = new System.Drawing.Point(931, 17);
            this.btnDangBan.Name = "btnDangBan";
            this.btnDangBan.Size = new System.Drawing.Size(180, 45);
            this.btnDangBan.TabIndex = 0;
            this.btnDangBan.Text = "Đăng bán ";
            this.btnDangBan.Click += new System.EventHandler(this.btnDangBan_Click);
            // 
            // FormMatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 809);
            this.Controls.Add(this.guna2DangBan);
            this.Controls.Add(this.ProductPanel);
            this.Controls.Add(this.CategoryPanel);
            this.Controls.Add(this.guna2MatHang);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMatHang";
            this.Text = "la";
            this.guna2MatHang.ResumeLayout(false);
            this.guna2MatHang.PerformLayout();
            this.CategoryPanel.ResumeLayout(false);
            this.ProductPanel.ResumeLayout(false);
            this.guna2DangBan.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2MatHang;
        private System.Windows.Forms.Label lbMatHang;
        private System.Windows.Forms.FlowLayoutPanel CategoryPanel;
        private System.Windows.Forms.FlowLayoutPanel ProductPanel;
        private Guna.UI2.WinForms.Guna2Panel guna2DangBan;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private ucProduct ucProduct1;
        private ucProduct ucProduct2;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button btnDangBan;
    }
}