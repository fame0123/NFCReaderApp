namespace WindowsFormsApplication1
{
    partial class form_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_login));
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btn_openfb = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.txt_uname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btn_login = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_exit = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCheckbox1 = new Bunifu.Framework.UI.BunifuCheckbox();
            this.label3 = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_exit)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Navy;
            this.linkLabel1.Location = new System.Drawing.Point(86, 325);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(132, 15);
            this.linkLabel1.TabIndex = 11;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "www.Fame.systems";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btn_openfb
            // 
            this.btn_openfb.Activecolor = System.Drawing.Color.Transparent;
            this.btn_openfb.BackColor = System.Drawing.Color.Transparent;
            this.btn_openfb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_openfb.BorderRadius = 0;
            this.btn_openfb.ButtonText = "Message Us on Facebook";
            this.btn_openfb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_openfb.DisabledColor = System.Drawing.Color.Gray;
            this.btn_openfb.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_openfb.Iconimage = global::WindowsFormsApplication1.Properties.Resources.fbIcon;
            this.btn_openfb.Iconimage_right = null;
            this.btn_openfb.Iconimage_right_Selected = null;
            this.btn_openfb.Iconimage_Selected = null;
            this.btn_openfb.IconMarginLeft = 0;
            this.btn_openfb.IconMarginRight = 0;
            this.btn_openfb.IconRightVisible = true;
            this.btn_openfb.IconRightZoom = 0D;
            this.btn_openfb.IconVisible = true;
            this.btn_openfb.IconZoom = 90D;
            this.btn_openfb.IsTab = false;
            this.btn_openfb.Location = new System.Drawing.Point(49, 300);
            this.btn_openfb.Name = "btn_openfb";
            this.btn_openfb.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_openfb.OnHovercolor = System.Drawing.Color.Transparent;
            this.btn_openfb.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_openfb.selected = false;
            this.btn_openfb.Size = new System.Drawing.Size(45, 43);
            this.btn_openfb.TabIndex = 10;
            this.btn_openfb.Text = "Message Us on Facebook";
            this.btn_openfb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_openfb.Textcolor = System.Drawing.Color.White;
            this.btn_openfb.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_openfb.Click += new System.EventHandler(this.btn_openfb_Click);
            // 
            // txt_pass
            // 
            this.txt_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pass.Location = new System.Drawing.Point(60, 182);
            this.txt_pass.Multiline = true;
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(235, 31);
            this.txt_pass.TabIndex = 4;
            this.txt_pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_pass.Enter += new System.EventHandler(this.txt_pass_Enter);
            this.txt_pass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_pass_KeyDown);
            this.txt_pass.Leave += new System.EventHandler(this.txt_pass_Leave);
            // 
            // txt_uname
            // 
            this.txt_uname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_uname.Location = new System.Drawing.Point(60, 128);
            this.txt_uname.Multiline = true;
            this.txt_uname.Name = "txt_uname";
            this.txt_uname.Size = new System.Drawing.Size(235, 31);
            this.txt_uname.TabIndex = 3;
            this.txt_uname.Text = "admin";
            this.txt_uname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_uname.Enter += new System.EventHandler(this.txt_uname_Enter);
            this.txt_uname.Leave += new System.EventHandler(this.txt_uname_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label4.Location = new System.Drawing.Point(258, 365);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "Powered by: FAME";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.label4);
            this.bunifuGradientPanel1.Controls.Add(this.btn_login);
            this.bunifuGradientPanel1.Controls.Add(this.btn_exit);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCustomLabel1);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCheckbox1);
            this.bunifuGradientPanel1.Controls.Add(this.linkLabel1);
            this.bunifuGradientPanel1.Controls.Add(this.btn_openfb);
            this.bunifuGradientPanel1.Controls.Add(this.label3);
            this.bunifuGradientPanel1.Controls.Add(this.txt_uname);
            this.bunifuGradientPanel1.Controls.Add(this.txt_pass);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.DarkKhaki;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.DarkKhaki;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(357, 386);
            this.bunifuGradientPanel1.TabIndex = 2;
            // 
            // btn_login
            // 
            this.btn_login.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_login.BorderRadius = 0;
            this.btn_login.ButtonText = "        Log In";
            this.btn_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_login.DisabledColor = System.Drawing.Color.Gray;
            this.btn_login.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_login.Iconimage = null;
            this.btn_login.Iconimage_right = null;
            this.btn_login.Iconimage_right_Selected = null;
            this.btn_login.Iconimage_Selected = null;
            this.btn_login.IconMarginLeft = 0;
            this.btn_login.IconMarginRight = 0;
            this.btn_login.IconRightVisible = true;
            this.btn_login.IconRightZoom = 0D;
            this.btn_login.IconVisible = true;
            this.btn_login.IconZoom = 90D;
            this.btn_login.IsTab = false;
            this.btn_login.Location = new System.Drawing.Point(209, 250);
            this.btn_login.Name = "btn_login";
            this.btn_login.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_login.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_login.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_login.selected = false;
            this.btn_login.Size = new System.Drawing.Size(86, 41);
            this.btn_login.TabIndex = 17;
            this.btn_login.Text = "        Log In";
            this.btn_login.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_login.Textcolor = System.Drawing.Color.White;
            this.btn_login.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click_1);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.Transparent;
            this.btn_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exit.Image = global::WindowsFormsApplication1.Properties.Resources.close_button_png_30225;
            this.btn_exit.ImageActive = null;
            this.btn_exit.Location = new System.Drawing.Point(319, 6);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(28, 34);
            this.btn_exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_exit.TabIndex = 15;
            this.btn_exit.TabStop = false;
            this.btn_exit.Zoom = 10;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click_1);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(90, 223);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(112, 17);
            this.bunifuCustomLabel1.TabIndex = 14;
            this.bunifuCustomLabel1.Text = "Remember me?";
            // 
            // bunifuCheckbox1
            // 
            this.bunifuCheckbox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.bunifuCheckbox1.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.bunifuCheckbox1.Checked = true;
            this.bunifuCheckbox1.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.bunifuCheckbox1.ForeColor = System.Drawing.Color.White;
            this.bunifuCheckbox1.Location = new System.Drawing.Point(65, 222);
            this.bunifuCheckbox1.Name = "bunifuCheckbox1";
            this.bunifuCheckbox1.Size = new System.Drawing.Size(20, 20);
            this.bunifuCheckbox1.TabIndex = 12;
            this.bunifuCheckbox1.Tag = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Mistral", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(120, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 57);
            this.label3.TabIndex = 6;
            this.label3.Text = "Log In";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.bunifuGradientPanel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // form_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(357, 386);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log In";
            this.Load += new System.EventHandler(this.form_login_Load);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_exit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.TextBox txt_uname;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuFlatButton btn_openfb;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCheckbox bunifuCheckbox1;
        private Bunifu.Framework.UI.BunifuImageButton btn_exit;
        private Bunifu.Framework.UI.BunifuFlatButton btn_login;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Label label3;
    }
}