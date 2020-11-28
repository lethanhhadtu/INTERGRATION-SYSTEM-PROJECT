using HRapii.Models;
using MySql.Data.MySqlClient;
using PersonalsDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HRapii.Controllers
{
    public class EmployeeController : ApiController
    {
        // GET: api/Employee
        public IEnumerable<Employee> Get()
        {
            MySqlConnection connection = Connection.Instance.ConnectPayrollDB();

            var listEmployee = new List<Employee>();
            string query = "SELECT * FROM `employee`";

            MySqlCommand command = connection.CreateCommand();
            command.CommandText = query;

            try
            {
                connection.Open();
            }
            catch (MySqlException ex)
            {

            }

            MySqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                Employee employee = new Employee(dataReader);
                listEmployee.Add(employee);
            }

            connection.Close();
            return listEmployee;
        }

        // GET: api/Employee/5
        public List<Employee> Get(int id)
        {
            MySqlConnection connection = Connection.Instance.ConnectPayrollDB();

            var listEmployee = new List<Employee>();
            string query = "SELECT * FROM `employee` where idEmployee=" + id;

            MySqlCommand command = connection.CreateCommand();
            command.CommandText = query;

            try
            {
                connection.Open();
            }
            catch (MySqlException ex)
            {

            }

            MySqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                Employee employee = new Employee(dataReader);
                listEmployee.Add(employee);
            }

            connection.Close();
            return listEmployee;
        }

        // POST: api/Employee
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Employee/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Employee/5
        public void Delete(int id)
        {
        }

    }
}
