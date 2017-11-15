namespace TextEncryption
{
  partial class Form1
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose (bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose ();
      }
      base.Dispose (disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent ()
    {
      this.textboxPlaintext = new System.Windows.Forms.RichTextBox();
      this.textboxCipherText = new System.Windows.Forms.RichTextBox();
      this.labelPlaintext = new System.Windows.Forms.Label();
      this.labelCiphertext = new System.Windows.Forms.Label();
      this.selectEncryptionScheme = new System.Windows.Forms.ComboBox();
      this.labelEncryptionScheme = new System.Windows.Forms.Label();
      this.textboxKey = new System.Windows.Forms.TextBox();
      this.labelKey = new System.Windows.Forms.Label();
      this.buttonEncrypt = new System.Windows.Forms.Button();
      this.buttonDecrypt = new System.Windows.Forms.Button();
      this.buttonLoadPlaintext = new System.Windows.Forms.Button();
      this.buttonSavePlaintext = new System.Windows.Forms.Button();
      this.buttonLoadCiphertext = new System.Windows.Forms.Button();
      this.buttonSaveCiphertext = new System.Windows.Forms.Button();
      this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
      this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
      this.labelInvalidKey = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // textboxPlaintext
      // 
      this.textboxPlaintext.Location = new System.Drawing.Point(3, 32);
      this.textboxPlaintext.Name = "textboxPlaintext";
      this.textboxPlaintext.Size = new System.Drawing.Size(360, 177);
      this.textboxPlaintext.TabIndex = 0;
      this.textboxPlaintext.Text = "";
      // 
      // textboxCipherText
      // 
      this.textboxCipherText.Location = new System.Drawing.Point(3, 256);
      this.textboxCipherText.Name = "textboxCipherText";
      this.textboxCipherText.Size = new System.Drawing.Size(359, 194);
      this.textboxCipherText.TabIndex = 1;
      this.textboxCipherText.Text = "";
      // 
      // labelPlaintext
      // 
      this.labelPlaintext.AutoSize = true;
      this.labelPlaintext.Location = new System.Drawing.Point(5, 9);
      this.labelPlaintext.Name = "labelPlaintext";
      this.labelPlaintext.Size = new System.Drawing.Size(61, 17);
      this.labelPlaintext.TabIndex = 2;
      this.labelPlaintext.Text = "Plaintext";
      // 
      // labelCiphertext
      // 
      this.labelCiphertext.AutoSize = true;
      this.labelCiphertext.Location = new System.Drawing.Point(5, 233);
      this.labelCiphertext.Name = "labelCiphertext";
      this.labelCiphertext.Size = new System.Drawing.Size(71, 17);
      this.labelCiphertext.TabIndex = 3;
      this.labelCiphertext.Text = "Ciphertext";
      // 
      // selectEncryptionScheme
      // 
      this.selectEncryptionScheme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.selectEncryptionScheme.FormattingEnabled = true;
      this.selectEncryptionScheme.Location = new System.Drawing.Point(389, 32);
      this.selectEncryptionScheme.Name = "selectEncryptionScheme";
      this.selectEncryptionScheme.Size = new System.Drawing.Size(213, 24);
      this.selectEncryptionScheme.TabIndex = 4;
      this.selectEncryptionScheme.SelectedIndexChanged += new System.EventHandler(this.selectEncryptionScheme_SelectedIndexChanged);
      // 
      // labelEncryptionScheme
      // 
      this.labelEncryptionScheme.AutoSize = true;
      this.labelEncryptionScheme.Location = new System.Drawing.Point(392, 9);
      this.labelEncryptionScheme.Name = "labelEncryptionScheme";
      this.labelEncryptionScheme.Size = new System.Drawing.Size(128, 17);
      this.labelEncryptionScheme.TabIndex = 5;
      this.labelEncryptionScheme.Text = "Encryption scheme";
      // 
      // textboxKey
      // 
      this.textboxKey.Location = new System.Drawing.Point(389, 92);
      this.textboxKey.Name = "textboxKey";
      this.textboxKey.Size = new System.Drawing.Size(212, 22);
      this.textboxKey.TabIndex = 6;
      this.textboxKey.TextChanged += new System.EventHandler(this.textboxKey_TextChanged);
      // 
      // labelKey
      // 
      this.labelKey.AutoSize = true;
      this.labelKey.Location = new System.Drawing.Point(392, 70);
      this.labelKey.Name = "labelKey";
      this.labelKey.Size = new System.Drawing.Size(32, 17);
      this.labelKey.TabIndex = 7;
      this.labelKey.Text = "Key";
      // 
      // buttonEncrypt
      // 
      this.buttonEncrypt.Location = new System.Drawing.Point(389, 160);
      this.buttonEncrypt.Name = "buttonEncrypt";
      this.buttonEncrypt.Size = new System.Drawing.Size(75, 30);
      this.buttonEncrypt.TabIndex = 8;
      this.buttonEncrypt.Text = "Encrypt";
      this.buttonEncrypt.UseVisualStyleBackColor = true;
      this.buttonEncrypt.Click += new System.EventHandler(this.buttonEncrypt_Click);
      // 
      // buttonDecrypt
      // 
      this.buttonDecrypt.Location = new System.Drawing.Point(389, 208);
      this.buttonDecrypt.Name = "buttonDecrypt";
      this.buttonDecrypt.Size = new System.Drawing.Size(75, 30);
      this.buttonDecrypt.TabIndex = 9;
      this.buttonDecrypt.Text = "Decrypt";
      this.buttonDecrypt.UseVisualStyleBackColor = true;
      this.buttonDecrypt.Click += new System.EventHandler(this.buttonDecrypt_Click);
      // 
      // buttonLoadPlaintext
      // 
      this.buttonLoadPlaintext.Location = new System.Drawing.Point(206, 6);
      this.buttonLoadPlaintext.Name = "buttonLoadPlaintext";
      this.buttonLoadPlaintext.Size = new System.Drawing.Size(75, 23);
      this.buttonLoadPlaintext.TabIndex = 10;
      this.buttonLoadPlaintext.Text = "Load";
      this.buttonLoadPlaintext.UseVisualStyleBackColor = true;
      this.buttonLoadPlaintext.Click += new System.EventHandler(this.buttonLoadPlaintext_Click);
      // 
      // buttonSavePlaintext
      // 
      this.buttonSavePlaintext.Location = new System.Drawing.Point(287, 6);
      this.buttonSavePlaintext.Name = "buttonSavePlaintext";
      this.buttonSavePlaintext.Size = new System.Drawing.Size(75, 23);
      this.buttonSavePlaintext.TabIndex = 11;
      this.buttonSavePlaintext.Text = "Save";
      this.buttonSavePlaintext.UseVisualStyleBackColor = true;
      this.buttonSavePlaintext.Click += new System.EventHandler(this.buttonSavePlaintext_Click);
      // 
      // buttonLoadCiphertext
      // 
      this.buttonLoadCiphertext.Location = new System.Drawing.Point(206, 230);
      this.buttonLoadCiphertext.Name = "buttonLoadCiphertext";
      this.buttonLoadCiphertext.Size = new System.Drawing.Size(75, 23);
      this.buttonLoadCiphertext.TabIndex = 12;
      this.buttonLoadCiphertext.Text = "Load";
      this.buttonLoadCiphertext.UseVisualStyleBackColor = true;
      this.buttonLoadCiphertext.Click += new System.EventHandler(this.buttonLoadCiphertext_Click);
      // 
      // buttonSaveCiphertext
      // 
      this.buttonSaveCiphertext.Location = new System.Drawing.Point(287, 230);
      this.buttonSaveCiphertext.Name = "buttonSaveCiphertext";
      this.buttonSaveCiphertext.Size = new System.Drawing.Size(75, 23);
      this.buttonSaveCiphertext.TabIndex = 13;
      this.buttonSaveCiphertext.Text = "Save";
      this.buttonSaveCiphertext.UseVisualStyleBackColor = true;
      this.buttonSaveCiphertext.Click += new System.EventHandler(this.buttonSaveCiphertext_Click);
      // 
      // openFileDialog1
      // 
      this.openFileDialog1.FileName = "openFileDialog1";
      // 
      // labelInvalidKey
      // 
      this.labelInvalidKey.AutoSize = true;
      this.labelInvalidKey.ForeColor = System.Drawing.Color.Red;
      this.labelInvalidKey.Location = new System.Drawing.Point(392, 120);
      this.labelInvalidKey.Name = "labelInvalidKey";
      this.labelInvalidKey.Size = new System.Drawing.Size(74, 17);
      this.labelInvalidKey.TabIndex = 14;
      this.labelInvalidKey.Text = "Invalid key";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(623, 452);
      this.Controls.Add(this.labelInvalidKey);
      this.Controls.Add(this.buttonSaveCiphertext);
      this.Controls.Add(this.buttonLoadCiphertext);
      this.Controls.Add(this.buttonSavePlaintext);
      this.Controls.Add(this.buttonLoadPlaintext);
      this.Controls.Add(this.buttonDecrypt);
      this.Controls.Add(this.buttonEncrypt);
      this.Controls.Add(this.labelKey);
      this.Controls.Add(this.textboxKey);
      this.Controls.Add(this.labelEncryptionScheme);
      this.Controls.Add(this.selectEncryptionScheme);
      this.Controls.Add(this.labelCiphertext);
      this.Controls.Add(this.labelPlaintext);
      this.Controls.Add(this.textboxCipherText);
      this.Controls.Add(this.textboxPlaintext);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.RichTextBox textboxPlaintext;
    private System.Windows.Forms.RichTextBox textboxCipherText;
    private System.Windows.Forms.Label labelPlaintext;
    private System.Windows.Forms.Label labelCiphertext;
    private System.Windows.Forms.ComboBox selectEncryptionScheme;
    private System.Windows.Forms.Label labelEncryptionScheme;
    private System.Windows.Forms.TextBox textboxKey;
    private System.Windows.Forms.Label labelKey;
    private System.Windows.Forms.Button buttonEncrypt;
    private System.Windows.Forms.Button buttonDecrypt;
    private System.Windows.Forms.Button buttonLoadPlaintext;
    private System.Windows.Forms.Button buttonSavePlaintext;
    private System.Windows.Forms.Button buttonLoadCiphertext;
    private System.Windows.Forms.Button buttonSaveCiphertext;
    private System.Windows.Forms.OpenFileDialog openFileDialog1;
    private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    private System.Windows.Forms.Label labelInvalidKey;
  }
}

