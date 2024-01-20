using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Moment1._1_razor.Pages
{
    public class RazorModel : PageModel
    {
        public string Code { get; set; }
        public string Name { get; set; }

        public RazorModel[] DataArray { get; set; }

        public void OnGet()
        {
            // Initialize the array within a method (OnGet)
            DataArray = new RazorModel[]
            {
                new RazorModel { Code = "Webbutveckling I", Name = "DT057G" },
                new RazorModel { Code = "Webbutveckling II", Name = "DT093G" },
                 new RazorModel { Code = "Webbutveckling III", Name = "DT173G" },
                new RazorModel { Code = "Fullstackutveckling med ramverk", Name = "DT071G" },
                 new RazorModel { Code = "Programmering i C#.NET", Name = "DT193G" },
                  new RazorModel { Code = "Databaser", Name = "DT003G" },

            };
        }
    }
}
