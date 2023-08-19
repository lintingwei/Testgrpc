using Grpc.Core;
using LogNameSpace;

namespace GrpcGreeter;

public class LogService : LogNameSpace.Logger.LoggerBase
{
    public override Task<LogResponse> Log(LogRequest request, ServerCallContext context)
    {
        return Task.FromResult(new LogResponse()
        {
            Success = true
        });
    }
}