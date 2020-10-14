using Houtzagerij_logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Houtzagerij
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal lengte = Convert.ToDecimal(textBox1.Text);
            if (lengte <= 300)
            {
                //Aantal Planken
                decimal aantalplankennodig = Plankennodig.plankennodig(numericUpDown1.Value, lengte);
                string aantalplankennodigstring = Convert.ToString(aantalplankennodig);
                label2.Text = aantalplankennodigstring;
                //Snoeiafval
                decimal totaalsnoeiafval = SnoeiAfval.snoeiafval(numericUpDown1.Value, lengte);
                string snoeiafvalstring = Convert.ToString(totaalsnoeiafval);
                label3.Text = snoeiafvalstring;
                //Aantalstukken uit planken
                decimal aantalstukkenplank1 = AantalStukkenplank.aantalstukkenplank1(numericUpDown1.Value, lengte);
                string aantalstukkenplank1string = Convert.ToString(aantalstukkenplank1);
                label1a.Text = aantalstukkenplank1string;
                if (numericUpDown1.Value * lengte > 300)
                {
                    label1b.Visible = true;
                    Aantalstukkenuit2plank.Visible = true;
                    decimal aantalstukkenplank2 = AantalStukkenplank.aantalstukkenplank2(numericUpDown1.Value, lengte);
                    string aantalstukkenplank2string = Convert.ToString(aantalstukkenplank2);
                    label1b.Text = aantalstukkenplank2string;
                }

                //instructie plank 1
                label4.Text = textBox1.Text;
                decimal totalelengteplank1 = AfsnijdenMaat.afsnijdenMaat(numericUpDown1.Value, lengte);
                string totalelengteplank1string = Convert.ToString(totalelengteplank1);
                label6.Text = totalelengteplank1string;

                //instructie plank 2
                if (numericUpDown1.Value * lengte > 300)
                {
                    label1.Visible = true;
                    label7.Visible = true;
                    label8.Visible = true;
                    label9.Visible = true;
                    label10.Visible = true;
                    label11.Visible = true;
                    label7.Text = textBox1.Text;
                    decimal totalelengteplank2 = AfsnijdenMaat.afsnijdenMaatplank2(numericUpDown1.Value, lengte);
                    string totalelengteplank2string = Convert.ToString(totalelengteplank2);
                    label10.Text = totalelengteplank2string;

                    //uitbreiding1
                }
            }
            else if (lengte > 300 && lengte < 1200)
            {
                decimal grotestukken = Uitbreiding1.uitbreiding1(lengte);
                if (grotestukken == 999)
                {
                    MessageBox.Show("Maximale maat is 1200 cm");
                }
                else if (grotestukken == 0)
                {
                    decimal aantalstukken = Uitbreiding1.aantalstukken(lengte);
                    if (aantalstukken == 0)
                    {
                        label16.Text = Convert.ToString(2);
                    }
                    else if (aantalstukken == 99)
                    {
                        MessageBox.Show("error");
                    }
                    else
                    {
                        label16.Text = (Convert.ToString(aantalstukken));
                    }
                    
                    decimal grootstuk = Uitbreiding1.normalegevallen(grotestukken, lengte);
                    decimal kleinstuk = lengte - grootstuk;
                    label13.Text = (Convert.ToString(grootstuk));
                    label14.Visible = true;
                    label14.Text = (Convert.ToString(kleinstuk));
                }

                else
                {
                    label13.Text = (Convert.ToString(grotestukken));
                    decimal aantalstukken = Uitbreiding1.aantalstukken(lengte);
                    if (aantalstukken == 0)
                    {
                        label16.Text = Convert.ToString(2);
                    }
                    else if (aantalstukken == 99)
                    {
                        MessageBox.Show("error");
                    }
                    else
                    {
                        label16.Text = (Convert.ToString(aantalstukken));
                    }
                }
            }
            else
            {
                MessageBox.Show("Maximale maat is 1200 cm");
            }
            
           

          
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1a.Text = " ";
            label1b.Text = " ";
            label2.Text = " ";
            label3.Text = " ";
            label4.Text = " ";
            label6.Text = " ";
            label7.Text = " ";
            label10.Text = " ";
            label13.Text = " ";
            label14.Text = " ";


        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }
    }
}
