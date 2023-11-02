using FoodInfo.Models;
using FoodInfo.Services;

namespace FoodInfo.Views;

public partial class SearchView : ContentPage
{
	public SearchView(string searchText="")
	{
        InitializeComponent();

		Entry_Search.Text = searchText;

		if (searchText != null )
		{
			PerformSearch(searchText);
		}
	}

	async private void PerformSearch(string searchText)
	{
		ProductsSearchByNameResponseModel response = await OpenFoodFactsAPIService.GetProductsResponse(searchText);

		ListView_Products.BindingContext = response;
	}

    private void Entry_Search_Completed(object sender, EventArgs e)
    {
        PerformSearch(Entry_Search.Text);
    }
}