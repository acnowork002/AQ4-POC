using AuditPoc.Api.Interfaces;
using AuditPoc.Api.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuditPoc.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private IValueService valueService;
        public ValuesController(IValueService valueService)
        {
            this.valueService = valueService;
        }

        [HttpGet("GetValues")]
        [ProducesResponseType(200, Type = typeof(Employee))]
        public Employee GetValues(int id)
        {
            Employee employee = this.valueService.GetValues(id);
            return employee;
        }
        
        [HttpPost("SaveValues")]
        [ProducesResponseType(200, Type = typeof(int))]
        public int SaveValues(Employee employee)
        {
            int id = this.valueService.SaveValues(employee);
            return id;
        }
    }
}
