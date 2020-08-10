using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using WebAppTalent.Models;

namespace WebAppTalent.Controllers
{
    public class TechnologiesController : Controller
    {
        //URL of API
        string BaseUrl = "https://localhost:44373";

        public ActionResult Index()
        {
            return View();
        }

        // GET: Technologies
        [HttpGet]
        public async Task<ActionResult> GetTechnologies(string tech)
        {
            string apiRest = "api/technologies/"+ tech +"/";
            List<Technologies> technologies = new List<Technologies>();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(BaseUrl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(
                    new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage Res = await client.GetAsync(apiRest);
                if (Res.IsSuccessStatusCode)
                {
                    var TechResponse = Res.Content.ReadAsStringAsync().Result;
                    technologies = JsonConvert.DeserializeObject<List<Technologies>>(TechResponse);
                }

                return PartialView("TechnologiesView", technologies);
            }
        }
    }
}