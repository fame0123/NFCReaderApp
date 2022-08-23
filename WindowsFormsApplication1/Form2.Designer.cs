namespace WindowsFormsApplication1
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_boatid = new System.Windows.Forms.TextBox();
            this.txt_fishid = new System.Windows.Forms.TextBox();
            this.txt_lat = new System.Windows.Forms.TextBox();
            this.txt_lng = new System.Windows.Forms.TextBox();
            this.txt_date = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_weit = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_boatCap = new System.Windows.Forms.TextBox();
            this.txt_boatName = new System.Windows.Forms.TextBox();
            this.txt_LicId = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_locattion = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_size = new System.Windows.Forms.ComboBox();
            this.cbox_species = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cbox_idnum = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btn_save = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_cancel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txt_departTime = new System.Windows.Forms.TextBox();
            this.txt_arrivTime = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txt_supplier = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txt_tagId = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txt_classification = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txt_enumerator = new System.Windows.Forms.TextBox();
            this.chkBox_rememberEnumerator = new System.Windows.Forms.CheckBox();
            this.chkBox_saveData = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Boat ID :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Catch ID :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Latitude :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Longitude :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(281, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Date (Y-M-D):";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txt_boatid
            // 
            this.txt_boatid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_boatid.Location = new System.Drawing.Point(122, 37);
            this.txt_boatid.Multiline = true;
            this.txt_boatid.Name = "txt_boatid";
            this.txt_boatid.Size = new System.Drawing.Size(148, 30);
            this.txt_boatid.TabIndex = 1;
            this.txt_boatid.TabStop = false;
            this.txt_boatid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_boatid.TextChanged += new System.EventHandler(this.txt_boatid_TextChanged);
            // 
            // txt_fishid
            // 
            this.txt_fishid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fishid.Location = new System.Drawing.Point(122, 73);
            this.txt_fishid.Multiline = true;
            this.txt_fishid.Name = "txt_fishid";
            this.txt_fishid.Size = new System.Drawing.Size(148, 30);
            this.txt_fishid.TabIndex = 2;
            this.txt_fishid.TabStop = false;
            this.txt_fishid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_fishid.TextChanged += new System.EventHandler(this.txt_fishid_TextChanged);
            // 
            // txt_lat
            // 
            this.txt_lat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_lat.Location = new System.Drawing.Point(122, 111);
            this.txt_lat.Multiline = true;
            this.txt_lat.Name = "txt_lat";
            this.txt_lat.Size = new System.Drawing.Size(148, 30);
            this.txt_lat.TabIndex = 3;
            this.txt_lat.TabStop = false;
            this.txt_lat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_lat.TextChanged += new System.EventHandler(this.txt_lat_TextChanged);
            // 
            // txt_lng
            // 
            this.txt_lng.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_lng.Location = new System.Drawing.Point(122, 148);
            this.txt_lng.Multiline = true;
            this.txt_lng.Name = "txt_lng";
            this.txt_lng.Size = new System.Drawing.Size(148, 30);
            this.txt_lng.TabIndex = 4;
            this.txt_lng.TabStop = false;
            this.txt_lng.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_lng.TextChanged += new System.EventHandler(this.txt_lng_TextChanged);
            // 
            // txt_date
            // 
            this.txt_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_date.Location = new System.Drawing.Point(387, 185);
            this.txt_date.Multiline = true;
            this.txt_date.Name = "txt_date";
            this.txt_date.Size = new System.Drawing.Size(148, 30);
            this.txt_date.TabIndex = 13;
            this.txt_date.TabStop = false;
            this.txt_date.Tag = "";
            this.txt_date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_date.TextChanged += new System.EventHandler(this.txt_date_TextChanged);
            this.txt_date.MouseHover += new System.EventHandler(this.txt_date_MouseHover);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Weight KL:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 249);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "Fish Validity:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txt_weit
            // 
            this.txt_weit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_weit.Location = new System.Drawing.Point(123, 186);
            this.txt_weit.Multiline = true;
            this.txt_weit.Name = "txt_weit";
            this.txt_weit.Size = new System.Drawing.Size(148, 30);
            this.txt_weit.TabIndex = 5;
            this.txt_weit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_weit.TextChanged += new System.EventHandler(this.txt_weit_TextChanged);
            this.txt_weit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_weit_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(14)))), ((int)(((byte)(34)))));
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(7, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 25);
            this.label8.TabIndex = 8;
            this.label8.Text = "Fish Record";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txt_boatCap
            // 
            this.txt_boatCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_boatCap.ForeColor = System.Drawing.Color.DarkRed;
            this.txt_boatCap.Location = new System.Drawing.Point(296, 38);
            this.txt_boatCap.Multiline = true;
            this.txt_boatCap.Name = "txt_boatCap";
            this.txt_boatCap.Size = new System.Drawing.Size(240, 30);
            this.txt_boatCap.TabIndex = 9;
            this.txt_boatCap.Text = "None";
            this.txt_boatCap.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_boatCap.TextChanged += new System.EventHandler(this.txt_boatCap_TextChanged);
            // 
            // txt_boatName
            // 
            this.txt_boatName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_boatName.Location = new System.Drawing.Point(388, 76);
            this.txt_boatName.Multiline = true;
            this.txt_boatName.Name = "txt_boatName";
            this.txt_boatName.Size = new System.Drawing.Size(148, 30);
            this.txt_boatName.TabIndex = 10;
            this.txt_boatName.Text = "None";
            this.txt_boatName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_boatName.TextChanged += new System.EventHandler(this.txt_boatName_TextChanged);
            // 
            // txt_LicId
            // 
            this.txt_LicId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_LicId.Location = new System.Drawing.Point(388, 113);
            this.txt_LicId.Multiline = true;
            this.txt_LicId.Name = "txt_LicId";
            this.txt_LicId.Size = new System.Drawing.Size(148, 30);
            this.txt_LicId.TabIndex = 11;
            this.txt_LicId.Text = "None";
            this.txt_LicId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_LicId.TextChanged += new System.EventHandler(this.txt_LicId_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(364, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "Captain Name:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(293, 87);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 16);
            this.label10.TabIndex = 0;
            this.label10.Text = "Boat Name:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(297, 120);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 16);
            this.label11.TabIndex = 0;
            this.label11.Text = "License ID:";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // txt_locattion
            // 
            this.txt_locattion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_locattion.Location = new System.Drawing.Point(388, 149);
            this.txt_locattion.Multiline = true;
            this.txt_locattion.Name = "txt_locattion";
            this.txt_locattion.Size = new System.Drawing.Size(148, 30);
            this.txt_locattion.TabIndex = 12;
            this.txt_locattion.Text = "None";
            this.txt_locattion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_locattion.TextChanged += new System.EventHandler(this.txt_locattion_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(311, 157);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 16);
            this.label12.TabIndex = 0;
            this.label12.Text = "Location:";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // txt_size
            // 
            this.txt_size.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txt_size.FormattingEnabled = true;
            this.txt_size.Location = new System.Drawing.Point(123, 249);
            this.txt_size.Name = "txt_size";
            this.txt_size.Size = new System.Drawing.Size(147, 21);
            this.txt_size.TabIndex = 7;
            this.txt_size.SelectedIndexChanged += new System.EventHandler(this.txt_size_SelectedIndexChanged);
            // 
            // cbox_species
            // 
            this.cbox_species.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbox_species.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_species.FormattingEnabled = true;
            this.cbox_species.Items.AddRange(new object[] {
            "Yellow Fin Tuna (YFT)",
            "Big Eye Tuna (BET)",
            "Blue Marlin (BUM)",
            "Sword Fish (SWO)",
            "Sail Fish (SFA)",
            "Pacific Blue Fin Tuna (PBF)"});
            this.cbox_species.Location = new System.Drawing.Point(123, 222);
            this.cbox_species.Name = "cbox_species";
            this.cbox_species.Size = new System.Drawing.Size(147, 21);
            this.cbox_species.TabIndex = 6;
            this.cbox_species.SelectedIndexChanged += new System.EventHandler(this.cbox_species_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(33, 223);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 20);
            this.label13.TabIndex = 0;
            this.label13.Text = "Species:";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // cbox_idnum
            // 
            this.cbox_idnum.FormattingEnabled = true;
            this.cbox_idnum.Location = new System.Drawing.Point(123, 276);
            this.cbox_idnum.Name = "cbox_idnum";
            this.cbox_idnum.Size = new System.Drawing.Size(147, 21);
            this.cbox_idnum.TabIndex = 8;
            this.cbox_idnum.SelectedIndexChanged += new System.EventHandler(this.cbox_idnum_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(55, 276);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 18);
            this.label14.TabIndex = 0;
            this.label14.Text = "ID No:";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // btn_save
            // 
            this.btn_save.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_save.BorderRadius = 0;
            this.btn_save.ButtonText = "Done";
            this.btn_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save.DisabledColor = System.Drawing.Color.Gray;
            this.btn_save.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_save.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_save.Iconimage")));
            this.btn_save.Iconimage_right = null;
            this.btn_save.Iconimage_right_Selected = null;
            this.btn_save.Iconimage_Selected = null;
            this.btn_save.IconMarginLeft = 0;
            this.btn_save.IconMarginRight = 0;
            this.btn_save.IconRightVisible = true;
            this.btn_save.IconRightZoom = 0D;
            this.btn_save.IconVisible = true;
            this.btn_save.IconZoom = 90D;
            this.btn_save.IsTab = false;
            this.btn_save.Location = new System.Drawing.Point(689, 228);
            this.btn_save.Name = "btn_save";
            this.btn_save.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_save.OnHovercolor = System.Drawing.Color.DarkSeaGreen;
            this.btn_save.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_save.selected = false;
            this.btn_save.Size = new System.Drawing.Size(132, 72);
            this.btn_save.TabIndex = 21;
            this.btn_save.Text = "Done";
            this.btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_save.Textcolor = System.Drawing.Color.White;
            this.btn_save.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click_1);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cancel.BorderRadius = 0;
            this.btn_cancel.ButtonText = "Cancel";
            this.btn_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancel.DisabledColor = System.Drawing.Color.Gray;
            this.btn_cancel.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_cancel.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_cancel.Iconimage")));
            this.btn_cancel.Iconimage_right = null;
            this.btn_cancel.Iconimage_right_Selected = null;
            this.btn_cancel.Iconimage_Selected = null;
            this.btn_cancel.IconMarginLeft = 0;
            this.btn_cancel.IconMarginRight = 0;
            this.btn_cancel.IconRightVisible = true;
            this.btn_cancel.IconRightZoom = 0D;
            this.btn_cancel.IconVisible = true;
            this.btn_cancel.IconZoom = 90D;
            this.btn_cancel.IsTab = false;
            this.btn_cancel.Location = new System.Drawing.Point(550, 228);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_cancel.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_cancel.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_cancel.selected = false;
            this.btn_cancel.Size = new System.Drawing.Size(133, 71);
            this.btn_cancel.TabIndex = 22;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancel.Textcolor = System.Drawing.Color.White;
            this.btn_cancel.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click_1);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(14)))), ((int)(((byte)(34)))));
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(152, 32);
            this.bunifuCustomLabel1.TabIndex = 15;
            this.bunifuCustomLabel1.Click += new System.EventHandler(this.bunifuCustomLabel1_Click);
            // 
            // txt_departTime
            // 
            this.txt_departTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_departTime.Location = new System.Drawing.Point(669, 40);
            this.txt_departTime.Multiline = true;
            this.txt_departTime.Name = "txt_departTime";
            this.txt_departTime.Size = new System.Drawing.Size(148, 30);
            this.txt_departTime.TabIndex = 14;
            this.txt_departTime.TabStop = false;
            this.txt_departTime.Tag = "";
            this.txt_departTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_departTime.TextChanged += new System.EventHandler(this.txt_departTime_TextChanged);
            // 
            // txt_arrivTime
            // 
            this.txt_arrivTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_arrivTime.Location = new System.Drawing.Point(670, 76);
            this.txt_arrivTime.Multiline = true;
            this.txt_arrivTime.Name = "txt_arrivTime";
            this.txt_arrivTime.Size = new System.Drawing.Size(148, 30);
            this.txt_arrivTime.TabIndex = 15;
            this.txt_arrivTime.TabStop = false;
            this.txt_arrivTime.Tag = "";
            this.txt_arrivTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_arrivTime.TextChanged += new System.EventHandler(this.txt_arrivTime_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(547, 46);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(120, 16);
            this.label15.TabIndex = 18;
            this.label15.Text = "Departure Time:";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(571, 85);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(96, 16);
            this.label16.TabIndex = 19;
            this.label16.Text = "Arrival Time:";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(598, 122);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(70, 16);
            this.label17.TabIndex = 21;
            this.label17.Text = "Supplier:";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // txt_supplier
            // 
            this.txt_supplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_supplier.Location = new System.Drawing.Point(669, 113);
            this.txt_supplier.Multiline = true;
            this.txt_supplier.Name = "txt_supplier";
            this.txt_supplier.Size = new System.Drawing.Size(148, 30);
            this.txt_supplier.TabIndex = 16;
            this.txt_supplier.TabStop = false;
            this.txt_supplier.Tag = "";
            this.txt_supplier.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_supplier.TextChanged += new System.EventHandler(this.txt_supplier_TextChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(609, 158);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(59, 16);
            this.label18.TabIndex = 23;
            this.label18.Text = "Tag ID:";
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // txt_tagId
            // 
            this.txt_tagId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tagId.Location = new System.Drawing.Point(669, 149);
            this.txt_tagId.Multiline = true;
            this.txt_tagId.Name = "txt_tagId";
            this.txt_tagId.Size = new System.Drawing.Size(148, 30);
            this.txt_tagId.TabIndex = 17;
            this.txt_tagId.TabStop = false;
            this.txt_tagId.Tag = "";
            this.txt_tagId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_tagId.TextChanged += new System.EventHandler(this.txt_tagId_TextChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(563, 193);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(105, 16);
            this.label19.TabIndex = 25;
            this.label19.Text = "Classification:";
            this.label19.Click += new System.EventHandler(this.label19_Click);
            // 
            // txt_classification
            // 
            this.txt_classification.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_classification.Location = new System.Drawing.Point(669, 184);
            this.txt_classification.Multiline = true;
            this.txt_classification.Name = "txt_classification";
            this.txt_classification.Size = new System.Drawing.Size(148, 30);
            this.txt_classification.TabIndex = 18;
            this.txt_classification.TabStop = false;
            this.txt_classification.Tag = "";
            this.txt_classification.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_classification.TextChanged += new System.EventHandler(this.txt_classification_TextChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(303, 226);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(149, 16);
            this.label20.TabIndex = 27;
            this.label20.Text = "Name of Enumerator";
            this.label20.Click += new System.EventHandler(this.label20_Click);
            // 
            // txt_enumerator
            // 
            this.txt_enumerator.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_enumerator.Location = new System.Drawing.Point(299, 245);
            this.txt_enumerator.Multiline = true;
            this.txt_enumerator.Name = "txt_enumerator";
            this.txt_enumerator.Size = new System.Drawing.Size(236, 30);
            this.txt_enumerator.TabIndex = 19;
            this.txt_enumerator.TabStop = false;
            this.txt_enumerator.Tag = "";
            this.txt_enumerator.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_enumerator.TextChanged += new System.EventHandler(this.txt_enumerator_TextChanged);
            // 
            // chkBox_rememberEnumerator
            // 
            this.chkBox_rememberEnumerator.AutoSize = true;
            this.chkBox_rememberEnumerator.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBox_rememberEnumerator.Location = new System.Drawing.Point(302, 277);
            this.chkBox_rememberEnumerator.Name = "chkBox_rememberEnumerator";
            this.chkBox_rememberEnumerator.Size = new System.Drawing.Size(211, 19);
            this.chkBox_rememberEnumerator.TabIndex = 20;
            this.chkBox_rememberEnumerator.Text = "Remember this Enumerator?";
            this.chkBox_rememberEnumerator.UseVisualStyleBackColor = true;
            this.chkBox_rememberEnumerator.CheckedChanged += new System.EventHandler(this.chkBox_rememberEnumerator_CheckedChanged);
            // 
            // chkBox_saveData
            // 
            this.chkBox_saveData.AutoSize = true;
            this.chkBox_saveData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBox_saveData.Location = new System.Drawing.Point(728, 16);
            this.chkBox_saveData.Name = "chkBox_saveData";
            this.chkBox_saveData.Size = new System.Drawing.Size(89, 19);
            this.chkBox_saveData.TabIndex = 28;
            this.chkBox_saveData.Text = "Save data";
            this.chkBox_saveData.UseVisualStyleBackColor = true;
            this.chkBox_saveData.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(833, 308);
            this.Controls.Add(this.chkBox_saveData);
            this.Controls.Add(this.chkBox_rememberEnumerator);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.txt_enumerator);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txt_classification);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txt_tagId);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txt_supplier);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txt_arrivTime);
            this.Controls.Add(this.txt_departTime);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.cbox_idnum);
            this.Controls.Add(this.cbox_species);
            this.Controls.Add(this.txt_size);
            this.Controls.Add(this.txt_locattion);
            this.Controls.Add(this.txt_LicId);
            this.Controls.Add(this.txt_boatName);
            this.Controls.Add(this.txt_boatCap);
            this.Controls.Add(this.txt_weit);
            this.Controls.Add(this.txt_date);
            this.Controls.Add(this.txt_lng);
            this.Controls.Add(this.txt_lat);
            this.Controls.Add(this.txt_fishid);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_boatid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Form";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_boatid;
        private System.Windows.Forms.TextBox txt_fishid;
        private System.Windows.Forms.TextBox txt_lat;
        private System.Windows.Forms.TextBox txt_lng;
        private System.Windows.Forms.TextBox txt_date;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_weit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_boatCap;
        private System.Windows.Forms.TextBox txt_boatName;
        private System.Windows.Forms.TextBox txt_LicId;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_locattion;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox txt_size;
        private System.Windows.Forms.ComboBox cbox_species;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbox_idnum;
        private System.Windows.Forms.Label label14;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuFlatButton btn_cancel;
        private Bunifu.Framework.UI.BunifuFlatButton btn_save;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txt_classification;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txt_tagId;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txt_supplier;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt_arrivTime;
        private System.Windows.Forms.TextBox txt_departTime;
        private System.Windows.Forms.CheckBox chkBox_rememberEnumerator;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txt_enumerator;
        private System.Windows.Forms.CheckBox chkBox_saveData;
    }
}