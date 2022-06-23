using MediatR.Pipeline;
using Microsoft.Extensions.Logging;
using System.Threading;
using System.Threading.Tasks;

namespace Travel.Application.Common.Behaviors
{
    public class LoggingBehavior<IRequest> : IRequestPreProcessor<IRequest>
    {
        private readonly ILogger _logger;

        public LoggingBehavior(ILogger<IRequest> logger)
        {
            _logger = logger;
        }
        public async Task Process(IRequest request, CancellationToken cancellationToken)
        {
            var requestName = typeof(IRequest).Name;
            _logger.LogInformation("Travel Request: {@Request}", requestName, request);
        }
    }
}
