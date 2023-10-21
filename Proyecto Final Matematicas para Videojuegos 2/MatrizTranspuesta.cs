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
    public partial class MatrizTranspuesta : Form
    {
        public MatrizTranspuesta()
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
            if (Matrices.SiMatriz1 == true)
            {
                btnSumar.Enabled = true;
            }
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            double[,] Resultado = new double[Int16.Parse(Matrices.yA), Int16.Parse(Matrices.xA)];
            int i = 0;
            int j = 0;
            string Salida = "";
            lstResultado.Items.Clear();
            lstResultado.Size = new System.Drawing.Size(31 + Int16.Parse(Matrices.yA) * 10, 17 + Int16.Parse(Matrices.xA) * 20);
            for (i = 0; i < Int16.Parse(Matrices.xA); i++)
            {
                for (j = 0; j < Int16.Parse(Matrices.yA); j++)
                {
                    Resultado[j,i] = Convert.ToDouble(Matrices.MatrizA[i,j]);
                    Salida = Salida + "  " +Resultado[j, i].ToString();
                }
                
                j = 0;
                lstResultado.Items.Add(Salida);
                Salida = "";
            }
            lstResultado.Visible = true;
            Resultadoes.Visible = true;

        }
    }
}
