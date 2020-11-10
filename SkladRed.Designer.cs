namespace Magazinciks
{
    partial class SkladRed
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SkladRed));
            System.Windows.Forms.Label id_skaldaLabel;
            System.Windows.Forms.Label id_tovaraLabel;
            System.Windows.Forms.Label kol_vo_tovaraa_na_skaldeLabel;
            System.Windows.Forms.Label optovaya_cenaLabel;
            System.Windows.Forms.Label rozn_cenaLabel;
            System.Windows.Forms.Label ostatok_na_skladeLabel;
            System.Windows.Forms.Label prihodLabel;
            System.Windows.Forms.Label id_TipdocLabel;
            this.bD_SeregiDataSet = new Magazinciks.BD_SeregiDataSet();
            this.skladBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.skladTableAdapter = new Magazinciks.BD_SeregiDataSetTableAdapters.SkladTableAdapter();
            this.tableAdapterManager = new Magazinciks.BD_SeregiDataSetTableAdapters.TableAdapterManager();
            this.skladBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.skladBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.id_skaldaTextBox = new System.Windows.Forms.TextBox();
            this.id_tovaraTextBox = new System.Windows.Forms.TextBox();
            this.kol_vo_tovaraa_na_skaldeTextBox = new System.Windows.Forms.TextBox();
            this.optovaya_cenaTextBox = new System.Windows.Forms.TextBox();
            this.rozn_cenaTextBox = new System.Windows.Forms.TextBox();
            this.ostatok_na_skladeTextBox = new System.Windows.Forms.TextBox();
            this.prihodTextBox = new System.Windows.Forms.TextBox();
            this.id_TipdocTextBox = new System.Windows.Forms.TextBox();
            id_skaldaLabel = new System.Windows.Forms.Label();
            id_tovaraLabel = new System.Windows.Forms.Label();
            kol_vo_tovaraa_na_skaldeLabel = new System.Windows.Forms.Label();
            optovaya_cenaLabel = new System.Windows.Forms.Label();
            rozn_cenaLabel = new System.Windows.Forms.Label();
            ostatok_na_skladeLabel = new System.Windows.Forms.Label();
            prihodLabel = new System.Windows.Forms.Label();
            id_TipdocLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bD_SeregiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skladBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skladBindingNavigator)).BeginInit();
            this.skladBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // bD_SeregiDataSet
            // 
            this.bD_SeregiDataSet.DataSetName = "BD_SeregiDataSet";
            this.bD_SeregiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // skladBindingSource
            // 
            this.skladBindingSource.DataMember = "Sklad";
            this.skladBindingSource.DataSource = this.bD_SeregiDataSet;
            // 
            // skladTableAdapter
            // 
            this.skladTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.SkladTableAdapter = this.skladTableAdapter;
            this.tableAdapterManager.StatusTableAdapter = null;
            this.tableAdapterManager.StranaTableAdapter = null;
            this.tableAdapterManager.TipDocTableAdapter = null;
            this.tableAdapterManager.TovarTableAdapter = null;
            this.tableAdapterManager.UlicaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Magazinciks.BD_SeregiDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // skladBindingNavigator
            // 
            this.skladBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.skladBindingNavigator.BindingSource = this.skladBindingSource;
            this.skladBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.skladBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.skladBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.skladBindingNavigatorSaveItem});
            this.skladBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.skladBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.skladBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.skladBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.skladBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.skladBindingNavigator.Name = "skladBindingNavigator";
            this.skladBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.skladBindingNavigator.Size = new System.Drawing.Size(316, 25);
            this.skladBindingNavigator.TabIndex = 0;
            this.skladBindingNavigator.Text = "bindingNavigator1";
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
            // skladBindingNavigatorSaveItem
            // 
            this.skladBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.skladBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("skladBindingNavigatorSaveItem.Image")));
            this.skladBindingNavigatorSaveItem.Name = "skladBindingNavigatorSaveItem";
            this.skladBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.skladBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.skladBindingNavigatorSaveItem.Click += new System.EventHandler(this.skladBindingNavigatorSaveItem_Click);
            // 
            // id_skaldaLabel
            // 
            id_skaldaLabel.AutoSize = true;
            id_skaldaLabel.Location = new System.Drawing.Point(12, 40);
            id_skaldaLabel.Name = "id_skaldaLabel";
            id_skaldaLabel.Size = new System.Drawing.Size(58, 13);
            id_skaldaLabel.TabIndex = 1;
            id_skaldaLabel.Text = "id Склада:";
            // 
            // id_skaldaTextBox
            // 
            this.id_skaldaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.skladBindingSource, "id_skalda", true));
            this.id_skaldaTextBox.Location = new System.Drawing.Point(150, 37);
            this.id_skaldaTextBox.Name = "id_skaldaTextBox";
            this.id_skaldaTextBox.Size = new System.Drawing.Size(139, 20);
            this.id_skaldaTextBox.TabIndex = 2;
            // 
            // id_tovaraLabel
            // 
            id_tovaraLabel.AutoSize = true;
            id_tovaraLabel.Location = new System.Drawing.Point(12, 66);
            id_tovaraLabel.Name = "id_tovaraLabel";
            id_tovaraLabel.Size = new System.Drawing.Size(58, 13);
            id_tovaraLabel.TabIndex = 3;
            id_tovaraLabel.Text = "id Товара:";
            // 
            // id_tovaraTextBox
            // 
            this.id_tovaraTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.skladBindingSource, "id_tovara", true));
            this.id_tovaraTextBox.Location = new System.Drawing.Point(150, 63);
            this.id_tovaraTextBox.Name = "id_tovaraTextBox";
            this.id_tovaraTextBox.Size = new System.Drawing.Size(139, 20);
            this.id_tovaraTextBox.TabIndex = 4;
            // 
            // kol_vo_tovaraa_na_skaldeLabel
            // 
            kol_vo_tovaraa_na_skaldeLabel.AutoSize = true;
            kol_vo_tovaraa_na_skaldeLabel.Location = new System.Drawing.Point(12, 92);
            kol_vo_tovaraa_na_skaldeLabel.Name = "kol_vo_tovaraa_na_skaldeLabel";
            kol_vo_tovaraa_na_skaldeLabel.Size = new System.Drawing.Size(136, 13);
            kol_vo_tovaraa_na_skaldeLabel.TabIndex = 5;
            kol_vo_tovaraa_na_skaldeLabel.Text = "Кол-во товара на складе:";
            // 
            // kol_vo_tovaraa_na_skaldeTextBox
            // 
            this.kol_vo_tovaraa_na_skaldeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.skladBindingSource, "kol-vo_tovaraa_na_skalde", true));
            this.kol_vo_tovaraa_na_skaldeTextBox.Location = new System.Drawing.Point(150, 89);
            this.kol_vo_tovaraa_na_skaldeTextBox.Name = "kol_vo_tovaraa_na_skaldeTextBox";
            this.kol_vo_tovaraa_na_skaldeTextBox.Size = new System.Drawing.Size(139, 20);
            this.kol_vo_tovaraa_na_skaldeTextBox.TabIndex = 6;
            // 
            // optovaya_cenaLabel
            // 
            optovaya_cenaLabel.AutoSize = true;
            optovaya_cenaLabel.Location = new System.Drawing.Point(12, 118);
            optovaya_cenaLabel.Name = "optovaya_cenaLabel";
            optovaya_cenaLabel.Size = new System.Drawing.Size(80, 13);
            optovaya_cenaLabel.TabIndex = 7;
            optovaya_cenaLabel.Text = "Оптовая цена:";
            // 
            // optovaya_cenaTextBox
            // 
            this.optovaya_cenaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.skladBindingSource, "Optovaya_cena", true));
            this.optovaya_cenaTextBox.Location = new System.Drawing.Point(150, 115);
            this.optovaya_cenaTextBox.Name = "optovaya_cenaTextBox";
            this.optovaya_cenaTextBox.Size = new System.Drawing.Size(139, 20);
            this.optovaya_cenaTextBox.TabIndex = 8;
            // 
            // rozn_cenaLabel
            // 
            rozn_cenaLabel.AutoSize = true;
            rozn_cenaLabel.Location = new System.Drawing.Point(12, 144);
            rozn_cenaLabel.Name = "rozn_cenaLabel";
            rozn_cenaLabel.Size = new System.Drawing.Size(65, 13);
            rozn_cenaLabel.TabIndex = 9;
            rozn_cenaLabel.Text = "Розн. цена:";
            // 
            // rozn_cenaTextBox
            // 
            this.rozn_cenaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.skladBindingSource, "Rozn_cena", true));
            this.rozn_cenaTextBox.Location = new System.Drawing.Point(150, 141);
            this.rozn_cenaTextBox.Name = "rozn_cenaTextBox";
            this.rozn_cenaTextBox.Size = new System.Drawing.Size(139, 20);
            this.rozn_cenaTextBox.TabIndex = 10;
            // 
            // ostatok_na_skladeLabel
            // 
            ostatok_na_skladeLabel.AutoSize = true;
            ostatok_na_skladeLabel.Location = new System.Drawing.Point(12, 170);
            ostatok_na_skladeLabel.Name = "ostatok_na_skladeLabel";
            ostatok_na_skladeLabel.Size = new System.Drawing.Size(106, 13);
            ostatok_na_skladeLabel.TabIndex = 11;
            ostatok_na_skladeLabel.Text = "Остаток на складе:";
            // 
            // ostatok_na_skladeTextBox
            // 
            this.ostatok_na_skladeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.skladBindingSource, "Ostatok_na_sklade", true));
            this.ostatok_na_skladeTextBox.Location = new System.Drawing.Point(150, 167);
            this.ostatok_na_skladeTextBox.Name = "ostatok_na_skladeTextBox";
            this.ostatok_na_skladeTextBox.Size = new System.Drawing.Size(139, 20);
            this.ostatok_na_skladeTextBox.TabIndex = 12;
            // 
            // prihodLabel
            // 
            prihodLabel.AutoSize = true;
            prihodLabel.Location = new System.Drawing.Point(12, 196);
            prihodLabel.Name = "prihodLabel";
            prihodLabel.Size = new System.Drawing.Size(47, 13);
            prihodLabel.TabIndex = 13;
            prihodLabel.Text = "Приход:";
            // 
            // prihodTextBox
            // 
            this.prihodTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.skladBindingSource, "Prihod", true));
            this.prihodTextBox.Location = new System.Drawing.Point(150, 193);
            this.prihodTextBox.Name = "prihodTextBox";
            this.prihodTextBox.Size = new System.Drawing.Size(139, 20);
            this.prihodTextBox.TabIndex = 14;
            // 
            // id_TipdocLabel
            // 
            id_TipdocLabel.AutoSize = true;
            id_TipdocLabel.Location = new System.Drawing.Point(12, 222);
            id_TipdocLabel.Name = "id_TipdocLabel";
            id_TipdocLabel.Size = new System.Drawing.Size(97, 13);
            id_TipdocLabel.TabIndex = 15;
            id_TipdocLabel.Text = "id Тип документа:";
            // 
            // id_TipdocTextBox
            // 
            this.id_TipdocTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.skladBindingSource, "id_Tipdoc", true));
            this.id_TipdocTextBox.Location = new System.Drawing.Point(150, 219);
            this.id_TipdocTextBox.Name = "id_TipdocTextBox";
            this.id_TipdocTextBox.Size = new System.Drawing.Size(139, 20);
            this.id_TipdocTextBox.TabIndex = 16;
            // 
            // SkladRed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 283);
            this.Controls.Add(id_skaldaLabel);
            this.Controls.Add(this.id_skaldaTextBox);
            this.Controls.Add(id_tovaraLabel);
            this.Controls.Add(this.id_tovaraTextBox);
            this.Controls.Add(kol_vo_tovaraa_na_skaldeLabel);
            this.Controls.Add(this.kol_vo_tovaraa_na_skaldeTextBox);
            this.Controls.Add(optovaya_cenaLabel);
            this.Controls.Add(this.optovaya_cenaTextBox);
            this.Controls.Add(rozn_cenaLabel);
            this.Controls.Add(this.rozn_cenaTextBox);
            this.Controls.Add(ostatok_na_skladeLabel);
            this.Controls.Add(this.ostatok_na_skladeTextBox);
            this.Controls.Add(prihodLabel);
            this.Controls.Add(this.prihodTextBox);
            this.Controls.Add(id_TipdocLabel);
            this.Controls.Add(this.id_TipdocTextBox);
            this.Controls.Add(this.skladBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SkladRed";
            this.Text = "SkladRed";
            this.Load += new System.EventHandler(this.SkladRed_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bD_SeregiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skladBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skladBindingNavigator)).EndInit();
            this.skladBindingNavigator.ResumeLayout(false);
            this.skladBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BD_SeregiDataSet bD_SeregiDataSet;
        private System.Windows.Forms.BindingSource skladBindingSource;
        private BD_SeregiDataSetTableAdapters.SkladTableAdapter skladTableAdapter;
        private BD_SeregiDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator skladBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton skladBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox id_skaldaTextBox;
        private System.Windows.Forms.TextBox id_tovaraTextBox;
        private System.Windows.Forms.TextBox kol_vo_tovaraa_na_skaldeTextBox;
        private System.Windows.Forms.TextBox optovaya_cenaTextBox;
        private System.Windows.Forms.TextBox rozn_cenaTextBox;
        private System.Windows.Forms.TextBox ostatok_na_skladeTextBox;
        private System.Windows.Forms.TextBox prihodTextBox;
        private System.Windows.Forms.TextBox id_TipdocTextBox;
    }
}