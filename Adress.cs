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
    public partial class Adress : Form
    {
        public Adress()
        {
            InitializeComponent();
        }

        private void adresBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.adresBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.bD_SeregiDataSet);
            }
            catch (Exception)
            {

                MessageBox.Show("Столбцы должны быть заполнены!");
            }
           

        }

        private void Adress_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bD_SeregiDataSet.Adres". При необходимости она может быть перемещена или удалена.
            this.adresTableAdapter.Fill(this.bD_SeregiDataSet.Adres);

        }
    }
}
