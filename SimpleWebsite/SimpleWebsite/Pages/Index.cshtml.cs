using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace SimpleWebsite.Pages
{
    public class IndexModel : PageModel
    {
        public Layout layout { get; set; }

        private readonly IOptions<Layout> _layout;

        public IndexModel(IOptions<Layout> layout)
        {
            _layout = layout;
        }

        public void OnGet()
        {
            layout = _layout.Value;
        }
    }
}
