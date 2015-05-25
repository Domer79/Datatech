using System.ComponentModel;
using System.Windows;

namespace Test.Wpf
{
    internal class StateMachineActionDispatcher
    {
        void Start()
        {
            var application = new Application();
            Program.StateMachine.ChangeState("Form1Open");
        }

        void Form1Open(Application application)
        {
            application.Run(new MainWindow());
            Program.StateMachine.ChangeState("Page1");
        }

        void Page1()
        {
            
        }

        void Form1Btn1Click(MainWindow mainWindow)
        {
            Program.StateMachine.ChangeState("Form1Btn2Enabled", mainWindow);
        }

        private void Form1Btn2Enabled(MainWindow mainWindow)
        {
            mainWindow.Btn2.IsEnabled = true;
            Program.StateMachine.ChangeState("Page1");
        }

        void Exit(CancelEventArgs e)
        {
            
        }
    }
}