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
    public partial class VectorCruz : Form
    {
        public static bool Sumar1 = false;
        public static bool Sumar2 = false;
        public VectorCruz()
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
            Matrices.vector2("", listVector2);
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
            double[] Resultado = new double[3];
            string Salida = "";
            string p = "";
            int i = 0;
            Resultado[0] = Matrices.Vector1[1] * Matrices.Vector2[2] - Matrices.Vector1[2]* Matrices.Vector2[1];
            Resultado[1] = Matrices.Vector1[2] * Matrices.Vector2[0] - Matrices.Vector1[0] * Matrices.Vector2[2];
            Resultado[2] = Matrices.Vector1[0] * Matrices.Vector2[1] - Matrices.Vector1[1] * Matrices.Vector2[0];
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
                Salida = Salida + " " + Resultado[i] + p;
               
            }
            Resultadoes.Visible = true;
            lstResultado.Items.Add(Salida);
            lstResultado.Visible = true;
        }
    }
}
