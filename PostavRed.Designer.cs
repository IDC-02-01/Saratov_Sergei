namespace Magazinciks
{
    partial class PostavRed
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PostavRed));
            System.Windows.Forms.Label id_PostavshikLabel;
            System.Windows.Forms.Label postavhikLabel;
            System.Windows.Forms.Label id_adresLabel;
            this.bD_SeregiDataSet = new Magazinciks.BD_SeregiDataSet();
            this.postavshikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.postavshikTableAdapter = new Magazinciks.BD_SeregiDataSetTableAdapters.PostavshikTableAdapter();
            this.tableAdapterManager = new Magazinciks.BD_SeregiDataSetTableAdapters.TableAdapterManager();
            this.postavshikBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.postavshikBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.id_PostavshikTextBox = new System.Windows.Forms.TextBox();
            this.postavhikTextBox = new System.Windows.Forms.TextBox();
            this.id_adresTextBox = new System.Windows.Forms.TextBox();
            id_PostavshikLabel = new System.Windows.Forms.Label();
            postavhikLabel = new System.Windows.Forms.Label();
            id_adresLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bD_SeregiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postavshikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postavshikBindingNavigator)).BeginInit();
            this.postavshikBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // bD_SeregiDataSet
            // 
            this.bD_SeregiDataSet.DataSetName = "BD_SeregiDataSet";
            this.bD_SeregiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // postavshikBindingSource
            // 
            this.postavshikBindingSource.DataMember = "Postavshik";
            this.postavshikBindingSource.DataSource = this.bD_SeregiDataSet;
            // 
            // postavshikTableAdapter
            // 
            this.postavshikTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.PostavshikTableAdapter = this.postavshikTableAdapter;
            this.tableAdapterManager.RaionTableAdapter = null;
            this.tableAdapterManager.SkladTableAdapter = null;
            this.tableAdapterManager.StatusTableAdapter = null;
            this.tableAdapterManager.StranaTableAdapter = null;
            this.tableAdapterManager.TipDocTableAdapter = null;
            this.tableAdapterManager.TovarTableAdapter = null;
            this.tableAdapterManager.UlicaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Magazinciks.BD_SeregiDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // postavshikBindingNavigator
            // 
            this.postavshikBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.postavshikBindingNavigator.BindingSource = this.postavshikBindingSource;
            this.postavshikBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.postavshikBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.postavshikBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.postavshikBindingNavigatorSaveItem});
            this.postavshikBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.postavshikBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.postavshikBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.postavshikBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.postavshikBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.postavshikBindingNavigator.Name = "postavshikBindingNavigator";
            this.postavshikBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.postavshikBindingNavigator.Size = new System.Drawing.Size(301, 25);
            this.postavshikBindingNavigator.TabIndex = 0;
            this.postavshikBindingNavigator.Text = "bindingNavigator1";
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
            // postavshikBindingNavigatorSaveItem
            // 
            this.postavshikBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.postavshikBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("postavshikBindingNavigatorSaveItem.Image")));
            this.postavshikBindingNavigatorSaveItem.Name = "postavshikBindingNavigatorSaveItem";
            this.postavshikBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.postavshikBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.postavshikBindingNavigatorSaveItem.Click += new System.EventHandler(this.postavshikBindingNavigatorSaveItem_Click);
            // 
            // id_PostavshikLabel
            // 
            id_PostavshikLabel.AutoSize = true;
            id_PostavshikLabel.Location = new System.Drawing.Point(7, 31);
            id_PostavshikLabel.Name = "id_PostavshikLabel";
            id_PostavshikLabel.Size = new System.Drawing.Size(85, 13);
            id_PostavshikLabel.TabIndex = 1;
            id_PostavshikLabel.Text = "id Поставщика:";
            // 
            // id_PostavshikTextBox
            // 
            this.id_PostavshikTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postavshikBindingSource, "id_Postavshik", true));
            this.id_PostavshikTextBox.Location = new System.Drawing.Point(110, 28);
            this.id_PostavshikTextBox.Name = "id_PostavshikTextBox";
            this.id_PostavshikTextBox.Size = new System.Drawing.Size(145, 20);
            this.id_PostavshikTextBox.TabIndex = 2;
            // 
            // postavhikLabel
            // 
            postavhikLabel.AutoSize = true;
            postavhikLabel.Location = new System.Drawing.Point(7, 57);
            postavhikLabel.Name = "postavhikLabel";
            postavhikLabel.Size = new System.Drawing.Size(97, 13);
            postavhikLabel.TabIndex = 3;
            postavhikLabel.Text = "Имя поставщика:";
            // 
            // postavhikTextBox
            // 
            this.postavhikTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postavshikBindingSource, "Postavhik", true));
            this.postavhikTextBox.Location = new System.Drawing.Point(110, 54);
            this.postavhikTextBox.Name = "postavhikTextBox";
            this.postavhikTextBox.Size = new System.Drawing.Size(145, 20);
            this.postavhikTextBox.TabIndex = 4;
            // 
            // id_adresLabel
            // 
            id_adresLabel.AutoSize = true;
            id_adresLabel.Location = new System.Drawing.Point(7, 83);
            id_adresLabel.Name = "id_adresLabel";
            id_adresLabel.Size = new System.Drawing.Size(52, 13);
            id_adresLabel.TabIndex = 5;
            id_adresLabel.Text = "id Адрес:";
            // 
            // id_adresTextBox
            // 
            this.id_adresTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postavshikBindingSource, "id_adres", true));
            this.id_adresTextBox.Location = new System.Drawing.Point(110, 80);
            this.id_adresTextBox.Name = "id_adresTextBox";
            this.id_adresTextBox.Size = new System.Drawing.Size(145, 20);
            this.id_adresTextBox.TabIndex = 6;
            // 
            // PostavRed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 117);
            this.Controls.Add(id_PostavshikLabel);
            this.Controls.Add(this.id_PostavshikTextBox);
            this.Controls.Add(postavhikLabel);
            this.Controls.Add(this.postavhikTextBox);
            this.Controls.Add(id_adresLabel);
            this.Controls.Add(this.id_adresTextBox);
            this.Controls.Add(this.postavshikBindingNavigator);
            this.Name = "PostavRed";
            this.Text = "PostavRed";
            this.Load += new System.EventHandler(this.PostavRed_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bD_SeregiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postavshikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postavshikBindingNavigator)).EndInit();
            this.postavshikBindingNavigator.ResumeLayout(false);
            this.postavshikBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BD_SeregiDataSet bD_SeregiDataSet;
        private System.Windows.Forms.BindingSource postavshikBindingSource;
        private BD_SeregiDataSetTableAdapters.PostavshikTableAdapter postavshikTableAdapter;
        private BD_SeregiDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator postavshikBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton postavshikBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox id_PostavshikTextBox;
        private System.Windows.Forms.TextBox postavhikTextBox;
        private System.Windows.Forms.TextBox id_adresTextBox;
    }
}