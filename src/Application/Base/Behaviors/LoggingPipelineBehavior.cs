using System.Diagnostics;
using Application.Base.Logs;
using MediatR;
using System.Text.Json;
using Microsoft.Extensions.Logging;

namespace Application.Base.Behaviors
{
    public class LoggingPipelineBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
        where TRequest : IRequest<TResponse>
    {
        private readonly IAppLogger _logger;

        public LoggingPipelineBehavior(IAppLogger logger)
        {
            _logger = logger;
        }

        public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
        {
            var stopwatch = Stopwatch.StartNew();

            var requestName = typeof(TRequest).Name;
            var requestData = JsonSerializer.Serialize(request);

            try
            {
                var response = await next();

                stopwatch.Stop();

                await _logger.LogInformationAsync("Request completed", new
                {
                    request = new
                    {
                        name = requestName,
                        body = requestData
                    },
                    response = new
                    {
                        body = JsonSerializer.Serialize(response)
                    },
                    timestamp = DateTime.UtcNow,
                    durationMs = stopwatch.ElapsedMilliseconds
                });

                return response;
            }
            catch (Exception ex)
            {
                stopwatch.Stop();

                await _logger.LogErrorAsync("Request failed", ex, new
                {
                    request = new
                    {
                        name = requestName,
                        body = requestData
                    },
                    exception = new
                    {
                        message = ex.Message,
                        stackTrace = ex.StackTrace
                    },
                    timestamp = DateTime.UtcNow,
                    durationMs = stopwatch.ElapsedMilliseconds
                });

                throw;
            }
        }
    }
}
