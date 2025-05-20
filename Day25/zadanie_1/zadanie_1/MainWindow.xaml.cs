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

namespace zadanie_1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            buttonRun.Click += ButtonRun_Click;
        }

        private void ButtonRun_Click(object sender, RoutedEventArgs e)
        {
            string hello = "Hello";
            string input = string.Empty;
            if (string.IsNullOrEmpty(TextBoxEnrerName.Text)
                || string.IsNullOrEmpty(TextBoxEnrerName.Text))
            {
                input = "World!";
            }
            else
            {
                input = TextBoxEnrerName.Text;
            }
            TextBlockHello.Text = $"{hello} {input}";
        }       
    }
}
