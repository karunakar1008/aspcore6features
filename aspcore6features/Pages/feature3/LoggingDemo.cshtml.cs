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
            try
            {
                int a = 10;
                int b = 0;
                int c = a / b;
            }
            catch (Exception exception)
            {
                _logger.LogTrace("1.Trace: Home page loaded");
                _logger.LogDebug("2. Debug: Home page loaded");
                _logger.LogInformation("3. Information: Home page loaded");
                _logger.LogWarning("4. Warning: Home page loaded");
                _logger.LogError("5. Error: Home page loaded");
                _logger.LogCritical("6. Critical: Home page loaded");
            }
           
        }
    }
}
