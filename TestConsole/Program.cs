using System.Configuration;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.FeatureManagement;

var features = new Dictionary<string, string>{{"FeatureManagement:Premium", "false"}};
IConfigurationRoot config = new ConfigurationBuilder().AddInMemoryCollection(features).Build();
//ZIServiceCollection services = new ServiceCollection();
