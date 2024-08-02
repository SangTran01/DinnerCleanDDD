using Dinner.Application.Common.Interfaces;

namespace Dinner.Infrastructure;

public class DateTimeProvider: IDateTimeProvider
{
    public DateTime UtcNow => DateTime.UtcNow;
}