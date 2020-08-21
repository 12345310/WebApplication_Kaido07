using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication_Kaido07.Models
{
    public class Repository
    {
        private static List<Employee> allEmpoyees = new List<Employee>();
        public static IEnumerable<Employee> AllEmpoyees
        {
            get { return allEmpoyees; }
        }
        public static void Create(Employee employee)
        {
            allEmpoyees.Add(employee);
        }
    }
}
