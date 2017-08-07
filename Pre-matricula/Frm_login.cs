using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Frm_login : Form
    {
        public Frm_login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             //int result = equipeTableAdapter.FillByEquipeLogin(_Database_para_C_DataSet.equipe, textBox1.Text, textBox2.Text);
            //if (result == 1)

           //login pre programado
            //if ((cbB_login.Text == "Cadastrar aluno") && (textBox2.Text == "123"))
            if (mTB_senha.Text == "123")
           
           //chamando tela principal da aplicação
            {
                Frm_Cadastro frap = new Frm_Cadastro();
                frap.Show();
                this.Visible = false;
            }
            else
            {
                // resultado negativo do teste do login
                MessageBox.Show("Usuario ou senha invalidos", "Ocorreu um erro ao autenticar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_cancela_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mTB_senha_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }           
        }
        }
