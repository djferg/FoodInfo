namespace FoodInfo;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    private async void ButtonScanBarcode_Clicked(object sender, EventArgs e)
    {
		await Shell.Current.GoToAsync("//ProductPage");
    }
}

