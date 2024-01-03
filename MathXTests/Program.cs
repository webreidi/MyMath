using Microsoft.NET.TestAnywhere.Builder;
using Microsoft.NET.TestAnywhere.Extensions;
using Xunit;

TestApplicationBuilder builder = await TestApplication.CreateBuilderAsync(args); 
builder.AddxUnit(() => new[] { typeof(Program).Assembly });
builder.AddTestReportsGenerator();
TestApplication app = await builder.BuildAsync(); 
return await app.RunAsync();