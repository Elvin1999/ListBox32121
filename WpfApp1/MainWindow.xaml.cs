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
using System.Windows.Threading;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer timer = new DispatcherTimer();
        public MainWindow()
        {
            InitializeComponent();
            timer.Interval = TimeSpan.FromMilliseconds(500);
            //timer.Tick += Timer_Tick;
            // timer.Start();
            //OldValue = myslider.Value;

            //listbox.ItemsSource=GetCars();
            //mydatagrid.ItemsSource=GetCars();

        }

        public List<Car> GetCars()
        {
            return new List<Car>
            {
                new Car
                {
                    Model="E-200",
                    Vendor="Mercedes",
                    Year=2022
                },
                new Car
                {
                    Model="Malibu",
                    Vendor="Chevrolet",
                    Year=2022
                },
                new Car
                {
                    Model="Grandeour",
                    Vendor="Hyundai",
                    Year=2022
                },
                new Car
                {
                    Model="Supra",
                    Vendor="Toyota",
                    Year=2022
                },
                new Car
                {
                    Model="A8",
                    Vendor="Audi",
                    Year=2022
                }
            };
        }

        private void listbox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //var car=listbox.SelectedItem as Car;
            //MessageBox.Show(car.ToString());
        }

        private void cbmbox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var  item=cbmbox.SelectedItem as ComboBoxItem;
            var element=item.Content as StackPanel;
            var txt = element.Children[1] as TextBlock;
            MessageBox.Show(txt.Text);
        }

        //private void Timer_Tick(object sender, EventArgs e)
        //{
        //    if (prgbar.Value < prgbar.Maximum)
        //    {
        //        prgbar.Value += 5;
        //    }
        //    else
        //    {
        //        timer.Stop();
        //        MessageBox.Show("Download Ended");
        //    }
        //}

        //private void up_Click(object sender, RoutedEventArgs e)
        //{
        //    if (prgbar.Value < prgbar.Maximum)
        //    {
        //        prgbar.Value += 5;
        //    }
        //}

        //private void down_Click(object sender, RoutedEventArgs e)
        //{
        //    if (prgbar.Value > prgbar.Minimum)
        //    {
        //        prgbar.Value -= 5;
        //    }
        //}
        //public double OldValue { get; set; }
        //private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        //{
        //    this.Width = this.MinWidth + myslider.Value;

        //    //if (myslider.Value > OldValue)
        //    //{
        //    //    this.Width += 1;
        //    //    OldValue = myslider.Value;
        //    //}
        //    //else
        //    //{
        //    //    this.Width -= 1;
        //    //    OldValue = myslider.Value;
        //    //}
        //}
    }
}
