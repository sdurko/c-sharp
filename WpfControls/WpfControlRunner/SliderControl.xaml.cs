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

namespace WpfControlRunner
{
    /// <summary>
    /// Interaction logic for SliderControl.xaml
    /// </summary>
    public partial class SliderControl : Window
    {
        private readonly SliderControlVM _viewModel;

        public SliderControl()
        {
            InitializeComponent();
            

            _viewModel = new SliderControlVM(this.Dispatcher);
            this.DataContext = _viewModel;
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Color clr = Color.FromArgb(255, 
                Convert.ToByte(RedSlider.Value),
                Convert.ToByte(GreenSlider.Value),
                Convert.ToByte(BlueSlider.Value));

            Circle.Fill = new SolidColorBrush(clr);
        }
    }
}
