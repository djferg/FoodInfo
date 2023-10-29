﻿using FoodInfo.Models;
using FoodInfo.Services;
using System.Security.Cryptography.X509Certificates;

namespace FoodInfo.Views;

public partial class MainPage : ContentPage
{
	public ProductsSearchByNameResponseModel recentProducts;
	public MainPage()
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
        await Navigation.PushAsync(new ProductView(recentProducts.Products[0]));
    }
}

