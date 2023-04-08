using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace aspcore6features.Pages
{
    public class DbConnectModel : PageModel
    {
        private readonly IConfiguration _configuration;

        public string? MyDbConnectionString { get; set; }
        public DbConnectModel(IConfiguration configuration)
        {

            _configuration = configuration;
        }
        public void OnGet()
        {
            var myKeyValue = _configuration["MyKey"];
            var firstValue = _configuration["Nested:FirstValue"];
            var secondValue = _configuration["Nested:SecondValue"];
            ViewData["myKey"] = myKeyValue;
            ViewData["firstvalue"] = firstValue;
            //ViewBag.firstvalue= firstValue; //
            TempData["secondValue"] = secondValue;

            MyDbConnectionString = _configuration["ConnectionStrings:DefaultConnection"];
        }
    }
}
