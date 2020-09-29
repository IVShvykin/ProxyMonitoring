using System;

namespace Common.Helpers.DateTimeBinder
{
    public static class DateTimeUTCParseHelper
    {
        public static (bool Success, DateTime? Result) ParseDateTime(string dateToParse)
        {
            if (string.IsNullOrEmpty(dateToParse))
            {
                return (true, null);
            }

            if (!dateToParse.EndsWith("Z"))
            {
                return (false, null);
                //throw new DateFormatException("DateTime fields should be in UTC format");
            }

            if (DateTime.TryParse(dateToParse, out var validDate))
            {
                return (true, validDate);
            }

            return (false, null);
        }
    }
}
