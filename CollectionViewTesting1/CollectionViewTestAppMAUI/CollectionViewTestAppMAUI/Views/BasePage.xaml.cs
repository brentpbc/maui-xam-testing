using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionViewTestAppMAUI.Views;

public partial class BasePage : ContentPage
{
    public BasePage()
    {
        InitializeComponent();
    }
    
    ~BasePage()
    {
        var type = this.GetType();
        Debug.WriteLine($"Garbage Collector cleaned up {type} page.");
    }
}