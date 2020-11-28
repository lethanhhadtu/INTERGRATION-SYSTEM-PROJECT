using PersonalsDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HRapii.Controllers
{
    public class BenefitPlansController : ApiController
    {
        public IEnumerable<Benefit_Plans> Get()
        {
            using (BenefitPlansEntities entities = new BenefitPlansEntities())
            {
                return entities.Benefit_Plans.ToList();
            }
        }

        public Benefit_Plans Get(int id)
        {
            using (BenefitPlansEntities entities = new BenefitPlansEntities())
            {
                return entities.Benefit_Plans.FirstOrDefault(e => e.Benefit_Plan_ID == id);
            }
        }
    }
}
