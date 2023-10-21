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
    public partial class MatrizEscalar : Form
    {
        public static bool Sumar1 = false;
        public MatrizEscalar()
        {
            InitializeComponent();
        }

        private void BtnVolverMenu_Click(object sender, EventArgs e)
        {
            Matrices.VolverMenu(this, "");
        }

        private void btnMatriz1_Click(object sender, EventArgs e)
        {
            Matrices.Matriz1(lstMatriz1, Llave1, Llave2, "");
            if (Matrices.SiMatriz1 == true && Sumar1 == true)
            {
                btnSumar.Enabled = true;
            }
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            double[,] Resultado = new double[Int16.Parse(Matrices.xA), Int16.Parse(Matrices.yA)];
            int x = 0;
            int y = 0;
            string Salida = "";
            lstResultado.Items.Clear();
            lstResultado.Size = new System.Drawing.Size(31 + Int16.Parse(Matrices.xA) * 10, 17 + Int16.Parse(Matrices.yA) * 20);
            for (x = 0;x < Int16.Parse(Matrices.yA); x++)
            {
                for (y = 0; y < Int16.Parse(Matrices.xA); y++)
                {
                    Resultado[y, x] = Convert.ToDouble(Matrices.MatrizA[y, x]) * Matrices.Escalar;
                    Salida = Salida + "  " + Resultado[y, x].ToString();
                }
                y = 0;
                lstResultado.Items.Add(Salida);
                Salida = "";
            }
            lstResultado.Visible = true;
            Resultadoes.Visible = true;

        }

        private void btnIngresar2_Click(object sender, EventArgs e)
        {
            Matrices.ColocarEscalar("", listEscalar);
            Sumar1 = true;
            if (Matrices.SiMatriz1 == true && Sumar1 == true)
            {
                btnSumar.Enabled = true;
            }
        }
    }
}
