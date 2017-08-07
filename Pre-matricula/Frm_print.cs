using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Frm_print : Form
    {
        public Frm_print()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            printForm1.Print();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }
    }
}

