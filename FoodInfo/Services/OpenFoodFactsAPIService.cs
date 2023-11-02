using System.Net.Http.Json;
using FoodInfo.Models;

namespace FoodInfo.Services
{
    public class OpenFoodFactsAPIService
    {
        private static readonly string baseURL = "https://world.openfoodfacts.net/api/v2/";
        private static readonly HttpClient client = new();

        public static async Task<ProductsSearchByNameResponseModel> GetProductsResponse(string brand_tags)
        {
            string endpoint = $"{baseURL}search?brands_tags={brand_tags}&fields=code,product_name,image_url";

            HttpResponseMessage response;
            try
            {
                response = await client.GetAsync(endpoint);

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadFromJsonAsync<ProductsSearchByNameResponseModel>();
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching product list {ex.Message}");
                return null;
            }
        }

        public static async Task<ProductSearchByCodeResponseModel> GetProductResponse(string code)
        {
            string endpoint = $"{baseURL}product/{code}?fields=code,product_name,image_url,ingredients";

            HttpResponseMessage response;
            try
            {
                response = await client.GetAsync(endpoint);

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadFromJsonAsync<ProductSearchByCodeResponseModel>();
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching product {ex.Message}");
                return null;
            }
        }
    }
}

