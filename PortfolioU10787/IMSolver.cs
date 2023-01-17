using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PortfolioU10787
{
    public partial class IMSolver : Form
    {
        public IMSolver()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MathSolving equation = new MathSolving();

            //this.Text = equation.SolveEquation(textBox1.Text).ToString();

        }
    }
}
