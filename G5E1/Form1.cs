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
        string name;
        double salary_base, salary, discount;
        int job;

        public Form1()
        {
            InitializeComponent();
        }

        private void calculate_Button_Click(object sender, EventArgs e)
        {
            if (job == 0)
            {
                discount = salary_base * 0.20;
                salary = salary_base - discount;
            }
            else if (job == 1)
            {
                discount = salary_base * 0.15;
                salary = salary_base - discount;
            }
            else if (job == 2)
            {
                discount = salary_base * 0.05;
                salary = salary_base - discount;
            }
            Form2 frm = new Form2(name, salary, discount, job);
            frm.Show();
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
            System.Diagnostics.Process.Start("https://github.com/Oscar-02/G5E1");
        }

        private void name_Box_TextChanged(object sender, EventArgs e)
        {
            name = name_Box.Text;
        }

        private void salary_Box_TextChanged(object sender, EventArgs e)
        {
            salary_base = double.Parse(salary_Box.Text);
        }

        private void job_Combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            job = job_Combo.SelectedIndex;
        }
    }
}
