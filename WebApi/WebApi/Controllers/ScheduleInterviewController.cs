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
    [RoutePrefix("api/ScheduleInterview")]
    public class ScheduleInterviewController : ApiController
    {
        //Get all the interviews
        [HttpGet]
        public IEnumerable<ScheduleInterview> Get()
        {
            using (TalentRecruitmentEntities talentRecruitment = new TalentRecruitmentEntities())
            {
                return talentRecruitment.ScheduleInterviews.ToList();
            }
        }

        //Insert news ScheduleInterview
        [HttpPost]
        public IActionResult Post([FromBody] ScheduleInterview scheduleInterview)
        {
            try
            {
                using (TalentRecruitmentEntities talentRecruitment = new TalentRecruitmentEntities())
                {
                    talentRecruitment.ScheduleInterviews.Add(scheduleInterview);
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
