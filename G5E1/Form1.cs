using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace G5E1
{
    public partial class Form1 : Form
    {
        /*
         * EJERCICIO 1 GUIA 5
         * PROGRAMACION ESTRUCTURADA
         * 
         * OSCAR ROLANDO CAÑAS VALDIZON
         */

        /*
         * EJERCICIO 2 GUIA 5
         * PROGRAMACION ESTRUCTURADA
         * 
         * NOTA. Revisar lineas "87 a 94" y lineas "119 a 126"
         * 
         * OSCAR ROLANDO CAÑAS VALDIZON
         */

        string name;
        double salary_base, salary, discount;
        int job;

        public Form1()
        {
            InitializeComponent();
            name_Tip.SetToolTip(name_Label, "Aqui escribe el nombre del empleado");
            name_Tip.ToolTipTitle = "Casilla Nombre";
            salary_Tip.SetToolTip(salary_Label, "Aqui escriba el salario del empleado (debe ser en $USD");
            salary_Tip.ToolTipTitle = "Casilla Salario Base";
            job_Tip.SetToolTip(job_Label, "Seleccione correctamente el puesto de la persona");
            job_Tip.ToolTipTitle = "Casilla Puesto Laboral";
        }

        private void calculate_Button_Click(object sender, EventArgs e)
        {
            if (job == 1)
            {
                discount = salary_base * 0.20;
                salary = salary_base - discount;
                Form2 frm = new Form2(name, salary, discount, job);
                frm.Show();
            }
            else if (job == 2)
            {
                discount = salary_base * 0.15;
                salary = salary_base - discount;
                Form2 frm = new Form2(name, salary, discount, job);
                frm.Show();
            }
            else if (job == 3)
            {
                discount = salary_base * 0.05;
                salary = salary_base - discount;
                Form2 frm = new Form2(name, salary, discount, job);
                frm.Show();
            }
            else if (job == 0)
            {
                MessageBox.Show("No has seleccionado ningun tipo de posicion laboral.", "Error en el programa...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void usd_Label_Click(object sender, EventArgs e)
        {

        }

        private void exit_Button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void code_Button_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://github.com/Oscar-02/G5E1");
            }
            catch
            {
                MessageBox.Show("Ocurrio un error al redirigir al URL.", "Error en el programa...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void name_Box_TextChanged(object sender, EventArgs e)
        {
            name = name_Box.Text;
        }

        private void name_Label_Click(object sender, EventArgs e)
        {
            
        }

        private void salary_Label_Click(object sender, EventArgs e)
        {
            
        }

        private void job_Label_Click(object sender, EventArgs e)
        {

        }

        private void salary_Box_TextChanged(object sender, EventArgs e)
        {
            try
            {
                salary_base = double.Parse(salary_Box.Text);
            }
            catch
            {
                MessageBox.Show("Has ingresado un valor no valido. Solo ingresa valores numericos.", "Error en el programa...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void job_Combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            job = job_Combo.SelectedIndex;
        }
    }
}
