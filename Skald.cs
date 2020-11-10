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
    public partial class Skald : Form
    {
        public Skald()
        {
            InitializeComponent();
        }

        private void Skald_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bD_SeregiDataSet.DataTable4". При необходимости она может быть перемещена или удалена.
            this.dataTable4TableAdapter.Fill(this.bD_SeregiDataSet.DataTable4);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.dataTable4TableAdapter.Fill(this.bD_SeregiDataSet.DataTable4);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Close();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            SkladRed sr = new SkladRed();
            sr.ShowDialog();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataTable4DataGridView.RowCount; i++)
            {
                dataTable4DataGridView.Rows[i].Selected = false;
                for (int j = 0; j < dataTable4DataGridView.ColumnCount; j++)
                    if (dataTable4DataGridView.Rows[i].Cells[j].Value != null)
                        if (dataTable4DataGridView.Rows[i].Cells[j].Value.ToString().Contains(toolStripTextBox1.Text))
                        {
                            dataTable4DataGridView.Rows[i].Selected = true;
                            break;
                        }
            }
        }
    }
}
