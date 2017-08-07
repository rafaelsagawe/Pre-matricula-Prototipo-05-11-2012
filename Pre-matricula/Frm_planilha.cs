using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Microsoft.Office.Interop.Excel;



namespace WindowsFormsApplication1
{
    public partial class Frm_planilha : Form
    {
        public Frm_planilha()
        {
            InitializeComponent();
        }

        private void cadALUNOSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cadALUNOSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.prototipo_DBDataSet);

        }

        private void Frm_planilha_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'prototipo_DBDataSet.CadALUNOS' table. You can move, or remove it, as needed.
            this.cadALUNOSTableAdapter.Fill(this.prototipo_DBDataSet.CadALUNOS);

        }

               

        private void cadALUNOSDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application excelapp =
               new Microsoft.Office.Interop.Excel.Application();

            Microsoft.Office.Interop.Excel._Workbook workbook =
                excelapp.Workbooks.Add(Type.Missing);

            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

            excelapp.Visible = true;

            try
            {
                // pegando a primeira planilha do excel;
                // deixando-a como ativa e ao final, 
                // será atribuido um nome a ela.
                worksheet = (Worksheet)workbook.Sheets["Plan1"];
                worksheet = (Worksheet)workbook.ActiveSheet;
                worksheet.Name = "Exportado de um DataGridView";

                // pegando os nomes das colunas do DataGridView
                for (int i = 1; i < cadALUNOSDataGridView.Columns.Count + 1; i++)
                {
                    worksheet.Cells[1, i] =
                        cadALUNOSDataGridView.Columns[i - 1].HeaderText;
                }

                // fazendo um loop no DataGridView, que recupera as rows
                // do DataGridView, correspondente a cada column.
                for (int i = 0; i < cadALUNOSDataGridView.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < cadALUNOSDataGridView.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] =
                            cadALUNOSDataGridView.Rows[i].Cells[j].Value.ToString();
                    }
                }

                // ao final, salva no formato do Excel.
                workbook.SaveAs(@"C:\DGVToExcel.xlsx",
                    Type.Missing, Type.Missing, Type.Missing,
                    Type.Missing, Type.Missing,
                    Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive,
                    Type.Missing, Type.Missing, Type.Missing,
                    Type.Missing, Type.Missing);

                MessageBox.Show("Arquivo criado com sucesso");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        
        }
    }
}
