using Sample.Application.Common.Interfaces.Services;

namespace Sample.Infrastructure.Services;

public class DateTimeProvider : IDateTimeProvider
{
    public DateTime UtcNow => DateTime.UtcNow;
}
