using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Test.Wpf.Interfaces;

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
