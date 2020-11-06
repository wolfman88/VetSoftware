namespace ClientInformation
{
  partial class Form_Client_Information
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
      this.grpBxClientIDBalance = new System.Windows.Forms.GroupBox();
      this.tabClientInformationWindow = new System.Windows.Forms.TabControl();
      this.tabPage1 = new System.Windows.Forms.TabPage();
      this.grpBxPatients = new System.Windows.Forms.GroupBox();
      this.grpBxPhones = new System.Windows.Forms.GroupBox();
      this.grpBxInformation = new System.Windows.Forms.GroupBox();
      this.comBxStatus = new System.Windows.Forms.ComboBox();
      this.lblStatus = new System.Windows.Forms.Label();
      this.tabPage2 = new System.Windows.Forms.TabPage();
      this.btnClientInformationOK = new System.Windows.Forms.Button();
      this.btnClientInformationCancel = new System.Windows.Forms.Button();
      this.lblClientIDTag = new System.Windows.Forms.Label();
      this.lblClientID = new System.Windows.Forms.Label();
      this.lblClientName = new System.Windows.Forms.Label();
      this.lblClientInformationClientBalancetag = new System.Windows.Forms.Label();
      this.lblClientInformationBalance = new System.Windows.Forms.Label();
      this.lblClassification = new System.Windows.Forms.Label();
      this.comBxClassification = new System.Windows.Forms.ComboBox();
      this.lblType = new System.Windows.Forms.Label();
      this.comboBox2 = new System.Windows.Forms.ComboBox();
      this.label1 = new System.Windows.Forms.Label();
      this.grpBxClientIDBalance.SuspendLayout();
      this.tabClientInformationWindow.SuspendLayout();
      this.tabPage1.SuspendLayout();
      this.grpBxInformation.SuspendLayout();
      this.SuspendLayout();
      // 
      // grpBxClientIDBalance
      // 
      this.grpBxClientIDBalance.Controls.Add(this.lblClientInformationBalance);
      this.grpBxClientIDBalance.Controls.Add(this.lblClientInformationClientBalancetag);
      this.grpBxClientIDBalance.Controls.Add(this.lblClientName);
      this.grpBxClientIDBalance.Controls.Add(this.lblClientID);
      this.grpBxClientIDBalance.Controls.Add(this.lblClientIDTag);
      this.grpBxClientIDBalance.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.grpBxClientIDBalance.Location = new System.Drawing.Point(8, 8);
      this.grpBxClientIDBalance.Name = "grpBxClientIDBalance";
      this.grpBxClientIDBalance.Size = new System.Drawing.Size(869, 47);
      this.grpBxClientIDBalance.TabIndex = 0;
      this.grpBxClientIDBalance.TabStop = false;
      // 
      // tabClientInformationWindow
      // 
      this.tabClientInformationWindow.Controls.Add(this.tabPage1);
      this.tabClientInformationWindow.Controls.Add(this.tabPage2);
      this.tabClientInformationWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tabClientInformationWindow.Location = new System.Drawing.Point(8, 61);
      this.tabClientInformationWindow.Name = "tabClientInformationWindow";
      this.tabClientInformationWindow.SelectedIndex = 0;
      this.tabClientInformationWindow.Size = new System.Drawing.Size(873, 578);
      this.tabClientInformationWindow.TabIndex = 1;
      // 
      // tabPage1
      // 
      this.tabPage1.BackColor = System.Drawing.Color.Silver;
      this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.tabPage1.Controls.Add(this.grpBxPatients);
      this.tabPage1.Controls.Add(this.grpBxPhones);
      this.tabPage1.Controls.Add(this.grpBxInformation);
      this.tabPage1.Location = new System.Drawing.Point(4, 25);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage1.Size = new System.Drawing.Size(865, 549);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "Information";
      // 
      // grpBxPatients
      // 
      this.grpBxPatients.FlatStyle = System.Windows.Forms.FlatStyle.System;
      this.grpBxPatients.Location = new System.Drawing.Point(6, 400);
      this.grpBxPatients.Name = "grpBxPatients";
      this.grpBxPatients.Size = new System.Drawing.Size(846, 139);
      this.grpBxPatients.TabIndex = 2;
      this.grpBxPatients.TabStop = false;
      this.grpBxPatients.Text = "Patients";
      // 
      // grpBxPhones
      // 
      this.grpBxPhones.FlatStyle = System.Windows.Forms.FlatStyle.System;
      this.grpBxPhones.Location = new System.Drawing.Point(6, 271);
      this.grpBxPhones.Name = "grpBxPhones";
      this.grpBxPhones.Size = new System.Drawing.Size(846, 123);
      this.grpBxPhones.TabIndex = 1;
      this.grpBxPhones.TabStop = false;
      this.grpBxPhones.Text = "Phones";
      // 
      // grpBxInformation
      // 
      this.grpBxInformation.Controls.Add(this.label1);
      this.grpBxInformation.Controls.Add(this.comboBox2);
      this.grpBxInformation.Controls.Add(this.lblType);
      this.grpBxInformation.Controls.Add(this.comBxClassification);
      this.grpBxInformation.Controls.Add(this.lblClassification);
      this.grpBxInformation.Controls.Add(this.comBxStatus);
      this.grpBxInformation.Controls.Add(this.lblStatus);
      this.grpBxInformation.FlatStyle = System.Windows.Forms.FlatStyle.System;
      this.grpBxInformation.Location = new System.Drawing.Point(6, 9);
      this.grpBxInformation.Name = "grpBxInformation";
      this.grpBxInformation.Size = new System.Drawing.Size(846, 256);
      this.grpBxInformation.TabIndex = 0;
      this.grpBxInformation.TabStop = false;
      this.grpBxInformation.Text = "Information";
      // 
      // comBxStatus
      // 
      this.comBxStatus.FormattingEnabled = true;
      this.comBxStatus.Location = new System.Drawing.Point(81, 16);
      this.comBxStatus.Name = "comBxStatus";
      this.comBxStatus.Size = new System.Drawing.Size(87, 24);
      this.comBxStatus.TabIndex = 1;
      // 
      // lblStatus
      // 
      this.lblStatus.AutoSize = true;
      this.lblStatus.Location = new System.Drawing.Point(23, 19);
      this.lblStatus.Name = "lblStatus";
      this.lblStatus.Size = new System.Drawing.Size(52, 17);
      this.lblStatus.TabIndex = 0;
      this.lblStatus.Text = "Status:";
      // 
      // tabPage2
      // 
      this.tabPage2.BackColor = System.Drawing.SystemColors.ControlLight;
      this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.tabPage2.Location = new System.Drawing.Point(4, 25);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage2.Size = new System.Drawing.Size(865, 549);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "tabPage2";
      // 
      // btnClientInformationOK
      // 
      this.btnClientInformationOK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.btnClientInformationOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnClientInformationOK.Location = new System.Drawing.Point(903, 12);
      this.btnClientInformationOK.Name = "btnClientInformationOK";
      this.btnClientInformationOK.Size = new System.Drawing.Size(81, 25);
      this.btnClientInformationOK.TabIndex = 2;
      this.btnClientInformationOK.Text = "OK";
      this.btnClientInformationOK.UseVisualStyleBackColor = true;
      // 
      // btnClientInformationCancel
      // 
      this.btnClientInformationCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.btnClientInformationCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnClientInformationCancel.Location = new System.Drawing.Point(903, 50);
      this.btnClientInformationCancel.Name = "btnClientInformationCancel";
      this.btnClientInformationCancel.Size = new System.Drawing.Size(81, 25);
      this.btnClientInformationCancel.TabIndex = 3;
      this.btnClientInformationCancel.Text = "Cancel";
      this.btnClientInformationCancel.UseVisualStyleBackColor = true;
      // 
      // lblClientIDTag
      // 
      this.lblClientIDTag.AutoSize = true;
      this.lblClientIDTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblClientIDTag.Location = new System.Drawing.Point(6, 16);
      this.lblClientIDTag.Name = "lblClientIDTag";
      this.lblClientIDTag.Size = new System.Drawing.Size(60, 16);
      this.lblClientIDTag.TabIndex = 0;
      this.lblClientIDTag.Text = "Client ID:";
      // 
      // lblClientID
      // 
      this.lblClientID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.lblClientID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblClientID.Location = new System.Drawing.Point(72, 16);
      this.lblClientID.Name = "lblClientID";
      this.lblClientID.Size = new System.Drawing.Size(80, 16);
      this.lblClientID.TabIndex = 1;
      // 
      // lblClientName
      // 
      this.lblClientName.AutoSize = true;
      this.lblClientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblClientName.Location = new System.Drawing.Point(158, 16);
      this.lblClientName.Name = "lblClientName";
      this.lblClientName.Size = new System.Drawing.Size(15, 16);
      this.lblClientName.TabIndex = 2;
      this.lblClientName.Text = "_";
      // 
      // lblClientInformationClientBalancetag
      // 
      this.lblClientInformationClientBalancetag.AutoSize = true;
      this.lblClientInformationClientBalancetag.Location = new System.Drawing.Point(622, 18);
      this.lblClientInformationClientBalancetag.Name = "lblClientInformationClientBalancetag";
      this.lblClientInformationClientBalancetag.Size = new System.Drawing.Size(77, 13);
      this.lblClientInformationClientBalancetag.TabIndex = 3;
      this.lblClientInformationClientBalancetag.Text = "Client balance:";
      // 
      // lblClientInformationBalance
      // 
      this.lblClientInformationBalance.AutoSize = true;
      this.lblClientInformationBalance.Location = new System.Drawing.Point(705, 19);
      this.lblClientInformationBalance.Name = "lblClientInformationBalance";
      this.lblClientInformationBalance.Size = new System.Drawing.Size(13, 13);
      this.lblClientInformationBalance.TabIndex = 4;
      this.lblClientInformationBalance.Text = "_";
      // 
      // lblClassification
      // 
      this.lblClassification.AutoSize = true;
      this.lblClassification.Location = new System.Drawing.Point(192, 19);
      this.lblClassification.Name = "lblClassification";
      this.lblClassification.Size = new System.Drawing.Size(94, 17);
      this.lblClassification.TabIndex = 2;
      this.lblClassification.Text = "Classification:";
      // 
      // comBxClassification
      // 
      this.comBxClassification.FormattingEnabled = true;
      this.comBxClassification.Location = new System.Drawing.Point(292, 16);
      this.comBxClassification.Name = "comBxClassification";
      this.comBxClassification.Size = new System.Drawing.Size(292, 24);
      this.comBxClassification.TabIndex = 3;
      // 
      // lblType
      // 
      this.lblType.AutoSize = true;
      this.lblType.Location = new System.Drawing.Point(646, 19);
      this.lblType.Name = "lblType";
      this.lblType.Size = new System.Drawing.Size(44, 17);
      this.lblType.TabIndex = 4;
      this.lblType.Text = "Type:";
      // 
      // comboBox2
      // 
      this.comboBox2.FormattingEnabled = true;
      this.comboBox2.Location = new System.Drawing.Point(696, 16);
      this.comboBox2.Name = "comboBox2";
      this.comboBox2.Size = new System.Drawing.Size(121, 24);
      this.comboBox2.TabIndex = 5;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(6, 48);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(35, 17);
      this.label1.TabIndex = 6;
      this.label1.Text = "Title";
      // 
      // Form_Client_Information
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.ControlLight;
      this.ClientSize = new System.Drawing.Size(996, 666);
      this.Controls.Add(this.btnClientInformationCancel);
      this.Controls.Add(this.btnClientInformationOK);
      this.Controls.Add(this.tabClientInformationWindow);
      this.Controls.Add(this.grpBxClientIDBalance);
      this.Name = "Form_Client_Information";
      this.Text = "Form_Client_Information";
      this.grpBxClientIDBalance.ResumeLayout(false);
      this.grpBxClientIDBalance.PerformLayout();
      this.tabClientInformationWindow.ResumeLayout(false);
      this.tabPage1.ResumeLayout(false);
      this.grpBxInformation.ResumeLayout(false);
      this.grpBxInformation.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox grpBxClientIDBalance;
    private System.Windows.Forms.TabControl tabClientInformationWindow;
    private System.Windows.Forms.TabPage tabPage1;
    private System.Windows.Forms.GroupBox grpBxPatients;
    private System.Windows.Forms.GroupBox grpBxPhones;
    private System.Windows.Forms.GroupBox grpBxInformation;
    private System.Windows.Forms.TabPage tabPage2;
    private System.Windows.Forms.Button btnClientInformationOK;
    private System.Windows.Forms.Button btnClientInformationCancel;
    private System.Windows.Forms.ComboBox comBxStatus;
    private System.Windows.Forms.Label lblStatus;
    private System.Windows.Forms.Label lblClientInformationBalance;
    private System.Windows.Forms.Label lblClientInformationClientBalancetag;
    private System.Windows.Forms.Label lblClientName;
    private System.Windows.Forms.Label lblClientID;
    private System.Windows.Forms.Label lblClientIDTag;
    private System.Windows.Forms.Label lblType;
    private System.Windows.Forms.ComboBox comBxClassification;
    private System.Windows.Forms.Label lblClassification;
    private System.Windows.Forms.ComboBox comboBox2;
    private System.Windows.Forms.Label label1;
  }
}