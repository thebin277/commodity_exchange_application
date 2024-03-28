namespace commodity_exchange_application
{
    partial class FormDK_Ban
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
            this.components = new System.ComponentModel.Container();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.lblDK_Ban = new Guna.UI.WinForms.GunaLabel();
            this.gunaPanel2 = new Guna.UI.WinForms.GunaPanel();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.btnBrowse = new Guna.UI2.WinForms.Guna2Button();
            this.txtImage = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2TextBox9 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBox10 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBox7 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBox8 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBox6 = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtName = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.txtPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBox3 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaPanel1.SuspendLayout();
            this.gunaPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtImage)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaPanel1.Controls.Add(this.lblDK_Ban);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(995, 63);
            this.gunaPanel1.TabIndex = 0;
            // 
            // lblDK_Ban
            // 
            this.lblDK_Ban.AutoSize = true;
            this.lblDK_Ban.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDK_Ban.ForeColor = System.Drawing.Color.White;
            this.lblDK_Ban.Location = new System.Drawing.Point(28, 9);
            this.lblDK_Ban.Name = "lblDK_Ban";
            this.lblDK_Ban.Size = new System.Drawing.Size(117, 31);
            this.lblDK_Ban.TabIndex = 0;
            this.lblDK_Ban.Text = "Đăng bán";
            // 
            // gunaPanel2
            // 
            this.gunaPanel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.gunaPanel2.Controls.Add(this.btnBrowse);
            this.gunaPanel2.Controls.Add(this.txtImage);
            this.gunaPanel2.Controls.Add(this.guna2TextBox9);
            this.gunaPanel2.Controls.Add(this.guna2TextBox10);
            this.gunaPanel2.Controls.Add(this.guna2TextBox7);
            this.gunaPanel2.Controls.Add(this.guna2TextBox8);
            this.gunaPanel2.Controls.Add(this.guna2TextBox6);
            this.gunaPanel2.Controls.Add(this.txtName);
            this.gunaPanel2.Controls.Add(this.btnSave);
            this.gunaPanel2.Controls.Add(this.txtPrice);
            this.gunaPanel2.Controls.Add(this.guna2TextBox3);
            this.gunaPanel2.Controls.Add(this.guna2TextBox2);
            this.gunaPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaPanel2.Location = new System.Drawing.Point(0, 63);
            this.gunaPanel2.Name = "gunaPanel2";
            this.gunaPanel2.Size = new System.Drawing.Size(995, 500);
            this.gunaPanel2.TabIndex = 1;
            // 
            // btnBrowse
            // 
            this.btnBrowse.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBrowse.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBrowse.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBrowse.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBrowse.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBrowse.ForeColor = System.Drawing.Color.White;
            this.btnBrowse.Location = new System.Drawing.Point(682, 255);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(180, 45);
            this.btnBrowse.TabIndex = 25;
            this.btnBrowse.Text = "Thêm Ảnh";
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtImage
            // 
            this.txtImage.BackColor = System.Drawing.Color.White;
            this.txtImage.Image = global::commodity_exchange_application.Properties.Resources.icon_add;
            this.txtImage.ImageRotate = 0F;
            this.txtImage.Location = new System.Drawing.Point(660, 40);
            this.txtImage.Name = "txtImage";
            this.txtImage.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.txtImage.Size = new System.Drawing.Size(231, 207);
            this.txtImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.txtImage.TabIndex = 24;
            this.txtImage.TabStop = false;
            // 
            // guna2TextBox9
            // 
            this.guna2TextBox9.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox9.DefaultText = "";
            this.guna2TextBox9.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox9.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox9.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox9.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox9.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox9.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox9.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox9.Location = new System.Drawing.Point(62, 255);
            this.guna2TextBox9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2TextBox9.Name = "guna2TextBox9";
            this.guna2TextBox9.PasswordChar = '\0';
            this.guna2TextBox9.PlaceholderText = "Địa chỉ*";
            this.guna2TextBox9.SelectedText = "";
            this.guna2TextBox9.Size = new System.Drawing.Size(229, 48);
            this.guna2TextBox9.TabIndex = 23;
            // 
            // guna2TextBox10
            // 
            this.guna2TextBox10.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox10.DefaultText = "";
            this.guna2TextBox10.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox10.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox10.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox10.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox10.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox10.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox10.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox10.Location = new System.Drawing.Point(62, 199);
            this.guna2TextBox10.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2TextBox10.Name = "guna2TextBox10";
            this.guna2TextBox10.PasswordChar = '\0';
            this.guna2TextBox10.PlaceholderText = "Giá gốc*";
            this.guna2TextBox10.SelectedText = "";
            this.guna2TextBox10.Size = new System.Drawing.Size(229, 48);
            this.guna2TextBox10.TabIndex = 22;
            // 
            // guna2TextBox7
            // 
            this.guna2TextBox7.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox7.DefaultText = "";
            this.guna2TextBox7.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox7.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox7.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox7.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox7.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox7.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox7.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox7.Location = new System.Drawing.Point(331, 199);
            this.guna2TextBox7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2TextBox7.Name = "guna2TextBox7";
            this.guna2TextBox7.PasswordChar = '\0';
            this.guna2TextBox7.PlaceholderText = "Mô tả hư hại*";
            this.guna2TextBox7.SelectedText = "";
            this.guna2TextBox7.Size = new System.Drawing.Size(254, 48);
            this.guna2TextBox7.TabIndex = 21;
            // 
            // guna2TextBox8
            // 
            this.guna2TextBox8.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox8.DefaultText = "";
            this.guna2TextBox8.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox8.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox8.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox8.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox8.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox8.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox8.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox8.Location = new System.Drawing.Point(331, 87);
            this.guna2TextBox8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2TextBox8.Name = "guna2TextBox8";
            this.guna2TextBox8.PasswordChar = '\0';
            this.guna2TextBox8.PlaceholderText = "Loại mặt hàng*";
            this.guna2TextBox8.SelectedText = "";
            this.guna2TextBox8.Size = new System.Drawing.Size(254, 48);
            this.guna2TextBox8.TabIndex = 20;
            // 
            // guna2TextBox6
            // 
            this.guna2TextBox6.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox6.DefaultText = "";
            this.guna2TextBox6.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox6.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox6.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox6.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox6.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox6.Location = new System.Drawing.Point(331, 255);
            this.guna2TextBox6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2TextBox6.Name = "guna2TextBox6";
            this.guna2TextBox6.PasswordChar = '\0';
            this.guna2TextBox6.PlaceholderText = "Ngày mua*";
            this.guna2TextBox6.SelectedText = "";
            this.guna2TextBox6.Size = new System.Drawing.Size(254, 48);
            this.guna2TextBox6.TabIndex = 19;
            // 
            // txtName
            // 
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.DefaultText = "";
            this.txtName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.Location = new System.Drawing.Point(62, 87);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.PlaceholderText = "Tên mặt hàng*";
            this.txtName.SelectedText = "";
            this.txtName.Size = new System.Drawing.Size(229, 48);
            this.txtName.TabIndex = 18;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSave.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(312, 389);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(180, 45);
            this.btnSave.TabIndex = 14;
            this.btnSave.TabStop = false;
            this.btnSave.Text = "Đăng bán";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrice.DefaultText = "";
            this.txtPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrice.Location = new System.Drawing.Point(62, 143);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PasswordChar = '\0';
            this.txtPrice.PlaceholderText = "Giá bán*";
            this.txtPrice.SelectedText = "";
            this.txtPrice.Size = new System.Drawing.Size(229, 48);
            this.txtPrice.TabIndex = 17;
            // 
            // guna2TextBox3
            // 
            this.guna2TextBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox3.DefaultText = "";
            this.guna2TextBox3.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox3.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox3.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox3.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox3.Location = new System.Drawing.Point(62, 311);
            this.guna2TextBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2TextBox3.Name = "guna2TextBox3";
            this.guna2TextBox3.PasswordChar = '\0';
            this.guna2TextBox3.PlaceholderText = "Mô tả chi tiết*";
            this.guna2TextBox3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.guna2TextBox3.SelectedText = "";
            this.guna2TextBox3.Size = new System.Drawing.Size(737, 71);
            this.guna2TextBox3.TabIndex = 16;
            // 
            // guna2TextBox2
            // 
            this.guna2TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox2.DefaultText = "";
            this.guna2TextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox2.Location = new System.Drawing.Point(331, 143);
            this.guna2TextBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2TextBox2.Name = "guna2TextBox2";
            this.guna2TextBox2.PasswordChar = '\0';
            this.guna2TextBox2.PlaceholderText = "Tình trạng mặt hàng*";
            this.guna2TextBox2.SelectedText = "";
            this.guna2TextBox2.Size = new System.Drawing.Size(254, 48);
            this.guna2TextBox2.TabIndex = 15;
            // 
            // FormDK_Ban
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 563);
            this.Controls.Add(this.gunaPanel2);
            this.Controls.Add(this.gunaPanel1);
            this.Name = "FormDK_Ban";
            this.Text = "FormDK_Ban";
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            this.gunaPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaLabel lblDK_Ban;
        private Guna.UI.WinForms.GunaPanel gunaPanel2;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2Button btnBrowse;
        private Guna.UI2.WinForms.Guna2CirclePictureBox txtImage;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox9;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox10;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox7;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox8;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox6;
        private Guna.UI2.WinForms.Guna2TextBox txtName;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2TextBox txtPrice;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox3;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox2;
    }
}