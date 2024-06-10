using System;
using System.Windows;
using System.Windows.Data;
using System.Windows.Markup;

namespace XvTPilotEditor.Converters
{
    public class EnumToVisibilityConverter : MarkupExtension, IValueConverter
    {
        public bool Collapse { get; set; }
        public bool IsReversed { get; set; }

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            Visibility visibility = Visibility.Visible;

            if (this.IsReversed == (value != null && value.Equals(parameter)))
            {
                visibility = this.Collapse ? Visibility.Collapsed : Visibility.Hidden;
            }

            return visibility;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return value.Equals(true) ? parameter : Binding.DoNothing;
        }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return this;
        }
    }
}
