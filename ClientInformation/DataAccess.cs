﻿using System;
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
        var output = connection.Query<Client>($"SELECT * FROM Client WHERE LastName LIKE  '{ lastName }%'").ToList();
        return output;
      }
    }

    public Client GetClientByID(string id)
    {
      using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("ClientDB")))
      {
        var output = connection.Query<Client>($"SELECT * FROM Client WHERE ClientID =  '{ id }'").FirstOrDefault();
        return output;
      }
    }
    public List<Client> GetClientListByFirstName(string firstname)
    {
      using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("ClientDB")))
      {
        var output = connection.Query<Client>($"SELECT * FROM Client WHERE FirstName LIKE  '{ firstname }%'").ToList();
        return output;
      }
    }
    public List<Client> GetClientListByPhoneNumber(string phonenumber)
    {
      using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("ClientDB")))
      {
        var output = connection.Query<Client>($"SELECT * FROM Client WHERE PhoneNumber LIKE  '{ phonenumber }%'").ToList();
        return output;
      }
    }
    public List<Client> GetClientListByEMail(string email)
    {
      using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("ClientDB")))
      {
        var output = connection.Query<Client>($"SELECT * FROM Client WHERE EMail LIKE  '{ email }%'").ToList();
        return output;
      }
    }
    public List<Client> GetClientListByAddress(string streetaddress)
    {
      using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("ClientDB")))
      {
        var output = connection.Query<Client>($"SELECT * FROM Client WHERE StreetAddress LIKE  '{ streetaddress }%'").ToList();
        return output;
      }
    }
    public bool UpdateClientInformation(string clientid, string firstname, string middleinitial, string lastname, string email,
      string city, string state, string postalcode, string streetaddress)
    {
      string sql = $"UPDATE Client SET FirstName = '{firstname}', MiddleInitial = '{middleinitial}', LastName = '{lastname}', " +
        $"EMail = '{email}', City = '{city}', State = '{state}', PostalCode = '{postalcode}'," +
        $"StreetAddress = '{streetaddress}' WHERE ClientID = '{clientid}'";

      using (var connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("ClientDB")))
      {
        var affectedRows = connection.Execute(sql);

        Console.WriteLine(affectedRows);
        if (affectedRows > 0)
          return true;

        return false;
      }
    }
    public bool AddNewClient(string clientid, string firstname, string middleinitial, string lastname, string email,
      string city, string state, string postalcode, string streetaddress)
    {
      string sql = $"INSERT INTO Client (ClientID, FirstName, MiddleInitial, LastName, EMail, " +
        $"StreetAddress, City, State, PostalCode) VALUES ('{clientid}', '{firstname}', '{middleinitial}', '{lastname}'," +
          $" '{email}', '{streetaddress}', '{city}', '{state}', '{postalcode}')";

      using (var connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("ClientDB")))
      {
        var affectedRows = connection.Execute(sql);

        Console.WriteLine(affectedRows);
        if (affectedRows > 0)
          return true;

        return false;
      }
    }
    public bool DeleteClientByID(string id)
    {
      /*using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("ClientDB")))
      {
        var output = connection.Query<Client>($"DELETE FROM Client WHERE ClientID =  '{ id }'").FirstOrDefault();
        return output;
      }*/
      string sql = $"DELETE FROM Client WHERE ClientID =  '{ id }'";

      using (var connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("ClientDB")))
      {
        var affectedRows = connection.Execute(sql);

        Console.WriteLine(affectedRows);
        if (affectedRows > 0)
          return true;

        return false;
      }
    }

    public List<Patient> GetPatientListByClientID(string clientid)
    {
      List<Patient> patientList = new List<Patient>();
      using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("ClientDB")))
      {
        var output = connection.Query<Patient>($"SELECT * FROM ClientPatientRelation WHERE ClientID LIKE  '{ clientid }%'").ToList();
        //var patientOutput = connection.Query<Patient>($"SELECT ");
        foreach (Patient pt in output)
        {
          var outputTwo = connection.Query<Patient>($"SELECT * FROM Patient WHERE Patient_ID = '{pt.Patient_ID}'").FirstOrDefault();
          patientList.Add((Patient)outputTwo);
        }
        return patientList;
      }
    }
    public List<Patient> GetPatientListDetailsByClientID(string clientid)
    {
      List<Patient> patientList = new List<Patient>();
      using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("ClientDB")))
      {
        var output = connection.Query<Patient>($"SELECT * FROM ClientPatientRelation WHERE ClientID LIKE  '{ clientid }%'").ToList();
        //var patientOutput = connection.Query<Patient>($"SELECT ");
        foreach (Patient pt in output)
        {
          var outputTwo = connection.Query<Patient>($"" +
            $"SELECT pt.Patient_ID, pt.Name, pt.Sex_ID, Sex.Sex, pt.Species_ID, sp.Species, pt.Breed_ID, br.Breed, pt.Weight " +
            $"FROM client " +
            $"INNER JOIN clientpatientrelation cpr ON cpr.clientid = client.clientid " +
            $"INNER JOIN patient pt ON pt.Patient_ID = cpr.patient_id " +
            $"INNER JOIN Sex ON Sex.Sex_ID = pt.Sex_ID " +
            $"INNER JOIN Species sp ON Sp.Species_ID = pt.Species_ID " +
            $"INNER JOIN Breed br ON br.Species_ID = sp.Species_ID AND br.Breed_ID = pt.Breed_ID " +
            $"WHERE pt.Patient_ID = '{pt.Patient_ID}'").FirstOrDefault();
          patientList.Add((Patient)outputTwo);
        }
        return patientList;
      }
    }
    public string GetNextPatient_ID()
    {
      using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("ClientDB")))
      {
        var output = connection.ExecuteScalar($"SELECT MAX(CAST(Patient_ID AS int))+1 FROM Patient");
        if (output != null)
        {
          return output.ToString();
        }
        return string.Empty;
      }
    }
  }
}
