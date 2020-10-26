using System;
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
    public ClientInformation()
    {
      InitializeComponent();
      TxtClientID.Select();
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
    }

    private void btnUpdateClientInfo_MouseClick(object sender, MouseEventArgs e)
    {
      DataAccess dbUpdate = new DataAccess();
      bool result = false;

      result = dbUpdate.UpdateClientInformation(TxtClientID.Text, TxtBxFirstName.Text, TxtMiddleInitial.Text,
        TxtLastName.Text, TxtEmail.Text, TxtCity.Text, TxtState.Text, 
        TxtPostalCode.Text, TxtStreetAddress.Text);
      MessageBox.Show(result.ToString());
    }
    private void TxtClientID_Leave(object sender, EventArgs e)
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
    }
  }
}
