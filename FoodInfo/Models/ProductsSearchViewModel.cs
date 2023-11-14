using FoodInfo.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodInfo.Models
{
    public class ProductsSearchViewModel
    {
        public string SearchTerm { get; set; }
        public int Results { get; set; }
        public List<ProductModel> Products { get; set; }
        
        public ProductsSearchViewModel()
        {
            SearchTerm = string.Empty;
            Products = new List<ProductModel>();
        }

        public async Task<List<ProductModel>> GetProductsAsync()
        {
            ProductsSearchByNameResponseModel productResponse = await OpenFoodFactsAPIService.GetProductsResponse(SearchTerm);
            Results = productResponse.Count;
            return productResponse.Products;
        }
    }
}
