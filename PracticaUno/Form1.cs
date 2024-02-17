using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaUno
{
    public partial class Lbl_Ecuacion : Form
    {
        public Lbl_Ecuacion()
        {
            InitializeComponent();
        }
        private void Btn_Resolver_Click(object sender, EventArgs e)
        {
            double a, b, c, x1, x2;

            // Validar la entrada para a
            if (!double.TryParse(Tbx_a.Text, out a))
            {
                MessageBox.Show("Ingrese un valor numérico para a", "Error");
                Tbx_a.Focus();
                return;
            }

            // Validar la entrada para b
            if (!double.TryParse(Tbx_b.Text, out b))
            {
                MessageBox.Show("Ingrese un valor numérico para b", "Error");
                Tbx_b.Focus();
                return;
            }

            // Validar la entrada para c
            if (!double.TryParse(Tbx_c.Text, out c))
            {
                MessageBox.Show("Ingrese un valor numérico para c", "Error");
                Tbx_c.Focus();
                return;
            }

            // Calcular el discriminante
            double discriminante = Math.Pow(b, 2) - 4 * a * c;

            // Calcular las raíces de la ecuación cuadrática
            if (discriminante > 0)
            {
                x1 = (-b + Math.Sqrt(discriminante)) / (2 * a);
                x2 = (-b - Math.Sqrt(discriminante)) / (2 * a);
                Lbl_x1.Text = "x1 = " + x1.ToString();
                Lbl_x2.Text = "x2 = " + x2.ToString();
            }
            else if (discriminante == 0)
            {
                x1 = -b / (2 * a);
                Lbl_x1.Text = "x1 = x2 = " + x1.ToString();
                Lbl_x2.Text = "";
            }
            else
            {
                // Calcular la parte real e imaginaria de las raíces complejas
                double parteReal = -b / (2 * a);
                double parteImaginaria = Math.Sqrt(-discriminante) / (2 * a);
                Lbl_x1.Text = "x1 = " + parteReal.ToString("F2") + " + " + parteImaginaria.ToString("F2") + "i";
                Lbl_x2.Text = "x2 = " + parteReal.ToString("F2") + " - " + parteImaginaria.ToString("F2") + "i";
            }

            Lbl_a.Text = Convert.ToString(a);
            Lbl_b.Text = Convert.ToString(b);
            Lbl_c.Text = Convert.ToString(c);
        }


        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}