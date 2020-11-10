using System;
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
    public partial class Nakladnaya : Form
    {
        public Nakladnaya()
        {
            InitializeComponent();
        }

        private void Nakladnaya_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bD_SeregiDataSet.DataTable5". При необходимости она может быть перемещена или удалена.
            this.dataTable5TableAdapter.Fill(this.bD_SeregiDataSet.DataTable5);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.dataTable5TableAdapter.Fill(this.bD_SeregiDataSet.DataTable5);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Close();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            NaklRed nr = new NaklRed();
            nr.ShowDialog();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataTable5DataGridView.RowCount; i++)
            {
                dataTable5DataGridView.Rows[i].Selected = false;
                for (int j = 0; j < dataTable5DataGridView.ColumnCount; j++)
                    if (dataTable5DataGridView.Rows[i].Cells[j].Value != null)
                        if (dataTable5DataGridView.Rows[i].Cells[j].Value.ToString().Contains(toolStripTextBox1.Text))
                        {
                            dataTable5DataGridView.Rows[i].Selected = true;
                            break;
                        }
            }
        }
    }
}
