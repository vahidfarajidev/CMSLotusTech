using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Base.Services
{
    public interface IAppLogger
    {
        Task LogInformationAsync(string message, object? data = null);
        Task LogWarningAsync(string message, object? data = null);
        Task LogErrorAsync(string message, Exception exception, object? data = null);
        Task LogDebugAsync(string message, object? data = null);
    }
}
