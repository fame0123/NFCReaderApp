using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public static class TimeStampConfiguration
    {
        public static string TimeStampConverter(this string timeStamp)
        {
            char[] stamp = timeStamp.Trim().ToCharArray();
            //MessageBox.Show(stamp.Length.ToString());

            string yr = "";
            string mont = "";
            string day = "";
            string hr = "";
            string min = "";


            if (stamp.Length == 10)
            {
                yr = "20" + stamp[0] + stamp[1];
                mont = stamp[2].ToString();
                day = stamp[3] + stamp[4].ToString();
                hr = stamp[5] + stamp[6].ToString();
                min = stamp[7] + stamp[8].ToString();



            }
            else if (stamp.Length == 11)
            {
                yr = "20" + stamp[0] + stamp[1];
                mont = stamp[2].ToString();
                day = stamp[3] + stamp[4].ToString();
                hr = stamp[5] + stamp[6].ToString();
                min = stamp[7] + stamp[8].ToString();



            }
            else if (stamp.Length == 12)
            {
                yr = "20" + stamp[0] + stamp[1];
                mont = stamp[2] + stamp[3].ToString();
                day = stamp[4] + stamp[5].ToString();
                hr = stamp[6] + stamp[7].ToString();
                min = stamp[8] + stamp[9].ToString();

            }
            else
            {

                yr = "20" + stamp[0] + stamp[1];
                mont = stamp[2].ToString();
                day = stamp[3] + stamp[4].ToString();
                hr = stamp[5] + stamp[6].ToString();
                min = stamp[7] + stamp[8].ToString();


            }
            int hours = Convert.ToInt32(hr);
            if (hours > 23)
            {
                int val1 = hours / 23;
                int val2 = val1 * 23;
                int val3 = hours - val2;
                hr = val3.ToString();
            }
            int minut = Convert.ToInt32(min);
            if (minut > 59)
            {
                int val1 = minut / 23;
                int val2 = val1 * 23;
                int val3 = minut - val2;
                min = val3.ToString();
            }

            return yr + "-" + mont + "-" + day;//+ " " + hr + ":" + min;
        }
    }
}
