using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Drawing.Printing;
using Newtonsoft.Json;


namespace WindowsFormsApplication1
{
    public partial class MainForm : Form
    {
        public static string global_var1 = "";

        public static string global_edit = "";

        public static string recordFileName = "";

        SerialPort sp;
        string msg = "";
        public MainForm()
        {
            InitializeComponent();
        }
        Thread readThread;

        
        public void Read() // --------------> Read Serial Port
        {

            while (true)
            {
                try
                {
                    msg = sp.ReadLine();
                    //bool msg2 = msg;
                    if (msg.Trim() != string.Empty)
                    {
                        //Thread.Sleep(1000);
                        //MessageBox.Show(msg);
                        //textBox1.Text = msg;
                        AppendTextBox(msg); // Throw the Data to the function

                    }
                }
                catch { }

            }

        }
        //-------------------------------------
        int i = 0;
        string data_holder = "";
        string spliter = "";
        string temporary_data1 = "", temporary_data2 = "";

        public Color Green { get; private set; }

        public void AppendTextBox(string value)  // Receive Data (msg)
        {
            if (InvokeRequired) // if Data is Null 
            {
                this.Invoke(new Action<string>(AppendTextBox), new object[] { value });
                return;
            }
            textBox1.Text = value; // value = msg

            if (value == "Scan a NFC tag") // 
            {
                richTextBox1.AppendText("\n" + value + "\n");
                data_holder = "";
                spliter = "";
                i = 0;
            }
            else
            {
                // ------------> if Records is 3 bytes means no Data Write in NFC Card
                richTextBox1.AppendText(value);
                if (value.Trim() == "Record is 3 bytes")
                {
                    MessageBox.Show("No Data Found.");
                }
            }


            int n = value.IndexOf("Payload 02 65"); // Find the word (Payload 02 65) Every Data that write in NFC Card are Start in (Payload 02 65 + FishID)
            if (n != -1)
            {
                if (value.Trim() != string.Empty || (value.Trim() != string.Empty && i == 0))
                {
                    string[] str1 = value.Split(new string[] { "en" }, StringSplitOptions.None);

                    //richTextBox1.AppendText(str1[1]);
                    if (i < 4)
                    {
                        data_holder = data_holder + spliter + str1[1];
                    }
                    spliter = "&";
                    i++;
                }
            }
            try
            {
                if (i == 4)
                {
                    i = 0;
                    global_var1 = data_holder;
                    temporary_data1 = data_holder;
                    data_holder = "";
                    spliter = "";
                   
                    string[] val = temporary_data1.Split('&');
                    string valz = ValidateData(val[1].ToString());
                    if (valz == "0")
                    {
                        temporary_data2 = temporary_data1;
                        
                        Form2 f2 = new Form2();
                        f2.ShowDialog();
                        
                    }
                    else { MessageBox.Show("This Card is already Scanned..!"); }

                    if (Form2.global_var3 == "save")//---------------------------------------------
                    {


                        string[] str_data = Form2.global_var2.Split('&');
                      
                        int addrow;
                        addrow = dataGridView1.Rows.Add();
                        for (int x = 0; x < str_data.Length; x++)
                        {

                            string form2_data = str_data[x];

                            #region convert TimeStamp
                            //    if (x == 3)
                            //    {
                            //        //str_data[x]; //=========================================================================================================
                            //        char[] stamp = str_data[x].Trim().ToCharArray();
                            //        //MessageBox.Show(stamp.Length.ToString());

                            //        string yr = "";
                            //        string mont = "";
                            //        string day = "";
                            //        string hr = "";
                            //        string min = "";


                            //        if (stamp.Length == 10)
                            //        {
                            //            yr = "20" + stamp[0] + stamp[1];
                            //            mont = stamp[2].ToString();
                            //            day = stamp[3] + stamp[4].ToString();
                            //            hr = stamp[5] + stamp[6].ToString();
                            //            min = stamp[7] + stamp[8].ToString();



                            //        }
                            //        else if (stamp.Length == 11)
                            //        {
                            //            yr = "20" + stamp[0] + stamp[1];
                            //            mont = stamp[2].ToString();
                            //            day = stamp[3] + stamp[4].ToString();
                            //            hr = stamp[5] + stamp[6].ToString();
                            //            min = stamp[7] + stamp[8].ToString();



                            //        }
                            //        else if (stamp.Length == 12)
                            //        {
                            //            yr = "20" + stamp[0] + stamp[1];
                            //            mont = stamp[2] + stamp[3].ToString();
                            //            day = stamp[4] + stamp[5].ToString();
                            //            hr = stamp[6] + stamp[7].ToString();
                            //            min = stamp[8] + stamp[9].ToString();

                            //        }
                            //        else
                            //        {

                            //            yr = "20" + stamp[0] + stamp[1];
                            //            mont = stamp[2].ToString();
                            //            day = stamp[3] + stamp[4].ToString();
                            //            hr = stamp[5] + stamp[6].ToString();
                            //            min = stamp[7] + stamp[8].ToString();


                            //        }
                            //        int hours = Convert.ToInt32(hr);
                            //        if (hours > 23)
                            //        {
                            //            int val1 = hours / 23;
                            //            int val2 = val1 * 23;
                            //            int val3 = hours - val2;
                            //            hr = val3.ToString();
                            //        }
                            //        int minut = Convert.ToInt32(min);
                            //        if (minut > 59)
                            //        {
                            //            int val1 = minut / 23;
                            //            int val2 = val1 * 23;
                            //            int val3 = minut - val2;
                            //            min = val3.ToString();
                            //        }

                            //        form2_data = yr + "-" + mont + "-" + day + " " + hr + ":" + min;
                            //    }
                            #endregion

                            dataGridView1.Rows[addrow].Cells[x].Value = form2_data;

                        }

                        Form2.global_var3 = "";
                        
                    }
                    dataGridView1.ClearSelection();
                    
                }
                //else { MessageBox.Show("NFC Card Have Less or More Than Expected Data. \n Please Try Another Card"); i = 0; }
                
            }
            catch { MessageBox.Show("NFC Card Have Less or More Than Expected Data. \n Please  Try Another Card...!"); i = 0; }
        }
       

