using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuditPoc.Api.Model
{
    public class Employee
    {
        [JsonIgnore()]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("age")]
        public string Age { get; set; }
        [JsonProperty("empno")]
        public string EmpNo { get; set; }
        [JsonProperty("email")]
        public string Email { get; set; }
    }
}
