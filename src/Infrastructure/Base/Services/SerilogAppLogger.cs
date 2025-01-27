using Application.Base.Logs;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Base.Logs
{
    public class SerilogAppLogger : IAppLogger
    {
        private readonly ILogger<SerilogAppLogger> _logger;

        public SerilogAppLogger(ILogger<SerilogAppLogger> logger)
        {
            _logger = logger;
        }

        public async Task LogInformationAsync(string message, object? data = null)
        {
            await Task.Run(() => _logger.LogInformation("{Message} | Data: {@Data}", message, data));
        }

        public async Task LogWarningAsync(string message, object? data = null)
        {
            await Task.Run(() => _logger.LogWarning("{Message} | Data: {@Data}", message, data));
        }

        public async Task LogErrorAsync(string message, Exception exception, object? data = null)
        {
            await Task.Run(() => _logger.LogError(exception, "{Message} | Data: {@Data}", message, data));
        }

        public async Task LogDebugAsync(string message, object? data = null)
        {
            await Task.Run(() => _logger.LogDebug("{Message} | Data: {@Data}", message, data));
        }
    }
}
