namespace ClientInformation
{
  partial class ClientSearch
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
      this.lstBxClientSearchResultDisplay = new System.Windows.Forms.ListBox();
      this.LblClientID = new System.Windows.Forms.Label();
      this.TxtClientSearchByID = new System.Windows.Forms.TextBox();
      this.LblClientLastName = new System.Windows.Forms.Label();
      this.TxtClientLastName = new System.Windows.Forms.TextBox();
      this.LblClientFirstName = new System.Windows.Forms.Label();
      this.TxtClientFirstName = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.MaskTxtClientPhoneNumber = new System.Windows.Forms.MaskedTextBox();
      this.LblClientEMail = new System.Windows.Forms.Label();
      this.TxtClientEMail = new System.Windows.Forms.TextBox();
      this.txtClientAddresssSearch = new System.Windows.Forms.TextBox();
      this.LblClientAddress = new System.Windows.Forms.Label();
      this.BtnClientSearch = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // lstBxClientSearchResultDisplay
      // 
      this.lstBxClientSearchResultDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lstBxClientSearchResultDisplay.FormattingEnabled = true;
      this.lstBxClientSearchResultDisplay.ItemHeight = 16;
      this.lstBxClientSearchResultDisplay.Location = new System.Drawing.Point(12, 178);
      this.lstBxClientSearchResultDisplay.Name = "lstBxClientSearchResultDisplay";
      this.lstBxClientSearchResultDisplay.ScrollAlwaysVisible = true;
      this.lstBxClientSearchResultDisplay.Size = new System.Drawing.Size(776, 260);
      this.lstBxClientSearchResultDisplay.TabIndex = 0;
      this.lstBxClientSearchResultDisplay.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstBxClientSearchResultDisplay_MouseDoubleClick);
      // 
      // LblClientID
      // 
      this.LblClientID.AutoSize = true;
      this.LblClientID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.LblClientID.Location = new System.Drawing.Point(28, 15);
      this.LblClientID.Name = "LblClientID";
      this.LblClientID.Size = new System.Drawing.Size(64, 17);
      this.LblClientID.TabIndex = 1;
      this.LblClientID.Text = "Client ID:";
      // 
      // TxtClientSearchByID
      // 
      this.TxtClientSearchByID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.TxtClientSearchByID.Location = new System.Drawing.Point(89, 12);
      this.TxtClientSearchByID.MaxLength = 6;
      this.TxtClientSearchByID.Name = "TxtClientSearchByID";
      this.TxtClientSearchByID.Size = new System.Drawing.Size(91, 23);
      this.TxtClientSearchByID.TabIndex = 2;
      // 
      // LblClientLastName
      // 
      this.LblClientLastName.AutoSize = true;
      this.LblClientLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.LblClientLastName.Location = new System.Drawing.Point(12, 40);
      this.LblClientLastName.Name = "LblClientLastName";
      this.LblClientLastName.Size = new System.Drawing.Size(80, 17);
      this.LblClientLastName.TabIndex = 3;
      this.LblClientLastName.Text = "Last Name:";
      // 
      // TxtClientLastName
      // 
      this.TxtClientLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.TxtClientLastName.Location = new System.Drawing.Point(89, 37);
      this.TxtClientLastName.Name = "TxtClientLastName";
      this.TxtClientLastName.Size = new System.Drawing.Size(326, 23);
      this.TxtClientLastName.TabIndex = 4;
      this.TxtClientLastName.TextChanged += new System.EventHandler(this.TxtClientLastName_TextChanged);
      // 
      // LblClientFirstName
      // 
      this.LblClientFirstName.AutoSize = true;
      this.LblClientFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.LblClientFirstName.Location = new System.Drawing.Point(12, 66);
      this.LblClientFirstName.Name = "LblClientFirstName";
      this.LblClientFirstName.Size = new System.Drawing.Size(80, 17);
      this.LblClientFirstName.TabIndex = 5;
      this.LblClientFirstName.Text = "First Name:";
      // 
      // TxtClientFirstName
      // 
      this.TxtClientFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.TxtClientFirstName.Location = new System.Drawing.Point(89, 63);
      this.TxtClientFirstName.Name = "TxtClientFirstName";
      this.TxtClientFirstName.Size = new System.Drawing.Size(326, 23);
      this.TxtClientFirstName.TabIndex = 6;
      this.TxtClientFirstName.TextChanged += new System.EventHandler(this.TxtClientFirstName_TextChanged);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(27, 144);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(65, 17);
      this.label1.TabIndex = 7;
      this.label1.Text = "Phone #:";
      // 
      // MaskTxtClientPhoneNumber
      // 
      this.MaskTxtClientPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.MaskTxtClientPhoneNumber.Location = new System.Drawing.Point(89, 141);
      this.MaskTxtClientPhoneNumber.Mask = "(999) 000-0000";
      this.MaskTxtClientPhoneNumber.Name = "MaskTxtClientPhoneNumber";
      this.MaskTxtClientPhoneNumber.Size = new System.Drawing.Size(117, 23);
      this.MaskTxtClientPhoneNumber.TabIndex = 8;
      this.MaskTxtClientPhoneNumber.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
      this.MaskTxtClientPhoneNumber.TextChanged += new System.EventHandler(this.MaskTxtClientPhoneNumber_TextChanged);
      // 
      // LblClientEMail
      // 
      this.LblClientEMail.AutoSize = true;
      this.LblClientEMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.LblClientEMail.Location = new System.Drawing.Point(41, 121);
      this.LblClientEMail.Name = "LblClientEMail";
      this.LblClientEMail.Size = new System.Drawing.Size(51, 17);
      this.LblClientEMail.TabIndex = 9;
      this.LblClientEMail.Text = "E-Mail:";
      // 
      // TxtClientEMail
      // 
      this.TxtClientEMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.TxtClientEMail.Location = new System.Drawing.Point(89, 115);
      this.TxtClientEMail.Name = "TxtClientEMail";
      this.TxtClientEMail.Size = new System.Drawing.Size(326, 23);
      this.TxtClientEMail.TabIndex = 10;
      this.TxtClientEMail.TextChanged += new System.EventHandler(this.TxtClientEMail_TextChanged);
      // 
      // txtClientAddresssSearch
      // 
      this.txtClientAddresssSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtClientAddresssSearch.Location = new System.Drawing.Point(89, 89);
      this.txtClientAddresssSearch.Name = "txtClientAddresssSearch";
      this.txtClientAddresssSearch.Size = new System.Drawing.Size(326, 23);
      this.txtClientAddresssSearch.TabIndex = 12;
      this.txtClientAddresssSearch.TextChanged += new System.EventHandler(this.txtClientAddresssSearch_TextChanged);
      // 
      // LblClientAddress
      // 
      this.LblClientAddress.AutoSize = true;
      this.LblClientAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.LblClientAddress.Location = new System.Drawing.Point(28, 92);
      this.LblClientAddress.Name = "LblClientAddress";
      this.LblClientAddress.Size = new System.Drawing.Size(64, 17);
      this.LblClientAddress.TabIndex = 11;
      this.LblClientAddress.Text = "Address:";
      // 
      // BtnClientSearch
      // 
      this.BtnClientSearch.BackColor = System.Drawing.Color.Silver;
      this.BtnClientSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.BtnClientSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.BtnClientSearch.Location = new System.Drawing.Point(661, 33);
      this.BtnClientSearch.Name = "BtnClientSearch";
      this.BtnClientSearch.Size = new System.Drawing.Size(111, 31);
      this.BtnClientSearch.TabIndex = 13;
      this.BtnClientSearch.Text = "Search";
      this.BtnClientSearch.UseVisualStyleBackColor = false;
      // 
      // ClientSearch
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Gainsboro;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.BtnClientSearch);
      this.Controls.Add(this.txtClientAddresssSearch);
      this.Controls.Add(this.LblClientAddress);
      this.Controls.Add(this.TxtClientEMail);
      this.Controls.Add(this.LblClientEMail);
      this.Controls.Add(this.MaskTxtClientPhoneNumber);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.TxtClientFirstName);
      this.Controls.Add(this.LblClientFirstName);
      this.Controls.Add(this.TxtClientLastName);
      this.Controls.Add(this.LblClientLastName);
      this.Controls.Add(this.TxtClientSearchByID);
      this.Controls.Add(this.LblClientID);
      this.Controls.Add(this.lstBxClientSearchResultDisplay);
      this.Name = "ClientSearch";
      this.Text = "Client Search";
      this.Load += new System.EventHandler(this.ClientSearch_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ListBox lstBxClientSearchResultDisplay;
    private System.Windows.Forms.Label LblClientID;
    private System.Windows.Forms.TextBox TxtClientSearchByID;
    private System.Windows.Forms.Label LblClientLastName;
    private System.Windows.Forms.TextBox TxtClientLastName;
    private System.Windows.Forms.Label LblClientFirstName;
    private System.Windows.Forms.TextBox TxtClientFirstName;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.MaskedTextBox MaskTxtClientPhoneNumber;
    private System.Windows.Forms.Label LblClientEMail;
    private System.Windows.Forms.TextBox TxtClientEMail;
    private System.Windows.Forms.TextBox txtClientAddresssSearch;
    private System.Windows.Forms.Label LblClientAddress;
    private System.Windows.Forms.Button BtnClientSearch;
  }
}