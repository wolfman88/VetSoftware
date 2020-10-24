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
      UpdateBinding();
    }

    private void UpdateBinding()
    {
      lstBxClientSearchResultDisplay.DataSource = clientList;
      lstBxClientSearchResultDisplay.DisplayMember = "FullInfo";
      lstBxClientSearchResultDisplay.ValueMember = "ClientID";
    }

    public void textBox1_TextChanged(object sender, EventArgs e)
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

    }
  }
}
