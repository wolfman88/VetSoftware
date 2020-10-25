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
  public partial class ClientSearch : Form
  {
    List<Client> clientList = new List<Client>();
    public ClientSearch()
    {
      InitializeComponent();
      TxtClientLastName.Select();
      UpdateBinding();
    }

    private void UpdateBinding()
    {
      lstBxClientSearchResultDisplay.DataSource = clientList;
      lstBxClientSearchResultDisplay.DisplayMember = "FullInfo";
      lstBxClientSearchResultDisplay.ValueMember = "ClientID";
    }

    public void TxtClientLastName_TextChanged(object sender, EventArgs e)
    {
      //Client cl = new Client();

      DataAccess dbAccess = new DataAccess();

      clientList = dbAccess.GetClientListByLastName(TxtClientLastName.Text);
      UpdateBinding();
      return;
    }

    private void lstBxClientSearchResultDisplay_MouseDoubleClick(object sender, MouseEventArgs e)
    {
      //MessageBox.Show(lstBxClientSearchResultDisplay.SelectedValue.ToString());

      ClientID = lstBxClientSearchResultDisplay.SelectedValue.ToString();
      this.Close();
    }

    public string ClientID { get; set; }

    private void ClientSearch_Load(object sender, EventArgs e)
    {
      //TxtClientLastName.Focus();
    }

    private void TxtClientFirstName_TextChanged(object sender, EventArgs e)
    {
      DataAccess dbAccess = new DataAccess();

      clientList = dbAccess.GetClientListByFirstName(TxtClientFirstName.Text);
      UpdateBinding();
      return;
    }

    private void MaskTxtClientPhoneNumber_TextChanged(object sender, EventArgs e)
    {
      DataAccess dbAccess = new DataAccess();

      clientList = dbAccess.GetClientListByPhoneNumber(MaskTxtClientPhoneNumber.Text);
      UpdateBinding();
      return;
    }

    private void TxtClientEMail_TextChanged(object sender, EventArgs e)
    {
      DataAccess dbAccess = new DataAccess();

      clientList = dbAccess.GetClientListByEMail(TxtClientEMail.Text);
      UpdateBinding();
      return;
    }

    private void txtClientAddresssSearch_TextChanged(object sender, EventArgs e)
    {
      DataAccess dbAccess = new DataAccess();

      clientList = dbAccess.GetClientListByAddress(txtClientAddresssSearch.Text);
      UpdateBinding();
      return;
    }

    private void txtClientPhoneNumberSearch_TextChanged(object sender, EventArgs e)
    {

    }
  }
}
