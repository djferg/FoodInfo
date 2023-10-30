using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using FoodInfo.Models;

namespace FoodInfo.Services
{
    public class OpenFoodFactsAPIService
    {
        readonly static string baseURL = "https://world.openfoodfacts.net/api/v2/";

        public static async Task<ProductsSearchByNameResponseModel> GetProductsResponse(string brand_tags)
        {
            string endpoint = baseURL + "search?brands_tags=" + brand_tags +
                "&fields=" +
                "code%2C" +
                "product_name%2C" +
                "image_url";

            HttpClient client = new();
            HttpRequestMessage request = new(HttpMethod.Get, endpoint);
            HttpResponseMessage response = await client.SendAsync(request);

            if (response.IsSuccessStatusCode)
            {
                ProductsSearchByNameResponseModel model = (ProductsSearchByNameResponseModel)await response.Content.ReadFromJsonAsync(typeof(ProductsSearchByNameResponseModel));
                return model;
            }
            else
            {
                return null;
            }
        }

        public static async Task<ProductSearchByCodeResponseModel> GetProductResponse(string code)
        {
            string endpoint = baseURL + "product/" + code +
                "?fields=code," +
                "product_name," +
                "image_url," +
                "ingredients";

            HttpClient client = new();
            HttpRequestMessage request = new(HttpMethod.Get, endpoint);
            HttpResponseMessage response = await client.SendAsync(request);

            if (response.IsSuccessStatusCode)
            {
                ProductSearchByCodeResponseModel model = (ProductSearchByCodeResponseModel)await response.Content.ReadFromJsonAsync(typeof(ProductSearchByCodeResponseModel));
                return model;
            }
            else
            {
                return null;
            }
        }
    }
}
