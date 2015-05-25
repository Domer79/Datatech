using System;
using System.Collections.Generic;
using System.Configuration;
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
using Test.Wpf.ConfigurationSections;

namespace Test.Wpf
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Closing += MainWindow_Closing;
        }

        void MainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Program.StateMachine.ChangeState("Start", "Exit", e);
        }

        private void Btn1_Click(object sender, RoutedEventArgs e)
        {
            Program.StateMachine.ChangeState("Start", "Form1Btn1Click", this);
        }

        private void Btn2_Click(object sender, RoutedEventArgs e)
        {
            Program.StateMachine.ChangeState("Form1Btn1Click", "Form1Btn2Click");
        }
    }
}
