﻿using System;
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
    public partial class RestaCuaternios : Form
    {
        public static bool Sumar1 = false;
        public static bool Sumar2 = false;
        public RestaCuaternios()
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
            btnCalcular.Enabled = false;
            Sumar1 = true;
            if (Sumar1 == true && Sumar2 == true)
            {
                btnCalcular.Enabled = true;
            }
        }

        private void btnIngresar2_Click(object sender, EventArgs e)
        {
            Matrices.Cuaterniones2("", listCuaternio2, btnCalcular);
            btnCalcular.Enabled = false;
            Sumar2 = true;
            if (Sumar1 == true && Sumar2 == true)
            {
                btnCalcular.Enabled = true;
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double[] Resultado = new double[4];
            lstResultado.Items.Clear();
            int i = 0;
            string Salida = "";
            string p = "";
            for (i = 0; i < 4; i++)
            {
                switch (i)
                {
                    case 0:
                        p = "";
                        break;
                    case 1:
                        p = "i";
                        break;
                    case 2:
                        p = "j";
                        break;
                    case 3:
                        p = "k";
                        break;

                    default:
                        break;
                }
                Resultado[i] = Matrices.cuaternio[i] - Matrices.cuaternio2[i];
                Salida = Salida  + " " + Resultado[i].ToString()+ p;
            }
            Resultadoes.Visible = true;
            lstResultado.Items.Add(Salida);
            lstResultado.Visible = true;
        }
    }
}
