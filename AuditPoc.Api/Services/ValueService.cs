using AuditPoc.Api.Interfaces;
using AuditPoc.Api.Model;
using AuditPoc.Data.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuditPoc.Api.Services
{
    public class ValueService: IValueService
    {
        protected Data.Model.AuditPocContext auditPocContext;
        public ValueService(AuditPocContext auditPocContext)
        {
            this.auditPocContext = auditPocContext;
        }
        public Employee GetValues(int id)
        {
            var empGet = (from d in this.auditPocContext.Data.AsNoTracking()
                           where d.Id == id
                           select d).SingleOrDefault();

            var employee = new Employee()
            {
                Name = empGet.Name,
                Age = empGet.Age,
                EmpNo = empGet.Empno,
                Email = empGet.Email
            };
            return employee;
        }

        public int SaveValues(Employee employee)
        {
            var empSave = new AuditPoc.Data.Model.Data() 
            {
                Id = employee.Id,
                Name = employee.Name,
                Age = employee.Age,
                Empno = employee.EmpNo,
                Email = employee.Email
            };
            this.auditPocContext.Add(empSave);
            this.auditPocContext.SaveChanges();
            return empSave.Id;
        }
    }
}
