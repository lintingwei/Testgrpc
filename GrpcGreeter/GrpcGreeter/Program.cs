using GrpcGreeter;
using GrpcGreeter.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddGrpc();

var app = builder.Build();

app.MapGrpcService<CalculatorService>();
app.MapGrpcService<LogService>();
app.MapGet("/", () => "Welcome to gRPC Server!");

app.Run();