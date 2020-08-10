using DataBD;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi.Controllers
{
    [RoutePrefix("api/candidates")]
    public class CandidatesController : ApiController
    {
        //Insert news candidates
        [HttpPost]
        public IActionResult Post([FromBody] Candidate candidate)
        {
            try
            {
                using (TalentRecruitmentEntities talentRecruitment = new TalentRecruitmentEntities())
                {
                    talentRecruitment.Candidates.Add(candidate);
                    talentRecruitment.SaveChanges();
                    return (IActionResult)Ok();
                }
            }
            catch (Exception e)
            {
                return (IActionResult)BadRequest(e.Message);
                throw;
            }
        }
    }
}
