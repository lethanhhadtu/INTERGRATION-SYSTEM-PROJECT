using HRapii.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HRapii.Controllers
{
    public class PayrateController : ApiController
    {
        // GET: api/Payrate
        public IEnumerable<Payrate> Get()
        {
            MySqlConnection connection = Connection.Instance.ConnectPayrollDB();

            var listPayrate = new List<Payrate>();
            string query = "SELECT * FROM `pay_rates` ";

            MySqlCommand command = connection.CreateCommand();
            command.CommandText = query;

            try
            {
                connection.Open();
            }
            catch (MySqlException ex)
            { }

            MySqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                Payrate payrate = new Payrate(dataReader);
                listPayrate.Add(payrate);
            }

            connection.Close();
            return listPayrate;
        }

        // GET: api/Payrate/5
        public List<Payrate> Get(int id)
        {
            MySqlConnection connection = Connection.Instance.ConnectPayrollDB();

            var listPayrate = new List<Payrate>();
            string query = "SELECT * FROM `pay_rates` where idPay_Rates=" + id;

            MySqlCommand command = connection.CreateCommand();
            command.CommandText = query;

            try
            {
                connection.Open();
            }
            catch (MySqlException ex)
            { }

            MySqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                Payrate payrate = new Payrate(dataReader);
                listPayrate.Add(payrate);
            }

            connection.Close();
            return listPayrate;
        }

        // POST: api/Payrate
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Payrate/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Payrate/5
        public void Delete(int id)
        {
        }
    }
}
