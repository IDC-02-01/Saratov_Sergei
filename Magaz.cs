﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagazinWPF
{
    public partial class Magaz : Form
    {
        public Magaz()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "magazinichDataSet.DataTable1". При необходимости она может быть перемещена или удалена.
            this.dataTable1TableAdapter.Fill(this.magazinichDataSet.DataTable1);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.dataTable1TableAdapter.Fill(this.magazinichDataSet.DataTable1);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            MainWindow main = new MainWindow();
            this.Close();
            main.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataTable1DataGridView.RowCount; i++)
            {
                dataTable1DataGridView.Rows[i].Selected = false;
                for (int j = 0; j < dataTable1DataGridView.ColumnCount; j++)
                    if (dataTable1DataGridView.Rows[i].Cells[j].Value != null)
                        if (dataTable1DataGridView.Rows[i].Cells[j].Value.ToString().Contains(toolStripTextBox1.Text))
                        {
                            dataTable1DataGridView.Rows[i].Selected = true;
                            break;
                        }
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            try
            {
                MagazRed mr = new MagazRed();
                mr.ShowDialog();
            }
            catch (Exception x)
            {

                MessageBox.Show("Ошибка!"+x);
            }
           
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Chek ck = new Chek();
            ck.ShowDialog();
        }
    }
}
