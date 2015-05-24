using System.ComponentModel;
using System.Windows;

namespace Test.Wpf
{
    internal class StateMachineActionDispatcher
    {
        void Start()
        {
            var application = new Application();
            application.Run(new MainWindow());
        }

        void Btn1Click(MainWindow mainWindow)
        {
            mainWindow.Btn2.IsEnabled = true;
        }

        void Exit(CancelEventArgs e)
        {
            
        }
    }
}