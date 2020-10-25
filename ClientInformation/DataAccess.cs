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
    public List<Client> GetClientListByFirstName(string firstname)
    {
      using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("ClientDB")))
      {
        var output = connection.Query<Client>($"SELECT * FROM ClientTable WHERE FirstName LIKE  '{ firstname }%'").ToList();
        return output;
      }
    }
    public List<Client> GetClientListByPhoneNumber(string phonenumber)
    {
      using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("ClientDB")))
      {
        var output = connection.Query<Client>($"SELECT * FROM ClientTable WHERE PhoneNumber LIKE  '{ phonenumber }%'").ToList();
        return output;
      }
    }
    public List<Client> GetClientListByEMail(string email)
    {
      using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("ClientDB")))
      {
        var output = connection.Query<Client>($"SELECT * FROM ClientTable WHERE EMail LIKE  '{ email }%'").ToList();
        return output;
      }
    }
    public List<Client> GetClientListByAddress(string streetaddress)
    {
      using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("ClientDB")))
      {
        var output = connection.Query<Client>($"SELECT * FROM ClientTable WHERE StreetAddress LIKE  '{ streetaddress }%'").ToList();
        return output;
      }
    }
    public List<Client> UpdateClientInformation(string clientid, string firstname, string middleinitial, string lastname, string email, 
      string phonenumber, string city, string state, string postalcode, string streetaddress)
    {
      using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("ClientDB")))
      {
        var output = connection.Query<Client>($"SELECT * FROM ClientTable WHERE StreetAddress LIKE  '{ streetaddress }%'").ToList();
        return output;
      }
    }
  }
}
