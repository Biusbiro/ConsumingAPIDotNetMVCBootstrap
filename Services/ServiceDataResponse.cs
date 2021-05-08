using System.IO;
using System.Net;
using ConsumingAPIDotNetMVCBootstrap.Models;
using Newtonsoft.Json;

namespace ConsumingAPIDotNetMVCBootstrap.Services
{
    public class ServiceDataResponse
    {
        public DataResponse GetDataResponse(string URL)
        {
            var requisition = WebRequest.CreateHttp(URL);
            requisition.Method = "GET";
            requisition.UserAgent = "Testinho";
            DataResponse dataResponse = new DataResponse();
            using (var response = requisition.GetResponse())
            {
                var streamData = response.GetResponseStream();
                StreamReader reader = new StreamReader(streamData);
                object objResponse = reader.ReadToEnd();
                dataResponse = JsonConvert.DeserializeObject<DataResponse>(objResponse.ToString());
                streamData.Close();
                response.Close();
            }
            return dataResponse;
        }
    }
}