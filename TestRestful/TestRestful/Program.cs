var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello TestRestful!");

app.MapGet("/Add", (int number1, int number2) => number1 + number2);

app.Run();
