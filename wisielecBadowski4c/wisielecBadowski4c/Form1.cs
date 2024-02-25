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
        Label[] labele = new Label[10];
        char[] symbole = new char[27];
        int bading = 0;
        int dedCount = 0;
        bool ded = false;
        char[] bad = new char[27];
        string[] teksty = new string[50];
        string wybrany = "";
        int cel = 0;
        int curr = 0;
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
                    //test.Text = wybrany;
                }
            }
            int left = 215;
            int top = 270;
            int count = wybrany.Length;
            cel = count;
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

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //zle.Text = curr.ToString();
            if (ded)
            {
                return;
            }
            char temp = (char)e.KeyCode;
            //test.Text = temp.ToString();
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
                    for (int j = 0; j < wybrany.Length; j++)
                    {
                        if (temp == wybrany[j])
                        {
                            labele[j].Text = temp.ToString();
                            /*curr++;
                            if (curr == 10)
                            {
                                MessageBox.Show("Gratulacje! Udało ci się ukończyć rozgrywkę!", "Zwycięstwo!"); // nie dziala
                                reset.Enabled = true;
                                ded = true;
                                break;
                            }*/
                            break;
                        }
                    }
                }
                else
                {
                    zle.Text += temp.ToString() + ", ";
                    bad[bading] = temp;
                    bading++;
                    wisi.Image = zdj.Images[dedCount];
                    dedCount++;
                    if (dedCount == 8)
                    {
                        MessageBox.Show("Koniec gry, skończyły ci się podejścia", "Przegrałeś");
                        ded = true;
                    }
                    break;
                }
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            //zle.Text = "X: " + e.X + " Y: " + e.Y;
        }

        private void reset_Click(object sender, EventArgs e) // naprawic
        {
            /*zle.Text = "";
            for (int i = 0; i < labele.Length; i++)
            {
                labele[i] = new Label();
                labele[i].Text = "";
            }
            string temp = File.ReadAllText(System.AppDomain.CurrentDomain.BaseDirectory + "/teksty.txt");
            teksty = temp.Split(";");
            Random rand = new Random();
            int temp2 = rand.Next(0, teksty.Length);
            for (int i = 0; i < teksty.Length; i++)
            {
                if (temp2 == i)
                {
                    wybrany = teksty[i]; // losowanie dziala
                    //test.Text = wybrany;
                }
            }
            reset.Enabled = false;*/
        }
    }
} // 215 270
