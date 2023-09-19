using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace FoodInfo
{
    static class OpenFoodFactsAPIService
    {
        static string baseURL = "https://api.openfoodfacts.org/api/v2/blahblahblah/";

        public static async Task<List<string>> GetProducts()
        {
            List<string> products = new List<string>();

            string endpoint = baseURL + "products";

            HttpClient client = new HttpClient();

            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, endpoint);
            request.Headers.Add("apikey", "&hhf6sbd7fnd67s667fff7");
            HttpResponseMessage response = await client.SendAsync(request);

            if(response.IsSuccessStatusCode)
            {
                ProductResponseModel model = (ProductResponseModel)await response.Content.ReadFromJsonAsync(typeof(List<string>));
                products = model.products;
            }
            return products;
        }
    }
}
