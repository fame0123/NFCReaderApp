using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class History : Form
    {
        public History()
        {
            InitializeComponent();
        }

        private void History_Load(object sender, EventArgs e)
        {
            string[] files = Directory.GetFiles("data_Record");
            string[] dirs = Directory.GetDirectories("data_Record");
            int lent = 0;
            foreach (string file in files)
            {
                cbox_list.Items.Add(Path.GetFileName(file));
                lent++;
            }
            cbox_list.SelectedIndex = lent - 1;

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
           

        }

       

        private void btn_confirm_Click_1(object sender, EventArgs e)
        {
            if (cbox_list.Text.Trim() != "")
            {
                if (cbox_list.Text.Trim().Length == 14)
                {
                    MainForm.recordFileName = cbox_list.Text.Trim() + "&confirm";
                    this.Close();
                }
                else { MessageBox.Show("File Name Not Supported..."); }
            }
            else { MessageBox.Show("Please Choose a File Name.!"); }
        }

        private void btn_cancel_Click_1(object sender, EventArgs e)
        {
            MainForm.recordFileName = "cancel&cancel";
            this.Close();
        }
    }
}
