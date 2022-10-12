using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RidiciStruktury07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Random rnd = new Random();
            int n = int.Parse(textBox1.Text);
            switch (comboBox1.SelectedItem.ToString())
            {
                case "ForEach":
                    {

                        for (int i = 0; i < n; i++)
                        {
                            int nc = rnd.Next(-10, 51);
                            listBox1.Items.Add(nc);

                        }

                        bool obsahuje = false;

                        foreach (int cislo in listBox1.Items)
                        {
                            if (cislo > 20 && cislo <= 25)
                            {
                                obsahuje = true;
                                break;
                            }
                        }
                        if (obsahuje)
                        {
                            MessageBox.Show("Ano, posloupnost obsahuje cislo z intervalu (20;25>.");
                        }
                        else
                        {
                            MessageBox.Show("Ne, posloupnost neobsahuje cislo z intervalu (20;25>.");
                        }
                    }
                    break;
                case "For":
                    {



                        for (int i = 0; i < n; i++)
                        {
                            int nc = rnd.Next(-10, 51);
                            listBox1.Items.Add(nc);

                        }
                        bool obsahuje = false;
                        for (int i = 0; i < listBox1.Items.Count && !obsahuje; i++)
                        {
                            int cislo = int.Parse(listBox1.Items[i].ToString());
                            if (cislo > 20 && cislo <= 25)
                            {
                                obsahuje = true;
                            }
                        }
                        if (obsahuje)
                        {
                            MessageBox.Show("Ano, posloupnost obsahuje cislo z intervalu (20;25>.");
                        }
                        else
                        {
                            MessageBox.Show("Ne, posloupnost neobsahuje cislo z intervalu (20;25>.");
                        }


                    }
                    break;
                case "While":
                    {
                        int i = 0;
                        while (i < n)
                        {
                            int nc = rnd.Next(-10, 51);
                            listBox1.Items.Add(nc);

                            i++;
                        }


                        i = 0;
                        bool obsahuje = false;
                        while (i < listBox1.Items.Count && !obsahuje)
                        {
                            int cislo = int.Parse(listBox1.Items[i].ToString());
                            if (cislo > 20 && cislo <= 25)
                            {
                                obsahuje = true;
                            }
                            i++;
                        }
                        if (obsahuje)
                        {
                            MessageBox.Show("Ano, posloupnost obsahuje cislo z intervalu (20;25>.");
                        }
                        else
                        {
                            MessageBox.Show("Ne, posloupnost neobsahuje cislo z intervalu (20;25>.");
                        }
                    }
                    break;
                default:
                    {
                        MessageBox.Show("Nevabrana moznost");
                    }
                    break;
            }

        }
    }
}
