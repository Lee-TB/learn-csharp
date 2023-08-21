using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClass
{
    internal partial class Employee {
        //constructor
        public Employee() {
            GenerateEmployeeId();
        }
        public Employee(int id, string name)
        {
            this.EmpId = id;
            this.Name = name;
        }

        public void DisplayEmpInfo()
        {
            Console.WriteLine(this.EmpId + " " + this.Name);
        }

        partial void GenerateEmployeeId()
        {
            this.EmpId = new Random().Next();
        }
    }
}
