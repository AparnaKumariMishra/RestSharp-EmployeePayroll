using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Newtonsoft.Json.Linq;
using RestSharp;

namespace Emp4
{
    internal class RSEMP4
    {
        public class Employee
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Salary { get; set; }
        }
        public class Operation
        {
            RestClient restClient = new RestClient("http://localhost:4000");

            public void UpdateEmployeeSalary()
            {
                RestRequest rq = new RestRequest("/employee/109", Method.Put);
                JObject jb = new JObject();
                jb.Add("name", "III");
                jb.Add("salary", "11000");
                rq.AddOrUpdateParameter("application/json", jb, ParameterType.RequestBody);

                RestResponse rr = restClient.Put(rq);
            }
        }
        public class RSEmp4
        {
            static void Main(string[] args)
            {
                Operation obj = new Operation();
                obj.UpdateEmployeeSalary();
            }
        }
    }
}
