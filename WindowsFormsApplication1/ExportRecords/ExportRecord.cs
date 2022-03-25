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
                var date = DateTime.Now.ToString("yyyy-M-d");
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
    }
}
