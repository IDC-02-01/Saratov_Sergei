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
    public partial class Sklad : Form
    {
        public Sklad()
        {
            InitializeComponent();
        }
        MainWindow mw = new MainWindow();
        private void Sklad_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "magazinichDataSet.DataTable3". При необходимости она может быть перемещена или удалена.
            this.dataTable3TableAdapter.Fill(this.magazinichDataSet.DataTable3);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            mw.Show();
            this.Close();
        }
    }
}