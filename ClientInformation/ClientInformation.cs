﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientInformation
{
  public partial class ClientInformation : Form
  {
    List<Patient> patientList = new List<Patient>();
    public ClientInformation()
    {
      InitializeComponent();
      TxtClientID.Select();
    }

    public void UpdateBinding()
    {
      lstBxPatientList.DataSource = patientList;
      lstBxPatientList.DisplayMember = "PatientDisplayInfo";
      lstBxPatientList.ValueMember = "Patient_ID";
    }

    private void TxtClientID_MouseDoubleClick(object sender, MouseEventArgs e)
    {
      ClientSearch clientSearchDialog = new ClientSearch();
      clientSearchDialog.ShowDialog();
      if (!string.IsNullOrEmpty(clientSearchDialog.ClientID))
      {
        TxtClientID.Text = clientSearchDialog.ClientID;
        SetClientValues(TxtClientID.Text);
      }
      return;
    }
    
    private void SetClientValues(string clientid)
    {
      DataAccess dbAccess = new DataAccess();

      Client client = dbAccess.GetClientByID(clientid);

      TxtBxFirstName.Text = client.FirstName;
      TxtMiddleInitial.Text = client.MiddleInitial;
      TxtLastName.Text = client.LastName;
      TxtStreetAddress.Text = client.StreetAddress;
      TxtCity.Text = client.City;
      TxtState.Text = client.State;
      TxtPostalCode.Text = client.PostalCode;
      TxtEmail.Text = client.EMail;
      txtMskPhoneNumber.Text = client.PhoneNumber;

      patientList = dbAccess.GetPatientListDetailsByClientID(TxtClientID.Text);
      UpdateBinding();
    }

    private void btnUpdateClientInfo_MouseClick(object sender, MouseEventArgs e)
    {
      DataAccess dbUpdate = new DataAccess();
      bool result = false;

      result = dbUpdate.UpdateClientInformation(TxtClientID.Text, TxtBxFirstName.Text, TxtMiddleInitial.Text,
        TxtLastName.Text, TxtEmail.Text, TxtCity.Text, TxtState.Text, 
        TxtPostalCode.Text, TxtStreetAddress.Text, txtMskPhoneNumber.Text);
      MessageBox.Show(result.ToString());
    }

    private void btnAddClient_MouseClick(object sender, MouseEventArgs e)
    {
      DataAccess dbAdd = new DataAccess();
      bool result = false;

      result = dbAdd.AddNewClient(TxtClientID.Text, TxtBxFirstName.Text, TxtMiddleInitial.Text,
        TxtLastName.Text, TxtEmail.Text, TxtCity.Text, TxtState.Text,
        TxtPostalCode.Text, TxtStreetAddress.Text, txtMskPhoneNumber.Text);
      MessageBox.Show(result.ToString());
    }

    private void btnFindClient_MouseClick(object sender, MouseEventArgs e)
    {
      DataAccess dbAccess = new DataAccess();

      Client client = dbAccess.GetClientByID(TxtClientID.Text);

      TxtBxFirstName.Text = client.FirstName;
      TxtMiddleInitial.Text = client.MiddleInitial;
      TxtLastName.Text = client.LastName;
      TxtStreetAddress.Text = client.StreetAddress;
      TxtCity.Text = client.City;
      TxtState.Text = client.State;
      TxtPostalCode.Text = client.PostalCode;
      TxtEmail.Text = client.EMail;
      txtMskPhoneNumber.Text = client.PhoneNumber;
    }

    private void btnDeleteClient_Click(object sender, EventArgs e)
    {
      DataAccess dbDelete = new DataAccess();
      bool result = false;

      result = dbDelete.DeleteClientByID(TxtClientID.Text);
      MessageBox.Show(result.ToString());
    }

    private void ClientInformation_Load(object sender, EventArgs e)
    {

    }
    private void lstBxPatientList_MouseDoubleClick(object sender, MouseEventArgs e)
    {
      
      PatientInformation patientInformationDialog = new PatientInformation();
      patientInformationDialog.ClientID = TxtClientID.Text;
      patientInformationDialog.ClientLastName = TxtLastName.Text;
      patientInformationDialog.ClientFirstName = TxtBxFirstName.Text;
      patientInformationDialog.Patient_ID = lstBxPatientList.SelectedValue.ToString();
      patientInformationDialog.ShowDialog();
      if (!string.IsNullOrEmpty(patientInformationDialog.Patient_ID))
      {
        lstBxPatientList.Text = patientInformationDialog.Patient_ID;
        SetClientValues(TxtClientID.Text);
      }
      return;

    }
    
  }
}
