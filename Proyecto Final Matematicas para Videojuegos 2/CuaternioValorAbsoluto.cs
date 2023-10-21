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
    public partial class CuaternioValorAbsoluto : Form
    {
        public CuaternioValorAbsoluto()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Matrices.Cuaterniones("", listCuaternio, btnCalcular);
        }

        private void BtnVolverMenu_Click(object sender, EventArgs e)
        {
            Matrices.VolverMenu(this, "");
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            lstResultado.Items.Clear();
            double Resultado = 0;
            string Salida;
            Resultado = Math.Sqrt(Math.Pow(Matrices.cuaternio[0],2) + Math.Pow(Matrices.cuaternio[1], 2) + Math.Pow(Matrices.cuaternio[2], 2) + Math.Pow(Matrices.cuaternio[3], 2));
            Salida = Resultado.ToString();
            Resultadoes.Visible = true;
            lstResultado.Items.Add(Salida);
            lstResultado.Visible = true;
        }
    }
}