        private void MainForm_Load(object sender, EventArgs e)// -========================= Main Form
        {
            SearchComPort();
            //MessageBox.Show(dataGridView1.Rows.Count.ToString()); global_var1
            this.dataGridView1.RowHeadersVisible = false;
            webBrowser1.Navigate("https://nutrindofresfoodinternasional.business.site");
        }

        private void bunifuDropdown1_onItemSelected(object sender, EventArgs e)
        {

        }

        private void btn_close_Click(object sender, EventArgs e) // Button  to Close/Stop Serial Reading
        {
            try
            {
                sp.Close();
                readThread.Abort();
            }
            catch { }
            
            form_login log = new form_login();
            log.Show();
            this.Close();
        }

        

        private void bunifuFlatButton3_Click(object sender, EventArgs e)  // Records Button
        {
            History hs = new History();
            hs.ShowDialog();
            string data_holder = "";
            string spliter;


            //================================================================================================ Read .Txt File and Convert to Json
            string[] _fileName = recordFileName.Split('&');
            if (_fileName[1] == "confirm")
            {
                btn_clear.Enabled = true;
                btn_edit.Enabled = true;
                btn_delete.Enabled = true;
                btn_upload.Enabled = true;
                spliter = "";
                string txtFile_Record = File.ReadAllText(@"data_Record\" + _fileName[0], Encoding.UTF8);
                string[] jsonSplit = txtFile_Record.Split('+');

                //-----------------------
                int addrow;

                for (int i = 0; i < jsonSplit.Length - 1; i++)
                {
                    spliter = "";
                    int x = 0;
                    string valz = "";
                    var dictionary = JsonConvert.DeserializeObject<System.Collections.IDictionary>(jsonSplit[i]);
                    //MessageBox.Show();
                    foreach (System.Collections.DictionaryEntry entry in dictionary)
                    {
                        if (entry.Key.ToString() == "CatchId")
                        {

                            valz = ValidateData(entry.Value.ToString());

                        }

                        data_holder = data_holder + spliter + entry.Value;
                        spliter = "%";

                    }

                    if (valz == "0")
                    {
                        //MessageBox.Show(data_holder);
                        string[] data_holder_split = data_holder.Split('%');

                        addrow = dataGridView1.Rows.Add();
                        //MessageBox.Show(addrow.ToString());
                        //for (int j = 0; j < data_holder_split.Length; j++)
                        //{
                        dataGridView1.Rows[addrow].Cells[0].Value = data_holder_split[0];
                        dataGridView1.Rows[addrow].Cells[1].Value = data_holder_split[1];
                        dataGridView1.Rows[addrow].Cells[2].Value = data_holder_split[2];
                        dataGridView1.Rows[addrow].Cells[3].Value = data_holder_split[3];
                        dataGridView1.Rows[addrow].Cells[4].Value = data_holder_split[4];
                        dataGridView1.Rows[addrow].Cells[5].Value = data_holder_split[5];
                        dataGridView1.Rows[addrow].Cells[6].Value = data_holder_split[6];
                        dataGridView1.Rows[addrow].Cells[7].Value = data_holder_split[7];
                        dataGridView1.Rows[addrow].Cells[8].Value = data_holder_split[8];
                        dataGridView1.Rows[addrow].Cells[9].Value = data_holder_split[9];
                        dataGridView1.Rows[addrow].Cells[10].Value = data_holder_split[10];
                        dataGridView1.Rows[addrow].Cells[11].Value = data_holder_split[11];
                        dataGridView1.Rows[addrow].Cells[12].Value = data_holder_split[12];
                        dataGridView1.Rows[addrow].Cells[13].Value = data_holder_split[13];
                        dataGridView1.Rows[addrow].Cells[14].Value = data_holder_split[14];
                        dataGridView1.Rows[addrow].Cells[15].Value = data_holder_split[15];
                        dataGridView1.Rows[addrow].Cells[16].Value = data_holder_split[16];
                        dataGridView1.Rows[addrow].Cells[17].Value = data_holder_split[17];
                        dataGridView1.Rows[addrow].Cells[18].Value = data_holder_split[18];
                        //}
                    }
                    data_holder = "";


                }
            }
        }
        

        private void btn_scan_Click(object sender, EventArgs e)
        {
            
        }
        // ======================================================================================================== > FUNCTION 
        public string ValidateData(string val)  // Check if data is in datagridview
        {
            int cnt = 0;
            string catchID;
            foreach(DataGridViewRow row in dataGridView1.Rows)
            {

                try
                {
                    catchID = row.Cells[1].Value.ToString();
                    if (catchID.Trim() == val.Trim())
                    {
                        return "1";
                    }
                }
                catch { }

            }

            return "0";
        }

        private void SearchComPort() // Search Com Port
        {
           
            comboBox1.Clear();
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                comboBox1.AddItem(port);
                //comboBox1.Items.Add(port);
            }

            try
            {
                //comboBox1.SelectedIndex = 0;
                comboBox1.selectedIndex = 0;
                btn_scan.Enabled = true;
                btn_upload.Enabled = false;
                btn_clear.Enabled = true;
                btn_edit.Enabled = true;
                btn_delete.Enabled = true;
            }
            catch
            {
                //MessageBox.Show
                richTextBox1.AppendText("\nNo ComPort Available.!!!");

                btn_scan.Enabled = false;
                btn_upload.Enabled = false;
                btn_clear.Enabled = false;
                btn_edit.Enabled = false;
                btn_delete.Enabled = false;
            }

        }
        //===============================================================================================^^^^^

