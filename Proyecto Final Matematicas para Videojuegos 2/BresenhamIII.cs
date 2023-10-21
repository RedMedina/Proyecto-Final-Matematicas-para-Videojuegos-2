using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Proyecto_Final_Matematicas_para_Videojuegos_2
{
    public partial class BresenhamIII : Form
    {
        public BresenhamIII()
        {
            InitializeComponent();
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            string Vacio = "";
            double test;
            double[] Punto1 = new double[2];
            double[] Punto2 = new double[2];
            double RadioX = 0;
            double RadioY = 0;
            lstResultado1.Items.Clear();
            lstResultado2.Items.Clear();
            lstResultado3.Items.Clear();
            lstResultado4.Items.Clear();
            lstResultado5.Items.Clear();
            lstResultado6.Items.Clear();
            lstResultado7.Items.Clear();
            lstResultado8.Items.Clear();
            lstResultado9.Items.Clear();
            lstResultado10.Items.Clear();


            do
            {
                Vacio = Interaction.InputBox("Ingrese el Radio Rx", "Ingrese el Radio de la Elipse");
                if (Vacio == "")
                {
                    MessageBox.Show("Está enviando datos vacios por favor introduzca datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                }

                else if (double.TryParse(Vacio, out test) == false)
                {
                    MessageBox.Show("Solo se aceptan numeros, NO LETRAS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                }
                else if (Convert.ToDouble(Vacio) == 0)
                {
                    MessageBox.Show("El Radio no puede ser 0", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                }

            } while (Vacio == "" || double.TryParse(Vacio, out test) == false || Convert.ToDouble(Vacio) == 0);

            RadioX = Convert.ToDouble(Vacio);
            Vacio = "";

            do
            {
                Vacio = Interaction.InputBox("Ingrese el Radio Ry", "Ingrese el Radio de la Elipse");
                if (Vacio == "")
                {
                    MessageBox.Show("Está enviando datos vacios por favor introduzca datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                }

                else if (double.TryParse(Vacio, out test) == false)
                {
                    MessageBox.Show("Solo se aceptan numeros, NO LETRAS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                }
                else if (Convert.ToDouble(Vacio) == 0)
                {
                    MessageBox.Show("El Radio no puede ser 0", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                }

            } while (Vacio == "" || double.TryParse(Vacio, out test) == false || Convert.ToDouble(Vacio) == 0);
            RadioY = Convert.ToDouble(Vacio);
            Punto1[0] = 0;
            Punto1[1] = RadioY;
            double DosRx = 0;
            double DosRy = 0;
            double Parametro = 0;
            double Parametro2 = 0;
            string Salida1 = "";
            string Salida2 = "";
            string Salida3 = "";
            string Salida4 = "";
            string Salida5 = "";
            string Salida6 = "";
            string Salida7 = "";
            string Salida8 = "";
            string Salida9 = "";
            string Salida10 = "";
            int i = 0;
            DosRx = Punto1[0] * (2 * (Math.Pow(RadioY, 2)));
            DosRy = Punto1[1] * (2 *(Math.Pow(RadioX,2)));
            Parametro = (Math.Pow(RadioY, 2)) - (Math.Pow(RadioX, 2) * RadioY) + ((0.25) * Math.Pow(RadioX, 2));

            while (DosRx< DosRy)
            {
                Salida2 = Parametro.ToString();
                lstResultado2.Items.Add(Salida2);
                if (Parametro < 0)
                {
                    Punto1[0] = Punto1[0] + 1;
                    Punto1[1] = Punto1[1];
                    DosRx = Punto1[0] * (2 * (Math.Pow(RadioY, 2)));
                    DosRy = Punto1[1] * (2 * (Math.Pow(RadioX, 2)));
                    Parametro = Parametro + DosRx + Math.Pow(RadioY, 2);

                }
                else
                {
                    Punto1[0] = Punto1[0] + 1;
                    Punto1[1] = Punto1[1] - 1;
                    DosRx = Punto1[0] * (2 * (Math.Pow(RadioY, 2)));
                    DosRy = Punto1[1] * (2 * (Math.Pow(RadioX, 2)));
                    Parametro = Parametro + DosRx - DosRy + Math.Pow(RadioY, 2);
                }
                Salida1 = i.ToString();
                Salida3 = "(" + Punto1[0].ToString() + ", " + Punto1[1].ToString() + ")";
                Salida4 = DosRx.ToString();
                Salida5 = DosRy.ToString();

                lstResultado1.Visible = true;
                lstResultado2.Visible = true;
                lstResultado3.Visible = true;
                lstResultado4.Visible = true;
                lstResultado5.Visible = true;
                Resultadoes.Visible = true;
                lstResultado1.Items.Add(Salida1);
                lstResultado3.Items.Add(Salida3);
                lstResultado4.Items.Add(Salida4);
                lstResultado5.Items.Add(Salida5);
                i++;
            }
            i = 0;

            Punto2[0] = Punto1[0];
            Punto2[1] = Punto1[1];
            DosRx = Punto2[0] * (2 * (Math.Pow(RadioY, 2)));
            DosRy = Punto2[1] * (2 * (Math.Pow(RadioX, 2)));
            Parametro2 = Math.Pow(RadioY, 2) * Math.Pow((Punto2[0] + (0.5)), 2) + Math.Pow(RadioX, 2) * Math.Pow((Punto2[1] - 1), 2) - Math.Pow(RadioX, 2) * Math.Pow(RadioY, 2);

            while (Punto2[1] != 0)
            {
                Salida7 = Parametro2.ToString();
                lstResultado7.Items.Add(Salida7);
                if (Parametro2 > 0)
                {
                    Punto2[0] = Punto2[0];
                    Punto2[1] = Punto2[1] - 1;
                    DosRx = Punto2[0] * (2 * (Math.Pow(RadioY, 2)));
                    DosRy = Punto2[1] * (2 * (Math.Pow(RadioX, 2)));
                    Parametro2 = Parametro2 - DosRy + Math.Pow(RadioX, 2);
                }
                else
                {
                    Punto2[0] = Punto2[0] + 1;
                    Punto2[1] = Punto2[1] - 1;
                    DosRx = Punto2[0] * (2 * (Math.Pow(RadioY, 2)));
                    DosRy = Punto2[1] * (2 * (Math.Pow(RadioX, 2)));
                    Parametro2 = Parametro2 + DosRx - DosRy + Math.Pow(RadioX, 2);
                }
                Salida6 = i.ToString();
                Salida8 = "(" + Punto2[0].ToString() + ", " + Punto2[1].ToString() + ")";
                Salida9 = DosRx.ToString();
                Salida10 = DosRy.ToString();
                lstResultado6.Visible = true;
                lstResultado7.Visible = true;
                lstResultado8.Visible = true;
                lstResultado9.Visible = true;
                lstResultado10.Visible = true;
                lbl1.Visible = true;
                lbl2.Visible = true;
                lbl3.Visible = true;
                lbl4.Visible = true;
                lbl5.Visible = true;
                lbl6.Visible = true;
                lbl7.Visible = true;
                lbl8.Visible = true;
                lbl9.Visible = true;
                lbl10.Visible = true;
                Resultado2.Visible = true;
                lstResultado6.Items.Add(Salida6);
                lstResultado8.Items.Add(Salida8);
                lstResultado9.Items.Add(Salida9);
                lstResultado10.Items.Add(Salida10);
                i++;
            }
            


        }

        private void BtnVolverMenu_Click(object sender, EventArgs e)
        {
            Matrices.VolverMenu(this, "");
        }
    }
}
