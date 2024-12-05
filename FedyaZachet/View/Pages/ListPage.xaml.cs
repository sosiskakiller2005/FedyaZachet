using FedyaZachet.Model;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FedyaZachet.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для ListPage.xaml
    /// </summary>
    public partial class ListPage : Page
    {
        private static FedyaZachetDbEntities _context = new FedyaZachetDbEntities();
        public ListPage()
        {
            InitializeComponent();
            MaterialsLv.ItemsSource = _context.Material.ToList();
        }
    }
}
