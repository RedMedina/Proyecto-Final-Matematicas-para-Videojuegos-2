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
    public partial class CuaternioOpuestoConjugado : Form
    {
        public CuaternioOpuestoConjugado()
        {
            InitializeComponent();
        }

        private void BtnVolverMenu_Click(object sender, EventArgs e)
        {
            Matrices.VolverMenu(this, "");
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Matrices.Cuaterniones("", listCuaternio, btnCalcular);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string Salida = "";
            int y = 0;
            DialogResult Respuesta;
            Respuesta = MessageBox.Show("Desea que se calcule el cuaternio opuesto? Si selecciona <No> se calculará el cuaternio conjugado", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            lstResultado.Items.Clear();
            if (Respuesta == DialogResult.Yes)
            {
                double[] CuaternioOpuesto = new double [4];
                int i = 0;
                for (i = 0; i < 4; i++)
                {
                    CuaternioOpuesto[i] = -1 * Matrices.cuaternio[i];
                }
                Salida = "(";
                for (y = 0; y < 4; y++)
                {
                    Salida = Salida + CuaternioOpuesto[y].ToString() + ",  ";
                }

            }
            else
            {
                double[] CuaternioConjugado = new double[4];
                int i = 0;
                CuaternioConjugado[0] = Matrices.cuaternio[0];
                for (i = 0; i < 3; i++)
                {
                    CuaternioConjugado[i+1] = -1 * Matrices.cuaternio[i+1];
                }
                Salida = "(";
                for (y = 0; y < 4; y++)
                {
                    Salida = Salida + CuaternioConjugado[y].ToString() +  ",  ";
                }
            }
            Salida = Salida + ")";
            Resultadoes.Visible = true;
            lstResultado.Items.Add(Salida);
            lstResultado.Visible = true;
        }
    }
}
