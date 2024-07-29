using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMvc
{
    [AttributeUsage(AttributeTargets.Method)]
    public class ActionAttribute : Attribute
    {
        public string Name { get; set; } = string.Empty;
        public ActionAttribute() { }
        public ActionAttribute(string name) { 
            Name = name;
        }

    }
}
