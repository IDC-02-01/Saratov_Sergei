namespace Magazinciks
{
    partial class MagazRed
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MagazRed));
            System.Windows.Forms.Label id_MagazinaLabel;
            System.Windows.Forms.Label id_TovaraLabel;
            System.Windows.Forms.Label prihodLabel;
            System.Windows.Forms.Label rozn_cenaLabel;
            System.Windows.Forms.Label ostatok_v_magazLabel;
            System.Windows.Forms.Label id_ChekLabel;
            System.Windows.Forms.Label id_TipdocLabel;
            this.bD_SeregiDataSet = new Magazinciks.BD_SeregiDataSet();
            this.magazBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.magazTableAdapter = new Magazinciks.BD_SeregiDataSetTableAdapters.MagazTableAdapter();
            this.tableAdapterManager = new Magazinciks.BD_SeregiDataSetTableAdapters.TableAdapterManager();
            this.magazBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.magazBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.id_MagazinaTextBox = new System.Windows.Forms.TextBox();
            this.id_TovaraTextBox = new System.Windows.Forms.TextBox();
            this.prihodTextBox = new System.Windows.Forms.TextBox();
            this.rozn_cenaTextBox = new System.Windows.Forms.TextBox();
            this.ostatok_v_magazTextBox = new System.Windows.Forms.TextBox();
            this.id_ChekTextBox = new System.Windows.Forms.TextBox();
            this.id_TipdocTextBox = new System.Windows.Forms.TextBox();
            id_MagazinaLabel = new System.Windows.Forms.Label();
            id_TovaraLabel = new System.Windows.Forms.Label();
            prihodLabel = new System.Windows.Forms.Label();
            rozn_cenaLabel = new System.Windows.Forms.Label();
            ostatok_v_magazLabel = new System.Windows.Forms.Label();
            id_ChekLabel = new System.Windows.Forms.Label();
            id_TipdocLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bD_SeregiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.magazBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.magazBindingNavigator)).BeginInit();
            this.magazBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // bD_SeregiDataSet
            // 
            this.bD_SeregiDataSet.DataSetName = "BD_SeregiDataSet";
            this.bD_SeregiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // magazBindingSource
            // 
            this.magazBindingSource.DataMember = "Magaz";
            this.magazBindingSource.DataSource = this.bD_SeregiDataSet;
            // 
            // magazTableAdapter
            // 
            this.magazTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdresTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChekTableAdapter = null;
            this.tableAdapterManager.GorodTableAdapter = null;
            this.tableAdapterManager.KategoriaTableAdapter = null;
            this.tableAdapterManager.MagazTableAdapter = this.magazTableAdapter;
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
            // magazBindingNavigator
            // 
            this.magazBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.magazBindingNavigator.BindingSource = this.magazBindingSource;
            this.magazBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.magazBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.magazBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.magazBindingNavigatorSaveItem});
            this.magazBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.magazBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.magazBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.magazBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.magazBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.magazBindingNavigator.Name = "magazBindingNavigator";
            this.magazBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.magazBindingNavigator.Size = new System.Drawing.Size(302, 25);
            this.magazBindingNavigator.TabIndex = 0;
            this.magazBindingNavigator.Text = "bindingNavigator1";
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
            // magazBindingNavigatorSaveItem
            // 
            this.magazBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.magazBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("magazBindingNavigatorSaveItem.Image")));
            this.magazBindingNavigatorSaveItem.Name = "magazBindingNavigatorSaveItem";
            this.magazBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.magazBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.magazBindingNavigatorSaveItem.Click += new System.EventHandler(this.magazBindingNavigatorSaveItem_Click);
            // 
            // id_MagazinaLabel
            // 
            id_MagazinaLabel.AutoSize = true;
            id_MagazinaLabel.Location = new System.Drawing.Point(13, 31);
            id_MagazinaLabel.Name = "id_MagazinaLabel";
            id_MagazinaLabel.Size = new System.Drawing.Size(71, 13);
            id_MagazinaLabel.TabIndex = 1;
            id_MagazinaLabel.Text = "id Магазина:";
            // 
            // id_MagazinaTextBox
            // 
            this.id_MagazinaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.magazBindingSource, "id_Magazina", true));
            this.id_MagazinaTextBox.Location = new System.Drawing.Point(109, 28);
            this.id_MagazinaTextBox.Name = "id_MagazinaTextBox";
            this.id_MagazinaTextBox.Size = new System.Drawing.Size(172, 20);
            this.id_MagazinaTextBox.TabIndex = 2;
            // 
            // id_TovaraLabel
            // 
            id_TovaraLabel.AutoSize = true;
            id_TovaraLabel.Location = new System.Drawing.Point(13, 57);
            id_TovaraLabel.Name = "id_TovaraLabel";
            id_TovaraLabel.Size = new System.Drawing.Size(58, 13);
            id_TovaraLabel.TabIndex = 3;
            id_TovaraLabel.Text = "id Товара:";
            // 
            // id_TovaraTextBox
            // 
            this.id_TovaraTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.magazBindingSource, "id_Tovara", true));
            this.id_TovaraTextBox.Location = new System.Drawing.Point(109, 54);
            this.id_TovaraTextBox.Name = "id_TovaraTextBox";
            this.id_TovaraTextBox.Size = new System.Drawing.Size(172, 20);
            this.id_TovaraTextBox.TabIndex = 4;
            // 
            // prihodLabel
            // 
            prihodLabel.AutoSize = true;
            prihodLabel.Location = new System.Drawing.Point(13, 83);
            prihodLabel.Name = "prihodLabel";
            prihodLabel.Size = new System.Drawing.Size(47, 13);
            prihodLabel.TabIndex = 5;
            prihodLabel.Text = "Приход:";
            // 
            // prihodTextBox
            // 
            this.prihodTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.magazBindingSource, "Prihod", true));
            this.prihodTextBox.Location = new System.Drawing.Point(109, 80);
            this.prihodTextBox.Name = "prihodTextBox";
            this.prihodTextBox.Size = new System.Drawing.Size(172, 20);
            this.prihodTextBox.TabIndex = 6;
            // 
            // rozn_cenaLabel
            // 
            rozn_cenaLabel.AutoSize = true;
            rozn_cenaLabel.Location = new System.Drawing.Point(13, 109);
            rozn_cenaLabel.Name = "rozn_cenaLabel";
            rozn_cenaLabel.Size = new System.Drawing.Size(64, 13);
            rozn_cenaLabel.TabIndex = 7;
            rozn_cenaLabel.Text = "Розн.Цена:";
            // 
            // rozn_cenaTextBox
            // 
            this.rozn_cenaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.magazBindingSource, "Rozn_cena", true));
            this.rozn_cenaTextBox.Location = new System.Drawing.Point(109, 106);
            this.rozn_cenaTextBox.Name = "rozn_cenaTextBox";
            this.rozn_cenaTextBox.Size = new System.Drawing.Size(172, 20);
            this.rozn_cenaTextBox.TabIndex = 8;
            // 
            // ostatok_v_magazLabel
            // 
            ostatok_v_magazLabel.AutoSize = true;
            ostatok_v_magazLabel.Location = new System.Drawing.Point(13, 135);
            ostatok_v_magazLabel.Name = "ostatok_v_magazLabel";
            ostatok_v_magazLabel.Size = new System.Drawing.Size(93, 13);
            ostatok_v_magazLabel.TabIndex = 9;
            ostatok_v_magazLabel.Text = "Ост. в магазине:";
            // 
            // ostatok_v_magazTextBox
            // 
            this.ostatok_v_magazTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.magazBindingSource, "Ostatok_v_magaz", true));
            this.ostatok_v_magazTextBox.Location = new System.Drawing.Point(109, 132);
            this.ostatok_v_magazTextBox.Name = "ostatok_v_magazTextBox";
            this.ostatok_v_magazTextBox.Size = new System.Drawing.Size(172, 20);
            this.ostatok_v_magazTextBox.TabIndex = 10;
            // 
            // id_ChekLabel
            // 
            id_ChekLabel.AutoSize = true;
            id_ChekLabel.Location = new System.Drawing.Point(13, 161);
            id_ChekLabel.Name = "id_ChekLabel";
            id_ChekLabel.Size = new System.Drawing.Size(41, 13);
            id_ChekLabel.TabIndex = 11;
            id_ChekLabel.Text = "id Чек:";
            // 
            // id_ChekTextBox
            // 
            this.id_ChekTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.magazBindingSource, "id_Chek", true));
            this.id_ChekTextBox.Location = new System.Drawing.Point(109, 158);
            this.id_ChekTextBox.Name = "id_ChekTextBox";
            this.id_ChekTextBox.Size = new System.Drawing.Size(172, 20);
            this.id_ChekTextBox.TabIndex = 12;
            // 
            // id_TipdocLabel
            // 
            id_TipdocLabel.AutoSize = true;
            id_TipdocLabel.Location = new System.Drawing.Point(13, 187);
            id_TipdocLabel.Name = "id_TipdocLabel";
            id_TipdocLabel.Size = new System.Drawing.Size(58, 13);
            id_TipdocLabel.TabIndex = 13;
            id_TipdocLabel.Text = "id Типдок:";
            // 
            // id_TipdocTextBox
            // 
            this.id_TipdocTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.magazBindingSource, "id_Tipdoc", true));
            this.id_TipdocTextBox.Location = new System.Drawing.Point(109, 184);
            this.id_TipdocTextBox.Name = "id_TipdocTextBox";
            this.id_TipdocTextBox.Size = new System.Drawing.Size(172, 20);
            this.id_TipdocTextBox.TabIndex = 14;
            // 
            // MagazRed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 233);
            this.Controls.Add(id_MagazinaLabel);
            this.Controls.Add(this.id_MagazinaTextBox);
            this.Controls.Add(id_TovaraLabel);
            this.Controls.Add(this.id_TovaraTextBox);
            this.Controls.Add(prihodLabel);
            this.Controls.Add(this.prihodTextBox);
            this.Controls.Add(rozn_cenaLabel);
            this.Controls.Add(this.rozn_cenaTextBox);
            this.Controls.Add(ostatok_v_magazLabel);
            this.Controls.Add(this.ostatok_v_magazTextBox);
            this.Controls.Add(id_ChekLabel);
            this.Controls.Add(this.id_ChekTextBox);
            this.Controls.Add(id_TipdocLabel);
            this.Controls.Add(this.id_TipdocTextBox);
            this.Controls.Add(this.magazBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MagazRed";
            this.Text = "MagazRed";
            this.Load += new System.EventHandler(this.MagazRed_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bD_SeregiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.magazBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.magazBindingNavigator)).EndInit();
            this.magazBindingNavigator.ResumeLayout(false);
            this.magazBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BD_SeregiDataSet bD_SeregiDataSet;
        private System.Windows.Forms.BindingSource magazBindingSource;
        private BD_SeregiDataSetTableAdapters.MagazTableAdapter magazTableAdapter;
        private BD_SeregiDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator magazBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton magazBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox id_MagazinaTextBox;
        private System.Windows.Forms.TextBox id_TovaraTextBox;
        private System.Windows.Forms.TextBox prihodTextBox;
        private System.Windows.Forms.TextBox rozn_cenaTextBox;
        private System.Windows.Forms.TextBox ostatok_v_magazTextBox;
        private System.Windows.Forms.TextBox id_ChekTextBox;
        private System.Windows.Forms.TextBox id_TipdocTextBox;
    }
}