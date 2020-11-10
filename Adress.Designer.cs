namespace Magazinciks
{
    partial class Adress
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
            System.Windows.Forms.Label id_AdresLabel;
            System.Windows.Forms.Label id_StranaLabel;
            System.Windows.Forms.Label id_RaionLabel;
            System.Windows.Forms.Label id_GorodLabel;
            System.Windows.Forms.Label id_UlicaLabel;
            System.Windows.Forms.Label domLabel;
            System.Windows.Forms.Label id_OblastLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Adress));
            this.bD_SeregiDataSet = new Magazinciks.BD_SeregiDataSet();
            this.adresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adresTableAdapter = new Magazinciks.BD_SeregiDataSetTableAdapters.AdresTableAdapter();
            this.tableAdapterManager = new Magazinciks.BD_SeregiDataSetTableAdapters.TableAdapterManager();
            this.adresBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.adresBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.id_AdresTextBox = new System.Windows.Forms.TextBox();
            this.id_StranaTextBox = new System.Windows.Forms.TextBox();
            this.id_RaionTextBox = new System.Windows.Forms.TextBox();
            this.id_GorodTextBox = new System.Windows.Forms.TextBox();
            this.id_UlicaTextBox = new System.Windows.Forms.TextBox();
            this.domTextBox = new System.Windows.Forms.TextBox();
            this.id_OblastTextBox = new System.Windows.Forms.TextBox();
            id_AdresLabel = new System.Windows.Forms.Label();
            id_StranaLabel = new System.Windows.Forms.Label();
            id_RaionLabel = new System.Windows.Forms.Label();
            id_GorodLabel = new System.Windows.Forms.Label();
            id_UlicaLabel = new System.Windows.Forms.Label();
            domLabel = new System.Windows.Forms.Label();
            id_OblastLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bD_SeregiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adresBindingNavigator)).BeginInit();
            this.adresBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // id_AdresLabel
            // 
            id_AdresLabel.AutoSize = true;
            id_AdresLabel.Location = new System.Drawing.Point(12, 31);
            id_AdresLabel.Name = "id_AdresLabel";
            id_AdresLabel.Size = new System.Drawing.Size(52, 13);
            id_AdresLabel.TabIndex = 1;
            id_AdresLabel.Text = "id Адрес:";
            // 
            // id_StranaLabel
            // 
            id_StranaLabel.AutoSize = true;
            id_StranaLabel.Location = new System.Drawing.Point(12, 57);
            id_StranaLabel.Name = "id_StranaLabel";
            id_StranaLabel.Size = new System.Drawing.Size(57, 13);
            id_StranaLabel.TabIndex = 3;
            id_StranaLabel.Text = "id Страна:";
            // 
            // id_RaionLabel
            // 
            id_RaionLabel.AutoSize = true;
            id_RaionLabel.Location = new System.Drawing.Point(12, 83);
            id_RaionLabel.Name = "id_RaionLabel";
            id_RaionLabel.Size = new System.Drawing.Size(52, 13);
            id_RaionLabel.TabIndex = 5;
            id_RaionLabel.Text = "id Район:";
            // 
            // id_GorodLabel
            // 
            id_GorodLabel.AutoSize = true;
            id_GorodLabel.Location = new System.Drawing.Point(12, 109);
            id_GorodLabel.Name = "id_GorodLabel";
            id_GorodLabel.Size = new System.Drawing.Size(51, 13);
            id_GorodLabel.TabIndex = 7;
            id_GorodLabel.Text = "id Город:";
            // 
            // id_UlicaLabel
            // 
            id_UlicaLabel.AutoSize = true;
            id_UlicaLabel.Location = new System.Drawing.Point(12, 135);
            id_UlicaLabel.Name = "id_UlicaLabel";
            id_UlicaLabel.Size = new System.Drawing.Size(53, 13);
            id_UlicaLabel.TabIndex = 9;
            id_UlicaLabel.Text = "id Улица:";
            // 
            // domLabel
            // 
            domLabel.AutoSize = true;
            domLabel.Location = new System.Drawing.Point(12, 161);
            domLabel.Name = "domLabel";
            domLabel.Size = new System.Drawing.Size(50, 13);
            domLabel.TabIndex = 11;
            domLabel.Text = "№Дома:";
            // 
            // id_OblastLabel
            // 
            id_OblastLabel.AutoSize = true;
            id_OblastLabel.Location = new System.Drawing.Point(12, 187);
            id_OblastLabel.Name = "id_OblastLabel";
            id_OblastLabel.Size = new System.Drawing.Size(64, 13);
            id_OblastLabel.TabIndex = 13;
            id_OblastLabel.Text = "id Область:";
            // 
            // bD_SeregiDataSet
            // 
            this.bD_SeregiDataSet.DataSetName = "BD_SeregiDataSet";
            this.bD_SeregiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // adresBindingSource
            // 
            this.adresBindingSource.DataMember = "Adres";
            this.adresBindingSource.DataSource = this.bD_SeregiDataSet;
            // 
            // adresTableAdapter
            // 
            this.adresTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdresTableAdapter = this.adresTableAdapter;
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
            this.tableAdapterManager.TovarTableAdapter = null;
            this.tableAdapterManager.UlicaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Magazinciks.BD_SeregiDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // adresBindingNavigator
            // 
            this.adresBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.adresBindingNavigator.BindingSource = this.adresBindingSource;
            this.adresBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.adresBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.adresBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.adresBindingNavigatorSaveItem});
            this.adresBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.adresBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.adresBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.adresBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.adresBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.adresBindingNavigator.Name = "adresBindingNavigator";
            this.adresBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.adresBindingNavigator.Size = new System.Drawing.Size(308, 25);
            this.adresBindingNavigator.TabIndex = 0;
            this.adresBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
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
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
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
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // adresBindingNavigatorSaveItem
            // 
            this.adresBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.adresBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("adresBindingNavigatorSaveItem.Image")));
            this.adresBindingNavigatorSaveItem.Name = "adresBindingNavigatorSaveItem";
            this.adresBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.adresBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.adresBindingNavigatorSaveItem.Click += new System.EventHandler(this.adresBindingNavigatorSaveItem_Click);
            // 
            // id_AdresTextBox
            // 
            this.id_AdresTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adresBindingSource, "id_Adres", true));
            this.id_AdresTextBox.Location = new System.Drawing.Point(84, 28);
            this.id_AdresTextBox.Name = "id_AdresTextBox";
            this.id_AdresTextBox.Size = new System.Drawing.Size(212, 20);
            this.id_AdresTextBox.TabIndex = 2;
            // 
            // id_StranaTextBox
            // 
            this.id_StranaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adresBindingSource, "id_Strana", true));
            this.id_StranaTextBox.Location = new System.Drawing.Point(84, 54);
            this.id_StranaTextBox.Name = "id_StranaTextBox";
            this.id_StranaTextBox.Size = new System.Drawing.Size(212, 20);
            this.id_StranaTextBox.TabIndex = 4;
            // 
            // id_RaionTextBox
            // 
            this.id_RaionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adresBindingSource, "id_Raion", true));
            this.id_RaionTextBox.Location = new System.Drawing.Point(84, 80);
            this.id_RaionTextBox.Name = "id_RaionTextBox";
            this.id_RaionTextBox.Size = new System.Drawing.Size(212, 20);
            this.id_RaionTextBox.TabIndex = 6;
            // 
            // id_GorodTextBox
            // 
            this.id_GorodTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adresBindingSource, "id_Gorod", true));
            this.id_GorodTextBox.Location = new System.Drawing.Point(84, 106);
            this.id_GorodTextBox.Name = "id_GorodTextBox";
            this.id_GorodTextBox.Size = new System.Drawing.Size(212, 20);
            this.id_GorodTextBox.TabIndex = 8;
            // 
            // id_UlicaTextBox
            // 
            this.id_UlicaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adresBindingSource, "id_Ulica", true));
            this.id_UlicaTextBox.Location = new System.Drawing.Point(84, 132);
            this.id_UlicaTextBox.Name = "id_UlicaTextBox";
            this.id_UlicaTextBox.Size = new System.Drawing.Size(212, 20);
            this.id_UlicaTextBox.TabIndex = 10;
            // 
            // domTextBox
            // 
            this.domTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adresBindingSource, "dom", true));
            this.domTextBox.Location = new System.Drawing.Point(84, 158);
            this.domTextBox.Name = "domTextBox";
            this.domTextBox.Size = new System.Drawing.Size(212, 20);
            this.domTextBox.TabIndex = 12;
            // 
            // id_OblastTextBox
            // 
            this.id_OblastTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adresBindingSource, "id_Oblast", true));
            this.id_OblastTextBox.Location = new System.Drawing.Point(84, 184);
            this.id_OblastTextBox.Name = "id_OblastTextBox";
            this.id_OblastTextBox.Size = new System.Drawing.Size(212, 20);
            this.id_OblastTextBox.TabIndex = 14;
            // 
            // Adress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 236);
            this.Controls.Add(id_AdresLabel);
            this.Controls.Add(this.id_AdresTextBox);
            this.Controls.Add(id_StranaLabel);
            this.Controls.Add(this.id_StranaTextBox);
            this.Controls.Add(id_RaionLabel);
            this.Controls.Add(this.id_RaionTextBox);
            this.Controls.Add(id_GorodLabel);
            this.Controls.Add(this.id_GorodTextBox);
            this.Controls.Add(id_UlicaLabel);
            this.Controls.Add(this.id_UlicaTextBox);
            this.Controls.Add(domLabel);
            this.Controls.Add(this.domTextBox);
            this.Controls.Add(id_OblastLabel);
            this.Controls.Add(this.id_OblastTextBox);
            this.Controls.Add(this.adresBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Adress";
            this.Text = "Adress";
            this.Load += new System.EventHandler(this.Adress_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bD_SeregiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adresBindingNavigator)).EndInit();
            this.adresBindingNavigator.ResumeLayout(false);
            this.adresBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BD_SeregiDataSet bD_SeregiDataSet;
        private System.Windows.Forms.BindingSource adresBindingSource;
        private BD_SeregiDataSetTableAdapters.AdresTableAdapter adresTableAdapter;
        private BD_SeregiDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator adresBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton adresBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox id_AdresTextBox;
        private System.Windows.Forms.TextBox id_StranaTextBox;
        private System.Windows.Forms.TextBox id_RaionTextBox;
        private System.Windows.Forms.TextBox id_GorodTextBox;
        private System.Windows.Forms.TextBox id_UlicaTextBox;
        private System.Windows.Forms.TextBox domTextBox;
        private System.Windows.Forms.TextBox id_OblastTextBox;
    }
}