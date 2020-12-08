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
    public partial class Chek : Form
    {
        public Chek()
        {
            InitializeComponent();
        }

        private void Chek_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "MagazinichDataSet.Chek". При необходимости она может быть перемещена или удалена.
            this.ChekTableAdapter.Fill(this.MagazinichDataSet.Chek);

            this.reportViewer1.RefreshReport();
        }
    }
}
