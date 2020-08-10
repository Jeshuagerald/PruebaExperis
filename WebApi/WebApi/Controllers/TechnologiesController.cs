using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DataBD;

namespace WebApi.Controllers
{
    [RoutePrefix("api/technologies")]
    public class TechnologiesController : ApiController
    {
        //Get the technologies associated to .Net
        [HttpGet]
        [Route("MicrosoftNet")]
        public IEnumerable<MicrosoftNet> GetMicrosoftNet()
        {
            using (TalentRecruitmentEntities talentRecruitment = new TalentRecruitmentEntities())
            {
                return talentRecruitment.MicrosoftNets.ToList();
            }
        }

        //Get the technologies associated to Java
        [HttpGet]
        [Route("OracleJava")]
        public IEnumerable<OracleJava> GetOracleJava()
        {
            using (TalentRecruitmentEntities talentRecruitment = new TalentRecruitmentEntities())
            {
                return talentRecruitment.OracleJavas.ToList();
            }
        }
    }
}
