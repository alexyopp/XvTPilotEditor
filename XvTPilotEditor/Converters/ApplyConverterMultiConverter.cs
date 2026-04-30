using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace XvTPilotEditor.Converters
{
    // Receives [value, IValueConverter] and returns converter.Convert(value,...)
    public sealed class ApplyConverterMultiConverter : IMultiValueConverter
    {
        public object? Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if (values == null || values.Length < 2)
                return DependencyProperty.UnsetValue;

            var value = values[0];
            var converter = values[1] as IValueConverter;
            if (converter == null)
                return value?.ToString() ?? string.Empty;

            return converter.Convert(value, targetType, parameter, culture) ?? DependencyProperty.UnsetValue;
        }

        public object[] ConvertBack(object? value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotSupportedException("ApplyConverterMultiConverter does not support ConvertBack.");
        }
    }
}