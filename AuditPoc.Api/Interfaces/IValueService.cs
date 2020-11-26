using AuditPoc.Api.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuditPoc.Api.Interfaces
{
    public interface IValueService
    {
        Employee GetValues(int id);

        List<Employee> GetAllValues();

        int SaveValues(Employee employee);
    }
}
