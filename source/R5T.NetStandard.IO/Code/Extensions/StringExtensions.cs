using System;


namespace R5T.NetStandard.IO.Extensions
{
    public static class StringExtensions
    {
        public static SearchPattern AsSearchPattern(this string value)
        {
            var searchPattern = new SearchPattern(value);
            return searchPattern;
        }
    }
}
