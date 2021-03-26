using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DaveSurfShop.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DaveSurfShop.Pages.Events
{
    public class ViewLocalEventsModel : PageModel
    {
        List<LocalEvent> Events;
        DBGenericService<LocalEvent> Service;

        public ViewLocalEventsModel(DBGenericService<LocalEvent> service)
        {
            Service = service;
        }

        public IActionResult OnGet()
        {
            Events = Service.GetObjectsAsync().Result.ToList();
            return Page();
        }
    }
}
