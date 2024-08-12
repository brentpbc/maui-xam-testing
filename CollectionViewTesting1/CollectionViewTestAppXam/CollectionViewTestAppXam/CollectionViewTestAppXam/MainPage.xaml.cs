using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CollectionViewTestAppXam.Views;
using Xamarin.Forms;

namespace CollectionViewTestAppXam
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void collectionViewPageButton_OnClicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new BasicCollectionViewPage());
        }

        void collectionView2PageButton_OnClicked(System.Object sender, System.EventArgs e)
        {
        }
    }
}