        private void btn_stop_Click(object sender, EventArgs e)
        {
            try
            {
                sp.Close();
                readThread.Abort();

                RchTextBox_colorChange("\n\nScan has been stopped.!\n\n", "pula");

                btn_stop.Visible = false;
                btn_scan.Visible = true;
                textBox1.Clear();
                //btn_scan.BackColor = Color.White;
                textBox1.BackColor = Color.White;
                btn_loadPort.Visible = true; // Reload Com port
                //btn_loadPort.BackColor = Color.DarkSlateGray;
                comboBox1.Enabled = true; // COM Port List
                //btn_stop. = false;
            }
            catch { }
        }

        private void btn_saveRecord_Click(object sender, EventArgs e) // ----> SAve Record
        {
            DateTime today = DateTime.Today;
            try
            {
                string Test_if_datagrid_have_data = dataGridView1.Rows[0].Cells[0].Value.ToString();
                //MessageBox.Show(Test_if_datagrid_have_data);
                int cnt = 0;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {

                    string BoatID = dataGridView1.Rows[cnt].Cells[0].Value.ToString();
                    string FishID = dataGridView1.Rows[cnt].Cells[1].Value.ToString();
                    string lat = dataGridView1.Rows[cnt].Cells[2].Value.ToString();
                    string lng = dataGridView1.Rows[cnt].Cells[3].Value.ToString();
                    string Petsa = dataGridView1.Rows[cnt].Cells[4].Value.ToString();
                    string Weight = dataGridView1.Rows[cnt].Cells[5].Value.ToString();
                    string species = dataGridView1.Rows[cnt].Cells[6].Value.ToString();
                    string cert = dataGridView1.Rows[cnt].Cells[7].Value.ToString();
                    string cap = dataGridView1.Rows[cnt].Cells[8].Value.ToString();
                    string botname = dataGridView1.Rows[cnt].Cells[9].Value.ToString();
                    string license = dataGridView1.Rows[cnt].Cells[10].Value.ToString();
                    string locate = dataGridView1.Rows[cnt].Cells[11].Value.ToString();
                    string idno = dataGridView1.Rows[cnt].Cells[12].Value.ToString();
                    string departureTime = dataGridView1.Rows[cnt].Cells[13].Value.ToString();
                    string arrivalTime = dataGridView1.Rows[cnt].Cells[14].Value.ToString();
                    string supplier = dataGridView1.Rows[cnt].Cells[15].Value.ToString();
                    string tagId = dataGridView1.Rows[cnt].Cells[16].Value.ToString();
                    string classification = dataGridView1.Rows[cnt].Cells[17].Value.ToString();
                    string enumeratorName = dataGridView1.Rows[cnt].Cells[18].Value.ToString();
                    //MessageBox.Show(cap+botname+license+locate);
                    string notepad_append = "{\"BoatId\":\"" + BoatID + "\"," +
                                            "\"CatchId\":\"" + FishID + "\"," +
                                            "\"Latitude\":\"" + lat + "\"," +
                                            "\"Longhitud\":\"" + lng + "\"," +
                                            "\"TimeStamp\":\"" + Petsa + "\"," +
                                            "\"Weight\":\"" + Weight + "\"," +
                                            "\"Species\":\"" + species + "\"," +
                                            "\"Certified\":\"" + cert + "\"," +
                                            "\"Captain\":\"" + cap + "\"," +
                                            "\"BoatName\":\"" + botname + "\"," +
                                            "\"LicenseId\":\"" + license + "\"," +
                                            "\"Location\":\"" + locate + "\"," +
                                            "\"IdNo\":\"" + idno + "\"," +
                                            "\"DepartureTime\":\"" + departureTime + "\"," +
                                            "\"ArrivalTime\":\"" + arrivalTime + "\"," +
                                            "\"Supplier\":\"" + supplier + "\"," +
                                            "\"TagId\":\"" + tagId + "\"," +
                                            "\"Classification\":\"" + classification + "\"," +
                                            "\"EnumeratorName\":\"" + enumeratorName + "\"" +
                                            "}+";



                    StreamWriter log1 = File.AppendText("data_Record/" + today.ToString("dd-MM-yyyy") + ".txt");
                    log1.WriteLine(notepad_append);
                    log1.Close();

                    cnt++;
                    //richTextBox1.AppendText(i.ToString());
                }
                MessageBox.Show("Record Successfully Save.\nFile Name: " + today.ToString("dd-MM-yyyy") + ".txt");
            }
            catch
            {
                MessageBox.Show("System Encountered Error. Make Sure That Record View List is Not Empty. Please Try Again...!");
            }
        }

