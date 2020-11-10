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
    public partial class NaklRed : Form
    {
        public NaklRed()
        {
            InitializeComponent();
        }

        private void nakladnayaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.nakladnayaBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.bD_SeregiDataSet);
            }
            catch (Exception)
            {

                MessageBox.Show("Столбцы должны быть заполнены!");
            }
          

        }

        private void NaklRed_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bD_SeregiDataSet.Nakladnaya". При необходимости она может быть перемещена или удалена.
            this.nakladnayaTableAdapter.Fill(this.bD_SeregiDataSet.Nakladnaya);

        }
    }
}
