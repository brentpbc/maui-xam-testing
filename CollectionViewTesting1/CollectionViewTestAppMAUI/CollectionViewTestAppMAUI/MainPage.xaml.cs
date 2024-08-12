using CollectionViewTestAppMAUI.ViewModels;
using CollectionViewTestAppMAUI.Views;

namespace CollectionViewTestAppMAUI;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}
	
	protected override void OnAppearing()
	{
		base.OnAppearing();
	}

	async void collectionViewPageButton_OnClicked(object? sender, EventArgs e)
	{
		await Navigation.PushAsync(new BasicCollectionViewPage());
	}

	async void collectionView2PageButton_OnClicked(object? sender, EventArgs e)
	{
		await Navigation.PushAsync(new CollectionView2Page());
	}
}

