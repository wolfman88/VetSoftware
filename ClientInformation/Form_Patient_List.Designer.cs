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
      this.radioButton1 = new System.Windows.Forms.RadioButton();
      this.radioButton2 = new System.Windows.Forms.RadioButton();
      this.radioButton3 = new System.Windows.Forms.RadioButton();
      this.radioButton4 = new System.Windows.Forms.RadioButton();
      this.grpBxPatientListSortBy = new System.Windows.Forms.GroupBox();
      this.grpBxPatientListPatientSearchCriteria = new System.Windows.Forms.GroupBox();
      this.grpBxPatientListClientInformation = new System.Windows.Forms.GroupBox();
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.Patient = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Patient_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Breed = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Owner = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.grpBxPatientListSortBy.SuspendLayout();
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
      // radioButton1
      // 
      this.radioButton1.AutoSize = true;
      this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.radioButton1.Location = new System.Drawing.Point(24, 24);
      this.radioButton1.Name = "radioButton1";
      this.radioButton1.Size = new System.Drawing.Size(107, 21);
      this.radioButton1.TabIndex = 5;
      this.radioButton1.TabStop = true;
      this.radioButton1.Text = "radioButton1";
      this.radioButton1.UseVisualStyleBackColor = true;
      // 
      // radioButton2
      // 
      this.radioButton2.AutoSize = true;
      this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.radioButton2.Location = new System.Drawing.Point(24, 51);
      this.radioButton2.Name = "radioButton2";
      this.radioButton2.Size = new System.Drawing.Size(107, 21);
      this.radioButton2.TabIndex = 6;
      this.radioButton2.TabStop = true;
      this.radioButton2.Text = "radioButton2";
      this.radioButton2.UseVisualStyleBackColor = true;
      // 
      // radioButton3
      // 
      this.radioButton3.AutoSize = true;
      this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.radioButton3.Location = new System.Drawing.Point(24, 78);
      this.radioButton3.Name = "radioButton3";
      this.radioButton3.Size = new System.Drawing.Size(107, 21);
      this.radioButton3.TabIndex = 7;
      this.radioButton3.TabStop = true;
      this.radioButton3.Text = "radioButton3";
      this.radioButton3.UseVisualStyleBackColor = true;
      // 
      // radioButton4
      // 
      this.radioButton4.AutoSize = true;
      this.radioButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.radioButton4.Location = new System.Drawing.Point(24, 105);
      this.radioButton4.Name = "radioButton4";
      this.radioButton4.Size = new System.Drawing.Size(107, 21);
      this.radioButton4.TabIndex = 8;
      this.radioButton4.TabStop = true;
      this.radioButton4.Text = "radioButton4";
      this.radioButton4.UseVisualStyleBackColor = true;
      // 
      // grpBxPatientListSortBy
      // 
      this.grpBxPatientListSortBy.BackColor = System.Drawing.Color.LightGray;
      this.grpBxPatientListSortBy.Controls.Add(this.radioButton4);
      this.grpBxPatientListSortBy.Controls.Add(this.radioButton3);
      this.grpBxPatientListSortBy.Controls.Add(this.radioButton2);
      this.grpBxPatientListSortBy.Controls.Add(this.radioButton1);
      this.grpBxPatientListSortBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.grpBxPatientListSortBy.ForeColor = System.Drawing.SystemColors.ControlText;
      this.grpBxPatientListSortBy.Location = new System.Drawing.Point(689, 20);
      this.grpBxPatientListSortBy.Name = "grpBxPatientListSortBy";
      this.grpBxPatientListSortBy.Size = new System.Drawing.Size(157, 137);
      this.grpBxPatientListSortBy.TabIndex = 9;
      this.grpBxPatientListSortBy.TabStop = false;
      this.grpBxPatientListSortBy.Text = "Sort By";
      // 
      // grpBxPatientListPatientSearchCriteria
      // 
      this.grpBxPatientListPatientSearchCriteria.BackColor = System.Drawing.Color.LightGray;
      this.grpBxPatientListPatientSearchCriteria.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.grpBxPatientListPatientSearchCriteria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.grpBxPatientListPatientSearchCriteria.Location = new System.Drawing.Point(11, 20);
      this.grpBxPatientListPatientSearchCriteria.Name = "grpBxPatientListPatientSearchCriteria";
      this.grpBxPatientListPatientSearchCriteria.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.grpBxPatientListPatientSearchCriteria.Size = new System.Drawing.Size(672, 137);
      this.grpBxPatientListPatientSearchCriteria.TabIndex = 10;
      this.grpBxPatientListPatientSearchCriteria.TabStop = false;
      this.grpBxPatientListPatientSearchCriteria.Text = "Patient search criteria";
      // 
      // grpBxPatientListClientInformation
      // 
      this.grpBxPatientListClientInformation.BackColor = System.Drawing.Color.LightGray;
      this.grpBxPatientListClientInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.grpBxPatientListClientInformation.Location = new System.Drawing.Point(11, 168);
      this.grpBxPatientListClientInformation.Name = "grpBxPatientListClientInformation";
      this.grpBxPatientListClientInformation.Size = new System.Drawing.Size(834, 52);
      this.grpBxPatientListClientInformation.TabIndex = 11;
      this.grpBxPatientListClientInformation.TabStop = false;
      this.grpBxPatientListClientInformation.Text = "Client information";
      // 
      // dataGridView1
      // 
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Patient,
            this.Patient_ID,
            this.Breed,
            this.Owner});
      this.dataGridView1.Location = new System.Drawing.Point(11, 226);
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
      // Form_Patient_List
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.ControlLight;
      this.CancelButton = this.btnPatientListDelete;
      this.ClientSize = new System.Drawing.Size(964, 524);
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
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btnPatientListNewPatient;
    private System.Windows.Forms.Button btnPatientListUpdate;
    private System.Windows.Forms.Button btnPatientListDelete;
    private System.Windows.Forms.Button btnPatientListSelect;
    private System.Windows.Forms.Button btnPatientListClose;
    private System.Windows.Forms.RadioButton radioButton1;
    private System.Windows.Forms.RadioButton radioButton2;
    private System.Windows.Forms.RadioButton radioButton3;
    private System.Windows.Forms.RadioButton radioButton4;
    private System.Windows.Forms.GroupBox grpBxPatientListSortBy;
    private System.Windows.Forms.GroupBox grpBxPatientListPatientSearchCriteria;
    private System.Windows.Forms.GroupBox grpBxPatientListClientInformation;
    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.DataGridViewTextBoxColumn Patient;
    private System.Windows.Forms.DataGridViewTextBoxColumn Patient_ID;
    private System.Windows.Forms.DataGridViewTextBoxColumn Breed;
    private System.Windows.Forms.DataGridViewTextBoxColumn Owner;
  }
}