﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magazinciks
{
    public partial class Otchet : Form
    {
        public Otchet()
        {
            InitializeComponent();
        }

        private void Otchet_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "BD_SeregiDataSet.Otchet". При необходимости она может быть перемещена или удалена.
            this.OtchetTableAdapter.Fill(this.BD_SeregiDataSet.Otchet);

            this.reportViewer1.RefreshReport();
        }
    }
}