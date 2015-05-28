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
using WpfRangeControls;

namespace demo
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

        private void button_Click(object sender, RoutedEventArgs e)
        {
            //ascbar.Marks.Add(new Rectangle() { Fill = Brushes.Green, Width = 10, Height = 10 });
        }

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            //var pos = AdvancedScrollbar.GetPosition(mover);
            //AdvancedScrollbar.SetPosition(mover, (pos + 13) % ascbar.Maximum);

        }
    }
}
