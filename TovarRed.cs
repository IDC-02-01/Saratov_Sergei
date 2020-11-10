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
    public partial class TovarRed : Form
    {
        public TovarRed()
        {
            InitializeComponent();
        }

        private void tovarBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.tovarBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.bD_SeregiDataSet);
            }
            catch (Exception)
            {

                MessageBox.Show("Поля должны быть заполнены!");
            }
           

        }

        private void TovarRed_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bD_SeregiDataSet.Tovar". При необходимости она может быть перемещена или удалена.
            this.tovarTableAdapter.Fill(this.bD_SeregiDataSet.Tovar);

        }
    }
}
