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
    public partial class BresenhamII : Form
    {
        public BresenhamII()
        {
            InitializeComponent();
        }

        private void BtnVolverMenu_Click(object sender, EventArgs e)
        {
            Matrices.VolverMenu(this, "");
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            lstResultado1.Items.Clear();
            lstResultado2.Items.Clear();
            lstResultado3.Items.Clear();
            lstResultado4.Items.Clear();
            lstResultado5.Items.Clear();
            string Vacio = "";
            double test;
            double[] Punto = new double[2];
            do
            {
                Vacio = Interaction.InputBox("Ingrese el Radio", "Ingrese el Radio de la Circunferencia");
                if (Vacio == "")
                {
                    MessageBox.Show("Está enviando datos vacios por favor introduzca datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                }
               
                else if (double.TryParse(Vacio, out test) == false)
                {
                    MessageBox.Show("Solo se aceptan numeros, NO LETRAS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                }
                else if (Convert.ToDouble(Vacio) == 0)
                {
                    MessageBox.Show("El Radio no puede ser 0", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                }

            } while (Vacio == "" || double.TryParse(Vacio, out test) == false || Convert.ToDouble(Vacio) == 0);
            //Calculos
            Punto[0] = 0;
            Punto[1] = Convert.ToDouble(Vacio);
            int test2;
            double Parametro = 0;
            if (int.TryParse(Vacio, out test2) == false)
            {
                Parametro = (5 / 4) - Punto[1];
            }
            else
            {
                Parametro = 1 - Punto[1];
            }
            double DosX = 0;
            double DosY = 0;
            DosX = Punto[0] * 2;
            DosY = Punto[1] * 2;
            string Salida1 = "";
            string Salida2 = "";
            string Salida3 = "";
            string Salida4 = "";
            string Salida5 = "";
            int i = 0;
            while (Punto[0] < Punto[1])
            {
                Salida2 = Parametro.ToString();
                lstResultado2.Items.Add(Salida2);
                if (Parametro < 0)
                {
                    Punto[0] = Punto[0] + 1;
                    Punto[1] = Punto[1];
                    DosX = Punto[0] * 2;
                    DosY = Punto[1] * 2;
                    Parametro = Parametro + DosX + 1;
                }
                else
                {
                    Punto[0] = Punto[0] + 1;
                    Punto[1] = Punto[1] - 1;
                    DosX = Punto[0] * 2;
                    DosY = Punto[1] * 2;
                    Parametro = Parametro + DosX + 1 - DosY;
                }
                Salida1 = i.ToString();
                Salida3 = "(" + Punto[0].ToString() + ", " + Punto[1].ToString() + ")";
                Salida4 = DosX.ToString();
                Salida5 = DosY.ToString();
                lstResultado1.Visible = true;
                lstResultado2.Visible = true;
                lstResultado3.Visible = true;
                lstResultado4.Visible = true;
                lstResultado5.Visible = true;
                Resultadoes.Visible = true;
                lblK.Visible = true;
                lblPk.Visible = true;
                lbl3.Visible = true;
                lbl4.Visible = true;
                lbl5.Visible = true;
                lstResultado1.Items.Add(Salida1);
                lstResultado3.Items.Add(Salida3);
                lstResultado4.Items.Add(Salida4);
                lstResultado5.Items.Add(Salida5);
                i++;
            }
           
        }
    }
}
