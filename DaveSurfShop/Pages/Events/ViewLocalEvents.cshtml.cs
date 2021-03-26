using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DaveSurfShop.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DaveSurfShop.MockData;

namespace DaveSurfShop.Pages.Events
{
    public class ViewLocalEventsModel : PageModel
    {
        public List<LocalEvent> Events;

        private DBGenericService<LocalEvent> Service;

        public ViewLocalEventsModel(DBGenericService<LocalEvent> service)
        {
            Service = service;

            if (Service.GetObjectsAsync().Result.ToList().Count <= 0)
            {
                MockData.MockData mockData = new MockData.MockData();
                foreach (var obj in mockData.GetEvents())
                {
                    Service.AddObjectAsync(obj);
                }
            }

            Events = Service.GetObjectsAsync().Result.ToList();
        }

        public IActionResult OnGet()
        {
            //Events = Service.GetObjectsAsync().Result.ToList();
            return Page();
        }
    }
}
