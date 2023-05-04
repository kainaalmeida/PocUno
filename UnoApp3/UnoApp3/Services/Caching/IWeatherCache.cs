using System.Collections.Immutable;
using UnoApp3.DataContracts;

namespace UnoApp3.Services.Caching
{
    public interface IWeatherCache
    {
        ValueTask<IImmutableList<WeatherForecast>> GetForecast(CancellationToken token);
    }
}