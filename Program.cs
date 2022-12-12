using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.FeatureManagement;

IConfigurationRoot configuration = new ConfigurationBuilder().Build();
ServiceCollection services = new();
services.AddFeatureManagement(configuration);

ServiceProvider serviceProvider = services.BuildServiceProvider();
IFeatureManager manager = serviceProvider.GetRequiredService<IFeatureManager>();

await manager.IsEnabledAsync("Feature");
