using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace aspcore6features.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IConfiguration _configuration;

        public IndexModel(ILogger<IndexModel> logger,IConfiguration configuration)
        {
            _logger = logger;
            this._configuration = configuration;
        }

        public void OnGet()
        {
            var myKeyValue= _configuration["MyKey"];
            var firstValue = _configuration["Nested:FirstValue"];
            var secondValue = _configuration["Nested:SecondValue"];
            ViewData["myKey"] = myKeyValue;
            ViewData["firstvalue"] = firstValue;
            //ViewBag.firstvalue= firstValue; //
            TempData["secondValue"] = secondValue;
        }
    }
}