

TestApplicationBuilder builder = await TestApplication.CreateBuilderAsync(args);
builder.AddMSTest(() => new[] { typeof(Program).Assembly });
builder.AddCodeCoverage();
builder.AddTestReportsGenerator();
builder.AddTelemetry();
TestApplication app = await builder.BuildAsync();
return await app.RunAsync();
