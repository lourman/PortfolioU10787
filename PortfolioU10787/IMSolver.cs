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

        private void button1_Click_1(object sender, EventArgs e)
        {
            uint[] ints = new uint[2];
            ints[0] = 2;
            ints[1] = 20;
            //ints[2] = 20;
            MathSolving ms = new MathSolving();
            ms.CalculateGCD(ints, true);
        }
    }
}
