using System.Windows;
using Test.Wpf.Infrastructure.StateMachine;
using Test.Wpf.Infrastructure.StateMachine.Events;

namespace Test.Wpf
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool _btn1Clicked;

        public MainWindow()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded;
        }

        void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            Tools.StateMachine = new StateMachine(new StartupEvent());
        }

        private void Btn1_Click(object sender, RoutedEventArgs e)
        {
            if (_btn1Clicked)
                return;
           
            Tools.StateMachine.ChangeState<MainWindowButton1ClickEvent>(this);
            _btn1Clicked = true;
        }

        private void Btn2_Click(object sender, RoutedEventArgs e)
        {
            Tools.StateMachine.ChangeState<MainWindowButton2ClickEvent>(this);
        }
    }
}