        private void btn_edit_Click(object sender, EventArgs e) // ---------------> Edit Button
        {
            try
            {
                //string value = dataGridView1.Rows[dataGridView1.SelectedIndex].Cells[1].Text.ToString();
                int index = dataGridView1.SelectedRows[0].Index;
                //MessageBox.Show(index.ToString());
                //foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                //{
                //MessageBox.Show(row.ToString());
                string BoatID = dataGridView1.Rows[index].Cells[0].Value.ToString();
                string FishID = dataGridView1.Rows[index].Cells[1].Value.ToString();
                string lat = dataGridView1.Rows[index].Cells[2].Value.ToString();
                string lng = dataGridView1.Rows[index].Cells[3].Value.ToString();
                string Petsa = dataGridView1.Rows[index].Cells[4].Value.ToString();
                string Weight = dataGridView1.Rows[index].Cells[5].Value.ToString();
                string species = dataGridView1.Rows[index].Cells[6].Value.ToString();
                string cert = dataGridView1.Rows[index].Cells[7].Value.ToString();
                string cap = dataGridView1.Rows[index].Cells[8].Value.ToString();
                string botname = dataGridView1.Rows[index].Cells[9].Value.ToString();
                string license = dataGridView1.Rows[index].Cells[10].Value.ToString();
                string locate = dataGridView1.Rows[index].Cells[11].Value.ToString();
                string idno = dataGridView1.Rows[index].Cells[12].Value.ToString();
                string departureTime = dataGridView1.Rows[index].Cells[13].Value.ToString();
                string arrivalTime = dataGridView1.Rows[index].Cells[14].Value.ToString();
                string supplier = dataGridView1.Rows[index].Cells[15].Value.ToString();
                string tagId = dataGridView1.Rows[index].Cells[16].Value.ToString();
                string classification = dataGridView1.Rows[index].Cells[17].Value.ToString();
                string enumeratorName = dataGridView1.Rows[index].Cells[18].Value.ToString();

                global_var1 = BoatID + "&" +
                              FishID + "&" +
                              lat + " " + lng + "&" +
                              Petsa + "&" +
                              Weight + "&" +
                              species + "&" +
                              cert + "&" +
                              cap + "&" +
                              botname + "&" +
                              license + "&" +
                              locate + "&" +
                              idno + "&" +
                              departureTime + "&" +
                              arrivalTime + "&" +
                              supplier + "&" +
                              tagId + "&" +
                              classification + "&" +
                              enumeratorName;
                              
                spliter = "";
                Form2 f2 = new Form2();
                Form2.global_var3 = "edit";
                f2.ShowDialog();

                if (Form2.global_var3 == "edit")
                {
                    string[] str_data = Form2.global_var2.Split('&');
                    //dataGridView1.Rows.Clear();
                    dataGridView1.Rows[index].Cells[0].Value = str_data[0];
                    dataGridView1.Rows[index].Cells[1].Value = str_data[1];
                    dataGridView1.Rows[index].Cells[2].Value = str_data[2];
                    dataGridView1.Rows[index].Cells[3].Value = str_data[3];
                    dataGridView1.Rows[index].Cells[4].Value = str_data[4];
                    dataGridView1.Rows[index].Cells[5].Value = str_data[5];
                    dataGridView1.Rows[index].Cells[6].Value = str_data[6];
                    dataGridView1.Rows[index].Cells[7].Value = str_data[7];
                    dataGridView1.Rows[index].Cells[8].Value = str_data[8];
                    dataGridView1.Rows[index].Cells[9].Value = str_data[9];
                    dataGridView1.Rows[index].Cells[10].Value = str_data[10];
                    dataGridView1.Rows[index].Cells[11].Value = str_data[11];
                    dataGridView1.Rows[index].Cells[12].Value = str_data[12];
                    dataGridView1.Rows[index].Cells[13].Value = str_data[13];
                    dataGridView1.Rows[index].Cells[14].Value = str_data[14];
                    dataGridView1.Rows[index].Cells[15].Value = str_data[15];
                    dataGridView1.Rows[index].Cells[16].Value = str_data[16];
                    dataGridView1.Rows[index].Cells[17].Value = str_data[17];
                    dataGridView1.Rows[index].Cells[18].Value = str_data[18];

                    Form2.global_var3 = "";
                }

            }
            catch { MessageBox.Show("Please Select a Data."); }
        }

