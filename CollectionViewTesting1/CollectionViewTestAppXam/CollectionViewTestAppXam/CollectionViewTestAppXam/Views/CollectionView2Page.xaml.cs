using System;
using System.Collections.Generic;
using CollectionViewTestAppXam.ViewModels;
using Xamarin.Forms;

namespace CollectionViewTestAppXam.Views
{	
	public partial class CollectionView2Page : BasePage
	{
        EventTestViewModel ViewModel;
        public CollectionView2Page()
        {
            InitializeComponent();
            BindingContext = ViewModel = new EventTestViewModel();
        }
    }
}

