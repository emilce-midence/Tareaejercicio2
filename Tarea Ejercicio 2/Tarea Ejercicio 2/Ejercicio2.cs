using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea_Ejercicio_2
{
    public partial class Ejercicio2 : Form
    {
        public Ejercicio2()
        {
            InitializeComponent();
        }

        private void Calcularbutton1_Click(object sender, EventArgs e)
        {
            double nota1, nota2, nota3, nota4, promedio;
            string condicion;

            nota1 = double.Parse(IngresartextBox1.Text);
            nota2 = double.Parse(IngresartextBox2.Text);
            nota3 = double.Parse(IngresartextBox3.Text);
            nota4 = double.Parse(IngresartextBox4.Text);

            promedio = (nota1 + nota2 + nota3 + nota4) / 4;

            if (promedio <= 64)
            {
                condicion = "DESAPROBADO";
                PromediotextBox1.Text = promedio.ToString();
                CondiciontextBox1.Text = condicion;
            }
            else if (promedio > 65 && promedio <= 100)
            {
                condicion = "APROBADO";
                PromediotextBox1.Text = promedio.ToString();
                CondiciontextBox1.Text = condicion;
            }

        }

        private void Limpiarbutton1_Click(object sender, EventArgs e)
        {
            IngresartextBox1.Clear();
            IngresartextBox2.Clear();
            IngresartextBox3.Clear();
            IngresartextBox4.Clear();
            CondiciontextBox1.Clear();
            IngresartextBox1.Focus();
        }
    }
}
