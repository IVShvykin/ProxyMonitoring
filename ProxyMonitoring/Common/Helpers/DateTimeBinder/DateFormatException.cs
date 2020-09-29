using System;

namespace Common.Helpers.DateTimeBinder
{
    public class DateFormatException: FormatException
    {
        public DateFormatException(string message) : base(message) { }
    }
}
