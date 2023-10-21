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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void btnSumaMatriz_Click(object sender, EventArgs e)
        {
            Suma_de_Matrices nextForm = new Suma_de_Matrices();
            this.Hide();
            nextForm.ShowDialog();
            this.Close();
        }

        private void btnRestaMatriz_Click(object sender, EventArgs e)
        {
           Resta_de_Matrices nextForm = new Resta_de_Matrices();
            this.Hide();
            nextForm.ShowDialog();
            this.Close();
        }

        private void btnMultMatriz_Click(object sender, EventArgs e)
        {
            Multiplicacion_de_Matrices nextForm = new Multiplicacion_de_Matrices();
            this.Hide();
            nextForm.ShowDialog();
            this.Close();
        }

        private void btnMatrizVector_Click(object sender, EventArgs e)
        {
            Matriz_Por_Vector nextForm = new Matriz_Por_Vector();
            this.Hide();
            nextForm.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cuaterniones nextForm = new Cuaterniones();
            this.Hide();
            nextForm.ShowDialog();
            this.Close();
        }

        private void btnMatrizCompuesta_Click(object sender, EventArgs e)
        {
            MatrizCompuest nextForm = new MatrizCompuest();
            this.Hide();
            nextForm.ShowDialog();
            this.Close();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void btnTraslacion_Click(object sender, EventArgs e)
        {
            Traslacion nextForm = new Traslacion();
            this.Hide();
            nextForm.ShowDialog();
            this.Close();
        }

        private void btnRotacion_Click(object sender, EventArgs e)
        {
            Rotacion nextForm = new Rotacion();
            this.Hide();
            nextForm.ShowDialog();
            this.Close();
        }

        private void btnEscalamiento_Click(object sender, EventArgs e)
        {
            Escalamiento nextForm = new Escalamiento();
            this.Hide();
            nextForm.ShowDialog();
            this.Close();
        }

        private void btnCuaternioOpuesto_Click(object sender, EventArgs e)
        {
            CuaternioOpuestoConjugado nextForm = new CuaternioOpuestoConjugado();
            this.Hide();
            nextForm.ShowDialog();
            this.Close();
        }

        private void btnCuaternioVAbsoluto_Click(object sender, EventArgs e)
        {
            CuaternioValorAbsoluto nextForm = new CuaternioValorAbsoluto();
            this.Hide();
            nextForm.ShowDialog();
            this.Close();
        }

        private void btnNormalizacionCuaternios_Click(object sender, EventArgs e)
        {
            NormalizacionCuaternios nextForm = new NormalizacionCuaternios();
            this.Hide();
            nextForm.ShowDialog();
            this.Close();
        }

        private void btnCuaternioInverso_Click(object sender, EventArgs e)
        {
            CuaternioInverso nextForm = new CuaternioInverso();
            this.Hide();
            nextForm.ShowDialog();
            this.Close();
        }

        private void btnRestaCuaternios_Click(object sender, EventArgs e)
        {
            RestaCuaternios nextForm = new RestaCuaternios();
            this.Hide();
            nextForm.ShowDialog();
            this.Close();
        }

        private void btnSumaCuaternios_Click(object sender, EventArgs e)
        {
            SumaCuaternios nextForm = new SumaCuaternios();
            this.Hide();
            nextForm.ShowDialog();
            this.Close();
        }

        private void btnProductoCuaternios_Click(object sender, EventArgs e)
        {
            ProductoCuaternios nextForm = new ProductoCuaternios();
            this.Hide();
            nextForm.ShowDialog();
            this.Close();
        }

        private void btnSumaVectores_Click(object sender, EventArgs e)
        {
            SumaVectores nextForm = new SumaVectores();
            this.Hide();
            nextForm.ShowDialog();
            this.Close();
        }

        private void btnRestaVectores_Click(object sender, EventArgs e)
        {
            RestaVectores nextForm = new RestaVectores();
            this.Hide();
            nextForm.ShowDialog();
            this.Close();
        }

        private void NormalizacionVec_Click(object sender, EventArgs e)
        {
            NormalizacionVector nextForm = new NormalizacionVector();
            this.Hide();
            nextForm.ShowDialog();
            this.Close();
        }

        private void btnCuaternioNulo_Click(object sender, EventArgs e)
        {
            CuaternioNulo nextForm = new CuaternioNulo();
            this.Hide();
            nextForm.ShowDialog();
            this.Close();
        }

        private void VectorCruz_Click(object sender, EventArgs e)
        {
            VectorCruz nextForm = new VectorCruz();
            this.Hide();
            nextForm.ShowDialog();
            this.Close();
        }

        private void btnMultVec_Click(object sender, EventArgs e)
        {
            MultiplicacionVector nextForm = new MultiplicacionVector();
            this.Hide();
            nextForm.ShowDialog();
            this.Close();
        }

        private void btnMatrizTraspuesta_Click(object sender, EventArgs e)
        {
            MatrizTranspuesta nextForm = new MatrizTranspuesta();
            this.Hide();
            nextForm.ShowDialog();
            this.Close();
        }

        private void BresenI_Click(object sender, EventArgs e)
        {
            BresenhamI nextForm = new BresenhamI();
            this.Hide();
            nextForm.ShowDialog();
            this.Close();
        }

        private void BresenII_Click(object sender, EventArgs e)
        {
            BresenhamII nextForm = new BresenhamII();
            this.Hide();
            nextForm.ShowDialog();
            this.Close();
        }

        private void BresenIII_Click(object sender, EventArgs e)
        {
            BresenhamIII nextForm = new BresenhamIII();
            this.Hide();
            nextForm.ShowDialog();
            this.Close();
        }

        private void btnGrassman_Click(object sender, EventArgs e)
        {
            Grassman nextForm = new Grassman();
            this.Hide();
            nextForm.ShowDialog();
            this.Close();
        }

        private void btnMatrizXEscalar_Click(object sender, EventArgs e)
        {
            MatrizEscalar nextForm = new MatrizEscalar();
            this.Hide();
            nextForm.ShowDialog();
            this.Close();
        }
    }
}
