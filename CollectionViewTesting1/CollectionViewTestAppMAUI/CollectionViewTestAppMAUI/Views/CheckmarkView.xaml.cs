using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionViewTestAppMAUI.Views;

public partial class CheckmarkView : ContentView
{
    // The order these properties are declared matters and affects timing of binding and values the
    // CheckMarkToGlyphConverter receives
    public static readonly BindableProperty CanEditProperty = BindableProperty.Create(nameof(CanEdit), typeof(bool), typeof(CheckmarkView), false);
    public static readonly BindableProperty IsCheckedProperty = BindableProperty.Create(nameof(IsChecked), typeof(bool), typeof(CheckmarkView), false, BindingMode.TwoWay);
    
    public bool CanEdit
    {
        get
        {
            return (bool)GetValue(CanEditProperty);
        }
        set
        {
            SetValue(CanEditProperty, value);
        }
    }
    
    public bool IsChecked
    {
        get
        {
            return (bool)GetValue(IsCheckedProperty);
        }
        set
        {
            SetValue(IsCheckedProperty, value);
        }
    }

   

    public CheckmarkView()
    {
        InitializeComponent();
    }
}