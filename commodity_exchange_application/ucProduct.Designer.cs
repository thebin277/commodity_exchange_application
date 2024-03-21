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
            this.lblName = new System.Windows.Forms.Label();
            this.guna2RatingStar1 = new Guna.UI2.WinForms.Guna2RatingStar();
            this.txtImage = new System.Windows.Forms.PictureBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblOriPrice = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblName.Location = new System.Drawing.Point(18, 223);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(174, 32);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Xe đạp trẻ em";
            // 
            // guna2RatingStar1
            // 
            this.guna2RatingStar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2RatingStar1.Location = new System.Drawing.Point(24, 329);
            this.guna2RatingStar1.Name = "guna2RatingStar1";
            this.guna2RatingStar1.Size = new System.Drawing.Size(141, 39);
            this.guna2RatingStar1.TabIndex = 1;
            // 
            // txtImage
            // 
            this.txtImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtImage.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtImage.Image = ((System.Drawing.Image)(resources.GetObject("txtImage.Image")));
            this.txtImage.Location = new System.Drawing.Point(0, 0);
            this.txtImage.Name = "txtImage";
            this.txtImage.Size = new System.Drawing.Size(323, 220);
            this.txtImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.txtImage.TabIndex = 2;
            this.txtImage.TabStop = false;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.lblPrice.ForeColor = System.Drawing.Color.Red;
            this.lblPrice.Location = new System.Drawing.Point(20, 266);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(157, 45);
            this.lblPrice.TabIndex = 19;
            this.lblPrice.Text = "200,000 đ";
            // 
            // lblOriPrice
            // 
            this.lblOriPrice.AutoSize = true;
            this.lblOriPrice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblOriPrice.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Strikeout);
            this.lblOriPrice.Location = new System.Drawing.Point(192, 278);
            this.lblOriPrice.Name = "lblOriPrice";
            this.lblOriPrice.Size = new System.Drawing.Size(109, 30);
            this.lblOriPrice.TabIndex = 20;
            this.lblOriPrice.Text = "400,000 đ";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(22, 386);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(150, 32);
            this.lblAddress.TabIndex = 21;
            this.lblAddress.Text = "Hồ Chí Minh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(191, 336);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 32);
            this.label4.TabIndex = 22;
            this.label4.Text = "Đã bán 5 ";
            // 
            // ucProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblOriPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtImage);
            this.Controls.Add(this.guna2RatingStar1);
            this.Controls.Add(this.lblName);
            this.Name = "ucProduct";
            this.Size = new System.Drawing.Size(323, 442);
            ((System.ComponentModel.ISupportInitialize)(this.txtImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private Guna.UI2.WinForms.Guna2RatingStar guna2RatingStar1;
        private System.Windows.Forms.PictureBox txtImage;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblOriPrice;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label label4;
    }
}
