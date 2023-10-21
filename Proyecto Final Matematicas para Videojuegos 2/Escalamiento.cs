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
    public partial class Escalamiento : Form
    {
        public Escalamiento()
        {
            InitializeComponent();
        }

        private void BtnVolverMenu_Click(object sender, EventArgs e)
        {
            Matrices.VolverMenu(this, "");
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string Vacio;
            double[] Coordenadas = new double[3];
            double[] Vector = new double[3];
            int x = 0;
            int y = 0;
            double test2;
            string p = "";
            double test;
            string Vacio2;
            double[] Resultado = new double[3];
            string Salida = "";
            lstResultado.Items.Clear();
            for (x = 0; x < 3; x++)
            {
                switch (x)
                {
                    case 0:
                        p = "x";
                        break;
                    case 1:
                        p = "y";
                        break;
                    case 2:
                        p = "z";
                        break;
                    default:
                        break;
                }
                do
                {
                    Vacio = Interaction.InputBox("Ingrese las Coordenadas (" + p + ")", "Ingrese las Coordenadas");
                    if (Vacio == "")
                    {
                        MessageBox.Show("Está enviando datos vacios por favor introduzca datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    }
                    else if (double.TryParse(Vacio, out test) == false)
                    {
                        MessageBox.Show("Solo se aceptan numeros, NO LETRAS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    }

                } while (Vacio == "" || double.TryParse(Vacio, out test) == false);
                Coordenadas[x] = Convert.ToDouble(Vacio);

            }
            p = "";
            for (y = 0; y < 3; y++)
            {
                switch (y)
                {
                    case 0:
                        p = "Sx";
                        break;
                    case 1:
                        p = "Sy";
                        break;
                    case 2:
                        p = "Sz";
                        break;
                    default:
                        break;
                }
                do
                {
                    Vacio2 = Interaction.InputBox("Ingrese el vector de Escalamiento (" + p + ")", "Vector de Escalamiento");
                    if (Vacio2 == "")
                    {
                        MessageBox.Show("Está enviando datos vacios por favor introduzca datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    }
                    else if (double.TryParse(Vacio2, out test2) == false)
                    {
                        MessageBox.Show("Solo se aceptan numeros, NO LETRAS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    }

                } while (Vacio2 == "" || double.TryParse(Vacio2, out test2) == false);
                Vector[y] = Convert.ToDouble(Vacio2);
            }

            int i = 0;
            Salida = "(";
            for (i = 0; i < 3; i++)
            {
                Resultado[i] = Coordenadas[i] * Vector[i];
                Salida = Salida + Resultado[i].ToString() + ",  ";
            }
            Salida = Salida + ")";
            /*DialogResult Pregunta;
             Pregunta = MessageBox.Show("¿Los datos son correctos?", "Importante", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
             if (Pregunta == DialogResult.Yes)
             {

             }*/
            lstResultado.Visible = true;
            Resultadoes.Visible = true;
            lstResultado.Items.Add(Salida);
        }
    }
}
