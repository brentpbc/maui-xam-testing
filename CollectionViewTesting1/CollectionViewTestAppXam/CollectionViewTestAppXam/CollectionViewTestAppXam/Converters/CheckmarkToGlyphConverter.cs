using System;
using System.Globalization;
using CollectionViewTestAppXam.Resources.Fonts;
using Xamarin.Forms;

namespace CollectionViewTestAppXam.Converters
{
    public class CheckMarkToGlyphConverter : BindableObject, IValueConverter
    {
        public static readonly BindableProperty CanEditProperty =
            BindableProperty.Create(
                nameof(CanEdit),
                typeof(bool),
                typeof(CheckMarkToGlyphConverter),
                false);

        public bool CanEdit
        {
            get { return (bool)GetValue(CanEditProperty); }
            set { SetValue(CanEditProperty, value); }
        }

        public object Convert(object value, Type targetType,
            object parameter, CultureInfo culture)
        {
            if (value == null) return FontAwesomeIcons.Square;
            bool isChecked = (bool)value;

            //Debug.WriteLine($"CheckmarkGlyphConverter IsChecked:{isChecked} CanEdit:{CanEdit}.");
            if (isChecked)
            {
                if (CanEdit)
                {
                    return FontAwesomeIcons.SquareCheck;
                }

                return FontAwesomeIcons.Check;

            }
            return FontAwesomeIcons.Square;
        }

        public object ConvertBack(object value, Type targetType,
            object parameter, CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }
}

