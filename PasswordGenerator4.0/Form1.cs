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

namespace PasswordGenerator4._0
{
    public partial class Form1 : Form
    {
        PasswordMethods myPasswordMethods = new PasswordMethods();
        FileSaving applicationFileSaving = new FileSaving();
        static string websiteName = String.Empty;
        static string loginName = String.Empty;
        static string password = String.Empty;
        static int passwordLength = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void buttonGenerateNew_Click(object sender, EventArgs e)
        {
            labelGeneratedPass.Text = myPasswordMethods.generateNewPassword(passwordLength);
        }

        private void labelWebsite_Click(object sender, EventArgs e)
        {

        }

        private void textBoxWebsite_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelLogin_Click(object sender, EventArgs e)
        {

        }

        private void textBoxLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void labelPassword_Click(object sender, EventArgs e)
        {

        }

        private void labelGeneratedPass_Click(object sender, EventArgs e)
        {

        }

        private void textBoxDesiredPassLength_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(textBoxDesiredPassLength.Text, out passwordLength);
        }

        private void labelDesiredLength_Click(object sender, EventArgs e)
        {

        }

        private void buttonSaveEntry_Click(object sender, EventArgs e)
        {
            if (textBoxWebsite.Text != String.Empty && textBoxLogin.Text != String.Empty && labelGeneratedPass.Text != "NULL")
            {
                applicationFileSaving.saveNewEntry(textBoxWebsite.Text, textBoxLogin.Text, labelGeneratedPass.Text);
                textBoxWebsite.Text = String.Empty;
                textBoxLogin.Text = String.Empty;
            }
        }
    }

    public class PasswordMethods
    {
        const int LOWER_CASE_LETTER = 1;
        const int UPPER_CASE_LETTER = 2;
        const int NUMBER            = 3;
        const int SYMBOL            = 4;
        static char[] SYMBOL_ARRAY = new char[24] { '!', '"', '#', '$', '%', '&', '\'', '(', ')', '*', '+', '-', '.', '/', ':', ';', '<', '=', '>', '?', '@', '[', ']', '^' };
        int chooseAlgorithm;
        static Random rndAlg = new Random();
        static Random rndLwr = new Random();
        static Random rndUpr = new Random();
        static Random rndNum = new Random();
        static Random rndSym = new Random();

        public PasswordMethods()
        {
            chooseAlgorithm = 0;
        }
        
        public string generateNewPassword(int passLength)
        {
            string passString = String.Empty;
            
            if(passLength < 10 || passLength > 64)
            {
                return "DESIRED LENGTH NOT IN RANGE: " + passLength + ". TRY AGAIN";
            }
            else
            {

                for(int i = 0; i < passLength; i++)
                {
                    chooseAlgorithm = rndAlg.Next(1, 5);

                    switch(chooseAlgorithm)
                    {
                        case LOWER_CASE_LETTER:
                            passString += getRandomLower();
                            break;

                        case UPPER_CASE_LETTER:
                            passString += getRandomUpper();
                            break;
                        
                        case NUMBER:
                            passString += getRandomNumber();
                            break;
                        
                        case SYMBOL:
                            passString += getRandomSymbol();
                            break;

                        default:
                            passString += getRandomLower();
                            break;
                    }
                }

                return passString;
            }
        }

        public char getRandomLower()
        {
            return (char)rndLwr.Next(97, 123); // ASCII 97 = a, 122 = z
        }
        
        public char getRandomUpper()
        {
            return (char)rndUpr.Next(65, 91); // ASCII 65 = A, 90 = Z
        }
        
        public int getRandomNumber()
        {
            return rndNum.Next(10); // from 0 - 9
        }

        public char getRandomSymbol()
        {
            return SYMBOL_ARRAY[rndSym.Next(24)]; // from 0 - 24
        }
    }

    public class FileSaving
    {
        static string path     = String.Empty;
        static string fullPath = String.Empty;

        public FileSaving()
        {
            path        = "Passwords.txt";
            fullPath    = System.IO.Path.GetFullPath(path);
        }

        public void saveNewEntry(string website, string login, string pass)
        {
            if(!File.Exists(fullPath))
            {
                using (StreamWriter sw = File.CreateText(fullPath))
                {
                    sw.WriteLine(website + ";    " + login + ";    " + pass);
                    sw.Close();
                }
            }
            else
            {
                using (StreamWriter sw = File.AppendText(fullPath))
                {
                    sw.WriteLine(website + ";    " + login + ";    " + pass);
                    sw.Close();
                }
            }
        }
    }
}