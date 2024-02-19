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

namespace wisielecBadowski4c
{
    public partial class Form1 : Form
    {
        char[] symbole = new char[27];
        string[] teksty = new string[50];
        string wybrany = "";
        private void ustaw()
        {
            string characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            symbole = characters.ToCharArray();
            string temp = File.ReadAllText(@"C:\Users\abadowski\source\repos\wisielecBadowski4c\wisielecBadowski4c\teksty.txt");
            teksty = temp.Split(";");
            Random rand = new Random();
            int temp2 = rand.Next(0, teksty.Length);
            for(int i = 0; i < teksty.Length; i++)
            {
                if(temp2 == i)
                {
                    wybrany = teksty[i]; // losowanie dziala
                    //test.Text = wybrany;
                }
            }
            int count = wybrany.Length;
            for(int i = 0; i < count; i++)
            {
                template.Text += "_ ";
            }
        }
        public Form1()
        {
            InitializeComponent();
            ustaw();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            char temp = (char)e.KeyCode;
            test.Text = temp.ToString();
            if (!symbole.Contains(temp))
            {
                MessageBox.Show("Podaj litere, " + temp.ToString() + " nie jest litera");
                return;
            }
            for(int i = 0; i < 27; i++)
            {
                if (temp == symbole[i])
                {
                    if(wybrany.Contains(temp))
                    {

                    }
                    // MessageBox.Show(temp.ToString());
                    break;
                }
            }
        }
    }
}
