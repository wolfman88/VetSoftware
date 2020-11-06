namespace ClientInformation
{
  partial class Form_Patient_List
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.btnPatientListNewPatient = new System.Windows.Forms.Button();
      this.btnPatientListUpdate = new System.Windows.Forms.Button();
      this.btnPatientListDelete = new System.Windows.Forms.Button();
      this.btnPatientListSelect = new System.Windows.Forms.Button();
      this.btnPatientListClose = new System.Windows.Forms.Button();
      this.radBtnPatientListName = new System.Windows.Forms.RadioButton();
      this.radBtnPatientListID = new System.Windows.Forms.RadioButton();
      this.radBtnPatientListBreed = new System.Windows.Forms.RadioButton();
      this.radBtnPatientListMicrochipID = new System.Windows.Forms.RadioButton();
      this.grpBxPatientListSortBy = new System.Windows.Forms.GroupBox();
      this.grpBxPatientListPatientSearchCriteria = new System.Windows.Forms.GroupBox();
      this.grpBxPatientListClientInformation = new System.Windows.Forms.GroupBox();
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.Patient = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Patient_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Breed = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Owner = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.lblPatientListName = new System.Windows.Forms.Label();
      this.txtPatientListName = new System.Windows.Forms.TextBox();
      this.btnPatientListClear = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.txtPatientListID = new System.Windows.Forms.TextBox();
      this.checkBox1 = new System.Windows.Forms.CheckBox();
      this.lblPatientListClientID = new System.Windows.Forms.Label();
      this.txtPatientListClientID = new System.Windows.Forms.TextBox();
      this.grpBxPatientListSortBy.SuspendLayout();
      this.grpBxPatientListPatientSearchCriteria.SuspendLayout();
      this.grpBxPatientListClientInformation.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      this.SuspendLayout();
      // 
      // btnPatientListNewPatient
      // 
      this.btnPatientListNewPatient.BackColor = System.Drawing.Color.Silver;
      this.btnPatientListNewPatient.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnPatientListNewPatient.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.btnPatientListNewPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnPatientListNewPatient.Location = new System.Drawing.Point(863, 12);
      this.btnPatientListNewPatient.Name = "btnPatientListNewPatient";
      this.btnPatientListNewPatient.Size = new System.Drawing.Size(90, 29);
      this.btnPatientListNewPatient.TabIndex = 0;
      this.btnPatientListNewPatient.Text = "New";
      this.btnPatientListNewPatient.UseVisualStyleBackColor = false;
      // 
      // btnPatientListUpdate
      // 
      this.btnPatientListUpdate.BackColor = System.Drawing.Color.Silver;
      this.btnPatientListUpdate.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnPatientListUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.btnPatientListUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnPatientListUpdate.Location = new System.Drawing.Point(863, 55);
      this.btnPatientListUpdate.Name = "btnPatientListUpdate";
      this.btnPatientListUpdate.Size = new System.Drawing.Size(90, 29);
      this.btnPatientListUpdate.TabIndex = 1;
      this.btnPatientListUpdate.Text = "Update";
      this.btnPatientListUpdate.UseVisualStyleBackColor = false;
      // 
      // btnPatientListDelete
      // 
      this.btnPatientListDelete.BackColor = System.Drawing.Color.Silver;
      this.btnPatientListDelete.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnPatientListDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.btnPatientListDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnPatientListDelete.Location = new System.Drawing.Point(863, 99);
      this.btnPatientListDelete.Name = "btnPatientListDelete";
      this.btnPatientListDelete.Size = new System.Drawing.Size(90, 29);
      this.btnPatientListDelete.TabIndex = 2;
      this.btnPatientListDelete.Text = "Delete";
      this.btnPatientListDelete.UseVisualStyleBackColor = false;
      // 
      // btnPatientListSelect
      // 
      this.btnPatientListSelect.BackColor = System.Drawing.Color.Silver;
      this.btnPatientListSelect.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnPatientListSelect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.btnPatientListSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnPatientListSelect.Location = new System.Drawing.Point(863, 143);
      this.btnPatientListSelect.Name = "btnPatientListSelect";
      this.btnPatientListSelect.Size = new System.Drawing.Size(90, 29);
      this.btnPatientListSelect.TabIndex = 3;
      this.btnPatientListSelect.Text = "Select";
      this.btnPatientListSelect.UseVisualStyleBackColor = false;
      // 
      // btnPatientListClose
      // 
      this.btnPatientListClose.BackColor = System.Drawing.Color.Silver;
      this.btnPatientListClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnPatientListClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.btnPatientListClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnPatientListClose.Location = new System.Drawing.Point(863, 188);
      this.btnPatientListClose.Name = "btnPatientListClose";
      this.btnPatientListClose.Size = new System.Drawing.Size(90, 29);
      this.btnPatientListClose.TabIndex = 4;
      this.btnPatientListClose.Text = "Close";
      this.btnPatientListClose.UseVisualStyleBackColor = false;
      // 
      // radBtnPatientListName
      // 
      this.radBtnPatientListName.AutoSize = true;
      this.radBtnPatientListName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.radBtnPatientListName.Location = new System.Drawing.Point(24, 24);
      this.radBtnPatientListName.Name = "radBtnPatientListName";
      this.radBtnPatientListName.Size = new System.Drawing.Size(63, 21);
      this.radBtnPatientListName.TabIndex = 5;
      this.radBtnPatientListName.TabStop = true;
      this.radBtnPatientListName.Text = "Name";
      this.radBtnPatientListName.UseVisualStyleBackColor = true;
      // 
      // radBtnPatientListID
      // 
      this.radBtnPatientListID.AutoSize = true;
      this.radBtnPatientListID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.radBtnPatientListID.Location = new System.Drawing.Point(24, 44);
      this.radBtnPatientListID.Name = "radBtnPatientListID";
      this.radBtnPatientListID.Size = new System.Drawing.Size(39, 21);
      this.radBtnPatientListID.TabIndex = 6;
      this.radBtnPatientListID.TabStop = true;
      this.radBtnPatientListID.Text = "ID";
      this.radBtnPatientListID.UseVisualStyleBackColor = true;
      // 
      // radBtnPatientListBreed
      // 
      this.radBtnPatientListBreed.AutoSize = true;
      this.radBtnPatientListBreed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.radBtnPatientListBreed.Location = new System.Drawing.Point(24, 63);
      this.radBtnPatientListBreed.Name = "radBtnPatientListBreed";
      this.radBtnPatientListBreed.Size = new System.Drawing.Size(64, 21);
      this.radBtnPatientListBreed.TabIndex = 7;
      this.radBtnPatientListBreed.TabStop = true;
      this.radBtnPatientListBreed.Text = "Breed";
      this.radBtnPatientListBreed.UseVisualStyleBackColor = true;
      // 
      // radBtnPatientListMicrochipID
      // 
      this.radBtnPatientListMicrochipID.AutoSize = true;
      this.radBtnPatientListMicrochipID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.radBtnPatientListMicrochipID.Location = new System.Drawing.Point(24, 83);
      this.radBtnPatientListMicrochipID.Name = "radBtnPatientListMicrochipID";
      this.radBtnPatientListMicrochipID.Size = new System.Drawing.Size(103, 21);
      this.radBtnPatientListMicrochipID.TabIndex = 8;
      this.radBtnPatientListMicrochipID.TabStop = true;
      this.radBtnPatientListMicrochipID.Text = "Microchip ID";
      this.radBtnPatientListMicrochipID.UseVisualStyleBackColor = true;
      // 
      // grpBxPatientListSortBy
      // 
      this.grpBxPatientListSortBy.BackColor = System.Drawing.Color.LightGray;
      this.grpBxPatientListSortBy.Controls.Add(this.radBtnPatientListMicrochipID);
      this.grpBxPatientListSortBy.Controls.Add(this.radBtnPatientListBreed);
      this.grpBxPatientListSortBy.Controls.Add(this.radBtnPatientListID);
      this.grpBxPatientListSortBy.Controls.Add(this.radBtnPatientListName);
      this.grpBxPatientListSortBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.grpBxPatientListSortBy.ForeColor = System.Drawing.SystemColors.ControlText;
      this.grpBxPatientListSortBy.Location = new System.Drawing.Point(689, 14);
      this.grpBxPatientListSortBy.Name = "grpBxPatientListSortBy";
      this.grpBxPatientListSortBy.Size = new System.Drawing.Size(157, 108);
      this.grpBxPatientListSortBy.TabIndex = 9;
      this.grpBxPatientListSortBy.TabStop = false;
      this.grpBxPatientListSortBy.Text = "Sort By";
      // 
      // grpBxPatientListPatientSearchCriteria
      // 
      this.grpBxPatientListPatientSearchCriteria.BackColor = System.Drawing.Color.LightGray;
      this.grpBxPatientListPatientSearchCriteria.Controls.Add(this.checkBox1);
      this.grpBxPatientListPatientSearchCriteria.Controls.Add(this.txtPatientListID);
      this.grpBxPatientListPatientSearchCriteria.Controls.Add(this.label1);
      this.grpBxPatientListPatientSearchCriteria.Controls.Add(this.btnPatientListClear);
      this.grpBxPatientListPatientSearchCriteria.Controls.Add(this.txtPatientListName);
      this.grpBxPatientListPatientSearchCriteria.Controls.Add(this.lblPatientListName);
      this.grpBxPatientListPatientSearchCriteria.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.grpBxPatientListPatientSearchCriteria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.grpBxPatientListPatientSearchCriteria.Location = new System.Drawing.Point(11, 14);
      this.grpBxPatientListPatientSearchCriteria.Name = "grpBxPatientListPatientSearchCriteria";
      this.grpBxPatientListPatientSearchCriteria.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.grpBxPatientListPatientSearchCriteria.Size = new System.Drawing.Size(672, 108);
      this.grpBxPatientListPatientSearchCriteria.TabIndex = 10;
      this.grpBxPatientListPatientSearchCriteria.TabStop = false;
      this.grpBxPatientListPatientSearchCriteria.Text = "Patient search criteria";
      // 
      // grpBxPatientListClientInformation
      // 
      this.grpBxPatientListClientInformation.BackColor = System.Drawing.Color.LightGray;
      this.grpBxPatientListClientInformation.Controls.Add(this.txtPatientListClientID);
      this.grpBxPatientListClientInformation.Controls.Add(this.lblPatientListClientID);
      this.grpBxPatientListClientInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.grpBxPatientListClientInformation.Location = new System.Drawing.Point(11, 135);
      this.grpBxPatientListClientInformation.Name = "grpBxPatientListClientInformation";
      this.grpBxPatientListClientInformation.Size = new System.Drawing.Size(834, 52);
      this.grpBxPatientListClientInformation.TabIndex = 11;
      this.grpBxPatientListClientInformation.TabStop = false;
      this.grpBxPatientListClientInformation.Text = "Client information";
      // 
      // dataGridView1
      // 
      this.dataGridView1.BackgroundColor = System.Drawing.Color.LightGray;
      this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Patient,
            this.Patient_ID,
            this.Breed,
            this.Owner});
      this.dataGridView1.Location = new System.Drawing.Point(11, 209);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.Size = new System.Drawing.Size(834, 261);
      this.dataGridView1.TabIndex = 12;
      // 
      // Patient
      // 
      this.Patient.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
      this.Patient.HeaderText = "Patient";
      this.Patient.Name = "Patient";
      this.Patient.Width = 300;
      // 
      // Patient_ID
      // 
      this.Patient_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
      this.Patient_ID.HeaderText = "Patient ID";
      this.Patient_ID.Name = "Patient_ID";
      this.Patient_ID.Width = 90;
      // 
      // Breed
      // 
      this.Breed.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
      this.Breed.HeaderText = "Breed";
      this.Breed.Name = "Breed";
      this.Breed.Width = 200;
      // 
      // Owner
      // 
      this.Owner.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
      this.Owner.HeaderText = "Owner";
      this.Owner.Name = "Owner";
      this.Owner.Width = 200;
      // 
      // lblPatientListName
      // 
      this.lblPatientListName.AutoSize = true;
      this.lblPatientListName.Location = new System.Drawing.Point(61, 24);
      this.lblPatientListName.Name = "lblPatientListName";
      this.lblPatientListName.Size = new System.Drawing.Size(49, 17);
      this.lblPatientListName.TabIndex = 0;
      this.lblPatientListName.Text = "Name:";
      // 
      // txtPatientListName
      // 
      this.txtPatientListName.Location = new System.Drawing.Point(116, 21);
      this.txtPatientListName.Name = "txtPatientListName";
      this.txtPatientListName.Size = new System.Drawing.Size(323, 23);
      this.txtPatientListName.TabIndex = 1;
      // 
      // btnPatientListClear
      // 
      this.btnPatientListClear.Location = new System.Drawing.Point(445, 18);
      this.btnPatientListClear.Name = "btnPatientListClear";
      this.btnPatientListClear.Size = new System.Drawing.Size(85, 28);
      this.btnPatientListClear.TabIndex = 2;
      this.btnPatientListClear.Text = "Clear";
      this.btnPatientListClear.UseVisualStyleBackColor = true;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(85, 55);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(25, 17);
      this.label1.TabIndex = 3;
      this.label1.Text = "ID:";
      // 
      // txtPatientListID
      // 
      this.txtPatientListID.Location = new System.Drawing.Point(116, 52);
      this.txtPatientListID.Name = "txtPatientListID";
      this.txtPatientListID.Size = new System.Drawing.Size(96, 23);
      this.txtPatientListID.TabIndex = 4;
      // 
      // checkBox1
      // 
      this.checkBox1.AutoSize = true;
      this.checkBox1.Location = new System.Drawing.Point(445, 83);
      this.checkBox1.Name = "checkBox1";
      this.checkBox1.Size = new System.Drawing.Size(197, 21);
      this.checkBox1.TabIndex = 5;
      this.checkBox1.Text = "Include inactives/deceased";
      this.checkBox1.UseVisualStyleBackColor = true;
      // 
      // lblPatientListClientID
      // 
      this.lblPatientListClientID.AutoSize = true;
      this.lblPatientListClientID.Location = new System.Drawing.Point(4, 26);
      this.lblPatientListClientID.Name = "lblPatientListClientID";
      this.lblPatientListClientID.Size = new System.Drawing.Size(64, 17);
      this.lblPatientListClientID.TabIndex = 6;
      this.lblPatientListClientID.Text = "Client ID:";
      // 
      // txtPatientListClientID
      // 
      this.txtPatientListClientID.Location = new System.Drawing.Point(74, 23);
      this.txtPatientListClientID.Name = "txtPatientListClientID";
      this.txtPatientListClientID.Size = new System.Drawing.Size(102, 23);
      this.txtPatientListClientID.TabIndex = 6;
      // 
      // Form_Patient_List
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.ControlLight;
      this.CancelButton = this.btnPatientListDelete;
      this.ClientSize = new System.Drawing.Size(964, 479);
      this.Controls.Add(this.dataGridView1);
      this.Controls.Add(this.grpBxPatientListClientInformation);
      this.Controls.Add(this.grpBxPatientListPatientSearchCriteria);
      this.Controls.Add(this.grpBxPatientListSortBy);
      this.Controls.Add(this.btnPatientListClose);
      this.Controls.Add(this.btnPatientListSelect);
      this.Controls.Add(this.btnPatientListDelete);
      this.Controls.Add(this.btnPatientListUpdate);
      this.Controls.Add(this.btnPatientListNewPatient);
      this.Name = "Form_Patient_List";
      this.Text = "Patient List";
      this.grpBxPatientListSortBy.ResumeLayout(false);
      this.grpBxPatientListSortBy.PerformLayout();
      this.grpBxPatientListPatientSearchCriteria.ResumeLayout(false);
      this.grpBxPatientListPatientSearchCriteria.PerformLayout();
      this.grpBxPatientListClientInformation.ResumeLayout(false);
      this.grpBxPatientListClientInformation.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btnPatientListNewPatient;
    private System.Windows.Forms.Button btnPatientListUpdate;
    private System.Windows.Forms.Button btnPatientListDelete;
    private System.Windows.Forms.Button btnPatientListSelect;
    private System.Windows.Forms.Button btnPatientListClose;
    private System.Windows.Forms.RadioButton radBtnPatientListName;
    private System.Windows.Forms.RadioButton radBtnPatientListID;
    private System.Windows.Forms.RadioButton radBtnPatientListBreed;
    private System.Windows.Forms.RadioButton radBtnPatientListMicrochipID;
    private System.Windows.Forms.GroupBox grpBxPatientListSortBy;
    private System.Windows.Forms.GroupBox grpBxPatientListPatientSearchCriteria;
    private System.Windows.Forms.GroupBox grpBxPatientListClientInformation;
    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.DataGridViewTextBoxColumn Patient;
    private System.Windows.Forms.DataGridViewTextBoxColumn Patient_ID;
    private System.Windows.Forms.DataGridViewTextBoxColumn Breed;
    private System.Windows.Forms.DataGridViewTextBoxColumn Owner;
    private System.Windows.Forms.CheckBox checkBox1;
    private System.Windows.Forms.TextBox txtPatientListID;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button btnPatientListClear;
    private System.Windows.Forms.TextBox txtPatientListName;
    private System.Windows.Forms.Label lblPatientListName;
    private System.Windows.Forms.TextBox txtPatientListClientID;
    private System.Windows.Forms.Label lblPatientListClientID;
  }
}