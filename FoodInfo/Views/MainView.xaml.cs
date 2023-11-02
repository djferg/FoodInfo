using FoodInfo.Models;
using FoodInfo.Services;
using System.Security.Cryptography.X509Certificates;

namespace FoodInfo.Views;

public partial class MainView : ContentPage
{
	public ProductsSearchByNameResponseModel recentProducts;
    public ProductSearchByCodeResponseModel testProductResponse;
    public ProductModel testProduct;
	public MainView()
	{
		InitializeComponent();	
	}

    private async void ButtonScanBarcode_Clicked(object sender, EventArgs e)
    {
		/*await Shell.Current.GoToAsync("//ProductPage");*/
		/*AppTheme theme = Application.Current.RequestedTheme;*/ //enum
		Application.Current.Resources.MergedDictionaries.Clear();
		Application.Current.Resources.MergedDictionaries.Add(new LightTheme());

        recentProducts = await OpenFoodFactsAPIService.GetProductsResponse("rosella");
        testProductResponse = await OpenFoodFactsAPIService.GetProductResponse(recentProducts.Products[0].Barcode);
        testProduct = testProductResponse.Product;


		if(recentProducts != null)
		{
			RecentProductOne.Text = recentProducts.Products[0].Name;
			RecentProductOneImage.Source = recentProducts.Products[0].ImageUrl;
            RecentProductTwo.Text = recentProducts.Products[1].Name;
            RecentProductTwoImage.Source = recentProducts.Products[1].ImageUrl;
        }

    }

    private async void Recent_Tapped(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new ProductView(testProduct));
    }

    private async void ButtonPreferences_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new SettingsView());
    }

    private async void Entry_Search_Completed(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new SearchView(Entry_Search.Text));
    }
}

