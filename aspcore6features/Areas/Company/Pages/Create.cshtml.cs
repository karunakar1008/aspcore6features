using aspcore6features.Areas.Company.Data;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace aspcore6features.Areas.Company.Pages
{
    public class CreateModel : PageModel
    {
        private readonly ICommonService _commonService;

        public CreateModel(ICommonService commonService)
        {
            this._commonService = commonService;
        }
        public string? Message { get; set; }
        public void OnGet()
        {
            Message = _commonService.DisplayMessage("karunakar");
        }
    }
}
