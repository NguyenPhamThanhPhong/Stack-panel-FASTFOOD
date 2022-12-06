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

namespace Stack_panel_FASTFOOD
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();

            

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Image i = new Image();
            i.Source = new BitmapImage(new Uri("C:\\Users\\user\\Desktop\\tren mang ve\\rocket.png"));
            //i.Margin = new Thickness(10);
            i.SetValue(Grid.RowProperty, 0);
            i.Width = 30;

            Button btn = new Button();
            btn.SetValue(Grid.RowProperty, 1);
            btn.FontSize = 26;
            btn.Content = "asdjdd";


            Grid gg = new Grid();
            RowDefinition R1 = new RowDefinition();
            R1.Height = new GridLength(1, GridUnitType.Star);
            RowDefinition R2 = new RowDefinition();
            R1.Height = new GridLength(3, GridUnitType.Star);
            gg.Margin = new Thickness(10);
            gg.RowDefinitions.Add(R1);
            gg.RowDefinitions.Add(R2);

            gg.Children.Add(i);
            gg.Children.Add(btn);
            stack_panel.Children.Add(gg);
        }
    }
}
