using Aggregator.Domain;

namespace Aggregator.Infrastructure.ConnectedServices
{
    public interface IOpenWeatherMapService
    {
        Task<OpenWeatherMap> Retrieve(string location, string appId);
    }
}