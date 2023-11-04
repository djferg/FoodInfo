using FoodInfo.Models;
using FoodInfo.Services;

namespace FoodInfo.Views;

public partial class ProductView : ContentPage
{
	public ProductView(ProductModel product)
	{
		InitializeComponent();
		
		BindingContext = product;

		if (product.RequiresUpdate)
		{
			UpdateProduct(product);
		}
	}

	public async void UpdateProduct(ProductModel product)
	{
        ProductSearchByCodeResponseModel productReponse = await OpenFoodFactsAPIService.GetProductResponse(product.Barcode);
        product = productReponse.Product;
		product.RequiresUpdate = false;

		BindingContext = product;
    }
}