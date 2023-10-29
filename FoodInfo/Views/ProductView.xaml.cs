using FoodInfo.Models;

namespace FoodInfo.Views;

public partial class ProductView : ContentPage
{
	public ProductView(ProductModel product)
	{
		InitializeComponent();
		
		BindingContext = product;
	}
}