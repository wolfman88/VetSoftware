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
      this.LstBxClientSearchResultDisplay = new System.Windows.Forms.ListBox();
      this.LblClientID = new System.Windows.Forms.Label();
      this.TxtClientSearchByID = new System.Windows.Forms.TextBox();
      this.LblClientLastName = new System.Windows.Forms.Label();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // LstBxClientSearchResultDisplay
      // 
      this.LstBxClientSearchResultDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.LstBxClientSearchResultDisplay.FormattingEnabled = true;
      this.LstBxClientSearchResultDisplay.ItemHeight = 16;
      this.LstBxClientSearchResultDisplay.Location = new System.Drawing.Point(12, 226);
      this.LstBxClientSearchResultDisplay.Name = "LstBxClientSearchResultDisplay";
      this.LstBxClientSearchResultDisplay.ScrollAlwaysVisible = true;
      this.LstBxClientSearchResultDisplay.Size = new System.Drawing.Size(776, 212);
      this.LstBxClientSearchResultDisplay.TabIndex = 0;
      // 
      // LblClientID
      // 
      this.LblClientID.AutoSize = true;
      this.LblClientID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.LblClientID.Location = new System.Drawing.Point(12, 9);
      this.LblClientID.Name = "LblClientID";
      this.LblClientID.Size = new System.Drawing.Size(25, 17);
      this.LblClientID.TabIndex = 1;
      this.LblClientID.Text = "ID:";
      // 
      // TxtClientSearchByID
      // 
      this.TxtClientSearchByID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.TxtClientSearchByID.Location = new System.Drawing.Point(34, 8);
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
      // textBox1
      // 
      this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.textBox1.Location = new System.Drawing.Point(89, 37);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(326, 23);
      this.textBox1.TabIndex = 4;
      // 
      // ClientSearch
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.ScrollBar;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.LblClientLastName);
      this.Controls.Add(this.TxtClientSearchByID);
      this.Controls.Add(this.LblClientID);
      this.Controls.Add(this.LstBxClientSearchResultDisplay);
      this.Name = "ClientSearch";
      this.Text = "Client Search";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ListBox LstBxClientSearchResultDisplay;
    private System.Windows.Forms.Label LblClientID;
    private System.Windows.Forms.TextBox TxtClientSearchByID;
    private System.Windows.Forms.Label LblClientLastName;
    private System.Windows.Forms.TextBox textBox1;
  }
}