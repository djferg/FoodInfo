using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodInfo.Services;

namespace FoodInfo.Models
{
    public  class ProductViewModel
    {
        public ProductModel Product { get; set; }
        public bool RequiresUpdate { get; set; }

        public ProductViewModel()
        {
            Product = new ProductModel();
            RequiresUpdate = true;
        }

        public async Task<ProductModel> GetProductAsync()
        {
            ProductSearchByCodeResponseModel productReponse = await OpenFoodFactsAPIService.GetProductResponse(Product.Barcode);
            return productReponse.Product;
        }

        public async Task UpdateProduct()
        {
            if (RequiresUpdate)
            {
                Product = await GetProductAsync();
                RequiresUpdate = false;
            }
        }
    }
}
