using System;
using System.Globalization;
using BlogTemplate.MaterialDesign;
using Xamarin.Forms;

namespace BlogTemplate.Converters
{
    /// <summary>
    /// Binding value converter that returns a filled icon for bookmarked products and an outlined icon for others.
    /// <seealso href="https://docs.microsoft.com/en-us/xamarin/xamarin-forms/app-fundamentals/data-binding/converters"/>
    /// </summary>
    public class BookmarkConverter : IValueConverter
    {
        /// <param name="value">True for bookmarked items.</param>
        /// <param name="targetType">Unused</param>
        /// <param name="parameter">Unused</param>
        /// <param name="culture">Unused</param>
        /// <returns>The Unicode string of a Material icon.</returns>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (bool)value ? Icons.Bookmark : Icons.BookmarkOutline;
        }

        /// <summary>
        /// It is unnecessary to implement.
        /// </summary>
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
