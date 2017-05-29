using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Security.Cryptography;

namespace RSAencryptDecrypt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void encryptBtn_Click(object sender, EventArgs e)
        {
            using (var rsa = new RSACryptoServiceProvider(1024))
            {
                try
                {
                    var testData = Encoding.UTF8.GetBytes(MsgToEncrypt.Text);
                    // client encrypting data with public key issued by server
                    try
                    {
                        rsa.FromXmlString(publicKey.Text);
                        var encryptedData = rsa.Encrypt(testData, true);
                        var base64Encrypted = Convert.ToBase64String(encryptedData);
                        result.Text = base64Encrypted;
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Issue when attemp to encrypt message with Public Key.\nProbably modified by you.\nBe sure that the Public Key is properly generated");
                    }
                }
                finally
                {
                    rsa.PersistKeyInCsp = false;
                }

            }
        }

        private void DecryptBtn_Click(object sender, EventArgs e)
        {
            var testData = Encoding.UTF8.GetBytes(MsgToEncrypt.Text);

            using (var rsa = new RSACryptoServiceProvider(1024))
            {
                try
                {
                    // server decrypting data with private key
                    //
                    try
                    {
                        rsa.FromXmlString(privateKey.Text);
                        var resultBytes = Convert.FromBase64String(MsgToEncrypt.Text);
                        var decryptedBytes = rsa.Decrypt(resultBytes, true);
                        var decryptedData = Encoding.UTF8.GetString(decryptedBytes);
                        result.Text = decryptedData;
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Issue when attemp to decrypt message with Private Key.\nProbably Private Key is wrong.");
                    }
                }
                finally
                {
                    rsa.PersistKeyInCsp = false;
                }

            }
        }

        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void generateNewRandomPrivateAndPublicKeyBtn_Click(object sender, EventArgs e)
        {
            string passPhrase = "";

            if(randomPassPhraseRB.Checked)
            {
                int length;
                Random rand = new Random();
                length = rand.Next(0, 128);
                passPhrase = RandomString(length);
                randomPassPhraseTB.Text = passPhrase;
            }
            else
            {
                passPhrase = customPassPhraseTB.Text;
            }
            MyCrypto mc = new MyCrypto(passPhrase);
            mc.AssignNewKey();
            publicKey.Text = mc.publicOnlyKeyXML;
            privateKey.Text = mc.publicPrivateKeyXML;
        }

        private void randomPassPhraseRB_CheckedChanged(object sender, EventArgs e)
        {
            if (randomPassPhraseRB.Checked)
            {
                customPassPhraseRB.Checked = false;
                customPassPhraseTB.Enabled = false;
            }
            else
            {
                customPassPhraseRB.Checked = true;
                customPassPhraseTB.Enabled = true;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This private Key must be given to the other party to decrypt your message");
        }

        private void label7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This public Key should not be shared with other people.\nOnly used to Encrypt and kept safe.\nSame thing for PassPhrase as it'll generate the public key aswell which we don't want.");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(e.Link.LinkData as string);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LinkLabel.Link link = new LinkLabel.Link();
            link.LinkData = "https://github.com/melharfi/RSA-Encrypt-Decrypt";
            linkLabel1.Links.Add(link);
        }
    }

    public class MyCrypto
    {
        private string _passphrase;
        public MyCrypto(string passphrase)
        {
            _passphrase = passphrase;
        }

        RSACryptoServiceProvider rsa = null;
        public string publicPrivateKeyXML;
        public string publicOnlyKeyXML;
        public void AssignNewKey()
        {
            const int PROVIDER_RSA_FULL = 1;
            string CONTAINER_NAME = _passphrase;
            CspParameters cspParams;
            cspParams = new CspParameters(PROVIDER_RSA_FULL);
            cspParams.KeyContainerName = CONTAINER_NAME;
            cspParams.Flags = CspProviderFlags.UseMachineKeyStore;
            cspParams.ProviderName = "Microsoft Strong Cryptographic Provider";
            rsa = new RSACryptoServiceProvider(cspParams);

            //Pair of public and private key as XML string.
            //Do not share this to other party
            publicPrivateKeyXML = rsa.ToXmlString(true);

            //Private key in xml file, this string should be share to other parties
            publicOnlyKeyXML = rsa.ToXmlString(false);

        }
    }
}
