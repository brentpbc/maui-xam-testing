using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CollectionViewTestAppMAUI.ViewModels;

namespace CollectionViewTestAppMAUI.Views;

public partial class CollectionView2Page : BasePage
{
    EventTestViewModel ViewModel;
    public CollectionView2Page()
    {
        InitializeComponent();
        BindingContext = ViewModel = new EventTestViewModel();
    }
}