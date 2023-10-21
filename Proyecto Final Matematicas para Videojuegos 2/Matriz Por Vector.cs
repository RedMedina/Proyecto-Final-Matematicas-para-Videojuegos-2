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
    public partial class Matriz_Por_Vector : Form
    {
        public Matriz_Por_Vector()
        {
            InitializeComponent();
        }
       
        private void btnMatriz_Click(object sender, EventArgs e)
        {
            DialogResult Pregunta;
            if (Matrices.SiMatriz1 == true)
            {
                Pregunta = MessageBox.Show("¿Realmente desea editar esta matriz?", "Importante", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Pregunta == DialogResult.Yes)
                {
                    Matrices.Matriz1(lstMatriz1, Llave1, Llave2, "");
                }
                else
                {

                }
            }
            else
            {
                Matrices.Matriz1(lstMatriz1, Llave1, Llave2, "");

            }

            if (Matrices.SiMatriz1 == true && Matrices.SiVector == true)
            {
                btnMultiplicar.Enabled = true;
            }
        }

        private void btnVector_Click(object sender, EventArgs e)
        {
            DialogResult Pregunta;
            if (Matrices.SiVector == true)
            {
                Pregunta = MessageBox.Show("¿Realmente desea editar el vector?", "Importante", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Pregunta == DialogResult.Yes)
                {
                    Matrices.ColocarVector(lstVector, "");
                }
                else
                {

                }
            }
            else
            {
                Matrices.ColocarVector(lstVector, "");

            }

           
            if (Matrices.SiMatriz1 == true && Matrices.SiVector == true)
            {
                btnMultiplicar.Enabled = true;
            }
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            if (Matrices.xA == 3.ToString())
            {
                Double[,] MatrizPorVector = new Double[Int16.Parse(Matrices.yA), 1];

                int i, j, k;
                double numeros1 = 0;
                string numeros2 = "";
                lstResultado.Size = new System.Drawing.Size(31 + Int16.Parse(Matrices.yA) * 10, 17 + 2* 20);
                lstResultado.Items.Clear();

                for (k = 1; k <= Int16.Parse(Matrices.yA); k++)
                {
                    for (j = 1; j <= 1; j++)
                    {
                        for (i = 1; i <= Int16.Parse(Matrices.xA); i++)
                        {
                            MatrizPorVector[k - 1, j - 1] = Convert.ToDouble(Matrices.MatrizA[i - 1, k - 1]) * Convert.ToDouble(Matrices.vector[j - 1, i-1]);
                            numeros1 = numeros1 + MatrizPorVector[k - 1, j - 1];
                        }
                        i = 1;
                        numeros2 = numeros2 + numeros1.ToString() + "  ";
                        numeros1 = 0;
                    }
                    lstResultado.Items.Add(numeros2);
                    numeros2 = "";
                    j = 1;
                }


                lstResultado.Visible = true;
                Resultadoes.Visible = true;
            }
            else
            {
                MessageBox.Show("El numero de filas y columnas de las matrices no coinciden, por favor verifique la operación", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
        }

        private void BtnVolverMenu_Click(object sender, EventArgs e)
        {
            Matrices.VolverMenu(this, "");
        }

        private void Matriz_Por_Vector_Load(object sender, EventArgs e)
        {
            if (Matrices.SiMatriz1 == true)
            {
                Matrices.AbrirMatriz(lstMatriz1, Matrices.MatrizA, Llave1, Llave2, Matrices.SiMatriz1, Matrices.xA, Matrices.yA, 56, Matrices.xA, "");
            }
            if (Matrices.SiVector == true)
            {
                int i;
                string numeros = "";
                string puntodelVector = "";

                for (i = 1; i<=3;i++)
                {
                    switch (i)
                    {
                        case 1:
                            puntodelVector = "i,";
                            break;
                        case 2:
                            puntodelVector = "j,";
                            break;
                        case 3:
                            puntodelVector = "k";
                            break;
                    }
                    numeros = numeros + Matrices.vector[0,i-1].ToString() + puntodelVector + "  ";
                }
                lstVector.Items.Add("("+numeros+")");
                lstVector.Visible = true;

            }
            if (Matrices.SiMatriz1 == true && Matrices.SiVector == true)
            {
                btnMultiplicar.Enabled = true;
            }
        }
    }
}
