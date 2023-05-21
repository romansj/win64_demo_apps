using ClassLibraryNETSt;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.Cryptography;
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

namespace WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private ObservableCollection<ExamplePair> obsCollection = new ObservableCollection<ExamplePair>();

        public MainWindow()
        {
            InitializeComponent();

            MyDataGrid.ItemsSource = obsCollection;


            var randomGenerator = new RandomGenerator("ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789 ");
            for (int i = 0; i < 100; i++)
            {
                var title = randomGenerator.getRandomString(5, 20);
                var descr = randomGenerator.getRandomString(5, 20);
                obsCollection.Add(new ExamplePair(title, descr));
            }
        }
    }
}
