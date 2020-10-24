using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientInformation
{
  public class Client
  {
    public Client()
    {
    }

    public string ClientID { get; set; } // 0
    public string FirstName { get; set; } // 1
    public string MiddleInitial { get; set; } // 2
    public string LastName { get; set; } // 3
    public string EMail { get; set; } // 4
    public string PhoneNumber { get; set; } // 5
    public string City { get; set; } // 6 
    public string State { get; set; } // 7
    public string PostalCode { get; set; } // 8
    public string StreetAddress { get; set; } // 9

    public Client GetClient(string ID)
    {
      Client cl = new Client();
      return cl;
    }
    public string FullInfo
    {
      get
      {
        return $" [{ClientID}] | { FirstName } | { LastName } | {PhoneNumber} | ({ EMail })";
      }
    }
  }
}
