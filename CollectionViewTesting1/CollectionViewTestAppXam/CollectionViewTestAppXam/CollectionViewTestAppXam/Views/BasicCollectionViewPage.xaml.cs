using System;
using System.Collections.Generic;
using CollectionViewTestAppXam.ViewModels;
using Xamarin.Forms;

namespace CollectionViewTestAppXam.Views
{	
	public partial class BasicCollectionViewPage : BasePage
	{
        BasicCollectionViewViewModel ViewModel;
        public BasicCollectionViewPage()
        {
            InitializeComponent();
            BindingContext = ViewModel = new BasicCollectionViewViewModel();
        }
    }
}

