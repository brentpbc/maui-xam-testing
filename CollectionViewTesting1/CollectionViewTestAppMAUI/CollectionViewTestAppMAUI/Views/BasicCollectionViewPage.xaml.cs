using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CollectionViewTestAppMAUI.ViewModels;

namespace CollectionViewTestAppMAUI.Views;

public partial class BasicCollectionViewPage : BasePage
{
    EventTestViewModel ViewModel;
    public BasicCollectionViewPage()
    {
        InitializeComponent();
        BindingContext = ViewModel = new EventTestViewModel();
    }
}