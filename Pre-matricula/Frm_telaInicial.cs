﻿using System;
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
    public partial class Frm_telaInicial : Form
    {
        public Frm_telaInicial()
        {

            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
            progressBar1.Value = progressBar1.Value + 2;
            }
            else
            {
                timer1.Enabled = false;
            Frm_login frl = new Frm_login();
            frl.Show();
            this.Visible = false;
            }
        }

            
        }

       }
