
namespace MagazinWPF
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
            System.Windows.Forms.Label iD_MagazLabel;
            System.Windows.Forms.Label iD_TovarLabel;
            System.Windows.Forms.Label dateLabel;
            System.Windows.Forms.Label ostatok_magazLabel;
            System.Windows.Forms.Label prihon_magazLabel;
            System.Windows.Forms.Label iD_addressLabel;
            System.Windows.Forms.Label iD_NakladnayaLabel;
            this.magazinichDataSet = new MagazinWPF.MagazinichDataSet();
            this.magazBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.magazTableAdapter = new MagazinWPF.MagazinichDataSetTableAdapters.MagazTableAdapter();
            this.tableAdapterManager = new MagazinWPF.MagazinichDataSetTableAdapters.TableAdapterManager();
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
            this.iD_MagazTextBox = new System.Windows.Forms.TextBox();
            this.iD_TovarTextBox = new System.Windows.Forms.TextBox();
            this.dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ostatok_magazTextBox = new System.Windows.Forms.TextBox();
            this.prihon_magazTextBox = new System.Windows.Forms.TextBox();
            this.iD_addressTextBox = new System.Windows.Forms.TextBox();
            this.iD_NakladnayaTextBox = new System.Windows.Forms.TextBox();
            iD_MagazLabel = new System.Windows.Forms.Label();
            iD_TovarLabel = new System.Windows.Forms.Label();
            dateLabel = new System.Windows.Forms.Label();
            ostatok_magazLabel = new System.Windows.Forms.Label();
            prihon_magazLabel = new System.Windows.Forms.Label();
            iD_addressLabel = new System.Windows.Forms.Label();
            iD_NakladnayaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.magazinichDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.magazBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.magazBindingNavigator)).BeginInit();
            this.magazBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // magazinichDataSet
            // 
            this.magazinichDataSet.DataSetName = "MagazinichDataSet";
            this.magazinichDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // magazBindingSource
            // 
            this.magazBindingSource.DataMember = "Magaz";
            this.magazBindingSource.DataSource = this.magazinichDataSet;
            // 
            // magazTableAdapter
            // 
            this.magazTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AddressTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChekTableAdapter = null;
            this.tableAdapterManager.CityTableAdapter = null;
            this.tableAdapterManager.CountryTableAdapter = null;
            this.tableAdapterManager.Dok_TipTableAdapter = null;
            this.tableAdapterManager.KategoriyaTableAdapter = null;
            this.tableAdapterManager.MagazTableAdapter = this.magazTableAdapter;
            this.tableAdapterManager.NakladnayaTableAdapter = null;
            this.tableAdapterManager.NazvanieTableAdapter = null;
            this.tableAdapterManager.OrganizaciyaTableAdapter = null;
            this.tableAdapterManager.SkladTableAdapter = null;
            this.tableAdapterManager.StreetTableAdapter = null;
            this.tableAdapterManager.TovarTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MagazinWPF.MagazinichDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
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
            this.magazBindingNavigator.Size = new System.Drawing.Size(326, 25);
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
            // iD_MagazLabel
            // 
            iD_MagazLabel.AutoSize = true;
            iD_MagazLabel.Location = new System.Drawing.Point(11, 31);
            iD_MagazLabel.Name = "iD_MagazLabel";
            iD_MagazLabel.Size = new System.Drawing.Size(77, 13);
            iD_MagazLabel.TabIndex = 1;
            iD_MagazLabel.Text = "ID_Магазина:";
            // 
            // iD_MagazTextBox
            // 
            this.iD_MagazTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.magazBindingSource, "ID_Magaz", true));
            this.iD_MagazTextBox.Location = new System.Drawing.Point(98, 28);
            this.iD_MagazTextBox.Name = "iD_MagazTextBox";
            this.iD_MagazTextBox.Size = new System.Drawing.Size(200, 20);
            this.iD_MagazTextBox.TabIndex = 2;
            // 
            // iD_TovarLabel
            // 
            iD_TovarLabel.AutoSize = true;
            iD_TovarLabel.Location = new System.Drawing.Point(11, 57);
            iD_TovarLabel.Name = "iD_TovarLabel";
            iD_TovarLabel.Size = new System.Drawing.Size(64, 13);
            iD_TovarLabel.TabIndex = 3;
            iD_TovarLabel.Text = "ID_Товара:";
            // 
            // iD_TovarTextBox
            // 
            this.iD_TovarTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.magazBindingSource, "ID_Tovar", true));
            this.iD_TovarTextBox.Location = new System.Drawing.Point(98, 54);
            this.iD_TovarTextBox.Name = "iD_TovarTextBox";
            this.iD_TovarTextBox.Size = new System.Drawing.Size(200, 20);
            this.iD_TovarTextBox.TabIndex = 4;
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new System.Drawing.Point(11, 84);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(36, 13);
            dateLabel.TabIndex = 5;
            dateLabel.Text = "Дата:";
            // 
            // dateDateTimePicker
            // 
            this.dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.magazBindingSource, "Date", true));
            this.dateDateTimePicker.Location = new System.Drawing.Point(98, 80);
            this.dateDateTimePicker.Name = "dateDateTimePicker";
            this.dateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateDateTimePicker.TabIndex = 6;
            // 
            // ostatok_magazLabel
            // 
            ostatok_magazLabel.AutoSize = true;
            ostatok_magazLabel.Location = new System.Drawing.Point(11, 109);
            ostatok_magazLabel.Name = "ostatok_magazLabel";
            ostatok_magazLabel.Size = new System.Drawing.Size(52, 13);
            ostatok_magazLabel.TabIndex = 7;
            ostatok_magazLabel.Text = "Остаток:";
            // 
            // ostatok_magazTextBox
            // 
            this.ostatok_magazTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.magazBindingSource, "Ostatok_magaz", true));
            this.ostatok_magazTextBox.Location = new System.Drawing.Point(98, 106);
            this.ostatok_magazTextBox.Name = "ostatok_magazTextBox";
            this.ostatok_magazTextBox.Size = new System.Drawing.Size(200, 20);
            this.ostatok_magazTextBox.TabIndex = 8;
            // 
            // prihon_magazLabel
            // 
            prihon_magazLabel.AutoSize = true;
            prihon_magazLabel.Location = new System.Drawing.Point(11, 135);
            prihon_magazLabel.Name = "prihon_magazLabel";
            prihon_magazLabel.Size = new System.Drawing.Size(47, 13);
            prihon_magazLabel.TabIndex = 9;
            prihon_magazLabel.Text = "Приход:";
            // 
            // prihon_magazTextBox
            // 
            this.prihon_magazTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.magazBindingSource, "Prihon_magaz", true));
            this.prihon_magazTextBox.Location = new System.Drawing.Point(98, 132);
            this.prihon_magazTextBox.Name = "prihon_magazTextBox";
            this.prihon_magazTextBox.Size = new System.Drawing.Size(200, 20);
            this.prihon_magazTextBox.TabIndex = 10;
            // 
            // iD_addressLabel
            // 
            iD_addressLabel.AutoSize = true;
            iD_addressLabel.Location = new System.Drawing.Point(11, 161);
            iD_addressLabel.Name = "iD_addressLabel";
            iD_addressLabel.Size = new System.Drawing.Size(57, 13);
            iD_addressLabel.TabIndex = 11;
            iD_addressLabel.Text = "ID_адрес:";
            // 
            // iD_addressTextBox
            // 
            this.iD_addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.magazBindingSource, "ID_address", true));
            this.iD_addressTextBox.Location = new System.Drawing.Point(98, 158);
            this.iD_addressTextBox.Name = "iD_addressTextBox";
            this.iD_addressTextBox.Size = new System.Drawing.Size(200, 20);
            this.iD_addressTextBox.TabIndex = 12;
            // 
            // iD_NakladnayaLabel
            // 
            iD_NakladnayaLabel.AutoSize = true;
            iD_NakladnayaLabel.Location = new System.Drawing.Point(11, 187);
            iD_NakladnayaLabel.Name = "iD_NakladnayaLabel";
            iD_NakladnayaLabel.Size = new System.Drawing.Size(83, 13);
            iD_NakladnayaLabel.TabIndex = 13;
            iD_NakladnayaLabel.Text = "ID_Накладная:";
            // 
            // iD_NakladnayaTextBox
            // 
            this.iD_NakladnayaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.magazBindingSource, "ID_Nakladnaya", true));
            this.iD_NakladnayaTextBox.Location = new System.Drawing.Point(98, 184);
            this.iD_NakladnayaTextBox.Name = "iD_NakladnayaTextBox";
            this.iD_NakladnayaTextBox.Size = new System.Drawing.Size(200, 20);
            this.iD_NakladnayaTextBox.TabIndex = 14;
            // 
            // MagazRed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 240);
            this.Controls.Add(iD_MagazLabel);
            this.Controls.Add(this.iD_MagazTextBox);
            this.Controls.Add(iD_TovarLabel);
            this.Controls.Add(this.iD_TovarTextBox);
            this.Controls.Add(dateLabel);
            this.Controls.Add(this.dateDateTimePicker);
            this.Controls.Add(ostatok_magazLabel);
            this.Controls.Add(this.ostatok_magazTextBox);
            this.Controls.Add(prihon_magazLabel);
            this.Controls.Add(this.prihon_magazTextBox);
            this.Controls.Add(iD_addressLabel);
            this.Controls.Add(this.iD_addressTextBox);
            this.Controls.Add(iD_NakladnayaLabel);
            this.Controls.Add(this.iD_NakladnayaTextBox);
            this.Controls.Add(this.magazBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MagazRed";
            this.ShowIcon = false;
            this.Text = "Добавить/Редактировать";
            this.Load += new System.EventHandler(this.MagazRed_Load);
            ((System.ComponentModel.ISupportInitialize)(this.magazinichDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.magazBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.magazBindingNavigator)).EndInit();
            this.magazBindingNavigator.ResumeLayout(false);
            this.magazBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MagazinichDataSet magazinichDataSet;
        private System.Windows.Forms.BindingSource magazBindingSource;
        private MagazinichDataSetTableAdapters.MagazTableAdapter magazTableAdapter;
        private MagazinichDataSetTableAdapters.TableAdapterManager tableAdapterManager;
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
        private System.Windows.Forms.TextBox iD_MagazTextBox;
        private System.Windows.Forms.TextBox iD_TovarTextBox;
        private System.Windows.Forms.DateTimePicker dateDateTimePicker;
        private System.Windows.Forms.TextBox ostatok_magazTextBox;
        private System.Windows.Forms.TextBox prihon_magazTextBox;
        private System.Windows.Forms.TextBox iD_addressTextBox;
        private System.Windows.Forms.TextBox iD_NakladnayaTextBox;
    }
}