using System;
using System.Globalization;
using Xamarin;

namespace MauiApp1
{
    public class SliderValueToColorConverter
    {
        public SliderValueToColorConverter()
        {
        }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture, Color color)
        {
            // Get the slider value as a double
            double sliderValue = (double)value;

            // Return a color based on the value
            if (sliderValue < 50)
            {
                // Return blue for values less than 50
                return color.Blue;
            }
            else if (sliderValue > 50)
            {
                // Return red for values greater than 50
                return color.Red;
            }
            else
            {
                // Return green for values equal to 50
                return color.Green;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // Not implemented
            throw new NotImplementedException();
        }
    }

    public class SliderValueToTextConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // Get the slider value as a double
            double sliderValue = (double)value;

            // Return a text based on the value
            if (sliderValue < 40)
            {
                // Return "Failed" for values less than 40
                return "Failed";
            }
            else if (sliderValue < 80)
            {
                // Return "Passed" for values between 40 and 79
                return "Passed";
            }
            else
            {
                // Return "Excellent" for values between 80 and 100
                return "Excellent";
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // Not implemented
            throw new NotImplementedException();
        }
    }
}