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
      GetListValues();
    }
    public PatientInformation(string patient_id)
    {
      InitializeComponent();
    }
    public string Patient_ID { get; set; }
    public string ClientID { get; set; }
    public string ClientLastName { get; set; }
    public string ClientFirstName { get; set; }

    private List<Breed> breedValues = new List<Breed>();
    private void PatientInformation_Load(object sender, EventArgs e)
    {
      txtPatient_ID.Select();
      SetPatientValues();

    }
    private void SetPatientValues()
    {
      DataAccess dbAccess = new DataAccess();

      Patient patient = dbAccess.GetPatientByID(Patient_ID);
      if (patient != null)
      {
        txtClientIDBinding.Text = ClientID;
        lblPatientClientID.Text = $"({ClientLastName}, {ClientFirstName})";
        txtPatient_ID.Text = patient.Patient_ID;
        txtPatientName.Text = patient.Name;
        cboBxPatientSex.SelectedValue = patient.Sex_ID;
        cboBxPatientSpecies.SelectedValue = patient.Species_ID;

        List<Breed> filteredBreeds = breedValues.Where(x => x.Species_ID == patient.Species_ID).ToList();
        cboBxPatientBreed.DataSource = filteredBreeds;
        cboBxPatientBreed.DisplayMember = "Breed_Name";
        cboBxPatientBreed.ValueMember = "Breed_ID";

        cboBxPatientBreed.SelectedValue = patient.Breed_ID;
      }
    }
    private void GetListValues()
    {
      DataAccess dbAccess = new DataAccess();
      List<Species> speciesValues = dbAccess.GetPatientSpeciesValues();
      List<Sex> sexValues = dbAccess.GetPatientSexValues();
      breedValues = dbAccess.GetPateintBreedValues();

      cboBxPatientSpecies.DataSource = speciesValues;
      cboBxPatientSpecies.DisplayMember = "Species_Name";
      cboBxPatientSpecies.ValueMember = "Species_ID";

      cboBxPatientSex.DataSource = sexValues;
      cboBxPatientSex.DisplayMember = "Sex_Name";
      cboBxPatientSex.ValueMember = "Sex_ID";

      cboBxPatientBreed.DataSource = breedValues;
      cboBxPatientBreed.DisplayMember = "Breed_Name";
      cboBxPatientBreed.ValueMember = "Breed_ID";

    }

    private void btnAddClient_MouseClick(object sender, MouseEventArgs e)
    {
      DataAccess dbAdd = new DataAccess();
      bool result = false;

      result = dbAdd.AddNewPatient(txtPatient_ID.Text, txtPatientName.Text, cboBxPatientSex.ValueMember,
        cboBxPatientSpecies.ValueMember, cboBxPatientBreed.ValueMember, txtClientIDBinding.Text);
      MessageBox.Show(result.ToString());
    }

    private void btnPatientFormCancel_MouseClick(object sender, MouseEventArgs e)
    {
      this.Close();
    }
  }
}
