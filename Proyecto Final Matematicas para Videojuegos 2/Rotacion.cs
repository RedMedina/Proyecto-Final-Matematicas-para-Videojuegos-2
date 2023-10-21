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
    public partial class Rotacion : Form
    {
        public Rotacion()
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
            string p = "";
            double test;
            double[] Resultado = new double[3];
            string Salida = "";
            lstResultado.Items.Clear();
            string TipoRotacion = "";
            string Vacio2;
            double test2;
            double Angulo = 0;
            double AnguloConvertido = 0;

            do
            {
                TipoRotacion = Interaction.InputBox("Ingrese el eje en que se rotará", "Rotación");
                if (TipoRotacion != "x" && TipoRotacion != "y" && TipoRotacion != "z" && TipoRotacion != "X" && TipoRotacion != "Y" && TipoRotacion != "Z")
                {
                    MessageBox.Show("Solo se puede rotar en x, y, z", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                }
            } while (TipoRotacion != "x" && TipoRotacion != "y" && TipoRotacion != "z" && TipoRotacion != "X" && TipoRotacion != "Y" && TipoRotacion != "Z");


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

            do
            {
                Vacio2 = Interaction.InputBox("Ingrese el angulo a rotar", "Ingrese el Angulo");
                if (Vacio2 == "")
                {
                    MessageBox.Show("Está enviando datos vacios por favor introduzca datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                }
                else if (double.TryParse(Vacio2, out test) == false)
                {
                    MessageBox.Show("Solo se aceptan numeros, NO LETRAS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                }
            } while (Vacio2 == "" || double.TryParse(Vacio2, out test2) == false);
            Angulo = Convert.ToDouble(Vacio2);
            AnguloConvertido = (Angulo * (Math.PI)) / 180;

            if (TipoRotacion == "z" || TipoRotacion == "Z")
            {
                Resultado[0] = Coordenadas[0] * Math.Cos(AnguloConvertido) - Coordenadas[1] * Math.Sin(AnguloConvertido);
                Resultado[1] = Coordenadas[0] * Math.Sin(AnguloConvertido) + Coordenadas[1] * Math.Cos(AnguloConvertido);
                Resultado[2] = Coordenadas[2];
            }
            else if (TipoRotacion == "y" || TipoRotacion == "Y")
            {
                Resultado[2] = Coordenadas[2] * Math.Cos(AnguloConvertido) - Coordenadas[0] * Math.Sin(AnguloConvertido);
                Resultado[0] = Coordenadas[2] * Math.Sin(AnguloConvertido) + Coordenadas[0] * Math.Cos(AnguloConvertido);
                Resultado[1] = Coordenadas[1];
            }
            else if (TipoRotacion == "x" || TipoRotacion == "X")
            {
                Resultado[1] = Coordenadas[1] * Math.Cos(AnguloConvertido) - Coordenadas[2] * Math.Sin(AnguloConvertido);
                Resultado[2] = Coordenadas[1] * Math.Sin(AnguloConvertido) + Coordenadas[2] * Math.Cos(AnguloConvertido);
                Resultado[0] = Coordenadas[0];
            }



            int i = 0;
            Salida = "(";
            for (i = 0; i < 3; i++)
            {
                Salida = Salida + Resultado[i].ToString() + ",  ";
            }
            Salida = Salida + ")";
          
            lstResultado.Visible = true;
            Resultadoes.Visible = true;
            lstResultado.Items.Add(Salida);
        }
    }
}
