using Calculator;
using Grpc.Net.Client;
using TestPerformance;

using var channel = GrpcChannel.ForAddress("https://localhost:7286");

var calculatorClient = new Calculator.Calculator.CalculatorClient(channel);

var addRequest = new AddRequest()
{
    Number1 = 10,
    Number2 = 33
};

var client = new HttpClient();


var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSingleton<IHttpService, HttpService>();
builder.Services.AddHttpClient();
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapGet("/gRpcEcho", async () =>
{
    Console.WriteLine("Call gRpcEcho");
    return await calculatorClient.AddAsync(addRequest);
});
app.MapGet("/restEcho", async (IHttpService httpService) =>
{
    Console.WriteLine("Call rest");
    return await httpService.GetAsync();
});

app.Run();