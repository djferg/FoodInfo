using FoodInfo.Models;
using FoodInfo.Services;

namespace FoodInfo.Views;

public partial class ProductView : ContentPage
{
	ProductViewModel viewModel = new();
	public ProductView(ProductModel product)
	{
		InitializeComponent();

		viewModel.Product = product;

		UpdateView();

        BindingContext = viewModel.Product;
		
	}

	public async void UpdateView()
	{
		await viewModel.UpdateProduct();
		BindingContext = null;
        BindingContext = viewModel.Product;
    }
}