using System.Windows;
using System.Windows.Input;
using Test.Wpf.Infrastructure.StateMachine.Events;

namespace Test.Wpf
{
    /// <summary>
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        private bool _textBox1TextChanged;
        private bool _textBox2IsHello;

        public Window2()
        {
            InitializeComponent();
        }

        public MainWindow MainWindow { get; set; }

        private void TextBox1_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if (_textBox1TextChanged) 
                return;

            Tools.StateMachine.ChangeState<Window2TextBox1EnterTextEvent>(this);
            _textBox1TextChanged = true;
        }

        private void TextBox2_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if (!_textBox1TextChanged)
                return;

            if (_textBox2IsHello)
                return;

            if (TextBox2.Text != "hello")
                return;

            Tools.StateMachine.ChangeState<Window2TextBox2EnterHelloEvent>(this);
            _textBox2IsHello = true;
        }

        private void Btn3_Click(object sender, RoutedEventArgs e)
        {
            if (!_textBox1TextChanged || !_textBox2IsHello)
                return;

            Tools.StateMachine.ChangeState<Window2Button3ClickEvent>(this);
        }
    }
}
