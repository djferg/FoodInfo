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
            PerformSearch();
        }
	}

    async private void PerformSearch()
    {
        try
        {
            ListView_Products.ItemsSource = null;
            ListView_Products.BindingContext = null;

            ProductsSearchByNameResponseModel response = await OpenFoodFactsAPIService.GetProductsResponse(Entry_Search.Text.ToString());

            if (response != null && response.Products != null)
            {
                ListView_Products.BindingContext = response;
                ListView_Products.ItemsSource = response.Products;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }


    private void Entry_Search_Completed(object sender, EventArgs e)
    {
        PerformSearch();
    }

    private void ListView_Products_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        ProductModel product = e.Item as ProductModel;
        Navigation.PushAsync(new ProductView(product));
    }
}