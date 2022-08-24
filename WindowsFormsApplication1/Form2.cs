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
            lbl_LineNum.Text = MainForm.lineNumber.ToString();

            chkBox_saveData.Checked = MainForm.chkbox_saveDataIsChecked;

            #region Clear textbox
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
            #endregion


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

            if (str.Length != 19)
            {

                if (str.Length == 4)
                {
                    txt_boatid.Text = str[0];

                    var latLon = str[1].Split(' ');

                    txt_lat.Text = latLon[0];
                    txt_lng.Text = latLon[0];

                    txt_date.Text = str[2].TimeStampConverter(); //TimeStampConfiguration  TimeStampConverter
                    txt_fishid.Text = str[3];
                }

                if (str.Length == 8)
                {
                    txt_boatid.Text = str[0];
                    txt_fishid.Text = str[1];

                    var latLon = str[2].Split(' ');
                    txt_lat.Text = latLon[0];
                    txt_lng.Text = latLon[1];

                    txt_date.Text = str[3].TimeStampConverter(); //TimeStampConfiguration  TimeStampConverter
                    txt_boatCap.Text = str[4];
                    txt_boatName.Text = str[5];
                    txt_LicId.Text = str[6];
                    txt_locattion.Text = str[7];
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
                lbl_LineNum.Text = str[18];

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
                var fishRecord = new FishRecord();

                fishRecord.BoatId = txt_boatid.Text;
                fishRecord.CatchId = txt_fishid.Text;
                fishRecord.Latitude = txt_lat.Text;
                fishRecord.Longitude = txt_lng.Text;
                fishRecord.TimeStamp = txt_date.Text;
                fishRecord.Weight = txt_weit.Text;
                fishRecord.Certified = txt_size.Text;
                fishRecord.Captain = txt_boatCap.Text;
                fishRecord.BoatName = txt_boatName.Text;
                fishRecord.LicenseId = txt_LicId.Text;
                fishRecord.Location = txt_locattion.Text;
                fishRecord.Species = cbox_species.Text;
                fishRecord.IdNo = cbox_idnum.Text;
                fishRecord.DepartureTime = txt_departTime.Text;
                fishRecord.ArrivalTime = txt_arrivTime.Text;
                fishRecord.Supplier = txt_supplier.Text;
                fishRecord.TagId = txt_tagId.Text;
                fishRecord.Classification = txt_classification.Text;
                fishRecord.EnumeratorName = txt_enumerator.Text;
                fishRecord.LineNumber = Convert.ToInt32(lbl_LineNum.Text);

                global_var2 = fishRecord.BoatId + "&" +
                              fishRecord.CatchId + "&" +
                              fishRecord.Latitude + "&" +
                              fishRecord.Longitude + "&" +
                              fishRecord.TimeStamp + "&" +
                              fishRecord.Weight + "&" +
                              fishRecord.Species + "&" +
                              fishRecord.Certified + "&" +
                              fishRecord.Captain + "&" +
                              fishRecord.BoatName + "&" +
                              fishRecord.LicenseId + "&" +
                              fishRecord.Location + "&" +
                              fishRecord.IdNo + "&" +
                              fishRecord.DepartureTime + "&" +
                              fishRecord.ArrivalTime + "&" +
                              fishRecord.Supplier + "&" +
                              fishRecord.TagId + "&" +
                              fishRecord.Classification + "&" +
                              fishRecord.EnumeratorName + "&" +
                              fishRecord.LineNumber;

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
                    File.WriteAllText("EnumeratorName.txt", fishRecord.EnumeratorName);
                }

                if (chkBox_saveData.Checked)
                {
                    fishRecord.ExportToJsonFile("Discrete");
                    MainForm.chkbox_saveDataIsChecked = true;
                }
                else { MainForm.chkbox_saveDataIsChecked = false; }

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
            if (global_var3 == "save") //
            {
                MainForm.lineNumber -= 1;
            }
            global_var3 = "cancel";

            this.Close();
        }

        #region Not Use Method
        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void txt_date_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txt_boatid_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_fishid_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_lat_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_lng_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_date_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txt_weit_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txt_boatCap_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_boatName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_LicId_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void txt_locattion_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void txt_size_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbox_species_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void cbox_idnum_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txt_departTime_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_arrivTime_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void txt_supplier_TextChanged(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void txt_tagId_TextChanged(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void txt_classification_TextChanged(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void txt_enumerator_TextChanged(object sender, EventArgs e)
        {

        }

        private void chkBox_rememberEnumerator_CheckedChanged(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
