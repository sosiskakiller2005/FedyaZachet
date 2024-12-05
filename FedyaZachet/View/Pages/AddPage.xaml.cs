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
    /// Логика взаимодействия для AddPage.xaml
    /// </summary>
    public partial class AddPage : Page
    {
        private static FedyaZachetDbEntities _context = new FedyaZachetDbEntities();
        public AddPage()
        {
            InitializeComponent();
            CategoryCmb.ItemsSource = _context.Category.ToList();
            CategoryCmb.DisplayMemberPath = "Name";
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            Material material = new Material()
            {
                Name = NameTb.Text,
                Category = CategoryCmb.SelectedItem as Category,
                Amount = Convert.ToInt32(AmountTB.Text),
                Price = Convert.ToInt32(PriceTb.Text)
            };
            _context.Material.Add(material);
            _context.SaveChanges();
            MessageBox.Show("Товар добавлен");
        }
    }
}
