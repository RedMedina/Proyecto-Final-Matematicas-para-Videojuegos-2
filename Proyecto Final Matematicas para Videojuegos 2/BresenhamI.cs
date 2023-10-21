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
    public partial class BresenhamI : Form
    {
        public BresenhamI()
        {
            InitializeComponent();
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            lstResultado1.Items.Clear();
            lstResultado2.Items.Clear();
            lstResultado3.Items.Clear();
            string Vacio = "";
            double[] PuntoI = new double[2];
            double[] PuntoF = new double[2];
            double test;
            int x = 0;
            int y = 0;
            string p = "";
            for (x = 0; x < 2; x++)
            {
                switch (x)
                {
                    case 0:
                        p = "x";
                        break;
                    case 1:
                        p = "y";
                        break;
                    default:
                        break;
                }
                do
                {
                    Vacio = Interaction.InputBox("Ingrese el Punto " + p, "Ingrese el Punto Inicial");
                    if (Vacio == "")
                    {
                        MessageBox.Show("Está enviando datos vacios por favor introduzca datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    }
                    else if (double.TryParse(Vacio, out test) == false)
                    {
                        MessageBox.Show("Solo se aceptan numeros, NO LETRAS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    }

                } while (Vacio == "" || double.TryParse(Vacio, out test) == false);
                PuntoI[x] = Convert.ToDouble(Vacio);
            }
            Vacio = "";
            p = "";
            for (y = 0; y < 2; y++)
            {
                switch (y)
                {
                    case 0:
                        p = "x";
                        break;
                    case 1:
                        p = "y";
                        break;
                    default:
                        break;
                }
                do
                {
                    Vacio = Interaction.InputBox("Ingrese el Punto " + p, "Ingrese el Punto Final");
                    if (Vacio == "")
                    {
                        MessageBox.Show("Está enviando datos vacios por favor introduzca datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    }
                    else if (double.TryParse(Vacio, out test) == false)
                    {
                        MessageBox.Show("Solo se aceptan numeros, NO LETRAS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    }

                } while (Vacio == "" || double.TryParse(Vacio, out test) == false);
                PuntoF[y] = Convert.ToDouble(Vacio);
            }

            double m = 0;
            m = (PuntoF[1] - PuntoI[1]) / (PuntoF[0] - PuntoI[0]);
            if (m < 1 && m >0)
            {
                double DeltaX = PuntoF[0] - PuntoI[0];
                double DeltaY = PuntoF[1] - PuntoI[1];
                double Parametro = 0;
                Parametro = 2 * DeltaY - DeltaX;
                double DosDeltaY = 0;
                DosDeltaY = 2 * DeltaY;
                double DosDeltaYDosDeltaX = 0;
                DosDeltaYDosDeltaX = 2 * DeltaY - 2*DeltaX;
                int i = 0;
                string Salida1 = "";
                string Salida2 = "";
                string Salida3 = "";
                for (i = 0; i < DeltaX; i++ )
                {
                    Salida2 = Parametro.ToString();
                    lstResultado2.Visible = true;
                    lstResultado2.Items.Add(Salida2);
                    if (Parametro < 0)
                    {
                        PuntoI[0] = PuntoI[0] + 1;
                        PuntoI[1] = PuntoI[1];
                        Parametro = Parametro + DosDeltaY;
                    }
                    else
                    {
                        PuntoI[0] = PuntoI[0] + 1;
                        PuntoI[1] = PuntoI[1] + 1;
                        Parametro = Parametro + DosDeltaYDosDeltaX;
                    }
                    Salida1 = i.ToString();
                    
                    Salida3 = "(" + PuntoI[0].ToString() + " ," + PuntoI[1].ToString() + ")";
                    lstResultado1.Visible = true;
                    lstResultado3.Visible = true;
                    Resultadoes.Visible = true;
                    lblK.Visible = true;
                    lblPk.Visible = true;
                    lbl3.Visible = true;
                    lstResultado1.Items.Add(Salida1);
                    lstResultado3.Items.Add(Salida3);
                }
                
            }
            else
            {
                MessageBox.Show("La pendiente es menor a 0 ó mayor a 1", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }

        }

        private void BtnVolverMenu_Click(object sender, EventArgs e)
        {
            Matrices.VolverMenu(this, "");
        }
    }
}
