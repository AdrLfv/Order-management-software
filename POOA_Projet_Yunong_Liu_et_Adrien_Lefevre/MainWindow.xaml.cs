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

namespace POOA_Projet_Yunong_Liu_et_Adrien_Lefevre
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Pizzeria pizzeria;
        public MainWindow()
        {
            InitializeComponent();
            pizzeria = new Pizzeria();
        }
        public MainWindow(Pizzeria pizzeria)
        {
            this.pizzeria = pizzeria;
            InitializeComponent();
        }
        private void BoutonModule1_Click(object sender, RoutedEventArgs e)
        {
            Module1 module1 = new Module1(pizzeria);
            module1.Show();
            this.Close();
        }
        private void BoutonModule2_Click(object sender, RoutedEventArgs e)
        {
            Module2 module2 = new Module2(pizzeria);
            module2.Show();
            this.Close();
        }
        private void BoutonModule3_Click(object sender, RoutedEventArgs e)
        {
            Module3 module3 = new Module3(pizzeria);
            module3.Show();
            this.Close();
        }
        private void BoutonModule4_Click(object sender, RoutedEventArgs e)
        {
            Module4 module4 = new Module4(pizzeria);
            module4.Show();
            this.Close();
        }
    }
}
