using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using GEE.Web.ViewModel;
using Newtonsoft.Json;
using System.Configuration;
using Newtonsoft.Json.Linq;

namespace GEE.Web.Service
{
    public class EnquiryService
    {
        public async Task<List<EnquiryViewModel>> GetAll()
        {
            using (var client = Common.GetHttpClient())
            {
                var Response = await client.GetAsync("api/enquiry/GetAll");
                if (Response.IsSuccessStatusCode)
                {
                    return JsonConvert.DeserializeObject<List<EnquiryViewModel>>(Response.Content.ReadAsStringAsync().Result);
                }
            }
            return null;
        }

        public async Task<bool> Save(HttpContent collection)
        {
            using (var client = Common.GetHttpClient())
            {
                var Response = await client.PostAsync("api/enquiry/Save", collection);
                return Response.IsSuccessStatusCode ? true : false;
            }
        }

        public async Task<bool> Update(HttpContent content)
        {
            using (var client = Common.GetHttpClient())
            {
                var Response = await client.PutAsync("api/enquiry/Update/", content);
                return Response.IsSuccessStatusCode ? true : false;
            }
        }

        public async Task<EnquiryViewModel> GetById(int id)
        {
            var enquiry = new EnquiryViewModel();
            using (var client = Common.GetHttpClient())
            {
                var Response = await client.GetAsync("api/enquiry/GetById/" + id);
                if (Response.IsSuccessStatusCode)
                {
                    return JsonConvert.DeserializeObject<EnquiryViewModel>(Response.Content.ReadAsStringAsync().Result);
                }
                return null;
            }
        }
    }
}
