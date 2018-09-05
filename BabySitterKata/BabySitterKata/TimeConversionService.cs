using BabySitterKata.Interfaces;
using System;

namespace BabySitterKata
{
    public class TimeConversionService : ITimeConversionService
    {
        public DateTime GetDate(string time)
        {
            var verifiedTime = DateTime.Parse(time).TimeOfDay;

            // only works if start time is never earliar than 4pm and end time is no later than 4pm
            var day = verifiedTime.Hours > 4 ? DateTime.Today : DateTime.Today.AddDays(1);

            return day + verifiedTime;
        }
    }
}
