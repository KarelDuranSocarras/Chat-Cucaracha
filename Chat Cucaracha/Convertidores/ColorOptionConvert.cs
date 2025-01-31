using System.Globalization;

namespace Chat_Cucaracha.Convertidores
{
    public class ColorOptionConvert : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is bool isSend)
            {
                return isSend ? Colors.LightBlue : Colors.LightGray;
            }
            return Colors.LightGray; // Valor por defecto
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
