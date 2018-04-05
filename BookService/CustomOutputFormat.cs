using System;

namespace BookService
{
    public class CustomOutputFormat : IFormatProvider, ICustomFormatter
    {
        public object GetFormat(Type formatType)
        {
            return null;
        }

        public string Format(string format, object arg, IFormatProvider provider)
        {
            return null;
        }
    }
}