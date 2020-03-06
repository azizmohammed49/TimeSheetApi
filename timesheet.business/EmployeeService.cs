using System;
using System.Collections.Generic;
using System.Linq;
using timesheet.data;
using timesheet.model;

namespace timesheet.business
{
    public class EmployeeService : IDisposable
    {
        public TimesheetDb db { get; }
        public EmployeeService(TimesheetDb dbContext)
        {
            this.db = dbContext;
        }

        public IEnumerable<Employee> GetEmployees()
        {
            var emps = db.Employees.ToList();
            return emps;
        }

        public void Dispose()
        {
            db.Dispose();
        }
    }
}
