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

namespace PractRab7.RunButton
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Random random = new Random();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnRunAway_MouseEnter(object sender, MouseEventArgs e)
        {
            
            double maxX = ActualWidth - btnRunAway.ActualWidth * 2;
            double maxY = ActualHeight - btnRunAway.ActualHeight * 2;

            double newX = random.NextDouble() * maxX;
            double newY = random.NextDouble() * maxY;

            btnRunAway.Margin = new Thickness(newX, newY, 0, 0);
        }
    }
}
