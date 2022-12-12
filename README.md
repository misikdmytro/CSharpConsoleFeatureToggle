# Feature flags in C# Console

1. Reference next packages: `Microsoft.Extensions.DependencyInjection` and `Microsoft.FeatureManagement`;
2. Create instance of `IConfiguration` (you can use `appsettings.json`, Azure config, etc. whatever you need);
3. Create instance of `ServiceCollection` using constructor `ServiceCollection services = new();`;
4. Register feature toggle services `services.AddFeatureManagement(configuration);`;
5. Create instance of `ServiceProvider` using `ServiceProvider serviceProvider = services.BuildServiceProvider();`;
6. Resolve `IFeatureManager`.
