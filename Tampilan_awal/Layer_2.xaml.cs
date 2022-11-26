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

namespace Tampilan_awal
{
    /// <summary>
    /// Interaction logic for Layer_2.xaml
    /// </summary>
    public partial class Layer_2 : Window
    {
        public Layer_2()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow objMainwindow = new MainWindow();
            this.Visibility = Visibility.Hidden;
            objMainwindow.Show();
        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            Layer_3 objLayer_3 = new Layer_3();
            this.Visibility = Visibility.Hidden;
            objLayer_3.Show();
        }

        private void NoneTopping_Click(object sender, RoutedEventArgs e)
        {

        }

        private void EggPudding_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BobaPearl_Click(object sender, RoutedEventArgs e)
        {

        }

        private void OatMeal_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CheeseFoam_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Regal_Click(object sender, RoutedEventArgs e)
        {

        }

        private void NoSugar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void LessSugar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void NormalSugar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ExtraSugar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void NoIce_Click(object sender, RoutedEventArgs e)
        {

        }

        private void LessIce_Click(object sender, RoutedEventArgs e)
        {

        }

        private void NormalIce_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ExtraIce_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Tambah_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Kurang_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AddOrder_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
