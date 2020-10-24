using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace ClientInformation
{
  public class DataAccess
  {
    /*public Client GetClientByLastName(string lastName)
    {
      using (System.Data.IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("ClientDB")))
      {
        var output = connection.Query<Client>($"SELECT * FROM Client WHERE LastName = '{lastName}'").FirstOrDefault();
        return output;
      }
    }*/
    public List<Client> GetClientListByLastName(string lastName)
    {
      using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("ClientDB")))
      {
        var output = connection.Query<Client>($"SELECT * FROM ClientTable WHERE LastName LIKE  '{ lastName }%'").ToList();
        return output;
      }
    }

    public Client GetClientByID(string id)
    {
      using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("ClientDB")))
      {
        var output = connection.Query<Client>($"SELECT * FROM ClientTable WHERE ClientID =  '{ id }'").FirstOrDefault();
        return output;
      }
    }
  }
}
