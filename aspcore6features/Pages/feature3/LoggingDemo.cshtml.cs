using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace aspcore6features.Pages.feature3
{
    public class LoggingDemoModel : PageModel
    {
        private readonly ILogger<LoggingDemoModel> _logger;
        public LoggingDemoModel(ILogger<LoggingDemoModel> logger)
        {
            _logger = logger;
        }
        public void OnGet()
        {
            _logger.LogTrace("1.Trace: Home page is loaded");
            _logger.LogDebug("2. Debug: Home page is loaded");
            _logger.LogInformation("3. Information: Home page is loaded");
            _logger.LogWarning("4. Warning: Home page is loaded");
            _logger.LogError("5. Error: Home page is loaded");
            _logger.LogCritical("6. Critical: Home page is loaded");
        }
    }
}
