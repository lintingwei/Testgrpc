using Calculator;
using Grpc.Core;

namespace GrpcGreeter.Services;

public class CalculatorService:Calculator.Calculator.CalculatorBase
{
    public override Task<AddResponse> Add(AddRequest request, ServerCallContext context)
    {
        return Task.FromResult(new AddResponse()
        {
            Sum = request.Number1 + request.Number2
        });
    }
}