using Android.Speech.Tts;
using FoodInfo.Models;
using FoodInfo.Services;

namespace FoodInfo.Views;

public partial class Search : ContentPage
{
	public Search(string searchText="")
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