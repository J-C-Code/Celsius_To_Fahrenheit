using Avalonia.Controls;
using Avalonia.Interactivity;
using System;
using System.Diagnostics;

namespace MyApp
{
    public partial class MainWindow : Window
    {
        // Start Main Window of Program (MyApp > MainWindow.axaml)
        public MainWindow()
        {
            InitializeComponent();
        }

        public void ButtonClicked(object source, RoutedEventArgs args)
        {
            if (Double.TryParse(celsius.Text, out double C))
            {
                var F = C * (9d / 5d) + 32;
                fahrenheit.Text = F.ToString("0.0");
            }
            else
            {
                celsius.Text = "0";
                fahrenheit.Text = "0";
            }
        }
    }
}
