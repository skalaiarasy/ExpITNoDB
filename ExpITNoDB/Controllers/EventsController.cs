using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ExpITNoDB.Controllers
{
    public class EventsController : Controller
    {
        public async Task<IActionResult> Index()
        {
            HttpClient client = new HttpClient();
            
            string apiUrl = "https://localhost:44394/api/EventMasters";

            var result = await client.GetStringAsync(apiUrl);


            return View(result);
        }
    }
}
