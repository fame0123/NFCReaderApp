using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace WindowsFormsApplication1
{
    public static class ExportRecord
    {
        public static void ExportToJsonFile(this List<FishRecord> fishRecord)
        {
           

            try
            {
                var date = DateTime.Now.ToString("yyyy-MM-d");
                var fileName = $"FishRecord_{DateTime.Now.ToString("hh-mm-ss")}.json";

                //var folderPath = $@"C:\Fame_Record\{date}";
                var pathsName = Path.GetDirectoryName(Environment.GetFolderPath(Environment.SpecialFolder.Personal));
                pathsName = Path.Combine(pathsName, "Downloads");

                var path = $@"{pathsName}\{fileName}";
                Directory.CreateDirectory(pathsName);

                var record = JsonConvert.SerializeObject(fishRecord);
                File.WriteAllText(path, record);

                MessageBox.Show($"Export Successful. You can now view your File in {path}", "Export Successful",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void ExportToJsonFile(this FishRecord fishRecord, string folderName)
        {


            try
            {
                var date = DateTime.Now.ToString("yyyy-MM-dd");
                var time = DateTime.Now.ToString("t")
                    .Replace(" ", "")
                    .Replace(":", ".");
                var name = "CatchId-" + fishRecord.CatchId; 
                var fileName = $"{name}_({time})_LN({fishRecord.LineNumber}).json";

                var pathsName = Path.GetDirectoryName(Environment.GetFolderPath(Environment.SpecialFolder.Personal));
                pathsName = Path.Combine(pathsName, "Downloads");

                //var path = $@"{pathsName}\{folderName}\{fileName}";
                var directory = $@"{pathsName}\{folderName}\{date}\";
                // If directory does not exist, create it
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }

                var path = directory + fileName
                    .Replace("\r", "")
                    .Replace("\n", "");
                var record = JsonConvert.SerializeObject(fishRecord);
                File.WriteAllText(path, record);

                MessageBox.Show($"Export Successful. You can now view your File in {path}", "Export Successful",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
