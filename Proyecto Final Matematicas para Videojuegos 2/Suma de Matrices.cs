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
    public partial class Suma_de_Matrices : Form
    {
        public Suma_de_Matrices()
        {
            InitializeComponent();
        }
        private void BtnVolverMenu_Click(object sender, EventArgs e)
        {
            Matrices.VolverMenu(this, "");
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
                btnSumar.Enabled = true;
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
                btnSumar.Enabled = true;
            }
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            int[,] sumaMatrices = new int[Int16.Parse(Matrices.xA), Int16.Parse(Matrices.yA)];
            if (Matrices.xA == Matrices.xB && Matrices.yA == Matrices.yB)
            {


                int i, j;
                string numeros = "";
                lstResultado.Size = new System.Drawing.Size(31 + Int16.Parse(Matrices.xA) * 10, 17 + Int16.Parse(Matrices.yA) * 20);
                lstResultado.Items.Clear();
                for (j = 1; j <= Int16.Parse(Matrices.yA); j++)
                {
                    for (i = 1; i <= Int16.Parse(Matrices.xA); i++)
                    {
                        sumaMatrices[i - 1, j - 1] = Int16.Parse(Matrices.MatrizA[i - 1, j - 1]) + Int16.Parse(Matrices.MatrizB[i - 1, j - 1]);
                        numeros = numeros + sumaMatrices[i - 1, j - 1] + "   ";
                    }
                    lstResultado.Items.Add(numeros);
                    numeros = "";
                    i = 1;
                }
                lstResultado.Visible = true;
                Resultadoes.Visible = true;
            }
            else
            {
                MessageBox.Show("El numero de filas y columnas de las matrices no coinciden, por favor verifique la operación", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
        }

        private void Suma_de_Matrices_Load(object sender, EventArgs e)
        {
            if (Matrices.SiMatriz1 == true)
            {
                Matrices.AbrirMatriz(lstMatriz1, Matrices.MatrizA, Llave1, Llave2, Matrices.SiMatriz1, Matrices.xA, Matrices.yA, 56, Matrices.xA, "");
            }
            if (Matrices.SiMatriz2 == true)
            {
                Matrices.AbrirMatriz(lstMatriz2, Matrices.MatrizB, Llave3, Llave4, Matrices.SiMatriz2, Matrices.xB, Matrices.yB, 335, Matrices.xB, "");
            }
            if (Matrices.SiMatriz1 == true && Matrices.SiMatriz2 == true)
            {
                btnSumar.Enabled = true;
            }
        }
    }
}
