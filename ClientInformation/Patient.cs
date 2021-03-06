﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientInformation
{
  public class Patient
  {
    public Patient()
    {
    }
    public string Patient_ID { get; set; }
    public string Name { get; set; }
    public string Sex_ID { get; set; }
    public string Sex_Name { get; set; }
    public string Species_ID { get; set; }
    public string Species_Name { get; set; }
    public string Breed_ID { get; set; }
    public string Breed_Name { get; set; }
    public string Weight { get; set; }

    public Patient GetPatient(string P_ID)
    {
      Patient pat = new Patient();
      return pat;
    }
    public string PatientDisplayInfo
    {
      get
      {
        return $" [{Patient_ID}] | { Name } | { Sex_Name } | { Species_Name } |  {Breed_Name}";
      }
    }
  }
}
