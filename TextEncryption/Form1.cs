using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TextEncryption
{
  public partial class Form1: Form
  {
    private Nullable <char> CaesarKey = null;
    private string VigenereKey = null;
    private const string CaesarKeyText = "Key (single character a-z)";
    private const string VigenereKeyText = "Key (string, characters a-z only)";
    private const string InvalidKeyMessage = "Invalid Key";


    public Form1 ()
    {
      InitializeComponent ();
      selectEncryptionScheme.DataSource = new [] {"Caesar cipher", "Vigenere cipher"};
      labelKey.Text = CaesarKeyText;
    }


    private void buttonEncrypt_Click (object sender, EventArgs e)
    {
      switch (selectEncryptionScheme.SelectedIndex)
      {
      case Encryption.Caesar:
        if (CaesarKey != null)
          textboxCipherText.Text = Encryption.EncryptCaesar (textboxPlaintext.Text,
                                                             (char) CaesarKey);
        break;
      case Encryption.Vigenere:
        if (VigenereKey != null)
          textboxCipherText.Text = Encryption.EncryptVigenere (textboxPlaintext.Text,
                                                               VigenereKey);
        break;
      default:
        break;
      }
    }


    private void buttonDecrypt_Click (object sender, EventArgs e)
    {
      switch (selectEncryptionScheme.SelectedIndex)
      {
      case Encryption.Caesar:
        if (CaesarKey != null)
          textboxPlaintext.Text = Encryption.DecryptCaesar (textboxCipherText.Text,
                                                             (char) CaesarKey);
        break;
      case Encryption.Vigenere:
        if (VigenereKey != null)
          textboxPlaintext.Text = Encryption.DecryptVigenere (textboxCipherText.Text,
                                                               VigenereKey);
        break;
      default:
        break;
      }
    }


    // Check if the key is valid for the selected scheme, save it to variable.
    private void ValidateKey ()
    {
      switch (selectEncryptionScheme.SelectedIndex)
      {
      case Encryption.Caesar: // update the Caesar cipher key
        if (Encryption.ValidateKey (textboxKey.Text, Encryption.Caesar))
        {
          CaesarKey = textboxKey.Text [0];
          labelInvalidKey.Text = "";
        }
        else
        {
          CaesarKey = null;
          labelInvalidKey.Text = InvalidKeyMessage;
        }
        break;
      case Encryption.Vigenere: // update the Vigenere cipher key
        if (Encryption.ValidateKey (textboxKey.Text, Encryption.Vigenere))
        {
          VigenereKey = textboxKey.Text;
          labelInvalidKey.Text = "";
        }
        else
        {
          VigenereKey = null;
          labelInvalidKey.Text = InvalidKeyMessage;
        }
        break;
      default:
        break;
      }
    }


    private void textboxKey_TextChanged (object sender, EventArgs e)
    {
      ValidateKey ();
    }


    // Load text from a file selected by user in open file dialog.
    string FileToText ()
    {
      StringBuilder text = new StringBuilder ("");
      Stream fileStream;
      if (openFileDialog1.ShowDialog () == DialogResult.OK)
      {
        try
        {
          fileStream = openFileDialog1.OpenFile ();
          if (fileStream == null)
          {
            MessageBox.Show ("Failed to load text.");
            return null;
          }
        }
        catch (Exception ex)
        {
          MessageBox.Show (ex.Message);
          return null;
        }
        StreamReader reader = new StreamReader (fileStream);
        while (!reader.EndOfStream)
          text.Append ((char) reader.Read ());
        reader.Dispose ();
        fileStream.Dispose ();
        return text.ToString ();
      }
      return null;
    }


    // Save text to a file selected by user in save file dialog.
    void TextToFile (string text)
    {
      Stream fileStream;
      if (saveFileDialog1.ShowDialog () == DialogResult.OK)
      {
        try
        {
          fileStream = saveFileDialog1.OpenFile ();
          if (fileStream == null)
          {
            MessageBox.Show ("Failed to save text.");
            return;
          }
        }
        catch (Exception ex)
        {
          MessageBox.Show (ex.Message);
          return;
        }
        StreamWriter writer = new StreamWriter (fileStream);
        for (int i = 0; i < text.Length; i++)
          writer.Write (text [i]);
        writer.Dispose ();
        fileStream.Dispose ();
      }
    }


    private void buttonLoadPlaintext_Click (object sender, EventArgs e)
    {
      string temp = FileToText ();
      if (temp != null)
        textboxPlaintext.Text = temp;
    }


    private void buttonSavePlaintext_Click (object sender, EventArgs e)
    {
      TextToFile (textboxPlaintext.Text);
    }


    private void buttonLoadCiphertext_Click (object sender, EventArgs e)
    {
      string temp = FileToText ();
      if (temp != null)
        textboxCipherText.Text = temp;
    }


    private void buttonSaveCiphertext_Click (object sender, EventArgs e)
    {
      TextToFile (textboxCipherText.Text);
    }


    private void selectEncryptionScheme_SelectedIndexChanged (object sender, EventArgs e)
    {
      switch (selectEncryptionScheme.SelectedIndex)
      {
      case Encryption.Caesar:
        labelKey.Text = CaesarKeyText;
        break;
      case Encryption.Vigenere:
        labelKey.Text = VigenereKeyText;
        break;
      default:
        break;
      }
      ValidateKey ();
    }
  }
}
