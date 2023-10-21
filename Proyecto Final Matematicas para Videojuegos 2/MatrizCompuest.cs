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
    public partial class MatrizCompuest : Form
    {
        public MatrizCompuest()
        {
            InitializeComponent();
        }

        private void BtnVolverMenu_Click(object sender, EventArgs e)
        {
            Matrices.VolverMenu(this, "");
        }

        private void btnAngulos_Click(object sender, EventArgs e)
        {
            string Vacio = "";
            int x = 0;
            string p = "";
            double test;
            double[,] MatrizTraslacion = new double[4,4];
            double[,] MatrizEscalamiento = new double[4, 4];
            double[,] MatrizRotacion = new double[4, 4];
            double[,] Resultado1 = new double[4, 4];
            double Angulo = 0;
            double AnguloConvertido = 0;
            double[,] AuxResultado1 = new double[4, 4];
            double[,] AuxMatrizCompuesta = new double[4, 4];
            //Matrices.MatrizCompuesta;

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
                    Vacio = Interaction.InputBox("Ingrese Vector de Traslacion (" + p + ")", "Ingrese el Vector de Traslacion");
                    if (Vacio == "")
                    {
                        MessageBox.Show("Está enviando datos vacios por favor introduzca datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    }
                    else if (double.TryParse(Vacio, out test) == false)
                    {
                        MessageBox.Show("Solo se aceptan numeros, NO LETRAS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    }

                } while (Vacio == "" || double.TryParse(Vacio, out test) == false);

                MatrizTraslacion[3, x] = Convert.ToDouble(Vacio);
                MatrizTraslacion[x,x] = 1;
            }
            MatrizTraslacion[3, 3] = 1;
           Vacio = "";
            x = 0;
            p = "";

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
                    Vacio = Interaction.InputBox("Ingrese Vector de Escalamiento (" + p + ")", "Ingrese el Vector de Escalamiento");
                    if (Vacio == "")
                    {
                        MessageBox.Show("Está enviando datos vacios por favor introduzca datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    }
                    else if (double.TryParse(Vacio, out test) == false)
                    {
                        MessageBox.Show("Solo se aceptan numeros, NO LETRAS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    }

                } while (Vacio == "" || double.TryParse(Vacio, out test) == false);

                MatrizEscalamiento[x, x] = Convert.ToDouble(Vacio);
            }
            MatrizEscalamiento[3, 3] = 1;
            Vacio = "";
            x = 0;
            p = "";
          
                do
                {
                    Vacio = Interaction.InputBox("Ingrese el Angulo que se rotará ", "Ingrese el Angulo en Rotación en Z");
                    if (Vacio == "")
                    {
                        MessageBox.Show("Está enviando datos vacios por favor introduzca datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    }
                    else if (double.TryParse(Vacio, out test) == false)
                    {
                        MessageBox.Show("Solo se aceptan numeros, NO LETRAS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    }

                } while (Vacio == "" || double.TryParse(Vacio, out test) == false);
            Angulo = Convert.ToDouble(Vacio);
            AnguloConvertido = (Angulo * (Math.PI)) / 180;
            MatrizRotacion[0, 0] = Math.Cos(AnguloConvertido);
            MatrizRotacion[1, 0] = -Math.Sin(AnguloConvertido);
            MatrizRotacion[0, 1] = Math.Sin(AnguloConvertido);
            MatrizRotacion[1, 1] = Math.Cos(AnguloConvertido);
            MatrizRotacion[2, 2] = 1;
            MatrizRotacion[3, 3] = 1;
            Vacio = "";
            x = 0;
            p = "";
            DialogResult Pregunta;
            Pregunta = MessageBox.Show("¿La matriz empezará con traslamiento? En caso que diga <No> iniciará con Rotación", "ERROR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Pregunta == DialogResult.Yes)
            {
                int i, j, k;
                double numeros1 = 0;
                string numeros2 = "";
                lstResultado.Items.Clear();
                for (k = 1; k <= 4; k++)
                {
                    for (j = 1; j <= 4; j++)
                    {
                        for (i = 1; i <= 4; i++)
                        {
                            AuxResultado1[k - 1, j - 1] = MatrizTraslacion[i - 1, k - 1] * MatrizEscalamiento[j - 1, i - 1];
                            numeros1 = numeros1 + AuxResultado1[k - 1, j - 1];
                        }
                        Resultado1[j - 1, k - 1] = numeros1;
                        numeros1 = 0;
                        i = 1;
                    }
                    j = 1;
                }

                numeros1 = 0;
                i = 0; j = 0; k = 0;
                for (k = 1; k <= 4; k++)
                {
                    for (j = 1; j <= 4; j++)
                    {
                        for (i = 1; i <= 4; i++)
                        {
                            AuxMatrizCompuesta[k - 1, j - 1] = Resultado1[i - 1, k - 1] * MatrizRotacion[j - 1, i - 1];
                            numeros1 = numeros1 + AuxMatrizCompuesta[k - 1, j - 1];
                        }
                        i = 1;
                        Matrices.MatrizCompuesta[j - 1, k - 1] = numeros1;
                        numeros2 = numeros2 + numeros1.ToString() + "  ";
                        numeros1 = 0;
                    }
                    lstResultado.Items.Add(numeros2);
                    numeros2 = "";
                    j = 1;
                }



            }
            else
            {
                int i, j, k;
                double numeros1 = 0;
                string numeros2 = "";
                lstResultado.Items.Clear();
                for (k = 1; k <= 4; k++)
                {
                    for (j = 1; j <= 4; j++)
                    {
                        for (i = 1; i <= 4; i++)
                        {
                            AuxResultado1[k - 1, j - 1] = MatrizRotacion[i - 1, k - 1] * MatrizEscalamiento[j - 1, i - 1];
                            numeros1 = numeros1 + AuxResultado1[k - 1, j - 1];
                        }
                        Resultado1[j - 1, k - 1] = numeros1;
                        numeros1 = 0;
                        i = 1;
                    }
                    j = 1;
                }

                numeros1 = 0;
                i = 0; j = 0; k = 0;
                for (k = 1; k <= 4; k++)
                {
                    for (j = 1; j <= 4; j++)
                    {
                        for (i = 1; i <= 4; i++)
                        {
                            AuxMatrizCompuesta[k - 1, j - 1] = Resultado1[i - 1, k - 1] * MatrizTraslacion[j - 1, i - 1];
                            numeros1 = numeros1 + AuxMatrizCompuesta[k - 1, j - 1];
                        }
                        Matrices.MatrizCompuesta[j - 1, k - 1] = numeros1;
                        i = 1;
                        numeros2 = numeros2 + numeros1.ToString() + "  ";
                        numeros1 = 0;
                    }
                    lstResultado.Items.Add(numeros2);
                    numeros2 = "";
                    j = 1;
                }
            }
            lstResultado.Visible = true;
            Resultadoes.Visible = true;
            btnCoordenadas.Enabled = true;
        }

        private void btnCoordenadas_Click(object sender, EventArgs e)
        {
            int x = 0;
            string Vacio = "";
            double test;
            string p = "";
            double[,] Coordenadas = new double[1,4];
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
                Coordenadas[0,x] = Convert.ToDouble(Vacio);

            }
            Coordenadas[0, 3] = 1;

            int i, j, k;
            double numeros1 = 0;
            string numeros2 = "";
            double[,] Coordenadas2 = new double[1, 4];
            double[,] AuxCoordenadas2 = new double[4, 1];
            lstResultado2.Items.Clear();

            for (k = 1; k <= 4; k++)
            {
                for (j = 1; j <= 1; j++)
                {
                    for (i = 1; i <= 4; i++)
                    {
                        AuxCoordenadas2[k - 1, j - 1] = Matrices.MatrizCompuesta[i - 1, k - 1] * Coordenadas[j - 1, i - 1];
                        numeros1 = numeros1 + AuxCoordenadas2[k - 1, j - 1];
                    }
                    i = 1;
                    Coordenadas2[j - 1, k - 1] = numeros1;
                    numeros2 = numeros2 + numeros1.ToString() + "  ";
                    numeros1 = 0;
                }
                lstResultado2.Items.Add(numeros2);
                numeros2 = "";
                j = 1;
            }
            lstResultado2.Visible = true;
        }
    }
}
