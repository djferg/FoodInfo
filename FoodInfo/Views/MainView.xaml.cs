using FoodInfo.Models;
using FoodInfo.Services;

namespace FoodInfo.Views;

public partial class MainView : ContentPage
{
	public MainView()
	{
		InitializeComponent();	
	}

    private async void ButtonScanBarcode_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new SearchView(Entry_Search.Text));
    }

    private async void ButtonPreferences_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new SettingsView());
    }

    private async void Entry_Search_Completed(object sender, EventArgs e)
    {
        bool isNumber = long.TryParse(Entry_Search.Text, out _);
        if (isNumber)
        {
            ProductModel product = new();
            product.Barcode = Entry_Search.Text;
            await Navigation.PushAsync(new ProductView(product));
        } else
        {
            await Navigation.PushAsync(new SearchView(Entry_Search.Text));
        }        
    }

    private async void Recent_Tapped(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new SearchView(Entry_Search.Text));
    }
}

