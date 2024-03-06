namespace commodity_exchange_application
{
    partial class ucProduct
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucProduct));
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.pnlName = new System.Windows.Forms.Panel();
            this.guna2Separator2 = new Guna.UI2.WinForms.Guna2Separator();
            this.lblName = new System.Windows.Forms.Label();
            this.pnlPrice = new System.Windows.Forms.Panel();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtImage = new Guna.UI.WinForms.GunaPictureBox();
            this.guna2ShadowPanel1.SuspendLayout();
            this.pnlName.SuspendLayout();
            this.pnlPrice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtImage)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.pnlName);
            this.guna2ShadowPanel1.Controls.Add(this.pnlPrice);
            this.guna2ShadowPanel1.Controls.Add(this.txtImage);
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(3, 3);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(308, 367);
            this.guna2ShadowPanel1.TabIndex = 0;
            // 
            // pnlName
            // 
            this.pnlName.Controls.Add(this.guna2Separator2);
            this.pnlName.Controls.Add(this.lblName);
            this.pnlName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlName.Location = new System.Drawing.Point(0, 203);
            this.pnlName.Name = "pnlName";
            this.pnlName.Size = new System.Drawing.Size(308, 100);
            this.pnlName.TabIndex = 2;
            // 
            // guna2Separator2
            // 
            this.guna2Separator2.Location = new System.Drawing.Point(6, 0);
            this.guna2Separator2.Name = "guna2Separator2";
            this.guna2Separator2.Size = new System.Drawing.Size(302, 10);
            this.guna2Separator2.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(35, 19);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(242, 68);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "ProductName";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlPrice
            // 
            this.pnlPrice.Controls.Add(this.lblPrice);
            this.pnlPrice.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlPrice.Location = new System.Drawing.Point(0, 303);
            this.pnlPrice.Name = "pnlPrice";
            this.pnlPrice.Size = new System.Drawing.Size(308, 64);
            this.pnlPrice.TabIndex = 1;
            // 
            // lblPrice
            // 
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(27, 3);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(250, 46);
            this.lblPrice.TabIndex = 0;
            this.lblPrice.Text = "ProductPrice";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtImage
            // 
            this.txtImage.BaseColor = System.Drawing.Color.White;
            this.txtImage.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtImage.Image = ((System.Drawing.Image)(resources.GetObject("txtImage.Image")));
            this.txtImage.Location = new System.Drawing.Point(0, 0);
            this.txtImage.Name = "txtImage";
            this.txtImage.Size = new System.Drawing.Size(308, 203);
            this.txtImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.txtImage.TabIndex = 0;
            this.txtImage.TabStop = false;
            // 
            // ucProduct
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.guna2ShadowPanel1);
            this.Name = "ucProduct";
            this.Size = new System.Drawing.Size(314, 373);
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.pnlName.ResumeLayout(false);
            this.pnlPrice.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI.WinForms.GunaPictureBox txtImage;
        private System.Windows.Forms.Panel pnlName;
        private System.Windows.Forms.Panel pnlPrice;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPrice;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator2;
    }
}
