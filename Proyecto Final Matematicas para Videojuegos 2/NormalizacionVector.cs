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
    public partial class NormalizacionVector : Form
    {
        public static bool Sumar1 = false;
        public NormalizacionVector()
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
            if (Sumar1 == true)
            {
                btnCalcular.Enabled = true;
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            lstResultado.Items.Clear();
            double Resultado = 0;
            string Salida = "";
            string Linea = "";
            string Salida0;
            Resultado = Math.Sqrt(Math.Pow(Matrices.Vector1[0],2) + Math.Pow(Matrices.Vector1[1],2) + Math.Pow(Matrices.Vector1[2],2));
            Salida0 = Resultado.ToString();
            Salida = Matrices.Vector1[0].ToString() + "i " + Matrices.Vector1[1].ToString() + "j " + Matrices.Vector1[2].ToString() + "k";
            Linea = "________________________________________________________________________________";
            Resultadoes.Visible = true;
            lstResultado.Items.Add(Salida);
            lstResultado.Items.Add(Linea);
            lstResultado.Items.Add(Salida0);
            lstResultado.Visible = true;
        }
    }
}
