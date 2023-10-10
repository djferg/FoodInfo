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
        static string baseURL = "https://world.openfoodfacts.net/api/v2/";

        public static async Task<List<string>> GetProducts()
        {
            List<string> products = new List<string>();

            string endpoint = baseURL + "search?brands_tags=arnott%27s" +
                "&fields=code%2Cproduct_name%2Cimage_url";

            HttpClient client = new HttpClient();

            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, endpoint);
            HttpResponseMessage response = await client.SendAsync(request);

            if(response.IsSuccessStatusCode)
            {
                ProductResponseModel model = (ProductResponseModel)await response.Content.ReadFromJsonAsync(typeof(List<string>));
                /*products = model.products;*/
            }
            if (products != null)
            {
                return products;
            }
            return products;
        }
    }
}
