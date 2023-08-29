using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConversorParcial
{
    public partial class Form1 : Form
    {
        String[][] Conversores = new string[][]{
            new string[]{ },
            new string[]{"Pie cuadrado", "Vara cuadrada", "Yarda cuadrada", "Metro cuadrado", "Tareas", "Manzana", "Hectárea"}
        };
        public Form1()
        {
            InitializeComponent();
        }

        private void cboConvertirConversor_Click(object sender, EventArgs e)
        {
            {
                int de, a;
                double cantidad, respuesta;

                de = cboDeConversor.SelectedIndex;
                a = cboAConversor.SelectedIndex;

                cantidad = double.Parse(txtCantidadConversor.Text);
                // Pie cuadrado, Vara cuadrada, Yarda 
                double[][] medida = {
            new double[]{ 0.13223087609, 0.1111, 0.092903, 0.00014774656489, 6988.96, 0.00000929368}, // medidas
        };
                respuesta = medida[cboTipoConversor.SelectedIndex][a] / medida[cboTipoConversor.SelectedIndex][de] * cantidad;
                lblRespuestaConversor.Text = "Respuesta: " + Math.Round(respuesta, 3);
            


            }
        }

        private void txtCantidadConversor_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboTipoConversor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboTipoConversor_TextChanged(object sender, EventArgs e)
        {
        }

        private void cboAConversor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblRespuestaConversor_Click(object sender, EventArgs e)
        {

        }

        private void lblCantidadConversor_Click(object sender, EventArgs e)
        {

        }

        private void cboDeConversor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}