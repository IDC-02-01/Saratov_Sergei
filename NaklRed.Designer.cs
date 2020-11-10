namespace Magazinciks
{
    partial class NaklRed
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NaklRed));
            System.Windows.Forms.Label id_NakladnoiLabel;
            System.Windows.Forms.Label id_TipdocLabel;
            System.Windows.Forms.Label id_KategoriaTovaraLabel;
            System.Windows.Forms.Label id_TovaraLabel;
            System.Windows.Forms.Label id_skladaLabel;
            System.Windows.Forms.Label id_MagazinaLabel;
            System.Windows.Forms.Label id_adresLabel;
            System.Windows.Forms.Label iNNLabel;
            System.Windows.Forms.Label id_organizLabel;
            System.Windows.Forms.Label id_PostavshikLabel;
            this.bD_SeregiDataSet = new Magazinciks.BD_SeregiDataSet();
            this.nakladnayaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nakladnayaTableAdapter = new Magazinciks.BD_SeregiDataSetTableAdapters.NakladnayaTableAdapter();
            this.tableAdapterManager = new Magazinciks.BD_SeregiDataSetTableAdapters.TableAdapterManager();
            this.nakladnayaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.nakladnayaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.id_NakladnoiTextBox = new System.Windows.Forms.TextBox();
            this.id_TipdocTextBox = new System.Windows.Forms.TextBox();
            this.id_KategoriaTovaraTextBox = new System.Windows.Forms.TextBox();
            this.id_TovaraTextBox = new System.Windows.Forms.TextBox();
            this.id_skladaTextBox = new System.Windows.Forms.TextBox();
            this.id_MagazinaTextBox = new System.Windows.Forms.TextBox();
            this.id_adresTextBox = new System.Windows.Forms.TextBox();
            this.iNNTextBox = new System.Windows.Forms.TextBox();
            this.id_organizTextBox = new System.Windows.Forms.TextBox();
            this.id_PostavshikTextBox = new System.Windows.Forms.TextBox();
            id_NakladnoiLabel = new System.Windows.Forms.Label();
            id_TipdocLabel = new System.Windows.Forms.Label();
            id_KategoriaTovaraLabel = new System.Windows.Forms.Label();
            id_TovaraLabel = new System.Windows.Forms.Label();
            id_skladaLabel = new System.Windows.Forms.Label();
            id_MagazinaLabel = new System.Windows.Forms.Label();
            id_adresLabel = new System.Windows.Forms.Label();
            iNNLabel = new System.Windows.Forms.Label();
            id_organizLabel = new System.Windows.Forms.Label();
            id_PostavshikLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bD_SeregiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nakladnayaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nakladnayaBindingNavigator)).BeginInit();
            this.nakladnayaBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // bD_SeregiDataSet
            // 
            this.bD_SeregiDataSet.DataSetName = "BD_SeregiDataSet";
            this.bD_SeregiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nakladnayaBindingSource
            // 
            this.nakladnayaBindingSource.DataMember = "Nakladnaya";
            this.nakladnayaBindingSource.DataSource = this.bD_SeregiDataSet;
            // 
            // nakladnayaTableAdapter
            // 
            this.nakladnayaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdresTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChekTableAdapter = null;
            this.tableAdapterManager.GorodTableAdapter = null;
            this.tableAdapterManager.KategoriaTableAdapter = null;
            this.tableAdapterManager.MagazTableAdapter = null;
            this.tableAdapterManager.NakladnayaTableAdapter = this.nakladnayaTableAdapter;
            this.tableAdapterManager.OblastTableAdapter = null;
            this.tableAdapterManager.OrganizTableAdapter = null;
            this.tableAdapterManager.OtchetTableAdapter = null;
            this.tableAdapterManager.PostavshikTableAdapter = null;
            this.tableAdapterManager.RaionTableAdapter = null;
            this.tableAdapterManager.SkladTableAdapter = null;
            this.tableAdapterManager.StatusTableAdapter = null;
            this.tableAdapterManager.StranaTableAdapter = null;
            this.tableAdapterManager.TipDocTableAdapter = null;
            this.tableAdapterManager.TovarTableAdapter = null;
            this.tableAdapterManager.UlicaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Magazinciks.BD_SeregiDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // nakladnayaBindingNavigator
            // 
            this.nakladnayaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.nakladnayaBindingNavigator.BindingSource = this.nakladnayaBindingSource;
            this.nakladnayaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.nakladnayaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.nakladnayaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.nakladnayaBindingNavigatorSaveItem});
            this.nakladnayaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.nakladnayaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.nakladnayaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.nakladnayaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.nakladnayaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.nakladnayaBindingNavigator.Name = "nakladnayaBindingNavigator";
            this.nakladnayaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.nakladnayaBindingNavigator.Size = new System.Drawing.Size(309, 25);
            this.nakladnayaBindingNavigator.TabIndex = 0;
            this.nakladnayaBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 15);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // nakladnayaBindingNavigatorSaveItem
            // 
            this.nakladnayaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.nakladnayaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("nakladnayaBindingNavigatorSaveItem.Image")));
            this.nakladnayaBindingNavigatorSaveItem.Name = "nakladnayaBindingNavigatorSaveItem";
            this.nakladnayaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.nakladnayaBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.nakladnayaBindingNavigatorSaveItem.Click += new System.EventHandler(this.nakladnayaBindingNavigatorSaveItem_Click);
            // 
            // id_NakladnoiLabel
            // 
            id_NakladnoiLabel.AutoSize = true;
            id_NakladnoiLabel.Location = new System.Drawing.Point(8, 31);
            id_NakladnoiLabel.Name = "id_NakladnoiLabel";
            id_NakladnoiLabel.Size = new System.Drawing.Size(77, 13);
            id_NakladnoiLabel.TabIndex = 1;
            id_NakladnoiLabel.Text = "id Накладной:";
            // 
            // id_NakladnoiTextBox
            // 
            this.id_NakladnoiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nakladnayaBindingSource, "id_Nakladnoi", true));
            this.id_NakladnoiTextBox.Location = new System.Drawing.Point(134, 28);
            this.id_NakladnoiTextBox.Name = "id_NakladnoiTextBox";
            this.id_NakladnoiTextBox.Size = new System.Drawing.Size(154, 20);
            this.id_NakladnoiTextBox.TabIndex = 2;
            // 
            // id_TipdocLabel
            // 
            id_TipdocLabel.AutoSize = true;
            id_TipdocLabel.Location = new System.Drawing.Point(8, 57);
            id_TipdocLabel.Name = "id_TipdocLabel";
            id_TipdocLabel.Size = new System.Drawing.Size(86, 13);
            id_TipdocLabel.TabIndex = 3;
            id_TipdocLabel.Text = "Тип документа:";
            // 
            // id_TipdocTextBox
            // 
            this.id_TipdocTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nakladnayaBindingSource, "id_Tipdoc", true));
            this.id_TipdocTextBox.Location = new System.Drawing.Point(134, 54);
            this.id_TipdocTextBox.Name = "id_TipdocTextBox";
            this.id_TipdocTextBox.Size = new System.Drawing.Size(154, 20);
            this.id_TipdocTextBox.TabIndex = 4;
            // 
            // id_KategoriaTovaraLabel
            // 
            id_KategoriaTovaraLabel.AutoSize = true;
            id_KategoriaTovaraLabel.Location = new System.Drawing.Point(8, 83);
            id_KategoriaTovaraLabel.Name = "id_KategoriaTovaraLabel";
            id_KategoriaTovaraLabel.Size = new System.Drawing.Size(114, 13);
            id_KategoriaTovaraLabel.TabIndex = 5;
            id_KategoriaTovaraLabel.Text = "id Категория Товара:";
            // 
            // id_KategoriaTovaraTextBox
            // 
            this.id_KategoriaTovaraTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nakladnayaBindingSource, "id_KategoriaTovara", true));
            this.id_KategoriaTovaraTextBox.Location = new System.Drawing.Point(134, 80);
            this.id_KategoriaTovaraTextBox.Name = "id_KategoriaTovaraTextBox";
            this.id_KategoriaTovaraTextBox.Size = new System.Drawing.Size(154, 20);
            this.id_KategoriaTovaraTextBox.TabIndex = 6;
            // 
            // id_TovaraLabel
            // 
            id_TovaraLabel.AutoSize = true;
            id_TovaraLabel.Location = new System.Drawing.Point(8, 109);
            id_TovaraLabel.Name = "id_TovaraLabel";
            id_TovaraLabel.Size = new System.Drawing.Size(58, 13);
            id_TovaraLabel.TabIndex = 7;
            id_TovaraLabel.Text = "id Товара:";
            // 
            // id_TovaraTextBox
            // 
            this.id_TovaraTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nakladnayaBindingSource, "id_Tovara", true));
            this.id_TovaraTextBox.Location = new System.Drawing.Point(134, 106);
            this.id_TovaraTextBox.Name = "id_TovaraTextBox";
            this.id_TovaraTextBox.Size = new System.Drawing.Size(154, 20);
            this.id_TovaraTextBox.TabIndex = 8;
            // 
            // id_skladaLabel
            // 
            id_skladaLabel.AutoSize = true;
            id_skladaLabel.Location = new System.Drawing.Point(8, 135);
            id_skladaLabel.Name = "id_skladaLabel";
            id_skladaLabel.Size = new System.Drawing.Size(58, 13);
            id_skladaLabel.TabIndex = 9;
            id_skladaLabel.Text = "id Склада:";
            // 
            // id_skladaTextBox
            // 
            this.id_skladaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nakladnayaBindingSource, "id_sklada", true));
            this.id_skladaTextBox.Location = new System.Drawing.Point(134, 132);
            this.id_skladaTextBox.Name = "id_skladaTextBox";
            this.id_skladaTextBox.Size = new System.Drawing.Size(154, 20);
            this.id_skladaTextBox.TabIndex = 10;
            // 
            // id_MagazinaLabel
            // 
            id_MagazinaLabel.AutoSize = true;
            id_MagazinaLabel.Location = new System.Drawing.Point(8, 161);
            id_MagazinaLabel.Name = "id_MagazinaLabel";
            id_MagazinaLabel.Size = new System.Drawing.Size(71, 13);
            id_MagazinaLabel.TabIndex = 11;
            id_MagazinaLabel.Text = "id Магазина:";
            // 
            // id_MagazinaTextBox
            // 
            this.id_MagazinaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nakladnayaBindingSource, "id_Magazina", true));
            this.id_MagazinaTextBox.Location = new System.Drawing.Point(134, 158);
            this.id_MagazinaTextBox.Name = "id_MagazinaTextBox";
            this.id_MagazinaTextBox.Size = new System.Drawing.Size(154, 20);
            this.id_MagazinaTextBox.TabIndex = 12;
            // 
            // id_adresLabel
            // 
            id_adresLabel.AutoSize = true;
            id_adresLabel.Location = new System.Drawing.Point(8, 187);
            id_adresLabel.Name = "id_adresLabel";
            id_adresLabel.Size = new System.Drawing.Size(52, 13);
            id_adresLabel.TabIndex = 13;
            id_adresLabel.Text = "id Адрес:";
            // 
            // id_adresTextBox
            // 
            this.id_adresTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nakladnayaBindingSource, "id_adres", true));
            this.id_adresTextBox.Location = new System.Drawing.Point(134, 184);
            this.id_adresTextBox.Name = "id_adresTextBox";
            this.id_adresTextBox.Size = new System.Drawing.Size(154, 20);
            this.id_adresTextBox.TabIndex = 14;
            // 
            // iNNLabel
            // 
            iNNLabel.AutoSize = true;
            iNNLabel.Location = new System.Drawing.Point(8, 213);
            iNNLabel.Name = "iNNLabel";
            iNNLabel.Size = new System.Drawing.Size(34, 13);
            iNNLabel.TabIndex = 15;
            iNNLabel.Text = "ИНН:";
            // 
            // iNNTextBox
            // 
            this.iNNTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nakladnayaBindingSource, "INN", true));
            this.iNNTextBox.Location = new System.Drawing.Point(134, 210);
            this.iNNTextBox.Name = "iNNTextBox";
            this.iNNTextBox.Size = new System.Drawing.Size(154, 20);
            this.iNNTextBox.TabIndex = 16;
            // 
            // id_organizLabel
            // 
            id_organizLabel.AutoSize = true;
            id_organizLabel.Location = new System.Drawing.Point(8, 239);
            id_organizLabel.Name = "id_organizLabel";
            id_organizLabel.Size = new System.Drawing.Size(88, 13);
            id_organizLabel.TabIndex = 17;
            id_organizLabel.Text = "id Организации:";
            // 
            // id_organizTextBox
            // 
            this.id_organizTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nakladnayaBindingSource, "id_organiz", true));
            this.id_organizTextBox.Location = new System.Drawing.Point(134, 236);
            this.id_organizTextBox.Name = "id_organizTextBox";
            this.id_organizTextBox.Size = new System.Drawing.Size(154, 20);
            this.id_organizTextBox.TabIndex = 18;
            // 
            // id_PostavshikLabel
            // 
            id_PostavshikLabel.AutoSize = true;
            id_PostavshikLabel.Location = new System.Drawing.Point(8, 265);
            id_PostavshikLabel.Name = "id_PostavshikLabel";
            id_PostavshikLabel.Size = new System.Drawing.Size(85, 13);
            id_PostavshikLabel.TabIndex = 19;
            id_PostavshikLabel.Text = "id Поставщика:";
            // 
            // id_PostavshikTextBox
            // 
            this.id_PostavshikTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nakladnayaBindingSource, "id_Postavshik", true));
            this.id_PostavshikTextBox.Location = new System.Drawing.Point(134, 262);
            this.id_PostavshikTextBox.Name = "id_PostavshikTextBox";
            this.id_PostavshikTextBox.Size = new System.Drawing.Size(154, 20);
            this.id_PostavshikTextBox.TabIndex = 20;
            // 
            // NaklRed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 318);
            this.Controls.Add(id_NakladnoiLabel);
            this.Controls.Add(this.id_NakladnoiTextBox);
            this.Controls.Add(id_TipdocLabel);
            this.Controls.Add(this.id_TipdocTextBox);
            this.Controls.Add(id_KategoriaTovaraLabel);
            this.Controls.Add(this.id_KategoriaTovaraTextBox);
            this.Controls.Add(id_TovaraLabel);
            this.Controls.Add(this.id_TovaraTextBox);
            this.Controls.Add(id_skladaLabel);
            this.Controls.Add(this.id_skladaTextBox);
            this.Controls.Add(id_MagazinaLabel);
            this.Controls.Add(this.id_MagazinaTextBox);
            this.Controls.Add(id_adresLabel);
            this.Controls.Add(this.id_adresTextBox);
            this.Controls.Add(iNNLabel);
            this.Controls.Add(this.iNNTextBox);
            this.Controls.Add(id_organizLabel);
            this.Controls.Add(this.id_organizTextBox);
            this.Controls.Add(id_PostavshikLabel);
            this.Controls.Add(this.id_PostavshikTextBox);
            this.Controls.Add(this.nakladnayaBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "NaklRed";
            this.Text = "NaklRed";
            this.Load += new System.EventHandler(this.NaklRed_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bD_SeregiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nakladnayaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nakladnayaBindingNavigator)).EndInit();
            this.nakladnayaBindingNavigator.ResumeLayout(false);
            this.nakladnayaBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BD_SeregiDataSet bD_SeregiDataSet;
        private System.Windows.Forms.BindingSource nakladnayaBindingSource;
        private BD_SeregiDataSetTableAdapters.NakladnayaTableAdapter nakladnayaTableAdapter;
        private BD_SeregiDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator nakladnayaBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton nakladnayaBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox id_NakladnoiTextBox;
        private System.Windows.Forms.TextBox id_TipdocTextBox;
        private System.Windows.Forms.TextBox id_KategoriaTovaraTextBox;
        private System.Windows.Forms.TextBox id_TovaraTextBox;
        private System.Windows.Forms.TextBox id_skladaTextBox;
        private System.Windows.Forms.TextBox id_MagazinaTextBox;
        private System.Windows.Forms.TextBox id_adresTextBox;
        private System.Windows.Forms.TextBox iNNTextBox;
        private System.Windows.Forms.TextBox id_organizTextBox;
        private System.Windows.Forms.TextBox id_PostavshikTextBox;
    }
}