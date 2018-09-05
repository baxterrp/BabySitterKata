using System;

namespace BabySitterKata.Interfaces
{
    public interface ITimeConversionService
    {
        DateTime GetDate(string time);
    }
}
