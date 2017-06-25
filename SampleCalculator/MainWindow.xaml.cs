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

namespace SampleCalculator
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
            double first = Convert.ToDouble(textBox.Text);
            double second = Convert.ToDouble(textBox_Copy.Text);
            switch (((ComboBoxItem)(comboBox.SelectedItem)).Content.ToString())
            {
                case "Add":
                    textBox_Copy1.Text = (first + second).ToString();
                    break;
                case "Multiply":
                    textBox_Copy1.Text = (first * second).ToString();
                    break;
                case "Substract":
                    textBox_Copy1.Text = (first - second).ToString();
                    break;
                case "Divide":
                    textBox_Copy1.Text = (first / second).ToString();
                    break;
            }
        }
    }
}
