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
    public partial class Frm_Cadastro : Form
    {
        public Frm_Cadastro()
        {
            InitializeComponent();
        }
        private void cadALUNOSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cadALUNOSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.prototipo_DBDataSet);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'prototipo_DBDataSet.CadALUNOS' table. You can move, or remove it, as needed.
            this.cadALUNOSTableAdapter.Fill(this.prototipo_DBDataSet.CadALUNOS);
            // TODO: This line of code loads data into the 'prototipo_DBDataSet.CadALUNOS' table. You can move, or remove it, as needed.
            this.cadALUNOSTableAdapter.Fill(this.prototipo_DBDataSet.CadALUNOS);
        }
        private void cadALUNOSBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.cadALUNOSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.prototipo_DBDataSet);
        }
        //rotina para quando fechar o formulario seja salvo o trabalho
        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.cadALUNOSBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.prototipo_DBDataSet);
                MessageBox.Show("Registro salvo e encerrando a aplicação", "Informa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao salvar", "Informa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Application.Exit();
        }
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Frm_consulta frm = new Frm_consulta();
            frm.ShowDialog();
        }
        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
            this.cadALUNOSTableAdapter.FillBy_buscaAluno(prototipo_DBDataSet.CadALUNOS, toolStripTextBox1.Text);
        }
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Frm_About frm = new Frm_About();
            frm.ShowDialog();
        }
        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_print frm = new Frm_print();
            frm.ShowDialog();
        }
        private void idade1TextBox_TextChanged(object sender, EventArgs e)
        {
        }
        private void toolStripButton4_Click_1(object sender, EventArgs e)
        {
            DateTime bday = new DateTime();
            bday = Convert.ToDateTime(idNascDateTimePicker.Text);
            int date = dTP_hoje.Value.Year;
            int age = date - bday.Year;
            MessageBox.Show(age.ToString());
           }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            Frm_planilha frm = new Frm_planilha();
            frm.ShowDialog();
        }
    }
}
