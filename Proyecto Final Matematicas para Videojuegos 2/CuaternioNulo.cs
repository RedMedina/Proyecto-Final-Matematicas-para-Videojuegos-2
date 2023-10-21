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
    public partial class CuaternioNulo : Form
    {
        public CuaternioNulo()
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
            if (Matrices.cuaternio[0] == 0 && Matrices.cuaternio[1] == 0 && Matrices.cuaternio[2] == 0 && Matrices.cuaternio[3] == 0)
            {
                MessageBox.Show("El Cuaternio es Nulo", "Cuaternio", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("El Cuaternio NO es Nulo", "Cuaternio", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
