namespace WindowsFormsApplication1
{
    partial class Frm_consulta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_consulta));
            this.prototipo_DBDataSet = new WindowsFormsApplication1.prototipo_DBDataSet();
            this.cadALUNOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cadALUNOSTableAdapter = new WindowsFormsApplication1.prototipo_DBDataSetTableAdapters.CadALUNOSTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication1.prototipo_DBDataSetTableAdapters.TableAdapterManager();
            this.cadALUNOSBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cadALUNOSBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SERIE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.turno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idade1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PortadorNesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cadALUNOSDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn76 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn80 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn38 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn77 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Irmao1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn78 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Irmao2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn79 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Irmao3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.prototipo_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadALUNOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadALUNOSBindingNavigator)).BeginInit();
            this.cadALUNOSBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cadALUNOSDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // prototipo_DBDataSet
            // 
            this.prototipo_DBDataSet.DataSetName = "prototipo_DBDataSet";
            this.prototipo_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cadALUNOSBindingSource
            // 
            this.cadALUNOSBindingSource.DataMember = "CadALUNOS";
            this.cadALUNOSBindingSource.DataSource = this.prototipo_DBDataSet;
            // 
            // cadALUNOSTableAdapter
            // 
            this.cadALUNOSTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CadALUNOSTableAdapter = this.cadALUNOSTableAdapter;
            this.tableAdapterManager.ConfidencialTableAdapter = null;
            this.tableAdapterManager.TUsersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplication1.prototipo_DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cadALUNOSBindingNavigator
            // 
            this.cadALUNOSBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.cadALUNOSBindingNavigator.BindingSource = this.cadALUNOSBindingSource;
            this.cadALUNOSBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.cadALUNOSBindingNavigator.CountItemFormat = "de {0}";
            this.cadALUNOSBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.cadALUNOSBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripTextBox1,
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.cadALUNOSBindingNavigatorSaveItem});
            this.cadALUNOSBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.cadALUNOSBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.cadALUNOSBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.cadALUNOSBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.cadALUNOSBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.cadALUNOSBindingNavigator.Name = "cadALUNOSBindingNavigator";
            this.cadALUNOSBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.cadALUNOSBindingNavigator.Size = new System.Drawing.Size(1010, 25);
            this.cadALUNOSBindingNavigator.TabIndex = 0;
            this.cadALUNOSBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(75, 22);
            this.toolStripLabel1.Text = "Buscar aluno";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 25);
            this.toolStripTextBox1.Click += new System.EventHandler(this.toolStripTextBox1_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // cadALUNOSBindingNavigatorSaveItem
            // 
            this.cadALUNOSBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cadALUNOSBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("cadALUNOSBindingNavigatorSaveItem.Image")));
            this.cadALUNOSBindingNavigatorSaveItem.Name = "cadALUNOSBindingNavigatorSaveItem";
            this.cadALUNOSBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.cadALUNOSBindingNavigatorSaveItem.Text = "Save Data";
            this.cadALUNOSBindingNavigatorSaveItem.Click += new System.EventHandler(this.cadALUNOSBindingNavigatorSaveItem_Click);
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "IdNome";
            this.dataGridViewTextBoxColumn4.HeaderText = "IdNome";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // SERIE
            // 
            this.SERIE.DataPropertyName = "SERIE";
            this.SERIE.HeaderText = "SERIE";
            this.SERIE.Name = "SERIE";
            // 
            // turno
            // 
            this.turno.DataPropertyName = "turno";
            this.turno.HeaderText = "turno";
            this.turno.Name = "turno";
            // 
            // idade1
            // 
            this.idade1.DataPropertyName = "idade1";
            this.idade1.HeaderText = "idade1";
            this.idade1.Name = "idade1";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "IdNome";
            this.dataGridViewTextBoxColumn5.HeaderText = "IdNome";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "SERIE";
            this.dataGridViewTextBoxColumn1.HeaderText = "SERIE";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "turno";
            this.dataGridViewTextBoxColumn2.HeaderText = "turno";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // PortadorNesc
            // 
            this.PortadorNesc.DataPropertyName = "PortadorNesc";
            this.PortadorNesc.HeaderText = "PortadorNesc";
            this.PortadorNesc.Name = "PortadorNesc";
            // 
            // IdNome
            // 
            this.IdNome.DataPropertyName = "IdNome";
            this.IdNome.HeaderText = "IdNome";
            this.IdNome.Name = "IdNome";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "SERIE";
            this.dataGridViewTextBoxColumn6.HeaderText = "SERIE";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "idade1";
            this.dataGridViewTextBoxColumn3.HeaderText = "idade1";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "PortadorNesc";
            this.dataGridViewTextBoxColumn7.HeaderText = "PortadorNesc";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "IdNome";
            this.dataGridViewTextBoxColumn11.HeaderText = "IdNome";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "SERIE";
            this.dataGridViewTextBoxColumn8.HeaderText = "SERIE";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "turno";
            this.dataGridViewTextBoxColumn9.HeaderText = "turno";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "idade1";
            this.dataGridViewTextBoxColumn10.HeaderText = "idade1";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "PortadorNesc";
            this.dataGridViewTextBoxColumn12.HeaderText = "PortadorNesc";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // cadALUNOSDataGridView
            // 
            this.cadALUNOSDataGridView.AutoGenerateColumns = false;
            this.cadALUNOSDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.cadALUNOSDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.cadALUNOSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cadALUNOSDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn76,
            this.dataGridViewTextBoxColumn80,
            this.dataGridViewTextBoxColumn38,
            this.dataGridViewTextBoxColumn77,
            this.Irmao1,
            this.dataGridViewTextBoxColumn78,
            this.Irmao2,
            this.dataGridViewTextBoxColumn79,
            this.Irmao3});
            this.cadALUNOSDataGridView.DataSource = this.cadALUNOSBindingSource;
            this.cadALUNOSDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cadALUNOSDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.cadALUNOSDataGridView.Location = new System.Drawing.Point(0, 25);
            this.cadALUNOSDataGridView.Name = "cadALUNOSDataGridView";
            this.cadALUNOSDataGridView.ReadOnly = true;
            this.cadALUNOSDataGridView.Size = new System.Drawing.Size(1010, 510);
            this.cadALUNOSDataGridView.TabIndex = 1;
            this.cadALUNOSDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cadALUNOSDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "IdNome";
            this.dataGridViewTextBoxColumn16.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            this.dataGridViewTextBoxColumn16.Width = 60;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "idade1";
            this.dataGridViewTextBoxColumn19.HeaderText = "Idade";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.ReadOnly = true;
            this.dataGridViewTextBoxColumn19.Width = 59;
            // 
            // dataGridViewTextBoxColumn76
            // 
            this.dataGridViewTextBoxColumn76.DataPropertyName = "SERIE";
            this.dataGridViewTextBoxColumn76.HeaderText = "Serie";
            this.dataGridViewTextBoxColumn76.Name = "dataGridViewTextBoxColumn76";
            this.dataGridViewTextBoxColumn76.ReadOnly = true;
            this.dataGridViewTextBoxColumn76.Width = 56;
            // 
            // dataGridViewTextBoxColumn80
            // 
            this.dataGridViewTextBoxColumn80.DataPropertyName = "turno";
            this.dataGridViewTextBoxColumn80.HeaderText = "Turno";
            this.dataGridViewTextBoxColumn80.Name = "dataGridViewTextBoxColumn80";
            this.dataGridViewTextBoxColumn80.ReadOnly = true;
            this.dataGridViewTextBoxColumn80.Width = 60;
            // 
            // dataGridViewTextBoxColumn38
            // 
            this.dataGridViewTextBoxColumn38.DataPropertyName = "PortadorNesc";
            this.dataGridViewTextBoxColumn38.HeaderText = "PNE";
            this.dataGridViewTextBoxColumn38.Name = "dataGridViewTextBoxColumn38";
            this.dataGridViewTextBoxColumn38.ReadOnly = true;
            this.dataGridViewTextBoxColumn38.Width = 54;
            // 
            // dataGridViewTextBoxColumn77
            // 
            this.dataGridViewTextBoxColumn77.DataPropertyName = "UNIDADE ESCOLAR1";
            this.dataGridViewTextBoxColumn77.HeaderText = "UNIDADE ESCOLAR 1";
            this.dataGridViewTextBoxColumn77.Name = "dataGridViewTextBoxColumn77";
            this.dataGridViewTextBoxColumn77.ReadOnly = true;
            this.dataGridViewTextBoxColumn77.Width = 131;
            // 
            // Irmao1
            // 
            this.Irmao1.DataPropertyName = "Irmao1";
            this.Irmao1.HeaderText = "Irmao1";
            this.Irmao1.Name = "Irmao1";
            this.Irmao1.ReadOnly = true;
            this.Irmao1.Width = 45;
            // 
            // dataGridViewTextBoxColumn78
            // 
            this.dataGridViewTextBoxColumn78.DataPropertyName = "UNIDADE ESCOLAR2";
            this.dataGridViewTextBoxColumn78.HeaderText = "UNIDADE ESCOLAR 2";
            this.dataGridViewTextBoxColumn78.Name = "dataGridViewTextBoxColumn78";
            this.dataGridViewTextBoxColumn78.ReadOnly = true;
            this.dataGridViewTextBoxColumn78.Width = 131;
            // 
            // Irmao2
            // 
            this.Irmao2.DataPropertyName = "Irmao2";
            this.Irmao2.HeaderText = "Irmao2";
            this.Irmao2.Name = "Irmao2";
            this.Irmao2.ReadOnly = true;
            this.Irmao2.Width = 45;
            // 
            // dataGridViewTextBoxColumn79
            // 
            this.dataGridViewTextBoxColumn79.DataPropertyName = "UNIDADE ESCOLAR3";
            this.dataGridViewTextBoxColumn79.HeaderText = "UNIDADE ESCOLAR 3";
            this.dataGridViewTextBoxColumn79.Name = "dataGridViewTextBoxColumn79";
            this.dataGridViewTextBoxColumn79.ReadOnly = true;
            this.dataGridViewTextBoxColumn79.Width = 131;
            // 
            // Irmao3
            // 
            this.Irmao3.DataPropertyName = "Irmao3";
            this.Irmao3.HeaderText = "Irmao3";
            this.Irmao3.Name = "Irmao3";
            this.Irmao3.ReadOnly = true;
            this.Irmao3.Width = 45;
            // 
            // Frm_consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1010, 535);
            this.Controls.Add(this.cadALUNOSDataGridView);
            this.Controls.Add(this.cadALUNOSBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_consulta";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de aluno";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.prototipo_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadALUNOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadALUNOSBindingNavigator)).EndInit();
            this.cadALUNOSBindingNavigator.ResumeLayout(false);
            this.cadALUNOSBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cadALUNOSDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private prototipo_DBDataSet prototipo_DBDataSet;
        private System.Windows.Forms.BindingSource cadALUNOSBindingSource;
        private prototipo_DBDataSetTableAdapters.CadALUNOSTableAdapter cadALUNOSTableAdapter;
        private prototipo_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator cadALUNOSBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton cadALUNOSBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn SERIE;
        private System.Windows.Forms.DataGridViewTextBoxColumn turno;
        private System.Windows.Forms.DataGridViewTextBoxColumn idade1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn PortadorNesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridView cadALUNOSDataGridView;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn76;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn80;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn38;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn77;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Irmao1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn78;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Irmao2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn79;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Irmao3;
    }
}