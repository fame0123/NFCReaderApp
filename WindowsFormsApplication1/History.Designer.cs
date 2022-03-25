namespace WindowsFormsApplication1
{
    partial class History
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(History));
            this.cbox_list = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_cancel = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_confirm = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbox_list
            // 
            this.cbox_list.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbox_list.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cbox_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_list.FormattingEnabled = true;
            this.cbox_list.IntegralHeight = false;
            this.cbox_list.Location = new System.Drawing.Point(29, 34);
            this.cbox_list.Name = "cbox_list";
            this.cbox_list.Size = new System.Drawing.Size(139, 148);
            this.cbox_list.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "dd-mm-yyyy";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(40, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "All Data Recorded";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btn_cancel);
            this.panel1.Controls.Add(this.btn_confirm);
            this.panel1.Controls.Add(this.cbox_list);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(195, 233);
            this.panel1.TabIndex = 4;
            // 
            // btn_cancel
            // 
            this.btn_cancel.ActiveBorderThickness = 1;
            this.btn_cancel.ActiveCornerRadius = 20;
            this.btn_cancel.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btn_cancel.ActiveForecolor = System.Drawing.Color.White;
            this.btn_cancel.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btn_cancel.BackColor = System.Drawing.Color.White;
            this.btn_cancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_cancel.BackgroundImage")));
            this.btn_cancel.ButtonText = "Cancel";
            this.btn_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_cancel.IdleBorderThickness = 1;
            this.btn_cancel.IdleCornerRadius = 20;
            this.btn_cancel.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_cancel.IdleForecolor = System.Drawing.Color.White;
            this.btn_cancel.IdleLineColor = System.Drawing.Color.Black;
            this.btn_cancel.Location = new System.Drawing.Point(29, 189);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(65, 40);
            this.btn_cancel.TabIndex = 5;
            this.btn_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click_1);
            // 
            // btn_confirm
            // 
            this.btn_confirm.ActiveBorderThickness = 1;
            this.btn_confirm.ActiveCornerRadius = 20;
            this.btn_confirm.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btn_confirm.ActiveForecolor = System.Drawing.Color.White;
            this.btn_confirm.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btn_confirm.BackColor = System.Drawing.Color.White;
            this.btn_confirm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_confirm.BackgroundImage")));
            this.btn_confirm.ButtonText = "Done";
            this.btn_confirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_confirm.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_confirm.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_confirm.IdleBorderThickness = 1;
            this.btn_confirm.IdleCornerRadius = 20;
            this.btn_confirm.IdleFillColor = System.Drawing.Color.SeaGreen;
            this.btn_confirm.IdleForecolor = System.Drawing.Color.White;
            this.btn_confirm.IdleLineColor = System.Drawing.Color.Black;
            this.btn_confirm.Location = new System.Drawing.Point(100, 189);
            this.btn_confirm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(68, 40);
            this.btn_confirm.TabIndex = 4;
            this.btn_confirm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click_1);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(222, 276);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "History";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Current and Pass Record";
            this.Load += new System.EventHandler(this.History_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbox_list;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_confirm;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_cancel;
    }
}