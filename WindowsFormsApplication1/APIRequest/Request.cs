using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.APIRequest
{
    class Request
    {
        static string URL = "https://jam.document.fish/api/1.1/obj/";

        private static RestClient client = new RestClient(URL);

        public bool PostRequest(List<string> requestList)
        {
            var where = "importData1";
            RestRequest request = new RestRequest(where, Method.POST);

            foreach (var post in requestList)
            {
                //var postData = new Todo
                //{
                //    Name = "Bahay",
                //    Description = "Gibain"
                //};
            }

            return true;
        }

    }
}
