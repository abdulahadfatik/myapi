using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication1.Context;

namespace WebApplication1.Pages.Employee
{
    public class IndexModel : PageModel
    {
        private readonly CompanyContext _db;
        private CompanyContext db;

        public IndexModel(CompanyContext _db)
        {
            _db = db;
        }
        public void OnGet()
        {
        }
    }
}