        private void btn_delete_Click(object sender, EventArgs e) // ---------- Delete Button
        {
            int id = 0;
            try
            {


                foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
                {
                    dataGridView1.Rows.RemoveAt(item.Index);
                    id = 1;
                }
                if (id == 0)
                {
                    MessageBox.Show("Please Select a Data.");
                }
            }
            catch { MessageBox.Show("Please Select a Data."); }
        }

        private void bunifuFlatButton7_Click(object sender, EventArgs e) // Account Button
        {
            Account ac = new Account();
            ac.ShowDialog();
        }

        private void btn_upload_Click(object sender, EventArgs e) // Upload data to cloud
        {
            try
            {
                //MessageBox.Show(dataGridView1.Rows[0].Cells[0].Value.ToString());
               
               
                if (dataGridView1.Rows.Count > 0)
                {
                    int cnt = 0;
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {

                        string BoatID = dataGridView1.Rows[cnt].Cells[0].Value.ToString();
                        string FishID = dataGridView1.Rows[cnt].Cells[1].Value.ToString();
                        string lat = dataGridView1.Rows[cnt].Cells[2].Value.ToString();
                        string lng = dataGridView1.Rows[cnt].Cells[3].Value.ToString();
                        string Petsa = dataGridView1.Rows[cnt].Cells[4].Value.ToString();
                        string Weight = dataGridView1.Rows[cnt].Cells[5].Value.ToString();
                        string species = dataGridView1.Rows[cnt].Cells[6].Value.ToString();
                        string cert = dataGridView1.Rows[cnt].Cells[7].Value.ToString();
                        string cap = dataGridView1.Rows[cnt].Cells[8].Value.ToString();
                        string botname = dataGridView1.Rows[cnt].Cells[9].Value.ToString();
                        string license = dataGridView1.Rows[cnt].Cells[10].Value.ToString();
                        string locate = dataGridView1.Rows[cnt].Cells[11].Value.ToString();
                        string idno = dataGridView1.Rows[cnt].Cells[12].Value.ToString();
                        string departureTime = dataGridView1.Rows[cnt].Cells[13].Value.ToString();
                        string arrivalTime = dataGridView1.Rows[cnt].Cells[14].Value.ToString();
                        string supplier = dataGridView1.Rows[cnt].Cells[15].Value.ToString();
                        string tagId = dataGridView1.Rows[cnt].Cells[16].Value.ToString();
                        string classification = dataGridView1.Rows[cnt].Cells[17].Value.ToString();
                        string enumeratorName = dataGridView1.Rows[cnt].Cells[18].Value.ToString();

                        string notepad_append = "{\"BoatId\":\"" + BoatID + "\"," +
                                                "\"CatchId\":\"" + FishID + "\"," +
                                                "\"Latitude\":\"" + lat + "\"," +
                                                "\"Longhitud\":\"" + lng + "\"," +
                                                "\"TimeStamp\":\"" + Petsa + "\"," +
                                                "\"Weight\":\"" + Weight + "\"," +
                                                "\"Species\":\"" + species + "\"," +
                                                "\"Certified\":\"" + cert + "\"," +
                                                "\"Captain\":\"" + cap + "\"," +
                                                "\"BoatName\":\"" + botname + "\"," +
                                                "\"LicenseId\":\"" + license + "\"," +
                                                "\"Location\":\"" + locate + "\"," +
                                                "\"IdNo\":\"" + idno + "\"" +
                                                "\"DepartureTime\":\"" + departureTime + "\"" +
                                                "\"ArrivalTime\":\"" + arrivalTime + "\"" +
                                                "\"Supplier\":\"" + supplier + "\"" +
                                                "\"TagId\":\"" + tagId + "\"" +
                                                "\"Classification\":\"" + classification + "\"" +
                                                "\"EnumeratorName\":\"" + enumeratorName + "\"" +
                                                "}+";

                        StreamWriter log = File.AppendText("jam.txt");
                        log.WriteLine(notepad_append);
                        log.Close();


                        DateTime today = DateTime.Today;
                        //string data_Record = "{\"boatid\":" + BoatID + ",\"fishid\":" + FishID + ",\"lat\":" + lng + ",\"lon\":" + lng + ",\"timestamp\":" + Petsa + ",\"weight\":" + Weight + ",\"size\":" + Size + "}";
                        StreamWriter log1 = File.AppendText("data_Record/" + today.ToString("dd-MM-yyyy") + ".txt");
                        log1.WriteLine(notepad_append);
                        log1.Close();

                        cnt++;
                        //richTextBox1.AppendText(i.ToString());
                    }
                    Process process = Process.Start(@"startProces.bat");
                }
                else { MessageBox.Show("No Data to Upload... Please Scan the NFC Card and Click Upload Button Again Thank You."); }

               

                //dataGridView1.Rows.Clear();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
                MessageBox.Show("No Data to Upload... Please Scan the NFC Card and Click Upload Button Again Thank You.");
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }

        private void bunifuImageButton8_Click(object sender, EventArgs e)// Minimized the FORM
        {
            this.WindowState = FormWindowState.Minimized;
        }

        

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.SelectionStart = richTextBox1.Text.Length;

            richTextBox1.ScrollToCaret();
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void btn_scan_Click_1(object sender, EventArgs e) // Button To Start Scan/ Read Serial port
        {
            try
            {
                sp = new SerialPort();

                sp.PortName = comboBox1.selectedValue;
                sp.BaudRate = 9600;
                sp.WriteTimeout = 5300;
                sp.ReadTimeout = 5300;
                sp.DtrEnable = true;
                sp.RtsEnable = true;
                sp.Open();

                //----------------------------> this will start the loop for incomming Serial Data
                readThread = new Thread(Read);
                readThread.Start();  
                //-----------------------------<
                RchTextBox_colorChange("\n\nReady To Scan NFC Card.!\n\n", "green");


                //btn_scan.BackColor = Green;
                btn_scan.Visible = false;
                btn_stop.Visible = true;
                btn_stop.Enabled = true;
                //btn_stop.BackColor = Color.DarkSlateGray;
                btn_upload.Enabled = true;
                textBox1.BackColor = Green;
                btn_loadPort.Visible = false;  // Reload Comport
                //btn_loadPort.BackColor = Color.Black;
                comboBox1.Enabled = false; // COM Port List

            }
            catch { MessageBox.Show("Com Port Not Supported...."); }
        }

        private void btn_dashboad_gridview_Click(object sender, EventArgs e) // Dashboard Button Show/Hide
        {
            if (dataGridView1.Visible == true)
            {
                dataGridView1.Visible = false;
                btn_dashboad_gridview.ButtonText = "Data List";
                btn_history.Enabled = false;
                btn_edit.Enabled = false;
                btn_clear.Enabled = false;
                btn_delete.Enabled = false;
                //bunifuFlatButton7.Enabled = false; // button Account
                btn_saveRecord.Enabled = false;
                btn_upload.Enabled = false;
            }
            else
            {
                dataGridView1.Visible = true;
                btn_dashboad_gridview.ButtonText = "Dashboard";
                btn_history.Enabled = true;
                btn_edit.Enabled = true;
                btn_clear.Enabled = true;
                btn_delete.Enabled = true;
                //bunifuFlatButton7.Enabled = true; // button Account
                btn_saveRecord.Enabled = true;
                btn_upload.Enabled = true;
            }
            
        }

        private void btn_loadPort_Click(object sender, EventArgs e)
        {
            SearchComPort(); // Reload Comport
        }

        private void btn_add_Click(object sender, EventArgs e) // --------------->> Add Button
        {
            global_var1 = "";
            Form2 f2 = new Form2();
            Form2.global_var3 = "save";
            f2.ShowDialog();

            if (Form2.global_var3 == "save")//---------------------------------------------
            {
                string[] str_data = Form2.global_var2.Split('&');
                
                int addrow;
                addrow = dataGridView1.Rows.Add();
                for (int x = 0; x < str_data.Length; x++)
                {

                    string form2_data = str_data[x];
                    if (x == 4)
                    {
                        form2_data = str_data[x];
                    }

                    dataGridView1.Rows[addrow].Cells[x].Value = form2_data;

                }
                Form2.global_var3 = "";

            }
            dataGridView1.ClearSelection();
            btn_clear.Enabled = true;
            btn_edit.Enabled = true;
            btn_delete.Enabled = true;
            btn_upload.Enabled = true;
            
        }

        private void btn_export_Click(object sender, EventArgs e)
        {
            var fishContainer = new List<FishRecord>();
            try
            {
                if (dataGridView1.Rows.Count > 0)
                {
                    int count = 0;
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        string BoatID = dataGridView1.Rows[count].Cells[0].Value.ToString();
                        string FishID = dataGridView1.Rows[count].Cells[1].Value.ToString();
                        string lat = dataGridView1.Rows[count].Cells[2].Value.ToString();
                        string lng = dataGridView1.Rows[count].Cells[3].Value.ToString();
                        string Petsa = dataGridView1.Rows[count].Cells[4].Value.ToString();
                        string Weight = dataGridView1.Rows[count].Cells[5].Value.ToString();
                        string species = dataGridView1.Rows[count].Cells[6].Value.ToString();
                        string cert = dataGridView1.Rows[count].Cells[7].Value.ToString();
                        string cap = dataGridView1.Rows[count].Cells[8].Value.ToString();
                        string botname = dataGridView1.Rows[count].Cells[9].Value.ToString();
                        string license = dataGridView1.Rows[count].Cells[10].Value.ToString();
                        string locate = dataGridView1.Rows[count].Cells[11].Value.ToString();
                        string idno = dataGridView1.Rows[count].Cells[12].Value.ToString();
                        string departureTime = dataGridView1.Rows[count].Cells[13].Value.ToString();
                        string arrivalTime = dataGridView1.Rows[count].Cells[14].Value.ToString();
                        string supplier = dataGridView1.Rows[count].Cells[15].Value.ToString();
                        string tagId = dataGridView1.Rows[count].Cells[16].Value.ToString();
                        string classification = dataGridView1.Rows[count].Cells[17].Value.ToString();
                        string enumeratorName = dataGridView1.Rows[count].Cells[18].Value.ToString();
                       
                        fishContainer.Add(new FishRecord
                        {
                            BoatId = BoatID,
                            CatchId = FishID,
                            Latitude = lat,
                            Longhitud = lng,
                            TimeStamp = Petsa,
                            Weight = Weight,
                            Species = species,
                            Certified = cert,
                            Captain = cap,
                            BoatName = botname,
                            LicenseId = license,
                            Location = locate,
                            IdNo = idno,
                            DepartureTime = departureTime,
                            ArrivalTime = arrivalTime,
                            Supplier = supplier,
                            TagId = tagId,
                            Classification = classification,
                            EnumeratorName = enumeratorName
                        });
                        count++;
                    }

                    fishContainer.ExportToJsonFile();
                    dataGridView1.Rows.Clear();
                }
                else
                {
                    MessageBox.Show("System Encountered Error. Make Sure That The Record List is Not Empty. Please Try Again...!", "Eport Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            catch (Exception exception)
            {
                //MessageBox.Show("System Encountered Error. Make Sure That The Record List is Not Empty. Please Try Again...!");
                
                MessageBox.Show("System Encountered Error. Make Sure That The Record List is Not Empty. Please Try Again...!", "Eport Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }                                                                                                  
        }

        public void RchTextBox_colorChange(string msg, string kulay) // RichtextBox Changing Color
        {
            // Change Color in RichtextBox
            richTextBox1.AppendText(msg);
            int richbox_lent = richTextBox1.TextLength;
            int Msg_lent = msg.Length - 2;
            int start_position = richbox_lent - Msg_lent;

            richTextBox1.SelectionStart = start_position;
            richTextBox1.SelectionLength = Msg_lent;
            if (kulay == "green")
            {
                richTextBox1.SelectionColor = Color.LimeGreen;
            }
            else { richTextBox1.SelectionColor = Color.IndianRed; }

        }
    }
}
