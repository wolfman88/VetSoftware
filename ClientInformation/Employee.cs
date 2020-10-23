using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientInformation
{
  class Employee
  {
    public Employee()
    {
    }

    public string ID { get; set; } // 0
    public string FirstName { get; set; } // 1
    public string MiddleInitial { get; set; } // 2
    public string LastName { get; set; } // 3
    public string EMail { get; set; } // 4
    public string PhoneNumber { get; set; } // 5
    public string City { get; set; } // 6 
    public string State { get; set; } // 7
    public string ZipCode { get; set; } // 8

    public Employee GetEmployee(string ID)
    {
      Employee emp = new Employee();
      return emp;
    }
  }
}
