using Aggregator.Infrastructure.ConnectedServices;

string location = "Rybnik";
string appId = "573dd4138f1d88a18eed7937eb968052";

IOpenWeatherMapService _weatherService = new OpenWeatherMapService();
var response = await _weatherService.Retrieve(location, appId);

Console.WriteLine($"Location: {location}");
Console.WriteLine($"Location: {response.weather.FirstOrDefault().description}");
Console.WriteLine($"Location: {response.main.temp}'C");

