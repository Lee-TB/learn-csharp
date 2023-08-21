using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClass
{
    internal partial class Employee
    {
        public int EmpId { get; set; }
        public string Name { get; set; }

        partial void GenerateEmployeeId();
    }
}
