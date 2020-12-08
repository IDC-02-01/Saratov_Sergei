
namespace MagazinWPF
{
    partial class Sklad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sklad));
            this.magazinichDataSet = new MagazinWPF.MagazinichDataSet();
            this.dataTable3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable3TableAdapter = new MagazinWPF.MagazinichDataSetTableAdapters.DataTable3TableAdapter();
            this.tableAdapterManager = new MagazinWPF.MagazinichDataSetTableAdapters.TableAdapterManager();
            this.dataTable3BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.dataTable3DataGridView = new System.Windows.Forms.DataGridView();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.magazinichDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable3BindingNavigator)).BeginInit();
            this.dataTable3BindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable3DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // magazinichDataSet
            // 
            this.magazinichDataSet.DataSetName = "MagazinichDataSet";
            this.magazinichDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataTable3BindingSource
            // 
            this.dataTable3BindingSource.DataMember = "DataTable3";
            this.dataTable3BindingSource.DataSource = this.magazinichDataSet;
            // 
            // dataTable3TableAdapter
            // 
            this.dataTable3TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AddressTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChekTableAdapter = null;
            this.tableAdapterManager.CityTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.CountryTableAdapter = null;
            this.tableAdapterManager.Dok_TipTableAdapter = null;
            this.tableAdapterManager.KategoriyaTableAdapter = null;
            this.tableAdapterManager.MagazTableAdapter = null;
            this.tableAdapterManager.NakladnayaTableAdapter = null;
            this.tableAdapterManager.NazvanieTableAdapter = null;
            this.tableAdapterManager.OrganizaciyaTableAdapter = null;
            this.tableAdapterManager.SkladTableAdapter = null;
            this.tableAdapterManager.StreetTableAdapter = null;
            this.tableAdapterManager.TovarTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MagazinWPF.MagazinichDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dataTable3BindingNavigator
            // 
            this.dataTable3BindingNavigator.AddNewItem = null;
            this.dataTable3BindingNavigator.BindingSource = this.dataTable3BindingSource;
            this.dataTable3BindingNavigator.CountItem = null;
            this.dataTable3BindingNavigator.DeleteItem = null;
            this.dataTable3BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorAddNewItem,
            this.toolStripButton1});
            this.dataTable3BindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.dataTable3BindingNavigator.MoveFirstItem = null;
            this.dataTable3BindingNavigator.MoveLastItem = null;
            this.dataTable3BindingNavigator.MoveNextItem = null;
            this.dataTable3BindingNavigator.MovePreviousItem = null;
            this.dataTable3BindingNavigator.Name = "dataTable3BindingNavigator";
            this.dataTable3BindingNavigator.PositionItem = null;
            this.dataTable3BindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.dataTable3BindingNavigator.TabIndex = 0;
            this.dataTable3BindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(148, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить/Редактировать";
            // 
            // dataTable3DataGridView
            // 
            this.dataTable3DataGridView.AllowUserToAddRows = false;
            this.dataTable3DataGridView.AllowUserToDeleteRows = false;
            this.dataTable3DataGridView.AutoGenerateColumns = false;
            this.dataTable3DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTable3DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.dataTable3DataGridView.DataSource = this.dataTable3BindingSource;
            this.dataTable3DataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataTable3DataGridView.Location = new System.Drawing.Point(0, 25);
            this.dataTable3DataGridView.Name = "dataTable3DataGridView";
            this.dataTable3DataGridView.ReadOnly = true;
            this.dataTable3DataGridView.Size = new System.Drawing.Size(800, 425);
            this.dataTable3DataGridView.TabIndex = 1;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(59, 22);
            this.toolStripButton1.Text = "В МЕНЮ";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_Sklad";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID Склада";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nazvanie";
            this.dataGridViewTextBoxColumn2.HeaderText = "Название Товара";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Date";
            this.dataGridViewTextBoxColumn3.HeaderText = "Дата";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Ostatok_Sklad";
            this.dataGridViewTextBoxColumn4.HeaderText = "Остаток на складе";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Prihon_Sklad";
            this.dataGridViewTextBoxColumn5.HeaderText = "Приход на склад";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Country";
            this.dataGridViewTextBoxColumn6.HeaderText = "Страна";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "City";
            this.dataGridViewTextBoxColumn8.HeaderText = "Город";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Street";
            this.dataGridViewTextBoxColumn7.HeaderText = "Улица";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Building";
            this.dataGridViewTextBoxColumn9.HeaderText = "Строение";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Dokument_tip";
            this.dataGridViewTextBoxColumn10.HeaderText = "Тип документа";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // Sklad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataTable3DataGridView);
            this.Controls.Add(this.dataTable3BindingNavigator);
            this.Name = "Sklad";
            this.Text = "Sklad";
            this.Load += new System.EventHandler(this.Sklad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.magazinichDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable3BindingNavigator)).EndInit();
            this.dataTable3BindingNavigator.ResumeLayout(false);
            this.dataTable3BindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable3DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MagazinichDataSet magazinichDataSet;
        private System.Windows.Forms.BindingSource dataTable3BindingSource;
        private MagazinichDataSetTableAdapters.DataTable3TableAdapter dataTable3TableAdapter;
        private MagazinichDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator dataTable3BindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.DataGridView dataTable3DataGridView;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
    }
}