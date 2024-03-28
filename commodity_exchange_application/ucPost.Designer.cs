namespace commodity_exchange_application
{
    partial class ucPost
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucPost));
            this.PostPrice = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.PostName = new Guna.UI.WinForms.GunaLabel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.PostPic = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PostPic)).BeginInit();
            this.SuspendLayout();
            // 
            // PostPrice
            // 
            this.PostPrice.AutoSize = true;
            this.PostPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PostPrice.ForeColor = System.Drawing.Color.Red;
            this.PostPrice.Location = new System.Drawing.Point(146, 74);
            this.PostPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PostPrice.Name = "PostPrice";
            this.PostPrice.Size = new System.Drawing.Size(114, 28);
            this.PostPrice.TabIndex = 15;
            this.PostPrice.Text = "2.990.000 ₫";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.Lime;
            this.gunaLabel2.Location = new System.Drawing.Point(290, 74);
            this.gunaLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(108, 28);
            this.gunaLabel2.TabIndex = 14;
            this.gunaLabel2.Text = "Cho trả giá";
            // 
            // PostName
            // 
            this.PostName.AutoSize = true;
            this.PostName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PostName.Location = new System.Drawing.Point(146, 42);
            this.PostName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PostName.Name = "PostName";
            this.PostName.Size = new System.Drawing.Size(543, 20);
            this.PostName.TabIndex = 13;
            this.PostName.Text = "GIÀY THỂ THAO MLB CHUNKY LINER BASIC BOS 3ASXCLB3N-43GOS MÀU VÀNG";
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 20;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(788, 54);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(119, 46);
            this.guna2Button1.TabIndex = 12;
            this.guna2Button1.Text = "Gỡ bài";
            // 
            // PostPic
            // 
            this.PostPic.Image = ((System.Drawing.Image)(resources.GetObject("PostPic.Image")));
            this.PostPic.ImageRotate = 0F;
            this.PostPic.Location = new System.Drawing.Point(41, 21);
            this.PostPic.Margin = new System.Windows.Forms.Padding(4);
            this.PostPic.Name = "PostPic";
            this.PostPic.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.PostPic.Size = new System.Drawing.Size(97, 102);
            this.PostPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PostPic.TabIndex = 11;
            this.PostPic.TabStop = false;
            // 
            // ucPost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.PostPrice);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.PostName);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.PostPic);
            this.Name = "ucPost";
            this.Size = new System.Drawing.Size(1061, 147);
            ((System.ComponentModel.ISupportInitialize)(this.PostPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Guna.UI.WinForms.GunaLabel PostPrice;
        public Guna.UI.WinForms.GunaLabel gunaLabel2;
        public Guna.UI.WinForms.GunaLabel PostName;
        public Guna.UI2.WinForms.Guna2Button guna2Button1;
        public Guna.UI2.WinForms.Guna2CirclePictureBox PostPic;
    }
}
