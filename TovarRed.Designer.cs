namespace Magazinciks
{
    partial class TovarRed
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TovarRed));
            System.Windows.Forms.Label id_TovaraLabel;
            System.Windows.Forms.Label id_KategoriyaTovaraLabel;
            System.Windows.Forms.Label nameTovaraLabel;
            System.Windows.Forms.Label id_MagazinaLabel;
            System.Windows.Forms.Label cenaLabel;
            System.Windows.Forms.Label id_statusLabel;
            this.bD_SeregiDataSet = new Magazinciks.BD_SeregiDataSet();
            this.tovarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tovarTableAdapter = new Magazinciks.BD_SeregiDataSetTableAdapters.TovarTableAdapter();
            this.tableAdapterManager = new Magazinciks.BD_SeregiDataSetTableAdapters.TableAdapterManager();
            this.tovarBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.tovarBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.id_TovaraTextBox = new System.Windows.Forms.TextBox();
            this.id_KategoriyaTovaraTextBox = new System.Windows.Forms.TextBox();
            this.nameTovaraTextBox = new System.Windows.Forms.TextBox();
            this.id_MagazinaTextBox = new System.Windows.Forms.TextBox();
            this.cenaTextBox = new System.Windows.Forms.TextBox();
            this.id_statusTextBox = new System.Windows.Forms.TextBox();
            id_TovaraLabel = new System.Windows.Forms.Label();
            id_KategoriyaTovaraLabel = new System.Windows.Forms.Label();
            nameTovaraLabel = new System.Windows.Forms.Label();
            id_MagazinaLabel = new System.Windows.Forms.Label();
            cenaLabel = new System.Windows.Forms.Label();
            id_statusLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bD_SeregiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tovarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tovarBindingNavigator)).BeginInit();
            this.tovarBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // bD_SeregiDataSet
            // 
            this.bD_SeregiDataSet.DataSetName = "BD_SeregiDataSet";
            this.bD_SeregiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tovarBindingSource
            // 
            this.tovarBindingSource.DataMember = "Tovar";
            this.tovarBindingSource.DataSource = this.bD_SeregiDataSet;
            // 
            // tovarTableAdapter
            // 
            this.tovarTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdresTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChekTableAdapter = null;
            this.tableAdapterManager.GorodTableAdapter = null;
            this.tableAdapterManager.KategoriaTableAdapter = null;
            this.tableAdapterManager.MagazTableAdapter = null;
            this.tableAdapterManager.NakladnayaTableAdapter = null;
            this.tableAdapterManager.OblastTableAdapter = null;
            this.tableAdapterManager.OrganizTableAdapter = null;
            this.tableAdapterManager.OtchetTableAdapter = null;
            this.tableAdapterManager.PostavshikTableAdapter = null;
            this.tableAdapterManager.RaionTableAdapter = null;
            this.tableAdapterManager.SkladTableAdapter = null;
            this.tableAdapterManager.StatusTableAdapter = null;
            this.tableAdapterManager.StranaTableAdapter = null;
            this.tableAdapterManager.TipDocTableAdapter = null;
            this.tableAdapterManager.TovarTableAdapter = this.tovarTableAdapter;
            this.tableAdapterManager.UlicaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Magazinciks.BD_SeregiDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tovarBindingNavigator
            // 
            this.tovarBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tovarBindingNavigator.BindingSource = this.tovarBindingSource;
            this.tovarBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tovarBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tovarBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tovarBindingNavigatorSaveItem});
            this.tovarBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tovarBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tovarBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tovarBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tovarBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tovarBindingNavigator.Name = "tovarBindingNavigator";
            this.tovarBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tovarBindingNavigator.Size = new System.Drawing.Size(306, 25);
            this.tovarBindingNavigator.TabIndex = 0;
            this.tovarBindingNavigator.Text = "bindingNavigator1";
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
            // tovarBindingNavigatorSaveItem
            // 
            this.tovarBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tovarBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tovarBindingNavigatorSaveItem.Image")));
            this.tovarBindingNavigatorSaveItem.Name = "tovarBindingNavigatorSaveItem";
            this.tovarBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.tovarBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.tovarBindingNavigatorSaveItem.Click += new System.EventHandler(this.tovarBindingNavigatorSaveItem_Click);
            // 
            // id_TovaraLabel
            // 
            id_TovaraLabel.AutoSize = true;
            id_TovaraLabel.Location = new System.Drawing.Point(15, 31);
            id_TovaraLabel.Name = "id_TovaraLabel";
            id_TovaraLabel.Size = new System.Drawing.Size(58, 13);
            id_TovaraLabel.TabIndex = 1;
            id_TovaraLabel.Text = "id Товара:";
            // 
            // id_TovaraTextBox
            // 
            this.id_TovaraTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tovarBindingSource, "id_Tovara", true));
            this.id_TovaraTextBox.Location = new System.Drawing.Point(129, 28);
            this.id_TovaraTextBox.Name = "id_TovaraTextBox";
            this.id_TovaraTextBox.Size = new System.Drawing.Size(152, 20);
            this.id_TovaraTextBox.TabIndex = 2;
            // 
            // id_KategoriyaTovaraLabel
            // 
            id_KategoriyaTovaraLabel.AutoSize = true;
            id_KategoriyaTovaraLabel.Location = new System.Drawing.Point(15, 57);
            id_KategoriyaTovaraLabel.Name = "id_KategoriyaTovaraLabel";
            id_KategoriyaTovaraLabel.Size = new System.Drawing.Size(113, 13);
            id_KategoriyaTovaraLabel.TabIndex = 3;
            id_KategoriyaTovaraLabel.Text = "id категория Товара:";
            // 
            // id_KategoriyaTovaraTextBox
            // 
            this.id_KategoriyaTovaraTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tovarBindingSource, "id_KategoriyaTovara", true));
            this.id_KategoriyaTovaraTextBox.Location = new System.Drawing.Point(129, 54);
            this.id_KategoriyaTovaraTextBox.Name = "id_KategoriyaTovaraTextBox";
            this.id_KategoriyaTovaraTextBox.Size = new System.Drawing.Size(152, 20);
            this.id_KategoriyaTovaraTextBox.TabIndex = 4;
            // 
            // nameTovaraLabel
            // 
            nameTovaraLabel.AutoSize = true;
            nameTovaraLabel.Location = new System.Drawing.Point(15, 83);
            nameTovaraLabel.Name = "nameTovaraLabel";
            nameTovaraLabel.Size = new System.Drawing.Size(72, 13);
            nameTovaraLabel.TabIndex = 5;
            nameTovaraLabel.Text = "Имя Товара:";
            // 
            // nameTovaraTextBox
            // 
            this.nameTovaraTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tovarBindingSource, "NameTovara", true));
            this.nameTovaraTextBox.Location = new System.Drawing.Point(129, 80);
            this.nameTovaraTextBox.Name = "nameTovaraTextBox";
            this.nameTovaraTextBox.Size = new System.Drawing.Size(152, 20);
            this.nameTovaraTextBox.TabIndex = 6;
            // 
            // id_MagazinaLabel
            // 
            id_MagazinaLabel.AutoSize = true;
            id_MagazinaLabel.Location = new System.Drawing.Point(15, 109);
            id_MagazinaLabel.Name = "id_MagazinaLabel";
            id_MagazinaLabel.Size = new System.Drawing.Size(71, 13);
            id_MagazinaLabel.TabIndex = 7;
            id_MagazinaLabel.Text = "id Магазина:";
            // 
            // id_MagazinaTextBox
            // 
            this.id_MagazinaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tovarBindingSource, "id_Magazina", true));
            this.id_MagazinaTextBox.Location = new System.Drawing.Point(129, 106);
            this.id_MagazinaTextBox.Name = "id_MagazinaTextBox";
            this.id_MagazinaTextBox.Size = new System.Drawing.Size(152, 20);
            this.id_MagazinaTextBox.TabIndex = 8;
            // 
            // cenaLabel
            // 
            cenaLabel.AutoSize = true;
            cenaLabel.Location = new System.Drawing.Point(15, 135);
            cenaLabel.Name = "cenaLabel";
            cenaLabel.Size = new System.Drawing.Size(36, 13);
            cenaLabel.TabIndex = 9;
            cenaLabel.Text = "Цена:";
            // 
            // cenaTextBox
            // 
            this.cenaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tovarBindingSource, "Cena", true));
            this.cenaTextBox.Location = new System.Drawing.Point(129, 132);
            this.cenaTextBox.Name = "cenaTextBox";
            this.cenaTextBox.Size = new System.Drawing.Size(152, 20);
            this.cenaTextBox.TabIndex = 10;
            // 
            // id_statusLabel
            // 
            id_statusLabel.AutoSize = true;
            id_statusLabel.Location = new System.Drawing.Point(15, 161);
            id_statusLabel.Name = "id_statusLabel";
            id_statusLabel.Size = new System.Drawing.Size(55, 13);
            id_statusLabel.TabIndex = 11;
            id_statusLabel.Text = "id Статус:";
            // 
            // id_statusTextBox
            // 
            this.id_statusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tovarBindingSource, "id_status", true));
            this.id_statusTextBox.Location = new System.Drawing.Point(129, 158);
            this.id_statusTextBox.Name = "id_statusTextBox";
            this.id_statusTextBox.Size = new System.Drawing.Size(152, 20);
            this.id_statusTextBox.TabIndex = 12;
            // 
            // TovarRed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 205);
            this.Controls.Add(id_TovaraLabel);
            this.Controls.Add(this.id_TovaraTextBox);
            this.Controls.Add(id_KategoriyaTovaraLabel);
            this.Controls.Add(this.id_KategoriyaTovaraTextBox);
            this.Controls.Add(nameTovaraLabel);
            this.Controls.Add(this.nameTovaraTextBox);
            this.Controls.Add(id_MagazinaLabel);
            this.Controls.Add(this.id_MagazinaTextBox);
            this.Controls.Add(cenaLabel);
            this.Controls.Add(this.cenaTextBox);
            this.Controls.Add(id_statusLabel);
            this.Controls.Add(this.id_statusTextBox);
            this.Controls.Add(this.tovarBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "TovarRed";
            this.Text = "TovarRed";
            this.Load += new System.EventHandler(this.TovarRed_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bD_SeregiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tovarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tovarBindingNavigator)).EndInit();
            this.tovarBindingNavigator.ResumeLayout(false);
            this.tovarBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BD_SeregiDataSet bD_SeregiDataSet;
        private System.Windows.Forms.BindingSource tovarBindingSource;
        private BD_SeregiDataSetTableAdapters.TovarTableAdapter tovarTableAdapter;
        private BD_SeregiDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tovarBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tovarBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox id_TovaraTextBox;
        private System.Windows.Forms.TextBox id_KategoriyaTovaraTextBox;
        private System.Windows.Forms.TextBox nameTovaraTextBox;
        private System.Windows.Forms.TextBox id_MagazinaTextBox;
        private System.Windows.Forms.TextBox cenaTextBox;
        private System.Windows.Forms.TextBox id_statusTextBox;
    }
}