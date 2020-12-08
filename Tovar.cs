using System;
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
    public partial class Tovar : Form
    {
        public Tovar()
        {
            InitializeComponent();
        }
        MainWindow mw = new MainWindow();
        private void Tovar_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "magazinichDataSet.DataTable2". При необходимости она может быть перемещена или удалена.
            this.dataTable2TableAdapter.Fill(this.magazinichDataSet.DataTable2);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            mw.Show();
            this.Close();
        }
    }
}
