using DJApp.Controller;
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

namespace DJApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        BeatController _controller;
        public MainWindow()
        {
            InitializeComponent();
            _controller = Resources["Controller"] as BeatController;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _controller.on();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            _controller.increaseBPM();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            _controller.off();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            _controller.decreaseBPM();
        }


        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            
            if (int.TryParse(Input_BPM.Text, out int new_bpm))
            {
                if(_controller.Status == "Music is playing")
                {
                    _controller.BPM = new_bpm;
                }               
                Input_BPM.Text = "";
            }
        }
    }
}
