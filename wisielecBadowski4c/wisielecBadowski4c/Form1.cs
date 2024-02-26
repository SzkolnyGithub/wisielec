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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace wisielecBadowski4c
{
    public partial class gra : Form
    {
        Label[] labele;
        char[] symbole = new char[27];
        int bading = 0;
        int dedCount = 0;
        bool ded = false;
        char[] bad = new char[27];
        string[] teksty = new string[50];
        string wybrany = "";
        private void ustaw()
        {
            reset.Enabled = false;
            string characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            symbole = characters.ToCharArray();
            string temp = File.ReadAllText(System.AppDomain.CurrentDomain.BaseDirectory + "/teksty.txt");
            teksty = temp.Split(";");
            Random rand = new Random();
            int temp2 = rand.Next(0, teksty.Length);
            for (int i = 0; i < teksty.Length; i++)
            {
                if (temp2 == i)
                {
                    wybrany = teksty[i]; // losowanie dziala
                    //zle.Text = wybrany;
                }
            }
            int left = 215;
            int top = 270;
            int count = wybrany.Length;
            labele = new Label[count];
            for (int i = 0; i < count; i++)
            {
                labele[i] = new Label();
                labele[i].Text = "_";
                labele[i].AutoSize = true;
                labele[i].Location = new Point(left, top);
                labele[i].Visible = true;
                Controls.Add(labele[i]);
                left += 20;
            }
        }
        public gra()
        {
            InitializeComponent();
            ustaw();
        }

        private void reset_Click_1(object sender, EventArgs e)
        {
            zle.Text = "";
            foreach (Label label in labele)
            {
                label.Dispose();
            }
            ustaw();
            reset.Enabled = false;
            ded = false;
            Array.Clear(bad, 0, bad.Length);
            bading = 0;
            dedCount = 0;
            wisi.Image = null;
        }

        private void gra_KeyDown(object sender, KeyEventArgs e)
        {
            if (ded)
            {
                reset.Enabled = true;
                return;
            }
            char temp = (char)e.KeyCode;
            for (int i = 0; i < bad.Length; i++)
            {
                if (temp == bad[i])
                {
                    return;
                }
            }
            if (!symbole.Contains(temp))
            {
                MessageBox.Show("Podaj litere, " + temp.ToString() + " nie jest litera");
                return;
            }
            for (int i = 0; i < 27; i++)
            {
                if (wybrany.Contains(temp))
                {
                    for (int j = 0; j < labele.Length; j++)
                    {
                        if (temp == wybrany[j])
                        {
                            labele[j].Text = temp.ToString();
                        }
                    }
                }
                else
                {
                    zle.Text += temp.ToString() + ", ";
                    bad[bading] = temp;
                    bading++;
                    wisi.Image = new Bitmap(System.AppDomain.CurrentDomain.BaseDirectory + ("sz" + (dedCount+1)) + ".png");
                    dedCount++;
                    if (dedCount == 8)
                    {
                        MessageBox.Show("Koniec gry, skończyły ci się podejścia", "Przegrałeś");
                        ded = true;
                    }
                    break;
                }
            }
            int counter = 0;
            for (int i = 0; i < labele.Length; i++)
            {
                if(labele[i].Text != "_")
                {
                    counter++;
                }
            }
            if(counter == labele.Length)
            {
                MessageBox.Show("Gratulacje! Udało ci się ukończyć rozgrywkę!", "Zwycięstwo!");
                ded = true;
            }
        }
    }
} // 215 270
