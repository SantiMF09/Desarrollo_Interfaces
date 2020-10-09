namespace Practica2
{
    partial class AgregarAgenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarAgenda));
            this.miagendaDataSet1 = new Practica2.miagendaDataSet1();
            this.agendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agendaTableAdapter = new Practica2.miagendaDataSet1TableAdapters.agendaTableAdapter();
            this.tableAdapterManager = new Practica2.miagendaDataSet1TableAdapters.TableAdapterManager();
            this.agendaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.agendaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.agendaDataGridView = new System.Windows.Forms.DataGridView();
            this.buttonExit = new System.Windows.Forms.Button();
            this.agendaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tareaibfk1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tareaTableAdapter = new Practica2.miagendaDataSet1TableAdapters.tareaTableAdapter();
            this.tareaibfk1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.annioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.miagendaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaBindingNavigator)).BeginInit();
            this.agendaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.agendaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tareaibfk1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tareaibfk1BindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // miagendaDataSet1
            // 
            this.miagendaDataSet1.DataSetName = "miagendaDataSet1";
            this.miagendaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // agendaBindingSource
            // 
            this.agendaBindingSource.DataMember = "agenda";
            this.agendaBindingSource.DataSource = this.miagendaDataSet1;
            // 
            // agendaTableAdapter
            // 
            this.agendaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.agendaTableAdapter = this.agendaTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tareaTableAdapter = this.tareaTableAdapter;
            this.tableAdapterManager.UpdateOrder = Practica2.miagendaDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // agendaBindingNavigator
            // 
            this.agendaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.agendaBindingNavigator.BindingSource = this.agendaBindingSource;
            this.agendaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.agendaBindingNavigator.DeleteItem = null;
            this.agendaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.agendaBindingNavigatorSaveItem});
            this.agendaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.agendaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.agendaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.agendaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.agendaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.agendaBindingNavigator.Name = "agendaBindingNavigator";
            this.agendaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.agendaBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.agendaBindingNavigator.TabIndex = 0;
            this.agendaBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // agendaBindingNavigatorSaveItem
            // 
            this.agendaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.agendaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("agendaBindingNavigatorSaveItem.Image")));
            this.agendaBindingNavigatorSaveItem.Name = "agendaBindingNavigatorSaveItem";
            this.agendaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.agendaBindingNavigatorSaveItem.Text = "Guardar datos";
            this.agendaBindingNavigatorSaveItem.Click += new System.EventHandler(this.agendaBindingNavigatorSaveItem_Click);
            // 
            // agendaDataGridView
            // 
            this.agendaDataGridView.AutoGenerateColumns = false;
            this.agendaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.agendaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.annioDataGridViewTextBoxColumn});
            this.agendaDataGridView.DataSource = this.agendaBindingSource1;
            this.agendaDataGridView.Location = new System.Drawing.Point(213, 122);
            this.agendaDataGridView.Name = "agendaDataGridView";
            this.agendaDataGridView.Size = new System.Drawing.Size(344, 220);
            this.agendaDataGridView.TabIndex = 1;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(353, 411);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 2;
            this.buttonExit.Text = "Volver";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // agendaBindingSource1
            // 
            this.agendaBindingSource1.DataMember = "agenda";
            this.agendaBindingSource1.DataSource = this.miagendaDataSet1;
            // 
            // tareaibfk1BindingSource
            // 
            this.tareaibfk1BindingSource.DataMember = "tarea_ibfk_1";
            this.tareaibfk1BindingSource.DataSource = this.agendaBindingSource1;
            // 
            // tareaTableAdapter
            // 
            this.tareaTableAdapter.ClearBeforeFill = true;
            // 
            // tareaibfk1BindingSource1
            // 
            this.tareaibfk1BindingSource1.DataMember = "tarea_ibfk_1";
            this.tareaibfk1BindingSource1.DataSource = this.agendaBindingSource1;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // annioDataGridViewTextBoxColumn
            // 
            this.annioDataGridViewTextBoxColumn.DataPropertyName = "annio";
            this.annioDataGridViewTextBoxColumn.HeaderText = "annio";
            this.annioDataGridViewTextBoxColumn.Name = "annioDataGridViewTextBoxColumn";
            // 
            // AgregarAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.agendaDataGridView);
            this.Controls.Add(this.agendaBindingNavigator);
            this.Name = "AgregarAgenda";
            this.Text = "AgregarAgenda";
            this.Load += new System.EventHandler(this.AgregarAgenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.miagendaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaBindingNavigator)).EndInit();
            this.agendaBindingNavigator.ResumeLayout(false);
            this.agendaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.agendaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tareaibfk1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tareaibfk1BindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private miagendaDataSet1 miagendaDataSet1;
        private System.Windows.Forms.BindingSource agendaBindingSource;
        private miagendaDataSet1TableAdapters.agendaTableAdapter agendaTableAdapter;
        private miagendaDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator agendaBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton agendaBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView agendaDataGridView;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.BindingSource agendaBindingSource1;
        private miagendaDataSet1TableAdapters.tareaTableAdapter tareaTableAdapter;
        private System.Windows.Forms.BindingSource tareaibfk1BindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn annioDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tareaibfk1BindingSource1;
    }
}