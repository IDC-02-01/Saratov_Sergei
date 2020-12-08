using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MagazinWPF
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            MagazinWPF.MagazinichDataSet magazinichDataSet = ((MagazinWPF.MagazinichDataSet)(this.FindResource("magazinichDataSet")));
            // Загрузить данные в таблицу DataTable1. Можно изменить этот код как требуется.
            MagazinWPF.MagazinichDataSetTableAdapters.DataTable1TableAdapter magazinichDataSetDataTable1TableAdapter = new MagazinWPF.MagazinichDataSetTableAdapters.DataTable1TableAdapter();
            magazinichDataSetDataTable1TableAdapter.Fill(magazinichDataSet.DataTable1);
            System.Windows.Data.CollectionViewSource dataTable1ViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("dataTable1ViewSource")));
            dataTable1ViewSource.View.MoveCurrentToFirst();
        }
    }
}
