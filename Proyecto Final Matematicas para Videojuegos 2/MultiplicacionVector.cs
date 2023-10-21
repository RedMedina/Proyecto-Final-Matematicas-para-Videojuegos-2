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
    public partial class MultiplicacionVector : Form
    {
        public static bool Sumar1 = false;
        public static bool Sumar2 = false;
        public MultiplicacionVector()
        {
            InitializeComponent();
        }

        private void BtnVolverMenu_Click(object sender, EventArgs e)
        {
            Matrices.VolverMenu(this, "");
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Matrices.vector1("", listVector);
            btnCalcular.Enabled = false;
            Sumar1 = true;
            if (Sumar1 == true && Sumar2 == true)
            {
                btnCalcular.Enabled = true;
            }

        }

        private void btnIngresar2_Click(object sender, EventArgs e)
        {
            Matrices.ColocarEscalar("", listEscalar);
            btnCalcular.Enabled = false;
            Sumar2 = true;
            if (Sumar1 == true && Sumar2 == true)
            {
                btnCalcular.Enabled = true;
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            lstResultado.Items.Clear();
            string Salida = "";
            double[] Resultado = new double[3];
            string p = "";
            int i = 0;
            for (i = 0; i < 3; i++)
            {
                Resultado[i] = Matrices.Vector1[i] * Matrices.Escalar;
            }
            int y = 0;
            for (y = 0; y < 3; y++)
            {
                switch (y)
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
                Salida = Salida + " " + Resultado[y] + p;
            }
            Resultadoes.Visible = true;
            lstResultado.Items.Add(Salida);
            lstResultado.Visible = true;
        }
    }
}
