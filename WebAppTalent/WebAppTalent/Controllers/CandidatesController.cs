using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using WebAppTalent.Models;

namespace WebAppTalent.Controllers
{
    public class CandidatesController : Controller
    {
        //URL of API
        string BaseUrlExternal = "http://jsonplaceholder.typicode.com";
        public ActionResult Index()
        {
            return View();
        }

        // GET: Candidates
        [HttpGet]
        public async Task<ActionResult> GetCandidates(int num)
        {
            string apiUsersExternal = "users";
            List<Candidates> candidates = new List<Candidates>();
            List<Candidates> candidatesTemp = new List<Candidates>();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(BaseUrlExternal);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(
                    new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage Res = await client.GetAsync(apiUsersExternal);
                if (Res.IsSuccessStatusCode)
                {
                    var UserResponse = Res.Content.ReadAsStringAsync().Result;
                    candidates = JsonConvert.DeserializeObject<List<Candidates>>(UserResponse);
                }

                if ((num % 2) == 0)
                {
                    foreach (var item in candidates)
                    {
                        if (item.id % 2 == 0)
                        {
                            candidatesTemp.Add(item);
                        }
                    }
                }
                else
                {
                    foreach (var item in candidates)
                    {
                        if (item.id % 2 != 0)
                        {
                            candidatesTemp.Add(item);
                        }
                    }
                }

                return PartialView("CandidatesView", candidatesTemp);
            }
        }
    }
}