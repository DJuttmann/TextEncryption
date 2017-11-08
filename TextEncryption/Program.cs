//========================================================================================
// TextEncryption by Daan Juttmann
// Created: 2017-11-08
// License: GNU General Public License 3.0 (https://www.gnu.org/licenses/gpl-3.0.en.html).
//========================================================================================


using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text;

namespace TextEncryption
{
  class Encryption
  {
    public const int Caesar = 0;
    public const int Vigenere = 1;


    // Convert character (a-z, A-Z) to int (0-25, 26-51).
    // Other characters return -1.
    private static int CharToInt (char c)
    {
      if (c >= 'a' && c <= 'z')
      {
        return (int) (c - 'a');
      }
      else if (c >= 'A' && c <= 'Z')
      {
        return (int) (c - 'A') + 26;
      }
      return -1;
    }


    // Convert int (0-25, 26-51) to character (a-z, A-Z).
    // Other values return null character.
    private static char IntToChar (int i)
    {
      if (i < 0 || i >= 52)
        return '\x0';
      if (i < 26)
        return Convert.ToChar (i + 'a');
      return Convert.ToChar (i + 'A' - 26);
    }


    // Encrypt a single character with a character key.
    private static char EncryptChar (char input, char key)
    {
      int i = CharToInt (input);
      int k = CharToInt (key);
      if (i == -1)
        return input; // ignore non-alphabetical characters.
      if (i < 26)
        return (IntToChar ((i + k) % 26));
      return (IntToChar (((i - 26 + k) % 26) + 26));
    }


    // Return the decryption character for a character key.
    private static char InveseChar (char key)
    {
      int k = CharToInt (key) % 26;
      return IntToChar ((26 - k) % 26);
    }


    // Encrypt a string with Caesar cipher.
    public static string EncryptCaesar (string plaintext, char key)
    {
      StringBuilder ciphertext = new StringBuilder ();
      for (int i = 0; i < plaintext.Length; i++)
      {
        ciphertext.Append (EncryptChar (plaintext [i], key));
      }
      return ciphertext.ToString ();
    }


    // Decrypt a string with Caesar cipher.
    public static string DecryptCaesar (string ciphertext, char key)
    {
      char inverseKey = InveseChar (key);
      return EncryptCaesar (ciphertext, inverseKey);
    }


    // Encrypt a string with Vigenere cipher.
    public static string EncryptVigenere (string plaintext, string key)
    {
      StringBuilder ciphertext = new StringBuilder ();
      for (int i = 0; i < plaintext.Length; i++)
      {
        ciphertext.Append (EncryptChar (plaintext [i], key [i % key.Length]));
      }
      return ciphertext.ToString ();
    }


    // Decrypt a string with Vigenere cipher.
    public static string DecryptVigenere (string ciphertext, string key)
    {
      StringBuilder InverseKey = new StringBuilder ();
      for (int i = 0; i < key.Length; i++)
        InverseKey.Append (InveseChar (key [i]));
      return EncryptVigenere (ciphertext, InverseKey.ToString ());
    }


    // Check if a key is valid for given encryption scheme.
    public static bool ValidateKey (string key, int scheme)
    {
      if (key == null)
        return false;
      switch (scheme)
      {
      case Caesar:
        if (key.Length == 1 && CharToInt (key [0]) != -1)
          return true;
        break;
      case Vigenere:
        if (key.Length == 0)
          return false;
        for (int i = 0; i < key.Length; i++)
        {
          if (CharToInt (key [i]) == -1)
            return false;
        }
        return true;
      default:
        break;
      }
      return false;
    }
  }



  static class Program
  {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main ()
    {
      Application.EnableVisualStyles ();
      Application.SetCompatibleTextRenderingDefault (false);
      Application.Run (new Form1 ());
    }
  }
}
