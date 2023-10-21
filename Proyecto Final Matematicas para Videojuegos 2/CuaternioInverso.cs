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
    public partial class CuaternioInverso : Form
    {
        public CuaternioInverso()
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
            lstResultado.Items.Clear();
            double Resultado = 0;
            string Salida0;
            string Salida = "";
            string Linea = "";
            Resultado = Math.Pow(Matrices.cuaternio[0], 2) + Math.Pow(Matrices.cuaternio[1], 2) + Math.Pow(Matrices.cuaternio[2], 2) + Math.Pow(Matrices.cuaternio[3], 2);
            Salida0 = Resultado.ToString();
            Salida = Matrices.cuaternio[0].ToString() + " " + Matrices.cuaternio[1].ToString() + "i " + Matrices.cuaternio[2].ToString() + "j " + Matrices.cuaternio[3].ToString() + "k";
            Linea = "________________________________________________________________________________";
            Resultadoes.Visible = true;
            lstResultado.Items.Add(Salida);
            lstResultado.Items.Add(Linea);
            lstResultado.Items.Add(Salida0);
            lstResultado.Visible = true;
        }
    }
}
