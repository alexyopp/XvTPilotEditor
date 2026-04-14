using System;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Windows.Data;
using System.Windows.Markup;
using XvTPilotEditor;

namespace XvTPilotEditor.Converters
{
    public sealed class UIntToPilotRatingConverter : MarkupExtension, IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null) return string.Empty;

            if (!uint.TryParse(System.Convert.ToString(value, culture), out var idx))
                return value;

            if (!Enum.IsDefined(typeof(PilotRating), idx))
                return idx.ToString(culture);

            var rating = (PilotRating)idx;
            var name = Enum.GetName(typeof(PilotRating), rating);
            var desc = (typeof(PilotRating).GetField(name!)?
                .GetCustomAttributes(typeof(DescriptionAttribute), false)
                .FirstOrDefault() as DescriptionAttribute)?.Description;

            return desc ?? rating.ToString();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        public override object ProvideValue(IServiceProvider serviceProvider) => this;
    }
}