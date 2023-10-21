using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Proyecto_Final_Matematicas_para_Videojuegos_2
{

    public class Matrices
    {
        public static String[,] MatrizA;
        public static String[,] MatrizB;
        public static string xA;
        public static string yA;
        public static string xB;
        public static string yB;
        public static bool SiMatriz1 = false;
        public static bool SiMatriz2 = false;
        public static bool SiVector = false;
        public static double[,] vector = new double[1, 3];
        public static double[] cuaternio = new double[4];
        public static double[] cuaternio2 = new double[4];
        public static double[] Vector1 = new double[3];
        public static double[] Vector2 = new double[3];
        public static double Escalar = 0;
        public static double[,] MatrizCompuesta = new double[4, 4];

        public static string Matriz1(ListBox lstMatriz, PictureBox llave1, PictureBox llave2, string resultado)
        {

            int i;
            int j;
            int test1;
            double test2;
            string numeros = "";
            do
            {
                yA = Interaction.InputBox("Indica el numero de filas", "Agregar Matriz", "");
                if (yA == "")
                {
                    MessageBox.Show("Está enviando datos vacios por favor introduzca datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                }
                else if (int.TryParse(yA, out test1) == false || Int16.Parse(yA) < 0)
                {
                    MessageBox.Show("Solo se aceptan numeros enteros y positivos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                }
            }
            while (yA == "" || int.TryParse(yA, out test1) == false || Int16.Parse(yA) < 0);
            do
            {
                xA = Interaction.InputBox("Indica el numero de columnas", "Agregar Matriz", "");
                if (xA == "")
                {
                    MessageBox.Show("Está enviando datos vacios por favor introduzca datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                }
                else if (int.TryParse(xA, out test1) == false || Int16.Parse(xA) < 0)
                {
                    MessageBox.Show("Solo se aceptan numeros enteros y positivos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                }
            }
            while (xA == "" || int.TryParse(xA, out test1) == false || Int16.Parse(xA) < 0);
            lstMatriz.Size = new System.Drawing.Size(31 + Int16.Parse(xA) * 10, 17 + Int16.Parse(yA) * 20);
            lstMatriz.Location = new Point(56 - Int16.Parse(xA) * 5, 98);
            lstMatriz.Items.Clear();
            MatrizA = new String[Int16.Parse(xA), Int16.Parse(yA)];
            for (j = 1; j <= Int16.Parse(yA); j++)
            {
                for (i = 1; i <= Int16.Parse(xA); i++)
                {
                    do {
                        MatrizA[i - 1, j - 1] = Interaction.InputBox("Agrega el numero [" + j + "] [" + i + "]", "Agregar Matriz", "");
                        if (MatrizA[i - 1, j - 1] == "")
                        {
                            MessageBox.Show("Está enviando datos vacios por favor introduzca datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                        }
                        else if (double.TryParse(MatrizA[i - 1, j - 1], out test2) == false)
                        {
                            MessageBox.Show("Solo se aceptan numeros, NO LETRAS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                        }
                    } while (MatrizA[i - 1, j - 1] == "" || double.TryParse(MatrizA[i - 1, j - 1], out test2) == false);
                    numeros = numeros + MatrizA[i - 1, j - 1] + "   ";
                }
                lstMatriz.Items.Add(numeros);
                numeros = "";
                i = 1;
            }
            lstMatriz.Visible = true;
            llave1.Visible = true;
            llave2.Visible = true;
            SiMatriz1 = true;
            return resultado;

        }
        public static string Matriz2(ListBox lstMatriz, PictureBox llave1, PictureBox llave2, string resultado)
        {
            int i;
            int j;
            string numeros = "";
            int test1;
            double test2;

            do
            {
                yB = Interaction.InputBox("Indica el numero de filas", "Agregar Matriz", "");
                if (yB == "")
                {
                    MessageBox.Show("Está enviando datos vacios por favor introduzca datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                }
                else if (int.TryParse(yB, out test1) == false || Int16.Parse(yB) < 0)
                {
                    MessageBox.Show("Solo se aceptan numeros enteros y positivos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                }
            }
            while (yB == "" || int.TryParse(yB, out test1) == false || Int16.Parse(yB) < 0);
            do
            {
                xB = Interaction.InputBox("Indica el numero de columnas", "Agregar Matriz", "");
                if (xB == "")
                {
                    MessageBox.Show("Está enviando datos vacios por favor introduzca datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                }
                else if (int.TryParse(xB, out test1) == false || Int16.Parse(xB) < 0)
                {
                    MessageBox.Show("Solo se aceptan numeros enteros y positivos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                }
            }
            while (xB == "" || int.TryParse(xB, out test1) == false || Int16.Parse(xB) < 0);
            lstMatriz.Size = new System.Drawing.Size(31 + Int16.Parse(xB) * 10, 17 + Int16.Parse(yB) * 20);
            lstMatriz.Location = new Point(335 - Int16.Parse(xB) * 5, 98);
            lstMatriz.Items.Clear();
            MatrizB = new String[Int16.Parse(xB), Int16.Parse(yB)];
            for (j = 1; j <= Int16.Parse(yB); j++)
            {
                for (i = 1; i <= Int16.Parse(xB); i++)
                {
                    do
                    {
                        MatrizB[i - 1, j - 1] = Interaction.InputBox("Agrega el numero [" + j + "] [" + i + "]", "Agregar Matriz", "");
                        if (MatrizB[i - 1, j - 1] == "")
                        {
                            MessageBox.Show("Está enviando datos vacios por favor introduzca datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                        }
                        else if (double.TryParse(MatrizB[i - 1, j - 1], out test2) == false)
                        {
                            MessageBox.Show("Solo se aceptan numeros, NO LETRAS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                        }
                    } while (MatrizB[i - 1, j - 1] == "" || double.TryParse(MatrizB[i - 1, j - 1], out test2) == false);
                    numeros = numeros + MatrizB[i - 1, j - 1] + "   ";
                }
                lstMatriz.Items.Add(numeros);
                numeros = "";
                i = 1;
            }
            lstMatriz.Visible = true;
            llave1.Visible = true;
            llave2.Visible = true;
            SiMatriz2 = true;
            return resultado;
        }
        public static string VolverMenu(Form ActualForm, string devolver)
        {
            Inicio nextForm = new Inicio();
            ActualForm.Hide();
            nextForm.ShowDialog();
            ActualForm.Close();
            return devolver;
        }
        public static string AbrirMatriz(ListBox lstMatriz, String[,] Matriz, PictureBox llave1, PictureBox llave2, bool SiMatriz, string x, string y, int puntox1, String puntox2, string devolver)
        {
            int i;
            int j;
            string numeros = "";
            lstMatriz.Size = new System.Drawing.Size(31 + Int16.Parse(x) * 10, 17 + Int16.Parse(y) * 20);
            lstMatriz.Location = new Point(puntox1 - Int16.Parse(puntox2) * 5, 98);

            lstMatriz.Items.Clear();
            for (j = 1; j <= Int16.Parse(y); j++)
            {
                for (i = 1; i <= Int16.Parse(x); i++)
                {
                    numeros = numeros + Matriz[i - 1, j - 1] + "   ";
                }
                lstMatriz.Items.Add(numeros);
                numeros = "";
                i = 1;
            }
            lstMatriz.Visible = true;
            llave1.Visible = true;
            llave2.Visible = true;
            SiMatriz = true;
            return devolver;
        }
        public static string ColocarVector(ListBox lstVector, string devolver)
        {
            double test1;
            string[,] Capturarvector = new string[1, 3];
            int i;

            string numeros = "";
            string puntodelVector = "";
            lstVector.Items.Clear();
            for (i = 1; i <= 3; i++)
            {
                switch (i)
                {
                    case 1:
                        puntodelVector = "i";
                        break;
                    case 2:
                        puntodelVector = "j";
                        break;
                    case 3:
                        puntodelVector = "k";
                        break;
                }
                do
                {
                    Capturarvector[0, i - 1] = Interaction.InputBox("Indica el punto " + puntodelVector, "Agregar Vector", "");
                    if (Capturarvector[0, i - 1] == "")
                    {
                        MessageBox.Show("Está enviando datos vacios por favor introduzca datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    }
                    else if (double.TryParse(Capturarvector[0, i - 1], out test1) == false || Int16.Parse(Capturarvector[0, i - 1]) < 0)
                    {
                        MessageBox.Show("Solo se aceptan numeros NO LETRAS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    }
                } while (Capturarvector[0, i - 1] == "" || double.TryParse(Capturarvector[0, i - 1], out test1) == false);
                vector[0, i - 1] = Convert.ToDouble(Capturarvector[0, i - 1]);
                numeros = numeros + Capturarvector[0, i - 1] + puntodelVector + "  ";
            }
            lstVector.Items.Add("(" + numeros + ")");
            lstVector.Visible = true;
            SiVector = true;
            return devolver;
        }

        public static string Cuaterniones(string devolver, ListBox lstCuaternio, Button Calcular)
            {
            double test;
            string Vacio = "";
            int i = 0;
            string p = "";
            string Salida = "";
            lstCuaternio.Items.Clear();
            for (i = 0; i < 4; i++)
            {
                switch (i)
                {
                    case 0:
                        p = "";
                        break;
                    case 1:
                        p = "i";
                        break;
                    case 2:
                        p = "j";
                        break;
                    case 3:
                        p = "k";
                        break;
                    default:
                        break;
                }
                do
                {
                    Vacio = Interaction.InputBox("Ingrese el Punto " + p , "Ingrese el Cuaternio");
                    if (Vacio == "")
                    {
                        MessageBox.Show("Está enviando datos vacios por favor introduzca datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    }
                    else if (double.TryParse(Vacio, out test) == false)
                    {
                        MessageBox.Show("Solo se aceptan numeros, NO LETRAS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    }

                } while (Vacio == "" || double.TryParse(Vacio, out test) == false);
                cuaternio[i] = Convert.ToDouble(Vacio);
            }

            Salida = "(";
            int y = 0;
            string q = "";
            for (y = 0; y < 4; y++)
            {
                switch (y)
                {
                    case 1:
                        q = "i";
                        break;
                    case 2:
                        q = "j";
                        break;
                    case 3:
                        q = "k";
                        break;
                    default:
                        break;
                }
                Salida = Salida + cuaternio[y].ToString() + q+",  ";
            }
            Salida = Salida + ")";
            lstCuaternio.Items.Add(Salida);
            Calcular.Enabled = true;
            return devolver;
            }

        public static string Cuaterniones2(string devolver, ListBox lstCuaternio, Button Calcular)
        {
            double test;
            string Vacio = "";
            int i = 0;
            string p = "";
            string Salida = "";
            lstCuaternio.Items.Clear();
            for (i = 0; i < 4; i++)
            {
                switch (i)
                {
                    case 0:
                        p = "";
                        break;
                    case 1:
                        p = "i";
                        break;
                    case 2:
                        p = "j";
                        break;
                    case 3:
                        p = "k";
                        break;
                    default:
                        break;
                }
                do
                {
                    Vacio = Interaction.InputBox("Ingrese el Punto " + p, "Ingrese el Cuaternio");
                    if (Vacio == "")
                    {
                        MessageBox.Show("Está enviando datos vacios por favor introduzca datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    }
                    else if (double.TryParse(Vacio, out test) == false)
                    {
                        MessageBox.Show("Solo se aceptan numeros, NO LETRAS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    }

                } while (Vacio == "" || double.TryParse(Vacio, out test) == false);
                cuaternio2[i] = Convert.ToDouble(Vacio);
            }

            Salida = "(";
            int y = 0;
            string q = "";
            for (y = 0; y < 4; y++)
            {
                switch (y)
                {
                    case 1:
                        q = "i";
                        break;
                    case 2:
                        q = "j";
                        break;
                    case 3:
                        q = "k";
                        break;
                    default:
                        break;
                }
                Salida = Salida + cuaternio2[y].ToString()+q + ",  ";
            }
            Salida = Salida + ")";
            lstCuaternio.Items.Add(Salida);
            Calcular.Enabled = true;
            return devolver;
        }

        public static string vector1( string devolver, ListBox lstCuaternio)
        {
            double test;
            string Vacio = "";
            int i = 0;
            string p = "";
            string Salida = "";
            lstCuaternio.Items.Clear();
            for (i = 0; i < 3; i++)
            {
                switch (i)
                {
                    case 0:
                        p = "i";
                        break;
                    case 1:
                        p = "j";
                        break;
                    case 2:
                        p = "k";
                        break;
                    default:
                        break;
                }
                do
                {
                    Vacio = Interaction.InputBox("Ingrese el Punto " + p, "Ingrese el Vector");
                    if (Vacio == "")
                    {
                        MessageBox.Show("Está enviando datos vacios por favor introduzca datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    }
                    else if (double.TryParse(Vacio, out test) == false)
                    {
                        MessageBox.Show("Solo se aceptan numeros, NO LETRAS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    }

                } while (Vacio == "" || double.TryParse(Vacio, out test) == false);
                Vector1[i] = Convert.ToDouble(Vacio);
            }

            Salida = "(";
            int y = 0;
            string q = "";
            for (y = 0; y < 3; y++)
            {
                switch (y)
                {
                    case 0:
                        q = "i";
                        break;
                    case 1:
                        q = "j";
                        break;
                    case 2:
                        q = "k";
                        break;
                    default:
                        break;
                }
                Salida = Salida + Vector1[y].ToString() + ",  ";
            }
            Salida = Salida + ")";
            lstCuaternio.Items.Add(Salida);
            return devolver;
        }

        public static string vector2(string devolver, ListBox lstCuaternio)
        {
            lstCuaternio.Items.Clear();
            double test;
            string Vacio = "";
            int i = 0;
            string p = "";
            string Salida = "";
            for (i = 0; i < 3; i++)
            {
                switch (i)
                {
                    case 0:
                        p = "i";
                        break;
                    case 1:
                        p = "j";
                        break;
                    case 2:
                        p = "k";
                        break;
                    default:
                        break;
                }
                do
                {
                    Vacio = Interaction.InputBox("Ingrese el Punto " + p, "Ingrese el Vector");
                    if (Vacio == "")
                    {
                        MessageBox.Show("Está enviando datos vacios por favor introduzca datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    }
                    else if (double.TryParse(Vacio, out test) == false)
                    {
                        MessageBox.Show("Solo se aceptan numeros, NO LETRAS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    }

                } while (Vacio == "" || double.TryParse(Vacio, out test) == false);
                Vector2[i] = Convert.ToDouble(Vacio);
            }

            Salida = "(";
            int y = 0;
            string q = "";
            for (y = 0; y < 3; y++)
            {
                switch (y)
                {
                    case 0:
                        q = "i";
                        break;
                    case 1:
                        q = "j";
                        break;
                    case 2:
                        q = "k";
                        break;
                    default:
                        break;
                }
                Salida = Salida + Vector2[y].ToString()+q + ",  ";
            }
            Salida = Salida + ")";
            lstCuaternio.Items.Add(Salida);
            return devolver;
        }

        public static string ColocarEscalar(string devolver, ListBox lstEscalar)
        {
            string Vacio = "";
            double test;
            string Salida = "";
            lstEscalar.Items.Clear();
            do
            {
                Vacio = Interaction.InputBox("Ingrese el Escalar ", "Ingrese el Escalar");
                if (Vacio == "")
                {
                    MessageBox.Show("Está enviando datos vacios por favor introduzca datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                }
                else if (double.TryParse(Vacio, out test) == false)
                {
                    MessageBox.Show("Solo se aceptan numeros, NO LETRAS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                }

            } while (Vacio == "" || double.TryParse(Vacio, out test) == false);
            Escalar = Convert.ToDouble(Vacio);
            Salida = Escalar.ToString();
            lstEscalar.Items.Add(Salida);
            return devolver;
        }
    }
}
