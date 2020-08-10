using DataBD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi.Controllers
{
    [RoutePrefix("api/InterviewMode")]
    public class InterviewModeController : ApiController
    {
        //Get the modes of interview
        [HttpGet]
        public IEnumerable<InterviewMode> Get()
        {
            using (TalentRecruitmentEntities talentRecruitment = new TalentRecruitmentEntities())
            {
                return talentRecruitment.InterviewModes.ToList();
            }
        }
    }
}
