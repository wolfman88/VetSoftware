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
  public partial class PatientInformation : Form
  {
    public PatientInformation()
    {
      InitializeComponent();
    }

    private void PatientInformation_Load(object sender, EventArgs e)
    {
      txtPatient_ID.Select();
    }

    private void txtPatient_ID_TextChanged(object sender, EventArgs e)
    {

    }
  }
}
