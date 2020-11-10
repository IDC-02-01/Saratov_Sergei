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
    public partial class PostavRed : Form
    {
        public PostavRed()
        {
            InitializeComponent();
        }

        private void postavshikBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.postavshikBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.bD_SeregiDataSet);
            }
            catch (Exception)
            {

                MessageBox.Show("Столбцы должны быть заполнены!");
            }
            

        }

        private void PostavRed_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bD_SeregiDataSet.Postavshik". При необходимости она может быть перемещена или удалена.
            this.postavshikTableAdapter.Fill(this.bD_SeregiDataSet.Postavshik);

        }
    }
}
