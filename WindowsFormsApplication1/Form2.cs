using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {

        public static string global_var2 = "";
        public static string global_var3 = "";

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //txt_boatid.Clear();
            //txt_arrivTime.Clear();
            //txt_boatCap.Clear();
            //txt_boatName.Clear();
            //txt_classification.Clear();
            //txt_departTime.Clear();
            //txt_fishid.Clear();
            //txt_lat.Clear();
            //txt_LicId.Clear();
            //txt_lng.Clear();
            //txt_locattion.Clear();
            //txt_supplier.Clear();
            //txt_tagId.Clear();
            //txt_weit.Clear();



            txt_date.Text = DateTime.Now.ToString("yyyy'-'MM'-'dd");
            // Read a text file line by line.  
            string[] lines = File.ReadAllLines("IdNumberList.txt");

            txt_enumerator.Text = File.ReadAllText("EnumeratorName.txt");

            foreach (string line in lines)
            {
                cbox_idnum.Items.Add(line);
            }

            txt_size.Items.Add("Not Certified");
            txt_size.Items.Add("Certified");
            txt_size.SelectedIndex = 0;
            cbox_species.SelectedIndex = 0;
            //MessageBox.Show(MainForm.global_var1);

            string[] str = MainForm.global_var1.Split('&');

            if (str.Length != 18)
            {

                if (str.Length == 4)
                {
                    txt_boatid.Text = str[0];

                    var latLon = str[1].Split(' ');

                    txt_lat.Text = latLon[0];
                    txt_lng.Text = latLon[1];

                    txt_date.Text = str[2].TimeStampConverter(); //TimeStampConfiguration  TimeStampConverter
                    txt_fishid.Text = str[3];
                }


                return; 
            }
            txt_boatid.Text = str[0];
            txt_fishid.Text = str[1];
            string[] loc = str[2].Split(' ');
            txt_lat.Text = loc[0];
            txt_lng.Text = loc[1];
            txt_date.Text = str[3];  //19413213414
            txt_boatCap.Text = str[4]; //-----------------------
            txt_boatName.Text = str[5];
            txt_LicId.Text = str[6];
            txt_locattion.Text = str[7];


            if (global_var3 == "edit")
            {

                txt_weit.Text = str[4];
                txt_size.Text = str[5];
                cbox_species.Text = str[5];
                txt_size.Text = str[6];
                txt_boatCap.Text = str[7];
                txt_boatName.Text = str[8];
                txt_LicId.Text = str[9];
                txt_locattion.Text = str[10];
                cbox_idnum.Text = str[11];
                txt_departTime.Text = str[12];
                txt_arrivTime.Text = str[13];
                txt_supplier.Text = str[14];
                txt_tagId.Text = str[15];
                txt_classification.Text = str[16];
                txt_enumerator.Text = str[17];

            }
            
        }

        private void txt_weit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) return;
            if (Char.IsControl(e.KeyChar)) return;
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.Contains('.') == false)) return;
            if ((e.KeyChar == '.') && ((sender as TextBox).SelectionLength == (sender as TextBox).TextLength)) return;
            e.Handled = true;
        }

        private void txt_size_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) return;
            if (Char.IsControl(e.KeyChar)) return;
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.Contains('.') == false)) return;
            if ((e.KeyChar == '.') && ((sender as TextBox).SelectionLength == (sender as TextBox).TextLength)) return;
            e.Handled = true;
        }
        
        private void btn_save_Click_1(object sender, EventArgs e)
        {
            if (txt_size.Text.Trim() != "" && txt_weit.Text.Trim() != "" && cbox_idnum.Text.Trim() != "")
            {
                string boatid = txt_boatid.Text;
                string fishid = txt_fishid.Text;
                string lat = txt_lat.Text;
                string lng = txt_lng.Text;
                string date = txt_date.Text;
                string weit = txt_weit.Text;
                string cert = txt_size.Text;
                string cap = txt_boatCap.Text;
                string botname = txt_boatName.Text;
                string license = txt_LicId.Text;
                string locationz = txt_locattion.Text;
                string species = cbox_species.Text;
                string idno = cbox_idnum.Text;
                string departureTime = txt_departTime.Text;
                string arrivalTime = txt_arrivTime.Text;
                string supplier = txt_supplier.Text;
                string tagId = txt_tagId.Text;
                string classification = txt_classification.Text;
                string enumeratorName = txt_enumerator.Text;

                global_var2 = boatid + "&" + 
                              fishid + "&" + 
                              lat + "&" +
                              lng + "&" +
                              date + "&" +
                              weit + "&" +
                              species + "&" +
                              cert + "&" +
                              cap + "&" +
                              botname + "&" +
                              license + "&" +
                              locationz + "&" +
                              idno + "&" + 
                              departureTime + "&" + 
                              arrivalTime + "&" +
                              supplier + "&" +
                              tagId + "&" +
                              classification + "&" +
                              enumeratorName; ;

                if (global_var3 == "edit") //
                {
                    global_var3 = "edit";
                }
                else
                {
                    global_var3 = "save";
                }

                int chkz = 0;

                for (int i = 0; i < cbox_idnum.Items.Count; i++)
                {
                    if (cbox_idnum.Text.Trim() == cbox_idnum.GetItemText(cbox_idnum.Items[i]))
                    {
                        chkz = 1;
                    }
                }
                if (chkz == 0)
                {
                    string notepad_append = cbox_idnum.Text;
                    StreamWriter log = File.AppendText("IdNumberList.txt");
                    log.WriteLine(notepad_append);
                    log.Close();
                }

                chkz = 0;

                if (chkBox_rememberEnumerator.Checked)
                {
                    File.WriteAllText("EnumeratorName.txt", enumeratorName);
                }

                this.Close();
            }
            else
            {

                if (txt_weit.Text.Trim() == "")
                {
                    txt_weit.BackColor = Color.Yellow;
                }
                else
                {
                    txt_weit.BackColor = Color.White;
                }
                if (cbox_idnum.Text.Trim() == "")
                {
                    cbox_idnum.BackColor = Color.Yellow;
                }
                else
                {
                    cbox_idnum.BackColor = Color.White;
                }
                MessageBox.Show("Please fill-up the Yellow Box. Required !!");
             
            }
        }

        private void btn_cancel_Click_1(object sender, EventArgs e)
        {
            global_var3 = "cancel";
            this.Close();
        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void txt_date_MouseHover(object sender, EventArgs e)
        {
            
        }
    }
}
