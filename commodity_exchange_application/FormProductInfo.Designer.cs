namespace commodity_exchange_application
{
    partial class FormProductInfo
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
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.ProductCTPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.BackColor = System.Drawing.Color.Black;
            this.guna2ControlBox1.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom;
            this.guna2ControlBox1.CustomIconSize = 15F;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.guna2ControlBox1.IconColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.guna2ControlBox1.Location = new System.Drawing.Point(1169, 10);
            this.guna2ControlBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(40, 34);
            this.guna2ControlBox1.TabIndex = 28;
            // 
            // ProductCTPanel
            // 
            this.ProductCTPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ProductCTPanel.Location = new System.Drawing.Point(0, 49);
            this.ProductCTPanel.Name = "ProductCTPanel";
            this.ProductCTPanel.Size = new System.Drawing.Size(1220, 705);
            this.ProductCTPanel.TabIndex = 31;
            // 
            // FormProductInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1220, 754);
            this.Controls.Add(this.ProductCTPanel);
            this.Controls.Add(this.guna2ControlBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormProductInfo";
            this.Load += new System.EventHandler(this.FormProductInfo_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.Windows.Forms.FlowLayoutPanel ProductCTPanel;
    }
}