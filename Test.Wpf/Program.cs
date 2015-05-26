using System;
using System.Windows;

namespace Test.Wpf
{
    class Program
    {
        [STAThread]
        public static void Main()
        {
            var application = new Application();
            application.Run(new MainWindow());
        }
    }
}
