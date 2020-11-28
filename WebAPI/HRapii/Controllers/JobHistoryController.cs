using PersonalsDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HRapii.Controllers
{
    public class JobHistoryController : ApiController
    {

        public IEnumerable<Job_History> Get()
        {
            using (JobHistoryEntities entities = new JobHistoryEntities())
            {
                return entities.Job_History.ToList();
            }
        }

        public Job_History Get(int id)
        {
            using (JobHistoryEntities entities = new JobHistoryEntities())
            {
                return entities.Job_History.FirstOrDefault(e => e.Employee_ID == id);
            }
        }
    }
}
