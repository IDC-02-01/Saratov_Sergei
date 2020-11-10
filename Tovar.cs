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
    public partial class Tovar : Form
    {
        public Tovar()
        {
            InitializeComponent();
        }

        private void Tovar_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bD_SeregiDataSet.DataTable2". При необходимости она может быть перемещена или удалена.
            this.dataTable2TableAdapter.Fill(this.bD_SeregiDataSet.DataTable2);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            TovarRed tr = new TovarRed();
            tr.ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.dataTable2TableAdapter.Fill(this.bD_SeregiDataSet.DataTable2);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Close();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataTable2DataGridView.RowCount; i++)
            {
                dataTable2DataGridView.Rows[i].Selected = false;
                for (int j = 0; j < dataTable2DataGridView.ColumnCount; j++)
                    if (dataTable2DataGridView.Rows[i].Cells[j].Value != null)
                        if (dataTable2DataGridView.Rows[i].Cells[j].Value.ToString().Contains(toolStripTextBox1.Text))
                        {
                            dataTable2DataGridView.Rows[i].Selected = true;
                            break;
                        }
            }
        }
    }
}
