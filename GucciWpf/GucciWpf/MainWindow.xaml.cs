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

namespace GucciWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void GucciButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Biggie Cheese");
        }

        private void BiggieCheese_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("One and only,  " + txtGucci.Text + "Mr.Boombastic");
        }
    }
}
