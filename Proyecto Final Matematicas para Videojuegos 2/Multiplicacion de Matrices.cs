using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final_Matematicas_para_Videojuegos_2
{
    public partial class Multiplicacion_de_Matrices : Form
    {
        public Multiplicacion_de_Matrices()
        {
            InitializeComponent();
        }

        private void btnMatriz1_Click(object sender, EventArgs e)
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

            if (Matrices.SiMatriz1 == true && Matrices.SiMatriz2 == true)
            {
                btnMultiplicar.Enabled = true;
            }
        }

        private void btnMatriz2_Click(object sender, EventArgs e)
        {
            DialogResult Pregunta;
            if (Matrices.SiMatriz2 == true)
            {
                Pregunta = MessageBox.Show("¿Realmente desea editar esta matriz?", "Importante", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Pregunta == DialogResult.Yes)
                {
                    Matrices.Matriz2(lstMatriz2, Llave3, Llave4, "");
                }
                else
                {

                }
            }
            else
            {
                Matrices.Matriz2(lstMatriz2, Llave3, Llave4, "");
            }
            if (Matrices.SiMatriz1 == true && Matrices.SiMatriz2 == true)
            {
                btnMultiplicar.Enabled = true;
            }
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            Double[,] MultiMatrices = new Double[Int16.Parse(Matrices.yA), Int16.Parse(Matrices.xB)];
            if (Matrices.xA == Matrices.yB)
            {
                int i, j, k;
                double numeros1 = 0;
                string numeros2 = "";
                lstResultado.Size = new System.Drawing.Size(31 + Int16.Parse(Matrices.yA) * 10, 17 + Int16.Parse(Matrices.xB) * 20);
                lstResultado.Items.Clear();

                for (k = 1; k <= Int16.Parse(Matrices.yA); k++)
                {
                    for (j = 1; j <= Int16.Parse(Matrices.xB); j++)
                    {
                        for (i = 1; i <= Int16.Parse(Matrices.xA); i++)
                        {
                            MultiMatrices[k - 1, j - 1] = Convert.ToDouble(Matrices.MatrizA[i - 1, k - 1]) * Convert.ToDouble(Matrices.MatrizB[j - 1, i - 1]);
                            numeros1 = numeros1 + MultiMatrices[k - 1, j - 1];
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

        private void Multiplicacion_de_Matrices_Load(object sender, EventArgs e)
        {
            if (Matrices.SiMatriz1 == true)
            {
                Matrices.AbrirMatriz(lstMatriz1, Matrices.MatrizA, Llave1, Llave2, Matrices.SiMatriz1, Matrices.xA, Matrices.yA,56 ,Matrices.xA,"");
            }
            if (Matrices.SiMatriz2 == true)
            {
                Matrices.AbrirMatriz(lstMatriz2, Matrices.MatrizB, Llave3, Llave4, Matrices.SiMatriz2, Matrices.xB, Matrices.yB, 335 , Matrices.xB, "");
            }
            if (Matrices.SiMatriz1 == true && Matrices.SiMatriz2 == true)
            {
                btnMultiplicar.Enabled = true;
            }
        }
    }
}
