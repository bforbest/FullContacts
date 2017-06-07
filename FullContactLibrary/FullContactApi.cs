using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace FullContactLibrary
{
    public class FullContactApi : IFullContactApi
    {
        private string _uri;
        private string _apiKey;
        public FullContactApi(string uri, string apiKey)
        {
            _uri = uri;
            _apiKey = apiKey;
        }

        
        public async Task<FullContactPerson> LookupPersonByEmailAsync(string email)
        {
            using (var client = new WebClient())
            {
                var http = new HttpClient();
                http.DefaultRequestHeaders.Add("X-FullContact-APIKey", _apiKey);
                var url =  _uri + email;
                var response = await http.GetAsync(url);
                if (response != null)
                {
                    string content="";
                    if (response.Content != null)
                    {
                        content = await response.Content.ReadAsStringAsync();
                    }
                    if (!response.IsSuccessStatusCode)
                    {
                        throw new HttpRequestException("Nothing found");
                    }
                    var serializer = new DataContractJsonSerializer(typeof(FullContactPerson));
                    var ms = new MemoryStream(Encoding.UTF8.GetBytes(content));
                    var data = (FullContactPerson)serializer.ReadObject(ms);
                    return data;
                }else
                {
                    throw new HttpRequestException();
                }
            }
        }
    }


}
