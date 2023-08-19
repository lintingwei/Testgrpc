using Calculator;
using Grpc.Net.Client;

using var channel = GrpcChannel.ForAddress("https://localhost:7286");

var calculatorClient = new Calculator.Calculator.CalculatorClient(channel);

var addRequest = new AddRequest()
{
    Number1 = 10,
    Number2 = 33
};
var addResponse = await calculatorClient.AddAsync(addRequest);
Console.WriteLine($"Add {addRequest.Number1} and {addRequest.Number2} : {addResponse.Sum}");

Console.ReadKey();