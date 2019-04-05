using DemoProject.Common;
using DemoProject.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;


namespace DemoProject.Api
{
    public class ServiceApi
    {
        public static ObservableCollection<Employee> emplyee;
        public static async Task<ObservableCollection<Employee>> GetEmplyee()
        {
            emplyee = new ObservableCollection<Employee>();
            var client = new HttpClient();
            string urlFomrate = ConstantsValue.BaseAddress + ConstantsValue.Emplyeelist;
            string requestContent = urlFomrate;
            try
            {
                var request = new HttpRequestMessage(HttpMethod.Get, requestContent);
                var response = await client.SendAsync(request);
                if (response.IsSuccessStatusCode)
                {
                    string result = response.Content.ReadAsStringAsync().Result;
                    emplyee = JsonConvert.DeserializeObject<ObservableCollection<Employee>>(result);

                }
                else
                {
                    return null;
                }
            }
            
            catch (Exception ex)
            {
                return null;
            }
            return emplyee;
        }
    }
}
