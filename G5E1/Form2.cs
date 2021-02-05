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
    public partial class Form2 : Form
    {
        string name_recieve;
        double salary_recieve, discount_recieve;
        int job_recieve;

        public Form2(string name, double salary, double discount, int job)
        {
            InitializeComponent();
            name_recieve = name;
            salary_recieve = salary;
            discount_recieve = discount;
            job_recieve = job;
        }

        private void name_Box_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            name_Box.Text = name_recieve;
            if (job_recieve == 0)
            {
                job_Box.Text = "Gerente";
            }
            else if (job_recieve == 1)
            {
                job_Box.Text = "Subgerente";
            }
            else if (job_recieve == 2)
            {
                job_Box.Text = "Secretaria";
            }
            salary_base_Box.Text = Convert.ToString(salary_recieve + discount_recieve);
            discount_Box.Text = Convert.ToString(discount_recieve);
            salary_Box.Text = Convert.ToString(salary_recieve);
        }
    }
}
