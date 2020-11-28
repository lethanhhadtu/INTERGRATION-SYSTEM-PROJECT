using PersonalsDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HRapii.Controllers
{
    public class PersonalsController : ApiController
    {
        public IEnumerable<Personal> Get()
        {
            using (HREntities enitites = new HREntities())
            {
                return enitites.Personals.ToList();
            }

        }

        public Personal Get(int id)
        {
            using (HREntities enitites = new HREntities())
            {
                return enitites.Personals.FirstOrDefault(e => e.Employee_ID == id);
            }

        }
    }
}
