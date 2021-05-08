using System.IO;
using System.Net;
using ConsumingAPIDotNetMVCBootstrap.Models;
using Newtonsoft.Json;

namespace ConsumingAPIDotNetMVCBootstrap.Services
{
    public class ServiceDataResponse
    {
        const string API = "https://lotericas.io/api/v1/";
        public DataResponse GetDataResponse(string URL)
        {
            var requisition = WebRequest.CreateHttp(API + URL);
            requisition.Method = "GET";
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